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
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }
        public string OldPass;
        private void FormEditUser_Load(object sender, EventArgs e)
        {   
            SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand cmd = new SqlCommand($"SELECT  Name, Mail, Pass, Login FROM [User]  where [User].Id_User='{FormAuthoriz.IDUser}'", Con);
            Con.Open();
            SqlDataReader Res = cmd.ExecuteReader();
            Res.Read();
            if (Res.HasRows)
            {
                OldPass = Res["Pass"].ToString();
                RtbxName.Text = Res["Name"].ToString();
                RtbxLogin.Text = Res["Login"].ToString();
                RtbxMail.Text = Res["Mail"].ToString();
            }
        }

        private void FormEditUser_Shown(object sender, EventArgs e)
        {
           // RtbxName.Select(0, 0);
           // panel1.Focus();
            this.ActiveControl = null;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (OldPass != RtbxPassOld.Text)
            {
                LblNonCurrent.Text = "Неверный ранее установленный пароль";
                return;
            }
            if (RtbxPassOld.Text != "" && RtbxPassNew.Text !="")
            {
                SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                SqlCommand cmd = new SqlCommand($"update [User] set Name='{RtbxName.Text}', Login='{RtbxLogin.Text}', Pass='{RtbxPassNew.Text}', Mail='{RtbxMail.Text}' where Id_User='{FormAuthoriz.IDUser}'", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Редактирование прошло успешно!", "Великолепие огненных эффектов!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CmbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CmbCheck.Checked)
            {
                RtbxPassOld.UseSystemPasswordChar = false;
                RtbxPassNew.UseSystemPasswordChar = false;
            }
            else
            {
                RtbxPassOld.UseSystemPasswordChar = true;
                RtbxPassNew.UseSystemPasswordChar = true;
            }
        }
    }
}
