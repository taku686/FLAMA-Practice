using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SongComponent
{
    public virtual void Add(SongComponent component)
    {
    }

    public virtual void Remove(SongComponent component)
    {
    }

    public virtual SongComponent Get(int index)
    {
        return null;
    }

    public abstract void DisplaySongInformation();
}