using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MonoployAnalisis.Properties;
using System.Collections.Generic;

namespace MonoployAnalisis
{
    public partial class Form1 : Form
    {

        List<Tuple<int,int>> tupleList = new List<Tuple<int, int>>
        {
            Tuple.Create( 1, 2),
            Tuple.Create( 5, 3),
            Tuple.Create( 1, 3)
        };

        private GameLogic game;
        List<Player> players = new List<Player>();
        public Form1()
        {
            InitializeComponent();


        
            Player p1 = new Player();
            PickPiece pickPiece = new PickPiece(p1);
            pickPiece.ShowDialog();
            players.Add(p1);
            nameP1.Text = players[0].Name;
            Player p2 = new Player();
            PickPiece pickPiece2 = new PickPiece(p2);
            pickPiece2.ShowDialog();
            players.Add(p2);
            nameP2.Text = players[1].Name;
            pickPlayerPiece((int)players[0].Piece + 1, (int)players[1].Piece + 1);

            game = new GameLogic(players);
            game.Initgame();
            players[0].PurchaseProperty((Property)game.GetBoardSpaces()[3]);

        }

       



        private void ShowProperties(Player player,ComboBox playerProperties)
        {

            foreach (var properties in player.GetOwnedProperties)
            {
                playerProperties.Items.Add(properties.GetName());

            }
            if(playerProperties.Items.Count>0)
            playerProperties.SelectedIndex = 0;

        }

        private void RefreshFunds()
        {
            fundsP1.Text = "";
            fundsP2.Text = "";
            fundsP1.Text = "$" + players[0].Funds;
            fundsP2.Text = "$" + players[1].Funds;
        }
        private void GetFunds(Player player,Label funds)
        {
            funds.Text += player.Funds;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

           ShowProperties(players[0],propertiesP1);
           ShowProperties(players[1], propertiesP2);
            GetFunds(players[0], fundsP1);
            GetFunds(players[1], fundsP2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void board_Click(object sender, EventArgs e)
        {

        }


        private void pickPlayerPiece(int getPieceP1, int getPieceP2)
        {
            

            switch (getPieceP1)
            {
                case 1:
                    pieceP1.Image = Resources.classicCar;
                    break;
                case 2:
                    pieceP1.Image = Resources.dedal;
                    break;
                case 3:
                    pieceP1.Image = Resources.fancyDog;
                    break;
                case 4:
                    pieceP1.Image = Resources.fancyHat;
                    break;
                case 5:
                    pieceP1.Image = Resources.iron;
                    break;
                case 6:
                    pieceP1.Image = Resources.oldBoot;
                    break;
                case 7:
                    pieceP1.Image = Resources.ship;
                    break;
                case 8:
                    pieceP1.Image = Resources.wheelBarrow;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;
            }



            switch (getPieceP2)
            {
                case 1:
                    pieceP2.Image = Resources.classicCar;
                    break;
                case 2:
                    pieceP2.Image = Resources.dedal;
                    break;
                case 3:
                    pieceP2.Image = Resources.fancyDog;
                    break;
                case 4:
                    pieceP2.Image = Resources.fancyHat;
                    break;
                case 5:
                    pieceP2.Image = Resources.iron;
                    break;
                case 6:
                    pieceP2.Image = Resources.oldBoot;
                    break;
                case 7:
                    pieceP2.Image = Resources.ship;
                    break;
                case 8:
                    pieceP2.Image = Resources.wheelBarrow;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;
            }
        }


     
       
        private void rollDice_Click(object sender, EventArgs e)
        {
            var dices = game.RollDiceValueTuple();
            if (dices.Item1 == -1 && dices.Item2 == -1)
                this.Close();
            int diceImage1 = dices.Item1;
            int diceImage2 = dices.Item2;


           
            System.Diagnostics.Debug.WriteLine("value 1:" + diceImage1);
            System.Diagnostics.Debug.WriteLine("value 2:" + diceImage2);

            switch (diceImage1)
            {
                case 1:
                    dice1.Image = Resources.p1;
                    break;
                case 2:
                    dice1.Image = Resources.p2;
                    break;
                case 3:
                    dice1.Image = Resources.p3;
                    break;
                case 4:
                    dice1.Image = Resources.p4;
                    break;
                case 5:
                    dice1.Image = Resources.p5;
                    break;
                case 6:
                    dice1.Image = Resources.p6;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;

            }


            switch (diceImage2)
            {
                case 1:
                    dice2.Image = Resources.r1;
                    break;
                case 2:
                    dice2.Image = Resources.r2;
                    break;
                case 3:
                    dice2.Image = Resources.r3;
                    break;
                case 4:
                    dice2.Image = Resources.r4;
                    break;
                case 5:
                    dice2.Image = Resources.r5;
                    break;
                case 6:
                    dice2.Image = Resources.r6;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;

            }
            RefreshFunds();
            
        }




        private void fundsP1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
