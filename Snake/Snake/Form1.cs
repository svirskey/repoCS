using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private int[,] field;

        private List<int> snakeX;
        private List<int> snakeY;
        
        private (int x, int y) food;

        /*
         0 - empty
         1 - food
         2 - snake
         3 - head
         */
        private int direction;
        private int oldDirection;
        /*
         1 - left
         2 - up
         3 - right
         4 - down
         */

        private int rows;
        private int cols;

        public Form1()
        {
            InitializeComponent();
            playingField.Visible = false;

            buttonPauseExit.Visible = false;
            buttonPauseContinue.Visible = false;
            labelPause.Visible = false;

            labelSettings.Visible = false;
            labelSpeed.Visible = false;
            labelResolution.Visible = false;
            nudResolution.Visible = false;
            nudSpeed.Visible = false;
            buttonSettingsExit.Visible = false;

            labelEndGameOver.Visible = false;
            labelEndScore.Visible = false;
            buttonEndExit.Visible = false;

            KeyPreview = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            buttonSettings.Visible = false;
            buttonExit.Visible = false;
            playingField.Visible = true;

            resolution = (int)nudResolution.Value;
            timerPlay.Interval =  750/  (int)nudSpeed.Value + 1;

            rows = playingField.Height / resolution; // высота
            cols = playingField.Width / resolution; // ширина
            field = new int[cols, rows]; // столбцы и строки

            // random snake and food
            snakeX = new List<int>();
            snakeY = new List<int>();

            Random rnd = new Random();

            snakeX.Add( rnd.Next(0, cols) ); // head
            snakeY.Add( rnd.Next(0, rows) ); // head

            snakeX.Add( 0 ); // null tail
            snakeY.Add( 0 ); // null tail

            field[snakeX[0], snakeY[0]] = 3;

            food.y = rnd.Next(0, rows);
            food.x = rnd.Next(0, cols);

            direction = rnd.Next(1, 4);

            switch (direction)
            {
                case 1: // left
                {
                    if (snakeX[0] == cols - 1)
                        snakeX[1] = 0;
                    else
                        snakeX[1] = snakeX[0] + 1;

                    snakeY[1] = snakeY[0];
                    break;
                }
                case 2:// up
                {
                    if (snakeY[0] == rows - 1)
                         snakeY[1] = 0;
                    else
                         snakeY[1] = snakeY[0] + 1;

                    snakeX[1] = snakeX[0];
                    break;
                }
                case 3: // right
                {
                    if (snakeX[0] == 0)
                         snakeX[1] = cols - 1;
                    else
                         snakeX[1] = snakeX[0] - 1;

                    snakeY[1] = snakeY[0];
                    break;
                }
                case 4:  // down
                {
                    if (snakeY[0] == 0)
                        snakeY[1] = rows - 1;
                    else
                        snakeY[1] = snakeY[0] - 1;

                    snakeX[1] = snakeX[0];
                    break;
                }
            }

            if (field[food.x, food.y] == 0)
                field[food.x, food.y] = 1;

            
            playingField.Image = new Bitmap(playingField.Width, playingField.Height);
            graphics = Graphics.FromImage(playingField.Image);

            graphics.Clear(Color.Black);
            playingField.Refresh();

            timerPlay.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b' && timerPlay.Enabled)
            {
                timerPlay.Stop();

                labelPause.Visible = true;
                buttonPauseContinue.Visible = true;
                buttonPauseExit.Visible = true;
            }

            if (e.KeyChar == 'w')
            {
                if (oldDirection != 4) 
                    direction = 2;
            }
            if (e.KeyChar == 'a')
            {
                if (oldDirection != 3)
                    direction = 1;
            }
            if (e.KeyChar == 's')
            {
                if (oldDirection != 2)
                    direction = 4;
            }
            if (e.KeyChar == 'd')
            {
                if (oldDirection != 1)
                    direction = 3;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            labelSettings.Visible = true;
            labelSpeed.Visible = true;
            labelResolution.Visible = true;
            nudResolution.Visible = true;
            nudSpeed.Visible = true;
            buttonSettingsExit.Visible = true;

            buttonStart.Visible = false;
            buttonSettings.Visible = false;
            buttonExit.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            oldDirection = direction;
            graphics.Clear(Color.Black);

            switch (direction)
            {
                case 1: // left
                    {
                        if (snakeX[0] == 0)
                        {
                            field[cols - 1, snakeY[0]] = 3;
                            snakeX.Insert(0, cols - 1);
                            snakeY.Insert(0, snakeY[0]);
                        }
                        else
                        {
                            field[snakeX[0] - 1, snakeY[0]] = 3;
                            snakeX.Insert(0, snakeX[0] - 1);
                            snakeY.Insert(0, snakeY[0]);
                        }

                        break;
                    }
                case 2: // up
                    {
                        if (snakeY[0] == 0)
                        {
                            field[snakeX[0], rows - 1] = 3;
                            snakeY.Insert(0, rows - 1);
                            snakeX.Insert(0, snakeX[0]);
                        }
                        else
                        {
                            field[snakeX[0], snakeY[0] - 1] = 3;
                            snakeY.Insert(0, snakeY[0] - 1);
                            snakeX.Insert(0, snakeX[0]);
                        }

                        break;
                    }
                case 3: //right
                    {
                        if (snakeX[0] == cols - 1)
                        {
                            field[0, snakeY[0]] = 3;
                            snakeX.Insert(0, 0);
                            snakeY.Insert(0, snakeY[0]);
                        }
                        else
                        {
                            field[snakeX[0] + 1, snakeY[0]] = 3;
                            int temp = snakeX[0] + 1;
                            snakeX.Insert(0, temp);
                            snakeY.Insert(0, snakeY[0]);
                        }

                        break;
                    }
                case 4: // down
                    {
                        if (snakeY[0] == rows - 1)
                        {
                            field[snakeX[0], 0] = 3;
                            snakeY.Insert(0, 0);
                            snakeX.Insert(0, snakeX[0]);
                        }
                        else
                        {
                            field[snakeX[0], snakeY[0] + 1] = 3;
                            int temp = snakeY[0] + 1;
                            snakeY.Insert(0, temp);
                            snakeX.Insert(0, snakeX[0]);
                        }

                        break;
                    }
            }

            if (snakeX[0]!=food.x || snakeY[0]!=food.y)
            {
                snakeX.RemoveAt(snakeX.Count - 1);
                snakeY.RemoveAt(snakeY.Count - 1);
            }
            else
            {
                Random rand = new Random();
                do
                {
                    food.x = rand.Next(0, cols);
                    food.y = rand.Next(0, rows);
                } while (field[food.x,food.y]!=0);
            }


            for (int i = 1; i < snakeX.Count; i++)
            {
                field[snakeX[i], snakeY[i]] = 2;
            }

            graphics.FillRectangle(Brushes.Green, food.x * resolution, 
                                    food.y * resolution, resolution, resolution);

            for (int i = 0; i < snakeX.Count; i++)
            {
                
                if (field[snakeX[i], snakeY[i]] == 3)
                    graphics.FillRectangle(Brushes.Yellow, snakeX[i] * resolution, snakeY[i] * resolution, resolution, resolution);

                if (field[snakeX[i], snakeY[i]] == 2)
                    graphics.FillRectangle(Brushes.OrangeRed, snakeX[i] * resolution, snakeY[i] * resolution, resolution, resolution);
            }
            for (int i = 1; i < snakeX.Count; i++)
            {
                if (field[snakeX[0], snakeY[0]] == field[snakeX[i], snakeY[i]])
                {
                    GameOver();
                }
            }
            playingField.Refresh();
        }

        private void GameOver()
        {
            timerPlay.Stop();

            labelEndScore.Text = $"Ваш счет: {snakeX.Count}";

            labelEndGameOver.Visible = true;
            labelEndScore.Visible = true;
            buttonEndExit.Visible = true;
        }

        private void buttonPauseContinue_Click(object sender, EventArgs e)
        {
            playingField.Visible = true;
            buttonPauseContinue.Visible = false;
            buttonPauseExit.Visible = false;
            labelPause.Visible = false;

            timerPlay.Start();
        }

        private void buttonPauseExit_Click(object sender, EventArgs e)
        {
            playingField.Visible = false;
            buttonPauseContinue.Visible = false;
            buttonPauseExit.Visible = false;
            labelPause.Visible = false;
            buttonStart.Visible = true;
            buttonSettings.Visible = true;
            buttonExit.Visible = true;

        }

        private void buttonSettingsExit_Click(object sender, EventArgs e)
        {
            labelSettings.Visible = false;
            labelSpeed.Visible = false;
            labelResolution.Visible = false;
            nudResolution.Visible = false;
            nudSpeed.Visible = false;
            buttonSettingsExit.Visible = false;

            buttonStart.Visible = true;
            buttonSettings.Visible = true;
            buttonExit.Visible = true;
        }

        private void buttonEndExit_Click(object sender, EventArgs e)
        {
            playingField.Visible = false;

            labelEndGameOver.Visible = false;
            labelEndScore.Visible = false;
            buttonEndExit.Visible = false;

            buttonStart.Visible = true;
            buttonSettings.Visible = true;
            buttonExit.Visible = true;
        }
    }
}
