using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoRoundedButton
{
    public partial class FrmRndBtnDemo : Form
    {
        public FrmRndBtnDemo()
        {
            InitializeComponent();
        }

        private void BtnRndDemo_Click(object sender, EventArgs e)
        {
            if (BtnRndDemo.Text == "Click")
            {
                BtnRndDemo.Text = "I'm an Ellipse";
            }
            else
            {
                BtnRndDemo.Text = "Click";
            }
        }

        private void BtnRndAnother_Click(object sender, EventArgs e)
        {
            if (BtnRndAnother.Text == "Hello")
            {
                BtnRndAnother.Text = "Goodbye";
            }
            else
            {
                BtnRndAnother.Text = "Hello";
            }
        }
    }
}
