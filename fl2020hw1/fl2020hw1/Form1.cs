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
        Dictionary<string, (int num, int ind)> dct = null;
        Dictionary<int, string> err = null;
        Dictionary<int, string> slav = null;
        public Form1()
        {
            InitializeComponent();

            dct = new Dictionary<string, (int, int)>();
            err = new Dictionary<int, string>();
            slav = new Dictionary<int, string>();

            err.Add(1, "единичного формата");
            err.Add(2, "формата 10-19");
            err.Add(3, "десятичного формата");
            err.Add(4, "формата сотен");

            dct.Add("один", (1, 1));
            dct.Add("два", (2, 1));
            dct.Add("три", (3, 1));
            dct.Add("четыре", (4, 1));
            dct.Add("пять", (5, 1));
            dct.Add("шесть", (6, 1));
            dct.Add("семь", (7, 1));
            dct.Add("восемь", (8, 1));
            dct.Add("девять", (9, 1));
            dct.Add("десять", (10, 2));
            dct.Add("одиннадцать", (11, 2));
            dct.Add("двенадцать", (12, 2));
            dct.Add("тринадцать", (13, 2));
            dct.Add("четырнадцать", (14, 2));
            dct.Add("пятнадцать", (15, 2));
            dct.Add("шестнадцать", (16, 2));
            dct.Add("семнадцать", (17, 2));
            dct.Add("восемнадцать", (18, 2));
            dct.Add("девятнадцать", (19, 2));
            dct.Add("двадцать", (20, 3));
            dct.Add("тридцать", (30, 3));
            dct.Add("сорок", (40, 3));
            dct.Add("пятьдесят", (50, 3));
            dct.Add("шестьдесят", (60, 3));
            dct.Add("семьдесят", (70, 3));
            dct.Add("восемьдесят", (80, 3));
            dct.Add("девяносто", (90, 3));
            dct.Add("сто", (100, 4));
            dct.Add("двести", (200, 4));
            dct.Add("триста", (300, 4));
            dct.Add("четыреста", (400, 4));
            dct.Add("пятьсот", (500, 4));
            dct.Add("шестьсот", (600, 4));
            dct.Add("семьсот", (700, 4));
            dct.Add("восемьсот", (800, 4));
            dct.Add("девятьсот", (900, 4));

            slav.Add(500, "Ф");
            slav.Add(100, "Р");
            slav.Add(30, "Л");
            slav.Add(8, "И");
            slav.Add(2, "В");
            slav.Add(1, "A"); 
        }

        private bool find(int from, int to)
        {
            if (dct[lst[from]].ind == dct[lst[to]].ind)
            {
                MessageBox.Show($"Два числа {err[dct[lst[from]].ind]}");
                return false;
            }

            if (dct[lst[from]].ind < dct[lst[to]].ind)
            {
                MessageBox.Show($"Число {err[dct[lst[from]].ind]} перед числом {err[dct[lst[to]].ind]}");
                return false;
            }

            if (dct[lst[from]].ind==2 && dct[lst[to]].ind==1)
            {
                MessageBox.Show($"Число {err[dct[lst[from]].ind]} перед числом {err[dct[lst[to]].ind]}");
                return false;
            }
            return true;
        }

        private bool DoIt()
        {
            num = 0;
            string str = textBoxInput.Text.Trim();
            lst = str.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            if (lst.Count == 0)
            {
                MessageBox.Show("Пустая строка!");
                return false;
            }

            if (lst.Count > 3)
            {
                MessageBox.Show("Слишком много слов!");
                return false;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                if (!dct.ContainsKey(lst[i]))
                {
                    MessageBox.Show($"Некорректное слово {lst[i]}");
                    return false;
                }
            }

            if (lst.Count == 2)
            {
                if (!find(0, 1)) return false; 
            }
           
            if (lst.Count==3)
            {
                if (!find(0, 1)) return false;
                if (!find(0, 2)) return false;
                if (!find(1, 2)) return false;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                num += dct[lst[i]].num;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DoIt())
            {
                textBoxArabian.Text = num.ToString();
                textBoxSlav.Text = NumToSlav();
            }
            else
            {
                textBoxArabian.Text = "\0";
                textBoxSlav.Text = "\0";
            }
        }

        private string NumToSlav()
        {
            string str = null;
            int varNum = num;

            foreach (var key in slav.Keys)
            {
                while (varNum>=key)
                {
                    varNum -= key;
                    str += slav[key];
                }
            }
            return str;
        }
    }
}
