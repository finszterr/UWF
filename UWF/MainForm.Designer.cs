namespace UWF
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
            this.sourceFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sourceFileButton = new System.Windows.Forms.Button();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceFileOpenFileDialog
            // 
            this.sourceFileOpenFileDialog.Title = "Select the source file";
            // 
            // sourceFileButton
            // 
            this.sourceFileButton.Location = new System.Drawing.Point(28, 83);
            this.sourceFileButton.Name = "sourceFileButton";
            this.sourceFileButton.Size = new System.Drawing.Size(955, 31);
            this.sourceFileButton.TabIndex = 0;
            this.sourceFileButton.Text = "Get source file";
            this.sourceFileButton.UseVisualStyleBackColor = true;
            this.sourceFileButton.Click += new System.EventHandler(this.sourceFileButton_Click);
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Location = new System.Drawing.Point(28, 128);
            this.sourceFileTextBox.Multiline = true;
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(955, 67);
            this.sourceFileTextBox.TabIndex = 1;
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.processButton.Location = new System.Drawing.Point(28, 213);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(955, 54);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::UWF.Properties.Resources.settings_gear_icon;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Location = new System.Drawing.Point(928, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(55, 38);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 313);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.sourceFileTextBox);
            this.Controls.Add(this.sourceFileButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unique word finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog sourceFileOpenFileDialog;
        private Button sourceFileButton;
        private TextBox sourceFileTextBox;
        private Button processButton;
        private Button settingsButton;
    }
}