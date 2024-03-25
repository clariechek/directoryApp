using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using directoryApp.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace directoryApp.ViewModels;

public class MainViewModel : ObservableObject
{
    private string _selectedDirectory;
    public string SelectedDirectory
    {
        get => _selectedDirectory;
        set => SetProperty(ref  _selectedDirectory, value);
    }

    private ObservableCollection<DirectoryItem> _directories;
    public ObservableCollection<DirectoryItem> Directories
    {
        get => _directories;
        set => SetProperty(ref _directories, value);
    }

    public ICommand ReloadCommand { get; }

    public MainViewModel()
    {
        ReloadCommand = new RelayCommand(ReloadDirectories);
        SelectedDirectory = @"C:\Users\Clarie\Desktop\TestFolder";
        ReloadDirectories();
    }

    private void ReloadDirectories()
    {
        if (Directory.Exists(SelectedDirectory))
        {
            Directories = new ObservableCollection<DirectoryItem>
            {
                new DirectoryItem(new DirectoryInfo(SelectedDirectory))
            };
        }
    }
}