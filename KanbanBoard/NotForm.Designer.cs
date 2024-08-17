namespace KanbanBoard
{
    partial class NotForm
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
            this.txtNotForm = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTU YAZIN:";
            // 
            // txtNotForm
            // 
            this.txtNotForm.Location = new System.Drawing.Point(79, 44);
            this.txtNotForm.Multiline = true;
            this.txtNotForm.Name = "txtNotForm";
            this.txtNotForm.Size = new System.Drawing.Size(247, 106);
            this.txtNotForm.TabIndex = 1;
            this.txtNotForm.TextChanged += new System.EventHandler(this.txtNotForm_TextChanged);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(223, 223);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(103, 36);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kalan Karakter Sayınız:";
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanKarakter.Location = new System.Drawing.Point(263, 169);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(0, 16);
            this.lblKalanKarakter.TabIndex = 4;
            // 
            // NotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 295);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtNotForm);
            this.Controls.Add(this.label1);
            this.Name = "NotForm";
            this.Text = "NotForm";
            this.Load += new System.EventHandler(this.NotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotForm;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanKarakter;
    }
}