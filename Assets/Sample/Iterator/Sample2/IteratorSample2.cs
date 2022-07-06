using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteratorSample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collection collection = new Collection();
        collection[0] = new Item("Item 0");
        collection[1] = new Item("Item 1");
        collection[2] = new Item("Item 2");
        collection[3] = new Item("Item 3");
        collection[4] = new Item("Item 4");
        collection[5] = new Item("Item 5");
        collection[6] = new Item("Item 6");
        collection[7] = new Item("Item 7");
        collection[8] = new Item("Item 8");

        Iterator2 iterator = collection.CreateIterator();

        iterator.Step = 2;

        Debug.Log("Iterating Collection");

        for (Item item = iterator.First(); !iterator.isDone; item = iterator.Next())
        {
            Debug.Log(item.Name);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}