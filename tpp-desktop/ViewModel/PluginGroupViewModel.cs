using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpp_desktop.ViewModel
{
    public class PluginGroupViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        private ObservableCollection<PluginViewModel> _plugins;
        public ObservableCollection<PluginViewModel> Plugins => this._plugins ?? (this._plugins = new ObservableCollection<PluginViewModel>());

        public PluginGroupViewModel(string name, string description, string author, IEnumerable<PluginViewModel> plugins)
        {
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this._plugins = new ObservableCollection<PluginViewModel>(plugins);
        }
    }
}
