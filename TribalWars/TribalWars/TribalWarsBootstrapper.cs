using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TribalWars.ViewModel;

namespace TribalWars
{
    public class TribalWarsBootstrapper :UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(UnitsRepository.UnitsRepositoryModule));

        }

        protected override DependencyObject CreateShell()
        {
            // Use the container to create an instance of the shell.
            Shell view = this.Container.TryResolve<Shell>();
            view.DataContext = new ShellViewModel();
            return view;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();
            return factory;
        }
    }
}
