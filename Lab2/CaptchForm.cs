using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class CaptchForm : Form
    {
        public CaptchForm()
        {
            InitializeComponent();
        }
        private string Captch;

        private void textBoxCaptch_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxCaptch.Text == Captch)
                Close();
        }

        private void CaptchForm_Load(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateCaptch();
        }
        private void CreateCaptch()
        {
            timer1.Stop();
            String combination = "0123456789АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Captch = null;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                Captch += combination[r.Next(combination.Length)];
            LabelCaptch.Text = Captch;
            timer1.Start();
        }
        private void LabelCaptch_Click(object sender, EventArgs e)
        {

        }
    }
}
