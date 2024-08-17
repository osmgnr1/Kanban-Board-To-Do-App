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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void yeniFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SayfaIsmiForm isimForm = new SayfaIsmiForm();
            isimForm.Owner = this;
            isimForm.ShowDialog();

            yeniFormToolStripMenuItem1.Enabled = true;
        }

        private void yeniNotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotForm note = new NotForm();
            note.Owner = this;
            note.ShowDialog();
        }
    }
}
