using DotPlot_Matrix.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DotPlot_Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static List<string> lst = new List<string>();
        private void MatrisiDoldur()
        {
            lstView.Columns.Add("", 50); 
            for (int i = 0; i < Information.txtSekans1.Length; i++)
                lstView.Columns.Add(Information.txtSekans1[i].ToString());

            for (int i = 0; i < Information.txtSekans2.Length; i++)
            {
               
                lst.Add(Information.txtSekans2[i].ToString());
                for (int j = 0; j < Information.txtSekans1.Length; j++)
                {
                    
                    if (Information.txtSekans2[i] == Information.txtSekans1[j])
                    {
                        lst.Add("X");
                        if (i==j)
                            Information.diagonal++;
                    }
                    else
                        lst.Add("");
                    
                }
                lstView.Items.Add(new ListViewItem(lst.ToArray()));
                lst.Clear();
            }
            lblResult.Text = Information.diagonal + "  /  " + Information.txtSekans1.Count() + 
                             "  =  " + (Information.diagonal / Math.Max(txtBilgi1.Text.Length,txtBilgi2.Text.Length));
            Information.diagonal = 0;
        }
        private void BilgiAl()
        {
            lstView.Clear();
            lstView.View = View.Details;
            lstView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstView.GridLines = true;
            lstView.FullRowSelect = true;

            txtBilgi1.Text = txtBilgi1.Text.ToUpper();
            txtBilgi2.Text = txtBilgi2.Text.ToUpper();
           
            Information.txtSekans1 = txtBilgi1.Text.ToCharArray();
            Information.txtSekans2 = txtBilgi2.Text.ToCharArray();
            MatrisiDoldur();
            

        }
        private void btnMatrisOlustur_Click(object sender, EventArgs e)
        {
            BilgiAl();
        }
    }
}
