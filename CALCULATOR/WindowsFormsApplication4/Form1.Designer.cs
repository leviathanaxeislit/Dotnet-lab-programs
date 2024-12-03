namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondot = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(11, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // buttondiv
            // 
            this.buttondiv.Location = new System.Drawing.Point(149, 75);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(39, 43);
            this.buttondiv.TabIndex = 3;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.operator_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(194, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 43);
            this.button6.TabIndex = 9;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.Location = new System.Drawing.Point(149, 124);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(39, 43);
            this.buttonmul.TabIndex = 8;
            this.buttonmul.Text = "*";
            this.buttonmul.UseVisualStyleBackColor = true;
            this.buttonmul.Click += new System.EventHandler(this.operator_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(104, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(59, 123);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 43);
            this.button9.TabIndex = 6;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 123);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 44);
            this.button10.TabIndex = 5;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(194, 173);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 96);
            this.button11.TabIndex = 14;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Location = new System.Drawing.Point(149, 173);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(39, 43);
            this.buttonminus.TabIndex = 13;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(104, 172);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 43);
            this.button13.TabIndex = 12;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(59, 172);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 43);
            this.button14.TabIndex = 11;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(11, 172);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 44);
            this.button15.TabIndex = 10;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(149, 222);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(39, 43);
            this.buttonadd.TabIndex = 18;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.operator_click);
            // 
            // buttondot
            // 
            this.buttondot.Location = new System.Drawing.Point(104, 221);
            this.buttondot.Name = "buttondot";
            this.buttondot.Size = new System.Drawing.Size(39, 43);
            this.buttondot.TabIndex = 17;
            this.buttondot.Text = ".";
            this.buttondot.UseVisualStyleBackColor = true;
            this.buttondot.Click += new System.EventHandler(this.button_click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(11, 221);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(87, 44);
            this.button19.TabIndex = 15;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentOperation.TabIndex = 19;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(11, 32);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(217, 26);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 281);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttondot);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonmul);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttondiv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonmul;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondot;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

