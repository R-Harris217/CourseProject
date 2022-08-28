namespace CourseProject_RobinHarris
{
    partial class HarrisZoo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedingTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.feedingTablesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landAnimalsToolStripMenuItem,
            this.waterAnimalsToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newToolStripMenuItem.Text = "New Tracker";
            // 
            // landAnimalsToolStripMenuItem
            // 
            this.landAnimalsToolStripMenuItem.Name = "landAnimalsToolStripMenuItem";
            this.landAnimalsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.landAnimalsToolStripMenuItem.Text = "Land Animals";
            this.landAnimalsToolStripMenuItem.Click += new System.EventHandler(this.landAnimalsToolStripMenuItem_Click);
            // 
            // waterAnimalsToolStripMenuItem
            // 
            this.waterAnimalsToolStripMenuItem.Name = "waterAnimalsToolStripMenuItem";
            this.waterAnimalsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.waterAnimalsToolStripMenuItem.Text = "Water Animals";
            this.waterAnimalsToolStripMenuItem.Click += new System.EventHandler(this.waterAnimalsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // feedingTablesToolStripMenuItem
            // 
            this.feedingTablesToolStripMenuItem.Name = "feedingTablesToolStripMenuItem";
            this.feedingTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feedingTablesToolStripMenuItem.Text = "Feeding Tables";
            this.feedingTablesToolStripMenuItem.Click += new System.EventHandler(this.feedingTablesToolStripMenuItem_Click);
            // 
            // HarrisZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HarrisZoo";
            this.Text = "Harris Zoo Animal Feeding Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedingTablesToolStripMenuItem;
    }
}

