using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoployAnalisis
{
    public partial class PickPiece : Form
    {

        private Player _player;
        public PickPiece(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        
        private void pieceP1_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Car);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Dedal);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Dog);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Hat);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Iron);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.Oldboot);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        { 
            _player.SetPiece(Player.PlayerPiece.Ship);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {

            _player.SetPiece(Player.PlayerPiece.WheelCart);
            _player.SetName(textBox1.Text);
            this.Close();
        }

        private void PickPiece_Load(object sender, EventArgs e)
        {

        }
    }
}
