using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WeightMatrix
{
    public partial class Weight_Matrix : Form
    {
   
        public Weight_Matrix()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.BeginEdit(false);
        }

        // Mengisi data grid dengan Nilai tertentu sebagai nilai masukan
        // Fungsi untuk mengambil nilai dari grid input
       public Matrix GridInput()
        {
            this.dataGridView1.EndEdit();


           int rows = this.dataGridView1.RowCount;
           int cols = this.dataGridView1.ColumnCount;

           Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            return result;

            
        }


        // Menbuat judul baris dan kolom
        public void GridTitle()
        {
            char s = 'A';
            int rows = this.dataGridView1.RowCount;
            int cols = this.dataGridView1.ColumnCount;
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    this.dataGridView1.Columns[i].HeaderCell.Value = s.ToString();
                    this.dataGridView1.Rows[i].HeaderCell.Value = s.ToString();
                    s++;
                }
            }
            else return;
        }

        private void Weight_Matrix_TextChanged(object sender, EventArgs e)
        {
            GridInput();
        }

     
    }
}
