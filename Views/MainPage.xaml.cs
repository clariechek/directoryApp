using System.Windows.Controls;

using directoryApp.ViewModels;

namespace directoryApp.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
