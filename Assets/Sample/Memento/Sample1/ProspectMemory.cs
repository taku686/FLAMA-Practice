using UnityEngine;

namespace Sample.Memento.Sample1
{
    public class ProspectMemory
    {
        private Memento _memento;

        public Memento Memento
        {
            set => _memento = value;
            get => _memento;
        }
    }
}