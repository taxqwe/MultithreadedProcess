using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Threading;

namespace KRPETROVDRAGUTAN
{
    public partial class MainForm : Form
    {
        //Переменные хранящие в себе загруженность процессора и памяти
        public int processorLoad;
        public int memoryLoad;

        //Лист с ядрами и информацией и них
        List<PerformanceCounter> pCForCores = new List<PerformanceCounter>();

        //Шрифт
        Font textFont = new System.Drawing.Font("Times New Roman", 8, FontStyle.Bold);

        //Кисть
        Brush textBrush = new SolidBrush(Color.LimeGreen);

        //Набор точек для отрисовки графика загруженности ЦП
        Point[] pcPoints = new Point[11];

        //Слежение за текущей точкой на графике
        int pointNumber = 0;

        //Потоки для проведения тестов
        Thread newThread_1;

        Thread newThread_2_1;
        Thread newThread_2_2;

        Thread newThread_3_1;
        Thread newThread_3_2;
        Thread newThread_3_3;
        Thread newThread_3_4;

        Thread newThread_4_1;
        Thread newThread_4_2;
        Thread newThread_4_3;
        Thread newThread_4_4;
        Thread newThread_4_5;
        Thread newThread_4_6;
        Thread newThread_4_7;
        Thread newThread_4_8;

        //Статусы выполнения тестов
        bool firstTest_status_bool = false;
        bool secondTest_status_bool = false;
        bool firthTest_status_bool = false;
        bool fourthTest_status_bool = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Получаем лист с процессами и добавляем их в ListBox
            var listOfProcesses = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            listBoxOfProcesses.Items.Add("ID " + "\t" + "Процесса :" + "\t" + "Имя процесса :" + "\t\t" + "Занимаемая память (КБайт) :");
            foreach (var p in listOfProcesses)
            {
                listBoxOfProcesses.Items.Add("PID: " +  "\t" + p.Id + "\t\t" + p.ProcessName + "\t\t\t" + (p.WorkingSet64/1024)+ "\t\t");
            }

            //Получаем информацию о загруженности ядер ЦП
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                pCForCores.Add(new PerformanceCounter("Процессор", "% загруженности процессора", i.ToString()));
            }

            //иницилизируем первою точку отрисовки графика загруженности ЦП
            pcPoints[0].X = 0;
            pcPoints[0].Y = 400;

            //Количество физических и логических ядер: 
            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            amountOfPCores.Text = "Количество физических ядер : " + coreCount.ToString();
            amountOfLCores.Text = "Количество логических ядер : " + Environment.ProcessorCount.ToString();

            var s = new ManagementObjectSearcher(@"SELECT * FROM Win32_processor");
            var o = s.Get().OfType<ManagementObject>().First();
            label15.Text = "Скорость процессора : " + o["CurrentClockSpeed"] + " Гц";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            //Обновление различной информации
            label13.Text = "Количество свободной памяти : " + pcMemoryFreeMB.NextValue().ToString() + " МБ";
            label10.Text = "Ввод страниц/сек : " + pcMemoryCin.NextValue().ToString();
            label11.Text = "Вывод страниц/сек : " + pcMemoryCout.NextValue().ToString();
            label12.Text = "Чтений страниц/с : " + performanceCread.NextValue().ToString();
            label14.Text = "Количество процессов : " + Process.GetProcesses().Length;

            //Получаем информацию о загруженности ЦП и выводим её
            processorLoad = (int)pcProcessor.NextValue();
            pcProcessorProgressBar.Value = processorLoad;
            pcProcessorLabel.Text = "Загруженность процессора : " + processorLoad.ToString() + "%";

            //Получаем информацию о памяти и выводим её
            memoryLoad = (int)pcMemoryPercentage.NextValue();
            memoryProgressBar.Value = memoryLoad;
            memoryPercentageLabel.Text = "Процент занятой памяти : " + memoryLoad.ToString() + "%";

            //Обновление информации о загруженности ядер
            for(int i = 0; i < Environment.ProcessorCount; i++)
            {
                switch(i)
                {
                    case 0: int Value1 = (int)pCForCores[0].NextValue(); progressBar1.Value = Value1; label1.Text = "Ядро 1 : " + Value1 + "%"; break;
                    case 1: int Value2 = (int)pCForCores[1].NextValue(); progressBar2.Value = Value2; label2.Text = "Ядро 2 : " + Value2 + "%"; break;
                    case 2: int Value3 = (int)pCForCores[2].NextValue(); progressBar3.Value = Value3; label3.Text = "Ядро 3 : " + Value3 + "%"; break;
                    case 3: int Value4 = (int)pCForCores[3].NextValue(); progressBar4.Value = Value4; label4.Text = "Ядро 4 : " + Value4 + "%"; break;
                    case 4: int Value5 = (int)pCForCores[4].NextValue(); progressBar5.Value = Value5; label5.Text = "Ядро 5 : " + Value5 + "%"; break;
                    case 5: int Value6 = (int)pCForCores[5].NextValue(); progressBar6.Value = Value6; label6.Text = "Ядро 6 : " + Value6 + "%"; break;
                    case 6: int Value7 = (int)pCForCores[6].NextValue(); progressBar7.Value = Value7; label7.Text = "Ядро 7 : " + Value7 + "%"; break;
                    case 7: int Value8 = (int)pCForCores[7].NextValue(); progressBar8.Value = Value8; label8.Text = "Ядро 8 : " + Value8 + "%"; break;
                }
            }

            //Изменяем координаты точек, и перебираем их по очереди, после 10-й точки идет новая отрисовка графика
            if (pointNumber < 440)
            {
                pcPoints[pointNumber / 40].X = pointNumber;
                pcPoints[pointNumber / 40].Y = 400 - (processorLoad * 4);
                pointNumber += 40;
            }
            else
            {
                pointNumber = 0;
            }

            //Обновляем статусы потоков
            if(firstTest_status_bool){
                firstTest_status.Text = "Выполняется";
                firstTest_status.ForeColor = System.Drawing.Color.Green;
            }
            else{
                firstTest_status.Text = "Неактивен";
                firstTest_status.ForeColor = System.Drawing.Color.Red;
            }

            if (secondTest_status_bool)
            {
                secondTest_status.Text = "Выполняется";
                secondTest_status.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                secondTest_status.Text = "Неактивен";
                secondTest_status.ForeColor = System.Drawing.Color.Red;
            }

            if (firthTest_status_bool)
            {
                thirdTest_status.Text = "Выполняется";
                thirdTest_status.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                thirdTest_status.Text = "Неактивен";
                thirdTest_status.ForeColor = System.Drawing.Color.Red;
            }

            if (fourthTest_status_bool)
            {
                fourthTest_status.Text = "Выполняется";
                fourthTest_status.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                fourthTest_status.Text = "Неактивен";
                fourthTest_status.ForeColor = System.Drawing.Color.Red;
            }

            //Обновляем график
            pictureBox1.Refresh();
        }

        //Отрисовка графика
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Заполняем фон чёрным цветом
            e.Graphics.Clear(Color.Black);

            //Отрисовываем поле
            for (int i = 0; i < 400; i += 40)
            {
                e.Graphics.DrawLine(Pens.DarkGray, 0, i, pictureBox1.Width, i);
                e.Graphics.DrawLine(Pens.DarkGray, i, 0, i, pictureBox1.Height);
            }

            //Отрисовываем точки на графике
            for (int i = 0; i < ((pointNumber - 40)/40); i++ )
            {
                e.Graphics.DrawLine(Pens.GreenYellow, pcPoints[i].X, pcPoints[i].Y, pcPoints[i + 1].X, pcPoints[i + 1].Y);
            }

            //Отрисовка значений на полях
            for (int i = 0, j = 0; i <= 400; i += 40, j++)
            {
                e.Graphics.DrawString(j + "0%", textFont, textBrush, 0, 385 - i);
            }

        }

        //Прописываем события, происходящие по нажатию на "тест" кнопки
        private void test1_Start_Click(object sender, EventArgs e)
        {
            if(!firstTest_status_bool)
            {
                newThread_1 = new Thread(firstOverloadingFucntion);
                newThread_1.Start();
                firstTest_status_bool = true;
            }
        }

        private void test1_Stop_Click(object sender, EventArgs e)
        {
            if(firstTest_status_bool)
            {
                newThread_1.Abort();
                firstTest_status_bool = false;
            }
        }

        private void test2_Start_Click(object sender, EventArgs e)
        {
            if (!secondTest_status_bool)
            {
                newThread_2_1 = new Thread(secondOverloadingFucntion);
                newThread_2_2 = new Thread(secondOverloadingFucntion);
                newThread_2_1.Start();
                newThread_2_2.Start();
                secondTest_status_bool = true;
            }
        }

        private void test2_Stop_Click(object sender, EventArgs e)
        {
            if (secondTest_status_bool)
            {
                newThread_2_1.Abort();
                newThread_2_2.Abort();
                secondTest_status_bool = false;
            }
        }


        private void test3_Start_Click(object sender, EventArgs e)
        {
            if (!firthTest_status_bool)
            {
                newThread_3_1 = new Thread(secondOverloadingFucntion);
                newThread_3_2 = new Thread(secondOverloadingFucntion);
                newThread_3_3 = new Thread(secondOverloadingFucntion);
                newThread_3_4 = new Thread(secondOverloadingFucntion);
                newThread_3_1.Start();
                newThread_3_2.Start();
                newThread_3_3.Start();
                newThread_3_4.Start();
                firthTest_status_bool = true;
            }
        }

        private void test3_Stop_Click(object sender, EventArgs e)
        {
            if (firthTest_status_bool)
            {
                newThread_3_1.Abort();
                newThread_3_2.Abort();
                newThread_3_3.Abort();
                newThread_3_4.Abort();
                firthTest_status_bool = false;
            }
        }

        private void test4_Start_Click(object sender, EventArgs e)
        {
            if (!fourthTest_status_bool)
            {
                newThread_4_1 = new Thread(secondOverloadingFucntion);
                newThread_4_2 = new Thread(secondOverloadingFucntion);
                newThread_4_3 = new Thread(secondOverloadingFucntion);
                newThread_4_4 = new Thread(secondOverloadingFucntion);
                newThread_4_5 = new Thread(secondOverloadingFucntion);
                newThread_4_6 = new Thread(secondOverloadingFucntion);
                newThread_4_7 = new Thread(secondOverloadingFucntion);
                newThread_4_8 = new Thread(secondOverloadingFucntion);
                newThread_4_1.Start();
                newThread_4_2.Start();
                newThread_4_3.Start();
                newThread_4_4.Start();
                newThread_4_5.Start();
                newThread_4_6.Start();
                newThread_4_7.Start();
                newThread_4_8.Start();
                fourthTest_status_bool = true;
            }
        }

        private void test4_Stop_Click(object sender, EventArgs e)
        {
            if (fourthTest_status_bool)
            {
                newThread_4_1.Abort();
                newThread_4_2.Abort();
                newThread_4_3.Abort();
                newThread_4_4.Abort();
                newThread_4_5.Abort();
                newThread_4_6.Abort();
                newThread_4_7.Abort();
                newThread_4_8.Abort();
                fourthTest_status_bool = false;
            }
        }

        //Первая функция для нагрузки процессора
        static void firstOverloadingFucntion()
        {
            fib(100);
            fib(100);
        }

        //Вторая функция для нагрузки процессора
        static void secondOverloadingFucntion()
        {
            fib(100);
        }

        //Функция для поиска чисел фибоначи
        static int fib(int n)
        {
            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }
    }
}
