using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_RobinHarris
{
    public partial class HarrisZoo : Form
    {
        public HarrisZoo()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void landAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandTracker newLandTracker = new LandTracker();
            newLandTracker.MdiParent = this;
            newLandTracker.Show();
        }

        private void waterAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaterTracker newWaterTracker = new WaterTracker();
            newWaterTracker.MdiParent = this;
            newWaterTracker.Show();
        }

        private void feedingTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedingTables newFeedingTables = new FeedingTables();
            newFeedingTables.MdiParent = this;
            newFeedingTables.Show();
        }

        public void GetPrintControl()
        {
            printDialog1.Document = printDocument1;
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
