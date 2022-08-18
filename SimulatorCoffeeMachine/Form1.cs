using System;
using System.Windows.Forms;
using ClassLibrarySimulatorCofeeMachine;

namespace SimulatorCoffeeMachine
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Espresso Coffee button
        //
        //        
        private void button1_Click(object sender, EventArgs e)
        {
            string coffe_sugar = new CustomerSmall().CustomerWantEspressoWithSugar50();
            string coffe = new CustomerSmall().CustomerWantEspresso50();

            button_MonoFunction(coffe_sugar, coffe);

            
            button1.Image = Properties.Resources.Espresso_Small_light;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;

            ProgressBar(60);
        }

        //Doppio Coffee button
        //
        //
        private void button2_Click(object sender, EventArgs e)
        {
            string coffe_sugar = new CustomerSmall().CustomerWantDoppioWithSugar100();
            string coffe = new CustomerSmall().CustomerWantDoppio100();

            
            button_MonoFunction(coffe_sugar, coffe);

        ///Здесь просто выполняется смена картинок интерфейса
        ///
        
            button1.Enabled = false;
            button2.Image = Properties.Resources.Doppio_SMALL_lignt;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;
        
        ///Здесь просто выполняется визуализация процесса приготовления кофе. 
        ///Элемент UI
            ProgressBar(60);
        }

        //Capuccino Coffee button
        //
        //
        private void button3_Click(object sender, EventArgs e)
        {
            string coffeBig_sugar = new Customer().CustomerWantCappuccinoWithSugar300();
            string coffeBig = new Customer().CustomerWantCappuccino300();
            string coffeSmall_sugar = new CustomerSmall().CustomerWantCappuccinoWithSugar150();
            string coffeSmall = new CustomerSmall().CustomerWantCappuccino150();

            button_Function(coffeBig_sugar, coffeBig, coffeSmall_sugar, coffeSmall);

            //Обработка состояния кнопок после нажатия активной кнопки

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Image = Properties.Resources.Cappuccino_SMALL;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;

         ///Здесь просто выполняется визуализация процесса приготовления кофе. 
         ///Элемент UI
            ProgressBar(60);
        }

        //Macciato Coffee button
        //
        //   
        private void button4_Click(object sender, EventArgs e)
        {
            string coffeBig_sugar = new Customer().CustomerWantMacciatoWithSugar300();
            string coffeBig = new Customer().CustomerWantMacciato300();
            string coffeSmall_sugar = new CustomerSmall().CustomerWantMacciatoWithSugar150();
            string coffeSmall = new CustomerSmall().CustomerWantMacciato150();

            button_Function(coffeBig_sugar, coffeBig, coffeSmall_sugar, coffeSmall);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Image = Properties.Resources.Macchiato_SMALL;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;

        ///Здесь просто выполняется визуализация процесса приготовления кофе. 
        ///Элемент UI
            ProgressBar(60);
        }

        //Raf Coffee button
        //
        //   
        private void button5_Click(object sender, EventArgs e)
        {
            string coffeBig_sugar = new Customer().CustomerWantRafWithSugar300();
            string coffeBig = new Customer().CustomerWantRaf300();
            string coffeSmall_sugar = new CustomerSmall().CustomerWantRafWithSugar150();
            string coffeSmall = new CustomerSmall().CustomerWantRaf150();

            button_Function(coffeBig_sugar, coffeBig, coffeSmall_sugar, coffeSmall);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Image = Properties.Resources.Raf_SMALL;
            button6.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;

        ///Здесь просто выполняется визуализация процесса приготовления кофе. 
        ///Элемент UI
            ProgressBar(60);
        }

        //Corretto Coffee button
        //
        //     

        private void button6_Click(object sender, EventArgs e)
        {
            string sugar = comboBox1.Text;
            string porcion = comboBox2.Text;
            string coffeBig_sugar = new Customer().CustomerWantCorrettoWithSugar300();
            string coffeBig = new Customer().CustomerWantCorretto300();
            string coffeSmall_sugar = new CustomerSmall().CustomerWantCorrettoWithSugar150();
            string coffeSmall = new CustomerSmall().CustomerWantCorretto150();

            button_Function(coffeBig_sugar, coffeBig, coffeSmall_sugar, coffeSmall);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Image = Properties.Resources.Raf_SMALL;
            button7.Enabled = true;
            button8.Enabled = false;

        ///Здесь просто выполняется визуализация процесса приготовления кофе. 
        ///Элемент UI
            ProgressBar(60);
        }

        //Take Coffee button
        //
        //

        // Смена картинок кнопок в исходное положение
        //
        //
        private void button7_Click(object sender, EventArgs e)
        {


            progressBar1.Value = 0;
            pictureBox1.Image = Properties.Resources.VibCoffee;
            richTextBox1.Clear();
            button1.Image = Properties.Resources.Espresso_SMALL_dark;
            button1.Enabled = true;
            button2.Image = Properties.Resources.Doppio_SMALL_dark;
            button2.Enabled = true;
            button3.Image = Properties.Resources.Cappuccino_SMALL_dark;
            button3.Enabled = true;
            button4.Image = Properties.Resources.Macchiato_SMALL_dark;
            button4.Enabled = true;
            button5.Image = Properties.Resources.Raf_SMALL_dark;
            button5.Enabled = true;
            button6.Image = Properties.Resources.Corretto_SMALL_dark;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }


        //Close button
        //
        //
        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        //Метод цикла обработки вариантов сочетания Комбобоксов для напитков из 4-х вариантов
        //
        //
        public void button_Function(string coffeBig_sugar, string coffeBig, string coffeSmall_sugar, string coffeSmall)
        {
            string sugar = comboBox1.Text;
            string porcion = comboBox2.Text;

            if (porcion == "Стакан 350 г")
            {
                if (sugar == "С сахаром")
                {
                    richTextBox1.Text = coffeBig_sugar;
                }
                else if (sugar == "Без сахара")
                {
                    richTextBox1.Text = coffeBig;
                }
                else
                {
                    richTextBox1.Text = coffeBig;
                }
            }

            else if (porcion == "Стакан 200 г")
            {
                if (sugar == "С сахаром")
                {
                    richTextBox1.Text = coffeSmall_sugar;
                }
                else if (sugar == "Без сахара")
                {
                    richTextBox1.Text = coffeSmall;
                }
                else
                {
                    richTextBox1.Text = coffeSmall;
                }
            }

            else if (sugar == "С сахаром")
            {
                richTextBox1.Text = coffeSmall_sugar;
            }
            else if (sugar == "Без сахара")
            {
                richTextBox1.Text = coffeSmall;
            }

            else
            {
                richTextBox1.Text = coffeSmall;
            }
        }
        //Функция моно. Для эспрессо и Доппио
        //
        //
        public void button_MonoFunction(string coffe_sugar, string coffe)
        {
            string sugar = comboBox1.Text;
            string porcion = comboBox2.Text;

            if (porcion == "Стакан 350 г")
            {
                if (sugar == "С сахаром")
                {
                    richTextBox1.Text = coffe_sugar;
                }
                else if (sugar == "Без сахара")
                {
                    richTextBox1.Text = coffe;
                }
                else
                {
                    richTextBox1.Text = coffe;
                }
            }

            else if (porcion == "Стакан 200 г")
            {
                if (sugar == "С сахаром")
                {
                    richTextBox1.Text = coffe_sugar;
                }
                else if (sugar == "Без сахара")
                {
                    richTextBox1.Text = coffe;
                }
                else
                {
                    richTextBox1.Text = coffe;
                }
            }

            else if (sugar == "С сахаром")
            {
                richTextBox1.Text = coffe_sugar;
            }
            else if (sugar == "Без сахара")
            {
                richTextBox1.Text = coffe;
            }

            else
            {
                richTextBox1.Text = coffe;
            }
        }

        ///Обработка анимации UI
        ///
        ///
        public void ProgressBar(int paramPB)
        {
            progressBar1.Maximum = paramPB;
            for (int i = 0; i <= 60; i++)
            {
                progressBar1.Value = i;
            }

            pictureBox1.Image = Properties.Resources.AnimatedCup;
        }
    }
}
