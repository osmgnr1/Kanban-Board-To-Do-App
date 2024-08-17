namespace KanbanBoard
{
    partial class SayfaIsmiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayfaIsmi = new System.Windows.Forms.TextBox();
            this.btnSayfaAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayfa İsmi:";
            // 
            // txtSayfaIsmi
            // 
            this.txtSayfaIsmi.Location = new System.Drawing.Point(163, 63);
            this.txtSayfaIsmi.Name = "txtSayfaIsmi";
            this.txtSayfaIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaIsmi.TabIndex = 1;
            // 
            // btnSayfaAc
            // 
            this.btnSayfaAc.Location = new System.Drawing.Point(174, 99);
            this.btnSayfaAc.Name = "btnSayfaAc";
            this.btnSayfaAc.Size = new System.Drawing.Size(89, 35);
            this.btnSayfaAc.TabIndex = 2;
            this.btnSayfaAc.Text = "Sayfa Aç";
            this.btnSayfaAc.UseVisualStyleBackColor = true;
            this.btnSayfaAc.Click += new System.EventHandler(this.btnSayfaAc_Click);
            // 
            // SayfaIsmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 185);
            this.Controls.Add(this.btnSayfaAc);
            this.Controls.Add(this.txtSayfaIsmi);
            this.Controls.Add(this.label1);
            this.Name = "SayfaIsmiForm";
            this.Text = "SayfaIsmiForm";
            this.Load += new System.EventHandler(this.SayfaIsmiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayfaIsmi;
        private System.Windows.Forms.Button btnSayfaAc;
    }
}