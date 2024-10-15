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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelDialog1 = new Panel();
            checkBoxDialog1 = new CheckBox();
            checkBoxDialog2 = new CheckBox();
            buttonDialog1 = new Button();
            labelDialog1 = new Label();
            labelDialog2 = new Label();
            labelDialog3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            panelDialog1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(275, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(39, 22);
            toolStripButton1.Text = "input";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(37, 22);
            toolStripButton2.Text = "work";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(30, 22);
            toolStripButton3.Text = "exit";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 125);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Лабораторная работа 9";
            panelDialog1.ResumeLayout(false);
            panelDialog1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelDialog1;
        private Label labelDialog1;
        private Label labelDialog2;
        private Label labelDialog3;
        private Button buttonDialog1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBoxDialog1;
        private CheckBox checkBoxDialog2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
