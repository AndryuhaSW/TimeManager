namespace TimeManager
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //=======================
        //drag window
        private bool mouseDown;
        private Point lastWinodwLocation;

        private void StartForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void StartForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastWinodwLocation.X) + e.X,
                    (this.Location.Y - lastWinodwLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void StartForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastWinodwLocation = e.Location;
        }

        //=======================


        //=======================
        //close windows
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //=======================

        //=======================
        //num validation
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Блокируем символ, если он не является числовым.
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToInt32(WorkTime.Text) > 50)
            {
                WorkTime.Text = "59";
            }
        }


        //=======================

        //=======================
        //
        private void StartButton_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm(
                Convert.ToInt32(WorkTime.Text),
                Convert.ToInt32(RestTime.Text));
            timerForm.Show();
            this.Hide();
        }
        //=======================
    }
}