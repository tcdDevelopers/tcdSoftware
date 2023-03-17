namespace TCDApplication
{
    partial class MainForm
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
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTransactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.customerTransactionToolStripMenuItem,
            this.expensesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectDetailsToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.projectToolStripMenuItem.Text = "Project Details";
            // 
            // projectDetailsToolStripMenuItem
            // 
            this.projectDetailsToolStripMenuItem.Name = "projectDetailsToolStripMenuItem";
            this.projectDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.projectDetailsToolStripMenuItem.Text = "Add";
            this.projectDetailsToolStripMenuItem.Click += new System.EventHandler(this.projectDetailsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.searchCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.customerToolStripMenuItem.Text = "Customer Details";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.customerDetailsToolStripMenuItem.Text = "Add Customer";
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            // 
            // customerTransactionToolStripMenuItem
            // 
            this.customerTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerTransactionDetailsToolStripMenuItem});
            this.customerTransactionToolStripMenuItem.Name = "customerTransactionToolStripMenuItem";
            this.customerTransactionToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.customerTransactionToolStripMenuItem.Text = "Customer Transaction";
            // 
            // customerTransactionDetailsToolStripMenuItem
            // 
            this.customerTransactionDetailsToolStripMenuItem.Name = "customerTransactionDetailsToolStripMenuItem";
            this.customerTransactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.customerTransactionDetailsToolStripMenuItem.Text = "Customer Transaction Details";
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCDApplication.Properties.Resources.TCD_Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
    }
}