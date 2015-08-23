using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightMatrix
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int n;
        private Matrix data;
        private string filePath = "";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_File create = new Create_New_File();
           //int n;
            DialogResult hasil = create.ShowDialog();
           if (hasil == DialogResult.OK)
            {
                if (!int.TryParse(create.textBox1.Text, out n))
                    MessageBox.Show("Masukkan angka yang benar");
                else
                    n = int.Parse(create.textBox1.Text);
            }
            else return;
           Matrix dataInput = new Matrix(n,n);
           this.data = dataInput;
           Weight_Matrix weight = new Weight_Matrix();
           weight.dataGridView1.RowCount = n;
           weight.dataGridView1.ColumnCount = n;
           weight.MdiParent = this;
           weight.WindowState = FormWindowState.Maximized;
           weight.GridTitle();
           weight.Show();
          
        }

        // Menyimpan File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Weight_Matrix activeForm = (Weight_Matrix)this.ActiveMdiChild;
            this.data = activeForm.GridInput();

            SaveFileDialog dlg = new SaveFileDialog();  
            dlg.Title = "Save Weight Data As...";
            dlg.DefaultExt = ".wdf";
            dlg.Filter = "Weight Data Files (*.wdf)|*.wdf";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               WeightFileWriter file = new WeightFileWriter(dlg.FileName);
               try
               {
                  file.WriteData(this.data);
                  this.filePath = dlg.FileName;
               }
               catch
               {
                  MessageBox.Show("File tidak dapat ditulis");
               }
               finally
               {
                  file.CloseFile();
               }
             } 
        }
    }
}
