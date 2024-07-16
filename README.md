# Calculation-of-the-profitability-of-a-debit-deposit
Расчет доходности дебетового вклада
# Формула для расчета вклада

Для расчета вклада можно использовать формулу сложного процента, которая учитывает начисление процентов на сумму вклада за определенный период времени. Формула для расчета будущей стоимости вклада (A) выглядит следующим образом:

$$
A = P \left(1 + \frac{r}{n}\right)^{nt}
$$

Где:
- \( A \) — будущая стоимость вклада (сумма на конец периода).
- \( P \) — начальная сумма вклада.
- \( r \) — годовая процентная ставка (в десятичном виде, например, 5% = 0.05).
- \( n \) — количество начислений процентов в году.
- \( t \) — количество лет.

# Функция на языке C++

```cpp

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
```

# Интерфейс приложения
![image](https://github.com/user-attachments/assets/95e01d38-7fbb-4d62-aec7-4d62bc9bb167)

# Стек технологий

- C++
- WinForm
- .Net Framework
- CLI
- Экономика

