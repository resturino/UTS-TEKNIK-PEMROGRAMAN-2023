namespace Tugas
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
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpBangun = new System.Windows.Forms.GroupBox();
            this.rdoNIM = new System.Windows.Forms.RadioButton();
            this.rdoSegi = new System.Windows.Forms.RadioButton();
            this.rdoPersegi = new System.Windows.Forms.RadioButton();
            this.grpSkor = new System.Windows.Forms.GroupBox();
            this.grpWarna = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdoBiru = new System.Windows.Forms.RadioButton();
            this.rdoPutih = new System.Windows.Forms.RadioButton();
            this.rdoKuning = new System.Windows.Forms.RadioButton();
            this.rdoMerah = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMode.SuspendLayout();
            this.grpBangun.SuspendLayout();
            this.grpWarna.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.checkBox2);
            this.grpMode.Controls.Add(this.checkBox1);
            this.grpMode.Location = new System.Drawing.Point(14, 17);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(307, 143);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(43, 88);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Game";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Visualisasi";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpBangun
            // 
            this.grpBangun.Controls.Add(this.rdoNIM);
            this.grpBangun.Controls.Add(this.rdoSegi);
            this.grpBangun.Controls.Add(this.rdoPersegi);
            this.grpBangun.Location = new System.Drawing.Point(17, 188);
            this.grpBangun.Name = "grpBangun";
            this.grpBangun.Size = new System.Drawing.Size(303, 133);
            this.grpBangun.TabIndex = 1;
            this.grpBangun.TabStop = false;
            this.grpBangun.Text = "Bangun Datar";
            this.grpBangun.Enter += new System.EventHandler(this.grpBangun_Enter);
            // 
            // rdoNIM
            // 
            this.rdoNIM.AutoSize = true;
            this.rdoNIM.Location = new System.Drawing.Point(30, 97);
            this.rdoNIM.Name = "rdoNIM";
            this.rdoNIM.Size = new System.Drawing.Size(96, 20);
            this.rdoNIM.TabIndex = 2;
            this.rdoNIM.TabStop = true;
            this.rdoNIM.Text = "3. Your NIM";
            this.rdoNIM.UseVisualStyleBackColor = true;
            this.rdoNIM.CheckedChanged += new System.EventHandler(this.rdoNIM_CheckedChanged);
            // 
            // rdoSegi
            // 
            this.rdoSegi.AutoSize = true;
            this.rdoSegi.Location = new System.Drawing.Point(30, 61);
            this.rdoSegi.Name = "rdoSegi";
            this.rdoSegi.Size = new System.Drawing.Size(124, 20);
            this.rdoSegi.TabIndex = 1;
            this.rdoSegi.TabStop = true;
            this.rdoSegi.Text = "2. Segi Delapan";
            this.rdoSegi.UseVisualStyleBackColor = true;
            this.rdoSegi.CheckedChanged += new System.EventHandler(this.rdoSegi_CheckedChanged);
            // 
            // rdoPersegi
            // 
            this.rdoPersegi.AutoSize = true;
            this.rdoPersegi.Location = new System.Drawing.Point(30, 22);
            this.rdoPersegi.Name = "rdoPersegi";
            this.rdoPersegi.Size = new System.Drawing.Size(88, 20);
            this.rdoPersegi.TabIndex = 0;
            this.rdoPersegi.TabStop = true;
            this.rdoPersegi.Text = "1. Persegi";
            this.rdoPersegi.UseVisualStyleBackColor = true;
            this.rdoPersegi.CheckedChanged += new System.EventHandler(this.rdoPersegi_CheckedChanged);
            // 
            // grpSkor
            // 
            this.grpSkor.Location = new System.Drawing.Point(16, 344);
            this.grpSkor.Name = "grpSkor";
            this.grpSkor.Size = new System.Drawing.Size(304, 87);
            this.grpSkor.TabIndex = 2;
            this.grpSkor.TabStop = false;
            this.grpSkor.Text = "Skor";
            this.grpSkor.Enter += new System.EventHandler(this.grpSkor_Enter);
            // 
            // grpWarna
            // 
            this.grpWarna.BackColor = System.Drawing.SystemColors.Menu;
            this.grpWarna.Controls.Add(this.textBox3);
            this.grpWarna.Controls.Add(this.textBox2);
            this.grpWarna.Controls.Add(this.textBox1);
            this.grpWarna.Controls.Add(this.richTextBox1);
            this.grpWarna.Controls.Add(this.rdoBiru);
            this.grpWarna.Controls.Add(this.rdoPutih);
            this.grpWarna.Controls.Add(this.rdoKuning);
            this.grpWarna.Controls.Add(this.rdoMerah);
            this.grpWarna.Location = new System.Drawing.Point(347, 326);
            this.grpWarna.Name = "grpWarna";
            this.grpWarna.Size = new System.Drawing.Size(431, 61);
            this.grpWarna.TabIndex = 3;
            this.grpWarna.TabStop = false;
            this.grpWarna.Text = "Warna";
            this.grpWarna.Enter += new System.EventHandler(this.grpWarna_Enter);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(354, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 15);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Putih";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(247, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(80, 15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Kuning";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(136, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(82, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Biru";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(28, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(81, 20);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Merah";
            // 
            // rdoBiru
            // 
            this.rdoBiru.AutoSize = true;
            this.rdoBiru.Location = new System.Drawing.Point(115, 26);
            this.rdoBiru.Name = "rdoBiru";
            this.rdoBiru.Size = new System.Drawing.Size(51, 20);
            this.rdoBiru.TabIndex = 3;
            this.rdoBiru.TabStop = true;
            this.rdoBiru.Text = "Biru";
            this.rdoBiru.UseVisualStyleBackColor = true;
            this.rdoBiru.CheckedChanged += new System.EventHandler(this.rdoBiru_CheckedChanged);
            // 
            // rdoPutih
            // 
            this.rdoPutih.AutoSize = true;
            this.rdoPutih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoPutih.Location = new System.Drawing.Point(333, 26);
            this.rdoPutih.Name = "rdoPutih";
            this.rdoPutih.Size = new System.Drawing.Size(57, 20);
            this.rdoPutih.TabIndex = 2;
            this.rdoPutih.TabStop = true;
            this.rdoPutih.Text = "Putih";
            this.rdoPutih.UseVisualStyleBackColor = true;
            this.rdoPutih.CheckedChanged += new System.EventHandler(this.rdoPutih_CheckedChanged);
            // 
            // rdoKuning
            // 
            this.rdoKuning.AutoSize = true;
            this.rdoKuning.Location = new System.Drawing.Point(224, 26);
            this.rdoKuning.Name = "rdoKuning";
            this.rdoKuning.Size = new System.Drawing.Size(68, 20);
            this.rdoKuning.TabIndex = 1;
            this.rdoKuning.TabStop = true;
            this.rdoKuning.Text = "Kuning";
            this.rdoKuning.UseVisualStyleBackColor = true;
            this.rdoKuning.CheckedChanged += new System.EventHandler(this.rdoKuning_CheckedChanged);
            // 
            // rdoMerah
            // 
            this.rdoMerah.AutoSize = true;
            this.rdoMerah.Location = new System.Drawing.Point(6, 28);
            this.rdoMerah.Name = "rdoMerah";
            this.rdoMerah.Size = new System.Drawing.Size(66, 20);
            this.rdoMerah.TabIndex = 0;
            this.rdoMerah.TabStop = true;
            this.rdoMerah.Text = "Merah";
            this.rdoMerah.UseVisualStyleBackColor = true;
            this.rdoMerah.CheckedChanged += new System.EventHandler(this.rdoMerah_CheckedChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(347, 398);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(109, 33);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(511, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(668, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlackboard.Location = new System.Drawing.Point(347, 17);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(431, 303);
            this.pnlBlackboard.TabIndex = 7;
            this.pnlBlackboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBlackboard_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBlackboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.grpWarna);
            this.Controls.Add(this.grpSkor);
            this.Controls.Add(this.grpBangun);
            this.Controls.Add(this.grpMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpBangun.ResumeLayout(false);
            this.grpBangun.PerformLayout();
            this.grpWarna.ResumeLayout(false);
            this.grpWarna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpBangun;
        private System.Windows.Forms.GroupBox grpSkor;
        private System.Windows.Forms.GroupBox grpWarna;
        private System.Windows.Forms.RadioButton rdoBiru;
        private System.Windows.Forms.RadioButton rdoPutih;
        private System.Windows.Forms.RadioButton rdoKuning;
        private System.Windows.Forms.RadioButton rdoMerah;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoNIM;
        private System.Windows.Forms.RadioButton rdoSegi;
        private System.Windows.Forms.RadioButton rdoPersegi;
        private System.Windows.Forms.Panel pnlBlackboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

