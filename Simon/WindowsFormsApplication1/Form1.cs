using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region Variables
        const int MaxSequence = 40;
        const int ColorNumbers = 4;
        Random RandomNumber;
        int[] CorrectSequence;
        int[] PlayerSequence;
        int LeghtOfSequence = 0;
        int PlayerIndex = 0;
        int tR = 0;
        int tB = 0;
        int tY = 0;
        int tG = 0;
        int temp_i = 0;
        Boolean isPlayerTurn = true;
        Boolean isSequenceCorrect = false;
        Boolean isGameStarted = false;
        System.Timers.Timer timer;
        #endregion


        public Form1()
        {
            InitializeComponent();
            CorrectSequence = new int[MaxSequence];
            PlayerSequence = new int[MaxSequence];
            RandomNumber = new Random();
            timer = new System.Timers.Timer(1000);
        }

        #region Button Click
        private void Red_Click(object sender, EventArgs e)
        {
            if (isGameStarted == true)
            {
                if(isPlayerTurn == true)
                {
                    PlayerSequence[PlayerIndex++] = 1;
                    isPlayerTurn = false;
                }
            }
            else
            {
                MessageBox.Show("Игра не начата");
            }
            RedTimer.Start();
            Continue();
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            if (isGameStarted == true)
            {
                if(isPlayerTurn == true)
                {
                    PlayerSequence[PlayerIndex++] = 2;
                    isPlayerTurn = false;
                }
            }
            else
            {
                MessageBox.Show("Игра не начата");
            }
            BlueTimer.Start();
            Continue();
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            if (isGameStarted == true)
            {
                if(isPlayerTurn == true)
                {
                    PlayerSequence[PlayerIndex++] = 3;
                    isPlayerTurn = false;
                }
            }
            else
            {
                MessageBox.Show("Игра не начата");
            }
            YellowTimer.Start();
            Continue();
        }

        private void Green_Click(object sender, EventArgs e)
        {
            if (isGameStarted == true)
            {
                if(isPlayerTurn == true)
                {
                    PlayerSequence[PlayerIndex++] = 4;
                    isPlayerTurn = false;
                }
            }
            else
            {
                MessageBox.Show("Игра не начата");
            }
            GreenTimer.Start();
            Continue();
        }
        #endregion

        private void initializeColorSequence()
        {
            for (int i = 0; i < MaxSequence; i++)
            {
                CorrectSequence[i] = RandomNumber.Next(1, ColorNumbers);
                PlayerSequence[i] = 0;
            }
        }

        private void StartGame()
        {
            LeghtOfSequence = 0;
            Label.Text = "Раунд " + Convert.ToString(LeghtOfSequence);
            isGameStarted = true;
            PlayerIndex = 0;
            initializeColorSequence();
            isPlayerTurn = false;
            Continue();
        }

        private void Continue()
        {
            isSequenceCorrect = true;
            for (int i = 0; i < PlayerIndex; i++)
            {
                if(CorrectSequence[i] == PlayerSequence[i])
                {
                    //
                }
                else
                {
                    isSequenceCorrect = false;
                    break;
                }
            }

            if (PlayerIndex >= LeghtOfSequence)
            {
                if (isSequenceCorrect == true)
                {
                    LeghtOfSequence++;
                    if(LeghtOfSequence <= MaxSequence)
                    {
                        Label.Text = "Раунд " + Convert.ToString(LeghtOfSequence);
                        temp_i = 1;
                        GameTimer.Start();
                        isPlayerTurn = true;
                        PlayerIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Вы выиграли!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы проиграли :-(");
                }
            }
            else
            {
                isPlayerTurn = true;
            }
          }

        private void Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        #region Color Blink
        private void RedTimer_Tick(object sender, EventArgs e)
        {
            RedTop.Visible = true;
            if(tR > 5)
            {
                RedTimer.Stop();
                RedTop.Visible = false;
                tR = 0;
            }
            tR += 1;
        }

        private void BlueTimer_Tick(object sender, EventArgs e)
        {
            BlueTop.Visible = true;
            if (tB > 5)
            {
                BlueTimer.Stop();
                BlueTop.Visible = false;
                tB = 0;
            }
            tB += 1;
        }

        private void YellowTimer_Tick(object sender, EventArgs e)
        {
            YellowTop.Visible = true;
            if (tY > 5)
            {
                YellowTimer.Stop();
                YellowTop.Visible = false;
                tY = 0;
            }
            tY += 1;
        }

        private void GreenTimer_Tick(object sender, EventArgs e)
        {
            GreenTop.Visible = true;
            if (tG > 5)
            {
                GreenTimer.Stop();
                GreenTop.Visible = false;
                tG = 0;
            }
            tG += 1;
        }
        #endregion

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (CorrectSequence[temp_i - 1] == 1)
            {
                RedTimer.Start();
            }
            if (CorrectSequence[temp_i - 1] == 2)
            {
                BlueTimer.Start();
            }
            if (CorrectSequence[temp_i - 1] == 3)
            {
                YellowTimer.Start();
            }
            if (CorrectSequence[temp_i - 1] == 4)
            {
                GreenTimer.Start();
            }
            if(temp_i >= LeghtOfSequence)
            {
                GameTimer.Stop();
            }
            else
            {
                temp_i += 1;
            }
        }

    }
    
}
