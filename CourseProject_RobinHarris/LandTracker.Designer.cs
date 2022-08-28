namespace CourseProject_RobinHarris
{
    partial class LandTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Carnivore");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Herbivore");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Omnivore");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lion");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tiger");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Carnivore", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Koala");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Elephant");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Herbivore", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Bear");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Omnivore", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "<==";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "==>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Not Fed";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(459, 356);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Carnivore";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Herbivore";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Omnivore";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView2.Size = new System.Drawing.Size(180, 152);
            this.treeView2.TabIndex = 21;
            this.treeView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(152, 356);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Lion";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Tiger";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Carnivore";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Koala";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Elephant";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Herbivore";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Bear";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Omnivore";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(180, 152);
            this.treeView1.TabIndex = 20;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // LandTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "LandTracker";
            this.Text = "Land Animal Feeding Tracker";
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.treeView2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
    }
}
