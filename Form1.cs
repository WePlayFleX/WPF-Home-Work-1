using System;
using System.Windows.Forms;

namespace WPF_Home_Work_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 2000;

            DialogResult result;
            int numDialog = 1;
            while (true)
            {
                result = MessageBox.Show($"{random.Next(minNumber, maxNumber)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество запросов {numDialog}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    result = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                numDialog++;
            }
        }
    }
}
