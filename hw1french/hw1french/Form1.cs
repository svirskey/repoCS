using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hw1french
{
    public partial class Form1 : Form
    {
        private int num;
        private List<string> lst;
        private Dictionary<string, int> dct = null;
        private Dictionary<int, string> slav = null;

        public Form1()
        {
            InitializeComponent();
            dct = new Dictionary<string, int>();
            slav = new Dictionary<int, string>();

            dct.Add("un", 1);
            dct.Add("deux", 2);
            dct.Add("trois", 3);
            dct.Add("quatre", 4);
            dct.Add("cinq", 5);
            dct.Add("six", 6);
            dct.Add("sept", 7);
            dct.Add("huit", 8);
            dct.Add("neuf", 9);
            dct.Add("dix", 10);

            dct.Add("onze", 11);
            dct.Add("douze", 12);
            dct.Add("treize", 13);
            dct.Add("quatorze", 14);
            dct.Add("quinze", 15);
            dct.Add("seize", 16);

            dct.Add("vingt", 20);
            dct.Add("vingts", 20);

            dct.Add("trente", 30);
            dct.Add("quarante", 40);
            dct.Add("cinquante", 50);
            dct.Add("soixante", 60);

            dct.Add("cent", 100);
            dct.Add("cents", 100);

            slav.Add(500, "Ф");
            slav.Add(100, "Р");
            slav.Add(30, "Л");
            slav.Add(8, "И");
            slav.Add(2, "В");
            slav.Add(1, "A");
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

            if (lst.Count > 6)
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

            switch (lst.Count)
            {
                case 1:
                    {
                        if (lst[0] == "cents")
                        {
                            MessageBox.Show($"Cлово \"{lst[0]}\" не может стоять первым");
                            return false;
                        }
                        num = dct[lst[0]];

                        break;
                    }
                case 2:
                    {
                        if (lst[0] == "dix")
                        {
                            if (dct[lst[1]] > 6 && dct[lst[1]] < 10)
                            {
                                num = 10 + dct[lst[1]];
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"dix\", второе должно быть \"sept\" или \"huit\" или \"neuf\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }

                        else if (lst[0] == "quatre")
                        {
                            if (lst[1] == "vingts")
                            {
                                num = 80;
                                return true;
                            }
                            if (lst[1] == "cents")
                            {
                                num = 400;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"quatre\", второе должно быть \"vingts\" или \"cents\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }

                        else if (dct[lst[0]] > 1 && dct[lst[0]] < 10)
                        {
                            if (lst[1] == "cents")
                            {
                                num = dct[lst[0]] * 100;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"{lst[0]}\", второе должно быть \"cents\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }

                        else if (dct[lst[0]] >= 20 && dct[lst[0]] < 60)
                        {
                            if (dct[lst[1]] >= 1 && dct[lst[1]] <= 9)
                            {
                                num = dct[lst[0]] + dct[lst[1]];
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"{lst[0]}\", второе должно быть от 1 до 9, а не \"{lst[1]}\"");
                                return false;
                            }
                        }

                        else if (dct[lst[0]] == 60)
                        {
                            if (dct[lst[1]] >= 1 && dct[lst[1]] <= 16)
                            {
                                num = dct[lst[0]] + dct[lst[1]];
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"{lst[0]}\", второе должно быть от 1 до 16, а не \"{lst[1]}\"");
                                return false;
                            }
                        }

                        else if (lst[0] == "cent")
                        {
                            if (dct[lst[1]] >= 1 && dct[lst[1]] <= 60)
                                num = 100 + dct[lst[1]];
                            else
                            {
                                MessageBox.Show($"В конструкции из двух слов при первом слове \"{lst[0]}\", второе должно быть в диапазоне 1-9 или 10-16 или десятки 20-60, а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"В конструкции из двух слов первое слово должно быть \"cent\" или \"dix\" или \"quatre\" или  в диапазоне десятков 20-60, а не \"{lst[0]}\"");
                            return false;
                        }
                        break;
                    }
                case 3:
                    {
                        if (lst[0] == "quatre")
                        {
                            if (lst[1] == "vingt")
                            {
                                if (dct[lst[2]] <= 16)
                                {
                                    num = 80 + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 1-16, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                        }
                        if (lst[0] == "soixante")
                        {
                            if (lst[1] == "dix")
                            {
                                if (dct[lst[2]] > 6 && dct[lst[2]] < 10)
                                {
                                    num = 70 + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 7-9, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из трёх слов при первом \"{lst[0]}\" второе слово должно быть\"dix\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else if (lst[0] == "cent")
                        {
                            if (lst[1] == "quatre")
                            {
                                if (lst[2] == "vingt")
                                {
                                    num = 180;
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть \"vingt\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else if (dct[lst[1]] >= 20 && dct[lst[1]] < 60)
                            {
                                if (dct[lst[2]] > 0 && dct[lst[2]] < 10)
                                {
                                    num = 100 + dct[lst[1]] + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 1-9, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else if (lst[1] == "soixante")
                            {
                                if (dct[lst[2]] > 0 && dct[lst[2]] < 17)
                                {
                                    num = 100 + dct[lst[1]] + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 1-16, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else if (lst[1] == "dix")
                            {
                                if (dct[lst[2]] > 6 && dct[lst[2]] < 10)
                                {
                                    num = 100 + 10 + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 7-9, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из трёх слов при первом \"{lst[0]}\" второе слово должно быть \"quatre\" или \"dix\" или в диапазоне десяток 20-60, а не \"{lst[1]}\"");
                                return false;
                                ///TODO 171
                            }
                        }
                        else if (dct[lst[0]] > 1 && dct[lst[0]] < 10)
                        {
                            if (lst[1] == "cent")
                            {
                                if (dct[lst[2]] <= 60)
                                {
                                    num = dct[lst[0]] * 100 + dct[lst[2]];
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из трёх слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть в диапазоне 1-16 или десяток 20-60, а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из трёх слов при первом \"{lst[0]}\" второе слово должно быть \"cents\", или если первое слово \"quatre\", то второе может еще быть \"vingt\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"В конструкции из трёх слов первое слово должно быть в диапазоне 2-9 или \"cent\", а не \"{lst[0]}\"");
                            return false;
                        }
                    }
                case 4:
                    {

                        if (dct[lst[0]] > 1 && dct[lst[0]] <10)
                        {
                            if (lst[1] == "cent")
                            {
                                if (lst[2]=="quatre")
                                {
                                    if (lst[3] == "vingt")
                                    {
                                        num = dct[lst[0]] * 100 + 80;
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть \"vingt\", а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else if (lst[2] == "dix")
                                {
                                    if (dct[lst[3]] > 6 && dct[lst[3]] < 10)
                                    {
                                        num = dct[lst[0]] * 100 + 10 + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть в диапазоне 7-9, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else if (dct[lst[2]] >=20 && dct[lst[2]] <= 50)
                                {
                                    if (dct[lst[3]] > 0 && dct[lst[3]] < 10)
                                    {
                                        num = dct[lst[0]] * 100 + dct[lst[2]] + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть в диапазоне 1-9, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else if (lst[2] == "soixante")
                                {
                                    if (dct[lst[3]] > 0 && dct[lst[3]] < 17)
                                    {
                                        num = dct[lst[0]] * 100 + dct[lst[2]] + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть в диапазоне 1-16, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из четырех слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть \"quatre\" или \"dix\" или в диапазоне десятков 20-60, а не \"{lst[3]}\"");
                                    return false;
                                }
                            }
                            else if ( lst[0]=="quatre" && lst[1] == "vingt")
                            {
                                if (lst[2] == "dix")
                                {
                                    if (dct[lst[3]] > 6 && dct[lst[3]] < 10)
                                    {
                                        num = 90 + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых двух \"{lst[0]} {lst[1]}\" четвертое слово должно быть в диапазоне 7-9, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из четырех слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть \"dix\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                 MessageBox.Show($"В конструкции из четырех слов при первом \"{lst[0]}\" второе слово должно быть \"cents\", или если первое слово \"quatre\", то второе может еще быть \"vingt\", а не \"{lst[1]}\"");
                                 return false;
                            }
                        }
                        else if (lst[0] == "cent")
                        {
                            if (lst[1] == "quatre")
                            {
                                if (lst[2] == "vingt")
                                {
                                    if (dct[lst[3]] <= 16)
                                    {
                                        num = 180 + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть в диапазоне 1-16, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из четырех слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть \"vingt\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else if (lst[1] == "soixante")
                            {
                                if (lst[2] == "dix")
                                {
                                    if (dct[lst[3]] > 6 && dct[lst[3]] < 10)
                                    {
                                        num = 170 + dct[lst[3]];
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из четырех слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвертое слово должно быть в диапазоне 7-9, а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из четырех слов при первых двух \"{lst[0]} {lst[1]}\" третье слово должно быть \"dix\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            {
                                MessageBox.Show($"В конструкции из четырех слов при первом \"{lst[0]}\" второе слово должно быть \"quatre\" или \"soixante\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"В конструкции из четырех слов первое слово должно быть \"cent\" или в диапазоне 1-9, а не \"{lst[0]}\"");
                            return false;
                        }
                    }
                case 5:
                    {
                        if (dct[lst[0]] > 1 && dct[lst[0]] < 10)
                        {
                            if (lst[1] == "cent")
                            {
                                if (lst[2] == "quatre")
                                {
                                    if (lst[3] == "vingt")
                                    {
                                        if (dct[lst[4]] < 17)
                                        {
                                            num = dct[lst[0]] * 100 + 80 + dct[lst[4]];
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show($"В конструкции из четырех слов при первых четырех \"{lst[0]} {lst[1]} {lst[2]} {lst[3]}\" пятое слово должно быть в диапазоне 1-16, а не \"{lst[4]}\"");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из пяти слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвёртое слово должно быть \"vingt\", а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else if (lst[2] == "soixante")
                                {
                                    if (lst[3] == "dix")
                                    {
                                        if (dct[lst[4]] > 6 && dct[lst[4]] < 10)
                                        {
                                            num = dct[lst[0]] * 100 + 70 + dct[lst[4]];
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show($"В конструкции из четырех слов при первых четырех \"{lst[0]} {lst[1]} {lst[2]} {lst[3]}\" пятое слово должно быть в диапазоне 7-9, а не \"{lst[4]}\"");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из пяти слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвёртое слово должно быть \"dix\", а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из пяти слов при первых двух \"{lst[0]} {lst[1]} \" третье слово должно быть \"quatre\" или \"soixante\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из пяти слов при первом \"{lst[0]}\" второе слово должно быть \"cent\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else if (lst[0] == "cent")
                        {
                            if (lst[1] == "quatre")
                            {
                                if (lst[2] == "vingt")
                                {
                                    if (lst[3] == "dix")
                                    {
                                        if (dct[lst[4]]>6 && dct[lst[4]] <10)
                                        {
                                            num = dct[lst[0]] + 90 + dct[lst[4]];
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show($"В конструкции из пяти слов при первых четырех \"{lst[0]} {lst[1]} {lst[2]} {lst[3]}\" пятое слово должно быть в диапазоне 7-9, а не \"{lst[4]}\"");
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"В конструкции из пяти слов при первых трёх \"{lst[0]} {lst[1]} {lst[2]}\" четвёртое слово должно быть \"dix\", а не \"{lst[3]}\"");
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"В конструкции из пяти слов при первых двух \"{lst[0]} {lst[1]} \" третье слово должно быть \"vingt\", а не \"{lst[2]}\"");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"В конструкции из пяти слов при первом \"{lst[0]}\" второе слово должно быть \"quatre\", а не \"{lst[1]}\"");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"В конструкции из пяти слов первое слово должно быть в диапазоне 1-9 или \"cent\", а не \"{lst[0]}\"");
                            return false;
                        }

                    }
                case 6:
                    {
                        if (dct[lst[0]]<2 && dct[lst[0]]>9)
                        {
                            MessageBox.Show($"В конструкции из шести слов первое слово должно быть в диапазоне 2-9, а не \"{lst[0]}\"");
                            return false;
                        }
                        if (lst[1]!="cent")
                        {
                            MessageBox.Show($"В конструкции из шести слов второе слово должно быть \"cent\", а не \"{lst[1]}\"");
                            return false;
                        }
                        if (lst[2] != "quatre")
                        {
                            MessageBox.Show($"В конструкции из шести слов третье слово должно быть \"quatre\", а не \"{lst[2]}\"");
                            return false;
                        }
                        if (lst[3] != "vingt")
                        {
                            MessageBox.Show($"В конструкции из шести слов четверое слово должно быть \"vingt\", а не \"{lst[3]}\"");
                            return false;
                        }
                        if (lst[4] != "dix")
                        {
                            MessageBox.Show($"В конструкции из шести слов четверое слово должно быть \"dix\", а не \"{lst[4]}\"");
                            return false;
                        }
                        if (dct[lst[5]] < 7 || dct[lst[5]] > 9)
                        {
                            MessageBox.Show($"В конструкции из шести слов последнее слово должно в диапазоне 7-9,а не \"{lst[5]}\"");
                            return false;
                        }

                        num = dct[lst[0]] * 100 + 90 + dct[lst[5]];
                        break;
                    }
            }
            return true;
        }

        private void buttonInput_Click(object sender, EventArgs e)
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
                while (varNum >= key)
                {
                    varNum -= key;
                    str += slav[key];
                }
            }
            return str;
        }
    }
}
