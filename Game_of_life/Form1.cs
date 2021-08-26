using Game_of_life.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_life
{
    public partial class Form1 : Form
    {
        static Board myBoard = new Board(30);

        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public bool RunSimulation = false;

        public Color deadColor = Color.Gray;

        public Color aliveColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {
            int buttonSize = panel1.Width / myBoard.Size;

            panel1.Height = panel1.Width;

            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    btnGrid[i, j].Click += Grid_Button_Click;

                    panel1.Controls.Add(btnGrid[i, j]);

                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].BackColor = deadColor;
                    btnGrid[i, j].Tag = new Point(i, j);
                    btnGrid[i, j].TabStop = false;
                    btnGrid[i, j].FlatStyle = FlatStyle.Flat;
                    btnGrid[i, j].FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            if (currentButton.BackColor == deadColor)
                currentButton.BackColor = aliveColor;
            else currentButton.BackColor = deadColor;

            Point location = (Point)currentButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell curentCell = myBoard.theGrid[x, y];
            curentCell.IsAlive = !curentCell.IsAlive;
        }

        private void randButton_Click(object sender, EventArgs e)
        {
            Randomize();
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if (myBoard.theGrid[i, j].IsAlive)
                        btnGrid[i, j].BackColor = aliveColor;
                    else btnGrid[i, j].BackColor = deadColor;
                }
            }
        }

        private void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    myBoard.theGrid[i, j].IsAlive = (rand.NextDouble() > 0.5);
                }
            }
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            CalculateNextGen();
            RefreshButtons();
        }

        private void CalculateNextGen()
        {
            bool[,] nextGen = new bool[myBoard.Size, myBoard.Size];

            for (int row = 1; row < myBoard.Size - 1; row++)
            {
                for (int col = 1; col < myBoard.Size - 1; col++)
                {
                    int aliveNeighbors = 0;
                    for(int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (myBoard.theGrid[row + i, col + j].IsAlive)
                                aliveNeighbors++;
                        }
                    }

                    var currentCell = myBoard.theGrid[row, col];

                    if (currentCell.IsAlive)
                        aliveNeighbors--;

                    // Cell is lonely and dies 
                    if (currentCell.IsAlive && aliveNeighbors < 2)
                        nextGen[row, col] = false;

                    // Cell dies due to over population 
                    else if (currentCell.IsAlive && aliveNeighbors > 3)
                        nextGen[row, col] = false;

                    // A new cell is born 
                    else if (!currentCell.IsAlive && aliveNeighbors == 3)
                        nextGen[row, col] = true;

                    // All other cells stay the same
                    else nextGen[row, col] = currentCell.IsAlive;
                }
            }
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    myBoard.theGrid[i, j].IsAlive = nextGen[i, j];
                }
            }
        }

        private void Pause()
        {
            RunSimulation = false;
        }

        private async Task Run()
        {
            RunSimulation = true;
            while (RunSimulation)
            {
                CalculateNextGen();
                RefreshButtons();
                await Task.Delay(1000);
            }
        }

        private async void startPauseButton_Click(object sender, EventArgs e)
        {
            if(startPauseButton.Text == "Start")
            {
                startPauseButton.Text = "Pause";
                await Run();
            }else
            {
                startPauseButton.Text = "Start";
                Pause();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearBoard();
            RefreshButtons();
        }

        private void ClearBoard()
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    myBoard.theGrid[i, j].IsAlive = false;
                }
            }
        }
    }
}
