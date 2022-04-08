
namespace Forms
{
	partial class HomeScreen
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LabelUniDirectory = new System.Windows.Forms.Label();
			this.TextBoxBaseUniDirectory = new System.Windows.Forms.TextBox();
			this.ButtonOpenBaseUniDirectory = new System.Windows.Forms.Button();
			this.ButtonDownloadUniFiles = new System.Windows.Forms.Button();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.ButtonOpenDownloadsDirectory = new System.Windows.Forms.Button();
			this.TextBoxDownloadsDirectory = new System.Windows.Forms.TextBox();
			this.LabelOriginDownloads = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonOptions = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.Enabled = false;
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.Visible = false;
			// 
			// LabelUniDirectory
			// 
			this.LabelUniDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelUniDirectory.AutoSize = true;
			this.LabelUniDirectory.Location = new System.Drawing.Point(139, 48);
			this.LabelUniDirectory.Name = "LabelUniDirectory";
			this.LabelUniDirectory.Size = new System.Drawing.Size(203, 17);
			this.LabelUniDirectory.TabIndex = 6;
			this.LabelUniDirectory.Text = "Base University Directory";
			// 
			// TextBoxBaseUniDirectory
			// 
			this.TextBoxBaseUniDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxBaseUniDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxBaseUniDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.TextBoxBaseUniDirectory, 2);
			this.TextBoxBaseUniDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxBaseUniDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxBaseUniDirectory.Location = new System.Drawing.Point(348, 45);
			this.TextBoxBaseUniDirectory.Name = "TextBoxBaseUniDirectory";
			this.TextBoxBaseUniDirectory.ReadOnly = true;
			this.TextBoxBaseUniDirectory.Size = new System.Drawing.Size(838, 24);
			this.TextBoxBaseUniDirectory.TabIndex = 7;
			// 
			// ButtonOpenBaseUniDirectory
			// 
			this.ButtonOpenBaseUniDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonOpenBaseUniDirectory.AutoSize = true;
			this.ButtonOpenBaseUniDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonOpenBaseUniDirectory.FlatAppearance.BorderSize = 0;
			this.ButtonOpenBaseUniDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonOpenBaseUniDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonOpenBaseUniDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOpenBaseUniDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonOpenBaseUniDirectory.Location = new System.Drawing.Point(1192, 43);
			this.ButtonOpenBaseUniDirectory.Name = "ButtonOpenBaseUniDirectory";
			this.ButtonOpenBaseUniDirectory.Size = new System.Drawing.Size(59, 27);
			this.ButtonOpenBaseUniDirectory.TabIndex = 8;
			this.ButtonOpenBaseUniDirectory.Text = "Open";
			this.ButtonOpenBaseUniDirectory.UseVisualStyleBackColor = true;
			this.ButtonOpenBaseUniDirectory.Click += new System.EventHandler(this.ButtonOpenDirectory_Click);
			// 
			// ButtonDownloadUniFiles
			// 
			this.ButtonDownloadUniFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonDownloadUniFiles.AutoSize = true;
			this.ButtonDownloadUniFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.ButtonDownloadUniFiles, 2);
			this.ButtonDownloadUniFiles.FlatAppearance.BorderSize = 0;
			this.ButtonDownloadUniFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonDownloadUniFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonDownloadUniFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDownloadUniFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonDownloadUniFiles.Location = new System.Drawing.Point(658, 79);
			this.ButtonDownloadUniFiles.Name = "ButtonDownloadUniFiles";
			this.ButtonDownloadUniFiles.Size = new System.Drawing.Size(217, 27);
			this.ButtonDownloadUniFiles.TabIndex = 9;
			this.ButtonDownloadUniFiles.Text = "Download University Files";
			this.ButtonDownloadUniFiles.UseVisualStyleBackColor = true;
			this.ButtonDownloadUniFiles.Click += new System.EventHandler(this.ButtonDownloadUniFiles_Click);
			// 
			// FolderBrowserDialog
			// 
			this.FolderBrowserDialog.UseDescriptionForTitle = true;
			// 
			// ButtonOpenDownloadsDirectory
			// 
			this.ButtonOpenDownloadsDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonOpenDownloadsDirectory.AutoSize = true;
			this.ButtonOpenDownloadsDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonOpenDownloadsDirectory.FlatAppearance.BorderSize = 0;
			this.ButtonOpenDownloadsDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonOpenDownloadsDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonOpenDownloadsDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOpenDownloadsDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonOpenDownloadsDirectory.Location = new System.Drawing.Point(1192, 5);
			this.ButtonOpenDownloadsDirectory.Name = "ButtonOpenDownloadsDirectory";
			this.ButtonOpenDownloadsDirectory.Size = new System.Drawing.Size(59, 27);
			this.ButtonOpenDownloadsDirectory.TabIndex = 13;
			this.ButtonOpenDownloadsDirectory.Text = "Open";
			this.ButtonOpenDownloadsDirectory.UseVisualStyleBackColor = true;
			this.ButtonOpenDownloadsDirectory.Click += new System.EventHandler(this.ButtonOpenDownloadsDirectory_Click);
			// 
			// TextBoxDownloadsDirectory
			// 
			this.TextBoxDownloadsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxDownloadsDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDownloadsDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.TextBoxDownloadsDirectory, 2);
			this.TextBoxDownloadsDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDownloadsDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDownloadsDirectory.Location = new System.Drawing.Point(348, 7);
			this.TextBoxDownloadsDirectory.Name = "TextBoxDownloadsDirectory";
			this.TextBoxDownloadsDirectory.ReadOnly = true;
			this.TextBoxDownloadsDirectory.Size = new System.Drawing.Size(838, 24);
			this.TextBoxDownloadsDirectory.TabIndex = 12;
			// 
			// LabelOriginDownloads
			// 
			this.LabelOriginDownloads.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelOriginDownloads.AutoSize = true;
			this.LabelOriginDownloads.Location = new System.Drawing.Point(3, 10);
			this.LabelOriginDownloads.Name = "LabelOriginDownloads";
			this.LabelOriginDownloads.Size = new System.Drawing.Size(339, 17);
			this.LabelOriginDownloads.TabIndex = 11;
			this.LabelOriginDownloads.Text = "Folder Where the Files are Downloaded To";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.Controls.Add(this.LabelOriginDownloads, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ButtonOptions, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.ButtonOpenDownloadsDirectory, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.ButtonDownloadUniFiles, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelUniDirectory, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ButtonOpenBaseUniDirectory, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxDownloadsDirectory, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxBaseUniDirectory, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1150, 149);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1255, 155);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// ButtonOptions
			// 
			this.ButtonOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonOptions.AutoSize = true;
			this.ButtonOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.ButtonOptions, 2);
			this.ButtonOptions.FlatAppearance.BorderSize = 0;
			this.ButtonOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonOptions.Location = new System.Drawing.Point(728, 117);
			this.ButtonOptions.Name = "ButtonOptions";
			this.ButtonOptions.Size = new System.Drawing.Size(78, 27);
			this.ButtonOptions.TabIndex = 10;
			this.ButtonOptions.Text = "Options";
			this.ButtonOptions.UseVisualStyleBackColor = true;
			this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(1153, 155);
			this.Name = "HomeScreen";
			this.Size = new System.Drawing.Size(1255, 155);
			this.Enter += new System.EventHandler(this.HomeScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelUniDirectory;
		private System.Windows.Forms.TextBox TextBoxBaseUniDirectory;
		private System.Windows.Forms.Button ButtonOpenBaseUniDirectory;
		private System.Windows.Forms.Button ButtonDownloadUniFiles;
		private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
		private System.Windows.Forms.Button ButtonOpenDownloadsDirectory;
		private System.Windows.Forms.TextBox TextBoxDownloadsDirectory;
		private System.Windows.Forms.Label LabelOriginDownloads;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button ButtonOptions;
	}
}
