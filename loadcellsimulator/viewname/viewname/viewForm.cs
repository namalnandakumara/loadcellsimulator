using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewname
{
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
        }

        private void tBoxView_TextChanged(object sender, EventArgs e)
        {

        }

        public void ViewE(string data)
        {
            // Implement your view logic here
             tBoxView.Text = data;


        }

        public void datareceiver(string data)
        {
            tBoxView.Text = data;
        }

    }
}
