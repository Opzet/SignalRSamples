using claucometa.tictactoe.engine;
using System.Windows.Forms;

namespace Claucometa.TicTacToe
{
    public partial class Square : UserControl
    {
        public Square()
        {
            InitializeComponent();
        }

        private void Square_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseUp -= new MouseEventHandler(this.Square_MouseUp);

            GameContext.Game.TriggerPlayerTurn();

            if (GameContext.Game.CurrentTurn == Players.PlayerO)
            {
                var mark = GameContext.Game.Mark.TakeO;
                Controls.Add(mark);
            }
            
            if (GameContext.Game.CurrentTurn == Players.PlayerX)
            {
                var mark = GameContext.Game.Mark.TakeX;
                Controls.Add(mark);
            }

            GameContext.Game.IsGameOver();
        }
    }
}
