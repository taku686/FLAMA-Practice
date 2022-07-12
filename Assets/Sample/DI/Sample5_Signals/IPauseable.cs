using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DI.Sample5
{
    public interface IPauseable
    {
        void OnPause(PauseSignal signal);
        void OnResume(ResumeSignal signal);
    }
}