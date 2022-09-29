using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW_Decoder
{
    public partial class Form1 : Form
    {
        public static List<string> hexParam = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog of = new OpenFileDialog();
            //of.ShowDialog();
            //richTextBox1.Text = string.Join(" ", (from b in File.ReadAllBytes(of.FileName) select b.ToString("X2")).ToArray());
            richTextBox1.Clear();
            hexParam.Clear();
            richTextBox1.Text = "11 FF 5B B6 A5 74 D6 2D E5 00 13 FF 1E 8D 4F 73 6E 2B D2 00 4A 16 F9 E9 5A C2 AD 3C B3 10 00 78 00 00 FF 78 00 17 FF 00 9C 64 40 28 10 0C 89 C1 D5 E4 20 00 CB 60 00 00 FF FF 84 92 EF 74 92 03 38 35 25 37 F7 21 F3 E8 36 51 00 00 57 00 00 40 20 00 00 0C 00 57 00 01 4A 20 22 34 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 1C 20 05 0E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF F3 17 D7 83 D7 83 D7 83 D7 84 FE 65 FE 65 FE 65 FE 65 FE 65 FE 65 FE 65 FE 65 82 67 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C7";
            hexParam.AddRange(richTextBox1.Text.Split(new[] { " " }, StringSplitOptions.None));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                hexParam[0] = "11";
                hexParam[1] = "FF";
                hexParam[2] = "5B";
                hexParam[3] = "B6";
                hexParam[4] = "A5";
                hexParam[5] = "74";
                hexParam[6] = "D6";
                hexParam[7] = "2D";
                hexParam[8] = "E5";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                hexParam[0] = "0D";
                hexParam[1] = "FF";
                hexParam[2] = "63";
                hexParam[3] = "B6";
                hexParam[4] = "B9";
                hexParam[5] = "74";
                hexParam[6] = "D7";
                hexParam[7] = "2D";
                hexParam[8] = "E5";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                hexParam[0] = "0D";
                hexParam[1] = "FF";
                hexParam[2] = "7C";
                hexParam[3] = "A1";
                hexParam[4] = "BD";
                hexParam[5] = "67";
                hexParam[6] = "D6";
                hexParam[7] = "28";
                hexParam[8] = "E5";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                hexParam[0] = "0D";
                hexParam[1] = "FF";
                hexParam[2] = "6C";
                hexParam[3] = "B8";
                hexParam[4] = "C2";
                hexParam[5] = "77";
                hexParam[6] = "E0";
                hexParam[7] = "32";
                hexParam[8] = "F3";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                hexParam[0] = "0D";
                hexParam[1] = "FF";
                hexParam[2] = "69";
                hexParam[3] = "B8";
                hexParam[4] = "BF";
                hexParam[5] = "77";
                hexParam[6] = "DE";
                hexParam[7] = "32";
                hexParam[8] = "F3";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                hexParam[0] = "11";
                hexParam[1] = "FF";
                hexParam[2] = "1D";
                hexParam[3] = "F3";
                hexParam[4] = "A8";
                hexParam[5] = "74";
                hexParam[6] = "D3";
                hexParam[7] = "34";
                hexParam[8] = "E1";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                hexParam[10] = "13";
                hexParam[11] = "FF";
                hexParam[12] = "1E";
                hexParam[13] = "8D";
                hexParam[14] = "4F";
                hexParam[15] = "73";
                hexParam[16] = "6E";
                hexParam[17] = "2B";
                hexParam[18] = "D2";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                hexParam[10] = "13";
                hexParam[11] = "FF";
                hexParam[12] = "26";
                hexParam[13] = "8D";
                hexParam[14] = "4F";
                hexParam[15] = "73";
                hexParam[16] = "6E";
                hexParam[17] = "2B";
                hexParam[18] = "D2";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                hexParam[10] = "12";
                hexParam[11] = "FF";
                hexParam[12] = "1E";
                hexParam[13] = "81";
                hexParam[14] = "4E";
                hexParam[15] = "81";
                hexParam[16] = "6B";
                hexParam[17] = "2B";
                hexParam[18] = "D2";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(0, 3).Replace(binary20.Substring(0, 3), "010");
                //Получаем значение
                string binaryNew = valueBin + binary20.Substring(3, 3) + binary20.Substring(6, 2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox3.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(0, 3).Replace(binary20.Substring(0, 3), "110");
                //Получаем значение
                string binaryNew = valueBin + binary20.Substring(3, 3) + binary20.Substring(6, 2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                hexParam[31] = "78";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox4.SelectedIndex == 1)
            {
                hexParam[31] = "96";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox4.SelectedIndex == 2)
            {
                hexParam[31] = "A1";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                hexParam[34] = "FF";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox5.SelectedIndex == 1)
            {
                hexParam[34] = "46";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                hexParam[35] = "64";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 1)
            {
                hexParam[35] = "64";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 2)
            {
                hexParam[35] = "9F";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 3)
            {
                hexParam[35] = "7C";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 4)
            {
                hexParam[35] = "6C";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 5)
            {
                hexParam[35] = "78";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 6)
            {
                hexParam[35] = "C0";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 7)
            {
                hexParam[35] = "C0";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 8)
            {
                hexParam[35] = "C3";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 9)
            {
                hexParam[35] = "96";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 10)
            {
                hexParam[35] = "9E";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 11)
            {
                hexParam[35] = "4F";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox6.SelectedIndex == 11)
            {
                hexParam[35] = "49";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                hexParam[37] = "1A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox7.SelectedIndex == 1)
            {
                hexParam[37] = "17";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox7.SelectedIndex == 2)
            {
                hexParam[37] = "14";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                hexParam[40] = "9C";
                hexParam[41] = "64";
                hexParam[42] = "40";
                hexParam[43] = "28";
                hexParam[44] = "10";
                hexParam[45] = "0C";
                hexParam[46] = "89";
                hexParam[47] = "C1";
                hexParam[48] = "D5";
                hexParam[49] = "E4";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox9.SelectedIndex == 1)
            {
                hexParam[40] = "A2";
                hexParam[41] = "64";
                hexParam[42] = "50";
                hexParam[43] = "28";
                hexParam[44] = "11";
                hexParam[45] = "0C";
                hexParam[46] = "9D";
                hexParam[47] = "C2";
                hexParam[48] = "DE";
                hexParam[49] = "E9";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox9.SelectedIndex == 2)
            {
                hexParam[40] = "B4";
                hexParam[41] = "78";
                hexParam[42] = "50";
                hexParam[43] = "28";
                hexParam[44] = "0E";
                hexParam[45] = "0C";
                hexParam[46] = "89";
                hexParam[47] = "C7";
                hexParam[48] = "DE";
                hexParam[49] = "E9";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox9.SelectedIndex == 3)
            {
                hexParam[40] = "B6";
                hexParam[41] = "8C";
                hexParam[42] = "64";
                hexParam[43] = "28";
                hexParam[44] = "10";
                hexParam[45] = "0C";
                hexParam[46] = "72";
                hexParam[47] = "C5";
                hexParam[48] = "E9";
                hexParam[49] = "F4";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox9.SelectedIndex == 4)
            {
                hexParam[40] = "CC";
                hexParam[41] = "80";
                hexParam[42] = "64";
                hexParam[43] = "28";
                hexParam[44] = "0E";
                hexParam[45] = "0C";
                hexParam[46] = "A6";
                hexParam[47] = "CD";
                hexParam[48] = "EB";
                hexParam[49] = "F5";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox9.SelectedIndex == 5)
            {
                hexParam[40] = "DC";
                hexParam[41] = "A0";
                hexParam[42] = "50";
                hexParam[43] = "28";
                hexParam[44] = "14";
                hexParam[45] = "11";
                hexParam[46] = "1D";
                hexParam[47] = "A8";
                hexParam[48] = "D3";
                hexParam[49] = "E1";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 0)
            {
                hexParam[60] = "E3";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 1)
            {
                hexParam[60] = "E5";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 2)
            {
                hexParam[60] = "E7";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 3)
            {
                hexParam[60] = "E9";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 4)
            {
                hexParam[60] = "EB";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 5)
            {
                hexParam[60] = "ED";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox10.SelectedIndex == 6)
            {
                hexParam[60] = "EF";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox10.Enabled = false;
            comboBox11.Enabled = true;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                hexParam[61] = "10";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 1)
            {
                hexParam[61] = "20";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 2)
            {
                hexParam[61] = "30";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 3)
            {
                hexParam[61] = "40";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 4)
            {
                hexParam[61] = "50";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 5)
            {
                hexParam[61] = "60";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox11.SelectedIndex == 6)
            {
                hexParam[61] = "70";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox11.Enabled = false;
            comboBox12.Enabled = true;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                hexParam[61] = hexParam[61].Replace("0","0");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 1)
            {
                hexParam[61] = hexParam[61].Replace("0", "1");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 2)
            {
                hexParam[61] = hexParam[61].Replace("0", "2");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 3)
            {
                hexParam[61] = hexParam[61].Replace("0", "3");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 4)
            {
                hexParam[61] = hexParam[61].Replace("0", "4");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 5)
            {
                hexParam[61] = hexParam[61].Replace("0", "5");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 6)
            {
                hexParam[61] = hexParam[61].Replace("0", "6");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 7)
            {
                hexParam[61] = hexParam[61].Replace("0", "7");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 8)
            {
                hexParam[61] = hexParam[61].Replace("0", "8");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox12.SelectedIndex == 9)
            {
                hexParam[61] = hexParam[61].Replace("0", "9");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox12.Enabled = false;
            comboBox13.Enabled = true;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.SelectedIndex == 0)
            {
                hexParam[58] = "0A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 1)
            {
                hexParam[58] = "1A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 2)
            {
                hexParam[58] = "2A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 3)
            {
                hexParam[58] = "3A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 4)
            {
                hexParam[58] = "4A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 5)
            {
                hexParam[58] = "5A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 6)
            {
                hexParam[58] = "6A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 7)
            {
                hexParam[58] = "7A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 8)
            {
                hexParam[58] = "8A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox13.SelectedIndex == 9)
            {
                hexParam[58] = "9A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox13.Enabled = false;
            comboBox14.Enabled = true;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.SelectedIndex == 0)
            {
                hexParam[58] = hexParam[58].Replace("A","0");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 1)
            {
                hexParam[58] = hexParam[58].Replace("A", "1");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 2)
            {
                hexParam[58] = hexParam[58].Replace("A", "2");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 3)
            {
                hexParam[58] = hexParam[58].Replace("A", "3");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 4)
            {
                hexParam[58] = hexParam[58].Replace("A", "4");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 5)
            {
                hexParam[58] = hexParam[58].Replace("A", "5");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 6)
            {
                hexParam[58] = hexParam[58].Replace("A", "6");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 7)
            {
                hexParam[58] = hexParam[58].Replace("A", "7");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 8)
            {
                hexParam[58] = hexParam[58].Replace("A", "8");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox14.SelectedIndex == 9)
            {
                hexParam[58] = hexParam[58].Replace("A", "9");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox14.Enabled = false;
            comboBox15.Enabled = true;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == 0)
            {
                hexParam[59] = "0A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 1)
            {
                hexParam[59] = "1A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 2)
            {
                hexParam[59] = "2A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 3)
            {
                hexParam[59] = "3A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 4)
            {
                hexParam[59] = "4A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 5)
            {
                hexParam[59] = "5A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 6)
            {
                hexParam[59] = "6A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 7)
            {
                hexParam[59] = "7A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 8)
            {
                hexParam[59] = "8A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox15.SelectedIndex == 9)
            {
                hexParam[59] = "9A";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox15.Enabled = false;
            comboBox16.Enabled = true;

        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox16.SelectedIndex == 0)
            {
                hexParam[59] = hexParam[59].Replace("A", "0");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 1)
            {
                hexParam[59] = hexParam[59].Replace("A", "1");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 2)
            {
                hexParam[59] = hexParam[59].Replace("A", "2");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 3)
            {
                hexParam[59] = hexParam[59].Replace("A", "3");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 4)
            {
                hexParam[59] = hexParam[59].Replace("A", "4");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 5)
            {
                hexParam[59] = hexParam[59].Replace("A", "5");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 6)
            {
                hexParam[59] = hexParam[59].Replace("A", "6");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 7)
            {
                hexParam[59] = hexParam[59].Replace("A", "7");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 8)
            {
                hexParam[59] = hexParam[59].Replace("A", "8");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox16.SelectedIndex == 9)
            {
                hexParam[59] = hexParam[59].Replace("A", "9");
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            comboBox16.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 6)
            {
                label13.Visible = true;
                label13.Text = "Длина пробега превышает 6 цифр";
            }
            else
            {
                int probeg = Convert.ToInt32(textBox1.Text);
                int correct = probeg / 32;
                int finish = correct * 32;
                textBox1.Text = finish.ToString();
                string hexProbeg = Convert.ToString(correct, 16);
                string value1 = hexProbeg.Substring(0, 2).ToUpper(); //Берем значения с 0 при 2 символах
                string value2 = hexProbeg.Substring(2, 2).ToUpper(); //Берем значения от 2 символа до 
                label13.Visible = true;

                hexParam[222] = value1;
                hexParam[223] = value2;

                hexParam[224] = value1;
                hexParam[225] = value2;

                hexParam[226] = value1;
                hexParam[227] = value2;

                hexParam[228] = value1;
                hexParam[229] = value2;

                hexParam[230] = value1;
                hexParam[231] = value2;

                hexParam[232] = value1;
                hexParam[233] = value2;

                hexParam[234] = value1;
                hexParam[235] = value2;

                hexParam[236] = value1;
                hexParam[237] = value2;

                hexParam[238] = value1;
                hexParam[239] = value2;

                hexParam[240] = value1;
                hexParam[241] = value2;

                hexParam[242] = value1;
                hexParam[243] = value2;

                hexParam[244] = value1;
                hexParam[245] = value2;

                hexParam[246] = value1;
                hexParam[247] = value2;

                hexParam[248] = value1;
                hexParam[249] = value2;

                hexParam[250] = value1;
                hexParam[251] = value2;

                hexParam[252] = value1;
                hexParam[253] = value2;

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
                label13.Text = "Пробег скорректирован";
                ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox10.Enabled = true;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://money.yandex.ru/to/410012274917815");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://rocketbank.ru/fortek");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.drive2.ru/users/forteks/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Binary|*.bin";

            if (sf.ShowDialog() == DialogResult.OK && sf.FileName.Length > 0)
            {
                byte[] b = richTextBox1.Text.Split(' ').Select(n => Convert.ToByte(Convert.ToInt32(n, 16))).ToArray();
                File.WriteAllBytes(sf.FileName, b);
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == 0)
            {                
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(3, 3).Replace(binary20.Substring(3, 3), "001");
                //Получаем значение
                string binaryNew = binary20.Substring(0,3) + valueBin + binary20.Substring(6,2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox17.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(3, 3).Replace(binary20.Substring(3, 3), "010");
                //Получаем значение
                string binaryNew = binary20.Substring(0, 3) + valueBin + binary20.Substring(6, 2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox17.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(3, 3).Replace(binary20.Substring(3, 3), "011");
                //Получаем значение
                string binaryNew = binary20.Substring(0, 3) + valueBin + binary20.Substring(6, 2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox17.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(3, 3).Replace(binary20.Substring(3, 3), "010");
                //Получаем значение
                string binaryNew = binary20.Substring(0, 3) + valueBin + binary20.Substring(6, 2);
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox18.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(6, 2).Replace(binary20.Substring(6, 2), "10");
                //Получаем значение
                string binaryNew = binary20.Substring(0, 6) + valueBin;
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox18.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary20 = Convert.ToString(Convert.ToInt32(hexParam[20], 16), 2).PadLeft(hexParam[20].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary20.Substring(6, 2).Replace(binary20.Substring(6, 2), "01");
                //Получаем значение
                string binaryNew = binary20.Substring(0, 6) + valueBin;
                //Заносим данные в массив
                hexParam[20] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[20];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox19.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(7, 1).Replace(binary25.Substring(7, 1), "0");
                //Получаем значение
                string binaryNew = binary25.Substring(0, 7) + valueBin;
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox19.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(7, 1).Replace(binary25.Substring(7, 1), "1");
                //Получаем значение
                string binaryNew = binary25.Substring(0, 7) + valueBin;
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox20.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1100011");
                //Получаем значение
                string binaryNew =  valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1100001");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1100000");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011110");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 4)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011100");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 5)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1100011");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 6)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1100001");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 7)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011111");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 8)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011101");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 9)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011111");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox20.SelectedIndex == 10)
            {
                //Получаем бинарный код значения
                string binary25 = Convert.ToString(Convert.ToInt32(hexParam[25], 16), 2).PadLeft(hexParam[25].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary25.Substring(0, 7).Replace(binary25.Substring(0, 7), "1011010");
                //Получаем значение
                string binaryNew = valueBin + binary25.Substring(7, 1);
                //Заносим данные в массив
                hexParam[25] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[25];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox21.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary26 = Convert.ToString(Convert.ToInt32(hexParam[26], 16), 2).PadLeft(hexParam[26].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary26.Substring(0, 7).Replace(binary26.Substring(0, 7), "1010110");
                //Получаем значение
                string binaryNew = valueBin + binary26.Substring(7, 1);
                //Заносим данные в массив
                hexParam[26] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[26];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox21.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary26 = Convert.ToString(Convert.ToInt32(hexParam[26], 16), 2).PadLeft(hexParam[26].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary26.Substring(0, 7).Replace(binary26.Substring(0, 7), "1010000");
                //Получаем значение
                string binaryNew = valueBin + binary26.Substring(7, 1);
                //Заносим данные в массив
                hexParam[26] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[26];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox21.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary26 = Convert.ToString(Convert.ToInt32(hexParam[26], 16), 2).PadLeft(hexParam[26].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary26.Substring(0, 7).Replace(binary26.Substring(0, 7), "1001000");
                //Получаем значение
                string binaryNew = valueBin + binary26.Substring(7, 1);
                //Заносим данные в массив
                hexParam[26] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[26];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox22.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary29 = Convert.ToString(Convert.ToInt32(hexParam[29], 16), 2).PadLeft(hexParam[29].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary29.Substring(5, 3).Replace(binary29.Substring(5, 3), "000");
                //Получаем значение
                string binaryNew = binary29.Substring(0, 5) + valueBin;
                //Заносим данные в массив
                hexParam[29] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[29];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox22.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary29 = Convert.ToString(Convert.ToInt32(hexParam[29], 16), 2).PadLeft(hexParam[29].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary29.Substring(5, 3).Replace(binary29.Substring(5, 3), "100");
                //Получаем значение
                string binaryNew = binary29.Substring(0, 5) + valueBin;
                //Заносим данные в массив
                hexParam[29] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[29];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox22.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary29 = Convert.ToString(Convert.ToInt32(hexParam[29], 16), 2).PadLeft(hexParam[29].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary29.Substring(5, 3).Replace(binary29.Substring(5, 3), "101");
                //Получаем значение
                string binaryNew = binary29.Substring(0, 5) + valueBin;
                //Заносим данные в массив
                hexParam[29] = Convert.ToInt32(binaryNew, 2).ToString("X");
                label17.Text = hexParam[29];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox23.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(4, 4).Replace(binary39.Substring(4, 4), "0000");
                //Получаем значение
                string binaryNew = binary39.Substring(0, 4) + valueBin;
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox23.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(4, 4).Replace(binary39.Substring(4, 4), "0001");
                //Получаем значение
                string binaryNew = binary39.Substring(0, 4) + valueBin;
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox23.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(4, 4).Replace(binary39.Substring(4, 4), "0010");
                //Получаем значение
                string binaryNew = binary39.Substring(0, 4) + valueBin;
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox23.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(4, 4).Replace(binary39.Substring(4, 4), "0011");
                //Получаем значение
                string binaryNew = binary39.Substring(0, 4) + valueBin;
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox23.SelectedIndex == 4)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(4, 4).Replace(binary39.Substring(4, 4), "0100");
                //Получаем значение
                string binaryNew = binary39.Substring(0, 4) + valueBin;
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0000");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox8.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0001");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox8.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0010");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox8.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0011");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox8.SelectedIndex == 4)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0100");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox8.SelectedIndex == 5)
            {
                //Получаем бинарный код значения
                string binary39 = Convert.ToString(Convert.ToInt32(hexParam[39], 16), 2).PadLeft(hexParam[39].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary39.Substring(0, 4).Replace(binary39.Substring(0, 4), "0101");
                //Получаем значение
                string binaryNew = valueBin + binary39.Substring(4, 4);
                //Заносим данные в массив
                hexParam[39] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[39];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox24.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00000");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00001");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00010");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00011");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 4)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00100");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 5)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00101");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 6)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00110");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 7)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "00111");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 8)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "01000");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox24.SelectedIndex == 9)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(3, 5).Replace(binary50.Substring(3, 5), "01001");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 3) + valueBin;
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox25.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(2, 1).Replace(binary50.Substring(2, 1), "0");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 2) + valueBin + binary50.Substring(3, 5);
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox25.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary50 = Convert.ToString(Convert.ToInt32(hexParam[50], 16), 2).PadLeft(hexParam[50].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary50.Substring(2, 1).Replace(binary50.Substring(2, 1), "1");
                //Получаем значение
                string binaryNew = binary50.Substring(0, 2) + valueBin + binary50.Substring(3, 5);
                //Заносим данные в массив
                hexParam[50] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[50];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox26.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary51 = Convert.ToString(Convert.ToInt32(hexParam[51], 16), 2).PadLeft(hexParam[51].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary51.Substring(0, 2).Replace(binary51.Substring(0, 2), "00");
                //Получаем значение
                string binaryNew = valueBin + binary51.Substring(2, 6);
                //Заносим данные в массив
                hexParam[51] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[51];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox26.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary51 = Convert.ToString(Convert.ToInt32(hexParam[51], 16), 2).PadLeft(hexParam[51].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary51.Substring(0, 2).Replace(binary51.Substring(0, 2), "01");
                //Получаем значение
                string binaryNew = valueBin + binary51.Substring(2, 6);
                //Заносим данные в массив
                hexParam[51] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[51];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox26.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary51 = Convert.ToString(Convert.ToInt32(hexParam[51], 16), 2).PadLeft(hexParam[51].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary51.Substring(0, 2).Replace(binary51.Substring(0, 2), "10");
                //Получаем значение
                string binaryNew = valueBin + binary51.Substring(2, 6);
                //Заносим данные в массив
                hexParam[51] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[51];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox26.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary51 = Convert.ToString(Convert.ToInt32(hexParam[51], 16), 2).PadLeft(hexParam[51].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary51.Substring(0, 2).Replace(binary51.Substring(0, 2), "11");
                //Получаем значение
                string binaryNew = valueBin + binary51.Substring(2, 6);
                //Заносим данные в массив
                hexParam[51] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[51];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox27.SelectedIndex == 0)
            {
                hexParam[52] = "CB";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox27.SelectedIndex == 1)
            {
                hexParam[52] = "CD";
                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox28.SelectedIndex == 0)
            {
                //Получаем бинарный код значения
                string binary53 = Convert.ToString(Convert.ToInt32(hexParam[53], 16), 2).PadLeft(hexParam[53].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary53.Substring(0, 4).Replace(binary53.Substring(0, 4), "0100");
                //Получаем значение
                string binaryNew = valueBin + binary53.Substring(4, 4);
                //Заносим данные в массив
                hexParam[53] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[53];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox28.SelectedIndex == 1)
            {
                //Получаем бинарный код значения
                string binary53 = Convert.ToString(Convert.ToInt32(hexParam[53], 16), 2).PadLeft(hexParam[53].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary53.Substring(0, 4).Replace(binary53.Substring(0, 4), "0110");
                //Получаем значение
                string binaryNew = valueBin + binary53.Substring(4, 4);
                //Заносим данные в массив
                hexParam[53] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[53];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox28.SelectedIndex == 2)
            {
                //Получаем бинарный код значения
                string binary53 = Convert.ToString(Convert.ToInt32(hexParam[53], 16), 2).PadLeft(hexParam[53].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary53.Substring(0, 4).Replace(binary53.Substring(0, 4), "1000");
                //Получаем значение
                string binaryNew = valueBin + binary53.Substring(4, 4);
                //Заносим данные в массив
                hexParam[53] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[53];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
            if (comboBox28.SelectedIndex == 3)
            {
                //Получаем бинарный код значения
                string binary53 = Convert.ToString(Convert.ToInt32(hexParam[53], 16), 2).PadLeft(hexParam[53].Length * 4, '0');
                //Берем значение и реплейсим
                string valueBin = binary53.Substring(0, 4).Replace(binary53.Substring(0, 4), "1100");
                //Получаем значение
                string binaryNew = valueBin + binary53.Substring(4, 4);
                //Заносим данные в массив
                hexParam[53] = Convert.ToInt32(binaryNew, 2).ToString("X2");
                label17.Text = hexParam[53];

                richTextBox1.Clear();
                foreach (var name in hexParam)
                    richTextBox1.AppendText(name + " ");
            }
        }
    }
}
