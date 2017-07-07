namespace KRPETROVDRAGUTAN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcProcessor = new System.Diagnostics.PerformanceCounter();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pcProcessorLabel = new System.Windows.Forms.Label();
            this.pcProcessorProgressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxOfProcesses = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxOfCores = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcMemoryPercentage = new System.Diagnostics.PerformanceCounter();
            this.pcMemoryFreeMB = new System.Diagnostics.PerformanceCounter();
            this.pcMemoryCin = new System.Diagnostics.PerformanceCounter();
            this.pcMemoryCout = new System.Diagnostics.PerformanceCounter();
            this.performanceCread = new System.Diagnostics.PerformanceCounter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.memoryProgressBar = new System.Windows.Forms.ProgressBar();
            this.memoryPercentageLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.amountOfLCores = new System.Windows.Forms.Label();
            this.amountOfPCores = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.test1_Start = new System.Windows.Forms.Button();
            this.test1_Stop = new System.Windows.Forms.Button();
            this.test2_Start = new System.Windows.Forms.Button();
            this.test2_Stop = new System.Windows.Forms.Button();
            this.test3_Stop = new System.Windows.Forms.Button();
            this.test3_Start = new System.Windows.Forms.Button();
            this.test4_Stop = new System.Windows.Forms.Button();
            this.test4_Start = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.firstTest_status = new System.Windows.Forms.Label();
            this.secondTest_status = new System.Windows.Forms.Label();
            this.thirdTest_status = new System.Windows.Forms.Label();
            this.fourthTest_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOfCores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryFreeMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryCin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCread)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcProcessor
            // 
            this.pcProcessor.CategoryName = "Процессор";
            this.pcProcessor.CounterName = "% загруженности процессора";
            this.pcProcessor.InstanceName = "_Total";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 500;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pcProcessorLabel
            // 
            this.pcProcessorLabel.AutoSize = true;
            this.pcProcessorLabel.Location = new System.Drawing.Point(6, 26);
            this.pcProcessorLabel.Name = "pcProcessorLabel";
            this.pcProcessorLabel.Size = new System.Drawing.Size(92, 13);
            this.pcProcessorLabel.TabIndex = 0;
            this.pcProcessorLabel.Text = "pcProcessorLabel";
            // 
            // pcProcessorProgressBar
            // 
            this.pcProcessorProgressBar.Location = new System.Drawing.Point(6, 42);
            this.pcProcessorProgressBar.Name = "pcProcessorProgressBar";
            this.pcProcessorProgressBar.Size = new System.Drawing.Size(427, 16);
            this.pcProcessorProgressBar.TabIndex = 1;
            // 
            // listBoxOfProcesses
            // 
            this.listBoxOfProcesses.FormattingEnabled = true;
            this.listBoxOfProcesses.HorizontalScrollbar = true;
            this.listBoxOfProcesses.Location = new System.Drawing.Point(6, 21);
            this.listBoxOfProcesses.Name = "listBoxOfProcesses";
            this.listBoxOfProcesses.Size = new System.Drawing.Size(229, 420);
            this.listBoxOfProcesses.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(259, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "График загруженности ЦП:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(21, 90);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(200, 20);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(21, 144);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(200, 20);
            this.progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(21, 198);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(200, 20);
            this.progressBar4.TabIndex = 7;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(21, 414);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(200, 20);
            this.progressBar8.TabIndex = 8;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(21, 360);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(200, 20);
            this.progressBar7.TabIndex = 9;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(21, 306);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(200, 20);
            this.progressBar6.TabIndex = 10;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(21, 252);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(200, 20);
            this.progressBar5.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ядро 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ядро 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ядро 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ядро 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ядро 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ядро 6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ядро 7:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ядро 8:";
            // 
            // groupBoxOfCores
            // 
            this.groupBoxOfCores.Controls.Add(this.label8);
            this.groupBoxOfCores.Controls.Add(this.label7);
            this.groupBoxOfCores.Controls.Add(this.label6);
            this.groupBoxOfCores.Controls.Add(this.label5);
            this.groupBoxOfCores.Controls.Add(this.label4);
            this.groupBoxOfCores.Controls.Add(this.label3);
            this.groupBoxOfCores.Controls.Add(this.label2);
            this.groupBoxOfCores.Controls.Add(this.label1);
            this.groupBoxOfCores.Controls.Add(this.progressBar5);
            this.groupBoxOfCores.Controls.Add(this.progressBar6);
            this.groupBoxOfCores.Controls.Add(this.progressBar7);
            this.groupBoxOfCores.Controls.Add(this.progressBar8);
            this.groupBoxOfCores.Controls.Add(this.progressBar4);
            this.groupBoxOfCores.Controls.Add(this.progressBar3);
            this.groupBoxOfCores.Controls.Add(this.progressBar2);
            this.groupBoxOfCores.Controls.Add(this.progressBar1);
            this.groupBoxOfCores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxOfCores.Location = new System.Drawing.Point(665, 14);
            this.groupBoxOfCores.Name = "groupBoxOfCores";
            this.groupBoxOfCores.Size = new System.Drawing.Size(241, 454);
            this.groupBoxOfCores.TabIndex = 21;
            this.groupBoxOfCores.TabStop = false;
            this.groupBoxOfCores.Text = "Загрузка ядер :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOfProcesses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 454);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список запущенных процессов : ";
            // 
            // pcMemoryPercentage
            // 
            this.pcMemoryPercentage.CategoryName = "Память";
            this.pcMemoryPercentage.CounterName = "% использования выделенной памяти";
            // 
            // pcMemoryFreeMB
            // 
            this.pcMemoryFreeMB.CategoryName = "Память";
            this.pcMemoryFreeMB.CounterName = "Доступно МБ";
            // 
            // pcMemoryCin
            // 
            this.pcMemoryCin.CategoryName = "Память";
            this.pcMemoryCin.CounterName = "Ввод страниц/сек";
            // 
            // pcMemoryCout
            // 
            this.pcMemoryCout.CategoryName = "Память";
            this.pcMemoryCout.CounterName = "Вывод страниц/с";
            // 
            // performanceCread
            // 
            this.performanceCread.CategoryName = "Память";
            this.performanceCread.CounterName = "Чтений страниц/с";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.memoryProgressBar);
            this.groupBox2.Controls.Add(this.memoryPercentageLabel);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 111);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о памяти : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "label10";
            // 
            // memoryProgressBar
            // 
            this.memoryProgressBar.Location = new System.Drawing.Point(9, 42);
            this.memoryProgressBar.Name = "memoryProgressBar";
            this.memoryProgressBar.Size = new System.Drawing.Size(432, 16);
            this.memoryProgressBar.TabIndex = 26;
            // 
            // memoryPercentageLabel
            // 
            this.memoryPercentageLabel.AutoSize = true;
            this.memoryPercentageLabel.Location = new System.Drawing.Point(6, 26);
            this.memoryPercentageLabel.Name = "memoryPercentageLabel";
            this.memoryPercentageLabel.Size = new System.Drawing.Size(134, 13);
            this.memoryPercentageLabel.TabIndex = 25;
            this.memoryPercentageLabel.Text = "Загруженность памяти : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(475, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 134);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.amountOfLCores);
            this.groupBox4.Controls.Add(this.amountOfPCores);
            this.groupBox4.Controls.Add(this.pcProcessorProgressBar);
            this.groupBox4.Controls.Add(this.pcProcessorLabel);
            this.groupBox4.Location = new System.Drawing.Point(465, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 111);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о процессоре :";
            // 
            // amountOfLCores
            // 
            this.amountOfLCores.AutoSize = true;
            this.amountOfLCores.Location = new System.Drawing.Point(259, 61);
            this.amountOfLCores.Name = "amountOfLCores";
            this.amountOfLCores.Size = new System.Drawing.Size(162, 13);
            this.amountOfLCores.TabIndex = 3;
            this.amountOfLCores.Text = "Количество логических ядер : ";
            // 
            // amountOfPCores
            // 
            this.amountOfPCores.AutoSize = true;
            this.amountOfPCores.Location = new System.Drawing.Point(6, 61);
            this.amountOfPCores.Name = "amountOfPCores";
            this.amountOfPCores.Size = new System.Drawing.Size(165, 13);
            this.amountOfPCores.TabIndex = 2;
            this.amountOfPCores.Text = "Количество физических ядер : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Количество процессов : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Количество потоков : ";
            // 
            // test1_Start
            // 
            this.test1_Start.Location = new System.Drawing.Point(12, 607);
            this.test1_Start.Name = "test1_Start";
            this.test1_Start.Size = new System.Drawing.Size(212, 52);
            this.test1_Start.TabIndex = 26;
            this.test1_Start.Text = "Начать первый тест:\r\nВызывает две функции фибоначи последовательно в одном потоке" +
    "\r\n";
            this.test1_Start.UseVisualStyleBackColor = true;
            this.test1_Start.Click += new System.EventHandler(this.test1_Start_Click);
            // 
            // test1_Stop
            // 
            this.test1_Stop.Location = new System.Drawing.Point(12, 665);
            this.test1_Stop.Name = "test1_Stop";
            this.test1_Stop.Size = new System.Drawing.Size(212, 52);
            this.test1_Stop.TabIndex = 27;
            this.test1_Stop.Text = "Остановить первый тест";
            this.test1_Stop.UseVisualStyleBackColor = true;
            this.test1_Stop.Click += new System.EventHandler(this.test1_Stop_Click);
            // 
            // test2_Start
            // 
            this.test2_Start.Location = new System.Drawing.Point(230, 607);
            this.test2_Start.Name = "test2_Start";
            this.test2_Start.Size = new System.Drawing.Size(235, 52);
            this.test2_Start.TabIndex = 28;
            this.test2_Start.Text = "Начать второй тест:\r\nВызывает две функции фибоначи в двух отдельных потоках\r\n\r\n";
            this.test2_Start.UseVisualStyleBackColor = true;
            this.test2_Start.Click += new System.EventHandler(this.test2_Start_Click);
            // 
            // test2_Stop
            // 
            this.test2_Stop.Location = new System.Drawing.Point(230, 665);
            this.test2_Stop.Name = "test2_Stop";
            this.test2_Stop.Size = new System.Drawing.Size(235, 52);
            this.test2_Stop.TabIndex = 29;
            this.test2_Stop.Text = "Остановить второй тест";
            this.test2_Stop.UseVisualStyleBackColor = true;
            this.test2_Stop.Click += new System.EventHandler(this.test2_Stop_Click);
            // 
            // test3_Stop
            // 
            this.test3_Stop.Location = new System.Drawing.Point(474, 665);
            this.test3_Stop.Name = "test3_Stop";
            this.test3_Stop.Size = new System.Drawing.Size(211, 52);
            this.test3_Stop.TabIndex = 31;
            this.test3_Stop.Text = "Остановить третий тест";
            this.test3_Stop.UseVisualStyleBackColor = true;
            this.test3_Stop.Click += new System.EventHandler(this.test3_Stop_Click);
            // 
            // test3_Start
            // 
            this.test3_Start.Location = new System.Drawing.Point(474, 607);
            this.test3_Start.Name = "test3_Start";
            this.test3_Start.Size = new System.Drawing.Size(211, 52);
            this.test3_Start.TabIndex = 30;
            this.test3_Start.Text = "Начать третий тест:\r\nВызывает четрые функции фибоначи в четырех потоках\r\n\r\n";
            this.test3_Start.UseVisualStyleBackColor = true;
            this.test3_Start.Click += new System.EventHandler(this.test3_Start_Click);
            // 
            // test4_Stop
            // 
            this.test4_Stop.Location = new System.Drawing.Point(695, 665);
            this.test4_Stop.Name = "test4_Stop";
            this.test4_Stop.Size = new System.Drawing.Size(211, 52);
            this.test4_Stop.TabIndex = 33;
            this.test4_Stop.Text = "Остановить четвертый тест";
            this.test4_Stop.UseVisualStyleBackColor = true;
            this.test4_Stop.Click += new System.EventHandler(this.test4_Stop_Click);
            // 
            // test4_Start
            // 
            this.test4_Start.Location = new System.Drawing.Point(695, 607);
            this.test4_Start.Name = "test4_Start";
            this.test4_Start.Size = new System.Drawing.Size(211, 52);
            this.test4_Start.TabIndex = 32;
            this.test4_Start.Text = "Начать четвёртый тест:\r\nВызывает восемь функций фибоначи в восьми потоках\r\n\r\n";
            this.test4_Start.UseVisualStyleBackColor = true;
            this.test4_Start.Click += new System.EventHandler(this.test4_Start_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(66, 720);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Статус : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 721);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Статус : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(525, 721);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Статус : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(746, 721);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Статус : ";
            // 
            // firstTest_status
            // 
            this.firstTest_status.AutoSize = true;
            this.firstTest_status.Location = new System.Drawing.Point(122, 721);
            this.firstTest_status.Name = "firstTest_status";
            this.firstTest_status.Size = new System.Drawing.Size(41, 13);
            this.firstTest_status.TabIndex = 38;
            this.firstTest_status.Text = "label20";
            // 
            // secondTest_status
            // 
            this.secondTest_status.AutoSize = true;
            this.secondTest_status.Location = new System.Drawing.Point(337, 721);
            this.secondTest_status.Name = "secondTest_status";
            this.secondTest_status.Size = new System.Drawing.Size(41, 13);
            this.secondTest_status.TabIndex = 39;
            this.secondTest_status.Text = "label20";
            // 
            // thirdTest_status
            // 
            this.thirdTest_status.AutoSize = true;
            this.thirdTest_status.Location = new System.Drawing.Point(576, 721);
            this.thirdTest_status.Name = "thirdTest_status";
            this.thirdTest_status.Size = new System.Drawing.Size(41, 13);
            this.thirdTest_status.TabIndex = 40;
            this.thirdTest_status.Text = "label20";
            // 
            // fourthTest_status
            // 
            this.fourthTest_status.AutoSize = true;
            this.fourthTest_status.Location = new System.Drawing.Point(802, 721);
            this.fourthTest_status.Name = "fourthTest_status";
            this.fourthTest_status.Size = new System.Drawing.Size(41, 13);
            this.fourthTest_status.TabIndex = 41;
            this.fourthTest_status.Text = "label20";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 748);
            this.Controls.Add(this.fourthTest_status);
            this.Controls.Add(this.thirdTest_status);
            this.Controls.Add(this.secondTest_status);
            this.Controls.Add(this.firstTest_status);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.test4_Stop);
            this.Controls.Add(this.test4_Start);
            this.Controls.Add(this.test3_Stop);
            this.Controls.Add(this.test3_Start);
            this.Controls.Add(this.test2_Stop);
            this.Controls.Add(this.test2_Start);
            this.Controls.Add(this.test1_Stop);
            this.Controls.Add(this.test1_Start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOfCores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Пользовательский диспетчер задач";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOfCores.ResumeLayout(false);
            this.groupBoxOfCores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryFreeMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryCin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCread)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pcProcessor;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label pcProcessorLabel;
        private System.Windows.Forms.ProgressBar pcProcessorProgressBar;
        private System.Windows.Forms.ListBox listBoxOfProcesses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxOfCores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Diagnostics.PerformanceCounter pcMemoryPercentage;
        private System.Diagnostics.PerformanceCounter pcMemoryFreeMB;
        private System.Diagnostics.PerformanceCounter pcMemoryCin;
        private System.Diagnostics.PerformanceCounter pcMemoryCout;
        private System.Diagnostics.PerformanceCounter performanceCread;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar memoryProgressBar;
        private System.Windows.Forms.Label memoryPercentageLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label amountOfLCores;
        private System.Windows.Forms.Label amountOfPCores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button test1_Start;
        private System.Windows.Forms.Button test1_Stop;
        private System.Windows.Forms.Button test2_Start;
        private System.Windows.Forms.Button test2_Stop;
        private System.Windows.Forms.Button test3_Stop;
        private System.Windows.Forms.Button test3_Start;
        private System.Windows.Forms.Button test4_Stop;
        private System.Windows.Forms.Button test4_Start;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label firstTest_status;
        private System.Windows.Forms.Label secondTest_status;
        private System.Windows.Forms.Label thirdTest_status;
        private System.Windows.Forms.Label fourthTest_status;
    }
}