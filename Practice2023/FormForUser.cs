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

namespace Practice2023
{
    public partial class FormForUser : Form
    {
        public FormForUser()
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
                }
                Con.Close();
            }
            catch { }
        }

        private void FormForUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPracticeDataSet.Tovar' table. You can move, or remove it, as needed.
            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
            FillForm();
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            FormEditUser Frm = new FormEditUser();
            this.Hide();
            Frm.ShowDialog();
            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
            FillForm();
            DgvTovars.ClearSelection();
            this.Show();
        }

        private void FormForUser_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            DgvTovars.ClearSelection();
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
                TovarsBS.Filter = $"Title like '%{RtbxFilter.Text}%'";
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FormHistory Frm = new FormHistory();
            Frm.ShowDialog();
        }

        public static string Title, Category, Article, CountTovar, CountInStorage, IdTovar;

        private void DgvTovars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {     
            DialogResult res=MessageBox.Show("Приобрести выбранный товар", "Осторожно!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res==DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = DgvTovars.Rows[e.RowIndex];

                    // Получаем значения ячеек выбранной строки
                    IdTovar = selectedRow.Cells["idTovarDataGridViewTextBoxColumn"].Value.ToString();
                    Title = selectedRow.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
                    Category = selectedRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
                    Article = selectedRow.Cells["articleDataGridViewTextBoxColumn"].Value.ToString();
                    CountTovar = selectedRow.Cells["countTovarDataGridViewTextBoxColumn"].Value.ToString();
                    CountInStorage = selectedRow.Cells["countInStorageDataGridViewTextBoxColumn"].Value.ToString();
                    FormAddTovar Frm = new FormAddTovar();
                    Frm.LblHowMany.Text = "Приобрести(ед):";
                    Frm.ShowDialog();
                    this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
                }
            }
        }
    }
}
