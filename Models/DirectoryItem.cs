using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directoryApp.Models
{
    public class DirectoryItem
    {
        public string Name { get; }
        public ObservableCollection<DirectoryItem> Directories { get; }

        public DirectoryItem(string fileName)
        {
            Name = fileName;
        }

        public DirectoryItem(DirectoryInfo directoryInfo)
        {
            Name = directoryInfo.Name;
            Directories = new ObservableCollection<DirectoryItem>();

            foreach (var directory in directoryInfo.GetDirectories())
            {
                Directories.Add(new DirectoryItem(directory));
            }
            
            foreach(var file in  directoryInfo.GetFiles())
            {
                Directories.Add(new DirectoryItem(file.Name));
            }
        }
    }
}