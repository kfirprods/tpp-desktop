using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace tpp_desktop.ViewModel
{
    public class PluginGroupViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        // TODO: Notify property changed
        public bool IsFavorite { get; set; }
        // TODO: Notify property changed
        public int RemoteGroupId { get; set; }
        private ObservableCollection<PluginViewModel> _plugins;
        public ObservableCollection<PluginViewModel> Plugins => this._plugins ?? (this._plugins = new ObservableCollection<PluginViewModel>());

        public PluginGroupViewModel(string name, string description, string author, bool isFavorite, int remoteGroupId, IEnumerable<PluginViewModel> plugins)
        {
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.IsFavorite = isFavorite;
            this.RemoteGroupId = remoteGroupId;
            this._plugins = new ObservableCollection<PluginViewModel>(plugins);
        }
    }
}
