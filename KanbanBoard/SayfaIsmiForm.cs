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
    public partial class SayfaIsmiForm : Form
    {
        public SayfaIsmiForm()
        {
            InitializeComponent();
        }

        Form1 MdiForm;
        public string cevap;

        private void btnSayfaAc_Click(object sender, EventArgs e)
        {

            MdiForm = (Form1)this.Owner;
            NotForm1 child = new NotForm1();
            child.MdiParent = MdiForm;
            child.Text = txtSayfaIsmi.Text;
            child.Show();
            this.Close();

            /*
            NotForm1 notForm =new NotForm1();
            notForm.MdiParent = frm1;
            
            notForm.Text = txtSayfaIsmi.Text;

            notForm.Width = 820;
            notForm.Height = 500;

            notForm.Show();
            */
        }

        private void SayfaIsmiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
