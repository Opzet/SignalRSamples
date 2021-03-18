using System;
using System.Drawing;
using System.Windows.Forms;

namespace Claucometa.TicTacToe
{
    internal partial class Form1 : Form
    {
        public Point StartLocation;

        public Form1()
        {
            InitializeComponent();
            StartLocation = gameArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameContext.Game = new GameScene();
            Reset();
        }

        private void Reset()
        {
            Controls.Remove(gameArea);
            gameArea = new GameArea(StartLocation);
            Controls.Add(gameArea);
        }
    }
}
