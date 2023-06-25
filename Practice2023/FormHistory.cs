using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

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

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Номер заявки");
            dt.Columns.Add("Артикул");
            dt.Columns.Add("Время");
            dt.Columns.Add("Кол-во");
            dt.Columns.Add("Состояние");

            for (int i = 0; i < DgvTovars.RowCount; i++)
            {
                DataRow row = dt.NewRow();
                row["Номер заявки"] = $"{DgvTovars[1, i].Value}";
                row["Артикул"] = $"{DgvTovars[2, i].Value}";
                row["Время"] = $"{DgvTovars[3, i].Value}";
                row["Кол-во"] = $"{DgvTovars[4, i].Value}";
                row["Состояние"] = $"{DgvTovars[6, i].Value}";
                dt.Rows.Add(row);
            }

            Word.Application word = new Word.Application();
            word.Application.Documents.Add(Type.Missing);

            Word.Table table = word.Application.ActiveDocument.Tables.Add(word.Selection.Range, dt.Rows.Count + 1, dt.Columns.Count, Type.Missing, Type.Missing);
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = dt.Columns[i].ColumnName;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dt.Rows[i][j].ToString();
                }
            }

            word.Visible = true;
        }
    }
}
