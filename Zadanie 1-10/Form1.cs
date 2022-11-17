using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1_10
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
                                // вызываем внутреннюю функцию Inner
            Action Outer()  // метод или внешняя функция
            {
                int x = 0;  // лексическое окружение - локальная переменная
                void Inner()    // локальная функция
                {
                    x++;        // операции с лексическим окружением
                    this.listBox1.Items.Add(x);
                }
                return Inner;   // возвращаем локальную функцию
            }
            for (int x = 0; x < 10; x++)
            {
                fn();
            }
        }
    }
}
