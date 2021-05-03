package se.anbe1507miun.bathingsites;

import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.util.AttributeSet;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;

/**
 * Created by angelika on 2017-05-07.
   * anbe1507 angelika doxakis berg
 * applikationsutveckling för android vt 2017
 * anbe1507@student.miun.se
 * Konstruktorn hämtar textview från layouten och ställer in text stl, fetstil samt färg. använder en setSites för att sätta antalet
 * badplatser till en medlem för att sedan i getSites set texten till textviewn med antalet badplatser.
 */

public class BathingSitesView extends LinearLayout implements View.OnClickListener {

    TextView bathingsites;
    private int num = 0;

    BathingSitesView(Context context, AttributeSet set){
        super(context, set);
        inflate(context, R.layout.bathingsitesview, this);

        bathingsites = (TextView)findViewById(R.id.textView);
        bathingsites.setTextSize(20);
        bathingsites.setTypeface(null, Typeface.BOLD);
        bathingsites.setTextColor(Color.BLACK);
    }

    public void setSites(int i){
        num = i;
    }

    public void getSites(){
        bathingsites.setText( num +" "+ getResources().getString(R.string.bathingsites));
    }

    @Override
    public void onClick(View v) {

    }
}
