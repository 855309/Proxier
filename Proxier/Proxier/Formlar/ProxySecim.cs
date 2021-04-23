using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Proxier.Formlar
{
    public partial class ProxySecim : Form
    {
        public List<string> proxyler = new List<string>();
        public ProxySecim()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    

        private void ProxySecim_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tamamButton_Click(object sender, EventArgs e)
        {
            string[] parcalar = proxyBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string parca in parcalar)
            {
                if (parca.Trim() != "")
                {
                    proxyler.Add(parca.Trim());
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void secmeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Metin dosyaları (*.txt)|*.txt|Bütün dosyalar (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                proxyBox.Clear();

                string yol = dialog.FileName;
                yolTextBox.Text = yol;
                string[] satirlar = File.ReadAllLines(yol);

                foreach (string satir in satirlar)
                {
                    if (satir.Trim() != "")
                    {
                        //proxyler.Add(satir.Trim());
                        proxyBox.Text = proxyBox.Text + satir.Trim() + "\r\n";
                    }
                }

                tamamButton.Enabled = true;
            }
        }

        private void proxyBox_TextChanged(object sender, EventArgs e)
        {
            if (proxyBox.Text.Trim() == "")
            {
                tamamButton.Enabled = false;
            }
            else
            {
                tamamButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbUrl.Text))
            {
                MessageBox.Show("Lütfen önce URL giriniz");
                return;
            }
            var webRequest = WebRequest.Create(TbUrl.Text);

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                var lst = strContent.Split('\n');
                foreach (string parca in lst)
                {
                    if (parca.Trim() != "")
                    {
                        proxyler.Add(parca.Trim());
                    }
                }

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
