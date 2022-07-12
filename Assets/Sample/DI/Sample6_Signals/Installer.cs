using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.DeclareSignal<MessageSignal>();
        Container.Bind<MessageSubscriber>().AsSingle();
        Container.BindSignal<MessageSignal>().ToMethod<MessageSubscriber>(x => x.RecieveMessage).FromResolve();

    }
}
