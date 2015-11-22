using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Proektna__prototip
{
    public partial class HighScores : Form
    {
        public HorizontalAlignment TextAlign { get; set; }
        GameMenu poc = null;
        HighScores getRezultati()
        {
            return this;
        }
        public HighScores(GameMenu poc)
        {
            this.poc = poc;
            InitializeComponent();

             if (File.Exists("rezultati.bin"))
            {  Stream str = File.OpenRead("rezultati.bin");
                BinaryFormatter bf = new BinaryFormatter();
                Rezultat rez = (Rezultat)bf.Deserialize(str);
                textBox1.AppendText(rez.Igrac1);
                textBox2.AppendText(rez.ToString());
                textBox3.AppendText(rez.Igrac2);
                textBox1.AppendText("\n");
                textBox2.AppendText("\n");
                textBox3.AppendText("\n");

                listBox1.Items.Add(rez.Igrac1);
                listBox2.Items.Add(rez.ToString());
                listBox3.Items.Add(rez.Igrac2);
                str.Close();
            }
              if (File.Exists("rezultati1.bin"))
             {
                 Stream str1 = File.OpenRead("rezultati1.bin");
                 BinaryFormatter bf1 = new BinaryFormatter();
                 Rezultat rez1 = (Rezultat)bf1.Deserialize(str1);
                 textBox1.AppendText(rez1.Igrac1);
                 textBox2.AppendText(rez1.ToString());
                 textBox3.AppendText(rez1.Igrac2);
                 textBox1.AppendText("\n");
                 textBox2.AppendText("\n");
                 textBox3.AppendText("\n");
                 listBox1.Items.Add(rez1.Igrac1);
                 listBox2.Items.Add(rez1.ToString());
                 listBox3.Items.Add(rez1.Igrac2);

                 str1.Close();
             }
              if (File.Exists("rezultati2.bin"))
             {
                 Stream str2 = File.OpenRead("rezultati2.bin");
                 BinaryFormatter bf2 = new BinaryFormatter();
                 Rezultat rez2 = (Rezultat)bf2.Deserialize(str2);
                 textBox1.AppendText(rez2.Igrac1);
                 textBox2.AppendText(rez2.ToString());
                 textBox3.AppendText(rez2.Igrac2);
                 textBox1.AppendText("\n");
                 textBox2.AppendText("\n");
                 textBox3.AppendText("\n");
                 listBox1.Items.Add(rez2.Igrac1);
                 listBox2.Items.Add(rez2.ToString());
                 listBox3.Items.Add(rez2.Igrac2);
                 str2.Close();
             }
              if (File.Exists("rezultati3.bin"))
             {
                 Stream str3 = File.OpenRead("rezultati3.bin");
                 BinaryFormatter bf3 = new BinaryFormatter();
                 Rezultat rez3 = (Rezultat)bf3.Deserialize(str3);
                 textBox1.AppendText(rez3.Igrac1);
                 textBox2.AppendText(rez3.ToString());
                 textBox3.AppendText(rez3.Igrac2);
                 textBox1.AppendText("\n");
                 textBox2.AppendText("\n");
                 textBox3.AppendText("\n");
                 listBox1.Items.Add(rez3.Igrac1);
                 listBox2.Items.Add(rez3.ToString());
                 listBox3.Items.Add(rez3.Igrac2);
                 str3.Close();
             }
              if (File.Exists("rezultati4.bin"))
             {
                 Stream str4 = File.OpenRead("rezultati4.bin");
                 BinaryFormatter bf4 = new BinaryFormatter();
                 Rezultat rez4 = (Rezultat)bf4.Deserialize(str4);
                 textBox1.AppendText(rez4.Igrac1);
                 textBox2.AppendText(rez4.ToString());
                 textBox3.AppendText(rez4.Igrac2);
                 textBox1.AppendText("\n");
                 textBox2.AppendText("\n");
                 textBox3.AppendText("\n");
                 listBox1.Items.Add(rez4.Igrac1);
                 listBox2.Items.Add(rez4.ToString());
                 listBox3.Items.Add(rez4.Igrac2);
                 str4.Close();
             }
              if (File.Exists("rezultati5.bin"))
             {
                 Stream str5 = File.OpenRead("rezultati5.bin");
                 BinaryFormatter bf5 = new BinaryFormatter();
                 Rezultat rez5 = (Rezultat)bf5.Deserialize(str5);
                 textBox1.Clear();
                 textBox2.Clear();
                 textBox3.Clear();
                 textBox1.AppendText(rez5.Igrac1);
                 textBox2.AppendText(rez5.ToString());
                 textBox3.AppendText(rez5.Igrac2);
                 textBox1.AppendText("\n");
                 textBox2.AppendText("\n");
                 textBox3.AppendText("\n");

     
                 str5.Close();
             }
            
        }
        

        private void Rezultati_FormClosed(object sender, FormClosedEventArgs e)
        {
            poc.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
