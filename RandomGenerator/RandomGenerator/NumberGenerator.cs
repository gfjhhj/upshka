using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class NumberGenerator : Form
    {
        public NumberGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            int min = (int)numericUpDown2.Value;
            int max = (int)numericUpDown3.Value;
            int num = (int)numericUpDown1.Value;
            for (int i = 0; i < num; i++)
            {
                listBox1.Items.Insert(i, random.Next(min, max));
            }
        }
    }
}
