using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameLogic gm = new GameLogic();
            Player player1 = new Player(Player.PlayerPiece.Car, "Carlos");
            Player player2 = new Player(Player.PlayerPiece.Dog, "Alejandro");
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);
            gm.Initgame(players);
            Label l = new Label();
            foreach (var p in players)
            {
                l.Text += (p.Funds);
                l.Text += " ";
            }
            Form1 f = new Form1();
            f.Controls.Add(l);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(f);
        
            //Console.ReadKey();
        }
    }
}
