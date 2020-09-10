namespace RPGGame
{
    partial class OyunEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunEkran));
            this.UstPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.PictureBox();
            this.Saglik = new System.Windows.Forms.Label();
            this.SaglikPuani = new System.Windows.Forms.Label();
            this.DusmanSaglikPuani = new System.Windows.Forms.Label();
            this.SaglikDusman = new System.Windows.Forms.Label();
            this.DPS = new System.Windows.Forms.Timer(this.components);
            this.Saat = new System.Windows.Forms.Label();
            this.CanArtır = new System.Windows.Forms.Button();
            this.HasarArtır = new System.Windows.Forms.Button();
            this.ParaArtır = new System.Windows.Forms.Button();
            this.CanFiyat = new System.Windows.Forms.Label();
            this.HasarFiyat = new System.Windows.Forms.Label();
            this.ParaFiyat = new System.Windows.Forms.Label();
            this.DusmanResim = new System.Windows.Forms.PictureBox();
            this.KarakterResim = new System.Windows.Forms.PictureBox();
            this.Saldiri = new System.Windows.Forms.PictureBox();
            this.ParaMiktar = new System.Windows.Forms.Label();
            this.Para = new System.Windows.Forms.Label();
            this.UstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DusmanResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarakterResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldiri)).BeginInit();
            this.SuspendLayout();
            // 
            // UstPanel
            // 
            this.UstPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.UstPanel.Controls.Add(this.Title);
            resources.ApplyResources(this.UstPanel, "UstPanel");
            this.UstPanel.Name = "UstPanel";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Image = global::RPGGame.Properties.Resources.oyun_başlık;
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.TabStop = false;
            // 
            // Saglik
            // 
            resources.ApplyResources(this.Saglik, "Saglik");
            this.Saglik.Name = "Saglik";
            // 
            // SaglikPuani
            // 
            resources.ApplyResources(this.SaglikPuani, "SaglikPuani");
            this.SaglikPuani.Name = "SaglikPuani";
            // 
            // DusmanSaglikPuani
            // 
            resources.ApplyResources(this.DusmanSaglikPuani, "DusmanSaglikPuani");
            this.DusmanSaglikPuani.Name = "DusmanSaglikPuani";
            // 
            // SaglikDusman
            // 
            resources.ApplyResources(this.SaglikDusman, "SaglikDusman");
            this.SaglikDusman.Name = "SaglikDusman";
            // 
            // DPS
            // 
            this.DPS.Interval = 1000;
            this.DPS.Tick += new System.EventHandler(this.DPS_Tick);
            // 
            // Saat
            // 
            resources.ApplyResources(this.Saat, "Saat");
            this.Saat.Name = "Saat";
            // 
            // CanArtır
            // 
            resources.ApplyResources(this.CanArtır, "CanArtır");
            this.CanArtır.Name = "CanArtır";
            this.CanArtır.UseVisualStyleBackColor = true;
            this.CanArtır.Click += new System.EventHandler(this.CanArtır_Click);
            // 
            // HasarArtır
            // 
            resources.ApplyResources(this.HasarArtır, "HasarArtır");
            this.HasarArtır.Name = "HasarArtır";
            this.HasarArtır.UseVisualStyleBackColor = true;
            this.HasarArtır.Click += new System.EventHandler(this.HasarArtır_Click);
            // 
            // ParaArtır
            // 
            resources.ApplyResources(this.ParaArtır, "ParaArtır");
            this.ParaArtır.Name = "ParaArtır";
            this.ParaArtır.UseVisualStyleBackColor = true;
            this.ParaArtır.Click += new System.EventHandler(this.ParaArtır_Click);
            // 
            // CanFiyat
            // 
            resources.ApplyResources(this.CanFiyat, "CanFiyat");
            this.CanFiyat.Name = "CanFiyat";
            // 
            // HasarFiyat
            // 
            resources.ApplyResources(this.HasarFiyat, "HasarFiyat");
            this.HasarFiyat.Name = "HasarFiyat";
            // 
            // ParaFiyat
            // 
            resources.ApplyResources(this.ParaFiyat, "ParaFiyat");
            this.ParaFiyat.Name = "ParaFiyat";
            // 
            // DusmanResim
            // 
            this.DusmanResim.Image = global::RPGGame.Properties.Resources.Battle_turtle;
            resources.ApplyResources(this.DusmanResim, "DusmanResim");
            this.DusmanResim.Name = "DusmanResim";
            this.DusmanResim.TabStop = false;
            // 
            // KarakterResim
            // 
            this.KarakterResim.Image = global::RPGGame.Properties.Resources.GraveRobber;
            resources.ApplyResources(this.KarakterResim, "KarakterResim");
            this.KarakterResim.Name = "KarakterResim";
            this.KarakterResim.TabStop = false;
            // 
            // Saldiri
            // 
            this.Saldiri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Saldiri.Image = global::RPGGame.Properties.Resources.saldırı;
            resources.ApplyResources(this.Saldiri, "Saldiri");
            this.Saldiri.Name = "Saldiri";
            this.Saldiri.TabStop = false;
            this.Saldiri.Click += new System.EventHandler(this.Saldiri_Click);
            this.Saldiri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Saldiri_MouseDown);
            this.Saldiri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Saldiri_MouseUp);
            // 
            // ParaMiktar
            // 
            resources.ApplyResources(this.ParaMiktar, "ParaMiktar");
            this.ParaMiktar.Name = "ParaMiktar";
            // 
            // Para
            // 
            resources.ApplyResources(this.Para, "Para");
            this.Para.Name = "Para";
            // 
            // OyunEkran
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.Para);
            this.Controls.Add(this.ParaMiktar);
            this.Controls.Add(this.ParaFiyat);
            this.Controls.Add(this.HasarFiyat);
            this.Controls.Add(this.CanFiyat);
            this.Controls.Add(this.ParaArtır);
            this.Controls.Add(this.HasarArtır);
            this.Controls.Add(this.CanArtır);
            this.Controls.Add(this.Saat);
            this.Controls.Add(this.DusmanSaglikPuani);
            this.Controls.Add(this.SaglikDusman);
            this.Controls.Add(this.SaglikPuani);
            this.Controls.Add(this.Saglik);
            this.Controls.Add(this.DusmanResim);
            this.Controls.Add(this.KarakterResim);
            this.Controls.Add(this.Saldiri);
            this.Controls.Add(this.UstPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OyunEkran";
            this.UstPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DusmanResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarakterResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saldiri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel UstPanel;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.PictureBox Saldiri;
        private System.Windows.Forms.PictureBox KarakterResim;
        private System.Windows.Forms.PictureBox DusmanResim;
        private System.Windows.Forms.Label Saglik;
        private System.Windows.Forms.Label SaglikPuani;
        private System.Windows.Forms.Label DusmanSaglikPuani;
        private System.Windows.Forms.Label SaglikDusman;
        private System.Windows.Forms.Timer DPS;
        private System.Windows.Forms.Label Saat;
        private System.Windows.Forms.Button CanArtır;
        private System.Windows.Forms.Button HasarArtır;
        private System.Windows.Forms.Button ParaArtır;
        private System.Windows.Forms.Label CanFiyat;
        private System.Windows.Forms.Label HasarFiyat;
        private System.Windows.Forms.Label ParaFiyat;
        private System.Windows.Forms.Label ParaMiktar;
        private System.Windows.Forms.Label Para;
    }
}

