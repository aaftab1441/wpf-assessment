using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TestingWPFProject.ViewModals
{
    public class KeepHistoryViewModel : INotifyPropertyChanged
    {
        private string _lastChangeTime;
        private string _lastChangeAuthor;
        private ObservableCollection<ObservableCollection<ChangeDetail>> _groupedChangeDetails;
        public ICommand CloseCommand { get; private set; }
        public Action RequestClose { get; set; }

        public string LastChangeTime
        {
            get { return _lastChangeTime; }
            set
            {
                _lastChangeTime = value;
                OnPropertyChanged(nameof(LastChangeTime));
            }
        }

        public string LastChangeAuthor
        {
            get { return _lastChangeAuthor; }
            set
            {
                _lastChangeAuthor = value;
                OnPropertyChanged(nameof(LastChangeAuthor));
            }
        }

        public ObservableCollection<ObservableCollection<ChangeDetail>> GroupedChangeDetails
        {
            get { return _groupedChangeDetails; }
            set
            {
                _groupedChangeDetails = value;
                OnPropertyChanged(nameof(GroupedChangeDetails));
            }
        }

        public ICommand StartFreshCommand { get; }
        public ICommand KeepVersionHistoryCommand { get; }

        public KeepHistoryViewModel()
        {
            CloseCommand = new RelayCommand(ExecuteClose);

            StartFreshCommand = new RelayCommand(param => StartFresh());
            KeepVersionHistoryCommand = new RelayCommand(param => KeepVersionHistory());

            // Dummy data for demonstration
            LastChangeTime = "7:03 PM on 11/1/23";
            LastChangeAuthor = "Wolf, Daniel";
            GroupedChangeDetails = new ObservableCollection<ObservableCollection<ChangeDetail>>
            {
                new ObservableCollection<ChangeDetail>
                {
                    new ChangeDetail { Icon = "pack://application:,,,/Resources/icon_tick.png", Details = "1, 2, 3, 10-12, 17-24, 28, 29, 30-33, 35-40, 42, 44-47, 49-52, 54, 55,\n57-62, 64-68, 70-75, 77-82, 84, 86-91, 93-96, 98, 100", Label = "128" }
                },
                new ObservableCollection<ChangeDetail>
                {
                    new ChangeDetail { Icon = "pack://application:,,,/Resources/icon_plus.png", Details = "", Label = "2" },
                    new ChangeDetail { Icon = "pack://application:,,,/Resources/icon_minus.png", Details = "", Label = "1" }
                }
            };
        }

        private void StartFresh()
        {
            // Implement the logic for starting fresh
        }

        private void KeepVersionHistory()
        {
            // Implement the logic for keeping version history
        }
        private void ExecuteClose(object parameter)
        {
            RequestClose?.Invoke();
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
