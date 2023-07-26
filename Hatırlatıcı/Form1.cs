using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Hatırlatıcı
{
 
    public partial class Form1 : Form
    {
        string saat="";
        string tarih ="" ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH.mm.ss";
            timer1.Start();
            label4.Visible = false;
            label5.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy");
            label2.Text = DateTime.Now.ToString("HH.mm.ss");
            
            if (label1.Text == tarih && label2.Text == saat)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = textBox2.Text;
                MessageBox.Show(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Text;
            saat = dateTimePicker2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            textBox2.Text = openFileDialog1.FileName;
        }
    }
}
