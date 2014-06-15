using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KursWalter.Core.Persistence;
using KursWalter.Core.Interfaces;

namespace KursWalter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            // Composition root

            //ToDo: Datenbankverbindung einfügen
            
            
            //ToDo: wenn connection, dann nötige Objekte Initialisieren und daten aus db laden


            var mainwindow = new MainWindow();

            // show mainwindow

            MainWindow = mainwindow;
            MainWindow.Show();

        }
    }
}
