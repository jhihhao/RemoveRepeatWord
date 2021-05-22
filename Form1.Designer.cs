
namespace RemoveRepeatWord
{
    partial class Form1
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
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnRemoveRepeatWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpenTextFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTextFile.Location = new System.Drawing.Point(3, 17);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(121, 62);
            this.btnOpenTextFile.TabIndex = 0;
            this.btnOpenTextFile.Text = "文字檔路徑";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFilePath.Location = new System.Drawing.Point(132, 37);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(261, 23);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnRemoveRepeatWord
            // 
            this.btnRemoveRepeatWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveRepeatWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveRepeatWord.Location = new System.Drawing.Point(3, 116);
            this.btnRemoveRepeatWord.Name = "btnRemoveRepeatWord";
            this.btnRemoveRepeatWord.Size = new System.Drawing.Size(121, 59);
            this.btnRemoveRepeatWord.TabIndex = 2;
            this.btnRemoveRepeatWord.Text = "刪除重複文字";
            this.btnRemoveRepeatWord.UseVisualStyleBackColor = true;
            this.btnRemoveRepeatWord.Click += new System.EventHandler(this.btnRemoveRepeatWord_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.57576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.42424F));
            this.tableLayoutPanel1.Controls.Add(this.btnOpenTextFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveRepeatWord, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 195);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 218);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Remove Repeat Word";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTextFile;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnRemoveRepeatWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

