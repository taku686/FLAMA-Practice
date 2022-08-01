using System;

namespace ShootingGame.Scripts.Damage
{
    public readonly struct Damage : IEquatable<Damage>
    {
        public int DamageValue { get; }

        public Damage(int value)
        {
            DamageValue = value;
        }

        public bool Equals(Damage other)
        {
            return DamageValue == other.DamageValue;
        }

        public override bool Equals(object obj)
        {
            return obj is Damage other && Equals(other);
        }
    }
}
