using UnityEngine;

namespace Sample.Memento.Sample3
{
    public class ProspectMemory
    {
        private Memento _memento;

        public Memento Memento
        {
            get => _memento;
            set => _memento = value;
        }
    }
}