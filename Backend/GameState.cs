using System;

namespace BlazorIncremental
{
    public class GameState
    {
        public DateTime LastTick;
        public double Currency = 0;
        public double CurrencyPerSecond = 5;
    }
}
