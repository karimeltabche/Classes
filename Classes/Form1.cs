using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstName.Items.Clear();

            Pet myDog = new Pet();
            Pet myNewDog = new Pet(txtName.Text);

            lstName.Items.Add(myDog.Name);
            myDog.Name=txtName.Text;
            lstName.Items.Add(myDog.Name);

            lstName.Items.Add(myNewDog.Name);

            
        }
    }
}
