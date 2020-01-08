namespace TranslitToRussian
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReloadDictionaryButton = new System.Windows.Forms.Button();
            this.ChooseFilesButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.CheckedListBox();
            this.RenameSelectedButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.DeselectAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReloadDictionaryButton
            // 
            this.ReloadDictionaryButton.Location = new System.Drawing.Point(12, 13);
            this.ReloadDictionaryButton.Name = "ReloadDictionaryButton";
            this.ReloadDictionaryButton.Size = new System.Drawing.Size(129, 23);
            this.ReloadDictionaryButton.TabIndex = 0;
            this.ReloadDictionaryButton.Text = "Reload Dictionary";
            this.ReloadDictionaryButton.UseVisualStyleBackColor = true;
            this.ReloadDictionaryButton.Click += new System.EventHandler(this.ReloadDictionaryButton_Click);
            // 
            // ChooseFilesButton
            // 
            this.ChooseFilesButton.Location = new System.Drawing.Point(167, 12);
            this.ChooseFilesButton.Name = "ChooseFilesButton";
            this.ChooseFilesButton.Size = new System.Drawing.Size(114, 23);
            this.ChooseFilesButton.TabIndex = 1;
            this.ChooseFilesButton.Text = "Choose Files";
            this.ChooseFilesButton.UseVisualStyleBackColor = true;
            this.ChooseFilesButton.Click += new System.EventHandler(this.ChooseFilesButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(12, 52);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(674, 346);
            this.FilesListBox.TabIndex = 2;
            // 
            // RenameSelectedButton
            // 
            this.RenameSelectedButton.Location = new System.Drawing.Point(565, 13);
            this.RenameSelectedButton.Name = "RenameSelectedButton";
            this.RenameSelectedButton.Size = new System.Drawing.Size(121, 23);
            this.RenameSelectedButton.TabIndex = 3;
            this.RenameSelectedButton.Text = "Rename Selected";
            this.RenameSelectedButton.UseVisualStyleBackColor = true;
            this.RenameSelectedButton.Click += new System.EventHandler(this.RenameSelectedButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(314, 13);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(93, 23);
            this.SelectAllButton.TabIndex = 4;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // DeselectAllButton
            // 
            this.DeselectAllButton.Location = new System.Drawing.Point(435, 13);
            this.DeselectAllButton.Name = "DeselectAllButton";
            this.DeselectAllButton.Size = new System.Drawing.Size(99, 23);
            this.DeselectAllButton.TabIndex = 5;
            this.DeselectAllButton.Text = "Deselect All";
            this.DeselectAllButton.UseVisualStyleBackColor = true;
            this.DeselectAllButton.Click += new System.EventHandler(this.DeselectAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 411);
            this.Controls.Add(this.ChooseFilesButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.DeselectAllButton);
            this.Controls.Add(this.RenameSelectedButton);
            this.Controls.Add(this.ReloadDictionaryButton);
            this.Controls.Add(this.FilesListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReloadDictionaryButton;
        private System.Windows.Forms.Button ChooseFilesButton;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button DeselectAllButton;
        private System.Windows.Forms.Button RenameSelectedButton;
        private System.Windows.Forms.CheckedListBox FilesListBox;
    }
}

