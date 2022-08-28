using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //private void newToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Tracker newTracker = new Tracker();
        //    newTracker.MdiParent = this;
        //    newTracker.Show();
        //}

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
    }
}
