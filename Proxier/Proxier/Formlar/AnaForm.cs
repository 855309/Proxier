using Proxier.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Diagnostics;

namespace Proxier
{
    public partial class AnaForm : Form
    {
        public List<string> proxyler = new List<string>();

        public List<string> basariliProxyler = new List<string>();

        public List<string> basarisizProxyler = new List<string>();

        public AnaForm()
        {
            InitializeComponent();

            var imageList = new ImageList();
            imageList.Images.Add("basarili", Proxier.Properties.Resources.basarili);
            imageList.Images.Add("basarisiz", Proxier.Properties.Resources.basarisiz);

            proxyListView.SmallImageList = imageList;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sonuçlarıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proxyListView.Items.Clear();
        }

        private void proxyYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProxySecim proxySecim = new ProxySecim();

            if (proxySecim.ShowDialog() == DialogResult.OK)
            {
                proxyler = proxySecim.proxyler;
                MessageBox.Show(proxyler.Count() + " Adet proxy yüklendi.", "Proxier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                başlatToolStripMenuItem.Enabled = true;

                durumYaz("Proxyler yüklendi.");
            }
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durdurToolStripMenuItem.Enabled = true;
            denemeBaslat();
        }

        public async void denemeBaslat()
        {
            foreach (string proxystring in proxyler)
            {
                if (durdu)
                {
                    durdurToolStripMenuItem.Enabled = false;
                    break;
                }

                basariliLabel.Text = basariliProxyler.Count().ToString();
                basarisizLabel.Text = basarisizProxyler.Count().ToString();

                //await Dene(proxystring);
                await Task.Run(() => Dene(proxystring));
            }

            durumYaz("Deneme bitti.");
            MessageBox.Show("Deneme bitti.\r\nToplam " + basariliProxyler.Count() + " Adet çalışan proxy,\r\n" + basarisizProxyler.Count() + " Adet çalışmayan proxy bulundu.", "Proxier", MessageBoxButtons.OK, MessageBoxIcon.Information);

            çalışanProxyleriKaydetToolStripMenuItem.Enabled = true;
            bütünSonuçlarıKaydetToolStripMenuItem.Enabled = true;
        }

        string testServer = "https://www.cloudflare.com/cdn-cgi/trace";


        public async Task<bool> Dene(string proxystring)
        {
            durumYaz(proxystring + " deneniyor...");

            ListViewItem item;

            var proxy = new WebProxy
            {
                Address = new Uri("http://" + proxystring),
                BypassProxyOnLocal = false,
                UseDefaultCredentials = false
            };

            var httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy
            };

            var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);

            client.Timeout = TimeSpan.FromSeconds(2); //Timeout belirleme

            try
            {
                DateTime onceZaman = DateTime.UtcNow;
                var cevap = await client.GetAsync(testServer);
                DateTime sonraZaman = DateTime.UtcNow;

                TimeSpan pingZaman = sonraZaman - onceZaman;

                double ping = pingZaman.TotalMilliseconds;

                if (cevap.StatusCode == HttpStatusCode.OK)
                {
                    durumYaz(proxystring + " başarılı.");
                    item = new ListViewItem(proxystring, "basarili");
                    

                    if (ping < 70)
                    {
                        item.SubItems.Add("Çok İyi", Color.Green, BackColor, Font);
                        item.SubItems.Add(Math.Floor(ping).ToString() + " ms", Color.Green, BackColor, Font);
                    }
                    else if (ping < 150)
                    {
                        item.SubItems.Add("Normal", Color.DarkGreen, BackColor, Font);
                        item.SubItems.Add(Math.Floor(ping).ToString() + " ms", Color.DarkGreen, BackColor, Font);
                    }
                    else if(ping < 500)
                    {
                        item.SubItems.Add("Orta", Color.Gold, BackColor, Font);
                        item.SubItems.Add(Math.Floor(ping).ToString() + " ms", Color.Gold, BackColor, Font);
                    }
                    else if (ping < 1000)
                    {
                        item.SubItems.Add("Kötü", Color.Red, BackColor, Font);
                        item.SubItems.Add(Math.Floor(ping).ToString() + " ms", Color.Red, BackColor, Font);
                    }
                    else if (ping < 2000)
                    {
                        item.SubItems.Add("Çok Kötü", Color.DarkRed, BackColor, Font);
                        item.SubItems.Add(Math.Floor(ping).ToString() + " ms", Color.DarkRed, BackColor, Font);
                    }

                    basariliProxyler.Add(proxystring);
                }
                else
                {
                    durumYaz(proxystring + " başarısız.");
                    item = new ListViewItem(proxystring, "basarisiz");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    basarisizProxyler.Add(proxystring);
                }
            }
            catch
            {
                durumYaz(proxystring + " başarısız.");
                item = new ListViewItem(proxystring, "basarisiz");
                item.SubItems.Add("-");
                item.SubItems.Add("-");
                basarisizProxyler.Add(proxystring);
            }

            proxyListView.Items.Add(item);

            return await Task.FromResult(true);
        }

        public bool durdu = false;
        
        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/fikret0/Proxier");
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        private void çalışanProxyleriKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Metin dosyaları (*.txt)|*.txt|Bütün dosyalar (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string yol = dialog.FileName;

                File.WriteAllLines(yol, basariliProxyler);

                MessageBox.Show(basariliProxyler.Count() + " Adet proxy kaydedildi.", "Proxier", MessageBoxButtons.OK, MessageBoxIcon.Information);

                durumYaz(basariliProxyler.Count() + " Adet proxy kaydedildi.");
            }
        }

        private void bütünSonuçlarıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Metin dosyaları (*.txt)|*.txt|Bütün dosyalar (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<string> sonuc = new List<string>();

                foreach (string proxystring in proxyler)
                {
                    if (basariliProxyler.Contains(proxystring))
                    {
                        sonuc.Add("[Başarılı]  " + proxystring);
                    }
                    else if (basarisizProxyler.Contains(proxystring))
                    {
                        sonuc.Add("[Başarısız] " + proxystring);
                    }
                }

                File.WriteAllLines(dialog.FileName, sonuc);

                MessageBox.Show((int)(basariliProxyler.Count() + basarisizProxyler.Count()) + " Adet sonuç kaydedildi.", "Proxier", MessageBoxButtons.OK, MessageBoxIcon.Information);

                durumYaz((int)(basariliProxyler.Count() + basarisizProxyler.Count()) + " Adet sonuç kaydedildi.");
            }
        }

        public void durumYaz(string durum)
        {
            durumLabel.Text = durum;
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durdu = true;
        }
    }
}
