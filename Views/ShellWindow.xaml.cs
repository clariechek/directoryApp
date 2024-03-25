using System.Windows.Controls;

using directoryApp.Contracts.Views;
using directoryApp.ViewModels;

using MahApps.Metro.Controls;

namespace directoryApp.Views;

public partial class ShellWindow : MetroWindow, IShellWindow
{
    public ShellWindow(ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public Frame GetNavigationFrame()
        => shellFrame;

    public void ShowWindow()
        => Show();

    public void CloseWindow()
        => Close();
}
