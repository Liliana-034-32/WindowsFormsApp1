using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 m_parent;

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            m_parent = frm1;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofd.FileName;
            textBox1.Text = System.IO.File.SetLastWriteTime(string path, DataTime lastWriteTime);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
