package se.anbe1507miun.bathingsites;

import android.content.Context;
import android.content.SharedPreferences;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.FileReader;

/**
 * Created by angelika on 2017-05-24.
 */

 public class HandleFile {

    String longi, lat, name, adress;
    private FileReader read;
    private String s;
    private String splitMe = ",";
    private Database db;
    private View view;

    HandleFile(String s, Context context){
        try{

           db = new Database(context);
            read = new FileReader(s);
           getStrings(new BufferedReader(read));
        }
        catch(Exception e){
            e.printStackTrace();
        }
    }

    /*
    * För varje rad som läses in, plocka ut alla " samt dela vid , anropa sedan filehandler() med resulterande rad i arrayen
     */
    public void getStrings(BufferedReader buff) {
        try {
            while ((s = buff.readLine()) != null) {
               String[] info;
               s = s.replaceAll("\"", "");
                      info = s.split(splitMe);
                filehandler(info);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

    }
/*
* placera värden till olika strängar beroende på placering i raden. kolla sedan om det finns fler värden är 3 och placera resterande till adress på så sätt som det är skrivet
* som om den är prick 4 lång, lägg adressen till adress. om den är över 4 så står de adress, ort. placera då till adress med just ett komma emellan
* annars en tom sträng
* skicka in värdena till en anrop av Save i databasen om den inte existerar redan.
 */
    public void filehandler(String[] info){

            longi = String.valueOf(info[0]);
            lat = String.valueOf(info[1]);
            name = String.valueOf(info[2]);
            Log.i("Longitude", info[0]);
            Log.i("Latitude", info[1]);

            if(info.length == 4) {
                adress = String.valueOf(info[3]);
            }if(info.length > 4) {
                adress = String.valueOf(info[3] + "," + info[4]);
            }if(info.length < 4)
            {
                adress = "";
            }

            if(!db.exists(longi, lat)){
                        db.Save(name, adress, "", longi, lat, "", "", "");
                    }
        }
    }

