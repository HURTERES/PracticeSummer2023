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

namespace Practice2023
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
         
        }

        private void FormClient_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPracticeDataSet.Tovar' table. You can move, or remove it, as needed.
            DgvTovars.AllowUserToResizeColumns = false;
            this.tovarTableAdapter.Fill(this.dBPracticeDataSet.Tovar);
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
                    LblID.Text = "ID сотрудника: "+ (Res["IdPredp"].ToString());
                }
                Con.Close();
            }
            catch { }
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            FormEditUser Frm = new FormEditUser();
            Frm.ShowDialog();
        }

        private void RtbxFilter_Enter(object sender, EventArgs e)
        {
            if (RtbxFilter.Text == "Фильтр по названию")
            {
               RtbxFilter.Text = "";
            }
        }

        private void RtbxFilter_Leave(object sender, EventArgs e)
        {
            if (RtbxFilter.Text == "")
            {
                RtbxFilter.Text = "Фильтр по названию";
            }
        }

        private void RtbxFilter_TextChanged(object sender, EventArgs e)
        {
            if(RtbxFilter.Text!="Фильтр по названию")
            BsTovars.Filter = $"Title like '%{RtbxFilter.Text}%'";
        }

        private void FormClient_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
