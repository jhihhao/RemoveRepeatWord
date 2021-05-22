using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoveRepeatWord
{
    public partial class Form1 : Form
    {
        public string softVersion = " v0.0.4";
        public string fileContent = string.Empty;
        public string filePath = string.Empty;
        public string inputFileName = string.Empty;
        public string fileEncoding = string.Empty;
        public Form1()
        {
            InitializeComponent();
            Text += softVersion;
        }

        private void BtnOpenTextFile_Click(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;
            tbResult.BackColor = Color.White;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog.FileName;
                inputFileName = openFileDialog.SafeFileName.Replace(".txt", "");
                filePath = tbFilePath.Text.Replace(openFileDialog.SafeFileName,"");

                Stream fs = File.OpenRead(openFileDialog.FileName);

                fileEncoding = DetectFileEncoding(fs);
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                if (fileEncoding == "ISO-8859-1")
                {
                    // Big-5
                    using StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding(950), true);
                    fileContent = reader.ReadToEnd();

                }
                else
                {
                    using StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding(fileEncoding), true);
                    fileContent = reader.ReadToEnd();
                }
            }
        }
        public string DetectFileEncoding(Stream fileStream)
        {
            var Utf8EncodingVerifier = Encoding.GetEncoding("utf-8", new EncoderExceptionFallback(), new DecoderExceptionFallback());
            using (var reader = new StreamReader(fileStream, Utf8EncodingVerifier,
                   detectEncodingFromByteOrderMarks: true, leaveOpen: true, bufferSize: 1024))
            {
                string detectedEncoding;
                try
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                    }
                    detectedEncoding = reader.CurrentEncoding.BodyName;
                }
                catch (Exception e)
                {
                    // Failed to decode the file using the BOM/UT8. 
                    // Assume it's local ANSI
                    detectedEncoding = "ISO-8859-1";
                }
                // Rewind the stream
                fileStream.Seek(0, SeekOrigin.Begin);
                return detectedEncoding;
            }
        }

        private void BtnRemoveRepeatWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                MessageBox.Show("請選擇檔案");
                return;
            }
            var result = string.Join("", fileContent.Distinct());
            if (fileEncoding == "ISO-8859-1")
            {
                using StreamWriter file = new StreamWriter($"{filePath}{inputFileName}_RemoveRepeatWord.txt", false, Encoding.GetEncoding("big5"));
                file.WriteLine(result);
            }
            else
            {
                using StreamWriter file = new StreamWriter($"{filePath}{inputFileName}_RemoveRepeatWord.txt");
                file.WriteLine(result);
            }

            tbResult.Text = "已完成";
            tbResult.BackColor = Color.LightGreen;
        }
    }
}
