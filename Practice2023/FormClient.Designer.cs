namespace Practice2023
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblBack = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BsTovars = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBPracticeDataSet = new Practice2023.DBPracticeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblName.Location = new System.Drawing.Point(848, 176);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(230, 25);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "11111111111111111111";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(848, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Предприниматель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.White;
            this.LblID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblID.Location = new System.Drawing.Point(798, 76);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(280, 25);
            this.LblID.TabIndex = 3;
            this.LblID.Text = "ID";
            this.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practice2023.Properties.Resources.Joker;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(903, 246);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(357, 34);
            this.BtnEnter.TabIndex = 7;
            this.BtnEnter.Text = "Редактировать профиль";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblBack
            // 
            this.LblBack.AutoSize = true;
            this.LblBack.BackColor = System.Drawing.Color.White;
            this.LblBack.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBack.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblBack.Location = new System.Drawing.Point(112, 89);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(184, 26);
            this.LblBack.TabIndex = 34;
            this.LblBack.Text = "Выйти из системы";
            this.LblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 34);
            this.button1.TabIndex = 35;
            this.button1.Text = "Разместить товар";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BsTovars
            // 
            this.BsTovars.DataSource = this.dBPracticeDataSet;
            this.BsTovars.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.BsTovars;
            this.dataGridView1.Location = new System.Drawing.Point(117, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 420);
            this.dataGridView1.TabIndex = 36;
            // 
            // dBPracticeDataSet
            // 
            this.dBPracticeDataSet.DataSetName = "DBPracticeDataSet";
            this.dBPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practice2023.Properties.Resources.ForAllLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 779);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 818);
            this.MinimumSize = new System.Drawing.Size(1400, 818);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"OK_Magazine\" > Предприниматель";
            this.Load += new System.EventHandler(this.FormClient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource BsTovars;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBPracticeDataSet dBPracticeDataSet;
    }
}