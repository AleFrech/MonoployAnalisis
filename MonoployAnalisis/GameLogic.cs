using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    public class GameLogic
    {
        private List<BoardObject> _boardSpaces;
        private Player _currentPlayer;
        private List<Player> _players;
        private bool gameOver = false;
        public GameLogic(List<Player> players )
        {
            _boardSpaces = new List<BoardObject>();
            _currentPlayer = players[0];
            _players = players;
        }

        public void NextTurn()
        {
            
           
       
                if (_currentPlayer == _players[0])
                {
                    _currentPlayer = _players[1];
                }
                else if (_currentPlayer == _players[1])
                {
                    _currentPlayer = _players[0];
                }
                
          
        }

        public void Move(bool isDouble,int totalMoves)
        {
            try
            {
                int position = _currentPlayer.CurrentPosition;
                position += totalMoves;
                if (position < _boardSpaces.Count)
                    _currentPlayer.SetCurrentPosition(position);
                else
                    _currentPlayer.SetCurrentPosition(0);

                if (_boardSpaces[_currentPlayer.CurrentPosition] is Property && ((Property)_boardSpaces[_currentPlayer.CurrentPosition]).Owner==null)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to buy " + _boardSpaces[_currentPlayer.CurrentPosition].GetName()+"?", "Buy Property", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                       _currentPlayer.PurchaseProperty((Property)_boardSpaces[_currentPlayer.CurrentPosition]);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                if (_currentPlayer.CurrentPosition == 30)
                {
                    ((Jail) _boardSpaces[10]).GoToJail(_currentPlayer);
                }
                if (_currentPlayer.CurrentPosition == 4)
                {
                    ((IncomeTax) _boardSpaces[4]).ChargeIncome(_currentPlayer);
                }
                if (_currentPlayer.CurrentPosition == 38)
                {
                    ((SuperTax)_boardSpaces[38]).ChargeSuper(_currentPlayer);
                }

                if (!isDouble)
                    NextTurn();
            }
            catch (InsufficientFundsException ex)
            {
                if (_currentPlayer == _players[0])
                {
                    MessageBox.Show(_players[1].Name + " Just won this game! ");
                }else if (_currentPlayer == _players[1])
                {
                    MessageBox.Show(_players[0].Name + " Just won this game! ");
                }
                gameOver = true;

            }
        }
        public List<BoardObject>GetBoardSpaces()
        {
            return _boardSpaces;
        }
        private void InitProperties()
        {
            _boardSpaces.Add(new Go());
            _boardSpaces.Add(new Property(Colors.Brown,2,new double[] {10,30,90,160},50 ,30 ,50 , "Mediterranean Ave.",60,250));
            _boardSpaces.Add(new BoardObject("Comunity Chest"));
            _boardSpaces.Add(new Property(Colors.Brown, 4, new double[] { 20, 60, 180,320 },50,30,50, "Baltic Ave.", 60,450));
            _boardSpaces.Add(new IncomeTax());
            _boardSpaces.Add(new BoardObject("Reading Train"));
            _boardSpaces.Add(new Property(Colors.Lightblue, 6, new double[] { 30, 90, 270, 400 }, 50,50,50, "Oriental Ave.", 100,550));
            _boardSpaces.Add(new BoardObject("Chance"));
            _boardSpaces.Add(new Property(Colors.Lightblue, 6, new double[] { 30, 90, 270, 400 },50,50,50, "Vermont Ave.", 100,550));
            _boardSpaces.Add(new Property(Colors.Lightblue, 8, new double[] { 40, 100, 300, 450 },50,60,50, "Connecticut Ave.", 120,600));
            _boardSpaces.Add(new Jail());
            _boardSpaces.Add(new Property(Colors.Pink, 10, new double[] { 50, 150, 450, 625},100,70,100, "St. Charles Place", 140,750));
            _boardSpaces.Add(new BoardObject("Electric Company"));
            _boardSpaces.Add(new Property(Colors.Pink, 10, new double[] { 50, 150, 450, 625 },100,70,100, "States Ave.", 140,750));
            _boardSpaces.Add(new Property(Colors.Pink, 12, new double[] { 60, 180, 500, 700 },100,80,100, "Virginia Ave.", 160,900));
            _boardSpaces.Add(new BoardObject("Pennsylvania Train"));
            _boardSpaces.Add(new Property(Colors.Orange, 14, new double[] { 70, 200, 550, 750 },100,90,100, "St. James Place", 180,950));
            _boardSpaces.Add(new BoardObject("Community Chest"));
            _boardSpaces.Add(new Property(Colors.Orange, 14, new double[] { 70, 200, 550, 750 }, 100, 90, 100, "Tennessee Ave.", 180, 950));
            _boardSpaces.Add(new Property(Colors.Orange, 16, new double[] {80, 220, 600, 800 }, 100, 100, 100, "New York Ave.", 180, 1000));
            _boardSpaces.Add(new BoardObject("Free Parking"));
            _boardSpaces.Add(new Property(Colors.Red, 18, new double[] { 90, 250, 700, 875 },150,110,150, "Kentucky Ave.", 220,1050));
            _boardSpaces.Add(new BoardObject("Chance"));
            _boardSpaces.Add(new Property(Colors.Red, 18, new double[] { 90, 250, 700, 875 }, 150, 110, 150, "Indiana Ave.", 220,1050));
            _boardSpaces.Add(new Property(Colors.Red, 20, new double[] { 100, 300, 750, 925 },150,120,150, "Illinois Ave.", 240,1100));
            _boardSpaces.Add(new BoardObject("B&O Train"));
            _boardSpaces.Add(new Property(Colors.Darkyellow, 22, new double[] { 110,330,800, 975 },150,130,150, "Atlantic Ave.", 260,1150));
            _boardSpaces.Add(new Property(Colors.Darkyellow, 22, new double[] { 110, 330, 800, 975 }, 150, 130, 150, "Ventnor Ave.", 260,1150));
            _boardSpaces.Add(new BoardObject("Water Service"));
            _boardSpaces.Add(new Property(Colors.Darkyellow, 24, new double[] { 120, 360, 850, 1025 }, 150, 140, 150, "Marvin Gardens", 280,1200));
            _boardSpaces.Add(new BoardObject("Go to Jail"));
            _boardSpaces.Add(new Property(Colors.Lightgreen, 26, new double[] { 130, 390,900,1100 },200,150,200, "Pacific Ave.", 300,1275));
            _boardSpaces.Add(new Property(Colors.Lightgreen, 26, new double[] { 130, 390,900,1100 },200,150,200, "North Carolina Ave.", 300,1275));
            _boardSpaces.Add(new BoardObject("Community Chest"));
            _boardSpaces.Add(new Property(Colors.Lightgreen, 28, new double[] { 150, 450, 1000, 1200 },200,160,200, "Pennsylvania Ave.", 320,1400));
            _boardSpaces.Add(new BoardObject("Short Line Train"));
            _boardSpaces.Add(new BoardObject("Chance"));
            _boardSpaces.Add(new Property(Colors.Darkblue, 35,new double[] { 175, 500, 1100, 1300 }, 200, 175, 200, "Park Place", 350,1500));
            _boardSpaces.Add(new SuperTax());
            _boardSpaces.Add(new Property(Colors.Darkblue, 50, new double[] { 200, 600, 1400, 1700 }, 200, 200, 200, "Boardwalk", 400,200));


        }
        public void Initgame( )
        {
            Bank.InitializeStartFunds(_players);
            InitProperties();

        }

        public Tuple<int, int> RollDiceValueTuple()
        {
            Random value = new Random();
            int diceValue1 = value.Next(1, 6);
            int diceValue2 = value.Next(1, 6);
            bool OutOfJail = true;
            if (((Jail) _boardSpaces[10]).PlayerIsInJail(_currentPlayer))
            {
               OutOfJail= ((Jail) _boardSpaces[10]).AttemptingToJail(diceValue1, diceValue2, _currentPlayer);
            }
            if (OutOfJail)
            {
                Move(diceValue1 == diceValue2, diceValue1 + diceValue2);
            }
            else
            {
                NextTurn();
            }
            if (gameOver)
            {
                return Tuple.Create(-1, -1);
            }
           
                return Tuple.Create(diceValue1, diceValue2);
         
        }

    }
}
