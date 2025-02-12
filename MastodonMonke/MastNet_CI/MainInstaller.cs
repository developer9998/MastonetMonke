﻿using ComputerInterface.Interfaces;
using Zenject;

namespace MastodonMonke.MastNet_CI
{
    internal class MainInstaller : Installer
    {
        public override void InstallBindings()
        {
            // Bind your mod entry like this
            Container.Bind<IComputerModEntry>().To<MastEntry>().AsSingle();
        }
    }
}