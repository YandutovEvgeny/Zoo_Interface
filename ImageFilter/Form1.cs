﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilter
{
    public partial class Form1 : Form
    {
        List<IFilter> filtres;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            filtres = new List<IFilter>()
            { 
                new BlackAndWhite(),
                new WhiteAndGray(),
                new GreenFilter(),
                new Negative(),
                new Mirror()
            };
            for (int i = 0; i < filtres.Count; i++)
                listBox1.Items.Add(filtres[i].GetName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = bitmap;
            }     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bitmap != null)  //Если картинка есть
            {
                int i = listBox1.SelectedIndex;
                if(i>=0)
                {
                    bitmap = filtres[i].Apply(bitmap);
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bitmap != null)
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    bitmap.Save(saveFileDialog1.FileName);
                }
            }
        }
    }
}
