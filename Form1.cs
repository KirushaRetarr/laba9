using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace laba9
{
    public partial class Form1 : Form
    {
        private float radius = 0;
        private float height = 0;
        private float density = 0;
        private double volume = 0;
        private double mass = 0;
        Form dilog1 = new Form();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxDialog1.Checked && checkBoxDialog2.Checked)
            {
                MessageBox.Show($"Объем конуса: {volume} кубических единиц\nМасса конуса: {mass} единиц массы", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (checkBoxDialog1.Checked && !checkBoxDialog2.Checked)
            {
                MessageBox.Show($"Объем конуса: {volume} кубических единиц", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (!checkBoxDialog1.Checked && checkBoxDialog2.Checked) 
            {
                MessageBox.Show($"Массу конуса невозможно рассчитать без объема", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDialog1_Click(object sender, EventArgs e)
        {
            try
            {
                radius = float.Parse(textBox1.Text);
                height = float.Parse(textBox2.Text);
                density = float.Parse(textBox3.Text);

                if (radius < 0)
                {
                    MessageBox.Show("Радиус не может быть отрицательным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (density <= 0)
                {
                    MessageBox.Show("Плотность должна быть положительной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                volume = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
                mass = volume * density;
                dilog1.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения! Возможны вы оставили поля пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dilog1.Text = "Input";
            dilog1.Size = new Size(390, 190);
            dilog1.Controls.Add(textBox1);
            dilog1.Controls.Add(textBox2);
            dilog1.Controls.Add(textBox3);
            dilog1.Controls.Add(labelDialog1);
            dilog1.Controls.Add(labelDialog2);
            dilog1.Controls.Add(labelDialog3);
            dilog1.Controls.Add(buttonDialog1);
            dilog1.Controls.Add(panelDialog1);
            dilog1.ShowDialog();
        }
    }
}
