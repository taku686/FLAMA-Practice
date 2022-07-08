using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscJockey 
{
    protected SongComponent _songList;

    public DiscJockey(SongComponent songList)
    {
        _songList = songList;
    }

    public void GetSongList()
    {
        _songList.DisplaySongInformation();
    }
}
