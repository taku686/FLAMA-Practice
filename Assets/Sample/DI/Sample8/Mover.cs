using System;
using UnityEngine;

namespace Sample.DI.Sample8
{
    public class Mover : MonoBehaviour
    {
        private void Update()
        {
            var hori = Input.GetAxis("Horizontal");
            var vert = Input.GetAxis("Vertical");
            if (hori != 0 || vert != 0)
            {
                transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))*0.01f;
            }
        }
    }
}