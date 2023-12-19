using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadApp
{
    public partial class Form1 : Form
    {
        private Thread numberThread;
        private Thread letterThread;
        private Thread symbolThread;
        private CancellationTokenSource tokenSource;//флаг для остановки потоков
      
        public Form1()
        {
            InitializeComponent();

            panelNumbers.Controls.Add(rbNumbersHigh); // радикнопки на трех панелях
            panelNumbers.Controls.Add(rbNumbersNormal);
            panelNumbers.Controls.Add(rbNumbersLow);
            this.Controls.Add(panelNumbers);
            panelLetters.Controls.Add(rbLettersHigh);
            panelLetters.Controls.Add(rbLettersNormal);
            panelLetters.Controls.Add(rbLettersLow);
            this.Controls.Add(panelLetters);
            panelSymbols.Controls.Add(rbSymbolsHigh);
            panelSymbols.Controls.Add(rbSymbolsNormal);
            panelSymbols.Controls.Add(rbSymbolsLow);
            this.Controls.Add(panelSymbols);


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
          
            if (numberThread == null || !numberThread.IsAlive)
            {
                numberThread = new Thread(GenerateNumbers);// создаем поток 
                numberThread.Priority = GetThreadPriority();//получаем приоритетность
                numberThread.Start();//запускаем поток
            }

            if (letterThread == null || !letterThread.IsAlive)
            {
                letterThread = new Thread(GenerateLetters);
                letterThread.Priority = GetThreadPriority();
                letterThread.Start();
            }

            if (symbolThread == null || !symbolThread.IsAlive)
            {
                symbolThread = new Thread(GenerateSymbols);
                symbolThread.Priority = GetThreadPriority();
                symbolThread.Start();
            }
        }

        private void GenerateNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                if (tokenSource.IsCancellationRequested)
                    break;
                int number = random.Next(0, 100);
                listBox1.BeginInvoke((MethodInvoker)delegate {
                    listBox1.Items.Add(number);//вывод на форму 
                });
                Thread.Sleep(400);
            }
        }

        private void GenerateLetters()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (tokenSource.IsCancellationRequested)
                    break;
                listBox2.BeginInvoke((MethodInvoker)delegate {
                    listBox2.Items.Add(c);//вывод на форму 
                });
                Thread.Sleep(400);
            }
        }

        private void GenerateSymbols()
        {
            string symbols = "!@#$%^&*()%*}{[]/><";
            Random random = new Random();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (tokenSource.IsCancellationRequested)
                    break;
                char symbol = symbols[random.Next(0, symbols.Length)];
                listBox3.BeginInvoke((MethodInvoker)delegate {
                    listBox3.Items.Add(symbol);//вывод на форму 
                });
                Thread.Sleep(400);
            }
        }

        private ThreadPriority GetThreadPriority()// метод возврата приоритетности
        {
           
            if (rbNumbersHigh.Checked)
            {
                rbLettersHigh.Checked = false;
                rbSymbolsHigh.Checked = false;
                return ThreadPriority.Highest;
            }
            else if (rbLettersHigh.Checked)
            {
                rbNumbersHigh.Checked = false;
                rbSymbolsHigh.Checked = false;
                return ThreadPriority.Highest;
            }
            else if (rbSymbolsHigh.Checked)
            {
                rbNumbersHigh.Checked = false;
                rbLettersHigh.Checked = false;
                return ThreadPriority.Highest;
            }

            if (rbNumbersLow.Checked)
            {
                rbLettersLow.Checked = false;
                rbSymbolsLow.Checked = false;
                return ThreadPriority.Lowest;
            }
            else if (rbSymbolsLow.Checked)
            {
                rbNumbersLow.Checked = false;
                rbLettersLow.Checked = false;
                return ThreadPriority.Lowest;
            }
            else if (rbLettersLow.Checked)
            {
                rbNumbersLow.Checked = false;
                rbSymbolsLow.Checked = false;
                return ThreadPriority.Lowest;
            }
            else
                return ThreadPriority.Normal; // По умолчанию устанавливаем обычный приоритет
        }
        //Кнопка СТОП
        private void button1_Click(object sender, EventArgs e)
        {
          
            tokenSource?.Cancel(); // отмена токена для остановки всех потоков
          
        }

        private void rbNumbersHigh_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNumbersHigh.Checked)
            {//Если выбрали эту кнопку, то приоритет высокий
                if (numberThread != null && numberThread.IsAlive)// если поток есть
                {
                    numberThread.Priority = ThreadPriority.Highest;// устанавливаем высокий приоритет
                    rbNumbersLow.Checked = false;// остальной выбор  отключен
                    rbNumbersNormal.Checked = false;
                    rbLettersHigh.Checked = false;
                    rbSymbolsHigh.Checked = false;
                }
            }
        }

        private void rbNumbersNormal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNumbersNormal.Checked)// все то же самое....
            {
                if (numberThread != null && numberThread.IsAlive)
                {
                    numberThread.Priority = ThreadPriority.Normal;
                    rbNumbersLow.Checked = false;
                    rbNumbersHigh.Checked = false;
                    rbLettersNormal.Checked = false;
                    rbSymbolsNormal.Checked = false;
                }
            }
        }

        private void rbNumbersLow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNumbersLow.Checked)
            {
                if (numberThread != null && numberThread.IsAlive)
                {
                    numberThread.Priority = ThreadPriority.Lowest;
                    rbNumbersNormal.Checked = false;
                    rbNumbersHigh.Checked = false;
                    rbLettersLow.Checked = false;
                    rbSymbolsLow.Checked = false;
                }
            }
        }

        private void rbLettersHigh_CheckedChanged_1(object sender, EventArgs e)
        {
            if (letterThread != null && letterThread.IsAlive)// если поток есть
            {
                letterThread.Priority = ThreadPriority.Highest;// устанавливаем высокий приоритет
                rbLettersLow.Checked = false;
                rbLettersNormal.Checked = false;
                rbNumbersHigh.Checked = false;
                rbSymbolsHigh.Checked = false;

            }
        }

        private void rbLettersNormal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (letterThread != null && letterThread.IsAlive)// если поток есть
            {
                letterThread.Priority = ThreadPriority.Normal;
                rbLettersLow.Checked = false;
                rbLettersHigh.Checked = false;
                rbNumbersNormal.Checked = false;
                rbSymbolsNormal.Checked = false;
            }
        }

        private void rbLettersLow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (letterThread != null && letterThread.IsAlive)// если поток есть
            {
                letterThread.Priority = ThreadPriority.Lowest;
                rbLettersNormal.Checked = false;
                rbLettersHigh.Checked = false;
                rbNumbersLow.Checked = false;
                rbSymbolsLow.Checked = false;
            }

        }

        private void rbSymbolsHigh_CheckedChanged_1(object sender, EventArgs e)
        {
            if (symbolThread != null && symbolThread.IsAlive)// если поток есть
            {
                symbolThread.Priority = ThreadPriority.Highest;
                rbSymbolsLow.Checked = false;
                rbSymbolsNormal.Checked = false;
                rbNumbersHigh.Checked = false;
                rbLettersHigh.Checked = false;
            }
        }

        private void rbSymbolsNormal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (symbolThread != null && symbolThread.IsAlive)// если поток есть
            {
                symbolThread.Priority = ThreadPriority.Normal;
                rbSymbolsLow.Checked = false;
                rbSymbolsHigh.Checked = false;
                rbNumbersNormal.Checked = false;
                rbLettersNormal.Checked = false;
            }
        }

        private void rbSymbolsLow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (symbolThread != null && symbolThread.IsAlive)// если поток есть
            {
                symbolThread.Priority = ThreadPriority.Lowest;
                rbSymbolsNormal.Checked = false;
                rbSymbolsHigh.Checked = false;
                rbNumbersLow.Checked = false;
                rbLettersLow.Checked = false;
            }
        }
      
    }
}
