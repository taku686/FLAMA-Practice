using System;
using UnityEngine;

namespace Sample.Memento.Sample1
{
    public class MementoSample1 : MonoBehaviour
    {
        private void Start()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Bruce";
            s.Phone = "(412) 256-6666";
            s.Budget = 25000.0;

            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Oliver";
            s.Phone = "(310) 209-8888";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);
        }
    }
}