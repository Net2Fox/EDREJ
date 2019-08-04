namespace EDREJ_1._4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Cip = new System.Windows.Forms.Button();
            this.Sett = new System.Windows.Forms.Button();
            this.CipPan = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtECD = new System.Windows.Forms.Panel();
            this.Dec = new System.Windows.Forms.Button();
            this.Cln = new System.Windows.Forms.Button();
            this.Enc = new System.Windows.Forms.Button();
            this.Aut = new System.Windows.Forms.Button();
            this.SettPan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CipPan.SuspendLayout();
            this.ButtECD.SuspendLayout();
            this.SettPan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(-2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "____________";
            // 
            // Cip
            // 
            this.Cip.BackColor = System.Drawing.Color.White;
            this.Cip.FlatAppearance.BorderSize = 0;
            this.Cip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cip.Location = new System.Drawing.Point(1, 1);
            this.Cip.Name = "Cip";
            this.Cip.Size = new System.Drawing.Size(73, 23);
            this.Cip.TabIndex = 1;
            this.Cip.Text = "Cipher";
            this.Cip.UseVisualStyleBackColor = false;
            this.Cip.Click += new System.EventHandler(this.Cip_Click);
            // 
            // Sett
            // 
            this.Sett.BackColor = System.Drawing.Color.White;
            this.Sett.FlatAppearance.BorderSize = 0;
            this.Sett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sett.Location = new System.Drawing.Point(93, 1);
            this.Sett.Name = "Sett";
            this.Sett.Size = new System.Drawing.Size(73, 23);
            this.Sett.TabIndex = 2;
            this.Sett.Text = "Settings";
            this.Sett.UseVisualStyleBackColor = false;
            this.Sett.Click += new System.EventHandler(this.Sett_Click);
            // 
            // CipPan
            // 
            this.CipPan.BackColor = System.Drawing.Color.Transparent;
            this.CipPan.Controls.Add(this.textBox1);
            this.CipPan.Controls.Add(this.label2);
            this.CipPan.Controls.Add(this.ButtECD);
            this.CipPan.Location = new System.Drawing.Point(-1, 384);
            this.CipPan.Name = "CipPan";
            this.CipPan.Size = new System.Drawing.Size(529, 383);
            this.CipPan.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 32);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 235);
            this.label2.TabIndex = 4;
            // 
            // ButtECD
            // 
            this.ButtECD.Controls.Add(this.Dec);
            this.ButtECD.Controls.Add(this.Cln);
            this.ButtECD.Controls.Add(this.Enc);
            this.ButtECD.Location = new System.Drawing.Point(142, 340);
            this.ButtECD.Name = "ButtECD";
            this.ButtECD.Size = new System.Drawing.Size(244, 29);
            this.ButtECD.TabIndex = 1;
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.Color.Gainsboro;
            this.Dec.FlatAppearance.BorderSize = 0;
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dec.Location = new System.Drawing.Point(165, 3);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(75, 23);
            this.Dec.TabIndex = 2;
            this.Dec.Text = "Decrypt";
            this.Dec.UseVisualStyleBackColor = false;
            // 
            // Cln
            // 
            this.Cln.BackColor = System.Drawing.Color.Gainsboro;
            this.Cln.FlatAppearance.BorderSize = 0;
            this.Cln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cln.Location = new System.Drawing.Point(84, 3);
            this.Cln.Name = "Cln";
            this.Cln.Size = new System.Drawing.Size(75, 23);
            this.Cln.TabIndex = 1;
            this.Cln.Text = "Clean";
            this.Cln.UseVisualStyleBackColor = false;
            // 
            // Enc
            // 
            this.Enc.BackColor = System.Drawing.Color.Gainsboro;
            this.Enc.FlatAppearance.BorderSize = 0;
            this.Enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enc.Location = new System.Drawing.Point(3, 3);
            this.Enc.Name = "Enc";
            this.Enc.Size = new System.Drawing.Size(75, 23);
            this.Enc.TabIndex = 0;
            this.Enc.Text = "Encrypt";
            this.Enc.UseVisualStyleBackColor = false;
            // 
            // Aut
            // 
            this.Aut.BackColor = System.Drawing.Color.White;
            this.Aut.FlatAppearance.BorderSize = 0;
            this.Aut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aut.Location = new System.Drawing.Point(186, 1);
            this.Aut.Name = "Aut";
            this.Aut.Size = new System.Drawing.Size(73, 23);
            this.Aut.TabIndex = 4;
            this.Aut.Text = "Author";
            this.Aut.UseVisualStyleBackColor = false;
            this.Aut.Click += new System.EventHandler(this.Aut_Click);
            // 
            // SettPan
            // 
            this.SettPan.BackColor = System.Drawing.Color.Transparent;
            this.SettPan.Controls.Add(this.panel1);
            this.SettPan.Location = new System.Drawing.Point(536, -2);
            this.SettPan.Name = "SettPan";
            this.SettPan.Size = new System.Drawing.Size(529, 383);
            this.SettPan.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(13, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 94);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Animations";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Aut);
            this.panel2.Controls.Add(this.Sett);
            this.panel2.Controls.Add(this.Cip);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 28);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CipPan);
            this.Controls.Add(this.SettPan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EDREJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CipPan.ResumeLayout(false);
            this.CipPan.PerformLayout();
            this.ButtECD.ResumeLayout(false);
            this.SettPan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cip;
        private System.Windows.Forms.Button Sett;
        private System.Windows.Forms.Panel CipPan;
        private System.Windows.Forms.Panel ButtECD;
        private System.Windows.Forms.Button Enc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button Cln;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Aut;
        private System.Windows.Forms.Panel SettPan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
    }
}

