using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace syskey
{
	public partial class EntryForm : Form
	{
		public EntryForm()
		{
			InitializeComponent();
		}

		private void bOk_Click(object sender, EventArgs e)
		{
			Close(); // Just close, make them think it's doing something
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			Close(); // Just close, make them think it's doing something
		}

		private void bUpdate_Click(object sender, EventArgs e)
		{
			// Open a new syskey form for setting the password like they usually do
			new PasswordForm().ShowDialog();
		}
	}
}
