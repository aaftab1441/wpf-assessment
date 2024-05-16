using System.Windows;
using TestingWPFProject.ViewModals;

namespace TestingWPFProject
{
    /// <summary>
    /// Interaction logic for KeepHistoryModal.xaml
    /// </summary>
    public partial class KeepHistoryModal : Window
    {
        public KeepHistoryModal()
        {
            InitializeComponent();
            var viewModel = new KeepHistoryViewModel();
            viewModel.RequestClose += Close;
            DataContext = viewModel;
        }
    }
}
