namespace KanbanBoard
{
    partial class Form1
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
            this.yeniFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniNotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniFormToolStripMenuItem
            // 
            this.yeniFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFormToolStripMenuItem1,
            this.yeniNotToolStripMenuItem});
            this.yeniFormToolStripMenuItem.Name = "yeniFormToolStripMenuItem";
            this.yeniFormToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.yeniFormToolStripMenuItem.Text = "Form İşlemleri";
            // 
            // yeniFormToolStripMenuItem1
            // 
            this.yeniFormToolStripMenuItem1.Name = "yeniFormToolStripMenuItem1";
            this.yeniFormToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yeniFormToolStripMenuItem1.Text = "Yeni Form";
            this.yeniFormToolStripMenuItem1.Click += new System.EventHandler(this.yeniFormToolStripMenuItem1_Click);
            // 
            // yeniNotToolStripMenuItem
            // 
            this.yeniNotToolStripMenuItem.Name = "yeniNotToolStripMenuItem";
            this.yeniNotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniNotToolStripMenuItem.Text = "Yeni Not";
            this.yeniNotToolStripMenuItem.Click += new System.EventHandler(this.yeniNotToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniNotToolStripMenuItem;
    }
}

