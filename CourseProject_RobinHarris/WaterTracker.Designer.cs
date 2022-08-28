namespace CourseProject_RobinHarris
{
    partial class WaterTracker
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mammals");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fish");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Otters");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Walrus");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sea Lions");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Dolphins");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mammals", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tiger Sharks");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nurse Sharks");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Hammerhead Sharks");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Fish", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
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
            this.label7.Location = new System.Drawing.Point(377, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "<==";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "==>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Not Fed";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(460, 357);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Mammals";
            treeNode1.Text = "Mammals";
            treeNode2.Name = "Fish";
            treeNode2.Text = "Fish";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView2.Size = new System.Drawing.Size(180, 152);
            this.treeView2.TabIndex = 21;
            this.treeView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(153, 357);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Otters";
            treeNode4.Name = "Walrus";
            treeNode4.Text = "Walrus";
            treeNode5.Name = "Sea Lions";
            treeNode5.Text = "Sea Lions";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Dolphins";
            treeNode7.Name = "Mammals";
            treeNode7.Text = "Mammals";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Tiger Sharks";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Nurse Sharks";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Hammerhead Sharks";
            treeNode11.Name = "Fish";
            treeNode11.Text = "Fish";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(180, 152);
            this.treeView1.TabIndex = 20;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // WaterTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "WaterTracker";
            this.Text = "Water Animal Feeding Tracker";
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
