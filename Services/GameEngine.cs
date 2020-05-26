using System;

namespace BlazorIncremental
{
    public class GameEngine : IGameEngine
    {
        public void ProcessTime(GameState state, DateTime newTime)
        {
            var deltaT = newTime - state.LastTick;
            state.LastTick = newTime;
            state.Currency += (deltaT.Milliseconds / 1000.0) * state.CurrencyPerSecond;
        }
    }
}
