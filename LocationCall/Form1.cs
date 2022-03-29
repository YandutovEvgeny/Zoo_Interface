using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationCall
{
    public partial class Form1 : Form
    {
        ICaller caller;
        int RUB = 200;
        public Form1()
        {
            InitializeComponent();
            caller = new MobilePhone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUB -= caller.Call(Convert.ToInt32(textBox1.Text));
            if (RUB < 0)
            {
                MessageBox.Show("У вас нет средств!\nНевозможно совершить звонок!");
                return;
            }
            label1.Text = "Средства: " + RUB.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            caller = new MobilePhone();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            caller = new Skype();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            caller = new StationPhone();
        }
    }
}
