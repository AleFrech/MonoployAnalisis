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
        public Form1()
        {
            InitializeComponent();
           game  = new GameLogic();
            Player player1 = new Player(Player.PlayerPiece.Car,"Carlos");
            Player player2 = new Player(Player.PlayerPiece.Dog, "Alejandro");
            var players = new List<Player>();
            players.Add(player1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void board_Click(object sender, EventArgs e)
        {

        }

       
        private void rollDice_Click(object sender, EventArgs e)
        {
            int diceImage1 = game.RollDiceValueTuple().Item1;
            int diceImage2 = game.RollDiceValueTuple().Item2;

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
