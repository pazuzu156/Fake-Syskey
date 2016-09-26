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
	/// Interaction logic for EditorWindow.xaml
	/// </summary>
	public partial class EditorWindow : Window
	{
		public string title { get; private set; }
		public string message { get; private set; }
		public bool Changed { get; private set; }

		public EditorWindow(string title, string message)
		{
			InitializeComponent();
			this.title = title;
			this.message = message;
			tbMessage.Text = this.message;
			tbTitle.Text = this.title;
			this.Changed = false;
		}

		private void bCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void bSave_Click(object sender, RoutedEventArgs e)
		{
			this.title = tbTitle.Text;
			this.message = tbMessage.Text;
			this.Changed = true;
			this.Close();
		}
	}
}
