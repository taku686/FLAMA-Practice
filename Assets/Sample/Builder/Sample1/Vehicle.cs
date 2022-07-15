using System.Collections.Generic;
using UnityEngine;

namespace Sample.Builder.Sample1
{
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }
        
        public void Show()
        {
            Debug.Log("\n---------------------------");
            Debug.Log("Vehicle Type: " + _vehicleType);
            Debug.Log(" Frame : " + _parts["frame"]);
            Debug.Log(" Engine : " + _parts["engine"]);
            Debug.Log(" #Wheels: " + _parts["wheels"]);
            Debug.Log(" #Doors : " + _parts["doors"]);
        }
    }
}