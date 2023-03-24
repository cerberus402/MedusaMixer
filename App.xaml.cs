using System.Configuration;
using System.Windows;
using ControlzEx.Theming;
using MedusaMixer.Properties;

namespace MedusaMixer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            ThemeManager.Current.ChangeTheme(this, Settings.Default["Theme"].ToString() ?? "Dark.Green");
        }

    }
}
