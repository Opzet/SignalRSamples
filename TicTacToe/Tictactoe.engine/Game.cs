using System;

namespace claucometa.tictactoe.engine
{
    public class Game
    {
        public event EventHandler GameOver;
        public event EventHandler NextTurn;
        readonly TurnManager TurnManager = new TurnManager();

        public Game()
        {
            TurnManager.NextTurn += TurnManager_NextTurn;
        }

        public Players CurrentTurn => TurnManager.CurrentTurn;

        public Players TriggerPlayerTurn() => TurnManager.TriggerPlayerTurn;

        public void IsGameOver()
        {
            if (TurnManager.IsGameOver) GameOver?.Invoke(this, null);
        }

        private void TurnManager_NextTurn(object sender, EventArgs e)
        {
            NextTurn?.Invoke(sender, e);
        }
    }
}
