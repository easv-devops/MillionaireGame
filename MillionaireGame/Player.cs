using System;

namespace MillionaireGame
{
    public class Player
    {
        public int Balance { get; set; }
        public int LifelinesRemaining { get; set; } = 2;

        public void UseLifeline()
        {
            if (LifelinesRemaining > 0)
            {
                LifelinesRemaining--;
            }
        }
    }
}
