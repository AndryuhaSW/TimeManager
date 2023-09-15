using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager
{
    public class TimeManager
    {
        public int WorkTime { get; set; }
        public int RestTime { get; set; }
        public TimerForm TimerForm { get; set; }

        private int _currentTimeSeconds;

        public TimeManager(int workTime, int restTime, TimerForm timerForm)
        {
            WorkTime = workTime;
            RestTime = restTime;
            TimerForm = timerForm;
        }

        public async Task Start()
        {
            while (true)
            {
                for (int i =0; i < WorkTime; i++)
                {
                    await Task.Delay(1000);
                    _currentTimeSeconds++;
                    TimerForm.UpdateTime(_currentTimeSeconds);
                }

                await TimerForm.NextState();

                _currentTimeSeconds = 0;
                TimerForm.UpdateTime(_currentTimeSeconds);

                for (int i = 0; i < RestTime; i++)
                {
                    await Task.Delay(1000);
                    _currentTimeSeconds++;
                    TimerForm.UpdateTime(_currentTimeSeconds);
                }

                await TimerForm.NextState();

                _currentTimeSeconds = 0;
                TimerForm.UpdateTime(_currentTimeSeconds);
            }
        }

    }
}
