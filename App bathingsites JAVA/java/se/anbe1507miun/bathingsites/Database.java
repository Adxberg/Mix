package se.anbe1507miun.bathingsites;

import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;
import android.widget.EditText;
import android.widget.RatingBar;
import android.widget.Toast;

/**
 * Created by angelika on 2017-05-17.
 * anbe1507 angelika doxakis berg
 * applikationsutveckling för android vt 2017
 * anbe1507@student.miun.se
 */

public class Database extends SQLiteOpenHelper {

    private static final int VERSION = 1;
    private static final String NAME = "Bathingsites";
    Context c;
    SQLiteDatabase db;


    public Database(Context context){
    super(context,NAME, null, VERSION);
        c = context;
    }
/*
* När Databasen skapas skapas en table med en query.
 */
    @Override
    public void onCreate(SQLiteDatabase sql){

        sql.execSQL("create table "+NAME+"( _id integer primary key autoincrement, name text, adress text, description text, longitude text, latitude text, rating text, temp text, date text);");
        Log.i("Database", "Created");
    }

    @Override
    public void onUpgrade(SQLiteDatabase sql, int i , int j){

    }
/*
* Funktion för att spara badplatser. tar ett visst antal strängar för att sätta in på korrekt plats i databasen med en query.
 */
    public void Save(String name, String adress, String description, String longitude, String latitude, String rate, String temp, String date ){
        db = getWritableDatabase();
        db.execSQL("insert into " + NAME+"(name, adress, description, longitude, latitude, rating, temp, date) values('"+name+"', '"+adress+"', '"+description+"', '"+longitude+"' , '"+latitude+"', '"+rate+"', '"+temp+"', '"+date+"');");
    }

    /*
    *Funktion som kollar om en badplats redan finns sparad genom att jämföra longitude och latitude med sparade koordinater.
    * Kollar med en query som sätts till en Cursor. om Cursorn inte har ngn träff returneras false annars true
     */
    public boolean exists(String longi, String lat){
        db = getReadableDatabase();
        Cursor curse = db.rawQuery("Select longitude , latitude from "+NAME+" where longitude = '"+longi+"' and latitude = '"+lat+"'", null);
        if(curse.getCount()<=0){
            curse.close();
            return false;
        }
        curse.close();
        return true;
    }

    /*
    * Med hjälp av en query som sätts till en Cursor så hämtas antalet sparade badplatser.
     */
    public int getRows(){
        db = getWritableDatabase();
       Cursor curse =  db.rawQuery("Select * from " +NAME, null);
        int count = curse.getCount();
        curse.close();
        return count;
    }
}
