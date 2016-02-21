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
        private GameLogic game;
        List<Player> players = new List<Player>();
        List<Tuple<int,int>> posListP1 = new List<Tuple<int, int>>
        {
            Tuple.Create( 619, 613), // 1) x,y GO 
            Tuple.Create( 552, 626), // 2) x,y MEDITERRANEAN AVENUE
            Tuple.Create( 496, 620),// 03) x,y COMUNITY CHEST
            Tuple.Create( 440, 626),// 04) x,y BALTIC AVENUE
            Tuple.Create( 387, 620),// 05) x,y INCOME TAX
            Tuple.Create( 330, 620),// 06) x,y READING RAILROAD
            Tuple.Create( 273, 627),// 07) x,y ORIENTAL AVENUE
            Tuple.Create( 221, 620),// 08) x,y CHANCE
            Tuple.Create( 162, 627),// 09) x,y VERMONT AVENUE
            Tuple.Create( 105, 628),// 10) x,y CONNECTICUT AVENUE
            Tuple.Create(  39, 605),// 11) x,y IN JAIL
            Tuple.Create(  12, 625),// 12) x,y OUT JAIL
            Tuple.Create(  47, 551),// 13) x,y ST. CHARLES PLACE
            Tuple.Create(  52, 496),// 14) x,y ELECTRIC COMPANY
            Tuple.Create(  47, 439),// 15) x,y STATES AVENUE
            Tuple.Create(  48, 384),// 16) x,y VIRGINIA AVENUE
            Tuple.Create(  56, 330),// 17) x,y PENNSYLVANIA RAILROAD
            Tuple.Create(  46, 272),// 18) x,y ST. JAMES PLACE
            Tuple.Create(  56, 217),// 19) x,y COMMUNITY CHEST
            Tuple.Create(  47, 161),// 20) x,y TENNESSEE AVENUE
            Tuple.Create(  46, 105),// 21) x,y NEW YORK AVENUE
            Tuple.Create(  60,  22),// 22) x,y FREE PARKING
            Tuple.Create( 124,  15),// 23) x,y KENTUCKY AVENUE
            Tuple.Create( 178,  21),// 24) x,y CHANCE
            Tuple.Create( 235,  15),// 25) x,y INDIANA AVENUE
            Tuple.Create( 290,  15),// 26) x,y ILLINOIS AVENUE
            Tuple.Create( 348,  23),// 27) x,y B & O RAILROAD
            Tuple.Create( 404,  15),// 28) x,y ATLANTIC AVENUE
            Tuple.Create( 458,  15),// 29) x,y VENTNOR AVENUE
            Tuple.Create( 515,  24),// 30) x,y WATER WORKS
            Tuple.Create( 640,  28),// 31) x,y MARVIN GARDENS
            Tuple.Create( 618, 52),// 32) x,y GO TO JAIL
            Tuple.Create( 626, 125),// 33) x,y PACIFIC AVENUE
            Tuple.Create( 626, 181),// 34) x,y NORTH CAROLINA AVENUE
            Tuple.Create( 626, 236),// 35) x,y COMMUNITY CHEST
            Tuple.Create( 626, 291),// 36) x,y PENNSYLVANIA RAILROAD
            Tuple.Create( 626, 347),// 37) x,y SHORT LINE
            Tuple.Create( 626, 403),// 38) x,y CHANCE
            Tuple.Create( 626, 460),// 39) x,y PARK PLACE
            Tuple.Create( 626, 515),// 40) x,y LUXURY TAX
            Tuple.Create( 626, 571),// 41) x,y BOARDWALK
        };


      

        List<Tuple<int, int>> posListP2 = new List<Tuple<int, int>>
        {
            Tuple.Create( 635, 646), // 1) x,y GO 
            Tuple.Create( 568, 659), // 2) x,y MEDITERRANEAN AVENUE
            Tuple.Create( 512, 653),// 03) x,y COMUNITY CHEST
            Tuple.Create( 456, 659),// 04) x,y BALTIC AVENUE
            Tuple.Create( 403, 653),// 05) x,y INCOME TAX
            Tuple.Create( 346, 653),// 06) x,y READING RAILROAD
            Tuple.Create( 289, 660),// 07) x,y ORIENTAL AVENUE
            Tuple.Create( 237, 653),// 08) x,y CHANCE
            Tuple.Create( 178, 660),// 09) x,y VERMONT AVENUE
            Tuple.Create( 121, 661),// 10) x,y CONNECTICUT AVENUE
            Tuple.Create(  68, 635),// 11) x,y IN JAIL
            Tuple.Create(  54, 662),// 12) x,y OUT JAIL
            Tuple.Create(  16, 569),// 13) x,y ST. CHARLES PLACE
            Tuple.Create(  21, 514),// 14) x,y ELECTRIC COMPANY
            Tuple.Create(  16, 457),// 15) x,y STATES AVENUE
            Tuple.Create(  17, 402),// 16) x,y VIRGINIA AVENUE
            Tuple.Create(  25, 348),// 17) x,y PENNSYLVANIA RAILROAD
            Tuple.Create(  15, 290),// 18) x,y ST. JAMES PLACE
            Tuple.Create(  25, 235),// 19) x,y COMMUNITY CHEST
            Tuple.Create(  16, 179),// 20) x,y TENNESSEE AVENUE
            Tuple.Create(  15, 123),// 21) x,y NEW YORK AVENUE
            Tuple.Create(  26,  61),// 22) x,y FREE PARKING
            Tuple.Create( 105,  48),// 23) x,y KENTUCKY AVENUE
            Tuple.Create( 159,  54),// 24) x,y CHANCE
            Tuple.Create( 216,  48),// 25) x,y INDIANA AVENUE
            Tuple.Create( 271,  48),// 26) x,y ILLINOIS AVENUE
            Tuple.Create( 329,  56),// 27) x,y B & O RAILROAD
            Tuple.Create( 385,  48),// 28) x,y ATLANTIC AVENUE
            Tuple.Create( 439,  48),// 29) x,y VENTNOR AVENUE
            Tuple.Create( 496,  57),// 30) x,y WATER WORKS
            Tuple.Create( 551,  49),// 31) x,y MARVIN GARDENS
            Tuple.Create( 654,  22),// 32) x,y GO TO JAIL
            Tuple.Create( 658, 104),// 33) x,y PACIFIC AVENUE
            Tuple.Create( 658, 160),// 34) x,y NORTH CAROLINA AVENUE
            Tuple.Create( 658, 215),// 35) x,y COMMUNITY CHEST
            Tuple.Create( 658, 270),// 36) x,y PENNSYLVANIA RAILROAD
            Tuple.Create( 658, 326),// 37) x,y SHORT LINE
            Tuple.Create( 658, 382),// 38) x,y CHANCE
            Tuple.Create( 658, 439),// 39) x,y PARK PLACE
            Tuple.Create( 658, 494),// 40) x,y LUXURY TAX
            Tuple.Create( 658, 550),// 41) x,y BOARDWALK

        };


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
