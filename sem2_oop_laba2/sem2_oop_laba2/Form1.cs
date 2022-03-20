using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2_oop_laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selector = comboBox1.SelectedItem.ToString();

            if (selector == "ИСиТ")
            {

                tabPage2.Controls.Clear();
                CheckBox group1 = new CheckBox();
                        group1.Text = "1";
                        group1.Location = new Point(5, 5);
                        group1.Width = 27;
                        tabPage2.Controls.Add(group1);
                        CheckBox group2 = new CheckBox();
                        group2.Text = "2";
                        group2.Location = new Point(35, 5);
                        group2.Width = 27;
                        tabPage2.Controls.Add(group2);
                        CheckBox group3 = new CheckBox();
                        group3.Text = "3";
                        group3.Location = new Point(65, 5);
                        group3.Width = 27;
                        tabPage2.Controls.Add(group3);
                      
              
                
            }
            if (selector == "ПОИТ")
            {

                tabPage2.Controls.Clear();
                CheckBox group4 = new CheckBox();
                        group4.Text = "4";
                        group4.Location = new Point(5, 5);
                        group4.Width = 27;
                        tabPage2.Controls.Add(group4);
                        CheckBox group5 = new CheckBox();
                        group5.Text = "5";
                        group5.Location = new Point(35, 5);
                        group5.Width = 27;
                        tabPage2.Controls.Add(group5);
                        CheckBox group6 = new CheckBox();
                        group6.Text = "6";
                        group6.Location = new Point(65, 5);
                        group6.Width = 27;
                        tabPage2.Controls.Add(group6);
                     
                
            }
            if (selector == "ПОИБМС")
            {

                tabPage2.Controls.Clear();
                CheckBox group7 = new CheckBox();
                        group7.Text = "7";
                        group7.Location = new Point(5, 5);
                        group7.Width = 27;
                        tabPage2.Controls.Add(group7);
                        CheckBox group8 = new CheckBox();
                        group8.Text = "8";
                        group8.Location = new Point(35, 5);
                        group8.Width = 27;
                        tabPage2.Controls.Add(group8);
                   
                        
      
            }
            if (selector == "ДЭиВИ")
            {
                tabPage2.Controls.Clear();
                CheckBox group9 = new CheckBox();
                        group9.Text = "9";
                        group9.Location = new Point(5, 5);
                        group9.Width = 27;
                        tabPage2.Controls.Add(group9);
                        CheckBox group10 = new CheckBox();
                        group10.Text = "10";
                        group10.Location = new Point(35, 5);
                        group10.Width = 40;
                        tabPage2.Controls.Add(group10);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
