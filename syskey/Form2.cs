using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace syskey
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			// This is one of the more convencing pieces
			// When they check the password radio button,
			// the system group box needs to be greyed out
			// and vice versa ;)
			rbSystem.CheckedChanged += rbSystem_CheckedChanged;

			// Continue making it believeable, incorrect password checking
			// Also, make sure ENTER key is accepted
			tbPassConf.KeyDown += tbPassConf_KeyDown;
		}

		// Keypress event of password confirm box
		void tbPassConf_KeyDown(object sender, KeyEventArgs e)
		{
			// Check if keycode matches enter key
			if(e.KeyCode == Keys.Enter)
			{
				// do simple password checking, remember, convince them it's real!
				if(tbPassConf.Text == tbPass.Text)
				{
					show_message_and_quit(); // Fuck 'em over!
				}
				else
				{
					// Believable, remember? :)
					MessageBox.Show("The passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Only need to capture the system radio button check change event
		// Don't really need to do this twice eh? Once will do it!
		void rbSystem_CheckedChanged(object sender, EventArgs e)
		{
			// If the system button is checked
			// Grey out the password stuff
			if(rbSystem.Checked)
			{
				gbPassword.Enabled = false;
				gbSystem.Enabled = true;
			}
			// else, grey out the system stuff
			// make it believable ;)
			else
			{
				gbPassword.Enabled = true;
				gbSystem.Enabled = false;
			}
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			Close(); // Just close
		}

		private void bOk_Click(object sender, EventArgs e)
		{
			// Make sure password option is checked for this
			// can't go around making it not believable anymore now can we?
			if(rbPassword.Checked)
			{
				if (tbPassConf.Text == tbPass.Text)
				{
					show_message_and_quit();
				}
				else
				{
					MessageBox.Show("The passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				Close();
			}
		}

		// The best part, we know they're scamming, and we've let them get this far
		// Now, it's time to shove that info in their smug faces, let them know the
		// scammer has been scammed! :)
		private void show_message_and_quit()
		{
			MessageBox.Show("You cannot enable syskey dumb scammer! It's disgusting how you lock "
				+ "innocent people out of their computers like this. You make me sick. Good luck locking "
				+ "me out of my own system! :)", "SCAMMER DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Application.Exit();
		}
	}
}
