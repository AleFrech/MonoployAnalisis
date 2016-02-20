using System;
using System.Threading;
using System.Windows.Forms;
using MonoployAnalisis.Properties;
using System.Collections.Generic;

namespace MonoployAnalisis
{
    public partial class Form1 : Form
    {
        private GameLogic game;
        List<Player> players = new List<Player>();
        public Form1()
        {
            InitializeComponent();
            Player player1 = new Player(Player.PlayerPiece.Car,"Carlos");
            Player player2 = new Player(Player.PlayerPiece.Dog, "Alejandro");
            players.Add(player1);
            players.Add(player2);
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

       
        private void rollDice_Click(object sender, EventArgs e)
        {
            var dices = game.RollDiceValueTuple();
            int diceImage1 = dices.Item1;
            int diceImage2 = dices.Item2;

            System.Diagnostics.Debug.WriteLine("value 1:" + diceImage1);
            System.Diagnostics.Debug.WriteLine("value 2:" + diceImage2);

            switch (diceImage1)
            {
                case 1:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p1;
                    break;
                case 2:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p2;
                    break;
                case 3:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p3;
                    break;
                case 4:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p4;
                    break;
                case 5:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p5;
                    break;
                case 6:
                    dice1.Image = global::MonoployAnalisis.Properties.Resources.p6;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;

            }


            switch (diceImage2)
            {
                case 1:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r1;
                    break;
                case 2:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r2;
                    break;
                case 3:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r3;
                    break;
                case 4:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r4;
                    break;
                case 5:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r5;
                    break;
                case 6:
                    dice2.Image = global::MonoployAnalisis.Properties.Resources.r6;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;

            }
        }

        private void fundsP1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
