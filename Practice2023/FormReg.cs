using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2023
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Shown(object sender, EventArgs e)
        {


            //ResourceManager resourceManager = new ResourceManager(typeof(Properties.Resources));

            //// Загрузка изображения из ресурсов
            //Image image = (Image)resourceManager.GetObject("Nebo");

            //// Создание объекта изображения с настройками прозрачности
            //Image transparentImage = new Bitmap(image.Width, image.Height);
            //Graphics graphics = Graphics.FromImage(transparentImage);
            //ImageAttributes imageAttributes = new ImageAttributes();
            //ColorMatrix colorMatrix = new ColorMatrix();
            //colorMatrix.Matrix33 = 0.3f; // Установка прозрачности в 30%
            //imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //// Наложение прозрачного изображения на PbxBack
            //graphics.DrawImage(image, new Rectangle(0, 0, transparentImage.Width, transparentImage.Height),
            //    0, 0, transparentImage.Width, transparentImage.Height, GraphicsUnit.Pixel, imageAttributes);

            // Отображение прозрачного изображения в PbxBack
            //PbxBack.Image = transparentImage;

            CmbRole.SelectedIndex = 0;

        }

        private void FormReg_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (RtbxPass.Text != RtbxPassConfirm.Text)
            {
                LblNonCurrent.Text = "Пароли не совпадают";
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(FormAuthoriz.TxtCon);
            SqlCommand Query = new SqlCommand();
            if ((RtbxLogin.Text.Trim() != "" && RtbxLogin.Text != "Введите логин") || (RtbxPass.Text.Trim() != "" && RtbxPass.Text != "Введите пароль") || (RtbxPassConfirm.Text.Trim()!="" && RtbxPassConfirm.Text!="Повторите пароль") || (RtbxMail.Text.Trim()!="" && RtbxMail.Text!="Введите e-mail")) 
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand($"SELECT [User].Name, [User].Mail FROM [User] where [User].Name ='{RtbxLogin.Text.Trim()}' or [User].Mail='{RtbxMail.Text.Trim()}'", Con);
                    Con.Open();
                    SqlDataReader Res = Cmd.ExecuteReader();
                    Res.Read();
                    if (Res.HasRows)
                    {
                        if (Res["Name"].ToString() == $"{RtbxLogin.Text.Trim()}")
                        {
                            LblNonCurrent.Text = "Пользователь с таким логином уже существует";
                            return;
                        }
                        else if (Res["Mail"].ToString() == $"{RtbxMail.Text.Trim()}")
                        {
                            LblNonCurrent.Text = "Пользователь с таким e-mail уже существует";
                            return;
                        }
                    }
                    Con.Close();
                }
                catch { }

                if (RtbxPass.Text != RtbxPassConfirm.Text)
                {
                    LblNonCurrent.Text = "Пароли не совпадают";
                    return;
                }
                else
                {
                    LblNonCurrent.Text = "";
                    if (CmbRole.SelectedIndex == 0)
                    {
                        Query = new SqlCommand($"insert into [User](Name, Pass, Mail, Role)\r\nvalues ('{RtbxLogin.Text}', '{RtbxPass.Text}','{RtbxMail.Text}','1')", Con);
                    }
                    else if (CmbRole.SelectedIndex == 1)
                    {
                        Query = new SqlCommand($"insert into [User](Name, Pass, Mail, Role)\r\nvalues ('{RtbxLogin.Text}', '{RtbxPass.Text}','{RtbxMail.Text}','2')", Con);
                    }
                    Con.Open();
                    Query.ExecuteReader();
                    Con.Close();
                    MessageBox.Show("Регистрация прошла успешно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else LblNonCurrent.Text = "Не все поля заполнены";

        }

        private void RtbxLogin_Enter(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "Введите логин")
            {
                RtbxLogin.Text = "";
            }
        }

        private void RtbxLogin_Leave(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "")
            {
                RtbxLogin.Text = "Введите логин";
            }
        }

        private void RtbxPass_Enter(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "Введите пароль")
            {
                RtbxPass.Text = "";
            }
        }

        private void RtbxPass_Leave(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "")
            {
                RtbxPass.Text = "Введите пароль";
            }
        }

        private void RtbxPassConfirm_Enter(object sender, EventArgs e)
        {
            if (RtbxPassConfirm.Text == "Повторите пароль")
            {
                RtbxPassConfirm.Text = "";
            }
        }

        private void RtbxPassConfirm_Leave(object sender, EventArgs e)
        {
            if (RtbxPassConfirm.Text == "")
            {
                RtbxPassConfirm.Text = "Повторите пароль";
            }
        }

        private void RtbxMail_Enter(object sender, EventArgs e)
        {
            if (RtbxMail.Text == "Введите e-mail")
            {
                RtbxMail.Text = "";
            }
        }

        private void RtbxMail_Leave(object sender, EventArgs e)
        {
            if (RtbxMail.Text == "")
            {
                RtbxMail.Text = "Введите e-mail";
            }
        }
    }
}
