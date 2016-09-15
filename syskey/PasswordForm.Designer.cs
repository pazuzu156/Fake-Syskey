namespace syskey
{
	partial class PasswordForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbPassword = new System.Windows.Forms.GroupBox();
			this.rbPassword = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.tbPassConf = new System.Windows.Forms.TextBox();
			this.gbSystem = new System.Windows.Forms.GroupBox();
			this.rbSystem = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.bOk = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.gbPassword.SuspendLayout();
			this.gbSystem.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPassword
			// 
			this.gbPassword.Controls.Add(this.tbPassConf);
			this.gbPassword.Controls.Add(this.tbPass);
			this.gbPassword.Controls.Add(this.label3);
			this.gbPassword.Controls.Add(this.label2);
			this.gbPassword.Controls.Add(this.label1);
			this.gbPassword.Enabled = false;
			this.gbPassword.Location = new System.Drawing.Point(12, 12);
			this.gbPassword.Name = "gbPassword";
			this.gbPassword.Size = new System.Drawing.Size(281, 112);
			this.gbPassword.TabIndex = 0;
			this.gbPassword.TabStop = false;
			// 
			// rbPassword
			// 
			this.rbPassword.AutoSize = true;
			this.rbPassword.Location = new System.Drawing.Point(17, 10);
			this.rbPassword.Name = "rbPassword";
			this.rbPassword.Size = new System.Drawing.Size(108, 17);
			this.rbPassword.TabIndex = 0;
			this.rbPassword.Text = "Password Startup";
			this.rbPassword.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Requires a password to be entered during system\r\nstart.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Confirm:";
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(95, 52);
			this.tbPass.Name = "tbPass";
			this.tbPass.PasswordChar = '*';
			this.tbPass.Size = new System.Drawing.Size(171, 20);
			this.tbPass.TabIndex = 4;
			// 
			// tbPassConf
			// 
			this.tbPassConf.Location = new System.Drawing.Point(95, 78);
			this.tbPassConf.Name = "tbPassConf";
			this.tbPassConf.PasswordChar = '*';
			this.tbPassConf.Size = new System.Drawing.Size(171, 20);
			this.tbPassConf.TabIndex = 5;
			// 
			// gbSystem
			// 
			this.gbSystem.Controls.Add(this.label5);
			this.gbSystem.Controls.Add(this.radioButton4);
			this.gbSystem.Controls.Add(this.label4);
			this.gbSystem.Controls.Add(this.radioButton3);
			this.gbSystem.Location = new System.Drawing.Point(12, 136);
			this.gbSystem.Name = "gbSystem";
			this.gbSystem.Size = new System.Drawing.Size(281, 149);
			this.gbSystem.TabIndex = 1;
			this.gbSystem.TabStop = false;
			// 
			// rbSystem
			// 
			this.rbSystem.AutoSize = true;
			this.rbSystem.Checked = true;
			this.rbSystem.Location = new System.Drawing.Point(17, 134);
			this.rbSystem.Name = "rbSystem";
			this.rbSystem.Size = new System.Drawing.Size(161, 17);
			this.rbSystem.TabIndex = 2;
			this.rbSystem.TabStop = true;
			this.rbSystem.Text = "System Generated Password";
			this.rbSystem.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 273);
			this.panel1.TabIndex = 0;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(24, 21);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(181, 17);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Store Startup Key on Floppy Disk";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Requires a floppy disk to be inserted during\r\nsystem start.";
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(24, 78);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(144, 17);
			this.radioButton4.TabIndex = 2;
			this.radioButton4.Text = "Store Startup Key Locally";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 39);
			this.label5.TabIndex = 3;
			this.label5.Text = "Stores as key as part of the operating system,\r\nand no interation is required dur" +
    "ing system\r\nstart.";
			// 
			// bOk
			// 
			this.bOk.Location = new System.Drawing.Point(78, 291);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(68, 23);
			this.bOk.TabIndex = 3;
			this.bOk.Text = "OK";
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler(this.bOk_Click);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(152, 291);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(68, 23);
			this.bCancel.TabIndex = 4;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 324);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bOk);
			this.Controls.Add(this.rbSystem);
			this.Controls.Add(this.gbSystem);
			this.Controls.Add(this.rbPassword);
			this.Controls.Add(this.gbPassword);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Startup Key";
			this.gbPassword.ResumeLayout(false);
			this.gbPassword.PerformLayout();
			this.gbSystem.ResumeLayout(false);
			this.gbSystem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPassword;
		private System.Windows.Forms.TextBox tbPassConf;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbPassword;
		private System.Windows.Forms.GroupBox gbSystem;
		private System.Windows.Forms.RadioButton rbSystem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bCancel;
	}
}