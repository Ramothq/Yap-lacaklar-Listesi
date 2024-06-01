using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Yapılacaklar_Listesi.yapilacaklarlistesi;

namespace Yapılacaklar_Listesi
{



    public partial class yapilacaklarlistesi : Form
    {
        List<Görev> görevler = new List<Görev>();
        string dosyaYolu = "gorevler.txt";
        public yapilacaklarlistesi()
        {
            InitializeComponent();
            görevleriYukle();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grvmtntxt.Text != "")
            {
                Görev yeniGörev = new Görev();
                yeniGörev.GörevMetni = grvmtntxt.Text;
                yeniGörev.SonTarih = trhsec.Value;
                yeniGörev.Tamamlandı = false;
                yeniGörev.Tür = comboBox1.SelectedIndex == -1 ? "Seçilmedi" : comboBox1.SelectedItem.ToString(); ;

                // Görevi listenin başına ekle
                görevler.Insert(0, yeniGörev);

                görevleriYenidenListele();
                görevleriKaydet();

                grvmtntxt.Text = "";
                comboBox1.SelectedIndex = -1;


            }
        }

        private void görevleriYenidenListele()
        {
            int seciliOgeIndeksi = grvlistbox.SelectedIndex;

            grvlistbox.Items.Clear();
            grvlistbox.DrawMode = DrawMode.OwnerDrawFixed;
            grvlistbox.DrawItem += grvlistbox_DrawItem;
            foreach (Görev görev in görevler)
            {
                string görevSatırı = görev.Tamamlandı ? "[Tamamlandı] " : "";
                görevSatırı += görev.GörevMetni + " (" + görev.SonTarih.ToShortDateString() + ") [" + görev.Tür + "]";
                grvlistbox.Items.Add(görevSatırı); ;



            }


        }
        private void grvlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grvlistbox.SelectedIndex != -1)
            {
                int seciliOgeIndeksi = grvlistbox.SelectedIndex;
                Görev seçiliGörev = görevler[grvlistbox.SelectedIndex];
                grvmtntxt.Text = seçiliGörev.GörevMetni;
                trhsec.Value = seçiliGörev.SonTarih;
                chckbx.Checked = seçiliGörev.Tamamlandı;

                grvmtntxt.Text = "";

                grvlistbox.SelectedIndex = seciliOgeIndeksi;
            }
        }

        private void grvmtntxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void görevleriKaydet()
        {
            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                foreach (Görev görev in görevler)
                {
                    writer.WriteLine($"{görev.GörevMetni},{görev.SonTarih},{görev.Tamamlandı},{görev.Tür}"); // Tür bilgisini ekle
                }
            }
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (grvlistbox.SelectedIndices.Count > 0) 
            {
                foreach (int index in grvlistbox.SelectedIndices) 
                {
                    görevler[index].Tamamlandı = chckbx.Checked; 
                }
                görevleriYenidenListele(); 
                görevleriKaydet(); //  kaydet
            }
        }

        private void görevleriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                görevler.Clear();
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    string satır;
                    while ((satır = reader.ReadLine()) != null)
                    {
                        string[] parçalar = satır.Split(',');
                        Görev görev = new Görev();
                        görev.GörevMetni = parçalar[0];
                        görev.SonTarih = DateTime.Parse(parçalar[1]);
                        görev.Tamamlandı = bool.Parse(parçalar[2]);
                        görevler.Add(görev);
                    }
                }
                görevleriYenidenListele();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (grvlistbox.SelectedIndices.Count > 0) // kontrol et
            {
                List<int> silinecekIndeksler = new List<int>(); // liste oluştur
                foreach (int index in grvlistbox.SelectedIndices) 
                {
                    silinecekIndeksler.Add(index); 
                }

                silinecekIndeksler.Sort((a, b) => b.CompareTo(a)); 

                foreach (int index in silinecekIndeksler) 
                {
                    GörevSil(index); // Seçilen ögeleri sil
                }
            }
        }

        private void GörevSil(int index)
        {
            if (index >= 0 && index < görevler.Count) 
            {
                görevler.RemoveAt(index); 
                görevleriYenidenListele(); // Güncelle
                görevleriKaydet(); //  kaydet
            }
        }


        private void btngeriyukle_Click(object sender, EventArgs e)
        {

        }
        public class Görev
        {
            public string GörevMetni { get; set; }
            public DateTime SonTarih { get; set; }
            public bool Tamamlandı { get; set; }
            public string Tür { get; set; } = "Seçilmedi";

        }

        private void btntmnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm görevleri silmek istediğinize emin misiniz?", "Tüm Görevleri Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                görevler.Clear();
                görevleriYenidenListele();
                görevleriKaydet();
            }
        }

        private void yapilacaklarlistesi_Load(object sender, EventArgs e)
        {
            grvmtntxt.Focus();
        }

        private void grvmtntxt_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnekle.PerformClick();
            }
        }

        private void grvlistbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawBackground();
            if (e.Index >= 0)
            {
                Görev gorev = görevler[e.Index];
                Brush brush = gorev.Tamamlandı ? Brushes.Green : Brushes.Black;
                e.Graphics.DrawString(grvlistbox.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void grvmtntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (grvmtntxt.Text.Length >= 35 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


