namespace tpp_desktop.ViewModel
{
    public class PluginViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // TODO: Notify property changed
        public string LocalFilePath { get; set; }
        // TODO: Notify property changed
        public int RemotePluginId { get; set; }
        public string Author { get; set; }

        public PluginViewModel(string name, string description, string localFilePath, int remotePluginId, string author)
        {
            this.Name = name;
            this.Description = description;
            this.LocalFilePath = localFilePath;
            this.RemotePluginId = remotePluginId;
            this.Author = author;
        }
    }
}
