using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWF
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ignoreFilePathTextbox.Text = Properties.Settings.Default.ignoresFilePath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ignoresFilePath = ignoreFilePathTextbox.Text;
            Properties.Settings.Default.Save();
        }

        private void SelectIgnoreFileButton_Click(object sender, EventArgs e)
        {
            if (ignoreFileOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ignoreFilePathTextbox.Text = ignoreFileOpenFileDialog.FileName;
            }
        }
    }
}
