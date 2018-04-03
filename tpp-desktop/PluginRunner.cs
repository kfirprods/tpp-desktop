using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api;
using tpp_desktop.Utilities;

namespace tpp_desktop
{
    public class PluginRunner
    {
        public static void RunPlugin(string pluginPath, string pluginName)
        {
            // TODO: Check for availability
            var port = 1738;

            // TODO: Fetch dynamically
            var pluginRunnerPath = "C:\\Projects\\tpp-desktop\\py\\plugin_runner.py";

            PythonUtilities.RunScript(pluginRunnerPath, $"{pluginPath} {pluginName} {port}");

            var communicator = Ice.Util.initialize();
            var obj = communicator.stringToProxy($"{pluginName}:default -p {port}");
            var plugin = PluginPrxHelper.checkedCast(obj);
            if (plugin == null)
            {
                throw new ApplicationException("Invalid proxy");
            }

            plugin.execute(new [] { "" });
            plugin.shutdown();
        }
        
    }
}
