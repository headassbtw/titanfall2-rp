using System;
using System.Threading;
using Eto.Drawing;
using Eto.Forms;
using titanfall2_rp;

namespace CrossPlatUI
{
    class Program
    {
        public static Application App;
        public static Icon Icon;
        public static MainWindow MainWindow;
        public static TrayIcon TrayIcon;
        public static Command QuitCommand;
        public static Command ShowCommand;
        public static RichPresenceManager Manager;
        public static Thread RPCThread;
        static void Main(string[] args)
        {
            App = new Application();
            Icon = Eto.Drawing.Icon.FromResource("CrossPlatUI.tf2rp.png");
            MainWindow = new MainWindow();
            TrayIcon = new TrayIcon(MainWindow);
            Manager = new();
            RPCThread = new Thread(async => Manager.Begin());
            RPCThread.Start();
            App.Run();
            QuitCommand = new Command();
            ShowCommand = new Command();
            QuitCommand.Executed += (sender, eventArgs) =>
            {
                App.Quit();
                Manager.Stop();
            };
            ShowCommand.Executed += (sender, eventArgs) =>
            {
                //most of these are just brute force, feel free to find what doesn't do anything and remove it
                MainWindow.ShowInTaskbar = true;
                MainWindow.ShowActivated = true;
                MainWindow.WindowState = WindowState.Normal;
                MainWindow.Show();
            };
            
            
            
            
            
            
            TrayIcon.Populate();
        }
    }
}