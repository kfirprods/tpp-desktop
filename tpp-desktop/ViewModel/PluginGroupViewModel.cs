using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using tpp_desktop.Common;
using Telerik.Windows.Controls;

namespace tpp_desktop.ViewModel
{
    public class PluginGroupViewModel : PropertyChangedNotifier
    {
        public int LocalPluginId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                _isFavorite = value;
                this.OnPropertyChanged();
            }
        }

        private int _remoteGroupId;
        public int RemoteGroupId
        {
            get => _remoteGroupId;
            set
            {
                _remoteGroupId = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(IsSynced));
            }
        }

        public bool IsSynced
        {
            get => RemoteGroupId > 0;
            set
            {
                // handle somehow
            }
        }

        private ObservableCollection<PluginViewModel> _plugins;
        public ObservableCollection<PluginViewModel> Plugins => this._plugins ?? (this._plugins = new ObservableCollection<PluginViewModel>());

        private PluginViewModel _currentRunningPlugin;

        public PluginViewModel CurrentRunningPlugin
        {
            get => this. _currentRunningPlugin;
            set
            {
                this._currentRunningPlugin = value;
                this.OnPropertyChanged();
            }
        }

        private DelegateCommand _runCommand;

        public DelegateCommand RunCommand => this._runCommand ?? (this._runCommand = new DelegateCommand((files) =>
        {
            var selectedFiles = (IEnumerable<string>[]) files;

            foreach (var plugin in this.Plugins)
            {
                this.CurrentRunningPlugin = plugin;
                plugin.Run(selectedFiles);
            }
        }, (files) => true));

        public PluginGroupViewModel(int pluginId, string name, string description, string author, bool isFavorite, int remoteGroupId, IEnumerable<PluginViewModel> plugins)
        {
            this.LocalPluginId = pluginId;
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.IsFavorite = isFavorite;
            this.RemoteGroupId = remoteGroupId;
            this._plugins = new ObservableCollection<PluginViewModel>(plugins);
        }
    }
}
