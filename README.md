# tpp-desktop
Textual Post Processing served as a desktop client.

### AUTHOR NAME
The author name, unless any other form of authentication is ever implemented, shall be the Windows username. It is used to watermark plugins and plugin groups.

### PLUGIN
A plugin is a python script with a well defined entry point that matches the requirements. It inputs a list of absolute file paths and may apply validations and changes to the files. It is associated with a title and the author name. Represented within a list in plugin groups that contain them.

### PLUGIN GROUP
One or more plugins associated together under the metadata of a title, description and author name. Represented by cards in the main UI. Said cards can be marked as favorite and show 1st in the UI.

### CENTRAL SERVER
An optional synchronization middle-man to help share plugins and plugin groups between users. In absence of a central server, all plugins and plugin groups remain local to the user, i.e the central server is much like a GitHub repository - you can commit work locally and not necessarily have it pushed.
*The central server implements no form of privacy - anyone can view, use or duplicate plugins and plugin groups, but only their authors can delete them.

## Flow
As you open the program, NTLM identification occurs behind the scenes just to identify you by a name.
You immediately get cards for all plugin groups as fetched by the server and from the local repository, with the 1st card being a + card that redirects you to plugin/plugin group creation. 

You can drag & drop files or directories onto a plugin group card and the plugins start running. If a plugin asks for validation, the code that requires your attention is marked for you in a built-in code editor. There, you choose whether to ignore the validation or edit.

The files are outputted to a settings-based directory which defaults to somewhere in %AppData%
