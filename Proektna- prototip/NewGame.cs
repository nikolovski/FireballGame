using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Resources;
using Proektna__prototip.Properties;
using System.Media;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace Proektna__prototip
{
    public partial class NewGame : Form
    {
       Players ig = null;
        Timer timer;
        Ball ball;
        Graphics graphics;
        Brush brush;
        Rectangle bounds;
        Bitmap pozadina;
        static readonly int FRAMES_PER_SECOND = 30;
        public int f = 0;
        public int flag = 0;
        public int flagce = 1;
        public String labela1;
        public String labela2;
        float speedX, speedY;
        public int max;
        public int i;
        public int j;
        
       
        public NewGame(Players ig)
        {
            InitializeComponent();
            this.ig = ig;
            lbl_igrac1.Text = ig.tbPlayer1.Text;
            lbl_igrac2.Text = ig.tbPlayer2.Text;
            
            bounds = new Rectangle(10, 10, this.Bounds.Width, this.Bounds.Height -120);
            pozadina = new Bitmap(Width,Height);
            graphics = CreateGraphics();
            ball = new Ball(Width / 2, Height / 2, 20, 20, (float)(Math.PI/4 ));
            ball.bound = bounds;
            Show();
            brush = new SolidBrush(Color.Blue); 
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 500 / FRAMES_PER_SECOND;
            max = (int)ig.numericUpDown1.Value;
            lbl_rez1.Text = (max).ToString();
            lbl_rez2.Text = (max).ToString();
            
            
        }
       
        
       


        void timer_Tick(object sender, EventArgs e)
        {

            if (Math.Abs(ball.directionY) < ball.directionY + 1)
            {

            }
            
            try
            {
                Rezultat rezultat = new Rezultat(lbl_igrac1.Text, lbl_igrac2.Text, Int32.Parse(lbl_rez1.Text), Int32.Parse(lbl_rez2.Text));




                if (lbl_rez1.Text == 0.ToString())
                {
                    timer.Stop();
                    DialogResult result = MessageBox.Show("Победник е " + lbl_igrac2.Text + ". Дали сакате нова игра?", "Известување", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        lbl_rez1.Text = max.ToString();
                        lbl_rez2.Text = max.ToString();
                        i = max;
                        j = max;
                        lbl_zapocni.Visible = true;
                        
                        if (!File.Exists("rezultati.bin"))
                        {
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();


                        }
                        else if (!File.Exists("rezultati1.bin"))
                        {
                            Stream str = File.Create("rezultati1.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati2.bin"))
                        {
                            Stream str = File.Create("rezultati2.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati3.bin"))
                        {
                            Stream str = File.Create("rezultati3.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati4.bin"))
                        {
                            Stream str = File.Create("rezultati4.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati5.bin"))
                        {
                            Stream str = File.Create("rezultati5.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else
                        {
                            
                            File.Delete("rezultati.bin");
                            File.Delete("rezultati1.bin");
                            File.Delete("rezultati2.bin");
                            File.Delete("rezultati3.bin");
                            File.Delete("rezultati4.bin");
                            File.Delete("rezultati5.bin");
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }


                    }
                    else if (result == DialogResult.No)
                    {

                        if (!File.Exists("rezultati.bin"))
                        {
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();


                        }
                        else if (!File.Exists("rezultati1.bin"))
                        {
                            Stream str = File.Create("rezultati1.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati2.bin"))
                        {
                            Stream str = File.Create("rezultati2.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati3.bin"))
                        {
                            Stream str = File.Create("rezultati3.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati4.bin"))
                        {
                            Stream str = File.Create("rezultati4.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati5.bin"))
                        {
                            Stream str = File.Create("rezultati5.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else 
                        {
                            File.Delete("rezultati.bin");
                            File.Delete("rezultati1.bin");
                            File.Delete("rezultati2.bin");
                            File.Delete("rezultati3.bin");
                            File.Delete("rezultati4.bin");
                            File.Delete("rezultati5.bin");
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                    
                        
                        ig.getGameMenu().Show();
                        this.Close();
                    }

                }

                else if (lbl_rez2.Text == 0.ToString())
                {
                    timer.Stop();
                    DialogResult result = MessageBox.Show("Победник е " + lbl_igrac1.Text + ". Дали сакате нова игра?", "Известување", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!File.Exists("rezultati.bin"))
                        {
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();


                        }
                        else if (!File.Exists("rezultati1.bin"))
                        {
                            Stream str = File.Create("rezultati1.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati2.bin"))
                        {
                            Stream str = File.Create("rezultati2.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati3.bin"))
                        {
                            Stream str = File.Create("rezultati3.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati4.bin"))
                        {
                            Stream str = File.Create("rezultati4.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati5.bin"))
                        {
                            Stream str = File.Create("rezultati5.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else
                        {

                            File.Delete("rezultati.bin");
                            File.Delete("rezultati1.bin");
                            File.Delete("rezultati2.bin");
                            File.Delete("rezultati3.bin");
                            File.Delete("rezultati4.bin");
                            File.Delete("rezultati5.bin");
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }

                        lbl_rez1.Text = max.ToString();
                        lbl_rez2.Text = max.ToString();
                        i = max;
                        j = max;
                        lbl_space.Visible = true;


                    }
                    else if (result == DialogResult.No)
                    {
                        timer.Stop();
                        if (!File.Exists("rezultati.bin"))
                        {
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();


                        }
                        else if (!File.Exists("rezultati1.bin"))
                        {
                            Stream str = File.Create("rezultati1.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati2.bin"))
                        {
                            Stream str = File.Create("rezultati2.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati3.bin"))
                        {
                            Stream str = File.Create("rezultati3.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati4.bin"))
                        {
                            Stream str = File.Create("rezultati4.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else if (!File.Exists("rezultati5.bin"))
                        {
                            Stream str = File.Create("rezultati5.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();
                        }
                        else
                        {

                            File.Delete("rezultati.bin");
                            File.Delete("rezultati1.bin");
                            File.Delete("rezultati2.bin");
                            File.Delete("rezultati3.bin");
                            File.Delete("rezultati4.bin");
                            File.Delete("rezultati5.bin");
                            Stream str = File.Create("rezultati.bin");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
                            bf.Serialize(str, rezultat);
                            str.Close();

                        }
                        ig.getGameMenu().Show();
                        this.Close();

                    }
                }



                lbl_igrac1.Text = labela1;
                lbl_igrac2.Text = labela2;
                ResourceManager rm = Resources.ResourceManager;
                Graphics g = Graphics.FromImage(pozadina);

                if (ball.positionX >= pb_igrac2.Location.X - pb_igrac2.Width-26)
                {
                    if ((ball.positionY <= pb_igrac2.Location.Y + pb_igrac2.Size.Height - 26) && (ball.positionY >= pb_igrac2.Location.Y+26))
                    {
                        
                        ball.directionX = -ball.directionX;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }
                    if ((ball.positionY <= pb_igrac2.Location.Y + 26) && (ball.positionY >= pb_igrac2.Location.Y-30))
                    {
                       
                        ball.directionX = -ball.directionX;
                        ball.directionY = -ball.directionY;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }
                    if ((ball.positionY <= pb_igrac2.Location.Y + pb_igrac2.Size.Height+10 ) && (ball.positionY >= pb_igrac2.Location.Y + pb_igrac2.Size.Height - 26))
                    {
                       
                        ball.directionX = -ball.directionX;
                        ball.directionY = -ball.directionY;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }


                }

                if (ball.positionX <= pb_igrac1.Location.X + pb_igrac1.Width+26)
                {

                    if ((ball.positionY <= pb_igrac1.Location.Y + pb_igrac1.Size.Height - 26) && (ball.positionY >= pb_igrac1.Location.Y + 26))
                    {
                       
                        ball.directionX = -ball.directionX;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }

                    if ((ball.positionY <= pb_igrac1.Location.Y + 26) && (ball.positionY >= pb_igrac1.Location.Y-30))
                    {
                       
                        ball.directionX = -ball.directionX;
                        ball.directionY = -ball.directionY;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }
                    if ((ball.positionY <= pb_igrac1.Location.Y + pb_igrac1.Size.Height+10) && (ball.positionY >= pb_igrac1.Location.Y + pb_igrac1.Size.Height - 26))
                    {
                       
                        ball.directionX = -ball.directionX;
                        ball.directionY = -ball.directionY;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.drvo_zvuk);
                        simpleSound.Play();


                    }

                }

                if ((ball.positionX <( ball.bound.Width/2)+10) && (ball.positionX > (ball.bound.Width/2)-10))
                {
                    SoundPlayer simpleSound = new SoundPlayer(Resources.ogan_zvuk);

                    simpleSound.Play();
                }


                if (ball.positionX < ball.bound.Left+50)
                {
                    if (Int32.Parse(lbl_rez1.Text)>1)
                   
                    {
                        
                        lbl_space.Visible = true;
                        lbl_rez1.Text = (--i).ToString();
                        ball.positionX = 400;
                        ball.positionY = 50;
                        SoundPlayer simpleSound = new SoundPlayer(Resources.voda_zvuk);
                        simpleSound.Play();
                    }
                    else
                    {
                        SoundPlayer simpleSound = new SoundPlayer(Resources.gasenje_topka);
                        
                        lbl_space.Visible = true;
                        lbl_rez1.Text = (--i).ToString();
                        ball.positionX = 400;
                        ball.positionY = 50;
                        simpleSound.Play();
                    }
                    timer.Stop();
                }

                if (ball.positionX > ball.bound.Right-60)
                {

                    if (Int32.Parse(lbl_rez2.Text) > 1)
                    {
                        
                        lbl_space.Visible = true;
                        lbl_rez2.Text = (--j).ToString();
                      
                        SoundPlayer simpleSound = new SoundPlayer(Resources.voda_zvuk);
                        simpleSound.Play();
                        ball.positionX = 400;
                        ball.positionY = 50;
                    }
                else 
                    {
                        SoundPlayer simpleSound = new SoundPlayer(Resources.gasenje_topka);
                      
                        lbl_space.Visible = true;
                        lbl_rez2.Text = (--j).ToString();
                        ball.positionX = 400;
                        ball.positionY = 50;
                        simpleSound.Play();
                    }
                    timer.Stop();
                }

                if (f == 0)
                {
                    Image slika = (Image)rm.GetObject("igra_pozadina1");
                    g.DrawImage(slika, 0, 0, Width, Height);
                    ball.Draw(brush, g);
                    ball.move();
                    try
                    {
                        graphics.DrawImageUnscaled(pozadina, 0, 0, Width, Height);
                    }
                    catch (Exception) { }
                }

                if (f == 1)
                {

                    Image slika = (Image)rm.GetObject("igra_pozadina2");

                    g.DrawImage(slika, 0, 0, Width, Height);
                    ball.Draw(brush, g);

                    ball.move();
                    try
                    {
                        graphics.DrawImageUnscaled(pozadina, 0, 0, Width, Height);
                    }
                    catch (Exception) { }
                }

                if (f == 2)
                {

                    Image slika = (Image)rm.GetObject("igra_pozadina3");

                    g.DrawImage(slika, 0, 0, Width, Height);
                    ball.Draw(brush, g);

                    ball.move();
                    try
                    {
                        graphics.DrawImageUnscaled(pozadina, 0, 0, Width, Height);
                    }
                    catch (Exception) { }

                }

                if (f == 3)
                {

                    Image slika = (Image)rm.GetObject("igra_pozadina4");

                    g.DrawImage(slika, 0, 0, Width, Height);
                    ball.Draw(brush, g);

                    ball.move();
                    try
                    {
                        graphics.DrawImageUnscaled(pozadina, 0, 0, Width, Height);
                    }
                    catch (Exception) { }

                }
                if (f == 4)
                {

                    Image slika = (Image)rm.GetObject("igra_pozadina5");

                    g.DrawImage(slika, 0, 0, Width, Height);
                    ball.Draw(brush, g);

                    ball.move();
                    try
                    {
                        graphics.DrawImageUnscaled(pozadina, 0, 0, Width, Height);
                    }
                    catch (Exception) { }
                    f = 0;
                }

                f++;
            }
            catch (Exception ) { };
        }
        
        


        private void NovaIgra_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                
                lbl_space.Visible = false;
                timer.Start();
                lbl_zapocni.Visible = false;
            }


            if (pb_igrac1.Location.Y > 0)
            {
                if (e.KeyCode == Keys.W)
                {
                    int h1;
                    h1 = pb_igrac1.Location.Y;
                    h1 -= 50;
                    pb_igrac1.Location = new System.Drawing.Point(pb_igrac1.Location.X, h1);
                }
            }

            if (pb_igrac1.Location.Y < this.Bounds.Height - 225)
            {
                if (e.KeyCode == Keys.S)
                {
                    int z1;
                    z1 = pb_igrac1.Location.Y;
                    z1 += 50;
                    pb_igrac1.Location = new System.Drawing.Point(pb_igrac1.Location.X, z1);
                }
            }

            if (pb_igrac2.Location.Y > 0){
                if (e.KeyCode == Keys.Up)
                {
                    int h;
                    h = pb_igrac2.Location.Y;
                    h -= 50;
                    pb_igrac2.Location = new System.Drawing.Point(pb_igrac2.Location.X, h);

                }
            }

            if (pb_igrac2.Location.Y < this.Bounds.Height - 225)
            {
                if (e.KeyCode == Keys.Down)
                {
                    int z;
                    z = pb_igrac2.Location.Y;
                    z += 50;
                    pb_igrac2.Location = new System.Drawing.Point(pb_igrac2.Location.X, z);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (flag == 0)
                {
                    MainMenuStrip.Visible = true;
                    speedX = ball.directionX;
                    speedY = ball.directionY;
                    ball.directionX = 0;
                    ball.directionY = 0;
                    flag = 1;
                    lbl_pauza.Visible = true;
                    lbl_space.Visible = false;
                }

                else
                {

                    ball.directionX = speedX;
                    ball.directionY = speedY;
                    flag = 0;
                    lbl_pauza.Visible = false;
                    MainMenuStrip.Visible = false;
                }
            }
        }
   



private void спороToolStripMenuItem_Click(object sender, EventArgs e)
{
    брзоToolStripMenuItem.Checked = false;
    спороToolStripMenuItem.Checked = true;
    ball.speed = 2;
    средноToolStripMenuItem.Checked = false;
}

private void средноToolStripMenuItem_Click(object sender, EventArgs e)
{
    спороToolStripMenuItem.Checked = false;
    брзоToolStripMenuItem.Checked = false;
    средноToolStripMenuItem.Checked = true;
    ball.speed = 3;
}

private void брзоToolStripMenuItem_Click(object sender, EventArgs e)
{
    спороToolStripMenuItem.Checked = false;
    брзоToolStripMenuItem.Checked = true;
    ball.speed =4 ;
    средноToolStripMenuItem.Checked = false;
}

private void NovaIgra_FormClosing(object sender, FormClosingEventArgs e)
{
    ig.getGameMenu().Show();
    SoundPlayer simpleSound = new SoundPlayer(Resources.glavna_zvuk);
    simpleSound.PlayLooping();
}

        private void lbl_zapocni_Click(object sender, EventArgs e)
        {

        }

        private void контролиToolStripMenuItem_Click(object sender, EventArgs e)
{
    Controls k = new Controls(this);
    this.Enabled = false;
    k.Show();
}


    }

    }


