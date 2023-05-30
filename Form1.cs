using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct popul
        {
            public int num;
            public int age;

            public popul(int num, int age)
            {
                this.num = num;
                this.age = age;
            }
        }
        Random rnd = new Random();
        popul[] nasel;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int r = rnd.Next(15, 100);
            nasel = new popul[r];

            for (int i = 0; i < nasel.Length; i++)
            {
                
                int a = rnd.Next(1930, 2024);

                nasel[i] = new popul(i, a);
                // У жителей можно добавить фамилию и имя.
                listBox1.Items.Add($"Житель {i + 1}: {a}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int other = int.Parse(textBox1.Text);
            listBox2.Items.Add($"Люди, родившиеся после {other}:");
            int count = 0;
            for (int i = 0; i < nasel.Length; i++)
            {

                int age = nasel[i].age;
                if (age > other)
                {
                    listBox2.Items.Add($"Житель {i + 1}: {age}");

                    count++;
                    
                }
            }
            MessageBox.Show($"Всего людей, родившихся после {other}: {count}");
        }
    }
}
