using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongGroup : SongComponent
{
    protected List<SongComponent> _components = new List<SongComponent>();
    public string _groupName { get; protected set; }

    public string _groupDescription { get; protected set; }

    public SongGroup(string name, string description)
    {
        _groupName = name;
        _groupDescription = description;
    }

    public override void Add(SongComponent component)
    {
        _components.Add(component);
    }

    public override void Remove(SongComponent component)
    {
        _components.Remove(component);
    }

    public override SongComponent Get(int index)
    {
        return _components[index];
    }

    public override void DisplaySongInformation()
    {
        Debug.Log(_groupName + " - " + _groupDescription);
        IEnumerator iterator = _components.GetEnumerator();
        while (iterator.MoveNext())
        {
            SongComponent songComponent = (SongComponent)iterator.Current;
            songComponent.DisplaySongInformation();
        }
    }
}