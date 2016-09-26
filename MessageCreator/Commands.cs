using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Message_Creator
{
	public class Commands
	{
		/// <summary>
		/// Statically execute command bindings
		/// </summary>
		static Commands()
		{
			Save = new RoutedUICommand("Save", "save", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S")
				});
			Import = new RoutedUICommand("Import..", "import", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.I, ModifierKeys.Control, "Ctrl+I")
				});
			Export = new RoutedUICommand("Export..", "export", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E")
				});
			Close = new RoutedUICommand("Close", "close", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q")
				});
			Add = new RoutedUICommand("Add New Item", "add", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Insert, ModifierKeys.None, "Ins")
				});
			Delete = new RoutedUICommand("Delete Selected Item", "delete", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Delete, ModifierKeys.None, "Del")
				});
			About = new RoutedUICommand("How to use this tool", "about", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.F1, ModifierKeys.None, "F1")
				});
			CloseDialog = new RoutedUICommand("Close Dialog Window", "closeDialog", typeof(Commands),
				new InputGestureCollection()
				{
					new KeyGesture(Key.Escape, ModifierKeys.None, "Escape")
				});
		}

		public static RoutedUICommand Save { get; private set; }
		public static RoutedUICommand Import { get; private set; }
		public static RoutedUICommand Export { get; private set; }
		public static RoutedUICommand Close { get; private set; }
		public static RoutedUICommand Add { get; private set; }
		public static RoutedUICommand Delete { get; private set; }
		public static RoutedUICommand About { get; private set; }
		public static RoutedUICommand CloseDialog { get; private set; }
	}
}
