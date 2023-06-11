namespace Practice2023
{
    partial class FormReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.LblNonCurrent = new System.Windows.Forms.Label();
            this.LblForgot = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtbxPass = new System.Windows.Forms.RichTextBox();
            this.RtbxLogin = new System.Windows.Forms.RichTextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RtbxPassConfirm = new System.Windows.Forms.RichTextBox();
            this.RtbxMail = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CmbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RtbxName = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LblNonCurrent
            // 
            this.LblNonCurrent.BackColor = System.Drawing.Color.White;
            this.LblNonCurrent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNonCurrent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblNonCurrent.Location = new System.Drawing.Point(295, 470);
            this.LblNonCurrent.Name = "LblNonCurrent";
            this.LblNonCurrent.Size = new System.Drawing.Size(600, 25);
            this.LblNonCurrent.TabIndex = 0;
            this.LblNonCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblForgot
            // 
            this.LblForgot.AutoSize = true;
            this.LblForgot.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblForgot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblForgot.Location = new System.Drawing.Point(621, 295);
            this.LblForgot.Name = "LblForgot";
            this.LblForgot.Size = new System.Drawing.Size(0, 18);
            this.LblForgot.TabIndex = 25;
            this.LblForgot.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(235, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 2);
            this.panel2.TabIndex = 24;
            // 
            // RtbxPass
            // 
            this.RtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxPass.Location = new System.Drawing.Point(235, 320);
            this.RtbxPass.Name = "RtbxPass";
            this.RtbxPass.Size = new System.Drawing.Size(314, 34);
            this.RtbxPass.TabIndex = 23;
            this.RtbxPass.Text = "Введите пароль";
            this.RtbxPass.Enter += new System.EventHandler(this.RtbxPass_Enter);
            this.RtbxPass.Leave += new System.EventHandler(this.RtbxPass_Leave);
            // 
            // RtbxLogin
            // 
            this.RtbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxLogin.Location = new System.Drawing.Point(235, 265);
            this.RtbxLogin.Name = "RtbxLogin";
            this.RtbxLogin.Size = new System.Drawing.Size(314, 34);
            this.RtbxLogin.TabIndex = 21;
            this.RtbxLogin.Text = "Введите логин";
            this.RtbxLogin.Enter += new System.EventHandler(this.RtbxLogin_Enter);
            this.RtbxLogin.Leave += new System.EventHandler(this.RtbxLogin_Leave);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(446, 516);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(293, 34);
            this.BtnEnter.TabIndex = 19;
            this.BtnEnter.Text = "Регистрация";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(490, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 67);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sign Up";
            // 
            // RtbxPassConfirm
            // 
            this.RtbxPassConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxPassConfirm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxPassConfirm.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxPassConfirm.Location = new System.Drawing.Point(235, 375);
            this.RtbxPassConfirm.Name = "RtbxPassConfirm";
            this.RtbxPassConfirm.Size = new System.Drawing.Size(314, 34);
            this.RtbxPassConfirm.TabIndex = 27;
            this.RtbxPassConfirm.Text = "Повторите пароль";
            this.RtbxPassConfirm.Enter += new System.EventHandler(this.RtbxPassConfirm_Enter);
            this.RtbxPassConfirm.Leave += new System.EventHandler(this.RtbxPassConfirm_Leave);
            // 
            // RtbxMail
            // 
            this.RtbxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxMail.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxMail.Location = new System.Drawing.Point(624, 210);
            this.RtbxMail.Name = "RtbxMail";
            this.RtbxMail.Size = new System.Drawing.Size(314, 34);
            this.RtbxMail.TabIndex = 28;
            this.RtbxMail.Text = "Введите e-mail";
            this.RtbxMail.Enter += new System.EventHandler(this.RtbxMail_Enter);
            this.RtbxMail.Leave += new System.EventHandler(this.RtbxMail_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(235, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 2);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(235, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 2);
            this.panel4.TabIndex = 30;
            // 
            // CmbRole
            // 
            this.CmbRole.AllowDrop = true;
            this.CmbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbRole.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbRole.ForeColor = System.Drawing.Color.Black;
            this.CmbRole.FormattingEnabled = true;
            this.CmbRole.Items.AddRange(new object[] {
            "Клиентом",
            "Предпринимателем"});
            this.CmbRole.Location = new System.Drawing.Point(624, 294);
            this.CmbRole.Name = "CmbRole";
            this.CmbRole.Size = new System.Drawing.Size(242, 34);
            this.CmbRole.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(619, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Вы являетесь:";
            // 
            // LblBack
            // 
            this.LblBack.AutoSize = true;
            this.LblBack.BackColor = System.Drawing.Color.White;
            this.LblBack.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.LblBack.Location = new System.Drawing.Point(828, 520);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(128, 26);
            this.LblBack.TabIndex = 33;
            this.LblBack.Text = "Вернуться ➤";
            this.LblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(265, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Нажимая “Регистрация”, вы соглашаетесь с  Условиями использования и Политикой кон" +
    "фиденциальности";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.linkLabel1.Location = new System.Drawing.Point(546, 430);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 18);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Условиями использования";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.linkLabel2.Location = new System.Drawing.Point(735, 430);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(219, 18);
            this.linkLabel2.TabIndex = 36;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Политикой конфиденциальности";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(624, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 2);
            this.panel5.TabIndex = 31;
            // 
            // RtbxName
            // 
            this.RtbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxName.Location = new System.Drawing.Point(235, 210);
            this.RtbxName.Name = "RtbxName";
            this.RtbxName.Size = new System.Drawing.Size(314, 34);
            this.RtbxName.TabIndex = 37;
            this.RtbxName.Text = "Введите имя и фамилию";
            this.RtbxName.Enter += new System.EventHandler(this.RtbxName_Enter);
            this.RtbxName.Leave += new System.EventHandler(this.RtbxName_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(235, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 2);
            this.panel1.TabIndex = 38;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practice2023.Properties.Resources.fotor_2023_6_10_22_31_48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RtbxName);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbRole);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RtbxMail);
            this.Controls.Add(this.RtbxPassConfirm);
            this.Controls.Add(this.LblNonCurrent);
            this.Controls.Add(this.LblForgot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RtbxPass);
            this.Controls.Add(this.RtbxLogin);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"OK_Magazine\" > Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.Shown += new System.EventHandler(this.FormReg_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNonCurrent;
        private System.Windows.Forms.Label LblForgot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox RtbxPass;
        private System.Windows.Forms.RichTextBox RtbxLogin;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtbxPassConfirm;
        private System.Windows.Forms.RichTextBox RtbxMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CmbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox RtbxName;
        private System.Windows.Forms.Panel panel1;
    }
}