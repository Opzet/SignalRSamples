using System;

namespace claucometa.tictactoe.engine
{
    internal class TurnManager
    {
        public event EventHandler NextTurn;
        public const int TotalTurns = 9;
        int player = (int)Players.PlayerO;
        int index = 0;
        public int Index { get { return index; } }
        public bool IsGameOver => Index == TotalTurns;
        public Players CurrentTurn => (Players)player;
        public Players TriggerPlayerTurn
        {
            get
            {
                index++;
                player++;
                player %= 2;
                NextTurn?.Invoke(this, new EventArgs());
                return (Players) player;
            }
        }
    }
}
