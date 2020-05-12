namespace PolitechLab2b
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSides = new System.Windows.Forms.Label();
            this.LabelIsTriangle = new System.Windows.Forms.Label();
            this.LabelSquarePerimeter = new System.Windows.Forms.Label();
            this.labelCos = new System.Windows.Forms.Label();
            this.labelEqualTriangle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY3 = new System.Windows.Forms.NumericUpDown();
            this.SaveData = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Get results ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input X1 of point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Y1 of point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input Y2 of point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input X2 of point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input Y3 of point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Input X3 of point";
            // 
            // labelSides
            // 
            this.labelSides.AutoSize = true;
            this.labelSides.Location = new System.Drawing.Point(241, 172);
            this.labelSides.Name = "labelSides";
            this.labelSides.Size = new System.Drawing.Size(0, 17);
            this.labelSides.TabIndex = 14;
            // 
            // LabelIsTriangle
            // 
            this.LabelIsTriangle.AutoSize = true;
            this.LabelIsTriangle.Location = new System.Drawing.Point(241, 112);
            this.LabelIsTriangle.Name = "LabelIsTriangle";
            this.LabelIsTriangle.Size = new System.Drawing.Size(0, 17);
            this.LabelIsTriangle.TabIndex = 21;
            // 
            // LabelSquarePerimeter
            // 
            this.LabelSquarePerimeter.AutoSize = true;
            this.LabelSquarePerimeter.Location = new System.Drawing.Point(241, 220);
            this.LabelSquarePerimeter.Name = "LabelSquarePerimeter";
            this.LabelSquarePerimeter.Size = new System.Drawing.Size(0, 17);
            this.LabelSquarePerimeter.TabIndex = 22;
            // 
            // labelCos
            // 
            this.labelCos.AutoSize = true;
            this.labelCos.Location = new System.Drawing.Point(241, 265);
            this.labelCos.Name = "labelCos";
            this.labelCos.Size = new System.Drawing.Size(0, 17);
            this.labelCos.TabIndex = 23;
            // 
            // labelEqualTriangle
            // 
            this.labelEqualTriangle.AutoSize = true;
            this.labelEqualTriangle.Location = new System.Drawing.Point(241, 311);
            this.labelEqualTriangle.Name = "labelEqualTriangle";
            this.labelEqualTriangle.Size = new System.Drawing.Size(0, 17);
            this.labelEqualTriangle.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Location = new System.Drawing.Point(27, 38);
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX1.TabIndex = 25;
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.Location = new System.Drawing.Point(27, 107);
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 26;
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Location = new System.Drawing.Point(27, 172);
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX2.TabIndex = 28;
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.Location = new System.Drawing.Point(27, 240);
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY2.TabIndex = 29;
            // 
            // numericUpDownX3
            // 
            this.numericUpDownX3.Location = new System.Drawing.Point(27, 309);
            this.numericUpDownX3.Name = "numericUpDownX3";
            this.numericUpDownX3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX3.TabIndex = 30;
            // 
            // numericUpDownY3
            // 
            this.numericUpDownY3.Location = new System.Drawing.Point(27, 371);
            this.numericUpDownY3.Name = "numericUpDownY3";
            this.numericUpDownY3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY3.TabIndex = 31;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(392, 38);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(91, 23);
            this.SaveData.TabIndex = 32;
            this.SaveData.Text = "SaveData";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(804, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.numericUpDownY3);
            this.Controls.Add(this.numericUpDownX3);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.labelEqualTriangle);
            this.Controls.Add(this.labelCos);
            this.Controls.Add(this.LabelSquarePerimeter);
            this.Controls.Add(this.LabelIsTriangle);
            this.Controls.Add(this.labelSides);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSides;
        private System.Windows.Forms.Label LabelIsTriangle;
        private System.Windows.Forms.Label LabelSquarePerimeter;
        private System.Windows.Forms.Label labelCos;
        private System.Windows.Forms.Label labelEqualTriangle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY3;
        private System.Windows.Forms.NumericUpDown numericUpDownX3;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

