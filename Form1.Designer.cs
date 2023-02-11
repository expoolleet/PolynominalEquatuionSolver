
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
            this.labelDegree = new System.Windows.Forms.Label();
            this.buttonFindRoots = new System.Windows.Forms.Button();
            this.textBoxCoefficient2 = new System.Windows.Forms.TextBox();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoefficient1 = new System.Windows.Forms.TextBox();
            this.labelVar2 = new System.Windows.Forms.Label();
            this.labelVar1 = new System.Windows.Forms.Label();
            this.textBoxCoefficient0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxEquation = new System.Windows.Forms.GroupBox();
            this.labelVar0 = new System.Windows.Forms.Label();
            this.labelVar5 = new System.Windows.Forms.Label();
            this.textBoxCoefficient5 = new System.Windows.Forms.TextBox();
            this.textBoxCoefficient4 = new System.Windows.Forms.TextBox();
            this.labelVar4 = new System.Windows.Forms.Label();
            this.labelVar3 = new System.Windows.Forms.Label();
            this.textBoxCoefficient3 = new System.Windows.Forms.TextBox();
            this.labelRoot1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFunc = new System.Windows.Forms.Label();
            this.labelRoot5 = new System.Windows.Forms.Label();
            this.labelRoot4 = new System.Windows.Forms.Label();
            this.labelRoot3 = new System.Windows.Forms.Label();
            this.labelRoot2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxEquation.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.buttonFindRoots.Location = new System.Drawing.Point(308, 182);
            this.buttonFindRoots.Name = "buttonFindRoots";
            this.buttonFindRoots.Size = new System.Drawing.Size(161, 51);
            this.buttonFindRoots.TabIndex = 8;
            this.buttonFindRoots.Text = "Найти корни";
            this.buttonFindRoots.UseVisualStyleBackColor = true;
            this.buttonFindRoots.Click += new System.EventHandler(this.buttonFindRoots_Click);
            // 
            // textBoxCoefficient2
            // 
            this.textBoxCoefficient2.Location = new System.Drawing.Point(262, 36);
            this.textBoxCoefficient2.Name = "textBoxCoefficient2";
            this.textBoxCoefficient2.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient2.TabIndex = 5;
            this.textBoxCoefficient2.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "f(x) =";
            // 
            // textBoxCoefficient1
            // 
            this.textBoxCoefficient1.Location = new System.Drawing.Point(331, 36);
            this.textBoxCoefficient1.Name = "textBoxCoefficient1";
            this.textBoxCoefficient1.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient1.TabIndex = 6;
            this.textBoxCoefficient1.Visible = false;
            // 
            // labelVar2
            // 
            this.labelVar2.AutoSize = true;
            this.labelVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar2.Location = new System.Drawing.Point(291, 36);
            this.labelVar2.Name = "labelVar2";
            this.labelVar2.Size = new System.Drawing.Size(34, 20);
            this.labelVar2.TabIndex = 99;
            this.labelVar2.Text = "x² +";
            this.labelVar2.Visible = false;
            // 
            // labelVar1
            // 
            this.labelVar1.AutoSize = true;
            this.labelVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar1.Location = new System.Drawing.Point(358, 36);
            this.labelVar1.Name = "labelVar1";
            this.labelVar1.Size = new System.Drawing.Size(29, 20);
            this.labelVar1.TabIndex = 99;
            this.labelVar1.Text = "x +";
            this.labelVar1.Visible = false;
            // 
            // textBoxCoefficient0
            // 
            this.textBoxCoefficient0.Location = new System.Drawing.Point(394, 36);
            this.textBoxCoefficient0.Name = "textBoxCoefficient0";
            this.textBoxCoefficient0.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient0.TabIndex = 7;
            this.textBoxCoefficient0.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(425, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "= 0";
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
            this.groupBoxEquation.Size = new System.Drawing.Size(457, 82);
            this.groupBoxEquation.TabIndex = 12;
            this.groupBoxEquation.TabStop = false;
            // 
            // labelVar0
            // 
            this.labelVar0.AutoSize = true;
            this.labelVar0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar0.Location = new System.Drawing.Point(419, 36);
            this.labelVar0.Name = "labelVar0";
            this.labelVar0.Size = new System.Drawing.Size(0, 20);
            this.labelVar0.TabIndex = 17;
            this.labelVar0.Visible = false;
            // 
            // labelVar5
            // 
            this.labelVar5.AutoSize = true;
            this.labelVar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar5.Location = new System.Drawing.Point(82, 36);
            this.labelVar5.Name = "labelVar5";
            this.labelVar5.Size = new System.Drawing.Size(34, 20);
            this.labelVar5.TabIndex = 16;
            this.labelVar5.Text = "x⁵ +";
            this.labelVar5.Visible = false;
            // 
            // textBoxCoefficient5
            // 
            this.textBoxCoefficient5.Location = new System.Drawing.Point(51, 36);
            this.textBoxCoefficient5.Name = "textBoxCoefficient5";
            this.textBoxCoefficient5.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient5.TabIndex = 2;
            this.textBoxCoefficient5.Visible = false;
            // 
            // textBoxCoefficient4
            // 
            this.textBoxCoefficient4.Location = new System.Drawing.Point(122, 36);
            this.textBoxCoefficient4.Name = "textBoxCoefficient4";
            this.textBoxCoefficient4.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient4.TabIndex = 3;
            this.textBoxCoefficient4.Visible = false;
            // 
            // labelVar4
            // 
            this.labelVar4.AutoSize = true;
            this.labelVar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar4.Location = new System.Drawing.Point(151, 36);
            this.labelVar4.Name = "labelVar4";
            this.labelVar4.Size = new System.Drawing.Size(34, 20);
            this.labelVar4.TabIndex = 14;
            this.labelVar4.Text = "x⁴ +";
            this.labelVar4.Visible = false;
            // 
            // labelVar3
            // 
            this.labelVar3.AutoSize = true;
            this.labelVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVar3.Location = new System.Drawing.Point(222, 36);
            this.labelVar3.Name = "labelVar3";
            this.labelVar3.Size = new System.Drawing.Size(34, 20);
            this.labelVar3.TabIndex = 12;
            this.labelVar3.Text = "x³ +";
            this.labelVar3.Visible = false;
            // 
            // textBoxCoefficient3
            // 
            this.textBoxCoefficient3.Location = new System.Drawing.Point(191, 36);
            this.textBoxCoefficient3.Name = "textBoxCoefficient3";
            this.textBoxCoefficient3.Size = new System.Drawing.Size(25, 20);
            this.textBoxCoefficient3.TabIndex = 4;
            this.textBoxCoefficient3.Visible = false;
            // 
            // labelRoot1
            // 
            this.labelRoot1.AutoSize = true;
            this.labelRoot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot1.Location = new System.Drawing.Point(9, 16);
            this.labelRoot1.Name = "labelRoot1";
            this.labelRoot1.Size = new System.Drawing.Size(38, 20);
            this.labelRoot1.TabIndex = 13;
            this.labelRoot1.Text = "x₁ = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFunc);
            this.groupBox1.Controls.Add(this.labelRoot5);
            this.groupBox1.Controls.Add(this.labelRoot4);
            this.groupBox1.Controls.Add(this.labelRoot3);
            this.groupBox1.Controls.Add(this.labelRoot2);
            this.groupBox1.Controls.Add(this.labelRoot1);
            this.groupBox1.Location = new System.Drawing.Point(308, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc.Location = new System.Drawing.Point(9, 116);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(48, 20);
            this.labelFunc.TabIndex = 18;
            this.labelFunc.Text = "f(x) = ";
            // 
            // labelRoot5
            // 
            this.labelRoot5.AutoSize = true;
            this.labelRoot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot5.Location = new System.Drawing.Point(9, 96);
            this.labelRoot5.Name = "labelRoot5";
            this.labelRoot5.Size = new System.Drawing.Size(38, 20);
            this.labelRoot5.TabIndex = 17;
            this.labelRoot5.Text = "x₅ = ";
            // 
            // labelRoot4
            // 
            this.labelRoot4.AutoSize = true;
            this.labelRoot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot4.Location = new System.Drawing.Point(9, 76);
            this.labelRoot4.Name = "labelRoot4";
            this.labelRoot4.Size = new System.Drawing.Size(38, 20);
            this.labelRoot4.TabIndex = 16;
            this.labelRoot4.Text = "x₄ = ";
            // 
            // labelRoot3
            // 
            this.labelRoot3.AutoSize = true;
            this.labelRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot3.Location = new System.Drawing.Point(9, 56);
            this.labelRoot3.Name = "labelRoot3";
            this.labelRoot3.Size = new System.Drawing.Size(38, 20);
            this.labelRoot3.TabIndex = 15;
            this.labelRoot3.Text = "x₃ = ";
            // 
            // labelRoot2
            // 
            this.labelRoot2.AutoSize = true;
            this.labelRoot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoot2.Location = new System.Drawing.Point(9, 36);
            this.labelRoot2.Name = "labelRoot2";
            this.labelRoot2.Size = new System.Drawing.Size(38, 20);
            this.labelRoot2.TabIndex = 14;
            this.labelRoot2.Text = "x₂ = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEquation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDegree);
            this.Controls.Add(this.buttonFindRoots);
            this.Controls.Add(this.labelDegree);
            this.Name = "MainForm";
            this.Text = "Решение алгебраических уравнений";
            this.groupBoxEquation.ResumeLayout(false);
            this.groupBoxEquation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.Button buttonFindRoots;
        private System.Windows.Forms.TextBox textBoxCoefficient2;
        private System.Windows.Forms.ComboBox comboBoxDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoefficient1;
        private System.Windows.Forms.Label labelVar2;
        private System.Windows.Forms.Label labelVar1;
        private System.Windows.Forms.TextBox textBoxCoefficient0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxEquation;
        private System.Windows.Forms.Label labelVar3;
        private System.Windows.Forms.TextBox textBoxCoefficient3;
        private System.Windows.Forms.Label labelVar5;
        private System.Windows.Forms.TextBox textBoxCoefficient5;
        private System.Windows.Forms.TextBox textBoxCoefficient4;
        private System.Windows.Forms.Label labelVar4;
        private System.Windows.Forms.Label labelRoot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFunc;
        private System.Windows.Forms.Label labelRoot5;
        private System.Windows.Forms.Label labelRoot4;
        private System.Windows.Forms.Label labelRoot3;
        private System.Windows.Forms.Label labelRoot2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelVar0;
    }
}

