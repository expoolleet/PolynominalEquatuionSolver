
namespace PolynomialCalculation
{
    partial class MainForm
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonFindRoots = new System.Windows.Forms.Button();
            this.labelRoot1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFunc5 = new System.Windows.Forms.TextBox();
            this.labelFunc5 = new System.Windows.Forms.Label();
            this.textBoxFunc4 = new System.Windows.Forms.TextBox();
            this.labelFunc4 = new System.Windows.Forms.Label();
            this.textBoxFunc3 = new System.Windows.Forms.TextBox();
            this.labelFunc3 = new System.Windows.Forms.Label();
            this.textBoxFunc2 = new System.Windows.Forms.TextBox();
            this.labelFunc2 = new System.Windows.Forms.Label();
            this.textBoxFunc1 = new System.Windows.Forms.TextBox();
            this.textBoxRoot5 = new System.Windows.Forms.TextBox();
            this.textBoxRoot4 = new System.Windows.Forms.TextBox();
            this.textBoxRoot3 = new System.Windows.Forms.TextBox();
            this.textBoxRoot2 = new System.Windows.Forms.TextBox();
            this.textBoxRoot1 = new System.Windows.Forms.TextBox();
            this.labelFunc1 = new System.Windows.Forms.Label();
            this.labelRoot5 = new System.Windows.Forms.Label();
            this.labelRoot4 = new System.Windows.Forms.Label();
            this.labelRoot3 = new System.Windows.Forms.Label();
            this.labelRoot2 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.labelVar2 = new System.Windows.Forms.Label();
            this.textBoxCoefficient0 = new System.Windows.Forms.TextBox();
            this.labelEqualZero = new System.Windows.Forms.Label();
            this.textBoxCoefficient2 = new System.Windows.Forms.TextBox();
            this.labelfx = new System.Windows.Forms.Label();
            this.textBoxCoefficient3 = new System.Windows.Forms.TextBox();
            this.labelVar3 = new System.Windows.Forms.Label();
            this.labelVar1 = new System.Windows.Forms.Label();
            this.textBoxCoefficient1 = new System.Windows.Forms.TextBox();
            this.labelVar4 = new System.Windows.Forms.Label();
            this.textBoxCoefficient4 = new System.Windows.Forms.TextBox();
            this.textBoxCoefficient5 = new System.Windows.Forms.TextBox();
            this.labelVar5 = new System.Windows.Forms.Label();
            this.labelVar0 = new System.Windows.Forms.Label();
            this.groupBoxEquation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarAccuracy = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonLimits = new System.Windows.Forms.Button();
            this.buttonGraphic = new System.Windows.Forms.Button();
            this.buttonSetInterval = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBoxEquation.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindRoots
            // 
            this.buttonFindRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindRoots.Location = new System.Drawing.Point(676, 212);
            this.buttonFindRoots.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindRoots.Name = "buttonFindRoots";
            this.buttonFindRoots.Size = new System.Drawing.Size(153, 58);
            this.buttonFindRoots.TabIndex = 8;
            this.buttonFindRoots.Text = "Найти корни";
            this.buttonFindRoots.UseVisualStyleBackColor = true;
            this.buttonFindRoots.Click += new System.EventHandler(this.buttonFindRoots_Click);
            // 
            // labelRoot1
            // 
            this.labelRoot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot1.Location = new System.Drawing.Point(8, 33);
            this.labelRoot1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoot1.Name = "labelRoot1";
            this.labelRoot1.Size = new System.Drawing.Size(28, 25);
            this.labelRoot1.TabIndex = 13;
            this.labelRoot1.Text = "x₁";
            this.labelRoot1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFunc5);
            this.groupBox1.Controls.Add(this.labelFunc5);
            this.groupBox1.Controls.Add(this.textBoxFunc4);
            this.groupBox1.Controls.Add(this.labelFunc4);
            this.groupBox1.Controls.Add(this.textBoxFunc3);
            this.groupBox1.Controls.Add(this.labelFunc3);
            this.groupBox1.Controls.Add(this.textBoxFunc2);
            this.groupBox1.Controls.Add(this.labelFunc2);
            this.groupBox1.Controls.Add(this.textBoxFunc1);
            this.groupBox1.Controls.Add(this.textBoxRoot5);
            this.groupBox1.Controls.Add(this.textBoxRoot4);
            this.groupBox1.Controls.Add(this.textBoxRoot3);
            this.groupBox1.Controls.Add(this.textBoxRoot2);
            this.groupBox1.Controls.Add(this.textBoxRoot1);
            this.groupBox1.Controls.Add(this.labelFunc1);
            this.groupBox1.Controls.Add(this.labelRoot5);
            this.groupBox1.Controls.Add(this.labelRoot4);
            this.groupBox1.Controls.Add(this.labelRoot3);
            this.groupBox1.Controls.Add(this.labelRoot2);
            this.groupBox1.Controls.Add(this.labelRoot1);
            this.groupBox1.Location = new System.Drawing.Point(510, 278);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 239);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // textBoxFunc5
            // 
            this.textBoxFunc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc5.Location = new System.Drawing.Point(262, 178);
            this.textBoxFunc5.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunc5.Name = "textBoxFunc5";
            this.textBoxFunc5.ReadOnly = true;
            this.textBoxFunc5.Size = new System.Drawing.Size(49, 24);
            this.textBoxFunc5.TabIndex = 32;
            this.textBoxFunc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunc5.Visible = false;
            // 
            // labelFunc5
            // 
            this.labelFunc5.AutoSize = true;
            this.labelFunc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc5.Location = new System.Drawing.Point(218, 182);
            this.labelFunc5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc5.Name = "labelFunc5";
            this.labelFunc5.Size = new System.Drawing.Size(36, 20);
            this.labelFunc5.TabIndex = 31;
            this.labelFunc5.Text = "f(x₅)";
            this.labelFunc5.Visible = false;
            // 
            // textBoxFunc4
            // 
            this.textBoxFunc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc4.Location = new System.Drawing.Point(262, 142);
            this.textBoxFunc4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunc4.Name = "textBoxFunc4";
            this.textBoxFunc4.ReadOnly = true;
            this.textBoxFunc4.Size = new System.Drawing.Size(49, 24);
            this.textBoxFunc4.TabIndex = 30;
            this.textBoxFunc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunc4.Visible = false;
            // 
            // labelFunc4
            // 
            this.labelFunc4.AutoSize = true;
            this.labelFunc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc4.Location = new System.Drawing.Point(218, 145);
            this.labelFunc4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc4.Name = "labelFunc4";
            this.labelFunc4.Size = new System.Drawing.Size(36, 20);
            this.labelFunc4.TabIndex = 29;
            this.labelFunc4.Text = "f(x₄)";
            this.labelFunc4.Visible = false;
            // 
            // textBoxFunc3
            // 
            this.textBoxFunc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc3.Location = new System.Drawing.Point(262, 105);
            this.textBoxFunc3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunc3.Name = "textBoxFunc3";
            this.textBoxFunc3.ReadOnly = true;
            this.textBoxFunc3.Size = new System.Drawing.Size(49, 24);
            this.textBoxFunc3.TabIndex = 28;
            this.textBoxFunc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunc3.Visible = false;
            // 
            // labelFunc3
            // 
            this.labelFunc3.AutoSize = true;
            this.labelFunc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc3.Location = new System.Drawing.Point(218, 108);
            this.labelFunc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc3.Name = "labelFunc3";
            this.labelFunc3.Size = new System.Drawing.Size(36, 20);
            this.labelFunc3.TabIndex = 27;
            this.labelFunc3.Text = "f(x₃)";
            this.labelFunc3.Visible = false;
            // 
            // textBoxFunc2
            // 
            this.textBoxFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc2.Location = new System.Drawing.Point(262, 68);
            this.textBoxFunc2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunc2.Name = "textBoxFunc2";
            this.textBoxFunc2.ReadOnly = true;
            this.textBoxFunc2.Size = new System.Drawing.Size(49, 24);
            this.textBoxFunc2.TabIndex = 26;
            this.textBoxFunc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunc2.Visible = false;
            // 
            // labelFunc2
            // 
            this.labelFunc2.AutoSize = true;
            this.labelFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc2.Location = new System.Drawing.Point(218, 71);
            this.labelFunc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc2.Name = "labelFunc2";
            this.labelFunc2.Size = new System.Drawing.Size(36, 20);
            this.labelFunc2.TabIndex = 25;
            this.labelFunc2.Text = "f(x₂)";
            this.labelFunc2.Visible = false;
            // 
            // textBoxFunc1
            // 
            this.textBoxFunc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc1.Location = new System.Drawing.Point(262, 32);
            this.textBoxFunc1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunc1.Name = "textBoxFunc1";
            this.textBoxFunc1.ReadOnly = true;
            this.textBoxFunc1.Size = new System.Drawing.Size(49, 24);
            this.textBoxFunc1.TabIndex = 24;
            this.textBoxFunc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunc1.Visible = false;
            // 
            // textBoxRoot5
            // 
            this.textBoxRoot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot5.Location = new System.Drawing.Point(38, 181);
            this.textBoxRoot5.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRoot5.Name = "textBoxRoot5";
            this.textBoxRoot5.ReadOnly = true;
            this.textBoxRoot5.Size = new System.Drawing.Size(172, 24);
            this.textBoxRoot5.TabIndex = 23;
            this.textBoxRoot5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoot5.Visible = false;
            // 
            // textBoxRoot4
            // 
            this.textBoxRoot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot4.Location = new System.Drawing.Point(38, 145);
            this.textBoxRoot4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRoot4.Name = "textBoxRoot4";
            this.textBoxRoot4.ReadOnly = true;
            this.textBoxRoot4.Size = new System.Drawing.Size(172, 24);
            this.textBoxRoot4.TabIndex = 22;
            this.textBoxRoot4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoot4.Visible = false;
            // 
            // textBoxRoot3
            // 
            this.textBoxRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot3.Location = new System.Drawing.Point(38, 108);
            this.textBoxRoot3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRoot3.Name = "textBoxRoot3";
            this.textBoxRoot3.ReadOnly = true;
            this.textBoxRoot3.Size = new System.Drawing.Size(172, 24);
            this.textBoxRoot3.TabIndex = 21;
            this.textBoxRoot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoot3.Visible = false;
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot2.Location = new System.Drawing.Point(38, 70);
            this.textBoxRoot2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.ReadOnly = true;
            this.textBoxRoot2.Size = new System.Drawing.Size(172, 24);
            this.textBoxRoot2.TabIndex = 20;
            this.textBoxRoot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoot2.Visible = false;
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot1.Location = new System.Drawing.Point(38, 32);
            this.textBoxRoot1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.ReadOnly = true;
            this.textBoxRoot1.Size = new System.Drawing.Size(172, 24);
            this.textBoxRoot1.TabIndex = 19;
            this.textBoxRoot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoot1.Visible = false;
            // 
            // labelFunc1
            // 
            this.labelFunc1.AutoSize = true;
            this.labelFunc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc1.Location = new System.Drawing.Point(218, 34);
            this.labelFunc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc1.Name = "labelFunc1";
            this.labelFunc1.Size = new System.Drawing.Size(36, 20);
            this.labelFunc1.TabIndex = 18;
            this.labelFunc1.Text = "f(x₁)";
            this.labelFunc1.Visible = false;
            // 
            // labelRoot5
            // 
            this.labelRoot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot5.Location = new System.Drawing.Point(8, 180);
            this.labelRoot5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoot5.Name = "labelRoot5";
            this.labelRoot5.Size = new System.Drawing.Size(28, 25);
            this.labelRoot5.TabIndex = 17;
            this.labelRoot5.Text = "x₅";
            this.labelRoot5.Visible = false;
            // 
            // labelRoot4
            // 
            this.labelRoot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot4.Location = new System.Drawing.Point(8, 144);
            this.labelRoot4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoot4.Name = "labelRoot4";
            this.labelRoot4.Size = new System.Drawing.Size(28, 25);
            this.labelRoot4.TabIndex = 16;
            this.labelRoot4.Text = "x₄";
            this.labelRoot4.Visible = false;
            // 
            // labelRoot3
            // 
            this.labelRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot3.Location = new System.Drawing.Point(8, 107);
            this.labelRoot3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoot3.Name = "labelRoot3";
            this.labelRoot3.Size = new System.Drawing.Size(28, 25);
            this.labelRoot3.TabIndex = 15;
            this.labelRoot3.Text = "x₃";
            this.labelRoot3.Visible = false;
            // 
            // labelRoot2
            // 
            this.labelRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot2.Location = new System.Drawing.Point(8, 70);
            this.labelRoot2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoot2.Name = "labelRoot2";
            this.labelRoot2.Size = new System.Drawing.Size(28, 25);
            this.labelRoot2.TabIndex = 14;
            this.labelRoot2.Text = "x₂";
            this.labelRoot2.Visible = false;
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(12, 212);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Func";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(490, 411);
            this.chart.TabIndex = 15;
            this.chart.Text = "chart1";
            this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDegree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxDegree.Location = new System.Drawing.Point(26, 32);
            this.comboBoxDegree.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new System.Drawing.Size(63, 28);
            this.comboBoxDegree.Sorted = true;
            this.comboBoxDegree.TabIndex = 1;
            this.comboBoxDegree.SelectedIndexChanged += new System.EventHandler(this.comboBoxDegree_SelectedIndexChanged);
            // 
            // labelVar2
            // 
            this.labelVar2.AutoSize = true;
            this.labelVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar2.Location = new System.Drawing.Point(82, -1);
            this.labelVar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar2.Name = "labelVar2";
            this.labelVar2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.labelVar2.Size = new System.Drawing.Size(34, 34);
            this.labelVar2.TabIndex = 99;
            this.labelVar2.Text = "x² +";
            this.labelVar2.Visible = false;
            // 
            // textBoxCoefficient0
            // 
            this.textBoxCoefficient0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient0.Location = new System.Drawing.Point(119, 4);
            this.textBoxCoefficient0.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient0.Name = "textBoxCoefficient0";
            this.textBoxCoefficient0.Size = new System.Drawing.Size(77, 26);
            this.textBoxCoefficient0.TabIndex = 7;
            this.textBoxCoefficient0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient0.Visible = false;
            this.textBoxCoefficient0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient0_KeyPress);
            // 
            // labelEqualZero
            // 
            this.labelEqualZero.AutoSize = true;
            this.labelEqualZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEqualZero.Location = new System.Drawing.Point(752, 13);
            this.labelEqualZero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEqualZero.Name = "labelEqualZero";
            this.labelEqualZero.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.labelEqualZero.Size = new System.Drawing.Size(31, 36);
            this.labelEqualZero.TabIndex = 99;
            this.labelEqualZero.Text = "= 0";
            this.labelEqualZero.Visible = false;
            // 
            // textBoxCoefficient2
            // 
            this.textBoxCoefficient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient2.Location = new System.Drawing.Point(4, 4);
            this.textBoxCoefficient2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient2.Name = "textBoxCoefficient2";
            this.textBoxCoefficient2.Size = new System.Drawing.Size(76, 26);
            this.textBoxCoefficient2.TabIndex = 5;
            this.textBoxCoefficient2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient2.Visible = false;
            this.textBoxCoefficient2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient2_KeyPress);
            // 
            // labelfx
            // 
            this.labelfx.AutoSize = true;
            this.labelfx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfx.Location = new System.Drawing.Point(4, 13);
            this.labelfx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfx.Name = "labelfx";
            this.labelfx.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.labelfx.Size = new System.Drawing.Size(52, 36);
            this.labelfx.TabIndex = 5;
            this.labelfx.Text = "f(x) =";
            this.labelfx.Visible = false;
            // 
            // textBoxCoefficient3
            // 
            this.textBoxCoefficient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient3.Location = new System.Drawing.Point(4, 4);
            this.textBoxCoefficient3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient3.Name = "textBoxCoefficient3";
            this.textBoxCoefficient3.Size = new System.Drawing.Size(76, 26);
            this.textBoxCoefficient3.TabIndex = 4;
            this.textBoxCoefficient3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient3.Visible = false;
            this.textBoxCoefficient3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient3_KeyPress);
            // 
            // labelVar3
            // 
            this.labelVar3.AutoSize = true;
            this.labelVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar3.Location = new System.Drawing.Point(81, -1);
            this.labelVar3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar3.Name = "labelVar3";
            this.labelVar3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.labelVar3.Size = new System.Drawing.Size(34, 34);
            this.labelVar3.TabIndex = 12;
            this.labelVar3.Text = "x³ +";
            this.labelVar3.Visible = false;
            // 
            // labelVar1
            // 
            this.labelVar1.AutoSize = true;
            this.labelVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar1.Location = new System.Drawing.Point(80, -1);
            this.labelVar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar1.Name = "labelVar1";
            this.labelVar1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.labelVar1.Size = new System.Drawing.Size(29, 34);
            this.labelVar1.TabIndex = 99;
            this.labelVar1.Text = "x +";
            this.labelVar1.Visible = false;
            // 
            // textBoxCoefficient1
            // 
            this.textBoxCoefficient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient1.Location = new System.Drawing.Point(4, 4);
            this.textBoxCoefficient1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient1.Name = "textBoxCoefficient1";
            this.textBoxCoefficient1.Size = new System.Drawing.Size(76, 26);
            this.textBoxCoefficient1.TabIndex = 6;
            this.textBoxCoefficient1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient1.Visible = false;
            this.textBoxCoefficient1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient1_KeyPress);
            // 
            // labelVar4
            // 
            this.labelVar4.AutoSize = true;
            this.labelVar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar4.Location = new System.Drawing.Point(85, -1);
            this.labelVar4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar4.Name = "labelVar4";
            this.labelVar4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.labelVar4.Size = new System.Drawing.Size(34, 34);
            this.labelVar4.TabIndex = 14;
            this.labelVar4.Text = "x⁴ +";
            this.labelVar4.Visible = false;
            // 
            // textBoxCoefficient4
            // 
            this.textBoxCoefficient4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient4.Location = new System.Drawing.Point(4, 4);
            this.textBoxCoefficient4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient4.Name = "textBoxCoefficient4";
            this.textBoxCoefficient4.Size = new System.Drawing.Size(76, 26);
            this.textBoxCoefficient4.TabIndex = 3;
            this.textBoxCoefficient4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient4.Visible = false;
            this.textBoxCoefficient4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient4_KeyPress);
            // 
            // textBoxCoefficient5
            // 
            this.textBoxCoefficient5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient5.Location = new System.Drawing.Point(10, 4);
            this.textBoxCoefficient5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxCoefficient5.Name = "textBoxCoefficient5";
            this.textBoxCoefficient5.Size = new System.Drawing.Size(76, 26);
            this.textBoxCoefficient5.TabIndex = 2;
            this.textBoxCoefficient5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCoefficient5.Visible = false;
            this.textBoxCoefficient5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient5_KeyPress);
            // 
            // labelVar5
            // 
            this.labelVar5.AutoSize = true;
            this.labelVar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar5.Location = new System.Drawing.Point(90, -1);
            this.labelVar5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar5.Name = "labelVar5";
            this.labelVar5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.labelVar5.Size = new System.Drawing.Size(34, 34);
            this.labelVar5.TabIndex = 16;
            this.labelVar5.Text = "x⁵ +";
            this.labelVar5.Visible = false;
            // 
            // labelVar0
            // 
            this.labelVar0.AutoSize = true;
            this.labelVar0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar0.Location = new System.Drawing.Point(688, 11);
            this.labelVar0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVar0.Name = "labelVar0";
            this.labelVar0.Size = new System.Drawing.Size(0, 20);
            this.labelVar0.TabIndex = 17;
            this.labelVar0.Visible = false;
            // 
            // groupBoxEquation
            // 
            this.groupBoxEquation.AutoSize = true;
            this.groupBoxEquation.Controls.Add(this.labelVar0);
            this.groupBoxEquation.Controls.Add(this.flowLayoutPanel);
            this.groupBoxEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEquation.Location = new System.Drawing.Point(12, 104);
            this.groupBoxEquation.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEquation.Name = "groupBoxEquation";
            this.groupBoxEquation.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEquation.Size = new System.Drawing.Size(815, 100);
            this.groupBoxEquation.TabIndex = 12;
            this.groupBoxEquation.TabStop = false;
            this.groupBoxEquation.Text = "Решить уравнение вида:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Controls.Add(this.labelfx);
            this.flowLayoutPanel.Controls.Add(this.panel5);
            this.flowLayoutPanel.Controls.Add(this.panel4);
            this.flowLayoutPanel.Controls.Add(this.panel3);
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.labelEqualZero);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 31);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 13, 0, 10);
            this.flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel.Size = new System.Drawing.Size(807, 65);
            this.flowLayoutPanel.TabIndex = 24;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.textBoxCoefficient5);
            this.panel5.Controls.Add(this.labelVar5);
            this.panel5.Location = new System.Drawing.Point(60, 16);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 34);
            this.panel5.TabIndex = 103;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.textBoxCoefficient4);
            this.panel4.Controls.Add(this.labelVar4);
            this.panel4.Location = new System.Drawing.Point(188, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 34);
            this.panel4.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.textBoxCoefficient3);
            this.panel3.Controls.Add(this.labelVar3);
            this.panel3.Location = new System.Drawing.Point(311, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 34);
            this.panel3.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.textBoxCoefficient2);
            this.panel2.Controls.Add(this.labelVar2);
            this.panel2.Location = new System.Drawing.Point(430, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 34);
            this.panel2.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBoxCoefficient1);
            this.panel1.Controls.Add(this.textBoxCoefficient0);
            this.panel1.Controls.Add(this.labelVar1);
            this.panel1.Location = new System.Drawing.Point(550, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 34);
            this.panel1.TabIndex = 25;
            // 
            // trackBarAccuracy
            // 
            this.trackBarAccuracy.Location = new System.Drawing.Point(8, 31);
            this.trackBarAccuracy.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarAccuracy.Maximum = 15;
            this.trackBarAccuracy.Name = "trackBarAccuracy";
            this.trackBarAccuracy.Size = new System.Drawing.Size(216, 45);
            this.trackBarAccuracy.TabIndex = 18;
            this.trackBarAccuracy.Value = 2;
            this.trackBarAccuracy.Scroll += new System.EventHandler(this.trackBarAccuracy_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAccuracy);
            this.groupBox2.Controls.Add(this.trackBarAccuracy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(522, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(307, 84);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Знаков после запятой";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAccuracy.Location = new System.Drawing.Point(245, 31);
            this.textBoxAccuracy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.ReadOnly = true;
            this.textBoxAccuracy.Size = new System.Drawing.Size(38, 26);
            this.textBoxAccuracy.TabIndex = 33;
            this.textBoxAccuracy.Text = "2";
            this.textBoxAccuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDegree);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 84);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Степень";
            // 
            // buttonLimits
            // 
            this.buttonLimits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLimits.Location = new System.Drawing.Point(510, 565);
            this.buttonLimits.Name = "buttonLimits";
            this.buttonLimits.Size = new System.Drawing.Size(173, 58);
            this.buttonLimits.TabIndex = 21;
            this.buttonLimits.Text = "Изменить границы графика";
            this.buttonLimits.UseVisualStyleBackColor = true;
            this.buttonLimits.Click += new System.EventHandler(this.buttonLimits_Click);
            // 
            // buttonGraphic
            // 
            this.buttonGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphic.Location = new System.Drawing.Point(509, 212);
            this.buttonGraphic.Name = "buttonGraphic";
            this.buttonGraphic.Size = new System.Drawing.Size(157, 58);
            this.buttonGraphic.TabIndex = 22;
            this.buttonGraphic.Text = "Построить график";
            this.buttonGraphic.UseVisualStyleBackColor = true;
            this.buttonGraphic.Click += new System.EventHandler(this.buttonGraphic_Click);
            // 
            // buttonSetInterval
            // 
            this.buttonSetInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonSetInterval.Location = new System.Drawing.Point(676, 245);
            this.buttonSetInterval.Name = "buttonSetInterval";
            this.buttonSetInterval.Size = new System.Drawing.Size(153, 58);
            this.buttonSetInterval.TabIndex = 23;
            this.buttonSetInterval.Text = "Задать интервал";
            this.buttonSetInterval.UseVisualStyleBackColor = true;
            this.buttonSetInterval.Click += new System.EventHandler(this.buttonSetInterval_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 633);
            this.Controls.Add(this.buttonSetInterval);
            this.Controls.Add(this.buttonFindRoots);
            this.Controls.Add(this.buttonGraphic);
            this.Controls.Add(this.buttonLimits);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEquation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение алгебраических уравнений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBoxEquation.ResumeLayout(false);
            this.groupBoxEquation.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFindRoots;
        private System.Windows.Forms.Label labelRoot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFunc1;
        private System.Windows.Forms.Label labelRoot5;
        private System.Windows.Forms.Label labelRoot4;
        private System.Windows.Forms.Label labelRoot3;
        private System.Windows.Forms.Label labelRoot2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox textBoxRoot2;
        private System.Windows.Forms.TextBox textBoxRoot1;
        private System.Windows.Forms.TextBox textBoxFunc1;
        private System.Windows.Forms.TextBox textBoxRoot5;
        private System.Windows.Forms.TextBox textBoxRoot4;
        private System.Windows.Forms.TextBox textBoxRoot3;
        private System.Windows.Forms.TextBox textBoxFunc5;
        private System.Windows.Forms.Label labelFunc5;
        private System.Windows.Forms.TextBox textBoxFunc4;
        private System.Windows.Forms.Label labelFunc4;
        private System.Windows.Forms.TextBox textBoxFunc3;
        private System.Windows.Forms.Label labelFunc3;
        private System.Windows.Forms.TextBox textBoxFunc2;
        private System.Windows.Forms.Label labelFunc2;
        private System.Windows.Forms.ComboBox comboBoxDegree;
        private System.Windows.Forms.Label labelVar2;
        private System.Windows.Forms.TextBox textBoxCoefficient0;
        private System.Windows.Forms.Label labelEqualZero;
        private System.Windows.Forms.TextBox textBoxCoefficient2;
        private System.Windows.Forms.Label labelfx;
        private System.Windows.Forms.TextBox textBoxCoefficient3;
        private System.Windows.Forms.Label labelVar3;
        private System.Windows.Forms.Label labelVar1;
        private System.Windows.Forms.TextBox textBoxCoefficient1;
        private System.Windows.Forms.Label labelVar4;
        private System.Windows.Forms.TextBox textBoxCoefficient4;
        private System.Windows.Forms.TextBox textBoxCoefficient5;
        private System.Windows.Forms.Label labelVar5;
        private System.Windows.Forms.Label labelVar0;
        private System.Windows.Forms.GroupBox groupBoxEquation;
        private System.Windows.Forms.TrackBar trackBarAccuracy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAccuracy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLimits;
        private System.Windows.Forms.Button buttonGraphic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonSetInterval;
    }
}

