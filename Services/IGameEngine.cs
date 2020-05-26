using System;

namespace BlazorIncremental
{
    public interface IGameEngine
    {
        void ProcessTime(GameState state, DateTime newTime);
    }
}
