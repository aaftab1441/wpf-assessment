using System.Windows;
using TestingWPFProject.ViewModels;

namespace TestingWPFProject
{
    /// <summary>
    /// Interaction logic for SettingsModal.xaml
    /// </summary>
    public partial class SettingsModal : Window
    {
        public SettingsModal()
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
