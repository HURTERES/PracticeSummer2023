using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice2023
{
    
    public partial class FormAuthoriz : Form
    {
        public static int Count = 0;
        public static int IDUser;
        public static string Role = "1";
        public FormAuthoriz()
        {
            InitializeComponent();
        }

        public static string TxtCon = "Data Source=213.155.192.79,3002;Initial Catalog=DBPractice;User ID=u21levinsas;Password=ngh4";


        private void FormAuthoriz_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
          
            if ( RtbxLogin.Text!="" && RtbxLogin.Text!="Введите логин")
            {
                Count++;
                if (Count >= 3)
                {
                    LblForgot.Text = "Восстановить пароль";
                    LblForgot.ForeColor = Color.FromArgb(67, 198, 172);
                    LblForgot.Visible = true;
                }
            }
            LblNonCurrent.Visible = false ;
            try
            {
                SqlConnection Con = new SqlConnection(TxtCon);
                SqlCommand Cmd = new SqlCommand($"SELECT        Id_User, Name, Role, Mail, Pass, Login, IdPredp \r\nFROM            [User]  where [User].Login='{RtbxLogin.Text.Trim()}' and [User].Pass='{RtbxPass.Text.Trim()}'", Con);
                Con.Open();
                SqlDataReader Res = Cmd.ExecuteReader();
                Res.Read();
                if (Res.HasRows)
                {
                    if (Res["Role"].ToString() == "1")
                    {
                        FormClient Frm = new FormClient();
                        this.Hide();
                        Role = Res["Role"].ToString();
                        IDUser = int.Parse(Res["Id_User"].ToString());
                        Frm.ShowDialog();
                        Count = 0;
                        RtbxLogin.Text = "Введите логин";
                        RtbxPass.Text = "Введите пароль";
                        LblForgot.Visible = false;
                        this.Show();
                        this.ActiveControl = null;
                    }
                    if (Res["Role"].ToString() == "2")
                    {
                        FormForUser Frm= new FormForUser();
                        this.Hide();
                        Role = Res["Role"].ToString();
                        IDUser = int.Parse(Res["Id_User"].ToString());
                        Frm.ShowDialog();
                        Count = 0;
                        RtbxLogin.Text = "Введите логин";
                        RtbxPass.Text = "Введите пароль";
                        LblForgot.Visible = false;
                        this.Show();
                        this.ActiveControl = null;
                    }
                    if (Res["Role"].ToString() == "3")
                    {
                        FormClient Frm = new FormClient();
                        this.Hide();
                        Role = Res["Role"].ToString();
                        IDUser = int.Parse(Res["Id_User"].ToString());
                        Frm.ShowDialog();
                        Count = 0;
                        RtbxLogin.Text = "Введите логин";
                        RtbxPass.Text = "Введите пароль";
                        LblForgot.Visible = false;
                        this.Show();
                        this.ActiveControl = null;
                    }
                }
                else
                {
                        LblNonCurrent.Text = "Неверный логин или пароль";
                        LblNonCurrent.Visible = true;
                    
                }
                Con.Close();
            }
            catch { }
        }

        private void RtbxLogin_Leave(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "")
            {
                RtbxLogin.Text = "Введите логин";
            }
        }

        private void RtbxLogin_Enter(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "Введите логин")
            { 
                RtbxLogin.Text = "";
            }
        }

        private void RtbxPass_Leave(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "")
            {
                RtbxPass.Text = "Введите пароль";
            }
        }

        private void RtbxPass_Enter(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "Введите пароль")
            {
                RtbxPass.Text = "";
            }
        }

        private void LblReg_Click(object sender, EventArgs e)
        {
            FormReg Frm = new FormReg();
            this.Hide();
            RtbxLogin.Text = "Введите логин";
            RtbxPass.Text = "Введите пароль";
            LblForgot.Text = "";
            LblNonCurrent.Visible = false;
            Count = 0;
            Frm.ShowDialog();
            this.Show();
            this.ActiveControl = null;
        }

        private void RtbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void RtbxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void RtbxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                    RtbxPass.Focus();
        }

        private void RtbxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                    RtbxLogin.Focus(); 
            
        }
    }
}
