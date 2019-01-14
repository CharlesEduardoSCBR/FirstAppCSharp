using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First App C#");
        }

        private void pbOpenSource_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de contato 1.0. \nEscrito por Charles Eduardo", "About");
        }
    }
}
