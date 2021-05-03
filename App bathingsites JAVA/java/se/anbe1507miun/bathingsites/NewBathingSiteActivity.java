package se.anbe1507miun.bathingsites;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.text.Html;
import android.text.TextUtils;
import android.util.Log;
import android.util.Patterns;
import android.view.Menu;
import android.view.MenuItem;
import android.webkit.URLUtil;
import android.widget.EditText;
import android.widget.RatingBar;
import android.widget.Toast;
import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static se.anbe1507miun.bathingsites.R.xml.preferences;

public class NewBathingSiteActivity extends AppCompatActivity {

    EditText name, adress, description, longitude, latitude, temp, date;
    RatingBar rate_bar;
    String CorrectUrl = "";
    String secondPart ="?location=";
    String thirdPart =  "&language=SW";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_new_bathing_site);

        name = (EditText) findViewById(R.id.name);
        adress = (EditText) findViewById(R.id.adress);
        description = (EditText) findViewById(R.id.description);
        longitude = (EditText) findViewById(R.id.longitude);
        latitude = (EditText) findViewById(R.id.latitude);
        temp = (EditText) findViewById(R.id.watertemp);
        date = (EditText) findViewById(R.id.dateoftemp);
        rate_bar = (RatingBar)findViewById(R.id.ratingBar);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        PreferenceManager.setDefaultValues(this, preferences, false);

    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_new_bathing_site, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        // Om användaren vill rensa så rensas alla fält med hjälp av clear, avslutas med en informativ toast
        if (id == R.id.action_clear) {

            name.setText("");
            adress.setText("");
            description.setText("");
            longitude.setText("");
            latitude.setText("");
            rate_bar.setRating(0);
            temp.setText("");
            date.setText("");

            Toast.makeText(this, "Cleared", Toast.LENGTH_LONG).show();
            return true;
        }
/* om användaren vill spara en badplats kollas först att alla obligatoriska gält är ifyllda. annars vissas ett error och användaren kan inte fortsätta.
* om allt är ifyllt enligt krav så skapas en ny databas objekt. värden från fälten inhämtas och sets till strängar. Om badplatsen finns efter ha kollats mot latitude och longitude
 * så meddelas användaren om detta med en toast, annars sparas badplatsen och alla fält nollställs samt att användaren förs tillbaka till huvudsidan med en uppdaterad räknare.
 */
        if (id == R.id.action_save) {

            if (name.getText().toString().matches("")) {
                name.setError("!");
            }
            if (adress.getText().toString().matches("")) {
                adress.setError("!");
            }
            if (longitude.getText().toString().matches("")) {
                longitude.setError("!");
            }
            if (latitude.getText().toString().matches("")) {
                latitude.setError("!");
            }
            else if(!name.getText().toString().matches("") && !adress.getText().toString().matches("") && !longitude.getText().toString().matches("") && !latitude.getText().toString().matches("")) {

                Database db = new Database(this);

                String longi = longitude.getText().toString();
                String lat = latitude.getText().toString();
                String rate = String.valueOf(rate_bar);
                String n = name.getText().toString();
                String a = adress.getText().toString();
                String d = description.getText().toString();
                String t = temp.getText().toString();
                String da = date.getText().toString();


               if(db.exists(longi, lat)){
                   Toast.makeText(this, R.string.exists, Toast.LENGTH_LONG).show();
               }
               else{
                   db.Save(n, a, d, longi, lat, rate, t, da);
                   Toast.makeText(this, R.string.Saved, Toast.LENGTH_LONG).show();

                   name.getText().clear();
                   adress.getText().clear();
                   description.getText().clear();
                   longitude.getText().clear();
                   latitude.getText().clear();
                   rate_bar.setRating(0);
                   temp.getText().clear();
                   date.getText().clear();
               }

                Intent intent  = new Intent(getApplicationContext(), MainActivity.class);
                intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                startActivity(intent);
            }
                return true;
            }

            /*
            * Vill användaren kolla vädre kontrolleras först att obligatoriska fält är ifyllda annars skickas ett error och inge mer sker. annars så Hämtas strängar och
            * sets ihop till en lång sträng som ska vara urlen. detta för om användaren modifierat defualt adressen på ngt sätt. sen skapas objektet Wheather
             */
        if (id == R.id.action_weather) {

            SharedPreferences pref = PreferenceManager.getDefaultSharedPreferences(getBaseContext());
            String weatherurl = pref.getString("weatherurl", "");

            if(longitude.getText().toString().matches("") && latitude.getText().toString().matches("") && adress.getText().toString().matches("")){
                longitude.setError("!");
                latitude.setError("!");
                adress.setError("!");
            }else {

                if (TextUtils.isEmpty(longitude.getText().toString()) && TextUtils.isEmpty(latitude.getText().toString())) {
                    CorrectUrl = weatherurl + secondPart + adress.getText().toString() + thirdPart;
                } else {
                    CorrectUrl = weatherurl + secondPart + latitude.getText().toString() + "|" + longitude.getText().toString()+ thirdPart;
                }
                Log.i("Correcturl: ", CorrectUrl);
                new Weather().execute();
            }
            return true;
        }
      /*
        * vill användaren ladda ner badplatser så skapas objektet DownLoadWebView
         */
        if(id == R.id.action_download){
            Intent intent = new Intent(this, DownloadWebView.class);
            startActivity(intent);
            return true;
        }
       if(id == R.id.action_settings){
           Intent intent = new Intent(this, Settings.class);
           startActivity(intent);
           return true;
       }
            return super.onOptionsItemSelected(item);
        }

    // Klass för att hämta väder med hjälp av AsyncTask
     private class Weather extends AsyncTask<Void, Integer, Void>{
         ProgressDialog progress;
         int countProgress= 0;
         String [] info;
         String urlImage = "";
         Drawable pic;

//Först skapas en progressdialog
         @Override
         protected void onPreExecute(){
             progress = new ProgressDialog(NewBathingSiteActivity.this);
             progress.setTitle(getString(R.string.download));
             progress.setMessage(getString(R.string.progress));
             progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
             progress.show();
            progress.setCancelable(false);
         }

         // Om processen i background avbryts kommer man till denna som avbryter arbetet och sänder ut en toast
        @Override
        protected void onCancelled() {
            super.onCancelled();
            progress.cancel();
            Toast.makeText(NewBathingSiteActivity.this, "ERROR, wrong URL or location", Toast.LENGTH_LONG).show();
        }

        // i bakgrunden....
         @Override
         protected Void doInBackground(Void... params) {
             String s = null;
             URL url = null;
             String res = "";
             int response;
             try {

                if(!URLUtil.isValidUrl(CorrectUrl)){
                    cancel(true);
                }
                 // Skapar en url me att hämta medlemsvariabeln CorrectUrl som har en url skapad från sharedpreferences
                 url = new URL(CorrectUrl);

                 //kollar om urlen är giltig, om inte så avbryts processen.
                 HttpURLConnection connect = (HttpURLConnection) url.openConnection();
                 if(connect.getResponseCode() != HttpURLConnection.HTTP_OK) {
                     cancel(true);
                 }
                     BufferedReader reader = new BufferedReader(new InputStreamReader(connect.getInputStream()));
                     StringBuilder builder = new StringBuilder();


                     // Medan information hämtas, öka räknaren med ett steg, anävnd en stringbuilder för att sätta ihop en sträng med ny rad för varje värde
                     // publicera progress med räknaren
                     while ((s = reader.readLine()) != null) {
                         res += s;
                         if (s.contains("null")) {
                             cancel(true);
                         }
                         countProgress++;

                         builder.append(s + "\n");
                         publishProgress(countProgress);
                     }
                     // placera nya strängen i en array och splitta vid varje br
                     info = builder.toString().split("<br>");
                     // Hämta länken till bilden som ska symbolisera vädret ur informationen som inhämtats
                     urlImage = String.valueOf(info[8].substring(info[8].indexOf(':') + 1));

             } catch (Exception e) {
                 cancel(true);
                 e.printStackTrace();
             }
// Sätt rätt bild till en image. om image skulle uteblivit för den inte finns(som i Uppsala), sätt då en bild som visar att bild inte kunnats hämta
             pic = Image(urlImage);
            if(pic == null){ pic = getResources().getDrawable(R.drawable.errorweather);

            }

             return null;
         }

         @Override
         protected void onProgressUpdate(Integer... values){
             progress.setProgress(values[0]);

         }

         @Override
         protected void onPostExecute(Void result){
            String results = new String();
             Double temp = 0.0;
            String Current = getString(R.string.Current);
             String City = "";
            String degree = getString(R.string.degree);
// stäng dialoguppdateringen
             progress.dismiss();

             //skapa en alertdialog som visar information om den plats man sökt med koordinater. visa stad, och temperatur
            AlertDialog.Builder popup = new AlertDialog.Builder(NewBathingSiteActivity.this);

             temp = Double.valueOf(info[4].substring(info[4].indexOf(':')+1));
             City = String.valueOf(info[0].substring(info[0].indexOf(':')+1));

             // lägg till gradtecken till strängen för temp
             results = "\n" + temp.toString() + degree;

             // piffa alertdialogen me en titel, skriv ut informationen, och sätt bilden
             popup.setTitle(Current);
             popup.setMessage(Html.fromHtml("<br>" + "<br>" + City + "<br>" + "<i>" + results  + "</i>" ));
             popup.setIcon(pic);
             popup.setCancelable(true);

             popup.setPositiveButton(
                     R.string.OK,
                     new DialogInterface.OnClickListener() {
                         public void onClick(DialogInterface ok, int id) {
                             ok.cancel();
                         }
                     });
             AlertDialog alert = popup.create();
             alert.show();

         }

    }
// funktion för och hämta korrekt bild
    public Drawable Image(String url){
        try {
            // Använd urlen som är medskickad, koppla upp till den och hämta bilden. returnera en färdig drawable från bitmap
        URL adress = new URL(url);
            HttpURLConnection connect = (HttpURLConnection)adress.openConnection();
            connect.setDoInput(true);
            connect.connect();
            InputStream input = connect.getInputStream();

            BitmapFactory.Options options = new BitmapFactory.Options();
            options.inJustDecodeBounds = true;
            Bitmap image = BitmapFactory.decodeStream(input);

            return new BitmapDrawable(image);
        }
        catch(Exception e){
            return null;
        }
    }
}

