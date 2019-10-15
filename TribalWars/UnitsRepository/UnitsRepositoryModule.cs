using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace UnitsRepository
{
    public class UnitsRepositoryModule :IModule
    {
        private readonly IUnityContainer _unityContainer;
        public UnitsRepositoryModule(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Console.WriteLine("OnInitialized");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Axe>();
        }
    }
}
