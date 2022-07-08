using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Zenject;

public class InputForMove : MonoBehaviour
{
    [Inject] private IInputtable _inputObject;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputObject != null)
        {
            Move((_inputObject.InputForMove()));
        }
    }


    private void Move(Vector3 vec)
    {
        var position = transform.localPosition;
        transform.localPosition = position + vec * 0.1f;
    }
}