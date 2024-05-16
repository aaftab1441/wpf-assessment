using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestingWPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenSettingsModal(object sender, RoutedEventArgs e)
        {
            var settingsModal = new SettingsModal();
            settingsModal.Owner = this;
            settingsModal.ShowDialog();
        }

        private void OpenKeepHistoryModal(object sender, RoutedEventArgs e)
        {
            var dialog = new KeepHistoryModal();
            dialog.Owner = this;
            dialog.ShowDialog();
        }
    }
}