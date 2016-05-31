namespace DiplomBolshakov
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
            this.label1 = new System.Windows.Forms.Label();
            this.YesRButton = new System.Windows.Forms.RadioButton();
            this.NoRButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CSSTBox = new System.Windows.Forms.TextBox();
            this.IndNor1TBox = new System.Windows.Forms.TextBox();
            this.FU1TBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ADdiasTBox = new System.Windows.Forms.TextBox();
            this.ADsystTBox = new System.Windows.Forms.TextBox();
            this.IndNor1TBox2 = new System.Windows.Forms.TextBox();
            this.KSR1TBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "                  Инфаркт миокарда. \r\nПрогнозирование осложнений пациентов";
            // 
            // YesRButton
            // 
            this.YesRButton.AutoSize = true;
            this.YesRButton.BackColor = System.Drawing.Color.Transparent;
            this.YesRButton.Location = new System.Drawing.Point(301, 94);
            this.YesRButton.Name = "YesRButton";
            this.YesRButton.Size = new System.Drawing.Size(40, 17);
            this.YesRButton.TabIndex = 1;
            this.YesRButton.TabStop = true;
            this.YesRButton.Text = "Да";
            this.YesRButton.UseVisualStyleBackColor = false;
            this.YesRButton.CheckedChanged += new System.EventHandler(this.YesRButton_CheckedChanged);
            // 
            // NoRButton
            // 
            this.NoRButton.AutoSize = true;
            this.NoRButton.BackColor = System.Drawing.Color.Transparent;
            this.NoRButton.Location = new System.Drawing.Point(373, 94);
            this.NoRButton.Name = "NoRButton";
            this.NoRButton.Size = new System.Drawing.Size(44, 17);
            this.NoRButton.TabIndex = 2;
            this.NoRButton.TabStop = true;
            this.NoRButton.Text = "Нет";
            this.NoRButton.UseVisualStyleBackColor = false;
            this.NoRButton.CheckedChanged += new System.EventHandler(this.NoRButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(271, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заболевание лёгких";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.BackColor = System.Drawing.Color.Transparent;
            this.Resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Resultlabel.ForeColor = System.Drawing.Color.Red;
            this.Resultlabel.Location = new System.Drawing.Point(277, 240);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(0, 20);
            this.Resultlabel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CSSTBox);
            this.panel1.Controls.Add(this.IndNor1TBox);
            this.panel1.Controls.Add(this.FU1TBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 38);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(346, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "ЧСС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(146, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "ИндНор1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "ФУ1";
            // 
            // CSSTBox
            // 
            this.CSSTBox.Location = new System.Drawing.Point(381, 10);
            this.CSSTBox.Name = "CSSTBox";
            this.CSSTBox.Size = new System.Drawing.Size(88, 20);
            this.CSSTBox.TabIndex = 21;
            // 
            // IndNor1TBox
            // 
            this.IndNor1TBox.Location = new System.Drawing.Point(220, 11);
            this.IndNor1TBox.Name = "IndNor1TBox";
            this.IndNor1TBox.Size = new System.Drawing.Size(88, 20);
            this.IndNor1TBox.TabIndex = 20;
            // 
            // FU1TBox
            // 
            this.FU1TBox.Location = new System.Drawing.Point(44, 10);
            this.FU1TBox.Name = "FU1TBox";
            this.FU1TBox.Size = new System.Drawing.Size(88, 20);
            this.FU1TBox.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ADdiasTBox);
            this.panel2.Controls.Add(this.ADsystTBox);
            this.panel2.Controls.Add(this.IndNor1TBox2);
            this.panel2.Controls.Add(this.KSR1TBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 47);
            this.panel2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(493, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "АДдиаст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(326, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "АДсист";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(146, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "ИндНор1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "КСР1";
            // 
            // ADdiasTBox
            // 
            this.ADdiasTBox.Location = new System.Drawing.Point(556, 14);
            this.ADdiasTBox.Name = "ADdiasTBox";
            this.ADdiasTBox.Size = new System.Drawing.Size(88, 20);
            this.ADdiasTBox.TabIndex = 23;
            // 
            // ADsystTBox
            // 
            this.ADsystTBox.Location = new System.Drawing.Point(381, 13);
            this.ADsystTBox.Name = "ADsystTBox";
            this.ADsystTBox.Size = new System.Drawing.Size(88, 20);
            this.ADsystTBox.TabIndex = 22;
            // 
            // IndNor1TBox2
            // 
            this.IndNor1TBox2.Location = new System.Drawing.Point(220, 13);
            this.IndNor1TBox2.Name = "IndNor1TBox2";
            this.IndNor1TBox2.Size = new System.Drawing.Size(88, 20);
            this.IndNor1TBox2.TabIndex = 21;
            // 
            // KSR1TBox
            // 
            this.KSR1TBox.Location = new System.Drawing.Point(44, 13);
            this.KSR1TBox.Name = "KSR1TBox";
            this.KSR1TBox.Size = new System.Drawing.Size(88, 20);
            this.KSR1TBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiplomBolshakov.Properties.Resources.IvanImage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoRButton);
            this.Controls.Add(this.YesRButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Прогнозирование осложнений";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton YesRButton;
        private System.Windows.Forms.RadioButton NoRButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CSSTBox;
        private System.Windows.Forms.TextBox IndNor1TBox;
        private System.Windows.Forms.TextBox FU1TBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ADdiasTBox;
        private System.Windows.Forms.TextBox ADsystTBox;
        private System.Windows.Forms.TextBox IndNor1TBox2;
        private System.Windows.Forms.TextBox KSR1TBox;
        private System.Windows.Forms.Label label1;
    }
}

