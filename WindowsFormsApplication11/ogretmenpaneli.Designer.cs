namespace WindowsFormsApplication11
{
    partial class ogretmenpaneli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciProjeGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arşivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinenDosyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kayıtSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.öğrenciİşlemleriToolStripMenuItem,
            this.arşivToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciProjeGirişiToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.öğrenciToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(192, 23);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci Proje Girişi ";
            // 
            // öğrenciProjeGirişiToolStripMenuItem
            // 
            this.öğrenciProjeGirişiToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.öğrenciProjeGirişiToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.öğrenciProjeGirişiToolStripMenuItem.Name = "öğrenciProjeGirişiToolStripMenuItem";
            this.öğrenciProjeGirişiToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.öğrenciProjeGirişiToolStripMenuItem.Text = "Öğrenci Proje Girişi";
            this.öğrenciProjeGirişiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciProjeGirişiToolStripMenuItem_Click);
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.öğrenciİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 23);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            this.öğrenciİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciİşlemleriToolStripMenuItem_Click);
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // arşivToolStripMenuItem
            // 
            this.arşivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silinenDosyalarToolStripMenuItem,
            this.kayıtSilmeToolStripMenuItem});
            this.arşivToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arşivToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.arşivToolStripMenuItem.Name = "arşivToolStripMenuItem";
            this.arşivToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.arşivToolStripMenuItem.Text = "Arşiv";
            // 
            // silinenDosyalarToolStripMenuItem
            // 
            this.silinenDosyalarToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.silinenDosyalarToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.silinenDosyalarToolStripMenuItem.Name = "silinenDosyalarToolStripMenuItem";
            this.silinenDosyalarToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.silinenDosyalarToolStripMenuItem.Text = "Silinen Dosyalar";
            this.silinenDosyalarToolStripMenuItem.Click += new System.EventHandler(this.silinenDosyalarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kayıtSilmeToolStripMenuItem
            // 
            this.kayıtSilmeToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.kayıtSilmeToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.kayıtSilmeToolStripMenuItem.Name = "kayıtSilmeToolStripMenuItem";
            this.kayıtSilmeToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kayıtSilmeToolStripMenuItem.Text = "Kayıt Silme";
            this.kayıtSilmeToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilmeToolStripMenuItem_Click);
            // 
            // ogretmenpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication11.Properties.Resources.okul_cantasi_4_777x446;
            this.ClientSize = new System.Drawing.Size(801, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ogretmenpaneli";
            this.Load += new System.EventHandler(this.ogretmenpaneli_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciProjeGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arşivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinenDosyalarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilmeToolStripMenuItem;
    }
}