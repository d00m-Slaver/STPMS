using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2_oop_laba_1
{
    public partial class Form1 : Form 
    {
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void MyDelegate();
        public event MyDelegate StartAll;

        public void start()
        {
            StartAll.Invoke();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton1;
            try
            {
                if (textBox1.Text=="" && textBox2.Text=="")
                {
                    MessageBox.Show("Вы не ввели данные.");
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите какую подстроку хотите заменить.");
                }
                else if(textBox2.Text == "")
                {
                    MessageBox.Show("Введите на какую строку нужно изменить.");
                }
                else
                {
                    string podstr = textBox1.Text;
                    string zamena = textBox2.Text;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = $"Произведена замена : {calc.Change(podstr,zamena)}";
                } 
            }
            catch (Exception t)
            {
                MessageBox.Show($"Ошибка : {t.Message}");
            }

        }

        private void Form1_Startbutton1()
        {
            textBox7.Text += "Кнопка 1 была нажата\n";
        }
        private void Form1_Startbutton2()
        {
            textBox7.Text += "Кнопка 2 была нажата\n";
        }
        private void Form1_Startbutton3()
        {
            textBox7.Text += "Кнопка 3 была нажата\n";
        }
        private void Form1_Startbutton4()
        {
            textBox7.Text += "Кнопка 4 была нажата\n";
        }
        private void Form1_Startbutton5()
        {
            textBox7.Text += "Кнопка 5 была нажата\n";
        }
        private void Form1_Startbutton6()
        {
            textBox7.Text += "Кнопка 6 была нажата\n";
        }
        private void Form1_StartLoad()
        {
            textBox7.Text += "Форма была загружена\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button newButton1 = new Button();
            newButton1.BackColor = Color.White;
            newButton1.Location = new Point(50, 250);
            newButton1.Text = "кнопка";
            this.Controls.Add(newButton1);
            StartAll += Form1_StartLoad;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calc.VPos = textBox6.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton4;
            try
            {
                if (radioButton1.Checked)
                {
                    StartAll += Form1_Check1;
                    if (calc.VPos==null)
                    {
                        return;
                    }
                    else
                    {
                        string strChecker = calc.VPos;
                        strChecker.ToLower();
                        int kolvo=0;
                        foreach (char item in strChecker)
                        {
                            for (int i = 0; i < calc.ArrayG.Length; i++)
                            {
                                if (item == calc.ArrayG[i])
                                {
                                    kolvo++;
                                }
                            }
                        }
                        textBox5.Text = $"Количество гласных : {kolvo}";
                    }
                }
                else if (radioButton2.Checked)
                {
                    StartAll += Form1_Check2;
                    if (calc.VPos == null)
                    {
                        return;
                    }
                    else
                    {

                        string strChecker = calc.VPos;
                        strChecker.ToLower();
                        int kolvo = 0;
                        foreach (char item in strChecker)
                        {
                            for (int i = 0; i < calc.ArrayS.Length; i++)
                            {
                                if (item == calc.ArrayS[i])
                                {
                                    kolvo++;
                                }
                            }
                        }
                        textBox5.Text = $"Количество согласных : {kolvo}";
                    }
                }
                else if (radioButton3.Checked)
                {
                    StartAll += Form1_Check3;
                    if (calc.VPos == null)
                    {
                        return;
                    }
                    else
                    {
                        string strChecker = calc.VPos;
                        strChecker.ToLower();
                        strChecker.Trim();
                        int kolvo = 0;
                        bool flag = false;
                        foreach (char item in strChecker)
                        {
                            if (flag == false)
                            {
                                for (int i = 0; i < calc.ArrayG.Length; i++)
                                {
                                    if (item == calc.ArrayG[i])
                                    {
                                        flag = true;
                                        kolvo++;
                                    }
                                }
                                for (int i = 0; i < calc.ArrayS.Length; i++)
                                {
                                    if (item == calc.ArrayS[i])
                                    {
                                        flag = true;
                                        kolvo++;
                                    }
                                }
                            }
                            else
                            {
                                if (item == '?' || item == '!' || item == '.')
                                {
                                    flag = false;
                                }
                            }

                        }
                        textBox5.Text = $"Количество предложение : {kolvo}";
                    }
                }
                else if (radioButton4.Checked)
                {
                    StartAll += Form1_Check4;
                    if (calc.VPos == null)
                    {
                        return;
                    }
                    else
                    {

                        string strChecker = calc.VPos;
                        strChecker.ToLower();
                        int kolvo = 0;
                        bool flag = false;
                        foreach (char item in strChecker)
                        {
                            if (flag==false)
                            {
                                for (int i = 0; i < calc.ArrayG.Length; i++)
                                {
                                    if (item == calc.ArrayG[i])
                                    {
                                        flag = true;
                                        kolvo++;
                                    }
                                }
                                for (int i = 0; i <calc.ArrayS.Length; i++)
                                {
                                    if (item == calc.ArrayS[i])
                                    {
                                        flag = true;
                                        kolvo++;
                                    }
                                }
                            }
                            else
                            {
                                if (item == ' ')
                                {
                                    flag = false;
                                }
                            }

                        }
                        textBox5.Text = $"Количество слов : {kolvo}";
                    }
                }
                else if (radioButton5.Checked)
                {
                    textBox5.Text = $"Длина строки : {calc.VPos.Length}";
                }
            }
            catch (Exception t)
            {
                MessageBox.Show($"Ошибка : {t.Message}");
            }
            
        }

        private void Form1_Check1()
        {
            textBox7.Text += "Выбран чекбокс 1";
        }
        private void Form1_Check2()
        {
            textBox7.Text += "Выбран чекбокс 2";
        }
        private void Form1_Check3()
        {
            textBox7.Text += "Выбран чекбокс 3";
        }
        private void Form1_Check4()
        {
            textBox7.Text += "Выбран чекбокс 4";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton2;
            try
            {
                if (textBox1.Text=="")
                {
                    MessageBox.Show("Введите подстроку для удаления.");
                }
                else
                {
                    string delStr = textBox1.Text;

                    textBox3.Text=$"Произведено удаление {calc.Del(delStr)}";
                }
            }
            catch (Exception t)
            {

                MessageBox.Show($"Ошибка : {t.Message}");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton5;
            if (calc.VPos == null || calc.VPos == "")
            {
                textBox3.Text = "Строка пуста";
            }
            else
            {
                textBox3.Text = calc.VPos;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton3;
            try
            {
                
                int number =Convert.ToInt32(textBox4.Text);

                string strChecker = calc.VPos;

                if (number > strChecker.Length)
                {
                    MessageBox.Show($"Введите значение меньше или равное {strChecker.Length}");
                }
                else
                {
                    textBox3.Text = $"Символ  \"{calc.Take(number)}\" с индексом {number}";
                }
            }
            catch (Exception t)
            {

                MessageBox.Show($"Ошибка : {t.Message}");
            }
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartAll += Form1_Startbutton6;
            if (calc.VPos!=null)
            {
                start();
            }
        }
    }
}
