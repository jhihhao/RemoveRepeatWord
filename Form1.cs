using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveRepeatWord
{
    public partial class Form1 : Form
    {
        public string softVersion = " v0.0.1";
        public string fileContent = string.Empty;
        public string filePath = string.Empty;
        public string inputFileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
            Text += softVersion;
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog.FileName;
                inputFileName = openFileDialog.SafeFileName.Replace(".txt", "");
                filePath = tbFilePath.Text.Replace(openFileDialog.SafeFileName,"");

                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
        }

        private void btnRemoveRepeatWord_Click(object sender, EventArgs e)
        {
            var result = string.Join("", fileContent.Distinct());
            using StreamWriter file = new StreamWriter($"{filePath}{inputFileName}_RemoveRepeatWord.txt");
            file.WriteLine(result);
        }
    }
}
