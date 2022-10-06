using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[][] Bike = new string[][]
            {
                new string[] { "Kayo", "K6-L", "2020 г.", "Белый"},
                new string[] {"250 см", "25 л/с", "Механика"},
                new string[] {"Кроссовый мотоцикл", "Полностью обслужен, готов к работе"},
            };
        string[][] Student = new string[][]
        {
                new string[] { "Петров", "Николай", "Иванович"},
                new string[] {"бИСТ-214", "ФЭМИТ", "2021 г.", "Бюджет"},
                new string[] {"г. Волгодонск", "17.02.2002"},
        };
        string[][] Aeroplane = new string[][]
        {
                new string[] { "Boening", "777-200", "2017 г."},
                new string[] {"Аэрофлот", "Россия"},
                new string[] {"305 чел.", "150 м3", "12200 км.", "91380 л."},
        };

        //
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Bike.Length;
            dataGridView1.ColumnCount = 4;

            for (int i = 0; i < Bike.Length; i++)
            {
                for (int j = 0; j < Bike[i].Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Bike[i][j];
                }
            }
            //
            dataGridView2.RowCount = Student.Length;
            dataGridView2.ColumnCount = 4;

            for (int i = 0; i < Student.Length; i++)
            {
                for (int j = 0; j < Student[i].Length; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = Student[i][j];
                }
            }
            //
            dataGridView3.RowCount = Aeroplane.Length;
            dataGridView3.ColumnCount = 4;

            for (int i = 0; i < Aeroplane.Length; i++)
            {
                for (int j = 0; j < Aeroplane[i].Length; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Aeroplane[i][j];
                }
            }
            button2.Enabled = true;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Bike.Length; i++)
            {
                for (int j = 0; j < Bike[i].Length; j++)
                {
                    Bike[i][j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            //
            for (int i = 0; i < Student.Length; i++)
            {
                for (int j = 0; j < Student[i].Length; j++)
                {
                    Student[i][j] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
            //
            for (int i = 0; i < Aeroplane.Length; i++)
            {
                for (int j = 0; j < Aeroplane[i].Length; j++)
                {
                    Aeroplane[i][j] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
        }
    }
}
