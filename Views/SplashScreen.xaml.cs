using MahApps.Metro.Controls;
using MedusaMixer.Views;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace MedusaMixer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Splash_Loaded(object sender, EventArgs e)
        {
            var sb = new Storyboard();
            var da = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(1.5)));
            da.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
            Storyboard.SetTarget(da, this);
            sb.Children.Add(da);
            sb.Begin();

            Task.Delay(5000).ContinueWith(_ =>
                {
                    Dispatcher.Invoke(() =>
                        {
                            MetroWindow Window = new MainView() { WindowStartupLocation = WindowStartupLocation.CenterScreen };
                            Window.Show();
                            Close();
                        }
                    );
                }
            );
;
        }
    }
}
