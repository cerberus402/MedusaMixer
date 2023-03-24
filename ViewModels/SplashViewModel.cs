using System.ComponentModel;
using System.Reflection;

namespace MedusaMixer.ViewModels
{
    class SplashViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        public string VersionNumber 
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
            set { VersionNumber = value; }
        }

    }
}
