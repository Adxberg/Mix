package se.anbe1507miun.bathingsites;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
/*
*anbe1507 angelika doxakis berg
 */

public class Settings extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        getFragmentManager().beginTransaction().replace(android.R.id.content, new Setting_menu_fragment()).commit();

    }
}
