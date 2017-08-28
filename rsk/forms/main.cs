using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rsk
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void groupDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmgroup myform = new frmgroup();
            myform.ShowDialog();

        }

        private void taxDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtax myform = new frmtax();
            myform.ShowDialog();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmitem myform = new frmitem();
           // myform.MdiParent = this;
           myform.ShowDialog();
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsupplier myform = new frmsupplier();
            myform.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcustomer myform = new frmcustomer();
            myform.ShowDialog();
        }

       
        private void itemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
