using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Queue<int> queue;
        
        public Form1()
        {
            InitializeComponent();
            queue = new Queue<int>();
           
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            MessageBox.Show("Очередь заполнена!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0) 
            {
                MessageBox.Show("Очередь пуста!");
                return;
            }

            int number = queue.Dequeue(); 
            MessageBox.Show("Из очереди извлечено число: " + number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string[] lines = File.ReadAllLines("people.txt");
            if (lines.Length==0)
            {
                MessageBox.Show("Файл пуст");
            }
            else
            {
                foreach (string line in lines)
                {
                    Queue<double> vozr = new Queue<double>();
                    string[] parts = line.Split(' ');
                    vozr.Enqueue(double.Parse(parts[3]));



                    if (vozr.Dequeue() < 40)
                    {
                        listBox1.Items.Add(line.ToString());
                    }
                    else
                    {
                        listBox2.Items.Add(line.ToString());
                    }
                }
            }
            


        }
    }
}
