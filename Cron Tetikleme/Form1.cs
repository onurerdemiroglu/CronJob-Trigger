using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cron_Tetikleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            domaincek();
            sinirsiz.Checked = true;

            string dosya_dizini = Application.StartupPath + "/Dosyalar/ayar.txt";
            if (File.Exists(dosya_dizini) == true)
            {
                AyarYukle();
            }
            else
            {
            }
        }
        private void sinirsiz_Click(object sender, EventArgs e)
        {
            teksefer.Checked = false;
            sinirsiz.Checked = true;
        }

        private void teksefer_Click(object sender, EventArgs e)
        {
            sinirsiz.Checked = false;
            teksefer.Checked = true;
        }
        void AyarYukle()
        {
            try
            {
                string ayar = File.ReadAllText(Application.StartupPath + "/Dosyalar/ayar.txt");

                string[] hesaptum = ayar.Split('|');

                string domainayar = hesaptum[0];
                string[] domainayar1 = domainayar.Split(',');
                cronarasizaman.Text = domainayar1[0];
                tumcronsonrasizaman.Text = domainayar1[1];
                string dongu = domainayar1[2];



                string domainayar2 = hesaptum[1];
                string[] domainayar3 = domainayar2.Split(',');
                string wpauto = domainayar3[0];
                string pauto = domainayar3[1];
                string wpcron = domainayar3[2];

                if (wpauto=="True")
                {
                    wautomatic.Checked = true;
                }
                else
                {
                    wautomatic.Checked = false;
                }

                if (pauto == "True")
                {
                    pinautomatic.Checked = true;
                }
                else
                {
                    pinautomatic.Checked = false;
                }

                if (wpcron == "True")
                {
                    wordpresscron.Checked = true;
                }
                else
                {
                    wordpresscron.Checked = false;
                }


                if (dongu== "sınırsız")
                {
                    sinirsiz.Checked = true;
                    teksefer.Checked = false;
                }
                else
                {
                    sinirsiz.Checked = false;
                    teksefer.Checked = true;
                }      

            }
            catch (Exception)
            {
            }
        }
        string wpautomatic, pinautomaticc, wpcron, dongu;

        void ayarkayit()
        {
            string cronarazaman = cronarasizaman.Text;
            string tumcronara = tumcronsonrasizaman.Text;

            if (wautomatic.Checked==true)
            {
                wpautomatic = "True";
            }
            else
            {
                wpautomatic = "False"; 
            }

            if (pinautomatic.Checked == true)
            {
                pinautomaticc = "True";
            }
            else
            {
                pinautomaticc = "False";
            }

            if (wordpresscron.Checked == true)
            {
                wpcron = "True";
            }
            else
            {
                wpcron = "False";
            }


            if (sinirsiz.Checked == true)
            {
                dongu = "sınırsız";
            }
            else
            {
                dongu = "tek döngü";
            }
            string tumayar = cronarazaman + "," + tumcronara + "," + dongu + "|" + wpautomatic + "," + pinautomaticc + "," + wpcron + "|";

            System.IO.File.WriteAllText(Application.StartupPath + "/Dosyalar/ayar.txt", tumayar);
        }

        void domaincek()
        {
            try
            {
                Domainliste.Items.Clear();
                string[] lines = File.ReadAllLines(Application.StartupPath + "/Dosyalar/domain.txt");
                Domainliste.Items.AddRange(lines);
            }
            catch (Exception)
            {
            }

            System.Collections.ArrayList yeni = new System.Collections.ArrayList();
            foreach (string item in Domainliste.Items)
            {
                if (yeni.Contains(item) == false)
                {
                    yeni.Add(item);
                }
            }

            Domainliste.Items.Clear();
            Domainliste.Items.AddRange(yeni.ToArray());
            domainsayisi.Text = "Toplam: "+Convert.ToString(Domainliste.Items.Count) + " adet domain bulunuyor.";
        }


       

        private void ayarkaydet_Click(object sender, EventArgs e)
        {
            ayarkayit();
        }
    

        private void ayaryukle_Click(object sender, EventArgs e)
        {
            string dosya_dizini = Application.StartupPath + "/Dosyalar/ayar.txt";
            if (File.Exists(dosya_dizini) == true)
            {
                AyarYukle();
            }
            else
            {
            }
        }
       
        private void cronac_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "/Dosyalar/domain.txt");

            }
            catch (Exception)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                thread.Abort(); 
            }
            catch (Exception)
            { 
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            domaincek();
        }
        Thread thread;
        private void baslat_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(cronbasla));
            thread.Start();
        }
        void cronbasla()
        {
            tekrar:
            for (int i = 0; i < Domainliste.Items.Count; i++)
            {


                if (pinautomatic.Checked==true)
                {
                    WebClient wc = new WebClient();
                    Stream oku = wc.OpenRead(Domainliste.Items[i].ToString() + "/?wp_pinterest_automatic=cron");
                    StreamReader sr = new StreamReader(oku);

                    bospin:
                    string cronpin = sr.ReadToEnd();
                    if (string.IsNullOrEmpty(cronpin))
                    {
                        Thread.Sleep(10);
                        goto bospin;
                    }
                    sr.Close();
                    oku.Close();
                    wc.Dispose();
                }



                if (wautomatic.Checked==true)
                {
                    WebClient wc2 = new WebClient();
                    Stream oku2 = wc2.OpenRead(Domainliste.Items[i].ToString() + "/?wp_automatic=cron");
                    StreamReader sr2 = new StreamReader(oku2);

                    bosauto:
                    string cronauto = sr2.ReadToEnd();
                    if (string.IsNullOrEmpty(cronauto))
                    {
                        Thread.Sleep(10);
                        goto bosauto;
                    }
                    sr2.Close();
                    oku2.Close();
                    wc2.Dispose();
                }

                if (wordpresscron.Checked == true)
                {
                    WebClient wc3 = new WebClient();
                    Stream oku3 = wc3.OpenRead(Domainliste.Items[i].ToString() + "/wp-cron.php"); 
                    oku3.Close();
                    wc3.Dispose();
                    Thread.Sleep(100);
                }

                //////////////////////////////////////// ÇIKTI ////////////////////////////////////
                if (wautomatic.Checked==true | pinautomatic.Checked==true | wordpresscron.Checked==true)
                {
                    cikti.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss") + "] Thread #" + (i + 1).ToString() + " " + Domainliste.Items[i].ToString() + " sitenin cronu çalıştırıldı.");

                    //Thread.Sleep(Convert.ToInt32(cronarasizaman.Text) * 1000);
                    Thread.Sleep(500);

                    if (cikti.Items.Count > 10)
                    {
                        cikti.Items.Clear();
                    }
                }
            }

            Thread.Sleep(Convert.ToInt32(tumcronsonrasizaman.Text)*60*1000);

            if (sinirsiz.Checked == true)
            {
                goto tekrar;
            } 
        }
    }
}
