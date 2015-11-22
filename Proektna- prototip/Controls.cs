using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proektna__prototip
{
    public partial class Controls : Form
    {
        GameMenu poc = null;
        NewGame ni = null;
        public int flag = 0;
        
        public Controls(GameMenu poc)
        {
            InitializeComponent();
            this.poc = poc;
            flag = 1;
        }
        public Controls(NewGame ni)
        {
            InitializeComponent();
            this.ni = ni;
            flag = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Kontroli_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Kontroli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 1)
            {
                poc.Show();
            }
            if (flag == 0)
            {
                ni.Enabled = true;
            }
        }
       
    }
}
