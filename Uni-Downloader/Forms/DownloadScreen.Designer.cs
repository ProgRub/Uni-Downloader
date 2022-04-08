
namespace Forms
{
	partial class DownloadScreen
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
			this.TextBoxDestinationFilename = new System.Windows.Forms.TextBox();
			this.TextBoxOriginFilename = new System.Windows.Forms.TextBox();
			this.LabelDestination = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelRenameFilename = new System.Windows.Forms.Label();
			this.TextBoxRenameFilename = new System.Windows.Forms.TextBox();
			this.ComboBoxDirectories = new System.Windows.Forms.ComboBox();
			this.ButtonMoveFile = new System.Windows.Forms.Button();
			this.LabelDestinyDirectory = new System.Windows.Forms.Label();
			this.LabelOrigin = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// TextBoxDestinationFilename
			// 
			this.TextBoxDestinationFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDestinationFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDestinationFilename.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDestinationFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDestinationFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDestinationFilename.Location = new System.Drawing.Point(538, 34);
			this.TextBoxDestinationFilename.Multiline = true;
			this.TextBoxDestinationFilename.Name = "TextBoxDestinationFilename";
			this.TextBoxDestinationFilename.ReadOnly = true;
			this.TextBoxDestinationFilename.Size = new System.Drawing.Size(529, 599);
			this.TextBoxDestinationFilename.TabIndex = 15;
			// 
			// TextBoxOriginFilename
			// 
			this.TextBoxOriginFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxOriginFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxOriginFilename.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxOriginFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxOriginFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxOriginFilename.Location = new System.Drawing.Point(3, 34);
			this.TextBoxOriginFilename.Multiline = true;
			this.TextBoxOriginFilename.Name = "TextBoxOriginFilename";
			this.TextBoxOriginFilename.ReadOnly = true;
			this.TextBoxOriginFilename.Size = new System.Drawing.Size(529, 599);
			this.TextBoxOriginFilename.TabIndex = 13;
			// 
			// LabelDestination
			// 
			this.LabelDestination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelDestination.AutoSize = true;
			this.LabelDestination.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelDestination.Location = new System.Drawing.Point(755, 14);
			this.LabelDestination.Name = "LabelDestination";
			this.LabelDestination.Size = new System.Drawing.Size(95, 17);
			this.LabelDestination.TabIndex = 16;
			this.LabelDestination.Text = "Destination";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel2.Controls.Add(this.LabelRenameFilename, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.TextBoxRenameFilename, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ComboBoxDirectories, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.ButtonMoveFile, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.LabelDestinyDirectory, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(148, 639);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 104);
			this.tableLayoutPanel2.TabIndex = 23;
			// 
			// LabelRenameFilename
			// 
			this.LabelRenameFilename.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelRenameFilename.AutoSize = true;
			this.LabelRenameFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelRenameFilename.Location = new System.Drawing.Point(82, 9);
			this.LabelRenameFilename.Name = "LabelRenameFilename";
			this.LabelRenameFilename.Size = new System.Drawing.Size(108, 17);
			this.LabelRenameFilename.TabIndex = 17;
			this.LabelRenameFilename.Text = "New FilePath";
			// 
			// TextBoxRenameFilename
			// 
			this.TextBoxRenameFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxRenameFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxRenameFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxRenameFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxRenameFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxRenameFilename.Location = new System.Drawing.Point(196, 6);
			this.TextBoxRenameFilename.Name = "TextBoxRenameFilename";
			this.TextBoxRenameFilename.Size = new System.Drawing.Size(575, 24);
			this.TextBoxRenameFilename.TabIndex = 18;
			// 
			// ComboBoxDirectories
			// 
			this.ComboBoxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBoxDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ComboBoxDirectories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxDirectories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxDirectories.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ComboBoxDirectories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxDirectories.FormattingEnabled = true;
			this.ComboBoxDirectories.Location = new System.Drawing.Point(196, 41);
			this.ComboBoxDirectories.Name = "ComboBoxDirectories";
			this.ComboBoxDirectories.Size = new System.Drawing.Size(575, 24);
			this.ComboBoxDirectories.TabIndex = 19;
			// 
			// ButtonMoveFile
			// 
			this.ButtonMoveFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ButtonMoveFile.AutoSize = true;
			this.ButtonMoveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.SetColumnSpan(this.ButtonMoveFile, 2);
			this.ButtonMoveFile.FlatAppearance.BorderSize = 0;
			this.ButtonMoveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonMoveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonMoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMoveFile.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonMoveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonMoveFile.Location = new System.Drawing.Point(342, 75);
			this.ButtonMoveFile.Name = "ButtonMoveFile";
			this.ButtonMoveFile.Size = new System.Drawing.Size(90, 26);
			this.ButtonMoveFile.TabIndex = 21;
			this.ButtonMoveFile.Text = "Move File";
			this.ButtonMoveFile.UseVisualStyleBackColor = true;
			this.ButtonMoveFile.Click += new System.EventHandler(this.ButtonMoveFile_Click);
			// 
			// LabelDestinyDirectory
			// 
			this.LabelDestinyDirectory.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelDestinyDirectory.AutoSize = true;
			this.LabelDestinyDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelDestinyDirectory.Location = new System.Drawing.Point(49, 45);
			this.LabelDestinyDirectory.Name = "LabelDestinyDirectory";
			this.LabelDestinyDirectory.Size = new System.Drawing.Size(141, 17);
			this.LabelDestinyDirectory.TabIndex = 20;
			this.LabelDestinyDirectory.Text = "Destiny Directory";
			// 
			// LabelOrigin
			// 
			this.LabelOrigin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LabelOrigin.AutoSize = true;
			this.LabelOrigin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelOrigin.Location = new System.Drawing.Point(240, 14);
			this.LabelOrigin.Name = "LabelOrigin";
			this.LabelOrigin.Size = new System.Drawing.Size(55, 17);
			this.LabelOrigin.TabIndex = 14;
			this.LabelOrigin.Text = "Origin";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.LabelOrigin, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelDestination, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxOriginFilename, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxDestinationFilename, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1070, 747);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 747);
			this.tableLayoutPanel1.TabIndex = 22;
			// 
			// DownloadScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(1070, 747);
			this.Name = "DownloadScreen";
			this.Size = new System.Drawing.Size(1070, 747);
			this.Enter += new System.EventHandler(this.DownloadScreen_Enter);
			this.Leave += new System.EventHandler(this.DownloadScreen_Leave);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxDestinationFilename;
		private System.Windows.Forms.TextBox TextBoxOriginFilename;
		private System.Windows.Forms.Label LabelDestination;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelOrigin;
		private System.Windows.Forms.Label LabelRenameFilename;
		private System.Windows.Forms.TextBox TextBoxRenameFilename;
		private System.Windows.Forms.ComboBox ComboBoxDirectories;
		private System.Windows.Forms.Button ButtonMoveFile;
		private System.Windows.Forms.Label LabelDestinyDirectory;
	}
}
