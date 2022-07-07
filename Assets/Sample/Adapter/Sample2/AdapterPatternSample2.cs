using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterPatternSample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Compound unknown = new Compound("Unknown");
        unknown.Display();
        Compound water = new RichCompound("Water");
        water.Display();
        Compound benzene = new RichCompound("Benzene");
        benzene.Display();
        Compound ethanol = new RichCompound("Ethanol");
        ethanol.Display();
    }
}