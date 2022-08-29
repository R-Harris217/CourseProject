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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Mammals");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Fish");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Otters");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Walrus");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Sea Lions");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Dolphins");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Mammals", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Tiger Sharks");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Nurse Sharks");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Hammerhead Sharks");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Fish", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.feedingTableDataSet1 = new CourseProject_RobinHarris.FeedingTableDataSet1();
            this.waterAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterAnimalTableAdapter = new CourseProject_RobinHarris.FeedingTableDataSet1TableAdapters.WaterAnimalTableAdapter();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "<==";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "==>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Not Fed";
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(608, 272);
            this.treeView2.Name = "treeView2";
            treeNode34.Name = "Mammals";
            treeNode34.Text = "Mammals";
            treeNode35.Name = "Fish";
            treeNode35.Text = "Fish";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            this.treeView2.Size = new System.Drawing.Size(180, 152);
            this.treeView2.TabIndex = 21;
            this.treeView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(301, 272);
            this.treeView1.Name = "treeView1";
            treeNode36.Name = "Node2";
            treeNode36.Text = "Otters";
            treeNode37.Name = "Walrus";
            treeNode37.Text = "Walrus";
            treeNode38.Name = "Sea Lions";
            treeNode38.Text = "Sea Lions";
            treeNode39.Name = "Node6";
            treeNode39.Text = "Dolphins";
            treeNode40.Name = "Mammals";
            treeNode40.Text = "Mammals";
            treeNode41.Name = "Node8";
            treeNode41.Text = "Tiger Sharks";
            treeNode42.Name = "Node9";
            treeNode42.Text = "Nurse Sharks";
            treeNode43.Name = "Node10";
            treeNode43.Text = "Hammerhead Sharks";
            treeNode44.Name = "Fish";
            treeNode44.Text = "Fish";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode44});
            this.treeView1.Size = new System.Drawing.Size(180, 152);
            this.treeView1.TabIndex = 20;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalNameDataGridViewTextBoxColumn,
            this.animalFoodDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.waterAnimalBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 225);
            this.dataGridView2.TabIndex = 26;
            // 
            // feedingTableDataSet1
            // 
            this.feedingTableDataSet1.DataSetName = "FeedingTableDataSet1";
            this.feedingTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waterAnimalBindingSource
            // 
            this.waterAnimalBindingSource.DataMember = "WaterAnimal";
            this.waterAnimalBindingSource.DataSource = this.feedingTableDataSet1;
            // 
            // waterAnimalTableAdapter
            // 
            this.waterAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "AnimalName";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Animal Name";
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            // 
            // animalFoodDataGridViewTextBoxColumn
            // 
            this.animalFoodDataGridViewTextBoxColumn.DataPropertyName = "AnimalFood";
            this.animalFoodDataGridViewTextBoxColumn.HeaderText = "Animal Food";
            this.animalFoodDataGridViewTextBoxColumn.Name = "animalFoodDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Feeding Table";
            // 
            // WaterTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "WaterTracker";
            this.Text = "Water Animal Feeding Tracker";
            this.Load += new System.EventHandler(this.WaterTracker_Load);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.treeView2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterAnimalBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private FeedingTableDataSet1 feedingTableDataSet1;
        private System.Windows.Forms.BindingSource waterAnimalBindingSource;
        private FeedingTableDataSet1TableAdapters.WaterAnimalTableAdapter waterAnimalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}
