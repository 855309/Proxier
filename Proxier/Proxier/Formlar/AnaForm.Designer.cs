
namespace Proxier
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çalışanProxyleriKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütünSonuçlarıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxylerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sonuçlarıTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.durumLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBosluk = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basariliLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.basarisizLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.proxyListView = new System.Windows.Forms.ListView();
            this.proxyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baglantiHiziColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.proxylerToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(383, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menü";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.durdurToolStripMenuItem,
            this.toolStripSeparator1,
            this.çalışanProxyleriKaydetToolStripMenuItem,
            this.bütünSonuçlarıKaydetToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Enabled = false;
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // çalışanProxyleriKaydetToolStripMenuItem
            // 
            this.çalışanProxyleriKaydetToolStripMenuItem.Enabled = false;
            this.çalışanProxyleriKaydetToolStripMenuItem.Name = "çalışanProxyleriKaydetToolStripMenuItem";
            this.çalışanProxyleriKaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.çalışanProxyleriKaydetToolStripMenuItem.Text = "Çalışan Proxyleri Kaydet";
            this.çalışanProxyleriKaydetToolStripMenuItem.Click += new System.EventHandler(this.çalışanProxyleriKaydetToolStripMenuItem_Click);
            // 
            // bütünSonuçlarıKaydetToolStripMenuItem
            // 
            this.bütünSonuçlarıKaydetToolStripMenuItem.Enabled = false;
            this.bütünSonuçlarıKaydetToolStripMenuItem.Name = "bütünSonuçlarıKaydetToolStripMenuItem";
            this.bütünSonuçlarıKaydetToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.bütünSonuçlarıKaydetToolStripMenuItem.Text = "Bütün Sonuçları Kaydet";
            this.bütünSonuçlarıKaydetToolStripMenuItem.Click += new System.EventHandler(this.bütünSonuçlarıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // proxylerToolStripMenuItem
            // 
            this.proxylerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyYükleToolStripMenuItem,
            this.toolStripSeparator3,
            this.sonuçlarıTemizleToolStripMenuItem});
            this.proxylerToolStripMenuItem.Name = "proxylerToolStripMenuItem";
            this.proxylerToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.proxylerToolStripMenuItem.Text = "Proxyler";
            // 
            // proxyYükleToolStripMenuItem
            // 
            this.proxyYükleToolStripMenuItem.Name = "proxyYükleToolStripMenuItem";
            this.proxyYükleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proxyYükleToolStripMenuItem.Text = "Proxy Yükle";
            this.proxyYükleToolStripMenuItem.Click += new System.EventHandler(this.proxyYükleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // sonuçlarıTemizleToolStripMenuItem
            // 
            this.sonuçlarıTemizleToolStripMenuItem.Enabled = false;
            this.sonuçlarıTemizleToolStripMenuItem.Name = "sonuçlarıTemizleToolStripMenuItem";
            this.sonuçlarıTemizleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sonuçlarıTemizleToolStripMenuItem.Text = "Sonuçları Temizle";
            this.sonuçlarıTemizleToolStripMenuItem.Click += new System.EventHandler(this.sonuçlarıTemizleToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem1});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yardımToolStripMenuItem1.Text = "Yardım";
            this.yardımToolStripMenuItem1.Click += new System.EventHandler(this.yardımToolStripMenuItem1_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem1});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumLabel,
            this.statusBosluk,
            this.toolStripStatusLabel1,
            this.basariliLabel,
            this.toolStripStatusLabel2,
            this.basarisizLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 459);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(383, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // durumLabel
            // 
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(37, 17);
            this.durumLabel.Text = "Hazır.";
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Enabled = false;
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.durdurToolStripMenuItem.Text = "Durdur";
            this.durdurToolStripMenuItem.Click += new System.EventHandler(this.durdurToolStripMenuItem_Click);
            // 
            // statusBosluk
            // 
            this.statusBosluk.Name = "statusBosluk";
            this.statusBosluk.Size = new System.Drawing.Size(204, 17);
            this.statusBosluk.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Başarılı:";
            // 
            // basariliLabel
            // 
            this.basariliLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.basariliLabel.Name = "basariliLabel";
            this.basariliLabel.Size = new System.Drawing.Size(13, 17);
            this.basariliLabel.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel2.Text = "Başarısız:";
            // 
            // basarisizLabel
            // 
            this.basarisizLabel.ForeColor = System.Drawing.Color.Red;
            this.basarisizLabel.Name = "basarisizLabel";
            this.basarisizLabel.Size = new System.Drawing.Size(13, 17);
            this.basarisizLabel.Text = "0";
            // 
            // proxyListView
            // 
            this.proxyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.proxyColumn,
            this.pingColumn,
            this.baglantiHiziColumn});
            this.proxyListView.HideSelection = false;
            this.proxyListView.Location = new System.Drawing.Point(0, 23);
            this.proxyListView.Name = "proxyListView";
            this.proxyListView.Size = new System.Drawing.Size(383, 435);
            this.proxyListView.TabIndex = 4;
            this.proxyListView.UseCompatibleStateImageBehavior = false;
            this.proxyListView.View = System.Windows.Forms.View.Details;
            // 
            // proxyColumn
            // 
            this.proxyColumn.Text = "Proxy";
            this.proxyColumn.Width = 145;
            // 
            // pingColumn
            // 
            this.pingColumn.Text = "Ping";
            this.pingColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pingColumn.Width = 109;
            // 
            // baglantiHiziColumn
            // 
            this.baglantiHiziColumn.Text = "Bağlantı Hızı";
            this.baglantiHiziColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baglantiHiziColumn.Width = 104;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 481);
            this.Controls.Add(this.proxyListView);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "AnaForm";
            this.Text = "Proxier 1.0";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxylerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çalışanProxyleriKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütünSonuçlarıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sonuçlarıTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel durumLabel;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusBosluk;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel basariliLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel basarisizLabel;
        private System.Windows.Forms.ListView proxyListView;
        private System.Windows.Forms.ColumnHeader proxyColumn;
        private System.Windows.Forms.ColumnHeader pingColumn;
        private System.Windows.Forms.ColumnHeader baglantiHiziColumn;
    }
}

