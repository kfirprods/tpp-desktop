module Api {
    sequence<string> StringArray;

    interface GuiOperations {
        void ShowMessageBox(string text);
    };

    interface Plugin {
        void execute(StringArray files);
        void shutdown();
    };
};
