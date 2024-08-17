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
    public partial class NotForm1 : Form
    {
        public NotForm1 notFrm1;
        public NotForm1()
        {

            InitializeComponent();

        }


        public void yeniNotEkle(string note)
        {

            string yeni;
            yeni = note;
            lstToDo.Items.Add(yeni);

        }

        private void NotForm1_Load(object sender, EventArgs e)
        {
            //this.lstDoing.AllowDrop = true;
            //this.lstToDo.AllowDrop = true;
            this.lstToDo.MouseDown += new MouseEventHandler(this.lstToDo_MouseDown);
        }


        private void lstToDo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstToDo.Items.Count == 0)
                    return;

                int index = lstToDo.IndexFromPoint(e.X, e.Y);

                string s = lstToDo.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    lstToDo.Items.RemoveAt(lstToDo.IndexFromPoint(e.X, e.Y));
                }
            }
            catch (Exception failure)
            {
                MessageBox.Show(failure.Message);
            }

        }

        private void lstDoing_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstDoing_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                lstDoing.Items.Add(str);
            }
        }

        private void lstDoing_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstDoing.Items.Count == 0)
                    return;

                int index = lstDoing.IndexFromPoint(e.X, e.Y);

                string s = lstDoing.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    lstDoing.Items.RemoveAt(lstDoing.IndexFromPoint(e.X, e.Y));
                }
            }
            catch (Exception failure)
            {
                MessageBox.Show(failure.Message);
            }
        }

        private void lstDone_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstDone_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                lstDone.Items.Add(str);
            }
        }
    }
}
