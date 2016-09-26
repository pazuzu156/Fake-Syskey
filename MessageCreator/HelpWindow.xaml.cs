using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Message_Creator
{
	/// <summary>
	/// Interaction logic for HelpWindow.xaml
	/// </summary>
	public partial class HelpWindow : Window
	{
		public HelpWindow()
		{
			InitializeComponent();
		}

		private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Close();
		}

		private void MySite_Clicked(object sender, MouseButtonEventArgs e)
		{
			Process.Start("http://kalebklein.com");
		}

		private void License_Clicked(object sender, MouseButtonEventArgs e)
		{
			Process.Start("https://opensource.org/licenses/MIT");
		}
	}
}
