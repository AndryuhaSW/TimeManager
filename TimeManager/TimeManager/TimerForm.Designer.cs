namespace TimeManager
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NextButton = new Button();
            Timer = new TextBox();
            CloseButton = new Button();
            StateName = new TextBox();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(255, 192, 128);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Location = new Point(238, 55);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(50, 25);
            NextButton.TabIndex = 6;
            NextButton.Text = "NEXT";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Visible = false;
            NextButton.Click += NextButton_Click;
            // 
            // Timer
            // 
            Timer.BorderStyle = BorderStyle.None;
            Timer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Timer.Location = new Point(27, 55);
            Timer.Name = "Timer";
            Timer.ReadOnly = true;
            Timer.Size = new Size(100, 25);
            Timer.TabIndex = 5;
            Timer.TextAlign = HorizontalAlignment.Center;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.BackgroundImage = Properties.Resources.CloseWindow;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(276, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(24, 24);
            CloseButton.TabIndex = 4;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // StateName
            // 
            StateName.BorderStyle = BorderStyle.None;
            StateName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StateName.Location = new Point(27, 24);
            StateName.Name = "StateName";
            StateName.ReadOnly = true;
            StateName.Size = new Size(100, 25);
            StateName.TabIndex = 7;
            StateName.Text = "Work";
            StateName.TextAlign = HorizontalAlignment.Center;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(300, 100);
            Controls.Add(StateName);
            Controls.Add(NextButton);
            Controls.Add(Timer);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimerForm";
            StartPosition = FormStartPosition.Manual;
            Text = "TimerForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextButton;
        private TextBox Timer;
        private Button CloseButton;
        private TextBox StateName;
    }
}