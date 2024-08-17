using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }
        public Form1 frm1;
        int kapasite = 140;
        private void NotForm_Load(object sender, EventArgs e)
        {
            lblKalanKarakter.Text = kapasite.ToString();
        }

        private void txtNotForm_TextChanged(object sender, EventArgs e)
        {
            int suanKacKarakterVar = txtNotForm.TextLength;
            int fark = kapasite - suanKacKarakterVar;
            lblKalanKarakter.Text = fark.ToString();

            if (fark == 0)
            {
                MessageBox.Show("Maksimum sayıya ulaştınız.");
            }

        }




        
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            frm1 =(Form1) this.Owner;
            ((NotForm1)frm1.ActiveMdiChild).yeniNotEkle(txtNotForm.Text);
            this.Hide();
            txtNotForm.Text = "";
        }
    }
}
