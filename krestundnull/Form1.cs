using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krestundnull
{
    public partial class Form1 : Form
    {

        string a = "";
        Random random = new Random();
        int[] array = new int[9];
        Button[] button = new Button[9];

        public Form1()
        {
            InitializeComponent();

            if (random.Next(1, 10) <= 5)
            {
                a = "Крестики";
                label1.Text = "Ходят X";
            }

            else
            {
                a = "Ходят O";
                label1.Text = "Ходят O";
            }

            button[0] = button1;

            button[1] = button2;

            button[2] = button3;

            button[3] = button4;

            button[4] = button5;

            button[5] = button6;

            button[6] = button7;

            button[7] = button8;

            button[8] = button9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (a == "Крестики")
            {
                for (int i = 0; i < button.Length; i++)
                {
                    if (sender == button[i])
                    {
                        button[i].Text = "X";
                        label1.Text = "Ходят O";
                        a = "1";
                        button[i].Enabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }

            else // Нолики
            {
                for (int i = 0; i < button.Length; i++)
                {
                    if (sender == button[i])
                    {
                        button[i].Text = "O";
                        label1.Text = "Ходят X";
                        a = "Крестики";
                        button[i].Enabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }

            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[1].BackColor = System.Drawing.Color.Green;

                button[2].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";

            }

            else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                button[3].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[5].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }
            else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                button[6].BackColor = System.Drawing.Color.Green;

                button[7].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }

            else if (array[7] == 1 && array[4] == 1 && array[1] == 1)
            {
                button[7].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[1].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }
            else if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[3].BackColor = System.Drawing.Color.Green;

                button[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }
            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                button[2].BackColor = System.Drawing.Color.Green;

                button[5].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }
            else if (array[2] == 1 && array[4] == 1 && array[6] == 1)
            {
                button[2].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }
            else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа крестиков!";
            }



           
            else if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[1].BackColor = System.Drawing.Color.Green;

                button[2].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";

            }

            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                button[3].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[5].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }
            
            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                button[6].BackColor = System.Drawing.Color.Green;

                button[7].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }

            else if (array[7] == 2 && array[4] == 2 && array[1] == 2)
            {
                button[7].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[1].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }
            
            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[3].BackColor = System.Drawing.Color.Green;

                button[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }
            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                button[2].BackColor = System.Drawing.Color.Green;

                button[5].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }
            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                button[2].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[6].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";
            }
            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                button[0].BackColor = System.Drawing.Color.Green;

                button[4].BackColor = System.Drawing.Color.Green;

                button[8].BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < button.Length; i++)
                {
                    button[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Победа ноликов!";



            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < button.Length; i++)
            {
                array[i] = 0;
                button[i].Text = "";

                if (random.Next(1,10) <= 5 )
                {
                    a = "Крестики";
                    label1.Text = "Ходят X";
                }
                else
                {
                    a = "Ходят O";
                    label1.Text = "Ходят O";
                }
                button[i].Enabled = true;
                button[i].BackColor = System.Drawing.Color.White;
            }
        }
    }
}
    

