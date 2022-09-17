using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno=0, doğru=0, yanlış=0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    //cevap 1
                    case 1:
                        if (textBox1.Text == "ankara")
                        {
                            button1.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    // cevap 2
                    case 2:
                        if (textBox1.Text=="bursa")
                        {
                            button2.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 3
                    case 3:
                        if (textBox1.Text=="ceylan")
                        {
                            button3.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 4
                    case 4:
                        if (textBox1.Text == "denizli")
                        {
                            button4.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 5
                    case 5:
                        if (textBox1.Text == "edirne")
                        {
                            button5.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 6
                    case 6:
                        if (textBox1.Text == "facebook")
                        {
                            button6.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 7
                    case 7:
                        if (textBox1.Text == "gaziantep")
                        {
                            button7.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 8
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            button8.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 9
                    case 9:
                        if (textBox1.Text == "ızgara")
                        {
                            button9.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 10
                    case 10:
                        if (textBox1.Text == "iskandinav")
                        {
                            button10.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 11
                    case 11:
                        if (textBox1.Text == "jön türkler")
                        {
                            button11.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 12
                    case 12:
                        if (textBox1.Text == "kastamonu")
                        {
                            button12.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 14
                    case 14:
                        if (textBox1.Text == "manisa")
                        {
                            button24.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 15
                    case 15:
                        if (textBox1.Text == "namaz")
                        {
                            button14.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 16
                    case 16:
                        if (textBox1.Text == "osmaniye")
                        {
                            button15.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 17
                    case 17:
                        if (textBox1.Text == "paris")
                        {
                            button16.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 18
                    case 18:
                        if (textBox1.Text == "rize")
                        {
                            button17.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 19
                    case 19:
                        if (textBox1.Text == "sidney")
                        {
                            button18.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 20
                    case 20:
                        if (textBox1.Text == "trabzon")
                        {
                            button19.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 21
                    case 21:
                        if (textBox1.Text == "uğurcan")
                        {
                            button20.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 22
                    case 22:
                        if (textBox1.Text == "varisler")
                        {
                            button21.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 23
                    case 23:
                        if (textBox1.Text == "yasin")
                        {
                            button22.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                    //cevap 24
                    case 24:
                        if (textBox1.Text == "zambia")
                        {
                            button23.BackColor = Color.CadetBlue;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                        }
                        break;

                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin Başkenti Neresidir ?";
                button1.BackColor = Color.Red;
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara bölgesindeki ilimiz hangisidir ?";
                button2.BackColor = Color.Red;
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Aslanların avlanmayı sevdiği hayvan türü ? ";
                button3.BackColor = Color.Red;
            }
            if (soruno==4)
            {
                richTextBox1.Text = "Ege bölgesindeki ilimiz ? ";
                button4.BackColor = Color.Red;
            }
            if (soruno==5)
            {
                richTextBox1.Text = "Selimiye camiisinin olduğu şehir ? ";
                button5.BackColor = Color.Red;
            }
            if (soruno==6)
            {
                richTextBox1.Text = "Eskiden popüler olan bir sosyal medya ağı ? ";
                button6.BackColor = Color.Red;
            }
            if (soruno==7)
            {
                richTextBox1.Text = "Baklavası ile ünlü olan şehir ? ";
                button7.BackColor = Color.Red;
            }
            if (soruno==8)
            {
                richTextBox1.Text = "Suriye ve aynı zaman da akdeniz ile ile sınır olan şehrimiz ? ";
                button8.BackColor = Color.Red;
            }
            if (soruno==9)
            {
                richTextBox1.Text = "Bir mangal aletidir ? ";
                button9.BackColor = Color.Red;
            }
            if (soruno==10)
            {
                richTextBox1.Text = "doğa güzellikleri ve manzarası ile ünlü olan dünyadaki belirli ülkelerin genel ismi ? ";
                button10.BackColor = Color.Red;
            }
            if (soruno==11)
            {
                richTextBox1.Text = "2.ABDÜLHAMİT döneminde yeni bir devlet anlayışını sürmeye çalışan topluluk ? ";
                button11.BackColor = Color.Red;
            }
            if (soruno==12)
            {
                richTextBox1.Text = "Ayıları ile ünlü şehrimiz ? ";
                button12.BackColor = Color.Red;
            }
            if (soruno==13)
            {
                richTextBox1.Text = "Osmanlıda bir devir adı olarak da geçmektedir ve bir bitki adıdır ? ";
                button13.BackColor = Color.Red;
            }
            if (soruno==14)
            {
                richTextBox1.Text = "Ege bölgesinde üzüm yetiştiriciliği ile meşhurdur ? ";
                button24.BackColor = Color.Red;
            }
            if (soruno==15)
            {
                richTextBox1.Text = "İslam dininde dinin direği olarak adlandırılır ? ";
                button14.BackColor = Color.Red;
            }
            if (soruno==16)
            {
                richTextBox1.Text = "MHP genel başkanlarından devlet bahçelinin memleketidir ? ";
                button15.BackColor = Color.Red;
            }
            if (soruno==17)
            {
                richTextBox1.Text = "Fransanın başkentidir ? ";
                button16.BackColor = Color.Red;
            }
            if (soruno==18)
            {
                richTextBox1.Text = "Türkiye cumhurhur başkanlarından tayyip erdoğanın memleketi ? ";
                button17.BackColor = Color.Red;
            }
            if (soruno==19)
            {
                richTextBox1.Text = "Avusturyanın başkenti ? ";
                button18.BackColor = Color.Red;
            }
            if (soruno==20)
            {
                richTextBox1.Text = "Karadenizde uzungölü barındıran şenrimiz ? ";
                button19.BackColor = Color.Red;
            }
            if (soruno==21)
            {
                richTextBox1.Text = "Trabzonsporda onur kıvraktan sonra kaleye geçen genç isim ? ";
                button20.BackColor = Color.Red;
            }
            if (soruno==22)
            {
                richTextBox1.Text = "Krallıklarda kralın çoçuklarına verilen isim ? ";
                button21.BackColor = Color.Red;
            }
            if (soruno==23)
            {
                richTextBox1.Text = "Kuranın kalbi olarak anılan sure ismi ? ";
                button22.BackColor = Color.Red;
            }
            if (soruno==24)
            {
                richTextBox1.Text = "Bir afrika ülkesi ? ";
                button23.BackColor = Color.Red;
            }
        }
    }
}
