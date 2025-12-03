using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lab1.FolderforModel;

namespace Lab1
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }
        public void Fill(Table_Motorbike Motorbike)
        {
            LabelIDData.Text = Motorbike.ID;
            LabelModelData.Text = Motorbike.Model;
            LabelBrandData.Text = Motorbike.Brand;
            LabelPriceData.Text = Motorbike.Price;
            LabelHorsepowerData.Text = Motorbike.Horspower;
            LabelMileageData.Text = Motorbike.Mileage;
            PictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
