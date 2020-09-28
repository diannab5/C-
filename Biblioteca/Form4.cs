using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(),DragDropEffects.Copy);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
