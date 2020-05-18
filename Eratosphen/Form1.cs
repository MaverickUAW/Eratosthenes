using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratosphen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = System.Convert.ToInt32(textBox1.Text);
            int m = 20;
            int k = 1;
            for (int i = 0; i < m; i++)
                dataGridView1.Columns.Add("", "");
            for (int i = 0; i < n / m; i++)
                dataGridView1.Rows.Add();
            
            for (int i = 0; i < n / m; i++)
                for (int j = 0; j < m; j++)
                    dataGridView1.Rows[i].Cells[j].Value = k++;
            if ((n%m)!=0)
                for (int i = 0; i < n % m; i++)
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = k++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = dataGridView1.ColumnCount;
            for(int q=2; q<n; q++)
            {
                for(int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    for(int j=0; j<m; j++)
                    {
                        if ((Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) % q) == 0 && Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value) != q && dataGridView1.Rows[i].Cells[j].Value != null|| Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value)==1)
                            dataGridView1.Rows[i].Cells[j].Value = null;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
