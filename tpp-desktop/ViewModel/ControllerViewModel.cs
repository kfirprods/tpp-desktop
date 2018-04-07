using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using tpp_desktop.Common;
using tpp_desktop.Utilities;
using tpp_desktop.ViewModel;

namespace tpp_desktop
{
    public class ControllerViewModel : PropertyChangedNotifier
    {
        private const string DatabaseFilename = "tpp.sqlite";
        private SQLiteConnection _dbConnection;

        private ObservableCollection<PluginGroupViewModel> _pluginGroups;

        public ObservableCollection<PluginGroupViewModel> PluginGroups
        {
            get => this._pluginGroups ?? (this._pluginGroups = new ObservableCollection<PluginGroupViewModel>());
            set
            {
                this._pluginGroups = value;
                this.OnPropertyChanged();
            }
        }

        public ControllerViewModel()
        {
            if (!File.Exists(DatabaseFilename))
            {
                this.InitializeDatabase();
            }

            else
            {
                this._dbConnection =
                    new SQLiteConnection($"Data Source={DatabaseFilename};Version=3;");
                this._dbConnection.Open();
            }

            this.FetchPluginGroups();
        }

        private void InitializeDatabase()
        {
            // Create database file
            SQLiteConnection.CreateFile(DatabaseFilename);

            this._dbConnection =
                new SQLiteConnection($"Data Source={DatabaseFilename};Version=3;");
            this._dbConnection.Open();

            // Create tables
            new SQLiteCommand("CREATE TABLE Plugins(name TEXT, description TEXT, localFilePath TEXT, remotePluginId INTEGER, author TEXT)",
                this._dbConnection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE PluginGroups(name TEXT, description TEXT, author TEXT, isFavorite INTEGER, remoteGroupId INTEGER)",
                this._dbConnection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE PluginGroupPlugins(groupId INT, pluginId INT)", this._dbConnection)
                .ExecuteNonQuery();
        }

        private void FetchPluginGroups()
        {
            var groupsTable = this._dbConnection.FetchTable("SELECT rowid, * FROM PluginGroups");
            var pluginGroups = new List<PluginGroupViewModel>();

            foreach (DataRow groupRow in groupsTable.Rows)
            {
                var groupId = int.Parse(groupRow["rowid"].ToString());
                var pluginIdsTable = this._dbConnection.FetchTable($"SELECT pluginId FROM PluginGroupPlugins WHERE groupId={groupId}");
                var plugins = from DataRow pluginIdRow in pluginIdsTable.Rows
                              select int.Parse(pluginIdRow["pluginId"].ToString())
                              into pluginId
                              select this._dbConnection.FetchTable($"SELECT * FROM Plugins WHERE rowid={pluginId}")
                              into pluginTable
                              select new PluginViewModel(
                                  pluginTable.Rows[0]["name"].ToString(),
                                  pluginTable.Rows[0]["description"].ToString(),
                                  pluginTable.Rows[0]["localFilePath"].ToString(),
                                  int.Parse(pluginTable.Rows[0]["remotePluginId"].ToString()),
                                  pluginTable.Rows[0]["author"].ToString()
                              );

                pluginGroups.Add(new PluginGroupViewModel(groupRow["name"].ToString(),
                    groupRow["description"].ToString(), groupRow["author"].ToString(),
                    groupRow["isFavorite"].ToString() == "1", 
                    int.Parse(groupRow["remoteGroupId"].ToString()),
                    plugins));
            }

            this.PluginGroups = new ObservableCollection<PluginGroupViewModel>(pluginGroups);
        }

        public void Shutdown()
        {
            this._dbConnection.Shutdown();
        }
    }
}
