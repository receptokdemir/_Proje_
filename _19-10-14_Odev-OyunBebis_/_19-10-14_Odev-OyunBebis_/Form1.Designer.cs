namespace _19_10_14_Odev_OyunBebis_
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYemekYe = new System.Windows.Forms.Button();
            this.btnTuvaleteGit = new System.Windows.Forms.Button();
            this.btnUyut = new System.Windows.Forms.Button();
            this.btnOldur = new System.Windows.Forms.Button();
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnYemekYe
            // 
            this.btnYemekYe.Location = new System.Drawing.Point(374, 52);
            this.btnYemekYe.Name = "btnYemekYe";
            this.btnYemekYe.Size = new System.Drawing.Size(185, 148);
            this.btnYemekYe.TabIndex = 1;
            this.btnYemekYe.Text = "Yemek Ye";
            this.btnYemekYe.UseVisualStyleBackColor = true;
            this.btnYemekYe.Click += new System.EventHandler(this.btnYemekYe_Click);
            // 
            // btnTuvaleteGit
            // 
            this.btnTuvaleteGit.Location = new System.Drawing.Point(565, 52);
            this.btnTuvaleteGit.Name = "btnTuvaleteGit";
            this.btnTuvaleteGit.Size = new System.Drawing.Size(185, 148);
            this.btnTuvaleteGit.TabIndex = 1;
            this.btnTuvaleteGit.Text = "Tuvalete Git";
            this.btnTuvaleteGit.UseVisualStyleBackColor = true;
            this.btnTuvaleteGit.Click += new System.EventHandler(this.btnTuvaleteGit_Click);
            // 
            // btnUyut
            // 
            this.btnUyut.Location = new System.Drawing.Point(374, 206);
            this.btnUyut.Name = "btnUyut";
            this.btnUyut.Size = new System.Drawing.Size(185, 148);
            this.btnUyut.TabIndex = 1;
            this.btnUyut.Text = "Uyut";
            this.btnUyut.UseVisualStyleBackColor = true;
            this.btnUyut.Click += new System.EventHandler(this.btnUyut_Click);
            // 
            // btnOldur
            // 
            this.btnOldur.Location = new System.Drawing.Point(565, 206);
            this.btnOldur.Name = "btnOldur";
            this.btnOldur.Size = new System.Drawing.Size(185, 148);
            this.btnOldur.TabIndex = 1;
            this.btnOldur.Text = "Öldür (Let\'s kill james)";
            this.btnOldur.UseVisualStyleBackColor = true;
            this.btnOldur.Click += new System.EventHandler(this.btnOldur_Click);
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(58, 250);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(277, 60);
            this.btnOyunaBasla.TabIndex = 2;
            this.btnOyunaBasla.Text = "Oyuna Başla";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bebişin Durumu";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(548, 394);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(26, 17);
            this.lblLife.TabIndex = 5;
            this.lblLife.Text = "life";
            this.lblLife.TextChanged += new System.EventHandler(this.lblLife_TextChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDurum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(331, 427);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(454, 31);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Oyuna Başlamak İçin Butona Tıklamalısın";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOyunaBasla);
            this.Controls.Add(this.btnOldur);
            this.Controls.Add(this.btnUyut);
            this.Controls.Add(this.btnTuvaleteGit);
            this.Controls.Add(this.btnYemekYe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYemekYe;
        private System.Windows.Forms.Button btnTuvaleteGit;
        private System.Windows.Forms.Button btnUyut;
        private System.Windows.Forms.Button btnOldur;
        private System.Windows.Forms.Button btnOyunaBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Timer timer1;
    }
}

