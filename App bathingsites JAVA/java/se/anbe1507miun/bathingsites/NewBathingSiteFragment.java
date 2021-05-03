package se.anbe1507miun.bathingsites;

import android.support.v4.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

/**
 * A placeholder fragment containing a simple view.
 * anbe1507 angelika doxakis berg
 * applikationsutveckling för android vt 2017
 * anbe1507@student.miun.se
 */
public class NewBathingSiteFragment extends Fragment {

    public NewBathingSiteFragment() {
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        return inflater.inflate(R.layout.fragment_new_bathing_site, container, false);
    }
}
