package se.anbe1507miun.bathingsites;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.webkit.DownloadListener;
import android.webkit.WebResourceRequest;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Toast;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
 /* anbe1507 angelika doxakis berg
         * applikationsutveckling för android vt 2017
         * anbe1507@student.miun.se*/
public class DownloadWebView extends AppCompatActivity {

    private WebView web;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_download_web_view);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

       /* FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });*/
        web = (WebView)findViewById(R.id.webView);
        SettingWeb();
        web.setWebViewClient(new WebClient());
    }
/*
* Hämtar den sparade urlen för weburl. Den har en default som användare kan tänkas ändras. Så nuvarande url hämtas av sharedpreferences
 */
    public void SettingWeb(){
        SharedPreferences pref = PreferenceManager.getDefaultSharedPreferences(getBaseContext());
        String downloading = pref.getString("weburl", "");

        web.loadUrl(downloading);
    }

    /*
    * intern klass för webview, extenderar webviewclient, skapar klassen SaveToDatabase vid konstruktion
     */
    public class WebClient extends WebViewClient implements DownloadListener {
        @Override
        public void onDownloadStart(String url, String userAgent, String contentDisposition, String mimetype, long contentLength) {

            new SaveToDatabase().execute(url);
        }

        @Override
        public boolean shouldOverrideUrlLoading(WebView view, WebResourceRequest req){
            view.setDownloadListener(this);
            return false;
        }
    }

    /*
    * SaveToDatabase extenderar AsyncTask och gör vad namnet säger, sparar till databas det som ska laddas ner från länk
     */
    private class SaveToDatabase extends AsyncTask<String, Integer, Void> {
        ProgressDialog progress;
        int countProgress = 0;
        String[] info;
        File input;

        /*
        * innan start skapas en progressdialog
         */
        @Override
        protected void onPreExecute() {
            progress = new ProgressDialog(DownloadWebView.this);
            progress.setTitle(getString(R.string.loadfile));
            progress.setMessage(getString(R.string.progress));
            progress.setProgressStyle(ProgressDialog.STYLE_SPINNER);
            progress.show();
            progress.setCancelable(false);
        }

        /*
        * under nedladdning
         */
        @Override
        protected Void doInBackground(String... params) {
            int i;
            URL url = null;
            String res = "";
            String path = params[0];
            String filename = "skrap";
            input = new File(getExternalCacheDir(), filename);
            byte[] byteData = new byte[1024];

            try {

                url = new URL(path); // urlen blir den urplockade filnamnet
                // Påbörjar sedan nedladdning med olika strömmar
                HttpURLConnection connect = (HttpURLConnection) url.openConnection();

                BufferedInputStream reader = new BufferedInputStream(connect.getInputStream());
                FileOutputStream output= new FileOutputStream(input);
                BufferedOutputStream outstream = new BufferedOutputStream(output, 1024);

                // medan det finns att hämta så öka räknaren med 1 steg för varje steg
                while ((i = reader.read(byteData, 0, 1024)) >= 0) {
                    countProgress++;
                    outstream.write(byteData, 0, i);
                    //publishProgress(countProgress);
                }
                outstream.close(); // stäng strömmen

                // skapa klassen HandleFile för att hantera innehållet
                HandleFile handle = new HandleFile(input.getAbsolutePath(), DownloadWebView.this);

            } catch (Exception e) {
                e.printStackTrace();
            }
            return null;
        }

        @Override
        protected void onProgressUpdate(Integer... values) {
            progress.setProgress(values[0]);

        }

        @Override
        protected void onPostExecute(Void result) {
/*
* stäng progressdialogen, visa en toast att det är sparat och ta användaren tillbaka till huvudsidan
 */
            input.delete();
            progress.dismiss();
            Toast.makeText(DownloadWebView.this, "Bathingsites saved", Toast.LENGTH_LONG).show();

            Intent intent  = new Intent(getApplicationContext(), MainActivity.class);
            intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            startActivity(intent);
        }
    }
}



