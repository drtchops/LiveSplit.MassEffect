using LiveSplit.Model;
using LiveSplit.TimeFormatters;
using LiveSplit.UI.Components;
using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;

namespace LiveSplit.MassEffect
{
    class MassEffectComponent : LogicComponent
    {
        public override string ComponentName
        {
            get { return "Mass Effect"; }
        }

        private TimerModel _timer;
        private GameMemory _gameMemory;

        public MassEffectComponent(LiveSplitState state)
        {
            _timer = new TimerModel { CurrentState = state };

            _gameMemory = new GameMemory();
            _gameMemory.OnLoadStarted += gameMemory_OnLoadStarted;
            _gameMemory.OnLoadFinished += gameMemory_OnLoadFinished;
            _gameMemory.StartMonitoring();
        }

        public override void Dispose()
        {
            if (_gameMemory != null)
            {
                _gameMemory.Stop();
            }

        }

        void gameMemory_OnLoadStarted(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = true;
        }

        void gameMemory_OnLoadFinished(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = false;
        }
    }
}
