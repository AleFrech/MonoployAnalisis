using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MonoployAnalisis
{ 
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.board = new System.Windows.Forms.PictureBox();
            this.nameP1 = new System.Windows.Forms.Label();
            this.propertiesP1 = new System.Windows.Forms.ComboBox();
            this.pieceP1 = new System.Windows.Forms.PictureBox();
            this.fundsP1 = new System.Windows.Forms.Label();
            this.panelP1 = new System.Windows.Forms.Panel();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.rollDice = new System.Windows.Forms.Button();
            this.panelP2 = new System.Windows.Forms.Panel();
            this.propertiesP2 = new System.Windows.Forms.ComboBox();
            this.pieceP2 = new System.Windows.Forms.PictureBox();
            this.fundsP2 = new System.Windows.Forms.Label();
            this.nameP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceP1)).BeginInit();
            this.panelP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            this.panelP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceP2)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Image = global::MonoployAnalisis.Properties.Resources.board;
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(680, 680);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            this.board.Click += new System.EventHandler(this.board_Click);
            // 
            // nameP1
            // 
            this.nameP1.AutoSize = true;
            this.nameP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameP1.Location = new System.Drawing.Point(15, 9);
            this.nameP1.Name = "nameP1";
            this.nameP1.Size = new System.Drawing.Size(78, 25);
            this.nameP1.TabIndex = 1;
            this.nameP1.Text = "Player1";
            // 
            // propertiesP1
            // 
            this.propertiesP1.FormattingEnabled = true;
            this.propertiesP1.Location = new System.Drawing.Point(17, 37);
            this.propertiesP1.Name = "propertiesP1";
            this.propertiesP1.Size = new System.Drawing.Size(121, 21);
            this.propertiesP1.TabIndex = 2;
            // 
            // pieceP1
            // 
            this.pieceP1.Location = new System.Drawing.Point(17, 64);
            this.pieceP1.Name = "pieceP1";
            this.pieceP1.Size = new System.Drawing.Size(76, 69);
            this.pieceP1.TabIndex = 3;
            this.pieceP1.TabStop = false;
            // 
            // fundsP1
            // 
            this.fundsP1.AutoSize = true;
            this.fundsP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsP1.ForeColor = System.Drawing.Color.Lime;
            this.fundsP1.Location = new System.Drawing.Point(99, 93);
            this.fundsP1.Name = "fundsP1";
            this.fundsP1.Size = new System.Drawing.Size(102, 31);
            this.fundsP1.TabIndex = 4;
            this.fundsP1.Text = "$ 1000";
            this.fundsP1.Click += new System.EventHandler(this.fundsP1_Click);
            // 
            // panelP1
            // 
            this.panelP1.Controls.Add(this.propertiesP1);
            this.panelP1.Controls.Add(this.nameP1);
            this.panelP1.Controls.Add(this.pieceP1);
            this.panelP1.Controls.Add(this.fundsP1);
            this.panelP1.Location = new System.Drawing.Point(783, 546);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(223, 146);
            this.panelP1.TabIndex = 9;
            this.panelP1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelP1.BorderStyle = BorderStyle.FixedSingle;
            // 
            // dice1
            // 
            this.dice1.Image = ((System.Drawing.Image)(resources.GetObject("dice1.Image")));
            this.dice1.Location = new System.Drawing.Point(920, 458);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(86, 82);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice1.TabIndex = 11;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Image = global::MonoployAnalisis.Properties.Resources.r1;
            this.dice2.Location = new System.Drawing.Point(1058, 458);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(86, 82);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice2.TabIndex = 12;
            this.dice2.TabStop = false;
            // 
            // rollDice
            // 
            this.rollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDice.Location = new System.Drawing.Point(969, 399);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(122, 53);
            this.rollDice.TabIndex = 13;
            this.rollDice.Text = "Roll Dice!";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // panelP2
            // 
            this.panelP2.Controls.Add(this.nameP2);
            this.panelP2.Controls.Add(this.propertiesP2);
            this.panelP2.Controls.Add(this.pieceP2);
            this.panelP2.Controls.Add(this.fundsP2);
            this.panelP2.Location = new System.Drawing.Point(1058, 546);
            this.panelP2.Name = "panelP2";
            this.panelP2.Size = new System.Drawing.Size(223, 146);
            this.panelP2.TabIndex = 10;
            this.panelP2.BorderStyle = BorderStyle.FixedSingle;
            // 
            // propertiesP2
            // 
            this.propertiesP2.FormattingEnabled = true;
            this.propertiesP2.Location = new System.Drawing.Point(17, 37);
            this.propertiesP2.Name = "propertiesP2";
            this.propertiesP2.Size = new System.Drawing.Size(121, 21);
            this.propertiesP2.TabIndex = 2;
            // 
            // pieceP2
            // 
            this.pieceP2.Location = new System.Drawing.Point(17, 64);
            this.pieceP2.Name = "pieceP2";
            this.pieceP2.Size = new System.Drawing.Size(76, 69);
            this.pieceP2.TabIndex = 3;
            this.pieceP2.TabStop = false;
            // 
            // fundsP2
            // 
            this.fundsP2.AutoSize = true;
            this.fundsP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsP2.ForeColor = System.Drawing.Color.Lime;
            this.fundsP2.Location = new System.Drawing.Point(99, 93);
            this.fundsP2.Name = "fundsP2";
            this.fundsP2.Size = new System.Drawing.Size(102, 31);
            this.fundsP2.TabIndex = 4;
            this.fundsP2.Text = "$ 1000";
            // 
            // nameP2
            // 
            this.nameP2.AutoSize = true;
            this.nameP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameP2.Location = new System.Drawing.Point(15, 9);
            this.nameP2.Name = "nameP2";
            this.nameP2.Size = new System.Drawing.Size(78, 25);
            this.nameP2.TabIndex = 5;
            this.nameP2.Text = "Player2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.panelP2);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.panelP1);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Monopoly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceP1)).EndInit();
            this.panelP1.ResumeLayout(false);
            this.panelP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            this.panelP2.ResumeLayout(false);
            this.panelP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceP2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBox board;
        private Label fundsP1;
        private Panel panelP1;
        private PictureBox pieceP1;
        private ComboBox propertiesP1;
        private Label nameP1;
        private PictureBox dice1;
        private PictureBox dice2;
        private Button rollDice;
        private Panel panelP2;
        private Label nameP2;
        private ComboBox propertiesP2;
        private PictureBox pieceP2;
        private Label fundsP2;
    }
}

