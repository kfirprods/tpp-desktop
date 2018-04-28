using System;
using System.Collections.Generic;
using System.Linq;
using Api;
using tpp_desktop.Utilities;

namespace tpp_desktop.ViewModel
{
    public enum PluginExecutionStage
    {
        Loading,
        ProcessingFile,
        UserInput,
        Shutdown
    }

    public class PluginViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // TODO: Notify property changed
        public string LocalFilePath { get; set; }
        // TODO: Notify property changed
        public int RemotePluginId { get; set; }
        public string Author { get; set; }

        // TODO: Notify property changed
        public PluginExecutionStage ExecutionStage { get; set; } = PluginExecutionStage.Loading;

        public PluginViewModel(string name, string description, string localFilePath, int remotePluginId, string author)
        {
            this.Name = name;
            this.Description = description;
            this.LocalFilePath = localFilePath;
            this.RemotePluginId = remotePluginId;
            this.Author = author;
        }

        public void Run(IEnumerable<string> files)
        {
            // Run a server
            var serverName = $"{this.Name}Server";
            // TODO: Check availability
            var serverPort = 1739;
            var ice = Ice.Util.initialize();
            var adapter =
                ice.createObjectAdapterWithEndpoints($"{serverName}Adapter", $"default -p {serverPort}");
            var guiServant = new GuiOperationsServant();
            adapter.add(guiServant, Ice.Util.stringToIdentity(serverName));
            adapter.activate();
            
            // Run the plugin and connect to its server
            // TODO: Check for availability
            var port = 1738;

            // TODO: Fetch dynamically
            var pluginRunnerPath = "C:\\Projects\\tpp-desktop\\py\\plugin_runner.py";

            PythonUtilities.RunScript(pluginRunnerPath, $"\"{this.LocalFilePath}\" \"{this.Name}\" {serverName} {serverPort} {port}");

            var communicator = Ice.Util.initialize();
            var obj = communicator.stringToProxy($"{this.Name}:default -p {port}");
            var plugin = PluginPrxHelper.checkedCast(obj);
            if (plugin == null)
            {
                throw new ApplicationException("Invalid proxy");
            }

            // TODO: Deal with user errors using Ice
            plugin.execute(files.ToArray());
            plugin.shutdown();
            ice.shutdown();
            ice.destroy();
        }
    }
}
