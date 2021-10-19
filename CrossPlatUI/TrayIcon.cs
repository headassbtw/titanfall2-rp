using Eto.Forms;

namespace CrossPlatUI
{
    public class TrayIcon
    {
        private TrayIndicator Indicator;
        public ContextMenu Menu;
        public TrayIcon(MainWindow window)
        {
            Indicator = new TrayIndicator();
            Indicator.Image = Program.Icon;
            Indicator.Title = Resources.AppDisplayName;
            Menu = new ContextMenu()
            {
                Items =
                {
                    new ButtonMenuItem()
                    {
                        Text = Resources.AppStarting,
                        Enabled = false
                    }
                }
            };
            Indicator.Menu = Menu;
            Indicator.Show();
        }

        public void Populate()
        {
            Menu.Items.Clear();
            Menu.Items.Add(new ButtonMenuItem()
            {
                Text = Resources.TrayShow,
                Command = Program.ShowCommand
            });
            Menu.Items.Add(new ButtonMenuItem()
            {
                Text = Resources.TrayQuit,
                Command = Program.QuitCommand
            });
            Menu.Items.Add(new CheckMenuItem()
            {
                Text = Resources.TrayEnabled,
                Enabled = false
            });
        }
        
        
        public void ShowButton()
        {
            
        }

        public void ExitButton()
        {
            
        }
    }
}