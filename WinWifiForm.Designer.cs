
namespace WinWifi
{
	partial class WinWifiForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinWifiForm));
			this.notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsButtonSaveFriendlyname = new System.Windows.Forms.ToolStripButton();
			this.tsTbName = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsButtonAutoRefresh = new System.Windows.Forms.ToolStripButton();
			this.tsCombo = new System.Windows.Forms.ToolStripComboBox();
			this.tsLabel = new System.Windows.Forms.ToolStripLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tbAP = new System.Windows.Forms.Label();
			this.tbIP = new System.Windows.Forms.Label();
			this.tbSpeed = new System.Windows.Forms.Label();
			this.tbQuality = new System.Windows.Forms.Label();
			this.tbCurrentTS = new System.Windows.Forms.Label();
			this.tbOldAP = new System.Windows.Forms.Label();
			this.tbOldTS = new System.Windows.Forms.Label();
			this.tbFocusDump = new System.Windows.Forms.TextBox();
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
			this.label7.Location = new System.Drawing.Point(5, 138);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "Signal Quality";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 238);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "Old Timestamp";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Old AP Mac";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 18);
			this.label4.TabIndex = 11;
			this.label4.Text = "Timestamp";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 18);
			this.label3.TabIndex = 10;
			this.label3.Text = "Speed TX / RX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Current Wifi IP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 18);
			this.label1.TabIndex = 8;
			this.label1.Text = "Current AP Mac";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsButtonSaveFriendlyname,
            this.tsTbName,
            this.toolStripSeparator2,
            this.tsButtonAutoRefresh,
            this.tsCombo,
            this.tsLabel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.Size = new System.Drawing.Size(459, 31);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
			this.toolStripButton1.Text = "Refresh";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// tsButtonSaveFriendlyname
			// 
			this.tsButtonSaveFriendlyname.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtonSaveFriendlyname.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonSaveFriendlyname.Image")));
			this.tsButtonSaveFriendlyname.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtonSaveFriendlyname.Name = "tsButtonSaveFriendlyname";
			this.tsButtonSaveFriendlyname.Size = new System.Drawing.Size(28, 28);
			this.tsButtonSaveFriendlyname.Text = "Save friendlyname for AP";
			this.tsButtonSaveFriendlyname.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// tsTbName
			// 
			this.tsTbName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsTbName.Name = "tsTbName";
			this.tsTbName.Size = new System.Drawing.Size(150, 31);
			this.tsTbName.Text = "friendly name";
			this.tsTbName.Click += new System.EventHandler(this.tsTbName_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// tsButtonAutoRefresh
			// 
			this.tsButtonAutoRefresh.CheckOnClick = true;
			this.tsButtonAutoRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtonAutoRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonAutoRefresh.Image")));
			this.tsButtonAutoRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtonAutoRefresh.Name = "tsButtonAutoRefresh";
			this.tsButtonAutoRefresh.Size = new System.Drawing.Size(28, 28);
			this.tsButtonAutoRefresh.Text = "Auto refresh disabled";
			this.tsButtonAutoRefresh.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// tsCombo
			// 
			this.tsCombo.AutoSize = false;
			this.tsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tsCombo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsCombo.Items.AddRange(new object[] {
            "2",
            "5",
            "30",
            "60",
            "180",
            "600"});
			this.tsCombo.Name = "tsCombo";
			this.tsCombo.Size = new System.Drawing.Size(55, 24);
			this.tsCombo.ToolTipText = "Refresh interval in seconds";
			this.tsCombo.SelectedIndexChanged += new System.EventHandler(this.tsCombo_SelectedIndexChanged);
			// 
			// tsLabel
			// 
			this.tsLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsLabel.Name = "tsLabel";
			this.tsLabel.Size = new System.Drawing.Size(138, 28);
			this.tsLabel.Text = "Autorefresh disabled";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tbAP
			// 
			this.tbAP.BackColor = System.Drawing.Color.White;
			this.tbAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbAP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAP.Location = new System.Drawing.Point(144, 35);
			this.tbAP.Name = "tbAP";
			this.tbAP.Size = new System.Drawing.Size(310, 27);
			this.tbAP.TabIndex = 17;
			this.tbAP.Text = "AP";
			this.tbAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbIP
			// 
			this.tbIP.BackColor = System.Drawing.Color.White;
			this.tbIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIP.Location = new System.Drawing.Point(144, 68);
			this.tbIP.Name = "tbIP";
			this.tbIP.Size = new System.Drawing.Size(310, 27);
			this.tbIP.TabIndex = 18;
			this.tbIP.Text = "IP";
			this.tbIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbSpeed
			// 
			this.tbSpeed.BackColor = System.Drawing.Color.White;
			this.tbSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbSpeed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSpeed.Location = new System.Drawing.Point(144, 101);
			this.tbSpeed.Name = "tbSpeed";
			this.tbSpeed.Size = new System.Drawing.Size(310, 27);
			this.tbSpeed.TabIndex = 19;
			this.tbSpeed.Text = "Speed";
			this.tbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbQuality
			// 
			this.tbQuality.BackColor = System.Drawing.Color.White;
			this.tbQuality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbQuality.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuality.Location = new System.Drawing.Point(144, 134);
			this.tbQuality.Name = "tbQuality";
			this.tbQuality.Size = new System.Drawing.Size(310, 27);
			this.tbQuality.TabIndex = 20;
			this.tbQuality.Text = "Quality";
			this.tbQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbCurrentTS
			// 
			this.tbCurrentTS.BackColor = System.Drawing.Color.White;
			this.tbCurrentTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCurrentTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbCurrentTS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCurrentTS.Location = new System.Drawing.Point(144, 168);
			this.tbCurrentTS.Name = "tbCurrentTS";
			this.tbCurrentTS.Size = new System.Drawing.Size(310, 27);
			this.tbCurrentTS.TabIndex = 21;
			this.tbCurrentTS.Text = "Current TS";
			this.tbCurrentTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbOldAP
			// 
			this.tbOldAP.BackColor = System.Drawing.Color.White;
			this.tbOldAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbOldAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbOldAP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOldAP.Location = new System.Drawing.Point(144, 201);
			this.tbOldAP.Name = "tbOldAP";
			this.tbOldAP.Size = new System.Drawing.Size(310, 27);
			this.tbOldAP.TabIndex = 22;
			this.tbOldAP.Text = "OldAP";
			this.tbOldAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbOldTS
			// 
			this.tbOldTS.BackColor = System.Drawing.Color.White;
			this.tbOldTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbOldTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbOldTS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbOldTS.Location = new System.Drawing.Point(144, 234);
			this.tbOldTS.Name = "tbOldTS";
			this.tbOldTS.Size = new System.Drawing.Size(310, 27);
			this.tbOldTS.TabIndex = 23;
			this.tbOldTS.Text = "Old TS";
			this.tbOldTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbFocusDump
			// 
			this.tbFocusDump.Location = new System.Drawing.Point(486, 168);
			this.tbFocusDump.Name = "tbFocusDump";
			this.tbFocusDump.Size = new System.Drawing.Size(100, 20);
			this.tbFocusDump.TabIndex = 24;
			// 
			// WinWifiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(459, 273);
			this.Controls.Add(this.tbFocusDump);
			this.Controls.Add(this.tbOldTS);
			this.Controls.Add(this.tbOldAP);
			this.Controls.Add(this.tbCurrentTS);
			this.Controls.Add(this.tbQuality);
			this.Controls.Add(this.tbSpeed);
			this.Controls.Add(this.tbIP);
			this.Controls.Add(this.tbAP);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "WinWifiForm";
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsButtonSaveFriendlyname;
		private System.Windows.Forms.ToolStripTextBox tsTbName;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripButton tsButtonAutoRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox tsCombo;
		private System.Windows.Forms.Label tbAP;
		private System.Windows.Forms.Label tbIP;
		private System.Windows.Forms.Label tbSpeed;
		private System.Windows.Forms.Label tbQuality;
		private System.Windows.Forms.Label tbCurrentTS;
		private System.Windows.Forms.Label tbOldAP;
		private System.Windows.Forms.Label tbOldTS;
		private System.Windows.Forms.ToolStripLabel tsLabel;
		private System.Windows.Forms.TextBox tbFocusDump;
	}
}

