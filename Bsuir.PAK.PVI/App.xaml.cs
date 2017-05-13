using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Windows;
using Bsuir.PAK.PVI.DataServices.Services;
using Ninject;

namespace Bsuir.PAK.PVI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Bind<MainWindow>().ToSelf();
            var view = kernel.Get<MainWindow>();
            view.Show();
        }
        
    }
}
