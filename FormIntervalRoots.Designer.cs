
namespace PolynomialCalculation
{
    partial class FormIntervalRoots
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
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.trackBarAccuracy = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(101, 214);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(123, 52);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Найти корни";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLeft.Location = new System.Drawing.Point(9, 56);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(132, 24);
            this.textBoxLeft.TabIndex = 1;
            this.textBoxLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxRight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxLeft);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Интервал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Правая граница";
            // 
            // textBoxRight
            // 
            this.textBoxRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRight.Location = new System.Drawing.Point(166, 56);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(135, 24);
            this.textBoxRight.TabIndex = 3;
            this.textBoxRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Левая граница";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAccuracy);
            this.groupBox2.Controls.Add(this.trackBarAccuracy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(307, 84);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Точность";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAccuracy.Location = new System.Drawing.Point(185, 31);
            this.textBoxAccuracy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.ReadOnly = true;
            this.textBoxAccuracy.Size = new System.Drawing.Size(98, 26);
            this.textBoxAccuracy.TabIndex = 33;
            this.textBoxAccuracy.Text = "0,01";
            this.textBoxAccuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarAccuracy
            // 
            this.trackBarAccuracy.Location = new System.Drawing.Point(8, 31);
            this.trackBarAccuracy.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarAccuracy.Maximum = 15;
            this.trackBarAccuracy.Name = "trackBarAccuracy";
            this.trackBarAccuracy.Size = new System.Drawing.Size(169, 45);
            this.trackBarAccuracy.TabIndex = 18;
            this.trackBarAccuracy.Value = 2;
            this.trackBarAccuracy.Scroll += new System.EventHandler(this.trackBarAccuracy_Scroll);
            // 
            // FormIntervalRoots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIntervalRoots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нахождение корней в интервале";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAccuracy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAccuracy;
        private System.Windows.Forms.TrackBar trackBarAccuracy;
    }
}