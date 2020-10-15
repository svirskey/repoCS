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
        Dictionary<string, int> dct = null;
        public Form1()
        {
            InitializeComponent();

            dct = new Dictionary<string, int>();

            dct.Add("один", 1);
            dct.Add("два", 2);
            dct.Add("три", 3);
            dct.Add("четыре", 4);
            dct.Add("пять", 5);
            dct.Add("шесть", 6);
            dct.Add("семь", 7);
            dct.Add("восемь", 8);
            dct.Add("девять", 9);
            dct.Add("десять", 10);
            dct.Add("одиннадцать", 11);
            dct.Add("двенадцать", 12);
            dct.Add("тринадцать", 13);
            dct.Add("четырнадцать", 14);
            dct.Add("пятнадцать", 15);
            dct.Add("шестнадцать", 16);
            dct.Add("семнадцать", 17);
            dct.Add("восемнадцать", 18);
            dct.Add("девятнадцать", 19);
            dct.Add("двадцать", 20);
            dct.Add("тридцать", 30);
            dct.Add("сорок", 40);
            dct.Add("пятьдесят", 50);
            dct.Add("шестьдесят", 60);
            dct.Add("семьдесят", 70);
            dct.Add("восемьдесят", 80);
            dct.Add("девяносто", 90);
            dct.Add("сто", 100);
            dct.Add("двести", 200);
            dct.Add("триста", 300);
            dct.Add("четыреста", 400);
            dct.Add("пятьсот", 500);
            dct.Add("шестьсот", 600);
            dct.Add("семьсот", 700);
            dct.Add("восемьсот", 800);
            dct.Add("девятьсот", 900);
        }
        private bool DoIt()
        {
            num = 0;
            string str = textBox1.Text.Trim();
            lst = str.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            bool flagHundreds = true, flagDecades = true, flagUnits = true;

            if (lst.Count<1)
                return false;

            for (int i = 0; i < lst.Count; i++)
            {
                if (dct.ContainsKey(lst[i]))
                {
                    if (dct[lst[i]] < 10)
                    {
                        if ( !flagUnits)                  
                            return false;

                        flagHundreds = false;
                        flagDecades = false;
                        flagUnits = false;
                        num += dct[lst[i]];
                    }

                    else if (dct[lst[i]] < 20)
                    {
                        if (!flagDecades || !flagUnits)
                            return false;

                        flagHundreds = false;
                        flagDecades = false;
                        flagUnits = false;
                        num += dct[lst[i]];
                    }

                    else if (dct[lst[i]] < 100)
                    {
                        if (!flagDecades)
                            return false ;

                        flagHundreds = false;
                        flagDecades = false;
                        num += dct[lst[i]];
                    }
                    else if (dct[lst[i]] < 1000)
                    {
                        if (!flagHundreds)
                            return false;

                        flagHundreds = false;
                        num += dct[lst[i]];
                    }
                }
                else
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (DoIt())  
                textBox2.Text = NumToSlav();
             else     
                textBox2.Text = "Некорректные данные";      
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
