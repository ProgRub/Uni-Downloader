
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
			this.TextBoxOriginFilename = new System.Windows.Forms.TextBox();
			this.LabelOrigin = new System.Windows.Forms.Label();
			this.LabelDestination = new System.Windows.Forms.Label();
			this.TextBoxDestinationFilename = new System.Windows.Forms.TextBox();
			this.LabelRenameFilename = new System.Windows.Forms.Label();
			this.TextBoxRenameFilename = new System.Windows.Forms.TextBox();
			this.ComboBoxDirectories = new System.Windows.Forms.ComboBox();
			this.LabelDestinyDirectory = new System.Windows.Forms.Label();
			this.ButtonMoveFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// TextBoxOriginFilename
			// 
			this.TextBoxOriginFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxOriginFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxOriginFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxOriginFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxOriginFilename.Location = new System.Drawing.Point(3, 52);
			this.TextBoxOriginFilename.Multiline = true;
			this.TextBoxOriginFilename.Name = "TextBoxOriginFilename";
			this.TextBoxOriginFilename.ReadOnly = true;
			this.TextBoxOriginFilename.Size = new System.Drawing.Size(800, 675);
			this.TextBoxOriginFilename.TabIndex = 13;
			// 
			// LabelOrigin
			// 
			this.LabelOrigin.AutoSize = true;
			this.LabelOrigin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelOrigin.Location = new System.Drawing.Point(375, 27);
			this.LabelOrigin.Name = "LabelOrigin";
			this.LabelOrigin.Size = new System.Drawing.Size(55, 17);
			this.LabelOrigin.TabIndex = 14;
			this.LabelOrigin.Text = "Origin";
			// 
			// LabelDestination
			// 
			this.LabelDestination.AutoSize = true;
			this.LabelDestination.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelDestination.Location = new System.Drawing.Point(1184, 27);
			this.LabelDestination.Name = "LabelDestination";
			this.LabelDestination.Size = new System.Drawing.Size(95, 17);
			this.LabelDestination.TabIndex = 16;
			this.LabelDestination.Text = "Destination";
			// 
			// TextBoxDestinationFilename
			// 
			this.TextBoxDestinationFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDestinationFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDestinationFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDestinationFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDestinationFilename.Location = new System.Drawing.Point(809, 52);
			this.TextBoxDestinationFilename.Multiline = true;
			this.TextBoxDestinationFilename.Name = "TextBoxDestinationFilename";
			this.TextBoxDestinationFilename.ReadOnly = true;
			this.TextBoxDestinationFilename.Size = new System.Drawing.Size(800, 675);
			this.TextBoxDestinationFilename.TabIndex = 15;
			// 
			// LabelRenameFilename
			// 
			this.LabelRenameFilename.AutoSize = true;
			this.LabelRenameFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelRenameFilename.Location = new System.Drawing.Point(490, 735);
			this.LabelRenameFilename.Name = "LabelRenameFilename";
			this.LabelRenameFilename.Size = new System.Drawing.Size(115, 17);
			this.LabelRenameFilename.TabIndex = 17;
			this.LabelRenameFilename.Text = "New FilePath";
			// 
			// TextBoxRenameFilename
			// 
			this.TextBoxRenameFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxRenameFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxRenameFilename.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxRenameFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxRenameFilename.Location = new System.Drawing.Point(611, 733);
			this.TextBoxRenameFilename.Name = "TextBoxRenameFilename";
			this.TextBoxRenameFilename.Size = new System.Drawing.Size(432, 24);
			this.TextBoxRenameFilename.TabIndex = 18;
			// 
			// ComboBoxDirectories
			// 
			this.ComboBoxDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ComboBoxDirectories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxDirectories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxDirectories.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ComboBoxDirectories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxDirectories.FormattingEnabled = true;
			this.ComboBoxDirectories.Location = new System.Drawing.Point(611, 763);
			this.ComboBoxDirectories.Name = "ComboBoxDirectories";
			this.ComboBoxDirectories.Size = new System.Drawing.Size(432, 24);
			this.ComboBoxDirectories.TabIndex = 19;
			// 
			// LabelDestinyDirectory
			// 
			this.LabelDestinyDirectory.AutoSize = true;
			this.LabelDestinyDirectory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelDestinyDirectory.Location = new System.Drawing.Point(464, 766);
			this.LabelDestinyDirectory.Name = "LabelDestinyDirectory";
			this.LabelDestinyDirectory.Size = new System.Drawing.Size(141, 17);
			this.LabelDestinyDirectory.TabIndex = 20;
			this.LabelDestinyDirectory.Text = "Destiny Directory";
			// 
			// ButtonMoveFile
			// 
			this.ButtonMoveFile.AutoSize = true;
			this.ButtonMoveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonMoveFile.FlatAppearance.BorderSize = 0;
			this.ButtonMoveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonMoveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonMoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMoveFile.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonMoveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonMoveFile.Location = new System.Drawing.Point(764, 793);
			this.ButtonMoveFile.Name = "ButtonMoveFile";
			this.ButtonMoveFile.Size = new System.Drawing.Size(90, 27);
			this.ButtonMoveFile.TabIndex = 21;
			this.ButtonMoveFile.Text = "Move File";
			this.ButtonMoveFile.UseVisualStyleBackColor = true;
			// 
			// DownloadScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonMoveFile);
			this.Controls.Add(this.LabelDestinyDirectory);
			this.Controls.Add(this.ComboBoxDirectories);
			this.Controls.Add(this.TextBoxRenameFilename);
			this.Controls.Add(this.LabelRenameFilename);
			this.Controls.Add(this.LabelDestination);
			this.Controls.Add(this.TextBoxDestinationFilename);
			this.Controls.Add(this.LabelOrigin);
			this.Controls.Add(this.TextBoxOriginFilename);
			this.Name = "DownloadScreen";
			this.Size = new System.Drawing.Size(1612, 841);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.TextBoxOriginFilename, 0);
			this.Controls.SetChildIndex(this.LabelOrigin, 0);
			this.Controls.SetChildIndex(this.TextBoxDestinationFilename, 0);
			this.Controls.SetChildIndex(this.LabelDestination, 0);
			this.Controls.SetChildIndex(this.LabelRenameFilename, 0);
			this.Controls.SetChildIndex(this.TextBoxRenameFilename, 0);
			this.Controls.SetChildIndex(this.ComboBoxDirectories, 0);
			this.Controls.SetChildIndex(this.LabelDestinyDirectory, 0);
			this.Controls.SetChildIndex(this.ButtonMoveFile, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxOriginFilename;
		private System.Windows.Forms.Label LabelOrigin;
		private System.Windows.Forms.Label LabelDestination;
		private System.Windows.Forms.TextBox TextBoxDestinationFilename;
		private System.Windows.Forms.Label LabelRenameFilename;
		private System.Windows.Forms.TextBox TextBoxRenameFilename;
		private System.Windows.Forms.ComboBox ComboBoxDirectories;
		private System.Windows.Forms.Label LabelDestinyDirectory;
		private System.Windows.Forms.Button ButtonMoveFile;
	}
}
