using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Telerik.Windows;
using Telerik.Windows.Controls;

namespace tpp_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RadWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new ControllerViewModel();
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            var controller = this.DataContext as ControllerViewModel;
            controller?.Shutdown();
        }

        #region Restoring standard Window functionality due to use of RadWindow 
        private void Icon_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.IconContextMenu.IsOpen = true;
        }

        private void Minimize_OnClick(object sender, RadRoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_OnClick(object sender, RadRoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void Close_OnClick(object sender, RadRoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void GroupTileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.GroupDetail.DataContext = this.GroupTileList.SelectedItem;
            this.GroupDetail.Visibility = Visibility.Visible;
            this.GroupTileList.Visibility = Visibility.Collapsed;
        }
    }
}
