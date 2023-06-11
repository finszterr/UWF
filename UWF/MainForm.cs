using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace UWF
{
    public partial class MainForm : Form
    {
        readonly string[] charsToRemove = new string[] { ",", ".", ";", "!", "?", "/"};

        public MainForm()
        {
            InitializeComponent();
        }

        private void sourceFileButton_Click(object sender, EventArgs e)
        {
            if (sourceFileOpenFileDialog.ShowDialog() == DialogResult.OK) {
                sourceFileTextBox.Text = sourceFileOpenFileDialog.FileName;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            Dictionary<string, int> dict = new();
            HashSet<string> ignore = new();

            SetIgnoreSet(ignore);

            try
            {
                if ((myStream = sourceFileOpenFileDialog.OpenFile()) != null)
                {
                    string currLine = "";
                    StreamReader reader = new StreamReader(sourceFileOpenFileDialog.FileName, Encoding.UTF8);
                    while ((currLine = reader.ReadLine()) != null)
                    {
                        if (IsEmptyNumberOrTiming(currLine))
                            continue;

                        currLine = currLine.Trim();
                        
                        foreach (string c in charsToRemove)
                        {
                            currLine = currLine.Replace(c, string.Empty);
                        }
                        string[] words = currLine.Split(" ");

                        foreach (string w in words)
                        {
                            if (ignore.Contains(w))
                                continue;

                            if (Decimal.TryParse(w, out decimal number))
                                continue;
                                

                            if (dict.ContainsKey(w))
                            {
                                dict[w] = dict[w] + 1;
                            }
                            else
                            {
                                dict.Add(w, 1);
                            }
                        }

                    }
                }
                File.WriteAllLines(sourceFileOpenFileDialog.FileName + ".csv",
                    dict.Select(x => x.Key + ";" + x.Value + ";"));

                MessageBox.Show(sourceFileOpenFileDialog.FileName + ".csv file has been created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        string pattern = @"\d{2}:\d{2}";
        bool IsEmptyNumberOrTiming(string line)
        {
            if (line == "")
                return true;
            if (int.TryParse(line, out _))
                return true;
            if (Regex.IsMatch(line, pattern))
                return true;

            return false;
        }

        void SetIgnoreSet(HashSet<string> set)
        {
            try
            {
                var path = Properties.Settings.Default.ignoresFilePath;
                StreamReader reader = new StreamReader(path, Encoding.UTF8);
                string currLine = "";

                while ((currLine = reader.ReadLine()) != null)
                {
                    if (IsEmptyNumberOrTiming(currLine))
                        continue;

                    currLine = currLine.Trim();

                    foreach (string c in charsToRemove)
                    {
                        currLine = currLine.Replace(c, string.Empty);
                    }
                    string[] words = currLine.Split(" ");

                    foreach (string w in words)
                    {
                        set.Add(w);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings se = new();
            se.StartPosition = FormStartPosition.CenterScreen;
            se.Show();
        }
    }
}