namespace _11_2_converter
{
	partial class MainForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gbConversion = new System.Windows.Forms.GroupBox();
			this.btnConvert = new System.Windows.Forms.Button();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.lblDirection = new System.Windows.Forms.Label();
			this.lblDestination = new System.Windows.Forms.Label();
			this.tbDestination = new System.Windows.Forms.TextBox();
			this.lblSource = new System.Windows.Forms.Label();
			this.tbSource = new System.Windows.Forms.TextBox();
			this.gbHistory = new System.Windows.Forms.GroupBox();
			this.btnClearHistory = new System.Windows.Forms.Button();
			this.cbHistory = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbConversion.SuspendLayout();
			this.gbHistory.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gbConversion);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbHistory);
			this.splitContainer1.Size = new System.Drawing.Size(472, 145);
			this.splitContainer1.SplitterDistance = 310;
			this.splitContainer1.TabIndex = 0;
			// 
			// gbConversion
			// 
			this.gbConversion.Controls.Add(this.btnConvert);
			this.gbConversion.Controls.Add(this.cbDirection);
			this.gbConversion.Controls.Add(this.lblDirection);
			this.gbConversion.Controls.Add(this.lblDestination);
			this.gbConversion.Controls.Add(this.tbDestination);
			this.gbConversion.Controls.Add(this.lblSource);
			this.gbConversion.Controls.Add(this.tbSource);
			this.gbConversion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbConversion.Location = new System.Drawing.Point(0, 0);
			this.gbConversion.Name = "gbConversion";
			this.gbConversion.Size = new System.Drawing.Size(310, 145);
			this.gbConversion.TabIndex = 0;
			this.gbConversion.TabStop = false;
			this.gbConversion.Text = "Conversion";
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConvert.Location = new System.Drawing.Point(229, 115);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(75, 23);
			this.btnConvert.TabIndex = 2;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// cbDirection
			// 
			this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Items.AddRange(new object[] {
            "2_based to 11_based",
            "11_based to 2_based"});
			this.cbDirection.Location = new System.Drawing.Point(101, 25);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(135, 21);
			this.cbDirection.TabIndex = 3;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// lblDirection
			// 
			this.lblDirection.AutoSize = true;
			this.lblDirection.Location = new System.Drawing.Point(7, 28);
			this.lblDirection.Name = "lblDirection";
			this.lblDirection.Size = new System.Drawing.Size(56, 13);
			this.lblDirection.TabIndex = 2;
			this.lblDirection.Text = "Convert ...";
			// 
			// lblDestination
			// 
			this.lblDestination.AutoSize = true;
			this.lblDestination.Location = new System.Drawing.Point(7, 92);
			this.lblDestination.Name = "lblDestination";
			this.lblDestination.Size = new System.Drawing.Size(39, 13);
			this.lblDestination.TabIndex = 2;
			this.lblDestination.Text = "Output";
			// 
			// tbDestination
			// 
			this.tbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDestination.Location = new System.Drawing.Point(101, 89);
			this.tbDestination.Name = "tbDestination";
			this.tbDestination.ReadOnly = true;
			this.tbDestination.Size = new System.Drawing.Size(203, 20);
			this.tbDestination.TabIndex = 2;
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(7, 66);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(31, 13);
			this.lblSource.TabIndex = 2;
			this.lblSource.Text = "Input";
			// 
			// tbSource
			// 
			this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSource.Location = new System.Drawing.Point(101, 63);
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(203, 20);
			this.tbSource.TabIndex = 2;
			// 
			// gbHistory
			// 
			this.gbHistory.Controls.Add(this.btnClearHistory);
			this.gbHistory.Controls.Add(this.cbHistory);
			this.gbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbHistory.Location = new System.Drawing.Point(0, 0);
			this.gbHistory.Name = "gbHistory";
			this.gbHistory.Size = new System.Drawing.Size(158, 145);
			this.gbHistory.TabIndex = 0;
			this.gbHistory.TabStop = false;
			this.gbHistory.Text = "History";
			// 
			// btnClearHistory
			// 
			this.btnClearHistory.Location = new System.Drawing.Point(6, 115);
			this.btnClearHistory.Name = "btnClearHistory";
			this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
			this.btnClearHistory.TabIndex = 1;
			this.btnClearHistory.Text = "Clear";
			this.btnClearHistory.UseVisualStyleBackColor = true;
			this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
			// 
			// cbHistory
			// 
			this.cbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHistory.FormattingEnabled = true;
			this.cbHistory.Location = new System.Drawing.Point(6, 25);
			this.cbHistory.Name = "cbHistory";
			this.cbHistory.Size = new System.Drawing.Size(140, 21);
			this.cbHistory.TabIndex = 0;
			this.cbHistory.SelectionChangeCommitted += new System.EventHandler(this.cbHistory_SelectionChangeCommitted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 145);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainForm";
			this.Text = "Converter 2based <-> 11based";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gbConversion.ResumeLayout(false);
			this.gbConversion.PerformLayout();
			this.gbHistory.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gbHistory;
		private System.Windows.Forms.GroupBox gbConversion;
		private System.Windows.Forms.ComboBox cbHistory;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.Label lblDirection;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.Button btnClearHistory;
		private System.Windows.Forms.Label lblDestination;
		private System.Windows.Forms.TextBox tbDestination;
		private System.Windows.Forms.Button btnConvert;
	}
}

