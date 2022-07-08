using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : SongComponent
{
    public string _songName { get; protected set; }
    public string _bandName { get; protected set; }
    public int _releaseYear { get; protected set; }

    public Song(string name, string band, int year)
    {
        _songName = name;
        _bandName = band;
        _releaseYear = year;
    }

    public override void DisplaySongInformation()
    {
        Debug.Log("Song of " + _songName + " - " + _bandName + " : " + _releaseYear);
    }
}