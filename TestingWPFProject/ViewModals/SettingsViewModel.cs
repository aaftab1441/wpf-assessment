using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestingWPFProject.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> AutosaveOptions { get; set; }

        public SettingsViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}