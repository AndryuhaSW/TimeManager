namespace TimeManager
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseButton = new Button();
            WorkTime = new TextBox();
            RestTime = new TextBox();
            StartButton = new Button();
            SuspendLayout();
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
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += button1_Click;
            // 
            // WorkTime
            // 
            WorkTime.BorderStyle = BorderStyle.None;
            WorkTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            WorkTime.Location = new Point(47, 60);
            WorkTime.Name = "WorkTime";
            WorkTime.Size = new Size(50, 25);
            WorkTime.TabIndex = 1;
            WorkTime.TextAlign = HorizontalAlignment.Center;
            WorkTime.KeyPress += textBox1_KeyPress;
            WorkTime.Validating += textBox1_Validating;
            // 
            // RestTime
            // 
            RestTime.BorderStyle = BorderStyle.None;
            RestTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RestTime.Location = new Point(125, 60);
            RestTime.Name = "RestTime";
            RestTime.Size = new Size(50, 25);
            RestTime.TabIndex = 2;
            RestTime.TextAlign = HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(255, 192, 128);
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Location = new Point(205, 60);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(50, 25);
            StartButton.TabIndex = 3;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(300, 150);
            Controls.Add(StartButton);
            Controls.Add(RestTime);
            Controls.Add(WorkTime);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            MouseDown += StartForm_MouseDown;
            MouseMove += StartForm_MouseMove;
            MouseUp += StartForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private TextBox WorkTime;
        private TextBox RestTime;
        private Button StartButton;
    }
}