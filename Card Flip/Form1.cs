using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class Flip_Card : Form
    {
        public Flip_Card()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            picCardBack.Visible = true;
            picCardShow.Visible = false;
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            picCardBack.Visible = false;
            picCardShow.Visible = true;
        }

        private void Flip_Card_Load(object sender, EventArgs e)
        {
            picCardShow.Visible = false;
            btnFront.Visible = true;
            btnBack.Visible = true;
        }
    }
}
