using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
     public Text _score;
     public int _totalScore;

    private void Start()
    {
        _score.text = 0.ToString();
        
    }
}
