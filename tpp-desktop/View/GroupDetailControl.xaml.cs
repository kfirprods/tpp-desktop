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

namespace tpp_desktop.View
{
    /// <summary>
    /// Interaction logic for GroupDetailControl.xaml
    /// </summary>
    public partial class GroupDetailControl : UserControl
    {
        public GroupDetailControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Animate
            this.Visibility = Visibility.Collapsed;
        }
    }
}
