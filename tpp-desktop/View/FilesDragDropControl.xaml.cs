using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Telerik.Windows.Controls;

namespace tpp_desktop.View
{
    /// <summary>
    /// Interaction logic for FilesDragDropControl.xaml
    /// </summary>
    public partial class FilesDragDropControl : UserControl
    {
        public static DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(DelegateCommand), typeof(FilesDragDropControl), null);

        public DelegateCommand Command
        {
            get => (DelegateCommand) this.GetValue(CommandProperty);
            set => this.SetValue(CommandProperty, value);
        }

        public static DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(FilesDragDropControl), null);

        public string Text
        {
            get => (string) this.GetValue(TextProperty);
            set => this.SetValue(TextProperty, value);
        }

        public FilesDragDropControl()
        {
            InitializeComponent();
        }

        private void FileDragDrop_OnDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[]) e.Data.GetData(DataFormats.FileDrop);

                if (this.Command != null && this.Command.CanExecute(files))
                {
                    this.Command.Execute(files);
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All Files|*.*"
            };

            var dialogResult = dialog.ShowDialog();

            if (dialogResult.HasValue && dialogResult.Value)
            {
                var files = dialog.FileNames;

                if (this.Command != null && this.Command.CanExecute(files))
                {
                    this.Command.Execute(files);
                }
            }
        }
    }
}
