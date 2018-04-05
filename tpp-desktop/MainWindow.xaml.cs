﻿using System;
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

namespace tpp_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ControllerViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            PluginRunner.RunPlugin("C:\\Projects\\tpp-desktop\\py\\test_plugin.py", "TestPlugin");
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            var controller = this.DataContext as ControllerViewModel;
            controller?.Shutdown();
        }
    }
}
