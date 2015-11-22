using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using Proektna__prototip.Properties;
using System.Media;

namespace Proektna__prototip
{
    public partial class GameMenu : Form
    {
        public int i { get; set; }
        public GameMenu()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(Resources.glavna_zvuk);
            simpleSound.PlayLooping();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("nova_igra_kopce");
            pictureBox1.Image = slika;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("nova_igra_kopce_neselektirano");
            pictureBox1.Image = slika;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("nova_igra_kopce_stisnato");
            pictureBox1.Image = slika;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("nova_igra_kopce");
            pictureBox1.Image = slika;

            
                Players ime = new Players(this);
                this.Hide();
                ime.Show();
                
            
        }

        
        private void ImeNaIgraci_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                this.Hide();
        }


        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("kontroli_kopce");
            pictureBox2.Image = slika;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("kontroli_kopce_neselektirano");
            pictureBox2.Image = slika;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("kontroli__kopce_stisnato");
            pictureBox2.Image = slika;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("kontroli_kopce");
            pictureBox2.Image = slika;

            Controls kontroli = new Controls(this);
            this.Hide();
            kontroli.Show();   
        }

        
        

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("izlez_kopce");
            pictureBox3.Image = slika;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("izlez_kopce_neselektirano");
            pictureBox3.Image = slika;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("izlez_kopce_stisnato");
            pictureBox3.Image = slika;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("izlez_kopce");
            pictureBox3.Image = slika;
            this.Close();
        }

       

       

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("rezultati_kopce");
            pictureBox5.Image = slika;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("rezultati_kopce_stisnato");
            pictureBox5.Image = slika;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("rezultati_kopce_neselektirano");
            pictureBox5.Image = slika;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image slika = (Image)rm.GetObject("rezultati_kopce");
            pictureBox5.Image = slika;
            
            HighScores rez = new HighScores(this);
            this.Visible = false;
            rez.Show();
        }

        
        private void Rezultati_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        

    }
}
