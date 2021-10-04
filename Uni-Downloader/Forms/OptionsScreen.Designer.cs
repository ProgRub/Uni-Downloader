
namespace Forms
{
	partial class OptionsScreen
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
			this.ListBoxFileFormats = new System.Windows.Forms.ListBox();
			this.LabelFileFormat = new System.Windows.Forms.Label();
			this.TextBoxFileFormat = new System.Windows.Forms.TextBox();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.LabelDescription = new System.Windows.Forms.Label();
			this.ButtonUndo = new System.Windows.Forms.Button();
			this.ButtonRedo = new System.Windows.Forms.Button();
			this.ButtonAddChangeFileFormat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ListBoxFileFormats
			// 
			this.ListBoxFileFormats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ListBoxFileFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListBoxFileFormats.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ListBoxFileFormats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ListBoxFileFormats.FormattingEnabled = true;
			this.ListBoxFileFormats.ItemHeight = 16;
			this.ListBoxFileFormats.Location = new System.Drawing.Point(566, 43);
			this.ListBoxFileFormats.Name = "ListBoxFileFormats";
			this.ListBoxFileFormats.Size = new System.Drawing.Size(409, 210);
			this.ListBoxFileFormats.TabIndex = 6;
			// 
			// LabelFileFormat
			// 
			this.LabelFileFormat.AutoSize = true;
			this.LabelFileFormat.Location = new System.Drawing.Point(32, 43);
			this.LabelFileFormat.Name = "LabelFileFormat";
			this.LabelFileFormat.Size = new System.Drawing.Size(94, 17);
			this.LabelFileFormat.TabIndex = 12;
			this.LabelFileFormat.Text = "File Format";
			// 
			// TextBoxFileFormat
			// 
			this.TextBoxFileFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxFileFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxFileFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxFileFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxFileFormat.Location = new System.Drawing.Point(132, 41);
			this.TextBoxFileFormat.Name = "TextBoxFileFormat";
			this.TextBoxFileFormat.Size = new System.Drawing.Size(428, 24);
			this.TextBoxFileFormat.TabIndex = 13;
			// 
			// TextBoxDescription
			// 
			this.TextBoxDescription.AcceptsReturn = true;
			this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDescription.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxDescription.Location = new System.Drawing.Point(132, 71);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.Size = new System.Drawing.Size(428, 182);
			this.TextBoxDescription.TabIndex = 15;
			// 
			// LabelDescription
			// 
			this.LabelDescription.AutoSize = true;
			this.LabelDescription.Location = new System.Drawing.Point(32, 73);
			this.LabelDescription.Name = "LabelDescription";
			this.LabelDescription.Size = new System.Drawing.Size(95, 17);
			this.LabelDescription.TabIndex = 14;
			this.LabelDescription.Text = "Description";
			// 
			// ButtonUndo
			// 
			this.ButtonUndo.AutoSize = true;
			this.ButtonUndo.FlatAppearance.BorderSize = 0;
			this.ButtonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonUndo.Image = global::Forms.Properties.Resources.Undo;
			this.ButtonUndo.Location = new System.Drawing.Point(304, 259);
			this.ButtonUndo.Name = "ButtonUndo";
			this.ButtonUndo.Size = new System.Drawing.Size(39, 32);
			this.ButtonUndo.TabIndex = 16;
			this.ButtonUndo.UseVisualStyleBackColor = true;
			// 
			// ButtonRedo
			// 
			this.ButtonRedo.AutoSize = true;
			this.ButtonRedo.FlatAppearance.BorderSize = 0;
			this.ButtonRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRedo.Image = global::Forms.Properties.Resources.Redo;
			this.ButtonRedo.Location = new System.Drawing.Point(349, 259);
			this.ButtonRedo.Name = "ButtonRedo";
			this.ButtonRedo.Size = new System.Drawing.Size(39, 32);
			this.ButtonRedo.TabIndex = 17;
			this.ButtonRedo.UseVisualStyleBackColor = true;
			// 
			// ButtonAddChangeFileFormat
			// 
			this.ButtonAddChangeFileFormat.AutoSize = true;
			this.ButtonAddChangeFileFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAddChangeFileFormat.FlatAppearance.BorderSize = 0;
			this.ButtonAddChangeFileFormat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddChangeFileFormat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddChangeFileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddChangeFileFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonAddChangeFileFormat.Location = new System.Drawing.Point(242, 297);
			this.ButtonAddChangeFileFormat.Name = "ButtonAddChangeFileFormat";
			this.ButtonAddChangeFileFormat.Size = new System.Drawing.Size(209, 27);
			this.ButtonAddChangeFileFormat.TabIndex = 18;
			this.ButtonAddChangeFileFormat.Text = "Add/Change File Format";
			this.ButtonAddChangeFileFormat.UseVisualStyleBackColor = true;
			// 
			// OptionsScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonAddChangeFileFormat);
			this.Controls.Add(this.ButtonRedo);
			this.Controls.Add(this.ButtonUndo);
			this.Controls.Add(this.TextBoxDescription);
			this.Controls.Add(this.LabelDescription);
			this.Controls.Add(this.TextBoxFileFormat);
			this.Controls.Add(this.LabelFileFormat);
			this.Controls.Add(this.ListBoxFileFormats);
			this.Name = "OptionsScreen";
			this.Size = new System.Drawing.Size(978, 447);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ListBoxFileFormats, 0);
			this.Controls.SetChildIndex(this.LabelFileFormat, 0);
			this.Controls.SetChildIndex(this.TextBoxFileFormat, 0);
			this.Controls.SetChildIndex(this.LabelDescription, 0);
			this.Controls.SetChildIndex(this.TextBoxDescription, 0);
			this.Controls.SetChildIndex(this.ButtonUndo, 0);
			this.Controls.SetChildIndex(this.ButtonRedo, 0);
			this.Controls.SetChildIndex(this.ButtonAddChangeFileFormat, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListBoxFileFormats;
		private System.Windows.Forms.Label LabelFileFormat;
		private System.Windows.Forms.TextBox TextBoxFileFormat;
		private System.Windows.Forms.TextBox TextBoxDescription;
		private System.Windows.Forms.Label LabelDescription;
		private System.Windows.Forms.Button ButtonUndo;
		private System.Windows.Forms.Button ButtonRedo;
		private System.Windows.Forms.Button ButtonAddChangeFileFormat;
	}
}
