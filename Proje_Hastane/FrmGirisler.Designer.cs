namespace Proje_Hastane
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.buttonHastaGirisi = new System.Windows.Forms.Button();
            this.buttonDoktorGirisi = new System.Windows.Forms.Button();
            this.buttonSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHastaGirisi
            // 
            this.buttonHastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHastaGirisi.BackgroundImage")));
            this.buttonHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHastaGirisi.Location = new System.Drawing.Point(13, 170);
            this.buttonHastaGirisi.Name = "buttonHastaGirisi";
            this.buttonHastaGirisi.Size = new System.Drawing.Size(129, 98);
            this.buttonHastaGirisi.TabIndex = 0;
            this.buttonHastaGirisi.UseVisualStyleBackColor = true;
            this.buttonHastaGirisi.Click += new System.EventHandler(this.buttonHastaGirisi_Click);
            // 
            // buttonDoktorGirisi
            // 
            this.buttonDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoktorGirisi.BackgroundImage")));
            this.buttonDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoktorGirisi.Location = new System.Drawing.Point(189, 170);
            this.buttonDoktorGirisi.Name = "buttonDoktorGirisi";
            this.buttonDoktorGirisi.Size = new System.Drawing.Size(129, 98);
            this.buttonDoktorGirisi.TabIndex = 1;
            this.buttonDoktorGirisi.UseVisualStyleBackColor = true;
            this.buttonDoktorGirisi.Click += new System.EventHandler(this.buttonDoktorGirisi_Click);
            // 
            // buttonSekreterGirisi
            // 
            this.buttonSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSekreterGirisi.BackgroundImage")));
            this.buttonSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSekreterGirisi.Location = new System.Drawing.Point(362, 170);
            this.buttonSekreterGirisi.Name = "buttonSekreterGirisi";
            this.buttonSekreterGirisi.Size = new System.Drawing.Size(129, 98);
            this.buttonSekreterGirisi.TabIndex = 2;
            this.buttonSekreterGirisi.UseVisualStyleBackColor = true;
            this.buttonSekreterGirisi.Click += new System.EventHandler(this.buttonSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSekreterGirisi);
            this.Controls.Add(this.buttonDoktorGirisi);
            this.Controls.Add(this.buttonHastaGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHastaGirisi;
        private System.Windows.Forms.Button buttonDoktorGirisi;
        private System.Windows.Forms.Button buttonSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

