using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice2023
{
    public partial class FormAddTovar : Form
    {
        public FormAddTovar()
        {
            InitializeComponent();
        }
        public string Title, Category, Article, Whose;
        List<string> LstTitle = new List<string>();
        List<string> LstCategory = new List<string>();
        List<string> LstArticle = new List<string>();
        List<string> LstCountInStorage = new List<string>();
        List<string> LstWhose = new List<string>();
        int CountInStorage = 0;
        private void FormAddTovar_Load(object sender, EventArgs e)
        {
            RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            CmbCategory.SelectedIndex = 0;
            SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand Cmd = new SqlCommand($"select * from Tovar", Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            while (Res.Read())
            {
                LstTitle.Add(Res["Title"].ToString());
                LstCategory.Add(Res["Category"].ToString());
                LstArticle.Add(Res["Article"].ToString());
                LstCountInStorage.Add(Res["CountInStorage"].ToString());
                LstWhose.Add(Res["Whose"].ToString());
            }
            Con.Close();
        }

        private void RtbxInStorage_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void RtbxInStorage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='\b')
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

                int N = int.Parse(RtbxInStorage.Text);
                RtbxInStorage.Text = (N + 1).ToString();
            RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void FormAddTovar_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RtbxInStorage.Text != "0")
            {
                int N = int.Parse(RtbxInStorage.Text);
                RtbxInStorage.Text = (N - 1).ToString();
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                RtbxInStorage.Text = "0";
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RtbxInStorage_Enter(object sender, EventArgs e)
        {
            if (RtbxInStorage.Text == "0")
            {
                RtbxInStorage.Text = "";
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void RtbxInStorage_Leave(object sender, EventArgs e)
        {
            if (RtbxInStorage.Text == "")
            {
                RtbxInStorage.Text = "0";
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }
               
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int Complete = 0;
            if (RtbxName.Text == "" || RtbxArticle.Text =="" || RtbxCountTovar.Text=="")
            {
                LblNonCurrent.Text = "Не все поля заполнены";
                return;
            }
            if (RtbxInStorage.Text == "0")
            {
                LblNonCurrent.Text = "Кол-во товаров, добавляемых на склад: 0";
                return;
            }
            for (int i = 0; i < LstArticle.Count; i++)
            {
                Title = LstTitle[i];
                Category = LstCategory[i];
                Article = LstArticle[i];
                Whose = LstWhose[i];
                CountInStorage = int.Parse(RtbxInStorage.Text);

                if (Title == RtbxName.Text && Category == CmbCategory.Text && Article == RtbxArticle.Text && Whose == (FormAuthoriz.IDUser).ToString())
                {
                    SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                    int S = int.Parse(LstCountInStorage[i]);
                    SqlCommand cmd = new SqlCommand($"update Tovar set CountInStorage={S+CountInStorage} where Article='{RtbxArticle.Text}'", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Ранее существующий товар изменен!", "Какая неожиданность!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Complete++;
                    this.Close();
                }    
            }
            if (Complete == 0)
            {
                SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                SqlCommand Cmd = new SqlCommand($"insert into Tovar (Title, Category, Article, CountTovar, CountInStorage, Whose) values ('{RtbxName.Text}','{CmbCategory.Text}','{RtbxArticle.Text}', '{RtbxCountTovar.Text}', '{RtbxInStorage.Text}', '{FormAuthoriz.IDUser}') ", Con);
                Con.Open();
                Cmd.ExecuteReader();
                Con.Close();
                MessageBox.Show("Товар успешно добавлен!", "Свершилось!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
