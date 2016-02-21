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
        #region  Position tuples

        private GameLogic game;
        List<Player> players = new List<Player>();

        private List<Tuple<int, int>> posListP1 = new List<Tuple<int, int>>
        {
            Tuple.Create(619, 613), // 00) x,y GO 
            Tuple.Create(552, 626), // 01) x,y MEDITERRANEAN AVENUE
            Tuple.Create(496, 620), // 02) x,y COMUNITY CHEST
            Tuple.Create(440, 626), // 03) x,y BALTIC AVENUE
            Tuple.Create(387, 620), // 04) x,y INCOME TAX
            Tuple.Create(330, 620), // 05) x,y READING RAILROAD
            Tuple.Create(273, 627), // 06) x,y ORIENTAL AVENUE
            Tuple.Create(221, 620), // 07) x,y CHANCE
            Tuple.Create(162, 627), // 08) x,y VERMONT AVENUE
            Tuple.Create(105, 628), // 09) x,y CONNECTICUT AVENUE
            Tuple.Create( 12, 625), // 10) x,y OUT JAIL
            Tuple.Create( 47, 551), // 11) x,y ST. CHARLES PLACE
            Tuple.Create( 52, 496), // 12) x,y ELECTRIC COMPANY
            Tuple.Create( 47, 439), // 13) x,y STATES AVENUE
            Tuple.Create( 48, 384), // 14) x,y VIRGINIA AVENUE
            Tuple.Create( 56, 330), // 15) x,y PENNSYLVANIA RAILROAD
            Tuple.Create( 46, 272), // 16) x,y ST. JAMES PLACE
            Tuple.Create( 56, 217), // 17) x,y COMMUNITY CHEST
            Tuple.Create( 47, 161), // 18) x,y TENNESSEE AVENUE
            Tuple.Create( 46, 105), // 19) x,y NEW YORK AVENUE
            Tuple.Create( 60,  22), // 20) x,y FREE PARKING
            Tuple.Create(124,  15), // 21) x,y KENTUCKY AVENUE
            Tuple.Create(178,  21), // 22) x,y CHANCE
            Tuple.Create(235,  15), // 23) x,y INDIANA AVENUE
            Tuple.Create(290,  15), // 24) x,y ILLINOIS AVENUE
            Tuple.Create(348,  23), // 25) x,y B & O RAILROAD
            Tuple.Create(404,  15), // 26) x,y ATLANTIC AVENUE
            Tuple.Create(458,  15), // 27) x,y VENTNOR AVENUE
            Tuple.Create(515,  24), // 28) x,y WATER WORKS
            Tuple.Create(640,  28), // 29) x,y MARVIN GARDENS
            Tuple.Create(618,  52), // 30) x,y GO TO JAIL
            Tuple.Create(626, 125), // 31) x,y PACIFIC AVENUE
            Tuple.Create(626, 181), // 32) x,y NORTH CAROLINA AVENUE
            Tuple.Create(626, 236), // 33) x,y COMMUNITY CHEST
            Tuple.Create(626, 291), // 34) x,y PENNSYLVANIA RAILROAD
            Tuple.Create(626, 347), // 35) x,y SHORT LINE
            Tuple.Create(626, 403), // 36) x,y CHANCE
            Tuple.Create(626, 460), // 37) x,y PARK PLACE
            Tuple.Create(626, 515), // 48) x,y LUXURY TAX
            Tuple.Create(626, 571), // 49) x,y BOARDWALK
            Tuple.Create( 39, 605)  // 40) x,y IN JAIL
        };
      

        List<Tuple<int, int>> posListP2 = new List<Tuple<int, int>>
        {
            Tuple.Create(635, 646), // 00) x,y GO 
            Tuple.Create(568, 659), // 01) x,y MEDITERRANEAN AVENUE
            Tuple.Create(512, 653), // 02) x,y COMUNITY CHEST
            Tuple.Create(456, 659), // 03) x,y BALTIC AVENUE
            Tuple.Create(403, 653), // 04) x,y INCOME TAX
            Tuple.Create(346, 653), // 05) x,y READING RAILROAD
            Tuple.Create(289, 660), // 06) x,y ORIENTAL AVENUE
            Tuple.Create(237, 653), // 07) x,y CHANCE
            Tuple.Create(178, 660), // 08) x,y VERMONT AVENUE
            Tuple.Create(121, 661), // 09) x,y CONNECTICUT AVENUE
            Tuple.Create( 54, 662), // 10) x,y OUT JAIL
            Tuple.Create( 16, 569), // 11) x,y ST. CHARLES PLACE
            Tuple.Create( 21, 514), // 12) x,y ELECTRIC COMPANY
            Tuple.Create( 16, 457), // 13) x,y STATES AVENUE
            Tuple.Create( 17, 402), // 14) x,y VIRGINIA AVENUE
            Tuple.Create( 25, 348), // 15) x,y PENNSYLVANIA RAILROAD
            Tuple.Create( 15, 290), // 16) x,y ST. JAMES PLACE
            Tuple.Create( 25, 235), // 17) x,y COMMUNITY CHEST
            Tuple.Create( 16, 179), // 18) x,y TENNESSEE AVENUE
            Tuple.Create( 15, 123), // 19) x,y NEW YORK AVENUE
            Tuple.Create( 26,  61), // 20) x,y FREE PARKING
            Tuple.Create(105,  48), // 21) x,y KENTUCKY AVENUE
            Tuple.Create(159,  54), // 22) x,y CHANCE
            Tuple.Create(216,  48), // 23) x,y INDIANA AVENUE
            Tuple.Create(271,  48), // 24) x,y ILLINOIS AVENUE
            Tuple.Create(329,  56), // 25) x,y B & O RAILROAD
            Tuple.Create(385,  48), // 26) x,y ATLANTIC AVENUE
            Tuple.Create(439,  48), // 27) x,y VENTNOR AVENUE
            Tuple.Create(496,  57), // 28) x,y WATER WORKS
            Tuple.Create(551,  49), // 29) x,y MARVIN GARDENS
            Tuple.Create(654,  22), // 30) x,y GO TO JAIL
            Tuple.Create(658, 104), // 31) x,y PACIFIC AVENUE
            Tuple.Create(658, 160), // 32) x,y NORTH CAROLINA AVENUE
            Tuple.Create(658, 215), // 33) x,y COMMUNITY CHEST
            Tuple.Create(658, 270), // 34) x,y PENNSYLVANIA RAILROAD
            Tuple.Create(658, 326), // 35) x,y SHORT LINE
            Tuple.Create(658, 382), // 36) x,y CHANCE
            Tuple.Create(658, 439), // 37) x,y PARK PLACE
            Tuple.Create(658, 494), // 38) x,y LUXURY TAX
            Tuple.Create(658, 550), // 39) x,y BOARDWALK
            Tuple.Create( 68, 635)  // 40) x,y IN JAIL

        };
    #endregion
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
          

        }
        private void ShowProperties(Player player,ComboBox playerProperties)
        {
            playerProperties.Items.Clear();

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
        private void pickPlayerPiece(int getPieceP1, int getPieceP2)
        {
            

            switch (getPieceP1)
            {
                case 1:
                    pieceP1.Image = Resources.classicCar;
                    boardPiece1.Image = Resources.classicCar;
                    break;
                case 2:
                    pieceP1.Image = Resources.dedal;
                    boardPiece1.Image = Resources.dedal;
                    break;
                case 3:
                    pieceP1.Image = Resources.fancyDog;
                    boardPiece1.Image = Resources.fancyDog;
                    break;
                case 4:
                    pieceP1.Image = Resources.fancyHat;
                    boardPiece1.Image = Resources.fancyHat;
                    break;
                case 5:
                    pieceP1.Image = Resources.iron;
                    boardPiece1.Image = Resources.iron;
                    break;
                case 6:
                    pieceP1.Image = Resources.oldBoot;
                    boardPiece1.Image = Resources.oldBoot;
                    break;
                case 7:
                    pieceP1.Image = Resources.ship;
                    boardPiece1.Image = Resources.ship;
                    break;
                case 8:
                    pieceP1.Image = Resources.wheelBarrow;
                    boardPiece1.Image = Resources.wheelBarrow;
                    break;
                default:
                    Console.WriteLine("No pos guau...");
                    break;
            }



            switch (getPieceP2)
            {
                case 1:
                    pieceP2.Image = Resources.classicCar;
                    boardPiece2.Image = Resources.classicCar;
                    break;
                case 2:
                    pieceP2.Image = Resources.dedal;
                    boardPiece2.Image = Resources.dedal;
                    break;
                case 3:
                    pieceP2.Image = Resources.fancyDog;
                    boardPiece2.Image = Resources.fancyDog;
                    break;
                case 4:
                    pieceP2.Image = Resources.fancyHat;
                    boardPiece2.Image = Resources.fancyHat;
                    break;
                case 5:
                    pieceP2.Image = Resources.iron;
                    boardPiece2.Image = Resources.iron;
                    break;
                case 6:
                    pieceP2.Image = Resources.oldBoot;
                    boardPiece2.Image = Resources.oldBoot;
                    break;
                case 7:
                    pieceP2.Image = Resources.ship;
                    boardPiece2.Image = Resources.ship;
                    break;
                case 8:
                    pieceP2.Image = Resources.wheelBarrow;
                    boardPiece2.Image = Resources.wheelBarrow;
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

            RollingDice(diceImage1, diceImage2);
        }
        private void RollingDice(int diceImage1, int diceImage2)
        {
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
            ShowProperties(players[0],propertiesP1);
            ShowProperties(players[1], propertiesP2);
            MovePlayerInBoard(players[0], players[1]);
        }
        public void MovePlayerInBoard(Player player1, Player player2)
        {
            int posPlayer1 = player1.CurrentPosition;
            int posPlayer2 = player2.CurrentPosition;

            Tuple<int, int> posValuesP1 = posListP1[posPlayer1];
            Tuple<int, int> posValuesP2 = posListP1[posPlayer2];

            if (posPlayer1 == 30)
            {
                posValuesP1 = posListP1[40];
            }

            if (posPlayer2 == 30)
            {
                posValuesP2 = posListP2[40];
            }


            int player1X = posValuesP1.Item1;
            int player1Y = posValuesP1.Item2;

            int player2X = posValuesP2.Item1;
            int player2Y = posValuesP2.Item2;

            if (player1 == players[0] )
            {
                this.boardPiece1.Location = new System.Drawing.Point(player1X, player1Y);
            }
            else if (player2 == players[1])
            {
                this.boardPiece2.Location = new System.Drawing.Point(player2X, player2Y);
            }
            
        }
    }
}
