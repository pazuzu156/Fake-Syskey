using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace syskey
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles(); // Disable, so it looks like the real syskey ;)
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
