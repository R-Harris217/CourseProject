using System;
using System.Windows.Forms;

namespace CourseProject_RobinHarris
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void landAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandTracker landTracker = new LandTracker();
            landTracker.MdiParent = this.MdiParent;
            landTracker.Show();
        }

        private void waterAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaterTracker waterTracker = new WaterTracker();
            waterTracker.MdiParent = this.MdiParent;
            waterTracker.Show();
        }

        private void feedingTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedingTables feedingTables = new FeedingTables();
            feedingTables.MdiParent = this.MdiParent;  
            feedingTables.Show();
        }
    }
}
