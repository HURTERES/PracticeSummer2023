namespace Practice2023
{
    partial class FormAuthoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthoriz));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblReg = new System.Windows.Forms.Label();
            this.RtbxLogin = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RtbxPass = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblForgot = new System.Windows.Forms.Label();
            this.LblNonCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(680, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log in";
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(763, 397);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(143, 34);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Text = "Войти";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblReg
            // 
            this.LblReg.AutoSize = true;
            this.LblReg.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(198)))), ((int)(((byte)(172)))));
            this.LblReg.Location = new System.Drawing.Point(622, 401);
            this.LblReg.Name = "LblReg";
            this.LblReg.Size = new System.Drawing.Size(126, 26);
            this.LblReg.TabIndex = 8;
            this.LblReg.Text = "Регистрация";
            this.LblReg.Click += new System.EventHandler(this.LblReg_Click);
            // 
            // RtbxLogin
            // 
            this.RtbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxLogin.Location = new System.Drawing.Point(607, 254);
            this.RtbxLogin.Name = "RtbxLogin";
            this.RtbxLogin.Size = new System.Drawing.Size(314, 34);
            this.RtbxLogin.TabIndex = 9;
            this.RtbxLogin.Text = "Введите логин";
            this.RtbxLogin.Enter += new System.EventHandler(this.RtbxLogin_Enter);
            this.RtbxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbxLogin_KeyDown);
            this.RtbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbxLogin_KeyPress);
            this.RtbxLogin.Leave += new System.EventHandler(this.RtbxLogin_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(607, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 2);
            this.panel1.TabIndex = 10;
            // 
            // RtbxPass
            // 
            this.RtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxPass.Location = new System.Drawing.Point(607, 329);
            this.RtbxPass.Name = "RtbxPass";
            this.RtbxPass.Size = new System.Drawing.Size(314, 34);
            this.RtbxPass.TabIndex = 11;
            this.RtbxPass.Text = "Введите пароль";
            this.RtbxPass.Enter += new System.EventHandler(this.RtbxPass_Enter);
            this.RtbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbxPass_KeyPress);
            this.RtbxPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RtbxPass_KeyUp);
            this.RtbxPass.Leave += new System.EventHandler(this.RtbxPass_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(607, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 2);
            this.panel2.TabIndex = 12;
            // 
            // LblForgot
            // 
            this.LblForgot.AutoSize = true;
            this.LblForgot.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblForgot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblForgot.Location = new System.Drawing.Point(615, 305);
            this.LblForgot.Name = "LblForgot";
            this.LblForgot.Size = new System.Drawing.Size(0, 18);
            this.LblForgot.TabIndex = 14;
            this.LblForgot.Visible = false;
            // 
            // LblNonCurrent
            // 
            this.LblNonCurrent.BackColor = System.Drawing.Color.White;
            this.LblNonCurrent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNonCurrent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblNonCurrent.Location = new System.Drawing.Point(607, 460);
            this.LblNonCurrent.Name = "LblNonCurrent";
            this.LblNonCurrent.Size = new System.Drawing.Size(314, 25);
            this.LblNonCurrent.TabIndex = 15;
            this.LblNonCurrent.Text = " ";
            this.LblNonCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAuthoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Practice2023.Properties.Resources.NiceImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1129, 635);
            this.Controls.Add(this.LblNonCurrent);
            this.Controls.Add(this.LblForgot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RtbxPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RtbxLogin);
            this.Controls.Add(this.LblReg);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1145, 674);
            this.MinimumSize = new System.Drawing.Size(1145, 674);
            this.Name = "FormAuthoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"OK_Magazine\"";
            this.Shown += new System.EventHandler(this.FormAuthoriz_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblReg;
        private System.Windows.Forms.RichTextBox RtbxLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RtbxPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblForgot;
        private System.Windows.Forms.Label LblNonCurrent;
    }
}

