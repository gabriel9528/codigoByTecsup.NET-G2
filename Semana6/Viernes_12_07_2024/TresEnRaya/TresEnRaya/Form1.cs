namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;
        public Form1()
        {
            InitializeComponent();
        }
        public void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        public void Score()
        {
            #region Player X


            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Coral;
                button2.BackColor = Color.Coral;
                button3.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Coral;
                button4.BackColor = Color.Coral;
                button7.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Coral;
                button5.BackColor = Color.Coral;
                button9.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Coral;
                button5.BackColor = Color.Coral;
                button6.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Coral;
                button8.BackColor = Color.Coral;
                button9.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Coral;
                button5.BackColor = Color.Coral;
                button8.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Coral;
                button6.BackColor = Color.Coral;
                button9.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Coral;
                button5.BackColor = Color.Coral;
                button7.BackColor = Color.Coral;

                MessageBox.Show("Player X ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            #endregion

            #region Player O

            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                button1.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }


            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                button1.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                button4.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                button2.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (string.IsNullOrEmpty(labelPlayer0.Text))
                //{
                //    plusOne = 0;
                //}
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                button3.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                button3.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;

                MessageBox.Show("Player 0 ha ganado esta partida", "Juego de tres en raya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            #endregion
        }

        #region Button_Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "0";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "0";
                checker = false;
            }
            Score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "0";
                checker = false;
            }
            Score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "0";
                checker = false;
            }
            Score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "0";
                checker = false;
            }
            Score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "0";
                checker = false;
            }
            Score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "0";
                checker = false;
            }
            Score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "0";
                checker = false;
            }
            Score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "0";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        #endregion

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            labelPlayer0.Text = "0";
            labelPlayerX.Text = "0";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            buttonNewGame.Enabled = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result =
            MessageBox.Show("¿Estas seguro que deseas salir?", "Juego de tres en raya",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
