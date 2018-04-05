using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpp_desktop.ViewModel
{
    public class PluginViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LocalFilePath { get; set; }
        public string RemoteFilePath { get; set; }
        public string Author { get; set; }

        public PluginViewModel(string name, string description, string localFilePath, string remoteFilePath, string author)
        {
            this.Name = name;
            this.Description = description;
            this.LocalFilePath = localFilePath;
            this.RemoteFilePath = remoteFilePath;
            this.Author = author;
        }
    }
}
