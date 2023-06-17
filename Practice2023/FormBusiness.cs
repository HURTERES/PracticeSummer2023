using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice2023
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        void FillForm()
        {
            try
            {
                SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                SqlCommand Cmd = new SqlCommand($"SELECT  Name, Mail, IdPredp FROM            [User]  where [User].Id_User='{FormAuthoriz.IDUser}'", Con);
                Con.Open();
                SqlDataReader Res = Cmd.ExecuteReader();
                Res.Read();
                if (Res.HasRows)
                {
                    LblName.Text = Res["Name"].ToString();
                    LblID.Text = "ID сотрудника: " + (Res["IdPredp"].ToString());
                }
                Con.Close();
            }
            catch { }
        }

        private void FormClient_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPracticeDataSet.Tovar' table. You can move, or remove it, as needed.
            DgvTovars.AllowUserToResizeColumns = false;

            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
            FillForm();

            TovarsBS.Filter = $"Whose = '{FormAuthoriz.IDUser}'";

            DgvTovars.ClearSelection();
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            FormEditUser Frm = new FormEditUser();
            this.Hide();
            Frm.ShowDialog();
            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
            FillForm();
            DgvTovars.ClearSelection();
            this.Show();
        }

        private void RtbxFilter_Enter(object sender, EventArgs e)
        {
            if (RtbxFilter.Text == "Поиск по названию")
            {
                RtbxFilter.Text = "";
            }
        }

        private void RtbxFilter_Leave(object sender, EventArgs e)
        {
            if (RtbxFilter.Text == "")
            {
                RtbxFilter.Text = "Поиск по названию";
            }
        }

        private void RtbxFilter_TextChanged(object sender, EventArgs e)
        {
            if (RtbxFilter.Text != "Поиск по названию")
                TovarsBS.Filter = $"Whose = '{FormAuthoriz.IDUser}' and Title like '%{RtbxFilter.Text}%'";
        }

        private void FormClient_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddTovar Frm = new FormAddTovar();
            this.Hide();
            Frm.ShowDialog();
            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
            DgvTovars.ClearSelection();
            this.Show();
        }

        public static string Title, Category, Article, CountTovar, CountInStorage, IdTovar;

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FormHistory Frm = new FormHistory();
            Frm.ShowDialog();
        }

        private void BtnEditTovar_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            if (DgvTovars.SelectedRows.Count != 0)
            {
                FormAddTovar Frm = new FormAddTovar();
                Frm.LblHowMany.Text = "На складе(ед):";
                this.Hide();
                Frm.ShowDialog();
                this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
                DgvTovars.ClearSelection();
                this.Show();
            }
            else MessageBox.Show("Не выбран ни один товар");
        }

        private void DgvTovars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DgvTovars.Rows[e.RowIndex];

                // Получаем значения ячеек выбранной строки
                IdTovar = selectedRow.Cells["idTovarDataGridViewTextBoxColumn"].Value.ToString();
                Title = selectedRow.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
                Category = selectedRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
                Article = selectedRow.Cells["articleDataGridViewTextBoxColumn"].Value.ToString();
                CountTovar= selectedRow.Cells["countTovarDataGridViewTextBoxColumn"].Value.ToString();
                CountInStorage = selectedRow.Cells["countInStorageDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
