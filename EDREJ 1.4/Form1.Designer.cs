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
            this.LangSwich = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ButtCSA = new System.Windows.Forms.Panel();
            this.AuthorPan = new System.Windows.Forms.Panel();
            this.Cred = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CipPan.SuspendLayout();
            this.ButtECD.SuspendLayout();
            this.SettPan.SuspendLayout();
            this.LangSwich.SuspendLayout();
            this.ButtCSA.SuspendLayout();
            this.AuthorPan.SuspendLayout();
            this.Cred.SuspendLayout();
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
            this.CipPan.Location = new System.Drawing.Point(-2, 52);
            this.CipPan.Name = "CipPan";
            this.CipPan.Size = new System.Drawing.Size(529, 329);
            this.CipPan.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 60);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 205);
            this.label2.TabIndex = 4;
            // 
            // ButtECD
            // 
            this.ButtECD.Controls.Add(this.Dec);
            this.ButtECD.Controls.Add(this.Cln);
            this.ButtECD.Controls.Add(this.Enc);
            this.ButtECD.Location = new System.Drawing.Point(72, 276);
            this.ButtECD.Name = "ButtECD";
            this.ButtECD.Size = new System.Drawing.Size(384, 45);
            this.ButtECD.TabIndex = 1;
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.Color.Gainsboro;
            this.Dec.FlatAppearance.BorderSize = 0;
            this.Dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dec.Location = new System.Drawing.Point(259, 3);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(122, 39);
            this.Dec.TabIndex = 2;
            this.Dec.Text = "Decrypt";
            this.Dec.UseVisualStyleBackColor = false;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // Cln
            // 
            this.Cln.BackColor = System.Drawing.Color.Gainsboro;
            this.Cln.FlatAppearance.BorderSize = 0;
            this.Cln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cln.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cln.Location = new System.Drawing.Point(131, 3);
            this.Cln.Name = "Cln";
            this.Cln.Size = new System.Drawing.Size(122, 39);
            this.Cln.TabIndex = 1;
            this.Cln.Text = "Clean";
            this.Cln.UseVisualStyleBackColor = false;
            this.Cln.Click += new System.EventHandler(this.Cln_Click);
            // 
            // Enc
            // 
            this.Enc.BackColor = System.Drawing.Color.Gainsboro;
            this.Enc.FlatAppearance.BorderSize = 0;
            this.Enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enc.Location = new System.Drawing.Point(3, 3);
            this.Enc.Name = "Enc";
            this.Enc.Size = new System.Drawing.Size(122, 39);
            this.Enc.TabIndex = 0;
            this.Enc.Text = "Encrypt";
            this.Enc.UseVisualStyleBackColor = false;
            this.Enc.Click += new System.EventHandler(this.Enc_Click);
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
            this.SettPan.Controls.Add(this.LangSwich);
            this.SettPan.Location = new System.Drawing.Point(-2, 52);
            this.SettPan.Name = "SettPan";
            this.SettPan.Size = new System.Drawing.Size(529, 329);
            this.SettPan.TabIndex = 6;
            this.SettPan.Visible = false;
            // 
            // LangSwich
            // 
            this.LangSwich.BackColor = System.Drawing.Color.Gainsboro;
            this.LangSwich.Controls.Add(this.label3);
            this.LangSwich.Controls.Add(this.radioButton1);
            this.LangSwich.Controls.Add(this.radioButton2);
            this.LangSwich.Location = new System.Drawing.Point(159, 0);
            this.LangSwich.Name = "LangSwich";
            this.LangSwich.Size = new System.Drawing.Size(211, 81);
            this.LangSwich.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Language";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(60, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(58, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Russian";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ButtCSA
            // 
            this.ButtCSA.Controls.Add(this.Aut);
            this.ButtCSA.Controls.Add(this.Sett);
            this.ButtCSA.Controls.Add(this.Cip);
            this.ButtCSA.Controls.Add(this.label1);
            this.ButtCSA.Location = new System.Drawing.Point(10, 12);
            this.ButtCSA.Name = "ButtCSA";
            this.ButtCSA.Size = new System.Drawing.Size(260, 28);
            this.ButtCSA.TabIndex = 7;
            // 
            // AuthorPan
            // 
            this.AuthorPan.Controls.Add(this.Cred);
            this.AuthorPan.Location = new System.Drawing.Point(-2, 52);
            this.AuthorPan.Name = "AuthorPan";
            this.AuthorPan.Size = new System.Drawing.Size(529, 329);
            this.AuthorPan.TabIndex = 8;
            this.AuthorPan.Visible = false;
            // 
            // Cred
            // 
            this.Cred.BackColor = System.Drawing.Color.Gainsboro;
            this.Cred.Controls.Add(this.label6);
            this.Cred.Controls.Add(this.label5);
            this.Cred.Controls.Add(this.label4);
            this.Cred.Location = new System.Drawing.Point(159, 0);
            this.Cred.Name = "Cred";
            this.Cred.Size = new System.Drawing.Size(211, 81);
            this.Cred.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cipher by ZerZru.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Developed By Net2Fox.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDREJ 1.4.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 379);
            this.Controls.Add(this.ButtCSA);
            this.Controls.Add(this.CipPan);
            this.Controls.Add(this.SettPan);
            this.Controls.Add(this.AuthorPan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDREJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CipPan.ResumeLayout(false);
            this.CipPan.PerformLayout();
            this.ButtECD.ResumeLayout(false);
            this.SettPan.ResumeLayout(false);
            this.LangSwich.ResumeLayout(false);
            this.LangSwich.PerformLayout();
            this.ButtCSA.ResumeLayout(false);
            this.ButtCSA.PerformLayout();
            this.AuthorPan.ResumeLayout(false);
            this.Cred.ResumeLayout(false);
            this.Cred.PerformLayout();
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
        private System.Windows.Forms.Panel LangSwich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel ButtCSA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel AuthorPan;
        private System.Windows.Forms.Panel Cred;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

