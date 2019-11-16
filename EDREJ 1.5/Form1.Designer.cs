namespace EDREJ_1._5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtECD = new System.Windows.Forms.Panel();
            this.Dec = new System.Windows.Forms.Button();
            this.Cln = new System.Windows.Forms.Button();
            this.Enc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CipPan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ButtECD.SuspendLayout();
            this.CipPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 28);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(447, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EDREJ_1._5.Properties.Resources.aboutbutton;
            this.pictureBox2.Location = new System.Drawing.Point(474, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EDREJ_1._5.Properties.Resources.closebutton;
            this.pictureBox1.Location = new System.Drawing.Point(501, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 205);
            this.label2.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "EDREJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CipPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 379);
            this.MinimumSize = new System.Drawing.Size(525, 379);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDREJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ButtECD.ResumeLayout(false);
            this.CipPan.ResumeLayout(false);
            this.CipPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel ButtECD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel CipPan;
        public System.Windows.Forms.Button Dec;
        public System.Windows.Forms.Button Cln;
        public System.Windows.Forms.Button Enc;
        private System.Windows.Forms.Label label1;
    }
}

