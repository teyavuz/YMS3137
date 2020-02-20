namespace WFA_MovieTheater
{
    partial class MainMenu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salloonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSalloonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.salloonsToolStripMenuItem,
            this.sessionsToolStripMenuItem,
            this.weeksToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1605, 29);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMoviesToolStripMenuItem,
            this.addMovieToolStripMenuItem});
            this.moviesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // allMoviesToolStripMenuItem
            // 
            this.allMoviesToolStripMenuItem.Name = "allMoviesToolStripMenuItem";
            this.allMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.allMoviesToolStripMenuItem.Text = "All Movies";
            this.allMoviesToolStripMenuItem.Click += new System.EventHandler(this.allMoviesToolStripMenuItem_Click);
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCategoriesToolStripMenuItem,
            this.addCategoryToolStripMenuItem});
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // allCategoriesToolStripMenuItem
            // 
            this.allCategoriesToolStripMenuItem.Name = "allCategoriesToolStripMenuItem";
            this.allCategoriesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.allCategoriesToolStripMenuItem.Text = "All Categories";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            // 
            // salloonsToolStripMenuItem
            // 
            this.salloonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSalloonsToolStripMenuItem});
            this.salloonsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salloonsToolStripMenuItem.Name = "salloonsToolStripMenuItem";
            this.salloonsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.salloonsToolStripMenuItem.Text = "Salloons";
            // 
            // allSalloonsToolStripMenuItem
            // 
            this.allSalloonsToolStripMenuItem.Name = "allSalloonsToolStripMenuItem";
            this.allSalloonsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.allSalloonsToolStripMenuItem.Text = "All Salloons";
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionListToolStripMenuItem});
            this.sessionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // sessionListToolStripMenuItem
            // 
            this.sessionListToolStripMenuItem.Name = "sessionListToolStripMenuItem";
            this.sessionListToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.sessionListToolStripMenuItem.Text = "Session List";
            // 
            // weeksToolStripMenuItem
            // 
            this.weeksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weekListToolStripMenuItem});
            this.weeksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.weeksToolStripMenuItem.Name = "weeksToolStripMenuItem";
            this.weeksToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.weeksToolStripMenuItem.Text = "Weeks";
            // 
            // weekListToolStripMenuItem
            // 
            this.weekListToolStripMenuItem.Name = "weekListToolStripMenuItem";
            this.weekListToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.weekListToolStripMenuItem.Text = "Week List";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 804);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Main Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salloonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSalloonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekListToolStripMenuItem;
    }
}

