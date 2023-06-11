namespace UWF
{
    partial class Settings
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
            this.ignoreFilePathTextbox = new System.Windows.Forms.TextBox();
            this.ignoreFilesPathLabel = new System.Windows.Forms.Label();
            this.selectIgnoreFileButton = new System.Windows.Forms.Button();
            this.ignoreFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ignoreFilePathTextbox
            // 
            this.ignoreFilePathTextbox.Location = new System.Drawing.Point(35, 56);
            this.ignoreFilePathTextbox.Multiline = true;
            this.ignoreFilePathTextbox.Name = "ignoreFilePathTextbox";
            this.ignoreFilePathTextbox.Size = new System.Drawing.Size(697, 60);
            this.ignoreFilePathTextbox.TabIndex = 0;
            this.ignoreFilePathTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ignoreFilesPathLabel
            // 
            this.ignoreFilesPathLabel.AutoSize = true;
            this.ignoreFilesPathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ignoreFilesPathLabel.Location = new System.Drawing.Point(35, 20);
            this.ignoreFilesPathLabel.Name = "ignoreFilesPathLabel";
            this.ignoreFilesPathLabel.Size = new System.Drawing.Size(203, 28);
            this.ignoreFilesPathLabel.TabIndex = 1;
            this.ignoreFilesPathLabel.Text = "Ignore words file path";
            // 
            // selectIgnoreFileButton
            // 
            this.selectIgnoreFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectIgnoreFileButton.Location = new System.Drawing.Point(746, 54);
            this.selectIgnoreFileButton.Name = "selectIgnoreFileButton";
            this.selectIgnoreFileButton.Size = new System.Drawing.Size(42, 62);
            this.selectIgnoreFileButton.TabIndex = 2;
            this.selectIgnoreFileButton.Text = "...";
            this.selectIgnoreFileButton.UseVisualStyleBackColor = true;
            this.selectIgnoreFileButton.Click += new System.EventHandler(this.SelectIgnoreFileButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.selectIgnoreFileButton);
            this.Controls.Add(this.ignoreFilesPathLabel);
            this.Controls.Add(this.ignoreFilePathTextbox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ignoreFilePathTextbox;
        private Label ignoreFilesPathLabel;
        private Button selectIgnoreFileButton;
        private OpenFileDialog ignoreFileOpenFileDialog;
    }
}