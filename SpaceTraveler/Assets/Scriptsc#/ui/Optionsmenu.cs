using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optionsmenu : MonoBehaviour
{
    public float musicvolume;
    public float sfxVolume;
    public string playername;
    GameObject[] musichandlers;

    public void savesettings() 
    {
        SistemaDeGuardado.savesettings(this);
      
    }
    public void loadsettings() 
    {
        Settingsprefs prefs = SistemaDeGuardado.loadsettings();
        musicvolume = prefs.musicvolume;
        sfxVolume = prefs.sfxVolume;
        playername = prefs.playername;
        if (prefs == null) 
        {
            savesettings();
        }

    }
    public void setvolume(){
        float musicvolumee=0;

        musichandlers = GameObject.FindGameObjectsWithTag("musichandler");
        foreach (GameObject music in musichandlers) 
        {
            music.GetComponent<AudioSource>().volume = musicvolumee;
        }

    }
    
}
