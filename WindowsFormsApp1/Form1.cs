
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
try
            {
                // Чтение данных из текстовых полей
                double principal = Convert.ToDouble(textBox1.Text);
                double rate = Convert.ToDouble(textBox2.Text) / 100;
                int years = Convert.ToInt32(textBox3.Text);

                // Расчет итоговой суммы
                double finalAmount = principal * Math.Pow((1 + rate), years);

                // Отображение результата
                label4.Text = "Итоговая сумма: "
                    + finalAmount.ToString("C2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.");
            }
        }
    }
}
