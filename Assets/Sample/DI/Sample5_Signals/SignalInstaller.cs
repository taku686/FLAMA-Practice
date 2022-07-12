using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

namespace DI.Sample5
{
    public class SignalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            Container.DeclareSignal<PauseSignal>();
            Container.DeclareSignal<ResumeSignal>();
            Container.BindSignal<PauseSignal>().ToMethod<Player>(p => p.OnPause).FromResolve();
            Container.BindSignal<ResumeSignal>().ToMethod<Player>(p => p.OnResume).FromResolve();
        }
    }
}