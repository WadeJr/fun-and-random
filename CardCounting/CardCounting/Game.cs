using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCounting
{
    
    
    public partial class Game : Form
    {
     
        public string imgBase = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";

        public List<Card> GetCards()
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 53; i++)
            {
                cards.Add(new Card());
                switch(i)
                {
                    case 0:
                        cards[i].ammount = 2;
                        cards[i].image = Image.FromFile(imgBase + "2C.png");
                        break;

                    case 1:
                        cards[i].ammount = 3;
                        cards[i].image = Image.FromFile(imgBase + "3C.png");
                        break;

                    case 2:
                        cards[i].ammount = 4;
                        cards[i].image = Image.FromFile(imgBase + "4C.png");
                        break;

                    case 3:
                        cards[i].ammount = 5;
                        cards[i].image = Image.FromFile(imgBase + "5C.png");
                        break;

                    case 4:
                        cards[i].ammount = 6;
                        cards[i].image = Image.FromFile(imgBase + "6C.png");
                        break;

                    case 5:
                        cards[i].ammount = 7;
                        cards[i].image = Image.FromFile(imgBase + "7C.png");
                        break;

                    case 6:
                        cards[i].ammount = 8;
                        cards[i].image = Image.FromFile(imgBase + "8C.png");
                        break;

                    case 7:
                        cards[i].ammount = 9;
                        cards[i].image = Image.FromFile(imgBase + "9C.png");
                        break;

                    case 8:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "10C.png");
                        break;

                    case 9:
                        cards[i].ammount = 2;
                        cards[i].image = Image.FromFile(imgBase + "2D.png");
                        break;

                    case 10:
                        cards[i].ammount = 3;
                        cards[i].image = Image.FromFile(imgBase + "3D.png");
                        break;

                    case 11:
                        cards[i].ammount = 4;
                        cards[i].image = Image.FromFile(imgBase + "4D.png");
                        break;

                    case 12:
                        cards[i].ammount = 5;
                        cards[i].image = Image.FromFile(imgBase + "5D.png");
                        break;

                    case 13:
                        cards[i].ammount = 6;
                        cards[i].image = Image.FromFile(imgBase + "6D.png");
                        break;

                    case 14:
                        cards[i].ammount = 7;
                        cards[i].image = Image.FromFile(imgBase + "7D.png");
                        break;

                    case 15:
                        cards[i].ammount = 8;
                        cards[i].image = Image.FromFile(imgBase + "8D.png");
                        break;

                    case 16:
                        cards[i].ammount = 9;
                        cards[i].image = Image.FromFile(imgBase + "9D.png");
                        break;

                    case 17:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "10D.png");
                        break;

                    case 18:
                        cards[i].ammount = 2;
                        cards[i].image = Image.FromFile(imgBase + "2S.png");
                        break;

                    case 19:
                        cards[i].ammount = 3;
                        cards[i].image = Image.FromFile(imgBase + "3S.png");
                        break;

                    case 20:
                        cards[i].ammount = 4;
                        cards[i].image = Image.FromFile(imgBase + "4S.png");
                        break;

                    case 21:
                        cards[i].ammount = 5;
                        cards[i].image = Image.FromFile(imgBase + "5S.png");
                        break;

                    case 22:
                        cards[i].ammount = 6;
                        cards[i].image = Image.FromFile(imgBase + "6S.png");
                        break;

                    case 23:
                        cards[i].ammount = 7;
                        cards[i].image = Image.FromFile(imgBase + "7S.png");
                        break;

                    case 24:
                        cards[i].ammount = 8;
                        cards[i].image = Image.FromFile(imgBase + "8S.png");
                        break;

                    case 25:
                        cards[i].ammount = 9;
                        cards[i].image = Image.FromFile(imgBase + "9S.png");
                        break;

                    case 26:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "10S.png");
                        break;

                    case 27:
                        cards[i].ammount = 2;
                        cards[i].image = Image.FromFile(imgBase + "2H.png");
                        break;

                    case 28:
                        cards[i].ammount = 3;
                        cards[i].image = Image.FromFile(imgBase + "3H.png");
                        break;

                    case 29:
                        cards[i].ammount = 4;
                        cards[i].image = Image.FromFile(imgBase + "4H.png");
                        break;

                    case 30:
                        cards[i].ammount = 5;
                        cards[i].image = Image.FromFile(imgBase + "5H.png");
                        break;

                    case 31:
                        cards[i].ammount = 6;
                        cards[i].image = Image.FromFile(imgBase + "6H.png");
                        break;

                    case 32:
                        cards[i].ammount = 7;
                        cards[i].image = Image.FromFile(imgBase + "7H.png");
                        break;

                    case 33:
                        cards[i].ammount = 8;
                        cards[i].image = Image.FromFile(imgBase + "8H.png");
                        break;

                    case 34:
                        cards[i].ammount = 9;
                        cards[i].image = Image.FromFile(imgBase + "9H.png");
                        break;

                    case 35:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "10H.png");
                        break;

                    case 36:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "KH.png");
                        break;
                    case 37:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "QH.png");
                        break;

                    case 38:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "JH.png");
                        break;

                    case 39:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "KS.png");
                        break;

                    case 40:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "QS.png");
                        break;

                    case 41:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "JS.png");
                        break;

                    case 42:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "KD.png");
                        break;

                    case 43:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "QD.png");
                        break;

                    case 44:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "JD.png");
                        break;

                    case 45:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "KC.png");
                        break;
                    case 46:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "QC.png");
                        break;

                    case 47:
                        cards[i].ammount = 10;
                        cards[i].image = Image.FromFile(imgBase + "JC.png");
                        break;

                    case 48:
                        cards[i].ammount = 11;
                        cards[i].aceSecond = 1;
                        cards[i].image = Image.FromFile(imgBase + "AH.png");
                        break;

                    case 49:
                        cards[i].ammount = 11;
                        cards[i].aceSecond = 1;
                        cards[i].image = Image.FromFile(imgBase + "AS.png");
                        break;

                    case 50:
                        cards[i].ammount = 11;
                        cards[i].aceSecond = 1;
                        cards[i].image = Image.FromFile(imgBase + "AD.png");
                        break;

                    case 51:
                        cards[i].ammount = 11;
                        cards[i].aceSecond = 1;
                        cards[i].image = Image.FromFile(imgBase + "AC.png");
                        break;

                    case 52:
                        cards[i].ammount = 11;
                        cards[i].aceSecond = 1;
                        cards[i].image = Image.FromFile(imgBase + "blue_back.png");
                        break;
                }

            }
           
            return cards;    
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
        
                


            Player player = new Player();
            player.Hide();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            dealerImg.Image = Image.FromFile(imgBase + "dealer.jpg");
        }

    }
    public class Card
    {
        public int aceSecond;
        public int ammount;
        public Image image;

    }
}
