using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spinners
{
	/// <summary>
	/// Interaction logic for ucSpinnerPiston.xaml
	/// </summary>
	public partial class ucSpinnerPiston : UserControl
	{
	    private const int OriginalSize = 6;

		public ucSpinnerPiston()
		{
			this.InitializeComponent();

		    ellipse.Width = this.Width;
		    ellipse.Height = this.Height;
		}
	}
}