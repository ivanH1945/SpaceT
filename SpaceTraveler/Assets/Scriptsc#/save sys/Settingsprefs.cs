using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingsprefs
{
    public float musicvolume;
    public float sfxVolume;
    public string playername;

    public Settingsprefs(Optionsmenu settings) 
    {
        musicvolume = settings.musicvolume;
        sfxVolume = settings.sfxVolume;
        playername = settings.playername;
    }
}
