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
using System.IO;
using System.Web.Script.Serialization;
using WinForms = System.Windows.Forms;
using syskey;

namespace Message_Creator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Settings s;
		private bool canSave = false;
		private string currentMessagesFile;
		private List<Message> lvItems;

		public MainWindow()
		{
			InitializeComponent();

			s = Settings.init();
			this.currentMessagesFile = s.data.messages;

			// Let's populate our list with our messages!
			lvItems = s.messages;
			lvMessages.ItemsSource = lvItems;
		}

		/// <summary>
		/// User canceled editing. Close the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Set can execute on command binding to canSave
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = canSave;
		}

		/// <summary>
		/// Save command executed, go ahead and save!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			this.SaveContent(this.currentMessagesFile);
		}

		/// <summary>
		/// Make sure users know they have unsaved changes when closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool dirtyExit = true;
			if(canSave)
			{
				if (MessageBox.Show("You have unsaved changes, closing now will cause you to loose those changes. Are you sure you want to close now?", "Save Changes", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
					dirtyExit = false;
			}

			if (!dirtyExit)
				e.Cancel = true;
		}

		/// <summary>
		/// This opens a new editor window and makes changes if any edits were made
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lvMessages_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			var item = ((FrameworkElement)e.OriginalSource).DataContext as Message;
			if(item != null)
			{
				// Open editor with content
				var editor = new EditorWindow(item.title, item.message);
				editor.ShowDialog();
				if(editor.Changed)
				{
					item.title = editor.title;
					item.message = editor.message;
					lvMessages.Items.Refresh();
					canSave = true;
				}
			}
		}

		/// <summary>
		/// Generic MenuItem Command allow execution
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Command_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		/// <summary>
		/// Close command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Add command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			NewWindow ni = new NewWindow();
			ni.ShowDialog();

			if(ni.Changed)
			{
				lvItems.Add(new Message() { title = ni.title, message = ni.message });
				lvMessages.Items.Refresh();
				canSave = true;
			}
		}

		/// <summary>
		/// Delete command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			bool confirm = false;
			if (lvMessages.SelectedItems.Count > 1)
			{
				if (MessageBox.Show("You have multiple items selected to remove. Are you sure you want to remove all of these items?", "Delete Items", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
					confirm = true;
			}
			else
				confirm = true;

			if(confirm)
			{
				var tmp = lvMessages.SelectedItems.Cast<Message>().ToList();
				foreach(var item in tmp)
				{
					lvItems.Remove(item);
				}

				if (lvItems.Count > 0)
					canSave = true;
				else
					canSave = false;

				lvMessages.Items.Refresh();
			}
		}

		/// <summary>
		/// Help window command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			new HelpWindow().ShowDialog();
		}

		/// <summary>
		/// Import command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImportCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			bool procede = false;
			if (canSave)
			{
				if (MessageBox.Show("You currently have unsaved changed. Proceding will erase any changes you've currently made. Are you sure you wish to continue with the import?",
					"Unsaved Changes", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
					procede = true;
			}
			else
				procede = true;

			if(procede)
			{
				var ofd = new WinForms.OpenFileDialog();
				ofd.Title = "Import messages..";
				ofd.Filter = "JSON|*.json";
				if (ofd.ShowDialog() == WinForms.DialogResult.OK)
				{
					if (File.Exists(ofd.FileName))
					{
						using (var reader = new StreamReader(File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)))
						{
							lvItems = new JavaScriptSerializer().Deserialize<List<Message>>(reader.ReadToEnd());
							lvMessages.ItemsSource = lvItems;
							lvMessages.Items.Refresh();
						}
						this.currentMessagesFile = ofd.FileName;
					}
					else
						MessageBox.Show(ofd.FileName + " could not be found!", "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		/// <summary>
		/// Export command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExportCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			var sfd = new WinForms.SaveFileDialog();
			sfd.Title = "Export messages to..";
			sfd.Filter = "JSON|*.json";
			if(sfd.ShowDialog() == WinForms.DialogResult.OK)
			{
				SaveContent(sfd.FileName);
				MessageBox.Show("Export successfull. You can find it at: " + sfd.FileName, "Export Success", MessageBoxButton.OK, MessageBoxImage.Information);
			}
		}

		/// <summary>
		/// Save content. For save function AND export function
		/// </summary>
		/// <param name="file"></param>
		private void SaveContent(string file)
		{
			string content = string.Empty;
			foreach (var item in lvMessages.Items)
			{
				var msg = item as Message;
				content += new JavaScriptSerializer().Serialize(new Message()
				{
					title = msg.title,
					message = msg.message
				}) + ",";
			}
			var json = string.Format("[{0}]", content.TrimEnd(','));

			if (File.Exists(file))
				File.Delete(file);

			using (var writer = new StreamWriter(File.Open(file, FileMode.OpenOrCreate, FileAccess.Write)))
			{
				writer.Write(json);
			}

			canSave = false;

			this.currentMessagesFile = file;
		}
	}
}
