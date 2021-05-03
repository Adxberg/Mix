package se.anbe1507miun.bathingsites;

import android.graphics.Color;
import android.graphics.Typeface;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

/**
 * Created by angelika on 2017-05-07.
 * anbe1507 angelika doxakis berg
 * applikationsutveckling för android vt 2017
 * anbe1507@student.miun.se
 * Bathingsitesframgen, genom onViewCreated så uppdateras räknaren för badplatser varje gång huvudsidan laddas där Bathingsites finns
 * först set antalet badplatser som finns genom funktionen getRows. och sedan getSites för o sätta antalet.
 */

public class BathingSitesFragment extends android.support.v4.app.Fragment {

    private Database db;
    public BathingSitesFragment(){}

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        db = new Database(getActivity());
        return  inflater.inflate(R.layout.bathingsitesfragment, container, false);

    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState){
        super.onViewCreated(view, savedInstanceState);

        BathingSitesView bsv = (BathingSitesView) view.findViewById(R.id.headpage);
        bsv.setSites(db.getRows());

        bsv.getSites();
    }
}
