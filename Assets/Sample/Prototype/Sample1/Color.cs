using UnityEngine;

namespace Sample.Prototype.Sample1
{
    public class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        public Color(int red,int green,int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
        
        public override ColorPrototype Clone()
        {
            Debug.Log("Cloning color RGB: (" + _red + " ," + _green + "," + _blue + ")");

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}