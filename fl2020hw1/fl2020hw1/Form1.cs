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
        private Dictionary<string, (int num, numberFormat ind)> dct = null;
        private Dictionary<int, string> err = null;
        private Dictionary<int, string> slav = null;
        public enum numberFormat
        {
            single=1,
            ten_nineteen=2,
            decades=3,
            hundreds=4
        }
        public Form1()
        {
            InitializeComponent();

            dct = new Dictionary<string, (int, numberFormat)>();
            err = new Dictionary<int, string>();
            slav = new Dictionary<int, string>();

            err.Add(1, "единичного формата");
            err.Add(2, "формата 10-19");
            err.Add(3, "десятичного формата");
            err.Add(4, "формата сотен");

            dct.Add("один", (1, numberFormat.single));
            dct.Add("два", (2, numberFormat.single));
            dct.Add("три", (3, numberFormat.single));
            dct.Add("четыре", (4, numberFormat.single));
            dct.Add("пять", (5, numberFormat.single));
            dct.Add("шесть", (6, numberFormat.single));
            dct.Add("семь", (7, numberFormat.single));
            dct.Add("восемь", (8, numberFormat.single));
            dct.Add("девять", (9, numberFormat.single));
            dct.Add("десять", (10, numberFormat.ten_nineteen));
            dct.Add("одиннадцать", (11, numberFormat.ten_nineteen));
            dct.Add("двенадцать", (12, numberFormat.ten_nineteen));
            dct.Add("тринадцать", (13, numberFormat.ten_nineteen));
            dct.Add("четырнадцать", (14, numberFormat.ten_nineteen));
            dct.Add("пятнадцать", (15, numberFormat.ten_nineteen));
            dct.Add("шестнадцать", (16, numberFormat.ten_nineteen));
            dct.Add("семнадцать", (17, numberFormat.ten_nineteen));
            dct.Add("восемнадцать", (18, numberFormat.ten_nineteen));
            dct.Add("девятнадцать", (19, numberFormat.ten_nineteen));
            dct.Add("двадцать", (20, numberFormat.decades));
            dct.Add("тридцать", (30, numberFormat.decades));
            dct.Add("сорок", (40, numberFormat.decades));
            dct.Add("пятьдесят", (50, numberFormat.decades));
            dct.Add("шестьдесят", (60, numberFormat.decades));
            dct.Add("семьдесят", (70, numberFormat.decades));
            dct.Add("восемьдесят", (80, numberFormat.decades));
            dct.Add("девяносто", (90, numberFormat.decades));
            dct.Add("сто", (100, numberFormat.hundreds));
            dct.Add("двести", (200, numberFormat.hundreds));
            dct.Add("триста", (300, numberFormat.hundreds));
            dct.Add("четыреста", (400, numberFormat.hundreds));
            dct.Add("пятьсот", (500, numberFormat.hundreds));
            dct.Add("шестьсот", (600, numberFormat.hundreds));
            dct.Add("семьсот", (700, numberFormat.hundreds));
            dct.Add("восемьсот", (800, numberFormat.hundreds));
            dct.Add("девятьсот", (900, numberFormat.hundreds));

            slav.Add(500, "Ф");
            slav.Add(100, "Р");
            slav.Add(30, "Л");
            slav.Add(8, "И");
            slav.Add(2, "В");
            slav.Add(1, "A"); 
        }

        private bool find(int from, int to)
        {
            if (dct[lst[from]].num == dct[lst[to]].num)
            {
                MessageBox.Show($"Два одинаковых числа \"{lst[from]}\" ");
                return false;
            }
            if (dct[lst[from]].ind == dct[lst[to]].ind)
            {
                MessageBox.Show($"Два числа \"{lst[from]}\" и \"{lst[to]}\" {err[(int)dct[lst[from]].ind]}");
                return false;
            }

            if (dct[lst[from]].ind < dct[lst[to]].ind)
            {
                MessageBox.Show($"Число {err[(int)dct[lst[from]].ind]} \"{lst[from]}\" перед числом {err[(int)dct[lst[to]].ind]} \"{lst[to]}\"");
                return false;
            }

            if (dct[lst[from]].ind==numberFormat.ten_nineteen && dct[lst[to]].ind== numberFormat.single)
            {
                MessageBox.Show($"Число {err[(int)dct[lst[from]].ind]} \"{lst[from]}\" перед числом {err[(int)dct[lst[to]].ind]} \"{lst[to]}\"");
                return false;
            }

            if (dct[lst[from]].ind == numberFormat.decades && dct[lst[to]].ind == numberFormat.ten_nineteen)
            {
                MessageBox.Show($"Число {err[(int)dct[lst[from]].ind]} \"{lst[from]}\" перед числом {err[(int)dct[lst[to]].ind]} \"{lst[to]}\" ");
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
                    MessageBox.Show($"Некорректное слово \"{lst[i]}\"");
                    return false;
                }
            }

            if (lst.Count == 2)
            {
                if (!find(0, 1)) return false; 
            }
           
            if (lst.Count == 3)
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
