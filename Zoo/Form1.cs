using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        List<IAnimal> animals;
        
        public Form1()
        {
            InitializeComponent();
            animals = new List<IAnimal>()
            {
                new Cat("Барсик"),
                new Cat("Гав"),
                new Cat("Гарфилд"),
                new Elephant("Дамбо"),
                new Parrot("Кеша")
            };
            foreach (IAnimal animal in animals)
                listBox1.Items.Add(animal.GetName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>=0)
            {
                MessageBox.Show(animals[i].Voice());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i >= 0)
            {
                MessageBox.Show(animals[i].Feed());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parrot parrot = (Parrot)animals[4];
            MessageBox.Show(parrot.Fly(15));
        }
    }
}
