namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.BlueTop = new System.Windows.Forms.PictureBox();
            this.RedTop = new System.Windows.Forms.PictureBox();
            this.YellowTop = new System.Windows.Forms.PictureBox();
            this.GreenTop = new System.Windows.Forms.PictureBox();
            this.RedTimer = new System.Windows.Forms.Timer(this.components);
            this.BlueTimer = new System.Windows.Forms.Timer(this.components);
            this.YellowTimer = new System.Windows.Forms.Timer(this.components);
            this.GreenTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTop)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(16, 17);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 39);
            this.Start.TabIndex = 0;
            this.Start.Text = "Begin";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Red.Location = new System.Drawing.Point(16, 81);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(162, 147);
            this.Red.TabIndex = 1;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Navy;
            this.Blue.Location = new System.Drawing.Point(184, 81);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(162, 147);
            this.Blue.TabIndex = 2;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(16, 229);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(162, 147);
            this.Yellow.TabIndex = 3;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(184, 229);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(162, 147);
            this.Green.TabIndex = 4;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(221, 19);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 5;
            // 
            // BlueTop
            // 
            this.BlueTop.BackColor = System.Drawing.Color.Blue;
            this.BlueTop.Location = new System.Drawing.Point(184, 81);
            this.BlueTop.Name = "BlueTop";
            this.BlueTop.Size = new System.Drawing.Size(162, 147);
            this.BlueTop.TabIndex = 6;
            this.BlueTop.TabStop = false;
            this.BlueTop.Visible = false;
            // 
            // RedTop
            // 
            this.RedTop.BackColor = System.Drawing.Color.Red;
            this.RedTop.Location = new System.Drawing.Point(16, 81);
            this.RedTop.Name = "RedTop";
            this.RedTop.Size = new System.Drawing.Size(162, 147);
            this.RedTop.TabIndex = 7;
            this.RedTop.TabStop = false;
            this.RedTop.Visible = false;
            // 
            // YellowTop
            // 
            this.YellowTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.YellowTop.Location = new System.Drawing.Point(16, 229);
            this.YellowTop.Name = "YellowTop";
            this.YellowTop.Size = new System.Drawing.Size(162, 147);
            this.YellowTop.TabIndex = 8;
            this.YellowTop.TabStop = false;
            this.YellowTop.Visible = false;
            // 
            // GreenTop
            // 
            this.GreenTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GreenTop.Location = new System.Drawing.Point(184, 229);
            this.GreenTop.Name = "GreenTop";
            this.GreenTop.Size = new System.Drawing.Size(162, 147);
            this.GreenTop.TabIndex = 9;
            this.GreenTop.TabStop = false;
            this.GreenTop.Visible = false;
            // 
            // RedTimer
            // 
            this.RedTimer.Interval = 10;
            this.RedTimer.Tick += new System.EventHandler(this.RedTimer_Tick);
            // 
            // BlueTimer
            // 
            this.BlueTimer.Interval = 10;
            this.BlueTimer.Tick += new System.EventHandler(this.BlueTimer_Tick);
            // 
            // YellowTimer
            // 
            this.YellowTimer.Interval = 10;
            this.YellowTimer.Tick += new System.EventHandler(this.YellowTimer_Tick);
            // 
            // GreenTimer
            // 
            this.GreenTimer.Interval = 10;
            this.GreenTimer.Tick += new System.EventHandler(this.GreenTimer_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(169, 35);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(45, 13);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "0 очков";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(362, 387);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GreenTop);
            this.Controls.Add(this.YellowTop);
            this.Controls.Add(this.RedTop);
            this.Controls.Add(this.BlueTop);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Simon";
            ((System.ComponentModel.ISupportInitialize)(this.BlueTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox BlueTop;
        private System.Windows.Forms.PictureBox RedTop;
        private System.Windows.Forms.PictureBox YellowTop;
        private System.Windows.Forms.PictureBox GreenTop;
        private System.Windows.Forms.Timer RedTimer;
        private System.Windows.Forms.Timer BlueTimer;
        private System.Windows.Forms.Timer YellowTimer;
        private System.Windows.Forms.Timer GreenTimer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

