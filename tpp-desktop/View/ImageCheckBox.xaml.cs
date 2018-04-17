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

namespace tpp_desktop.View
{
    /// <summary>
    /// Interaction logic for ImageCheckBox.xaml
    /// </summary>
    public partial class ImageCheckBox : UserControl
    {
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(ImageCheckBox));

        public bool IsChecked
        {
            get => (bool) GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public static readonly DependencyProperty UncheckedImagePathProperty =
            DependencyProperty.Register("UncheckedImagePath", typeof(string), typeof(ImageCheckBox));

        public string UncheckedImagePath
        {
            get => (string) GetValue(UncheckedImagePathProperty);
            set => SetValue(UncheckedImagePathProperty, value);
        }

        public static readonly DependencyProperty CheckedImagePathProperty =
            DependencyProperty.Register("CheckedImagePath", typeof(string), typeof(ImageCheckBox));

        public string CheckedImagePath
        {
            get => (string)GetValue(CheckedImagePathProperty);
            set => SetValue(CheckedImagePathProperty, value);
        }

        public ImageCheckBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        // Prevent mouse clicks from propagating because we don't want containing tiles to take it as a click
        private void UIElement_OnPreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            this.IsChecked = !this.IsChecked;
        }

        private void UIElement_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
