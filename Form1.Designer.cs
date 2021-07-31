
namespace WinWifi
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.tbQuality = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbIP = new System.Windows.Forms.TextBox();
			this.tbSpeed = new System.Windows.Forms.TextBox();
			this.tbOldAP = new System.Windows.Forms.TextBox();
			this.tbOldTS = new System.Windows.Forms.TextBox();
			this.tbCurrentTS = new System.Windows.Forms.TextBox();
			this.tbAP = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tsTbName = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsCombo = new System.Windows.Forms.ToolStripComboBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notify
			// 
			this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notify.BalloonTipText = "Wifi Connected AP";
			this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
			this.notify.Text = "Wifi AP";
			this.notify.Visible = true;
			this.notify.DoubleClick += new System.EventHandler(this.notify_DoubleClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 207);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 29);
			this.label7.TabIndex = 15;
			this.label7.Text = "Signal Quality";
			// 
			// tbQuality
			// 
			this.tbQuality.BackColor = System.Drawing.SystemColors.Window;
			this.tbQuality.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuality.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbQuality.Location = new System.Drawing.Point(216, 202);
			this.tbQuality.Margin = new System.Windows.Forms.Padding(4);
			this.tbQuality.Name = "tbQuality";
			this.tbQuality.ReadOnly = true;
			this.tbQuality.Size = new System.Drawing.Size(463, 37);
			this.tbQuality.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 357);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(193, 29);
			this.label6.TabIndex = 13;
			this.label6.Text = "Old Timestamp";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 308);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 29);
			this.label5.TabIndex = 12;
			this.label5.Text = "Old AP Mac";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 258);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 29);
			this.label4.TabIndex = 11;
			this.label4.Text = "Timestamp";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 29);
			this.label3.TabIndex = 10;
			this.label3.Text = "Speed TX / RX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 29);
			this.label2.TabIndex = 9;
			this.label2.Text = "Current Wifi IP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 29);
			this.label1.TabIndex = 8;
			this.label1.Text = "Current AP Mac";
			// 
			// tbIP
			// 
			this.tbIP.BackColor = System.Drawing.SystemColors.Window;
			this.tbIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbIP.Location = new System.Drawing.Point(214, 104);
			this.tbIP.Margin = new System.Windows.Forms.Padding(4);
			this.tbIP.Name = "tbIP";
			this.tbIP.ReadOnly = true;
			this.tbIP.Size = new System.Drawing.Size(463, 37);
			this.tbIP.TabIndex = 7;
			// 
			// tbSpeed
			// 
			this.tbSpeed.BackColor = System.Drawing.SystemColors.Window;
			this.tbSpeed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSpeed.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbSpeed.Location = new System.Drawing.Point(214, 153);
			this.tbSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.tbSpeed.Name = "tbSpeed";
			this.tbSpeed.ReadOnly = true;
			this.tbSpeed.Size = new System.Drawing.Size(463, 37);
			this.tbSpeed.TabIndex = 6;
			// 
			// tbOldAP
			// 
			this.tbOldAP.BackColor = System.Drawing.SystemColors.Window;
			this.tbOldAP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOldAP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbOldAP.Location = new System.Drawing.Point(214, 303);
			this.tbOldAP.Margin = new System.Windows.Forms.Padding(4);
			this.tbOldAP.Name = "tbOldAP";
			this.tbOldAP.ReadOnly = true;
			this.tbOldAP.Size = new System.Drawing.Size(463, 37);
			this.tbOldAP.TabIndex = 3;
			// 
			// tbOldTS
			// 
			this.tbOldTS.BackColor = System.Drawing.SystemColors.Window;
			this.tbOldTS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOldTS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbOldTS.Location = new System.Drawing.Point(214, 352);
			this.tbOldTS.Margin = new System.Windows.Forms.Padding(4);
			this.tbOldTS.Name = "tbOldTS";
			this.tbOldTS.ReadOnly = true;
			this.tbOldTS.Size = new System.Drawing.Size(463, 37);
			this.tbOldTS.TabIndex = 2;
			// 
			// tbCurrentTS
			// 
			this.tbCurrentTS.BackColor = System.Drawing.SystemColors.Window;
			this.tbCurrentTS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCurrentTS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbCurrentTS.Location = new System.Drawing.Point(214, 254);
			this.tbCurrentTS.Margin = new System.Windows.Forms.Padding(4);
			this.tbCurrentTS.Name = "tbCurrentTS";
			this.tbCurrentTS.ReadOnly = true;
			this.tbCurrentTS.Size = new System.Drawing.Size(463, 37);
			this.tbCurrentTS.TabIndex = 1;
			// 
			// tbAP
			// 
			this.tbAP.BackColor = System.Drawing.SystemColors.Window;
			this.tbAP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbAP.Location = new System.Drawing.Point(214, 54);
			this.tbAP.Margin = new System.Windows.Forms.Padding(4);
			this.tbAP.Name = "tbAP";
			this.tbAP.ReadOnly = true;
			this.tbAP.Size = new System.Drawing.Size(463, 37);
			this.tbAP.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.tsTbName,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.tsCombo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip1.Size = new System.Drawing.Size(690, 38);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
			this.toolStripButton1.Text = "Refresh";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(34, 33);
			this.toolStripButton2.Text = "Save friendlyname for AP";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// tsTbName
			// 
			this.tsTbName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tsTbName.Name = "tsTbName";
			this.tsTbName.Size = new System.Drawing.Size(223, 38);
			this.tsTbName.Text = "friendly name";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.CheckOnClick = true;
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(34, 33);
			this.toolStripButton3.Text = "Auto refresh disabled";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
			// 
			// tsCombo
			// 
			this.tsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tsCombo.Items.AddRange(new object[] {
            "1",
            "5",
            "30",
            "60",
            "180",
            "600"});
			this.tsCombo.Name = "tsCombo";
			this.tsCombo.Size = new System.Drawing.Size(121, 38);
			this.tsCombo.ToolTipText = "Refresh interval in seconds";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(690, 410);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbQuality);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbIP);
			this.Controls.Add(this.tbSpeed);
			this.Controls.Add(this.tbOldAP);
			this.Controls.Add(this.tbCurrentTS);
			this.Controls.Add(this.tbOldTS);
			this.Controls.Add(this.tbAP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Wifi Connected AP - Lazze Ziden 2021 -";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notify;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbIP;
		private System.Windows.Forms.TextBox tbSpeed;
		private System.Windows.Forms.TextBox tbOldAP;
		private System.Windows.Forms.TextBox tbOldTS;
		private System.Windows.Forms.TextBox tbCurrentTS;
		private System.Windows.Forms.TextBox tbAP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbQuality;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripTextBox tsTbName;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox tsCombo;
	}
}

