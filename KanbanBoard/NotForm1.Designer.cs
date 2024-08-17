namespace KanbanBoard
{
    partial class NotForm1
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "DONE";
            // 
            // lstDone
            // 
            this.lstDone.AllowDrop = true;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(540, 68);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(200, 342);
            this.lstDone.TabIndex = 10;
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDone_DragDrop);
            this.lstDone.DragOver += new System.Windows.Forms.DragEventHandler(this.lstDone_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "DOING";
            // 
            // lstDoing
            // 
            this.lstDoing.AllowDrop = true;
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.Location = new System.Drawing.Point(294, 68);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(200, 342);
            this.lstDoing.TabIndex = 8;
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDoing_DragDrop);
            this.lstDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.lstDoing_DragOver);
            this.lstDoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstDoing_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "TO DO";
            // 
            // lstToDo
            // 
            this.lstToDo.AllowDrop = true;
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.Location = new System.Drawing.Point(41, 68);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(200, 342);
            this.lstToDo.TabIndex = 6;
            this.lstToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstToDo_MouseDown);
            // 
            // NotForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDoing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstToDo);
            this.Name = "NotForm1";
            this.Text = "NotForm1";
            this.Load += new System.EventHandler(this.NotForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstToDo;
    }
}