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

namespace prKol_ind_FormsZuev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "slova.txt";
            textBox1.Text = fileName;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length < 2)
            {
                MessageBox.Show("В файле должно быть минимум 2 строки! Понял?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s1 = lines[0];
            string s2 = lines[1];
            label1.Text = s1;
            label2.Text = s2;

            bool result = IsReverse.Reverse(s1, s2);
            if (result)
            {
                MessageBox.Show("Да, вторая строка является обратной первой" , "Результат", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Нет, вторая строка НЕ является обратной первой", "Результат", MessageBoxButtons.OK);
            }
            
        }

        
    }
}
    

