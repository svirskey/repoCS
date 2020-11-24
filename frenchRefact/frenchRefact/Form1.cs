using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frenchRefact
{
    public partial class Form1 : Form
    {
        private int num;
        private List<string> lst;
        private Dictionary<string, int> dct = null;
        private Dictionary<int, string> slav = null;
        private Dictionary<int, string> error = null;

        public Form1()
        {

        InitializeComponent();
            dct = new Dictionary<string, int>();
            slav = new Dictionary<int, string>();
            error = new Dictionary<int, string>();

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

            error.Add(0, "сотен");
            error.Add(1, "десятков");
            error.Add(2, "10-16");
            error.Add(3, "единиц");
        }

        bool GoodOrNot(int num, int add,string[] addNames, string[] names) 
        {
            var len = (add.ToString()).Length;
            int addNum;

            string addName="";

            for (int i=0; i<addNames.Length;i++)
            {
                if (addNames[i] != "")
                {
                    addName = addNames[i];
                    break;
                }                    
            }

            if (num == 0)
                return true;

            switch (len)
            {
                case 3:
                    {
                        addNum = 0;

                        if (names[0]==addName)
                        {
                            MessageBox.Show($"Два одинаковых числа \"{addName}\" формата {error[0]}");
                            return false;
                        }

                        for (int i=0; i<4;i++)
                        {
                            if (names[i] != "")
                            {
                                if (addNum==i)
                                {
                                    MessageBox.Show($"Два числа \"{names[i]}\" и \"{addName}\" одинакового формата {error[i]}");
                                    return false;
                                }
                                else
                                {
                                    MessageBox.Show($"Число \"{names[i]}\" формата {error[i]} перед числом \"{addName}\" формата {error[addNum]}");
                                    return false;
                                }
                               
                            }
                        }
                        return false;
                    }                 
                case 2:
                    {

                        if (add > 17)
                        {
                            addNum = 1;
                            if (names[1] == addName)
                            {
                                MessageBox.Show($"Два одинаковых числа \"{addName}\" формата {error[addNum]}");
                                return false;
                            }
                        }    
                        else
                            addNum = 2;

                        if (names[2] == addName)
                        {
                            MessageBox.Show($"Два одинаковых числа \"{addName}\" формата {error[addNum]}");
                            return false;
                        }


                        if (num % 100 == 0) 
                            return true;
                        else if (add > 16) // decades
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                if (names[i] != "")
                                {
                                    if (addNum == i)
                                    {
                                        MessageBox.Show($"Два числа \"{names[i]}\" и \"{addName}\" одинакового формата {error[i]}");
                                        return false;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Число \"{names[i]}\" формата {error[i]} перед числом \"{addName}\" формата {error[addNum]}");
                                        return false;
                                    }
                                }
                            }
                            return false;
                        }
                        else 
                        {
                            for (int i = 3; i >1; i--)
                            {
                                if (names[i] != "")
                                {
                                    if (addNum == i)
                                    {
                                        MessageBox.Show($"Два числа \"{names[i]}\" и \"{addName}\" одинакового формата {error[i]}");
                                        return false;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Число \"{names[i]}\" формата {error[i]} перед числом \"{addName}\" формата {error[addNum]}");
                                        return false;
                                    }
                                }
                            }
                            return false;
                        }
                    }
                case 1:
                    {
                        addNum = 3;                      

                        if (addName==names[addNum])
                        {
                            MessageBox.Show($"Два одинаковых числа \"{addName}\" формата {error[addNum]}");
                            return false;
                        }

                        if (num % 100 == 0 && num % 10 == 0) 
                            return true;
                        else
                        {
                            for (int i = 2; i < 4; i++)
                            {
                                if (names[i] != "")
                                {
                                    if (addNum == i)
                                    {
                                        MessageBox.Show($"Два числа \"{names[i]}\" и \"{addName}\" одинакового формата {error[i]}");
                                        return false;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Число \"{names[i]}\" формата {error[i]} перед числом \"{addName}\" формата {error[addNum]}");
                                        return false;
                                    }
                                }
                            }

                            return false;
                        }
                    }
            }

            return true;
        }

        private bool DoIt()
        {
            num = 0;
            string str = textBoxInput.Text.Trim();
            lst = str.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            string[] names = { "",    // hundreds 100-900
                               "",    // decades  20-90
                               "",    // f10-16   10-16
                               "" };  // units    1-9

            string[] addNames = { "",    // hundreds 100-900
                                  "",    // decades  20-90
                                  "",    // f10-16   10-16
                                  "" };  // units    1-9


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
            
            if (lst[0]=="cents" || lst[0]=="vingts")
            {
                MessageBox.Show($"\"{lst[0]}\" не может стоять в начале");
                return false;
            }

            int prev = 0;

            bool flag = true,
                 flagFirst = true;

            for (int i=0; i<lst.Count; i++)
            {
                flag = true;

                if (prev==0) // begin
                {
                    prev = dct[lst[i]];
                    flag = false;
                }
                else if (prev==4 && dct[lst[i]]==20) // 80
                {
                    prev *= dct[lst[i]];
                    flag = false;
                }
                else if ((prev==80||prev==60) && dct[lst[i]] == 10) // 70 & 90
                {
                    prev += dct[lst[i]];
                    flag = false;
                }
                else if ((prev == 80 || prev == 60) && dct[lst[i]]  <17) // 60-76 & 80-96 without 70 & 90
                {
                    prev += dct[lst[i]];
                    flag = false;
                }
                else if ((prev == 90 || prev == 70) && dct[lst[i]] > 6 && dct[lst[i]] < 10) // 77-79 & 97-99 
                {
                    prev += dct[lst[i]];
                    flag = false;
                }
                else if (prev < 10 && prev > 1 && dct[lst[i]] == 100) // 100-900
                {
                    prev *= dct[lst[i]];
                    flag = false;
                }
                else if (prev < 70 && prev % 10==0 && prev > 10 && dct[lst[i]] > 0 && dct[lst[i]] < 10) // 21-29 ... 61-69
                {
                    prev += dct[lst[i]];
                    flag = false;
                }
                else if (prev== 10 && dct[lst[i]] > 6 && dct[lst[i]] < 10) // 17-19
                {
                    prev += dct[lst[i]];
                    flag = false;
                }

                else if (i!=lst.Count-1)
                {
                    getName(addNames, prev, lst, i - 1);

                    if (flagFirst)
                    {               
                        flagFirst = false;

                        if (GoodOrNot(num, prev,addNames, names)) //TODO
                        {
                            getName(names, prev, lst, i - 1);
                            clearNames(addNames);
                            num += prev;
                            prev = dct[lst[i]];
                        }
                        else
                            return false;
                    }
                    else
                    {
                        if (GoodOrNot(num, prev,addNames, names))
                        {
                            getName(names, prev, lst, i - 1);
                            clearNames(addNames);
                            num += prev;
                            prev = dct[lst[i]];
                        }
                        else
                            return false;
                    }                  
                }

                if (i==lst.Count-1)
                {
                    if (flag)
                    {
                        getName(addNames, prev, lst, i - 1);

                        if (GoodOrNot(num, prev, addNames, names))
                        {
                            getName(names, prev, lst, i - 1);
                            clearNames(addNames);
                            num += prev;
                            prev = dct[lst[i]];

                            getName(addNames, prev, lst, i);
                        }
                        else
                            return false;

                        if (GoodOrNot(num, prev,addNames, names))
                            num += prev;
                        else
                            return false;
                    }
                    else
                    {
                        getName(addNames, prev, lst, i);

                        if (GoodOrNot(num, prev,addNames, names))
                            num += prev;
                        else
                            return false;
                    }                      
                }
            }       
            return true;
        }

        void getName(string[] names, int prev, List<string> lst,int i)
        {
            if (prev == 100)
            {
                names[0] = lst[i];
            }
            else if (prev > 100)
            {
                names[0] = lst[i - 1] + " " + lst[i];
            }
            else if (prev % 10 == 0 && prev < 70 && prev>10) 
            {
                names[1] = lst[i];
            }
            else if (prev == 80)
            {
                names[1] = lst[i - 1] + " " + lst[i];
            }
            else if (prev == 90)
            {
                names[1] = lst[i - 2] + " " + lst[i - 1];
                names[2] = lst[i];
            }
            else if (prev > 90 && prev < 97)
            {
                names[1] = lst[i - 2] + " " + lst[i - 1];
                names[2] = lst[i];
            }
            else if (prev > 96)
            {
                names[1] = lst[i - 3] + " " + lst[i - 2];
                names[2]= lst[i - 1];
                names[3] = lst[i];
            }
            else if (prev > 80 && prev < 90)
            {
                names[1] = lst[i - 2] + " " + lst[i - 1];
                names[3] = lst[i];
            }
            else if (prev > 76 && prev < 80)
            {
                names[1] = lst[i - 2];
                names[2] = lst[i - 1];
                names[3] = lst[i];
            }
            else if (prev >= 70 && prev < 77)
            {
                names[1] = lst[i - 1];
                names[2] = lst[i];
            }
            else if (prev > 20)
            {
                names[1] = lst[i - 1];
                names[3] = lst[i];
            }
            else if (prev > 16)
            {
                names[2] = lst[i - 1];
                names[3] = lst[i];
            }
            else if (prev >= 10)
            {
                names[2] = lst[i];
            }
            else
            {
                names[3] = lst[i];
            }
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

        private void clearNames(string[] names)
        {
            for (int i=0; i<names.Length;i++)
                names[i] = "";
        }
    }
}

