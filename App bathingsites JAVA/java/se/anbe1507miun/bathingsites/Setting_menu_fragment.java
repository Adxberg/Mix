package se.anbe1507miun.bathingsites;

import android.content.Context;
import android.content.SharedPreferences;
import android.net.Uri;
import android.os.Bundle;
import android.preference.Preference;
import android.preference.PreferenceFragment;
import android.preference.PreferenceManager;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

/*
* anbe1507
* angelika doxakis berg
* Klass för sharedpreferences som ser till att den angivna adressen för väderweb och nedladdning finns tillgänglig på båda aktiviteterna
* samt att rätt adress hämtas till AsyncTask när det är dags
 */

public class Setting_menu_fragment extends PreferenceFragment implements SharedPreferences.OnSharedPreferenceChangeListener {

    private String web, weather;

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        addPreferencesFromResource(R.xml.preferences);
        SharedPreferences pref = PreferenceManager.getDefaultSharedPreferences(getActivity());
        Preference webPref = findPreference("weburl");
        webPref.setSummary(pref.getString("weburl", getString(R.string.downloadingdefault)));
        pref.registerOnSharedPreferenceChangeListener(this);
    }

    @Override
    public void onSharedPreferenceChanged(SharedPreferences sharedPreferences, String key) {

        if(key.equals(web)){
            Preference web = findPreference(key);
            web.setSummary(sharedPreferences.getString(key, ""));
        }
        if(key.equals(weather)){
            Preference weather = findPreference(key);
            weather.setSummary(sharedPreferences.getString(key, ""));
        }
    }
}
