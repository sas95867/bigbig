using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigbig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        int randomNum = new Random().Next(6)+1;
            //MessageBox.Show(this, "老大是否能用馬眼吸珍珠?", "提問", MessageBoxButtons.YesNo);
            //MessageBox.Show("老大馬眼是黑洞屌?", "提問", MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show($"你骰出了 {randomNum}", "骰子點數", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         


        }
    }
}
