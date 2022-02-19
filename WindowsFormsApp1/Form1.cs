using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Form2 m_son; 

        public Form1(Form2 frm2)
        {
            InitializeComponent();
            this.Click += new EventHandler(button2_Click);
            m_son = frm2;
        }

        public string Data
        {
            get
            {
                return textBox1.Text;
            }
        }
        /* string password = "qwerty123", input = string.Empty;
         while (input != password)
         {
             Console.WriteLine("Введите пароль:");
             input = Console.ReadLine();
         }
         Console.WriteLine("Пароль принят");
         Console.Read();*/

        /*private static Mutex m_instance;
        private const string m_appName = "MyAppName";

        /// <summary>
        /// попытка установить Mutex
        /// </summary>
        /// <returns></returns>
        private static bool SetMutexFailed()
        {
            bool tryCreateNewApp;
            m_instance = new Mutex(true, m_appName, out tryCreateNewApp);
            return !tryCreateNewApp;
        }

        static void Main()
        {
            if (SetMutexFailed())
            {
                MessageBox.Show("Программа уже запущена на вашем компьютере");
                return;
            }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            /* OpenFileDialog OPF = new OpenFileDialog();
             OPF.Multiselect = true;
             if (OPF.ShowDialog() == DialogResult.OK)
             {
                 foreach(string file in OPF.FileNames)
                 {
                     MessageBox.Show(file);
                 }
             }*/
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofd.FileName;
            label1.Text = System.IO.File.GetCreationTime(ofd.FileName).ToString();
            label2.Text = System.IO.File.GetLastWriteTime(ofd.FileName).ToString();

            // Меняем дату последней операции записи в файл
           // System.IO.File.SetLastWriteTime(@"H:\test.txt", new DateTime(1988, 10, 22));

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           // this.textBox1.Text = f.Data;
        }
    }
}
