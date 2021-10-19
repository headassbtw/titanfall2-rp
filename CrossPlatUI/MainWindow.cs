using Eto.Drawing;
using Eto.Forms;

namespace CrossPlatUI
{
    public class MainWindow : Form
    {
        public MainWindow()
        {
            Title = Resources.AppDisplayName;
            ClientSize = new Size(720, 480);
            Icon = Program.Icon;
            var tabs = new TabControl();
            tabs.Width = 720;
            var mainTab = new TabPage();
            mainTab.Text = Resources.MainTabName;
            var settingsTab = new TabPage();
            settingsTab.Text = Resources.SettingsTabName;


            var layout = new StackLayout();
            layout.Items.Add(new Label()
            {
                Text = "Coming Soon!"
            });
            layout.Items.Add(new Button()
            {
                Text = "Coming Soon 2: Electric Boogaloo!"
            });
            mainTab.Content = layout;
            settingsTab.Content = layout;
            tabs.Pages.Add(mainTab);
            tabs.Pages.Add(settingsTab);
            Content = tabs;
            Closing += (sender, eventArgs) =>
            {
                //this is very hacky, but it accomplishes what i want it to
                eventArgs.Cancel = true;
                ShowInTaskbar = false;
                Minimize();
            };
        }
    }
}