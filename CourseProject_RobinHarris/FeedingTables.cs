using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseProject_RobinHarris
{
    public partial class FeedingTables : CourseProject_RobinHarris.BaseForm
    {
        public FeedingTables()
        {
            InitializeComponent();
        }

        private void FeedingTables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedingTableDataSet1.WaterAnimal' table. You can move, or remove it, as needed.
            this.waterAnimalTableAdapter.Fill(this.feedingTableDataSet1.WaterAnimal);
            // TODO: This line of code loads data into the 'feedingTableDataSet.LandAnimal' table. You can move, or remove it, as needed.
            this.landAnimalTableAdapter.Fill(this.feedingTableDataSet.LandAnimal);

        }
    }
}
