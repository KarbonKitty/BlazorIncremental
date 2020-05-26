using System;
using System.Timers;
using Microsoft.AspNetCore.Components;

namespace BlazorIncremental.Components
{
    public class GameBase : ComponentBase
    {
        [Inject] protected GameEngine Engine { get; set; }
        protected GameState state;
        protected Timer gameTimer;

        protected override void OnInitialized()
        {
            state = new GameState
            {
                LastTick = DateTime.Now
            };
            gameTimer = new Timer
            {
                Interval = 50
            };
            gameTimer.Elapsed += LoopStep;
            gameTimer.Start();
        }

        private void LoopStep(object sender, ElapsedEventArgs e)
        {
            Engine.ProcessTime(state, e.SignalTime);
            this.StateHasChanged();
        }
    }
}
