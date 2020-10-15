using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fl2020hw2
{
    public partial class Form1 : Form
    {

        int wordCount = 0;
        string str=null;
        public Form1()
        {
            InitializeComponent();
        }
        void DoLogic()
        {
            wordCount = 0;
            textOutput.Text = "";
            if (textFrom.Text == "") textFrom.Text = "0";
            if (textTo.Text == "") textTo.Text = "0";

            str = textInput.Text;

            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0)
                {
                    if (str[i - 1] == ' ' && str[i] != ' ')
                        wordCount++;
                }
                else
                {
                    if (str[i] != ' ') wordCount++;
                }
            }
            string str1 = null;

            if (int.Parse(textFrom.Text) <= 0 || int.Parse(textTo.Text) < int.Parse(textFrom.Text) || int.Parse(textTo.Text) > wordCount)
            {
                textOutput.Text = "Неверные данные!";
            }
            else
            {
                int words = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (i > 0)
                    {
                        if (str[i - 1] == ' ' && str[i] != ' ')
                            words++;
                    }
                    else
                    {
                        if (str[i] != ' ') words++;
                    }
                    if (words >= int.Parse(textFrom.Text) && words <= int.Parse(textTo.Text))
                    {
                        str1 += str[i];
                        continue;
                    }
                    textOutput.Text += str[i];
                }
                textOutput.Text += " ";
                textOutput.Text += str1;
            }
        }

        private void textFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = '\0';
            }
        }
        private void textTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!='\b')
            {
                e.KeyChar = '\0';
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoLogic();
        }

        private void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                DoLogic();
        }
    }
}
