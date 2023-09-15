using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager
{
    public partial class TimerForm : Form
    {
        public TimerForm(int workTime, int restTime)
        {
            InitializeComponent();

            //movw window to upper right cornor
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            this.Left = screenWidth - this.Width;
            this.Top = 0;

            //start timer
            TimeManager timeManager = new TimeManager(workTime, restTime, this);
            timeManager.Start().GetAwaiter();
        }



        //=====================
        //close window
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //=====================


        //=====================
        //next state
        private void NextButton_Click(object sender, EventArgs e)
        {
            ReadyNestState = true;
        }

        private bool ReadyNestState = false;

        public async Task NextState()
        {
            NextButton.Visible = true;
            while (!ReadyNestState)
            {
                SystemSounds.Exclamation.Play();
                await Task.Delay(400);
            }
            ReadyNestState = false;

            if (StateName.Text == "Work")
                StateName.Text = "Rest";
            else
                StateName.Text = "Work";
        }

        public void UpdateTime(int timeSeconds)
        {
            //otobrozit' vrem9
            Timer.Text = $"{(timeSeconds / 60):D2}:{(timeSeconds % 60):D2}";
        }
        //=====================
    }
}
