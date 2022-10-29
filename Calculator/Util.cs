using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public class Util
    {
        string operatorSelected = ""; // Выбранный оператор
        bool isOperationSelected = false; // Выбран ли оператор
        bool isnum1 = false; // Введено ли первое число
        bool isnum2 = false; // Введено ли второе число
        bool calculations = false; // Производилось ли вычисление
        bool plus_minus = true; // Знак положительный(true)  или отрицательный(false)
        double num1, num2; // Переменные для расчета
        double resultValue; // Конечный результат
        // Ввод числа на табло
        public void ButtonClick(TextBox textBox_Result, object sender, Label label_opposite)
        {
            if (textBox_Result.Text == "000000000")
            {
                textBox_Result.Clear(); // Стираем табло
                label_opposite.Text = ""; // Стираем минус
            }
            if(isnum1)
            {
                isnum1 = false;
                isnum2 = true;
            }
            if(textBox_Result.TextLength < 9 || isOperationSelected)
            {
                if(isOperationSelected)
                {
                    textBox_Result.Clear();
                    label_opposite.Text = "";
                    isOperationSelected = false;
                }
                textBox_Result.Text += (sender as Button).Text;
            }
        }
        // Ввод оператора
        public void OperatorCkick(TextBox textBox_Result, object sender, Button equals)
        {
            if (!isnum2)
            {
                operatorSelected = (sender as Button).Text;
            }
            if (!calculations)
            {
                num1 = double.Parse(textBox_Result.Text);
                if(!plus_minus)
                {
                    num1 *= -1;
                }
                calculations = true;
                plus_minus = true;
                isnum1 = true;
                isOperationSelected = true;
            }
            if(isnum2)
            {
                equals.PerformClick(); // Имметируем нажатие "Равно"
                num1 = double.Parse(textBox_Result.Text);
                if (!plus_minus)
                {
                    num1 *= -1;
                }
                calculations = true;
                plus_minus = true;
                isnum1 = true;
                isOperationSelected = true;
                operatorSelected = (sender as Button).Text;
            }
        }
        // Кнопка "Очистить"
        public void ClearClick(TextBox textBox_Result, Label label_opposite)
        {
            textBox_Result.Text = "000000000";
            label_opposite.Text = "-";
            plus_minus = true;
            isOperationSelected = false;
            calculations = false;
            isnum1 = false;
            isnum2 = false; 
        }
        // Кнопка "Равно"
        public void EqualsClick(TextBox textBox_Result, Label label_opposite)
        {
            if (calculations && isnum2)
            {
                IntermediateValue(textBox_Result, label_opposite);
            }
        }
        // Вычисление  
        public void IntermediateValue(TextBox textBox_Result, Label label_opposite)
        {
            num2 = double.Parse(textBox_Result.Text); 
            if(!plus_minus)
            {
                num2 *= -1;
                plus_minus = true;
            }
            switch (operatorSelected)
            {
                case "+":
                    resultValue = num1 + num2;
                    ShowInTextbox(textBox_Result);
                    break;
                case "-":
                    resultValue = num1 - num2;
                    ShowInTextbox(textBox_Result);
                    break;
                case "×":
                    resultValue = num1 * num2;
                    ShowInTextbox(textBox_Result);
                    break;
                case "÷":
                    if (num2 != 0)
                    {
                        resultValue = num1 / num2;
                        ShowInTextbox(textBox_Result);
                    }
                    else textBox_Result.Text = "NOT ÷ 0";
                    break;
                default:
                    break;
            }     
            if (resultValue < 0)
            {
                label_opposite.Text = "-";
                plus_minus = false;
            }
            if (resultValue <= 0)
            {
                label_opposite.Text = "";
            }
            if(textBox_Result.TextLength > 9)
            {
                textBox_Result.Text = "EXCEEDED";
            }
            calculations = false;
            isnum2 = false;
            plus_minus = true;
        }
        // Смена знака числа
        public void PlusMinus(Label label_opposite)  
        {
            if (plus_minus)
            {
                label_opposite.Text = "-";
                plus_minus = false;
            }
            else if (!plus_minus)
            {
                label_opposite.Text = "";
                plus_minus = true;
            }
        }
        // Округление и запись ответа в тексбокс
        public void ShowInTextbox(TextBox textBox_Result) 
        {
            textBox_Result.Text = Math.Round(resultValue, 2).ToString();
        }
    } 
}
