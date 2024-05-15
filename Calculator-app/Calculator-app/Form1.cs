using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string romenRakami(double sonuc)
        {
            int sayi = Convert.ToInt32(sonuc);
            //Burada binler, yüzler, onlar, birler diye 4 ayrı liste oluşturup ilk indekslerine boş değer atayıp geri kalanını da rakamsal değerlere göre romen rakamlarına
            //denk gelecek şekilde elemanlar atadım
            string[] binler = { "", "M", "MM", "MMM", "MV^", "V^ ","V^M", "V^MM", "V^MMM", "MX^" };
            string[] yuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] onlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] birler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            //Burada isleminin sonucundaki sayının basamak değerleri belirlemek için bir takım mod alma ve bölme işlemi yaptım
            int binlerBasamagi = sayi / 1000;
            int yuzlerBasamagi = (sayi % 1000) / 100;
            int onlarBasamagi = (sayi % 100) / 10;
            int birlerBasamagi = sayi % 10;

            //visual studio üzerinde 4000 ve üstü sayıların binler basamağının romen rakamlarıyla gösterimi olmadığı için karar yapılarını 0-4000, 4000-10000, ve 
            //diğer durumlar için ayarladım. romenRakamı fonksiyonu içerisine girilen değere göre değer döndürüyor.
            if (sayi > 0 && sayi < 4000)
                return " ≈ " + Convert.ToString(binler[binlerBasamagi] + yuzler[yuzlerBasamagi] + onlar[onlarBasamagi] + birler[birlerBasamagi]);
            else if (sayi > 3999 && sayi < 10000) 
            { 
                MessageBox.Show("İşlemin sonucu 4000 ve üzeri olduğu durumlarda romen rakamlarıyla gösterimde binler basamağı normalde olduğundan farklı gözükmektedir\n\n4000 = MV^\n5000 = V^\n6000 = V^MM\n7000 = V^MM\n8000 = V^MMM\n9000 = MX^",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return " ≈ " + Convert.ToString(binler[binlerBasamagi] + yuzler[yuzlerBasamagi] + onlar[onlarBasamagi] + birler[birlerBasamagi]);
            }
            else
                return ""; 
        }

         //Rakamlar basıldığında ilk başta sonuc labelının boş olup olmadığı kontrol ediliyor (bir işlem yapıldıktan sonra bir rakama basıldığında yeni bir işlem başlatmak için)
         //eğer boşsa islem labelı kontrol ediliyor.
         //İslem labelı boş olduğu durumda girilen rakam ilkSayi adlı labela, eğer islem labelı doluysa ikinciSayi adlı labela yazdırıyor
        private void birTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "1";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "1";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "1";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "1";
                }
            }
        }

        private void ikiTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "") 
            { 
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "2";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "2";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "2";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "2";
                }
            }
        }

        private void ucTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "3";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "3";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "3";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "3";
                }
            }
        }

        private void dortTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "4";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "4";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "4";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "4";
                }
            }
        }

        private void besTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "5";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "5";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "5";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "5";
                }
            }
        }

        private void altiTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "6";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "6";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "6";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "6";
                }
            }
        }

        private void yediTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "7";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "7";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "7";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "7";
                }
            }
        }

        private void sekizTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "8";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "8";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "8";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "8";
                }
            }
        }

        private void dokuzTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "9";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "9";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "9";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "9";
                }
            }
        }

        private void sifirTusu_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "")
            {
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "0";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "0";
                }
            }
            else
            {
                islem.Text = "  ";
                ilkSayi.Text = "";
                ikinciSayi.Text = "";
                sonuc.Text = "";
                if (islem.Text == "  ")
                {
                    ilkSayi.Text = ilkSayi.Text + "0";
                }
                else if (islem.Text != "  ")
                {
                    ikinciSayi.Text = ikinciSayi.Text + "0";
                }
            }
        }

        //Rakamlarda olduğu gibi ilk başta islem labelına bakılıyor eğer boşsa ilk sayi labelına değilse ikinci sayı labelına bakılıyor.
        //Bakılacak labela karar verildikten sonra labelın text inin sonu "," ile bitiyorsa ikinci bir virgül konulmayacağıdan hata mesajı veriyor
        private void virgul_Click(object sender, EventArgs e)
        {
            if (islem.Text == "  ") 
            {
                if (ilkSayi.Text.EndsWith(","))
                {
                    MessageBox.Show("İkinci bir virgül koyulamaz!!",
                        "DİKKAT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    ilkSayi.Text = ilkSayi.Text + ",";
                }
            }
            else
            {
                if (ikinciSayi.Text.EndsWith(","))
                {
                    MessageBox.Show("İkinci bir virgül koyulamaz!!",
                        "DİKKAT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    ikinciSayi.Text = ikinciSayi.Text + ",";
                }
            }
        }
        //Kök alma işlemi haricindeki işlem operatörlerinde ilkSayi isimli labelın boş olma durumu kontrol ediliyor. Eğer boşsa işlem operatörü konulmayacağına dair
        //hata mesajı veriliyor.ilkSayi isimli label doluysa islem operatörü islem isimli labela yerleştiriliyor
        //Kök alma işleminde ise tercihen ilk operatörün girilmesini istedim sonrasında girilen sayı da ikinciSayi adlı labela yazılıyor  
        private void bolme_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "/";
            }
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "*";
            }
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            if (ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else 
            { 
            islem.Text = "-";
            }
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "+";
            }
        }
       
        private void pow_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "pow";
            }
        }
        
        private void mod_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "%";
            }
        }
        
        private void ebob_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "EBOB";
            }
        }
       
        private void ekok_Click(object sender, EventArgs e)
        {
            if(ilkSayi.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem operatörü kullanılamaz!!",
                    "DİKKAT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                islem.Text = "EKOK";
            }
        }

        private void kok_Click(object sender, EventArgs e)
        {
            if (ilkSayi.Text != "")
            {
                MessageBox.Show("Kök alma işlemi için önce kök alma operatörünü kullanın sonrasında sayıyı giriniz!!", 
                    "DİKKAT", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                ilkSayi.Text = "";
                islem.Text = "  ";
            }
            else 
            { 
                islem.Text = "√";
            }
        }

        //İşaret değiştirme operatöründe ilk ikinciSayi adlı labelın boş olup olmadığı kontrol ediliyor. Boşsa ilkSayi adlı labela bakılıyor.
        //Label boşsa hata mesajı veriyor doluysa işaret değiştirme işlemi "-1" ile çarpmayla değiştiriliyor. Eğer ikinciSayi adlı label boş değilse aynı şekilde 
        //işaret değiştirme işlemi yapılıyor
        private void isaretDegistir_Click(object sender, EventArgs e)
        {
            if (ikinciSayi.Text == "")
            {
                if (ilkSayi.Text == "")
                    MessageBox.Show("İşaret değiştirmek için öncelikle bir sayı girmelisiniz!!", 
                        "DİKKAT", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                else
                  ilkSayi.Text = (Convert.ToDouble(ilkSayi.Text) * -1).ToString();
            }
            else
            {
                ikinciSayi.Text = (Convert.ToDouble(ikinciSayi.Text) * -1).ToString();
            }
        }


        //ilk başta ikinciSayi adlı labelın boşluk durumu kontrol ediliyor.Eğer boş değilse text1 isimli bir string değere ikinciSayi adlı label aktarılıyor
        //sonrasında yeni oluşturulumuş text1 isimli değişkene text1.substring kullanılarak son değeri kaldırılmış şekilde atanıyor. Eğer text değişkenlerinin
        //uzunluğu 0 a eşit olursa uygulama çökmesin diye silme işlemi yapılmıyor
        private void karakterSil_Click(object sender, EventArgs e)
        {
            if (ikinciSayi.Text == "")
            {
                if(islem.Text=="  ")
                {
                    string text1 = ilkSayi.Text;
                    if (text1.Length == 0) 
                    {
                        ilkSayi.Text = text1;
                    }
                    else 
                    {
                        text1 = text1.Substring(0, text1.Length - 1);
                        ilkSayi.Text = text1;
                    }
                }
                else
                {
                    string text2 = islem.Text;
                    if (text2.Length == 0)
                    {
                        islem.Text = text2;
                    }
                    else
                    {
                        text2 = text2.Substring(0, text2.Length - 1);
                        islem.Text = text2;
                    }
                }
            }
            else
            {
                string text3 = ikinciSayi.Text;
                text3 = text3.Substring(0, text3.Length - 1);
                ikinciSayi.Text = text3;
            }
        }
        //Eşittir butonuna tıklandığında ikinciSayi adlı labelın boş olup olmadığı kontrol ediliyor. Boşsa hata mesajı veriliyor
        //Eğer doluysa işlemi yapmak üzere islem adlı labelın hangi değer aldığı karar yapısıyla kontrol ediliyor
        private void esittir_Click(object sender, EventArgs e)
        {
            if (ikinciSayi.Text == "")
            {
                MessageBox.Show("İkinci Sayı Girilmeden İşlem Yapılamaz!!",
                    "DİKKAT", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else 
            { 
                //sonuc string şekilde "=" işaretiyle beraber yazdırılıyor
                //gecmiç kısmına ise eski gecmis textiyle beraber birleştirip gecmisTxt adlı labela yazdırıyor
                if (islem.Text == "-")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    sonuc.Text = "= " + (sayi1 - sayi2).ToString() + romenRakami(sayi1-sayi2);
                    gecmisTxt.Text += ilkSayi.Text +" - "+ikinciSayi.Text + sonuc.Text + "\n";
                }
                else if (islem.Text == "+")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    sonuc.Text = "= " + (sayi1 + sayi2).ToString() + romenRakami(sayi1 + sayi2);
                    gecmisTxt.Text += ilkSayi.Text + " + " + ikinciSayi.Text + sonuc.Text + "\n";
                }
                else if (islem.Text == "*")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    sonuc.Text = "= " + (sayi1 * sayi2).ToString() + romenRakami(sayi1 * sayi2);
                    gecmisTxt.Text += ilkSayi.Text + " * " + ikinciSayi.Text + sonuc.Text + "\n";
                }
                else if (islem.Text == "/")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    if (sayi2 == 0)
                    {
                        sonuc.Text = "= " + "∞";
                        gecmisTxt.Text += ilkSayi.Text + " - " + ikinciSayi.Text + sonuc.Text + "\n";
                    }
                    else
                    {
                        sonuc.Text = "= " + (sayi1 / sayi2).ToString() + romenRakami(sayi1 / sayi2);
                        gecmisTxt.Text += ilkSayi.Text + " / " + ikinciSayi.Text + sonuc.Text + "\n";
                    }
                }
                else if (islem.Text == "pow")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    sonuc.Text = Math.Pow(sayi1, sayi2).ToString() + romenRakami(Math.Pow(sayi2,sayi2));
                    gecmisTxt.Text += ilkSayi.Text + " ^ " + ikinciSayi.Text + sonuc.Text + "\n";
                }
                else if (islem.Text == "mod")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    sonuc.Text = "= " + (sayi1 % sayi2).ToString() + romenRakami(sayi1 % sayi2);
                    gecmisTxt.Text += ilkSayi.Text + " MOD(%) " + ikinciSayi.Text + sonuc.Text + "\n";
                }
                else if(islem.Text == "√")
                {
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    if (ilkSayi.Text != "")
                    {
                        MessageBox.Show("Kök alma işlemi için önce kök tuşuna basıp sonrasında kökünü almak istediğiniz tuşa basmanız gerekmektedir!!");
                        islem.Text = "  ";
                        ilkSayi.Text = "";
                        ikinciSayi.Text = "";
                        sonuc.Text = "";
                    }
                    else
                    {
                        sonuc.Text = "= " + Math.Sqrt(sayi2).ToString()+ romenRakami(Math.Sqrt(sayi2));
                        gecmisTxt.Text += "√" + ikinciSayi.Text + " = " + sonuc.Text + "\n";
                    }
                }

                //Ekok da iki sayının çarpımından başlayıp azala azala giderek tüm değerleri sayi1 ve sayi2 ile mod işlemine sokarak ortak olarak modları sıfır çıkan
                //değerleri ekok isimli bir değere atanıyor
                else if(islem.Text == "EKOK")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    int ekok;
                    for(int i = Convert.ToInt32(sayi1*sayi2); i>0; i--)
                    {
                        if (i % sayi1 == 0 && i % sayi2 == 0)
                        {
                            ekok = i;
                            sonuc.Text = "= " + ekok.ToString() + romenRakami(Convert.ToDouble(ekok));
                            
                        }
                    }
                    gecmisTxt.Text += "EKOK(" + ilkSayi.Text + "," + ikinciSayi.Text + ")" + sonuc.Text + "\n";
                }
                else if(islem.Text == "EBOB")
                {
                    double sayi1 = Convert.ToDouble(ilkSayi.Text);
                    double sayi2 = Convert.ToDouble(ikinciSayi.Text);
                    int ebob;
                    double kucukSayi;
                    if(sayi1< sayi2)
                    {
                        kucukSayi = sayi1;
                        for (int i = 2; i <= kucukSayi; i++)
                        {
                            if (sayi1 % i == 0 && sayi2 % i == 0)
                            {
                                ebob = i;
                                sonuc.Text = "= " + ebob.ToString() + romenRakami(Convert.ToDouble(ebob));
                            }
                        }
                        gecmisTxt.Text += "EBOB(" + ilkSayi.Text + "," + ikinciSayi.Text + ")" + sonuc.Text + "\n";
                    }
                    else if(sayi1 > sayi2) 
                    {
                        kucukSayi = sayi2;
                        for (int i = 2; i <= kucukSayi; i++)
                        {
                            if (sayi1 % i == 0 && sayi2 % i == 0)
                            {
                                ebob = i;
                                sonuc.Text = "= " + ebob.ToString() + romenRakami(Convert.ToDouble(ebob));
                                
                            }
                        }
                        gecmisTxt.Text += "EBOB(" + ilkSayi.Text + "," + ikinciSayi.Text + ")" + sonuc.Text + "\n";
                    }

                
                }
            }
        }
        //C tuşuna basıldığında labelları en baştaki duruma getiriyor
        private void Sil_Click(object sender, EventArgs e)
        {
            islem.Text = "  ";
            ilkSayi.Text= "";
            ikinciSayi.Text = "";
            sonuc.Text= "";
        }

        //ilk başta ikinciSayi adlı labelın boş olup olmadığı kontrol ediliyor eğer boş değilse ikinciSayi adlı label siliniyor. Eğer boşsa islem adlı labela bakılıyor
        //boş değilse siliniyor boşsa ilkSayi adlı labela bakılıyor boş değilse siliyor
        private void labelSil_Click(object sender, EventArgs e)
        {
            if (ikinciSayi.Text != "")
            {
                ikinciSayi.Text = "";
            }
            else
            {
                if (islem.Text != "  ")
                {
                    islem.Text = "";
                }
                else
                {
                    ilkSayi.Text = "";
                }
            }
            
        }
        //uygulama çalıştığında istediğim genişlik ve yükseklik değerine göre açılıyor
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 372;
            this.Height = 406;
        }

        //geçmişi açmak için kullanılan butonda her basıldığında sayac değeri arttırılıyor eğer sayac değeri tekse uygulamanın genişliği arttırılıyor geçmiş kısmının
        //visible durumu true değeri alıyor ve butonun üstündeki yazı "geçmişi gizle" diye değişiyor. Sayac çift değer aldığında ise uygulamanın genişliği başlangıç değerinde döndürülüyor
        // geçmiş kısmının visible değeri false oluyor ve butonun üzerindeki yazı "geçmişi göster" olarak değişiyor.
        int sayac = 0;
        private void gecmisBtn_Click(object sender, EventArgs e)
        {
            sayac++;
            if(sayac%2!=0)
            {
                this.Width = 541;
                gecmisTxt.Visible= true;
                gecmisBslk.Visible= true;
                gecmisBtn.Text = "Geçmişi Gizle";
            }
            else
            {
                this.Width = 372;
                gecmisTxt.Visible = false;
                gecmisBslk.Visible = false;
                gecmisBtn.Text = "Geçmişi Göster";
            }
        }

        
    }
}
