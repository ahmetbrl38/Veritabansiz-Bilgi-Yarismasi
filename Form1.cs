using System;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

//https://www.kisayazi.com/genel-kultur-sorulari-coktan-secmeli.html

namespace VeritabansizBilgiYarismasi
{
    public partial class Form1 : Form
    {

        private SoundPlayer sp;
        
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0;
        int dogru = 0;
        int yanlis = 0;
        int puan = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer("DogruCevap.wav");            
        }

        private void butonlarıAktifleştir()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnA.BackColor = Color.LightGray;
            btnB.BackColor = Color.LightGray;
            btnC.BackColor = Color.LightGray;
            btnD.BackColor = Color.LightGray;
        }

        private void butonlarıPasifleştir()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            butonlarıAktifleştir();           
            soruNo++;                       
            lblSoru.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                btnGec.Text = "Geç";
                rchSoruMetni.Text = "Bilimkurgunun babası sayılan Fransız yazar aşağıdakilerden hangisidir?";
                btnA.Text = "Victor Hugo";
                btnB.Text = "Balzac";
                btnC.Text = "Jules Verne";
                btnD.Text = "Montaigne";
                label3.Text = "Jules Verne";

            }
            if (soruNo == 2)
            {
                rchSoruMetni.Text = "Türkiye Eurovision şarkı yarışmasına ilk kez hangi sanatçı ve şarkıyla ile katılmıştır?";
                btnA.Text = "Semiha Yankı – Seninle Bir Dakika";
                btnB.Text = "Kayahan – Gözlerinin Hapsindeyim";
                btnC.Text = "Sertab Erener- Everyway That I Can";
                btnD.Text = "MFÖ – Sufi";
                label3.Text = "Semiha Yankı – Seninle Bir Dakika";
            }
            if (soruNo == 3)
            {
                rchSoruMetni.Text = "Bir dönem İskandinav ülkelerinde hüküm sürmüş, yılın büyük kısmını denizlerde geçiren savaşçı halk aşağıdakilerden hangisidir?";
                btnA.Text = "Keltler";
                btnB.Text = "Aztekler";
                btnC.Text = "Anglo-saksonlar";
                btnD.Text = "Vikingler";
                label3.Text = "Vikingler";
            }
            if (soruNo == 4)
            {
                rchSoruMetni.Text = "Ünlü Fransız romanı “Notre Dame’ın Kamburu” aşağıdaki yazarların hangisi tarafından yazılmıştır ?";
                btnA.Text = "Victor Hugo";
                btnB.Text = "Jean Jarcques Rousseau";
                btnC.Text = "Honore de Balzac";
                btnD.Text = "Voltaire";
                label3.Text = "Victor Hugo";
            }
            if (soruNo == 5)
            {
                rchSoruMetni.Text = "Güney Amerika’yı keşfeden İtalyan kaşif aşağıdakilerden hangisidir?";
                btnA.Text = "Christopher Kolombus";
                btnB.Text = "Amerigo Vespucci";
                btnC.Text = "Galileo";
                btnD.Text = "Vasco da Gama";
                label3.Text = "Amerigo Vespucci";

            }
            if (soruNo == 6)
            {
                rchSoruMetni.Text = "Kuantum mekaniği, istatiksel mekanik alanlar konularında çalışmış ve özellikle İzafiyet teorisi ile fiziğe önemli katkılar sağlamış Albert Einstein’ın doğduğu ve büyüdüğü Avrupa ülkesi hangisidir?";
                btnA.Text = "Almanya";
                btnB.Text = "Amerika";
                btnC.Text = "Avusturya";
                btnD.Text = "Polonya";
                label3.Text = "Almanya";

            }
            if (soruNo == 7)
            {
                rchSoruMetni.Text = "Hangi Avrupa şehrinde kanallarda gondol gezintisi yapmak önemli bir turistik etkinliktir?";
                btnA.Text = "Floransa";
                btnB.Text = "Amsterdam";
                btnC.Text = "Bruges";
                btnD.Text = "Venedik";
                label3.Text = "Venedik";

            }
            if (soruNo == 8)
            {
                rchSoruMetni.Text = "Canavar kostümleri ile tanınan Finlandiya’lı bir hard rock grubu 2006’da yapılan 51. Eurovision şarkı yarışmasında birincilik kazandı. Bu grubun adı aşağıdakilerden hangisidir?";
                btnA.Text = "Led Zepplin";
                btnB.Text = "Lordi";
                btnC.Text = "Monster";
                btnD.Text = "Dragon";
                label3.Text = "Lordi";

            }
            if (soruNo == 9)
            {
                rchSoruMetni.Text = "FIFA’ya bağlı 6 kıta federasyonundan Avrupa Futbol Federasyonları Birliği’nin yaygın olarak kullanılan kısaltması aşağıdakilerden hangisidir?";
                btnA.Text = "UEFA";
                btnB.Text = "IFA";
                btnC.Text = "EFPM";
                btnD.Text = "ESC";
                label3.Text = "UEFA";

            }
            if (soruNo == 10)
            {
                rchSoruMetni.Text = "Aşağıdaki dillerden hangileri Latince’nin kardeş dilleri arasında yer alan Romence’ye en yakın dillerdir?";
                btnA.Text = "Fransızca ve İtalyanca";
                btnB.Text = "Macarca ve Bulgarca";
                btnC.Text = "Rusça ve Lehçe";
                btnD.Text = "Fince ve Macarca";
                label3.Text = "Fransızca ve İtalyanca";

            }
            if (soruNo == 11)
            {
                btnİpucu.Visible = true;
                rchSoruMetni.Text = "Kardeşi padişahlığını kabul etmeyerek isyan eden ve en sonunda Avrupa'nın da içine karıştığı bir taht mücadelesi veren Osmanlı Padişahı kimdir?";
                btnA.Text = "II. Bayezid";
                btnB.Text = "II. Abdulhamid";
                btnC.Text = "Osman Gazi";
                btnD.Text = "Hz.Ömer";
                label3.Text = "II. Bayezid";

            }
            if (soruNo == 12)
            {
                btnİpucu.Visible = false;
                rchSoruMetni.Text = "Sanayi devrimi ilk olarak hangi ülkede gerçekleşmiştir?";
                btnA.Text = "Almanya";
                btnB.Text = "İtalya";
                btnC.Text = "İngiltere";
                btnD.Text = "Fransa";
                label3.Text = "İngiltere";

            }
            if (soruNo == 13)
            {
                rchSoruMetni.Text = "Aşağıdakilerden hangisi 7 birincilikle Eurovizyon Yarışması’nı en çok kazanan ülkedir?";
                btnA.Text = "İrlanda";
                btnB.Text = "Avusturya";
                btnC.Text = "Montenegro";
                btnD.Text = "Ukrayna";
                label3.Text = "İrlanda";
            }
            if (soruNo == 14)
            {
                rchSoruMetni.Text = "İtalyan mutfağının en ünlü yemeği aşağıdakilerden hangisidir?";
                btnA.Text = "Gulaş";
                btnB.Text = "Sushi";
                btnC.Text = "Makarna";
                btnD.Text = "Noodle";
                label3.Text = "Makarna";
            }
            if (soruNo == 15)
            {
                rchSoruMetni.Text = "Londra’da bulunan ve asıl adı ‘Büyük Benjamin’ olan fakat kısaca ‘Big Ben’ olarak bilinen bina ne tür bir yapıdır?";
                btnA.Text = "Kilise";
                btnB.Text = "Köprü";
                btnC.Text = "Banka";
                btnD.Text = "Saat Kulesi";
                label3.Text = "Saat Kulesi";                        
            }
            
        }
        private void dogrulukKosulu()
        {

            if (label3.Text == btnA.Text)
            {
                btnA.BackColor = Color.Green;
            }
            else if (label3.Text == btnB.Text)
            {
                btnB.BackColor = Color.Green;
            }
            else if (label3.Text == btnC.Text)
            {
                btnC.BackColor = Color.Green;
            }
            else if (label3.Text == btnD.Text)
            {
                btnD.BackColor = Color.Green;
            }
        }

        private void DogruCevapSes()
        {
            SoundPlayer audio = new SoundPlayer(VeritabansizBilgiYarismasi.Properties.Resources.DogruCevap);
            audio.Play();
        }
        private void YanlisCevapSes()
        {
            SoundPlayer audio = new SoundPlayer(VeritabansizBilgiYarismasi.Properties.Resources.YanlisCevap1);
            audio.Play();

        }
        private void BonusSes1()
        {
            SoundPlayer audio = new SoundPlayer(VeritabansizBilgiYarismasi.Properties.Resources.KimdiO);
            audio.Play();
        }
        private void BonusSes2()
        {
            SoundPlayer audio = new SoundPlayer(VeritabansizBilgiYarismasi.Properties.Resources.HzÖmer);
            audio.Play();
        }
        
        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text = btnA.Text;
            if (label2.Text == label3.Text)
            {
                DogruCevapSes();
                btnA.BackColor = Color.Green;
                dogru++;
                puan += 30;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                YanlisCevapSes();
                dogrulukKosulu();
                btnA.BackColor = Color.Firebrick;                
                yanlis++;
                puan -= 10;
                lblPuan.Text = puan.ToString();
                lblYanlis.Text = yanlis.ToString();
            }
            butonlarıPasifleştir();
            if(soruNo == 15)
            {
                MessageBox.Show("Tebrikler,yarışmayı tamamladınız. Toplam " + (dogru + yanlis).ToString() + " soru cevapladınız.Toplam skorunuz: " + puan);

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            if (label2.Text == label3.Text)
            {
                DogruCevapSes();
                btnB.BackColor = Color.Green;
                dogru++;
                puan += 30;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                YanlisCevapSes();
                dogrulukKosulu();
                btnB.BackColor = Color.Firebrick;
                yanlis++;
                puan -= 10;
                lblPuan.Text = puan.ToString();
                lblYanlis.Text = yanlis.ToString();
            }
            if (soruNo == 15)
            {
                MessageBox.Show("Tebrikler,yarışmayı tamamladınız. Toplam " + (dogru + yanlis).ToString() + " soru cevapladınız.Toplam skorunuz: " + puan);

            }
            butonlarıPasifleştir();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label2.Text = btnC.Text;
            if (label2.Text == label3.Text)
            {
                DogruCevapSes();
                btnC.BackColor = Color.Green;
                dogru++;
                puan += 30;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                YanlisCevapSes();
                dogrulukKosulu();
                btnC.BackColor = Color.Firebrick;
                yanlis++;
                puan -= 10;
                lblPuan.Text = puan.ToString();
                lblYanlis.Text = yanlis.ToString();
            }
            butonlarıPasifleştir();
            if (soruNo == 15)
            {
                MessageBox.Show("Tebrikler,yarışmayı tamamladınız. Toplam " + (dogru + yanlis).ToString() + " soru cevapladınız.Toplam skorunuz: " + puan);

            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            if (soruNo == 11)
            {
                BonusSes2();
            }
            else
            {
                if (label2.Text == label3.Text)
                {
                    DogruCevapSes();
                    btnD.BackColor = Color.Green;
                    dogru++;
                    puan += 30;
                    lblPuan.Text = puan.ToString();
                    lblDogru.Text = dogru.ToString();
                }
                else
                {
                    YanlisCevapSes();
                    dogrulukKosulu();
                    btnD.BackColor = Color.Firebrick;
                    yanlis++;
                    puan -= 10;
                    lblPuan.Text = puan.ToString();
                    lblYanlis.Text = yanlis.ToString();
                }
                butonlarıPasifleştir();
                if (soruNo == 15)
                {
                    MessageBox.Show("Tebrikler,yarışmayı tamamladınız.\n -Toplam " + (dogru + yanlis).ToString() + " soru cevapladınız.\n -Net skorunuz: " + puan, "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnGec.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BonusSes1();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmKurallar fr = new frmKurallar();
            fr.Show();
        }
    }
}
