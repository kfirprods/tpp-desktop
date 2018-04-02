module Api {
    interface GuiOperations {
        void ShowMessageBox(string text);
    };

    sequence<string> StringArray;

    interface Plugin {
        void execute(StringArray files);

    };
};
