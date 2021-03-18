using claucometa.tictactoe.engine;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Claucometa.TicTacToe
{
    public partial class GameArea : UserControl
    {
        public GameArea(Point initial) : this()
        {
            Location = initial;
        }

        public GameArea()
        {
            InitializeComponent();
            label2.Text = GetMark;
            GameContext.Game.GameOver += Context_GameOver;
            GameContext.Game.NextTurn += Game_NextTurn;
        }

        private void Game_NextTurn(object sender, EventArgs e)
        {
            label2.Text = GetMark;
        }

        private static string GetMark =>
            GameContext.Game.CurrentTurn == Players.PlayerO ? 
                "X" : "O";

        private void Context_GameOver(object sender, EventArgs e)
        {
            label1.Visible = true;
        }            
    }
}
