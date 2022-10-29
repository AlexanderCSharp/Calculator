using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Объект класса Util 
        Util util = new Util();

        // Ввод числа
        private void button_click(object sender, EventArgs e)
        {
            util.ButtonClick(textBox_Result, sender, label_opposite);
        }
        // Ввод оператора
        private void operator_click(object sender, EventArgs e)
        {
            util.OperatorCkick(textBox_Result, sender, equals);
        }
        // Кнопка "Очистить"
        private void clear_click(object sender, EventArgs e)
        {
            util.ClearClick(textBox_Result, label_opposite);
        }
        // Кнопка "Равно"
        private void equals_click(object sender, EventArgs e)
        {
            util.EqualsClick(textBox_Result, label_opposite);
        }
        // Кнопка "Плюс-минус"
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            util.PlusMinus(label_opposite);
        }
        // Закрытие калькулятора
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Свертывание калькулятора
        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Перемещение калькулятора
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            pictureBox1.Capture = false;
            label1.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        // Изменение цвета на красный при наведении на кнопку "Закрыть"
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            button11.UseVisualStyleBackColor = false;
            button11.BackColor = Color.Red;
        }
        // Возвращение цвета кнопки "Закрыть"
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            button11.UseVisualStyleBackColor = true;
        }
    }
}
