using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCounting
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            string player = "player1";


            Game game = new Game();
            game.Show();
            this.Hide();
            
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            string player = "player2";

            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void Player3_Click(object sender, EventArgs e)
        {
            string player = "player3";


            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void Player4_Click(object sender, EventArgs e)
        {
            string player = "player4";

            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            Player1.Visible = false;
            Player2.Visible = false;
            Player3.Visible = false;
            Player4.Visible = false;
        
        }

    
        private void Click(object sender, EventArgs e)
        {
            Player1.Visible = true;
            Player2.Visible = true;
            Player3.Visible = true;
            Player4.Visible = true;
        }




        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               Click(this, new EventArgs());
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DataRecieved(object sender, SimpleTCP.Message e)
        {
           
        }
    }
}
