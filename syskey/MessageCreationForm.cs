using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace syskey
{
	public partial class MessageCreationForm : Form
	{
		private Settings s;

		public MessageCreationForm(Settings settings)
		{
			InitializeComponent();
			this.s = settings;
		}
	}
}
