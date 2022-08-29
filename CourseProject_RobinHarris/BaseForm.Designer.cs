namespace CourseProject_RobinHarris
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedingTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(248, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 10);
            this.label2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.navigateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTrackerToolStripMenuItem,
            this.feedingTablesToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // newTrackerToolStripMenuItem
            // 
            this.newTrackerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landAnimalsToolStripMenuItem,
            this.waterAnimalsToolStripMenuItem});
            this.newTrackerToolStripMenuItem.Name = "newTrackerToolStripMenuItem";
            this.newTrackerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTrackerToolStripMenuItem.Text = "New Tracker";
            // 
            // landAnimalsToolStripMenuItem
            // 
            this.landAnimalsToolStripMenuItem.Name = "landAnimalsToolStripMenuItem";
            this.landAnimalsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.landAnimalsToolStripMenuItem.Text = "Land Animals";
            this.landAnimalsToolStripMenuItem.Click += new System.EventHandler(this.landAnimalsToolStripMenuItem_Click);
            // 
            // waterAnimalsToolStripMenuItem
            // 
            this.waterAnimalsToolStripMenuItem.Name = "waterAnimalsToolStripMenuItem";
            this.waterAnimalsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waterAnimalsToolStripMenuItem.Text = "Water Animals";
            this.waterAnimalsToolStripMenuItem.Click += new System.EventHandler(this.waterAnimalsToolStripMenuItem_Click);
            // 
            // feedingTablesToolStripMenuItem
            // 
            this.feedingTablesToolStripMenuItem.Name = "feedingTablesToolStripMenuItem";
            this.feedingTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedingTablesToolStripMenuItem.Text = "Feeding Tables";
            this.feedingTablesToolStripMenuItem.Click += new System.EventHandler(this.feedingTablesToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedingTablesToolStripMenuItem;
    }
}