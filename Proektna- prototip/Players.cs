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
    public partial class Players : Form
    {
        GameMenu gameMenu = null;
       
        public Players(GameMenu gameMenu){
            InitializeComponent();
            this.gameMenu = gameMenu;
        }
       
        private void Players_FormClosed(object sender, FormClosedEventArgs e){gameMenu.Show();}
       
        private void cancelButton_Click(object sender, EventArgs e){gameMenu.Show(); this.Hide();}

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (tbPlayer1.Text == "" || tbPlayer2.Text == ""){
                MessageBox.Show("Player name(s) missing!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPlayer1.Text.Length > 10 || tbPlayer2.Text.Length > 10){
                MessageBox.Show("The name(s) are too long! Max characters is 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                this.Hide();
                NewGame newGame = new NewGame(this);
                newGame.Show();
                newGame.max =(int)numericUpDown1.Value; 
                newGame.labela1 = tbPlayer1.Text;
                newGame.labela2 = tbPlayer2.Text;
                newGame.i = newGame.max;
                newGame.j = newGame.max;
            }

        }

        private void Players_Load(object sender, EventArgs e)
        {

        }
    }
}
