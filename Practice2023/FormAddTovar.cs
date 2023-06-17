using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Permissions;
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
        int CountInStorage1 = 0;
        public string ID;
        public int NumberTrans = 1;
        public string Whosen = "0";

        private void FormAddTovar_Load(object sender, EventArgs e)
        {
            SqlConnection Con1 = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand Cmd1 = new SqlCommand($"select max(NumberTrans) as NTrans from Trans", Con1);
            Con1.Open();
            SqlDataReader Res1 = Cmd1.ExecuteReader();
            Res1.Read();
            if (Res1.HasRows)
                NumberTrans = int.Parse(Res1["NTrans"].ToString())+1;
            Con1.Close();
           

            SqlConnection Con2 = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand Cmd2 = new SqlCommand($" select CountInStorage, Whose from Tovar where Id_Tovar='{FormForUser.IdTovar}'", Con2);
            Con2.Open();
            SqlDataReader Res2 = Cmd2.ExecuteReader();
            Res2.Read();
            if (Res2.HasRows)
            {
                CountInStorage = int.Parse(Res2["CountInStorage"].ToString());
                CountInStorage1 = int.Parse(Res2["CountInStorage"].ToString());
                Whosen = (Res2["Whose"].ToString());
            }

            Con2.Close();




            if (LblHowMany.Text == "Приобрести(ед):")
            {
                // FormForUser;
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
                CmbCategory.SelectedIndex = 0;
                FormForUser Frm = new FormForUser();
                ID = FormForUser.IdTovar;
                RtbxName.Text = FormForUser.Title;
                RtbxName.ReadOnly =true;
                RtbxArticle.Text = FormForUser.Article;
                RtbxArticle.ReadOnly = true;
                RtbxCountTovar.Text = FormForUser.CountTovar;
                RtbxCountTovar.ReadOnly = true;
                RtbxInStorage.Text = FormForUser.CountInStorage;
                CmbCategory.Text = FormForUser.Category;
                CmbCategory.Enabled = false;
                RtbxInStorage.Text = "0";
                RtbxInStorage.ReadOnly = true;
RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
                LblForm.Text = "Buy Product";
                BtnSave.Text = "Приобрести";
                BtnCancel.Text = "Отменить операцию";
                this.Text = "СУБД \"OK_Magazine\" >  Покупка товара";
            }
            else if (LblHowMany.Text == "На складе(ед):")
            {
                // FormBusiness
                FormClient Frm = new FormClient();
                ID = FormClient.IdTovar;
                RtbxName.Text=FormClient.Title;
                RtbxArticle.Text=FormClient.Article;
                RtbxCountTovar.Text=FormClient.CountTovar;
                RtbxInStorage.Text=FormClient.CountInStorage;
                CmbCategory.Text=FormClient.Category;
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
                LblForm.Text = "Edit Product";
                BtnSave.Text = "Сохранить изменения";
                BtnCancel.Text = "Отменить изменения";
                this.Text = "СУБД \"OK_Magazine\" >  Редактирование товара";
                BtnDelete.Visible = Visible;
            }
            else
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
            if (LblHowMany.Text == "Приобрести(ед):")
            {
                if (CountInStorage1 > int.Parse(RtbxInStorage.Text))
                {
                    int N = int.Parse(RtbxInStorage.Text);
                    RtbxInStorage.Text = (N + 1).ToString();
                }
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                int N = int.Parse(RtbxInStorage.Text);
                RtbxInStorage.Text = (N + 1).ToString();
                RtbxInStorage.SelectionAlignment = HorizontalAlignment.Center;
            }
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

        private void RtbxCountTovar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            string FDT = Dt.ToString("yyyy-MM-dd HH:mm");


            SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand Cmd = new SqlCommand($"Delete from Tovar where Id_Tovar='{ID}'",Con);
            
            Con.Open();
            Cmd.ExecuteNonQuery();
            Cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{CountInStorage1}','{FormAuthoriz.IDUser}','Списание','{RtbxArticle.Text}','{FormAuthoriz.IDUser}')", Con);
            Cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Ранее существующий товар удален", "Какая жалость!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DateTime Dt = DateTime.Now;
            string FDT = Dt.ToString("yyyy-MM-dd HH:mm");


            int Complete = 0;
            if (RtbxName.Text == "" || RtbxArticle.Text =="" || RtbxCountTovar.Text=="")
            {
                LblNonCurrent.Text = "Не все поля заполнены";
                return;
            }
            if (RtbxInStorage.Text == "0")
            {
                if (LblHowMany.Text == "Приобрести(ед):")
                {
                    LblNonCurrent.Text = "Кол-во товаров к приобретению: 0";
                }
                else LblNonCurrent.Text = "Кол-во товаров, добавляемых на склад: 0";
                return;
            }

            if (LblHowMany.Text == "На складе(ед):")
            { 
                CountInStorage1 = CountInStorage - int.Parse(RtbxInStorage.Text);
                SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                SqlCommand cmd = new SqlCommand($"update Tovar set CountInStorage={RtbxInStorage.Text}, Title='{RtbxName.Text}', Category='{CmbCategory.Text}', Article='{RtbxArticle.Text}', CountTovar='{RtbxCountTovar.Text}' where Id_Tovar='{ID}'", Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                if (int.Parse(RtbxInStorage.Text) >= CountInStorage)
                {
                    CountInStorage1 = int.Parse(RtbxInStorage.Text) - CountInStorage;
                    cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{CountInStorage1}','{FormAuthoriz.IDUser}','Поступление','{RtbxArticle.Text}','{FormAuthoriz.IDUser}')", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                if (int.Parse(RtbxInStorage.Text) < CountInStorage)
                {
                    CountInStorage1 =CountInStorage - int.Parse(RtbxInStorage.Text);
                    cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{CountInStorage1}','{FormAuthoriz.IDUser}','Списание','{RtbxArticle.Text}','{FormAuthoriz.IDUser}')", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
               

                MessageBox.Show("Ранее существующий товар изменен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (LblHowMany.Text == "Приобрести(ед):")
            {

                if (CountInStorage1 == int.Parse(RtbxInStorage.Text))
                {
                    SqlConnection Con= new SqlConnection(FormAuthoriz.TxtCon);
                    SqlCommand cmd = new SqlCommand($"Delete from Tovar where Id_Tovar='{ID}'", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{CountInStorage1}','{FormAuthoriz.IDUser}','Приобретение','{RtbxArticle.Text}','{Whosen}')", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    this.Close();
                }
                else
                {
                    CountInStorage = CountInStorage - int.Parse(RtbxInStorage.Text);
                    SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                    SqlCommand cmd = new SqlCommand($"update Tovar set CountInStorage={CountInStorage} where Id_Tovar='{ID}'", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{RtbxInStorage.Text}','{FormAuthoriz.IDUser}','Приобретение','{RtbxArticle.Text}','{Whosen}')", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    this.Close();
                }
            }

            if (LblHowMany.Text == "Добавить на склад(ед):")
            {

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
                        SqlCommand cmd = new SqlCommand($"update Tovar set CountInStorage={S + CountInStorage} where Article='{RtbxArticle.Text}'", Con);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        Complete++;
                        cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}','{RtbxInStorage.Text}','{FormAuthoriz.IDUser}','Поступление','{RtbxArticle.Text}','{FormAuthoriz.IDUser}')", Con);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Ранее существующий товар изменен!", "Какая неожиданность!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                if (Complete == 0)
                {
                    SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
                    SqlCommand Cmd = new SqlCommand($"insert into Tovar (Title, Category, Article, CountTovar, CountInStorage, Whose) values ('{RtbxName.Text}','{CmbCategory.Text}','{RtbxArticle.Text}', '{RtbxCountTovar.Text}', '{RtbxInStorage.Text}', '{FormAuthoriz.IDUser}') ", Con);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Cmd = new SqlCommand($"insert into Trans (NumberTrans, TimeTrans, HowMany, WhoCompleteTrans, State, WhatBought, Whose) values ('{NumberTrans}', '{FDT}', '{RtbxInStorage.Text}','{FormAuthoriz.IDUser}' ,'Поступление','{RtbxArticle.Text}','{FormAuthoriz.IDUser}')", Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Товар успешно добавлен!", "Свершилось!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
    }
}
