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
using System.Windows.Shapes;

namespace Message_Creator
{
	/// <summary>
	/// Interaction logic for NewWindow.xaml
	/// </summary>
	public partial class NewWindow : Window
	{
		public string title { get; private set; }
		public string message { get; private set; }
		public bool Changed { get; private set; }

		public NewWindow()
		{
			InitializeComponent();
			this.Changed = false;
		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			this.Close();
		}

		private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void tbItemTitle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
				this.Edit();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Edit();
		}

		private void Edit()
		{
			this.title = tbItemTitle.Text;
			this.Changed = true;
			this.Close();
		}
	}
}
