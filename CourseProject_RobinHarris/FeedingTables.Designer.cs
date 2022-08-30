namespace CourseProject_RobinHarris
{
    partial class FeedingTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedingTables));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedingTableDataSet = new CourseProject_RobinHarris.FeedingTableDataSet();
            this.landAnimalTableAdapter = new CourseProject_RobinHarris.FeedingTableDataSetTableAdapters.LandAnimalTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.animalNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalFoodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedingTableDataSet1 = new CourseProject_RobinHarris.FeedingTableDataSet1();
            this.feedingTableDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterAnimalTableAdapter = new CourseProject_RobinHarris.FeedingTableDataSet1TableAdapters.WaterAnimalTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Harris Zoo Animal Feeding Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Land Animals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Water Animals";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalNameDataGridViewTextBoxColumn,
            this.animalFoodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.landAnimalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 225);
            this.dataGridView1.TabIndex = 19;
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
            // landAnimalBindingSource
            // 
            this.landAnimalBindingSource.DataMember = "LandAnimal";
            this.landAnimalBindingSource.DataSource = this.feedingTableDataSet;
            // 
            // feedingTableDataSet
            // 
            this.feedingTableDataSet.DataSetName = "FeedingTableDataSet";
            this.feedingTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // landAnimalTableAdapter
            // 
            this.landAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalNameDataGridViewTextBoxColumn1,
            this.animalFoodDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.waterAnimalBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(447, 217);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 225);
            this.dataGridView2.TabIndex = 20;
            // 
            // animalNameDataGridViewTextBoxColumn1
            // 
            this.animalNameDataGridViewTextBoxColumn1.DataPropertyName = "AnimalName";
            this.animalNameDataGridViewTextBoxColumn1.HeaderText = "Animal Name";
            this.animalNameDataGridViewTextBoxColumn1.Name = "animalNameDataGridViewTextBoxColumn1";
            // 
            // animalFoodDataGridViewTextBoxColumn1
            // 
            this.animalFoodDataGridViewTextBoxColumn1.DataPropertyName = "AnimalFood";
            this.animalFoodDataGridViewTextBoxColumn1.HeaderText = "Animal Food";
            this.animalFoodDataGridViewTextBoxColumn1.Name = "animalFoodDataGridViewTextBoxColumn1";
            // 
            // waterAnimalBindingSource
            // 
            this.waterAnimalBindingSource.DataMember = "WaterAnimal";
            this.waterAnimalBindingSource.DataSource = this.feedingTableDataSet1;
            // 
            // feedingTableDataSet1
            // 
            this.feedingTableDataSet1.DataSetName = "FeedingTableDataSet1";
            this.feedingTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedingTableDataSetBindingSource
            // 
            this.feedingTableDataSetBindingSource.DataSource = this.feedingTableDataSet;
            this.feedingTableDataSetBindingSource.Position = 0;
            // 
            // waterAnimalTableAdapter
            // 
            this.waterAnimalTableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(60, 483);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "&Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FeedingTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FeedingTables";
            this.Load += new System.EventHandler(this.FeedingTables_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.printButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedingTableDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FeedingTableDataSet feedingTableDataSet;
        private System.Windows.Forms.BindingSource landAnimalBindingSource;
        private FeedingTableDataSetTableAdapters.LandAnimalTableAdapter landAnimalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource feedingTableDataSetBindingSource;
        private FeedingTableDataSet1 feedingTableDataSet1;
        private System.Windows.Forms.BindingSource waterAnimalBindingSource;
        private FeedingTableDataSet1TableAdapters.WaterAnimalTableAdapter waterAnimalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalFoodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
