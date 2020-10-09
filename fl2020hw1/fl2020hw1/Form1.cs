using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fl2020hw1
{
    public partial class Form1 : Form
    {
        private int num;
        private List<string> lst;
        public Form1()
        {
            InitializeComponent();
        }
        private void DoIt()
        {
            num = 0;
            string str = textBox1.Text.Trim();
            lst = str.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            if (TranslateToNumber()) textBox2.Text = NumToSlav();
            else MessageBox.Show("Некорректные данные");
        }
        private bool TranslateToNumber()
        {
            bool flag100 = false, flag10 = false, flag1 = false;
            int tmp = 0;

            for (int i = 0; i < lst.Count(); i++)
            {
                if (Hundreds(lst[i],ref tmp))
                {
                    if (flag100 || flag10 || flag1) return false;
                    flag100 = true;
                    num += tmp;
                    continue;
                }

                if (Decades(lst[i],ref tmp))
                {
                    if (flag10 || flag1) return false;
                    flag10 = true; flag100 = true;
                    num += tmp;
                    continue;
                }

                if (Units(lst[i],ref tmp))
                {
                    if (flag1) return false;
                    flag1 = true; flag10 = true; flag100 = true;
                    num += tmp;
                    continue;
                }
                 return false;
            }

        return true;
        }

        private bool Units(string word, ref int num)
        {
            if (word == "Один" || word == "один")
            {
                num = 1; return true;
            }
            else if (word == "Два" || word == "два")
            {
                num = 2; return true;
            }
            else if (word == "Три" || word == "три")
            {
                num = 3; return true;
            }
            else if (word == "Четыре" || word == "четыре")
            {
                num = 4; return true;
            }
            else if (word == "Пять" || word == "пять")
            {
                num = 5; return true;
            }
            else if (word == "Шесть" || word == "шесть")
            {
                num = 6; return true;
            }
            else if (word == "Семь" || word == "семь")
            {
                num = 7; return true;
            }
            else if (word == "Восемь" || word == "восемь")
            {
                num = 8; return true;
            }
            else if (word == "Девять" || word == "девять")
            {
                num = 9; return true;
            }
            else if (word == "Десять" || word == "десять")
            {
                num = 10; return true;
            }
            else if (word == "Одиннадцать" || word == "одиннадцать")
            {
                num = 11; return true;
            }
            else if (word == "Двенадцать" || word == "двенацдать")
            {
                num = 12; return true;
            }
            else if (word == "Тринадцать" || word == "тринадцать")
            {
                num = 13; return true;
            }
            else if (word == "Четырнадцать" || word == "четырнадцать")
            {
                num = 14; return true;
            }
            else if (word == "Пятнадцать" || word == "пятнадцать")
            {
                num = 15; return true;
            }
            else if (word == "Шестнадцать" || word == "шестнадцать")
            {
                num = 16; return true;
            }
            else if (word == "Семнадцать" || word == "семнадцать")
            {
                num = 17; return true;
            }
            else if (word == "Восемнадцать" || word == "восемнадцать")
            {
                num = 18; return true;
            }
            else if (word == "Девятнадцать" || word == "девятнадцать")
            {
                num = 19; return true;
            }
            return false;
        }

        private bool Decades(string word, ref int num)
        {
            if (word == "Двадцать" || word == "двадцать")
            {
                num = 20; return true;
            }
            else if (word == "Тридцать" || word == "тридцать")
            {
                num = 30; return true;
            }
            else if (word == "Сорок" || word == "сорок")
            {
                num = 40; return true;
            }
            else if (word == "Пятьдесят" || word == "пятьдесят")
            {
                num = 50; return true;
            }
            else if (word == "Шестьдесят" || word == "шестьдесят")
            {
                num = 60; return true;
            }
            else if (word == "Семьдесят" || word == "семьдесят")
            {
                num = 70; return true;
            }
            else if (word == "Восемьдесят" || word == "восемьдесят")
            {
                num = 80; return true;
            }
            else if (word == "Девяносто" || word == "девяносто")
            {
                num = 90; return true;
            }
            return false;
        }

        private bool Hundreds(string word, ref int num)
        {
            if (word == "Сто" || word == "сто")
            {
                num = 100; return true;
            }
            else if (word == "Двести" || word == "двести")
            {
                num = 200; return true;
            }
            else if (word == "Триста" || word == "триста")
            {
                num = 300; return true;
            }
            else if (word == "Четыреста" || word == "четыреста")
            {
                num = 400; return true;
            }
            else if (word == "Пятьсот" || word == "пятьсот")
            {
                num = 500; return true;
            }
            else if (word == "Шестьсот" || word == "шестьсот")
            {
                num = 600; return true;
            }
            else if (word == "Семьсот" || word == "семьсот")
            {
                num = 700; return true;
            }
            else if (word == "Восемьсот" || word == "восемьсот")
            {
                num = 800; return true;
            }
            else if (word == "Девятьсот" || word == "девятьсот")
            {
                num = 900; return true;
            }

        return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoIt();
        }

        private string NumToSlav()
        {
            string old = null ;
            /*
            А - 1
            В - 2
            И - 8
            Л - 30
            Р - 100
            Ф - 500
            */
            int tmp;
            tmp = num / 500;
            if (tmp != 0)
            {
                old += 'Ф';
                num -= (500 * tmp);
            }
            tmp = num / 100;
            if (tmp != 0)
            {
                for (int i = 0; i < tmp; i++) old += 'Р';
                num -= (100 * tmp);
            }
            tmp = num / 30;
            if (tmp != 0)
            {
                for (int i = 0; i < tmp; i++) old += 'Л';
                num -= (30 * tmp);
            }
            tmp = num / 8;
            if (tmp != 0)
            {
                for (int i = 0; i < tmp; i++) old += 'И';
                num -= (8 * tmp);
            }
            tmp = num / 2;
            if (tmp != 0)
            {
                for (int i = 0; i < tmp; i++) old += 'В';
                num -= (2 * tmp);
            }

            if (num != 0)
            {
                for (int i = 0; i < num; i++) old += 'А';
                num--;
            }
            return old;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r") 
                DoIt();
        }
    }
}
