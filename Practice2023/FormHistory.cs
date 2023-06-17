using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2023
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPracticeDataSet.Trans' table. You can move, or remove it, as needed.
            this.transTableAdapter.Fill(this.dBPracticeDataSet.Trans);
            // TODO: This line of code loads data into the 'dBPracticeDataSet.Trans' table. You can move, or remove it, as needed.
            this.transTableAdapter.Fill(this.dBPracticeDataSet.Trans);
            if (FormAuthoriz.Role == "2")
                BsHistory.Filter = $"WhoCompleteTrans= '{FormAuthoriz.IDUser}'";
            else BsHistory.Filter = $"Whose ='{FormAuthoriz.IDUser}'";
        }

        private void DgvTovars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
