using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TribalWars
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            TribalWarsBootstrapper bootstrapper = new TribalWarsBootstrapper();
            bootstrapper.Run();
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }
}
