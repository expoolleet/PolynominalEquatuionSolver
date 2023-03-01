
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelDegree = new System.Windows.Forms.Label();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVar2 = new System.Windows.Forms.Label();
            this.textBoxCoefficient0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCoefficient2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBoxEquation.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDegree.Location = new System.Drawing.Point(8, 28);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(74, 20);
            this.labelDegree.TabIndex = 0;
            this.labelDegree.Text = "Степень";
            // 
            // buttonFindRoots
            // 
            this.buttonFindRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindRoots.Location = new System.Drawing.Point(474, 182);
            this.buttonFindRoots.Name = "buttonFindRoots";
            this.buttonFindRoots.Size = new System.Drawing.Size(252, 51);
            this.buttonFindRoots.TabIndex = 8;
            this.buttonFindRoots.Text = "Найти корни";
            this.buttonFindRoots.UseVisualStyleBackColor = true;
            this.buttonFindRoots.Click += new System.EventHandler(this.buttonFindRoots_Click);
            // 
            // labelRoot1
            // 
            this.labelRoot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot1.Location = new System.Drawing.Point(6, 28);
            this.labelRoot1.Name = "labelRoot1";
            this.labelRoot1.Size = new System.Drawing.Size(38, 20);
            this.labelRoot1.TabIndex = 13;
            this.labelRoot1.Text = "x₁ = ";
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
            this.groupBox1.Location = new System.Drawing.Point(474, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // textBoxFunc5
            // 
            this.textBoxFunc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc5.Location = new System.Drawing.Point(174, 145);
            this.textBoxFunc5.Name = "textBoxFunc5";
            this.textBoxFunc5.ReadOnly = true;
            this.textBoxFunc5.Size = new System.Drawing.Size(68, 24);
            this.textBoxFunc5.TabIndex = 32;
            this.textBoxFunc5.Visible = false;
            // 
            // labelFunc5
            // 
            this.labelFunc5.AutoSize = true;
            this.labelFunc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc5.Location = new System.Drawing.Point(124, 148);
            this.labelFunc5.Name = "labelFunc5";
            this.labelFunc5.Size = new System.Drawing.Size(53, 20);
            this.labelFunc5.TabIndex = 31;
            this.labelFunc5.Text = "f(x₅) = ";
            this.labelFunc5.Visible = false;
            // 
            // textBoxFunc4
            // 
            this.textBoxFunc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc4.Location = new System.Drawing.Point(174, 115);
            this.textBoxFunc4.Name = "textBoxFunc4";
            this.textBoxFunc4.ReadOnly = true;
            this.textBoxFunc4.Size = new System.Drawing.Size(68, 24);
            this.textBoxFunc4.TabIndex = 30;
            this.textBoxFunc4.Visible = false;
            // 
            // labelFunc4
            // 
            this.labelFunc4.AutoSize = true;
            this.labelFunc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc4.Location = new System.Drawing.Point(124, 118);
            this.labelFunc4.Name = "labelFunc4";
            this.labelFunc4.Size = new System.Drawing.Size(53, 20);
            this.labelFunc4.TabIndex = 29;
            this.labelFunc4.Text = "f(x₄) = ";
            this.labelFunc4.Visible = false;
            // 
            // textBoxFunc3
            // 
            this.textBoxFunc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc3.Location = new System.Drawing.Point(174, 85);
            this.textBoxFunc3.Name = "textBoxFunc3";
            this.textBoxFunc3.ReadOnly = true;
            this.textBoxFunc3.Size = new System.Drawing.Size(68, 24);
            this.textBoxFunc3.TabIndex = 28;
            this.textBoxFunc3.Visible = false;
            // 
            // labelFunc3
            // 
            this.labelFunc3.AutoSize = true;
            this.labelFunc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc3.Location = new System.Drawing.Point(124, 88);
            this.labelFunc3.Name = "labelFunc3";
            this.labelFunc3.Size = new System.Drawing.Size(53, 20);
            this.labelFunc3.TabIndex = 27;
            this.labelFunc3.Text = "f(x₃) = ";
            this.labelFunc3.Visible = false;
            // 
            // textBoxFunc2
            // 
            this.textBoxFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc2.Location = new System.Drawing.Point(174, 55);
            this.textBoxFunc2.Name = "textBoxFunc2";
            this.textBoxFunc2.ReadOnly = true;
            this.textBoxFunc2.Size = new System.Drawing.Size(68, 24);
            this.textBoxFunc2.TabIndex = 26;
            this.textBoxFunc2.Visible = false;
            // 
            // labelFunc2
            // 
            this.labelFunc2.AutoSize = true;
            this.labelFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc2.Location = new System.Drawing.Point(124, 58);
            this.labelFunc2.Name = "labelFunc2";
            this.labelFunc2.Size = new System.Drawing.Size(53, 20);
            this.labelFunc2.TabIndex = 25;
            this.labelFunc2.Text = "f(x₂) = ";
            this.labelFunc2.Visible = false;
            // 
            // textBoxFunc1
            // 
            this.textBoxFunc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFunc1.Location = new System.Drawing.Point(174, 25);
            this.textBoxFunc1.Name = "textBoxFunc1";
            this.textBoxFunc1.ReadOnly = true;
            this.textBoxFunc1.Size = new System.Drawing.Size(68, 24);
            this.textBoxFunc1.TabIndex = 24;
            this.textBoxFunc1.Visible = false;
            // 
            // textBoxRoot5
            // 
            this.textBoxRoot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot5.Location = new System.Drawing.Point(47, 145);
            this.textBoxRoot5.Name = "textBoxRoot5";
            this.textBoxRoot5.ReadOnly = true;
            this.textBoxRoot5.Size = new System.Drawing.Size(68, 24);
            this.textBoxRoot5.TabIndex = 23;
            this.textBoxRoot5.Visible = false;
            // 
            // textBoxRoot4
            // 
            this.textBoxRoot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot4.Location = new System.Drawing.Point(47, 115);
            this.textBoxRoot4.Name = "textBoxRoot4";
            this.textBoxRoot4.ReadOnly = true;
            this.textBoxRoot4.Size = new System.Drawing.Size(68, 24);
            this.textBoxRoot4.TabIndex = 22;
            this.textBoxRoot4.Visible = false;
            // 
            // textBoxRoot3
            // 
            this.textBoxRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot3.Location = new System.Drawing.Point(47, 85);
            this.textBoxRoot3.Name = "textBoxRoot3";
            this.textBoxRoot3.ReadOnly = true;
            this.textBoxRoot3.Size = new System.Drawing.Size(68, 24);
            this.textBoxRoot3.TabIndex = 21;
            this.textBoxRoot3.Visible = false;
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot2.Location = new System.Drawing.Point(47, 55);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.ReadOnly = true;
            this.textBoxRoot2.Size = new System.Drawing.Size(68, 24);
            this.textBoxRoot2.TabIndex = 20;
            this.textBoxRoot2.Visible = false;
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoot1.Location = new System.Drawing.Point(47, 25);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.ReadOnly = true;
            this.textBoxRoot1.Size = new System.Drawing.Size(68, 24);
            this.textBoxRoot1.TabIndex = 19;
            this.textBoxRoot1.Visible = false;
            // 
            // labelFunc1
            // 
            this.labelFunc1.AutoSize = true;
            this.labelFunc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc1.Location = new System.Drawing.Point(124, 28);
            this.labelFunc1.Name = "labelFunc1";
            this.labelFunc1.Size = new System.Drawing.Size(53, 20);
            this.labelFunc1.TabIndex = 18;
            this.labelFunc1.Text = "f(x₁) = ";
            this.labelFunc1.Visible = false;
            // 
            // labelRoot5
            // 
            this.labelRoot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot5.Location = new System.Drawing.Point(6, 148);
            this.labelRoot5.Name = "labelRoot5";
            this.labelRoot5.Size = new System.Drawing.Size(38, 20);
            this.labelRoot5.TabIndex = 17;
            this.labelRoot5.Text = "x₅ = ";
            this.labelRoot5.Visible = false;
            // 
            // labelRoot4
            // 
            this.labelRoot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot4.Location = new System.Drawing.Point(6, 118);
            this.labelRoot4.Name = "labelRoot4";
            this.labelRoot4.Size = new System.Drawing.Size(38, 20);
            this.labelRoot4.TabIndex = 16;
            this.labelRoot4.Text = "x₄ = ";
            this.labelRoot4.Visible = false;
            // 
            // labelRoot3
            // 
            this.labelRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot3.Location = new System.Drawing.Point(6, 88);
            this.labelRoot3.Name = "labelRoot3";
            this.labelRoot3.Size = new System.Drawing.Size(38, 20);
            this.labelRoot3.TabIndex = 15;
            this.labelRoot3.Text = "x₃ = ";
            this.labelRoot3.Visible = false;
            // 
            // labelRoot2
            // 
            this.labelRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot2.Location = new System.Drawing.Point(6, 58);
            this.labelRoot2.Name = "labelRoot2";
            this.labelRoot2.Size = new System.Drawing.Size(38, 20);
            this.labelRoot2.TabIndex = 14;
            this.labelRoot2.Text = "x₂ = ";
            this.labelRoot2.Visible = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(11, 182);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Func";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(457, 251);
            this.chart.TabIndex = 15;
            this.chart.Text = "chart1";
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxDegree.Location = new System.Drawing.Point(88, 30);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new System.Drawing.Size(48, 21);
            this.comboBoxDegree.Sorted = true;
            this.comboBoxDegree.TabIndex = 1;
            this.comboBoxDegree.SelectedIndexChanged += new System.EventHandler(this.comboBoxDegree_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Решить уравнение вида:";
            // 
            // labelVar2
            // 
            this.labelVar2.AutoSize = true;
            this.labelVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar2.Location = new System.Drawing.Point(447, 35);
            this.labelVar2.Name = "labelVar2";
            this.labelVar2.Size = new System.Drawing.Size(34, 20);
            this.labelVar2.TabIndex = 99;
            this.labelVar2.Text = "x² +";
            this.labelVar2.Visible = false;
            // 
            // textBoxCoefficient0
            // 
            this.textBoxCoefficient0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient0.Location = new System.Drawing.Point(586, 32);
            this.textBoxCoefficient0.Name = "textBoxCoefficient0";
            this.textBoxCoefficient0.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient0.TabIndex = 7;
            this.textBoxCoefficient0.Visible = false;
            this.textBoxCoefficient0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(650, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "= 0";
            // 
            // textBoxCoefficient2
            // 
            this.textBoxCoefficient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient2.Location = new System.Drawing.Point(383, 32);
            this.textBoxCoefficient2.Name = "textBoxCoefficient2";
            this.textBoxCoefficient2.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient2.TabIndex = 5;
            this.textBoxCoefficient2.Visible = false;
            this.textBoxCoefficient2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "f(x) =";
            // 
            // textBoxCoefficient3
            // 
            this.textBoxCoefficient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient3.Location = new System.Drawing.Point(276, 32);
            this.textBoxCoefficient3.Name = "textBoxCoefficient3";
            this.textBoxCoefficient3.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient3.TabIndex = 4;
            this.textBoxCoefficient3.Visible = false;
            this.textBoxCoefficient3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient3_KeyPress);
            // 
            // labelVar3
            // 
            this.labelVar3.AutoSize = true;
            this.labelVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar3.Location = new System.Drawing.Point(340, 35);
            this.labelVar3.Name = "labelVar3";
            this.labelVar3.Size = new System.Drawing.Size(34, 20);
            this.labelVar3.TabIndex = 12;
            this.labelVar3.Text = "x³ +";
            this.labelVar3.Visible = false;
            // 
            // labelVar1
            // 
            this.labelVar1.AutoSize = true;
            this.labelVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar1.Location = new System.Drawing.Point(551, 35);
            this.labelVar1.Name = "labelVar1";
            this.labelVar1.Size = new System.Drawing.Size(29, 20);
            this.labelVar1.TabIndex = 99;
            this.labelVar1.Text = "x +";
            this.labelVar1.Visible = false;
            // 
            // textBoxCoefficient1
            // 
            this.textBoxCoefficient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient1.Location = new System.Drawing.Point(487, 32);
            this.textBoxCoefficient1.Name = "textBoxCoefficient1";
            this.textBoxCoefficient1.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient1.TabIndex = 6;
            this.textBoxCoefficient1.Visible = false;
            this.textBoxCoefficient1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient1_KeyPress);
            // 
            // labelVar4
            // 
            this.labelVar4.AutoSize = true;
            this.labelVar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar4.Location = new System.Drawing.Point(236, 35);
            this.labelVar4.Name = "labelVar4";
            this.labelVar4.Size = new System.Drawing.Size(34, 20);
            this.labelVar4.TabIndex = 14;
            this.labelVar4.Text = "x⁴ +";
            this.labelVar4.Visible = false;
            // 
            // textBoxCoefficient4
            // 
            this.textBoxCoefficient4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient4.Location = new System.Drawing.Point(172, 32);
            this.textBoxCoefficient4.Name = "textBoxCoefficient4";
            this.textBoxCoefficient4.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient4.TabIndex = 3;
            this.textBoxCoefficient4.Visible = false;
            this.textBoxCoefficient4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient4_KeyPress);
            // 
            // textBoxCoefficient5
            // 
            this.textBoxCoefficient5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoefficient5.Location = new System.Drawing.Point(66, 32);
            this.textBoxCoefficient5.Name = "textBoxCoefficient5";
            this.textBoxCoefficient5.Size = new System.Drawing.Size(58, 26);
            this.textBoxCoefficient5.TabIndex = 2;
            this.textBoxCoefficient5.Visible = false;
            this.textBoxCoefficient5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCoefficient5_KeyPress);
            // 
            // labelVar5
            // 
            this.labelVar5.AutoSize = true;
            this.labelVar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar5.Location = new System.Drawing.Point(132, 35);
            this.labelVar5.Name = "labelVar5";
            this.labelVar5.Size = new System.Drawing.Size(34, 20);
            this.labelVar5.TabIndex = 16;
            this.labelVar5.Text = "x⁵ +";
            this.labelVar5.Visible = false;
            // 
            // labelVar0
            // 
            this.labelVar0.AutoSize = true;
            this.labelVar0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar0.Location = new System.Drawing.Point(516, 9);
            this.labelVar0.Name = "labelVar0";
            this.labelVar0.Size = new System.Drawing.Size(0, 20);
            this.labelVar0.TabIndex = 17;
            this.labelVar0.Visible = false;
            // 
            // groupBoxEquation
            // 
            this.groupBoxEquation.Controls.Add(this.labelVar0);
            this.groupBoxEquation.Controls.Add(this.labelVar5);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient5);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient4);
            this.groupBoxEquation.Controls.Add(this.labelVar4);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient1);
            this.groupBoxEquation.Controls.Add(this.labelVar1);
            this.groupBoxEquation.Controls.Add(this.labelVar3);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient3);
            this.groupBoxEquation.Controls.Add(this.label2);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient2);
            this.groupBoxEquation.Controls.Add(this.label4);
            this.groupBoxEquation.Controls.Add(this.textBoxCoefficient0);
            this.groupBoxEquation.Controls.Add(this.labelVar2);
            this.groupBoxEquation.Location = new System.Drawing.Point(12, 94);
            this.groupBoxEquation.Name = "groupBoxEquation";
            this.groupBoxEquation.Size = new System.Drawing.Size(714, 82);
            this.groupBoxEquation.TabIndex = 12;
            this.groupBoxEquation.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 446);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEquation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDegree);
            this.Controls.Add(this.buttonFindRoots);
            this.Controls.Add(this.labelDegree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение алгебраических уравнений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBoxEquation.ResumeLayout(false);
            this.groupBoxEquation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.Button buttonFindRoots;
        private System.Windows.Forms.Label labelRoot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFunc1;
        private System.Windows.Forms.Label labelRoot5;
        private System.Windows.Forms.Label labelRoot4;
        private System.Windows.Forms.Label labelRoot3;
        private System.Windows.Forms.Label labelRoot2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVar2;
        private System.Windows.Forms.TextBox textBoxCoefficient0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCoefficient2;
        private System.Windows.Forms.Label label2;
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
    }
}

