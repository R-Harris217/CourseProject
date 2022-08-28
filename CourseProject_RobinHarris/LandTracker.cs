using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseProject_RobinHarris
{
    public partial class LandTracker : CourseProject_RobinHarris.Tracker
    {
        public LandTracker()
        {
            InitializeComponent();
        }

        private void TreeView_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void TreeView_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // check to be sure that the drag content is the correct type for this control 
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TreeView_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            TreeNode NewNode;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt;
                TreeNode DestinationNode;

                pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (!(DestinationNode.TreeView == NewNode.TreeView))
                {
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();

                    // remove original node 
                    NewNode.Remove();
                }
            }
        }
    }
}
