namespace Lab5
{
    partial class Form1
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
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLevenshteinDist = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxParallTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxmaxDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxResult1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(14, 25);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(157, 28);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Выбрать файл";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(737, 429);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 31);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLevenshteinDist
            // 
            this.buttonLevenshteinDist.Location = new System.Drawing.Point(23, 134);
            this.buttonLevenshteinDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLevenshteinDist.Name = "buttonLevenshteinDist";
            this.buttonLevenshteinDist.Size = new System.Drawing.Size(129, 45);
            this.buttonLevenshteinDist.TabIndex = 9;
            this.buttonLevenshteinDist.Text = "Поиск";
            this.buttonLevenshteinDist.UseVisualStyleBackColor = true;
            this.buttonLevenshteinDist.Click += new System.EventHandler(this.buttonLevenshteinDist_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(606, 290);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.ReadOnly = true;
            this.textBoxFileReadTime.Size = new System.Drawing.Size(155, 22);
            this.textBoxFileReadTime.TabIndex = 14;
            // 
            // textBoxParallTime
            // 
            this.textBoxParallTime.Location = new System.Drawing.Point(535, 350);
            this.textBoxParallTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParallTime.Name = "textBoxParallTime";
            this.textBoxParallTime.ReadOnly = true;
            this.textBoxParallTime.Size = new System.Drawing.Size(144, 22);
            this.textBoxParallTime.TabIndex = 11;
            this.textBoxParallTime.Text = " ";
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(702, 238);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.ReadOnly = true;
            this.textBoxFileReadCount.Size = new System.Drawing.Size(130, 22);
            this.textBoxFileReadCount.TabIndex = 4;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(247, 77);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(499, 22);
            this.textBoxFind.TabIndex = 1;
            // 
            // textBoxmaxDist
            // 
            this.textBoxmaxDist.Location = new System.Drawing.Point(635, 146);
            this.textBoxmaxDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmaxDist.Name = "textBoxmaxDist";
            this.textBoxmaxDist.Size = new System.Drawing.Size(73, 22);
            this.textBoxmaxDist.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время чтения из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите значение для поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Результат поиска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Время поиска:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Максимальное расстояние для параллельного поиска:";
            // 
            // listBoxResult1
            // 
            this.listBoxResult1.FormattingEnabled = true;
            this.listBoxResult1.ItemHeight = 16;
            this.listBoxResult1.Location = new System.Drawing.Point(23, 233);
            this.listBoxResult1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxResult1.Name = "listBoxResult1";
            this.listBoxResult1.Size = new System.Drawing.Size(369, 228);
            this.listBoxResult1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 473);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.textBoxParallTime);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxmaxDist);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLevenshteinDist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxResult1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Поиск в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.TextBox textBoxmaxDist;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxParallTime;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonLevenshteinDist;

        private System.Windows.Forms.ListBox listBoxResult1;

    }
}

