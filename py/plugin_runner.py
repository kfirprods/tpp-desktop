import os
import sys
import imp

import Ice
import Api


def connect_to_frontend(name, port):
    ic = Ice.initialize(sys.argv)
    base = ic.stringToProxy("{}:default -p {}".format(name, port))
    return Api.GuiOperationsPrx.checkedCast(base)



def main():
    plugin_path = sys.argv[1]
    plugin_name = sys.argv[2]
    
    frontend_name = sys.argv[3]
    frontend_port = sys.argv[4]
    
    print "Connecting to frontend..."
    frontend_api = connect_to_frontend(frontend_name, frontend_port)
    print "Connected!"
  
    port = 1738
    if len(sys.argv) > 5:
        port = sys.argv[5]

    plugin_directory_path, plugin_module_name = os.path.split(plugin_path)
    plugin_module_name = plugin_module_name.replace(".py", "")
    f, file_name, description = imp.find_module(plugin_module_name, [plugin_directory_path])
    plugin_module = imp.load_module(plugin_name, f, file_name, description)
    plugin_class = getattr(plugin_module, plugin_name)

    with Ice.initialize(sys.argv) as communicator:
        adapter = communicator.createObjectAdapterWithEndpoints(
            "{}Adapter".format(plugin_name),
            "default -p {}".format(port)
        )
        print "{} will now be available on port {}".format(plugin_name, port)

        object = plugin_class(frontend_api)
        adapter.add(object, communicator.stringToIdentity(plugin_name))
        adapter.activate()
        communicator.waitForShutdown()


if __name__ == "__main__":
    main()
