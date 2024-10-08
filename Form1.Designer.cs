namespace laba9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelDialog1 = new Panel();
            checkBoxDialog1 = new CheckBox();
            checkBoxDialog2 = new CheckBox();
            buttonDialog1 = new Button();
            label1 = new Label();
            labelDialog1 = new Label();
            labelDialog2 = new Label();
            labelDialog3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panelDialog1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(82, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 105);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(17, 74);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 38);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Work";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Input";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelDialog1
            // 
            panelDialog1.BorderStyle = BorderStyle.FixedSingle;
            panelDialog1.Controls.Add(checkBoxDialog1);
            panelDialog1.Controls.Add(checkBoxDialog2);
            panelDialog1.Location = new Point(220, 0);
            panelDialog1.Name = "panelDialog1";
            panelDialog1.Size = new Size(113, 80);
            panelDialog1.TabIndex = 0;
            // 
            // checkBoxDialog1
            // 
            checkBoxDialog1.AutoSize = true;
            checkBoxDialog1.Location = new Point(10, 15);
            checkBoxDialog1.Name = "checkBoxDialog1";
            checkBoxDialog1.Size = new Size(66, 19);
            checkBoxDialog1.TabIndex = 0;
            checkBoxDialog1.Text = "Volume";
            checkBoxDialog1.UseVisualStyleBackColor = true;
            // 
            // checkBoxDialog2
            // 
            checkBoxDialog2.AutoSize = true;
            checkBoxDialog2.Location = new Point(10, 35);
            checkBoxDialog2.Name = "checkBoxDialog2";
            checkBoxDialog2.Size = new Size(53, 19);
            checkBoxDialog2.TabIndex = 1;
            checkBoxDialog2.Text = "Mass";
            checkBoxDialog2.UseVisualStyleBackColor = true;
            // 
            // buttonDialog1
            // 
            buttonDialog1.Location = new Point(165, 120);
            buttonDialog1.Name = "buttonDialog1";
            buttonDialog1.Size = new Size(75, 23);
            buttonDialog1.TabIndex = 0;
            buttonDialog1.Text = "Accept";
            buttonDialog1.UseVisualStyleBackColor = true;
            buttonDialog1.Click += buttonDialog1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Меню";
            // 
            // labelDialog1
            // 
            labelDialog1.AutoSize = true;
            labelDialog1.Location = new Point(50, 5);
            labelDialog1.Name = "labelDialog1";
            labelDialog1.Size = new Size(40, 15);
            labelDialog1.TabIndex = 0;
            labelDialog1.Text = "Radius:";
            // 
            // labelDialog2
            // 
            labelDialog2.AutoSize = true;
            labelDialog2.Location = new Point(50, 45);
            labelDialog2.Name = "labelDialog2";
            labelDialog2.Size = new Size(40, 15);
            labelDialog2.TabIndex = 0;
            labelDialog2.Text = "Height:";
            // 
            // labelDialog3
            // 
            labelDialog3.AutoSize = true;
            labelDialog3.Location = new Point(50, 85);
            labelDialog3.Name = "labelDialog3";
            labelDialog3.Size = new Size(40, 15);
            labelDialog3.TabIndex = 0;
            labelDialog3.Text = "Density:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 153);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Лабораторная работа 9";
            panel1.ResumeLayout(false);
            panelDialog1.ResumeLayout(false);
            panelDialog1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelDialog1;
        private Label label1;
        private Label labelDialog1;
        private Label labelDialog2;
        private Label labelDialog3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonDialog1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBoxDialog1;
        private CheckBox checkBoxDialog2;
    }
}
