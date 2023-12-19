namespace MultiThreadApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSymbolsHigh = new System.Windows.Forms.RadioButton();
            this.rbSymbolsLow = new System.Windows.Forms.RadioButton();
            this.rbSymbolsNormal = new System.Windows.Forms.RadioButton();
            this.rbLettersHigh = new System.Windows.Forms.RadioButton();
            this.rbLettersLow = new System.Windows.Forms.RadioButton();
            this.rbLettersNormal = new System.Windows.Forms.RadioButton();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.rbNumbersHigh = new System.Windows.Forms.RadioButton();
            this.rbNumbersLow = new System.Windows.Forms.RadioButton();
            this.rbNumbersNormal = new System.Windows.Forms.RadioButton();
            this.panelLetters = new System.Windows.Forms.Panel();
            this.panelSymbols = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNumbers.SuspendLayout();
            this.panelLetters.SuspendLayout();
            this.panelSymbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(515, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(151, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 303);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(287, 41);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 303);
            this.listBox3.TabIndex = 6;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(516, 100);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(117, 40);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поток чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поток букв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поток символолв";
            // 
            // rbSymbolsHigh
            // 
            this.rbSymbolsHigh.AutoSize = true;
            this.rbSymbolsHigh.Location = new System.Drawing.Point(3, 3);
            this.rbSymbolsHigh.Name = "rbSymbolsHigh";
            this.rbSymbolsHigh.Size = new System.Drawing.Size(47, 17);
            this.rbSymbolsHigh.TabIndex = 1;
            this.rbSymbolsHigh.TabStop = true;
            this.rbSymbolsHigh.Text = "High";
            this.rbSymbolsHigh.UseVisualStyleBackColor = true;
            this.rbSymbolsHigh.CheckedChanged += new System.EventHandler(this.rbSymbolsHigh_CheckedChanged_1);
            // 
            // rbSymbolsLow
            // 
            this.rbSymbolsLow.AutoSize = true;
            this.rbSymbolsLow.Location = new System.Drawing.Point(3, 71);
            this.rbSymbolsLow.Name = "rbSymbolsLow";
            this.rbSymbolsLow.Size = new System.Drawing.Size(45, 17);
            this.rbSymbolsLow.TabIndex = 3;
            this.rbSymbolsLow.TabStop = true;
            this.rbSymbolsLow.Text = "Low";
            this.rbSymbolsLow.UseVisualStyleBackColor = true;
            this.rbSymbolsLow.CheckedChanged += new System.EventHandler(this.rbSymbolsLow_CheckedChanged_1);
            // 
            // rbSymbolsNormal
            // 
            this.rbSymbolsNormal.AutoSize = true;
            this.rbSymbolsNormal.Location = new System.Drawing.Point(3, 36);
            this.rbSymbolsNormal.Name = "rbSymbolsNormal";
            this.rbSymbolsNormal.Size = new System.Drawing.Size(58, 17);
            this.rbSymbolsNormal.TabIndex = 2;
            this.rbSymbolsNormal.TabStop = true;
            this.rbSymbolsNormal.Text = "Normal";
            this.rbSymbolsNormal.UseVisualStyleBackColor = true;
            this.rbSymbolsNormal.CheckedChanged += new System.EventHandler(this.rbSymbolsNormal_CheckedChanged_1);
            // 
            // rbLettersHigh
            // 
            this.rbLettersHigh.AutoSize = true;
            this.rbLettersHigh.Location = new System.Drawing.Point(3, 3);
            this.rbLettersHigh.Name = "rbLettersHigh";
            this.rbLettersHigh.Size = new System.Drawing.Size(47, 17);
            this.rbLettersHigh.TabIndex = 1;
            this.rbLettersHigh.TabStop = true;
            this.rbLettersHigh.Text = "High";
            this.rbLettersHigh.UseVisualStyleBackColor = true;
            this.rbLettersHigh.CheckedChanged += new System.EventHandler(this.rbLettersHigh_CheckedChanged_1);
            // 
            // rbLettersLow
            // 
            this.rbLettersLow.AutoSize = true;
            this.rbLettersLow.Location = new System.Drawing.Point(3, 71);
            this.rbLettersLow.Name = "rbLettersLow";
            this.rbLettersLow.Size = new System.Drawing.Size(45, 17);
            this.rbLettersLow.TabIndex = 3;
            this.rbLettersLow.TabStop = true;
            this.rbLettersLow.Text = "Low";
            this.rbLettersLow.UseVisualStyleBackColor = true;
            this.rbLettersLow.CheckedChanged += new System.EventHandler(this.rbLettersLow_CheckedChanged_1);
            // 
            // rbLettersNormal
            // 
            this.rbLettersNormal.AutoSize = true;
            this.rbLettersNormal.Location = new System.Drawing.Point(3, 37);
            this.rbLettersNormal.Name = "rbLettersNormal";
            this.rbLettersNormal.Size = new System.Drawing.Size(58, 17);
            this.rbLettersNormal.TabIndex = 2;
            this.rbLettersNormal.TabStop = true;
            this.rbLettersNormal.Text = "Normal";
            this.rbLettersNormal.UseVisualStyleBackColor = true;
            this.rbLettersNormal.CheckedChanged += new System.EventHandler(this.rbLettersNormal_CheckedChanged_1);
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.rbNumbersHigh);
            this.panelNumbers.Controls.Add(this.rbNumbersLow);
            this.panelNumbers.Controls.Add(this.rbNumbersNormal);
            this.panelNumbers.Location = new System.Drawing.Point(34, 375);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(98, 100);
            this.panelNumbers.TabIndex = 8;
            // 
            // rbNumbersHigh
            // 
            this.rbNumbersHigh.AutoSize = true;
            this.rbNumbersHigh.Location = new System.Drawing.Point(3, 3);
            this.rbNumbersHigh.Name = "rbNumbersHigh";
            this.rbNumbersHigh.Size = new System.Drawing.Size(47, 17);
            this.rbNumbersHigh.TabIndex = 1;
            this.rbNumbersHigh.TabStop = true;
            this.rbNumbersHigh.Text = "High";
            this.rbNumbersHigh.UseVisualStyleBackColor = true;
            this.rbNumbersHigh.CheckedChanged += new System.EventHandler(this.rbNumbersHigh_CheckedChanged_1);
            // 
            // rbNumbersLow
            // 
            this.rbNumbersLow.AutoSize = true;
            this.rbNumbersLow.Location = new System.Drawing.Point(3, 71);
            this.rbNumbersLow.Name = "rbNumbersLow";
            this.rbNumbersLow.Size = new System.Drawing.Size(45, 17);
            this.rbNumbersLow.TabIndex = 3;
            this.rbNumbersLow.TabStop = true;
            this.rbNumbersLow.Text = "Low";
            this.rbNumbersLow.UseVisualStyleBackColor = true;
            this.rbNumbersLow.CheckedChanged += new System.EventHandler(this.rbNumbersLow_CheckedChanged_1);
            // 
            // rbNumbersNormal
            // 
            this.rbNumbersNormal.AutoSize = true;
            this.rbNumbersNormal.Location = new System.Drawing.Point(3, 37);
            this.rbNumbersNormal.Name = "rbNumbersNormal";
            this.rbNumbersNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNumbersNormal.TabIndex = 2;
            this.rbNumbersNormal.TabStop = true;
            this.rbNumbersNormal.Text = "Normal";
            this.rbNumbersNormal.UseVisualStyleBackColor = true;
            this.rbNumbersNormal.CheckedChanged += new System.EventHandler(this.rbNumbersNormal_CheckedChanged_1);
            // 
            // panelLetters
            // 
            this.panelLetters.Controls.Add(this.rbLettersHigh);
            this.panelLetters.Controls.Add(this.rbLettersLow);
            this.panelLetters.Controls.Add(this.rbLettersNormal);
            this.panelLetters.Location = new System.Drawing.Point(173, 375);
            this.panelLetters.Name = "panelLetters";
            this.panelLetters.Size = new System.Drawing.Size(98, 100);
            this.panelLetters.TabIndex = 9;
            // 
            // panelSymbols
            // 
            this.panelSymbols.Controls.Add(this.rbSymbolsHigh);
            this.panelSymbols.Controls.Add(this.rbSymbolsLow);
            this.panelSymbols.Controls.Add(this.rbSymbolsNormal);
            this.panelSymbols.Location = new System.Drawing.Point(309, 375);
            this.panelSymbols.Name = "panelSymbols";
            this.panelSymbols.Size = new System.Drawing.Size(98, 100);
            this.panelSymbols.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "УС Т А Н О В И Т Ь    П Р И О Р И Т Е Т";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.panelLetters);
            this.Controls.Add(this.panelSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelNumbers.ResumeLayout(false);
            this.panelNumbers.PerformLayout();
            this.panelLetters.ResumeLayout(false);
            this.panelLetters.PerformLayout();
            this.panelSymbols.ResumeLayout(false);
            this.panelSymbols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSymbolsHigh;
        private System.Windows.Forms.RadioButton rbSymbolsLow;
        private System.Windows.Forms.RadioButton rbSymbolsNormal;
        private System.Windows.Forms.RadioButton rbLettersHigh;
        private System.Windows.Forms.RadioButton rbLettersLow;
        private System.Windows.Forms.RadioButton rbLettersNormal;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.RadioButton rbNumbersHigh;
        private System.Windows.Forms.RadioButton rbNumbersLow;
        private System.Windows.Forms.RadioButton rbNumbersNormal;
        private System.Windows.Forms.Panel panelLetters;
        private System.Windows.Forms.Panel panelSymbols;
        private System.Windows.Forms.Label label4;
    }
}

