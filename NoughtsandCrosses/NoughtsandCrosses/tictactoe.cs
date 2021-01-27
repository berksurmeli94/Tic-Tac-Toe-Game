using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsandCrosses
{
    public partial class tictactoe : Form
    {
        int mov, movX, movY;
        public tictactoe()
        {
            InitializeComponent();
        }

        public int turns = 0;
        public int sm = 0;
        public int sc = 0;
        public int sd = 0;

        public bool onturn = true;


        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void RButton_Click(object sender, EventArgs e)
        {
            sm = sc = sd = 0;
            NewGame();
        }
        public Button CPU()
        {
            Button b = null;
            if (AverageCPU.Checked == true)
            {
                b = CPUTryWinorDefend("O");
                if (b != null)
                    return b;
                else
                {
                    b = CPUTryWinorDefend("X");
                    if (b != null)
                        return b;
                    else
                        return CPUMoveRandom();
                }
            }
            else if (DumbCPU.Checked == true)
                b = CPUMoveRandom();
            return b;


        }

        public Button CPUTryWinorDefend(String s)
        {
            Button b = null;

            // horizontal
            if ((A00.Text == A01.Text) && A01.Text == s && A02.Text == "")
                return A02;
            else if ((A00.Text == A02.Text) && A00.Text == s && A01.Text == "")
                return A01;
            else if ((A01.Text == A02.Text) && A01.Text == s && A00.Text == "")
                return A00;


            else if ((A10.Text == A12.Text) && A10.Text == s && A11.Text == "")
                return A11;
            else if ((A10.Text == A11.Text) && A10.Text == s && A02.Text == "")
                return A02;
            else if ((A12.Text == A11.Text) && A11.Text == s && A10.Text == "")
                return A10;


            else if ((A20.Text == A22.Text) && A20.Text == s && A21.Text == "")
                return A21;
            else if ((A20.Text == A21.Text) && A20.Text == s && A22.Text == "")
                return A22;
            else if ((A22.Text == A21.Text) && A21.Text == s && A20.Text == "")
                return A20;


            // vertical
            if ((A00.Text == A10.Text) && A00.Text == s && A20.Text == "")
                return A20;
            else if ((A00.Text == A20.Text) && A00.Text == s && A10.Text == "")
                return A10;
            else if ((A20.Text == A10.Text) && A10.Text == s && A00.Text == "")
                return A00;


            else if ((A21.Text == A11.Text) && A11.Text == s && A01.Text == "")
                return A01;
            else if ((A21.Text == A01.Text) && A01.Text == s && A11.Text == "")
                return A11;
            else if ((A22.Text == A12.Text) && A12.Text == s && A02.Text == "")
                return A21;


            else if ((A22.Text == A12.Text) && A12.Text == s && A02.Text == "")
                return A02;
            else if ((A22.Text == A02.Text) && A02.Text == s && A12.Text == "")
                return A12;
            else if ((A02.Text == A12.Text) && A01.Text == s && A22.Text == "")
                return A22;


            // diagonal
            if ((A00.Text == A11.Text) && A11.Text == s && A22.Text == "")
                return A22;
            else if ((A22.Text == A00.Text) && A22.Text == s && A11.Text == "")
                return A11;
            else if ((A22.Text == A11.Text) && A11.Text == s && A00.Text == "")
                return A00;


            else if ((A20.Text == A11.Text) && A11.Text == s && A02.Text == "")
                return A02;
            else if ((A20.Text == A02.Text) && A02.Text == s && A11.Text == "")
                return A11;
            else if ((A02.Text == A11.Text) && A11.Text == s && A20.Text == "")
                return A20;
            else
                return null;


        }
        public Button CPUMoveRandom()
        {
            Button b = null;
            foreach (Control C in Controls)
            {
                b = C as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            {
                if (b.Text == "")
                {
                    if (onturn == true)
                    {
                        b.Text = "X";
                    }
                    else
                        b.Text = "O";
                    turns++;
                    onturn = !onturn;
                }
                if (CheckWinner() == true)
                {
                    if (onturn == false)
                    {
                        sm++;
                        MessageBox.Show("Kazandınız!");
                        NewGame();
                    }
                    else
                    {
                        sc++;
                        MessageBox.Show("Bilgisayar Kazandı!");
                        NewGame();
                    }
                }

                if (CheckDraw() == true && CheckWinner() == false)
                {
                    sd++;
                    MessageBox.Show("Berabere!");
                    NewGame();
                }

                if (onturn == false) 
                {
                    CPU().PerformClick();
                }
            }
        }
    

    private void EButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }



    public void NewGame()
    {
        A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
        onturn = true;
        turns = 0;
        XWin.Text = "Sen : " + sm;
        Me.Text = "Bilgisayar: " + sc;
        Draws.Text = "Beraberlik: " + sd;
    }

    private void NGButton_Click(object sender, EventArgs e)
    {
        NewGame();
    }

    bool CheckDraw()
    {
        if ((turns == 9) && CheckWinner() == false)
            return true;
        else
            return false;
    }

    bool CheckWinner()
    {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A02.Text) && A20.Text != "")
                return true;

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            if      ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;
            else
                return false;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void lbl_close_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_close.BackColor = Color.Red;
        }

        private void lbl_close_MouseLeave(object sender, EventArgs e)
        {
            lbl_close.BackColor = Color.Black;
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void lbl_full_screen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
