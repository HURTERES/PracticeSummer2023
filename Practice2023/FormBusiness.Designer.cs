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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.LblBack = new System.Windows.Forms.Label();
            this.BtnPlace = new System.Windows.Forms.Button();
            this.BsTovars = new System.Windows.Forms.BindingSource(this.components);
            this.dBPracticeDataSet = new Practice2023.DBPracticeDataSet();
            this.DgvTovars = new System.Windows.Forms.DataGridView();
            this.tovarTableAdapter = new Practice2023.DBPracticeDataSetTableAdapters.TovarTableAdapter();
            this.RtbxFilter = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.TovarsBS = new System.Windows.Forms.BindingSource(this.components);
            this.idTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countInStorageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovarsBS)).BeginInit();
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
            // BtnEditProfile
            // 
            this.BtnEditProfile.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProfile.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditProfile.ForeColor = System.Drawing.Color.White;
            this.BtnEditProfile.Location = new System.Drawing.Point(903, 246);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.Size = new System.Drawing.Size(357, 34);
            this.BtnEditProfile.TabIndex = 7;
            this.BtnEditProfile.Text = "Редактировать профиль";
            this.BtnEditProfile.UseVisualStyleBackColor = false;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEnter_Click);
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
            // BtnPlace
            // 
            this.BtnPlace.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlace.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPlace.ForeColor = System.Drawing.Color.White;
            this.BtnPlace.Location = new System.Drawing.Point(117, 192);
            this.BtnPlace.Name = "BtnPlace";
            this.BtnPlace.Size = new System.Drawing.Size(420, 34);
            this.BtnPlace.TabIndex = 35;
            this.BtnPlace.Text = "Разместить товар";
            this.BtnPlace.UseVisualStyleBackColor = false;
            this.BtnPlace.Click += new System.EventHandler(this.button1_Click);
            // 
            // BsTovars
            // 
            this.BsTovars.DataMember = "Tovar";
            this.BsTovars.DataSource = this.dBPracticeDataSet;
            // 
            // dBPracticeDataSet
            // 
            this.dBPracticeDataSet.DataSetName = "DBPracticeDataSet";
            this.dBPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DgvTovars
            // 
            this.DgvTovars.AllowUserToAddRows = false;
            this.DgvTovars.AllowUserToDeleteRows = false;
            this.DgvTovars.AllowUserToResizeColumns = false;
            this.DgvTovars.AllowUserToResizeRows = false;
            this.DgvTovars.AutoGenerateColumns = false;
            this.DgvTovars.BackgroundColor = System.Drawing.Color.White;
            this.DgvTovars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTovars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTovars.ColumnHeadersHeight = 30;
            this.DgvTovars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvTovars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTovarDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.countTovarDataGridViewTextBoxColumn,
            this.countInStorageDataGridViewTextBoxColumn,
            this.whoseDataGridViewTextBoxColumn});
            this.DgvTovars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvTovars.DataSource = this.TovarsBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTovars.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTovars.EnableHeadersVisualStyles = false;
            this.DgvTovars.GridColor = System.Drawing.Color.White;
            this.DgvTovars.Location = new System.Drawing.Point(117, 304);
            this.DgvTovars.Name = "DgvTovars";
            this.DgvTovars.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTovars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTovars.RowHeadersVisible = false;
            this.DgvTovars.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvTovars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTovars.Size = new System.Drawing.Size(977, 420);
            this.DgvTovars.TabIndex = 36;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // RtbxFilter
            // 
            this.RtbxFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxFilter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxFilter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxFilter.Location = new System.Drawing.Point(126, 246);
            this.RtbxFilter.Name = "RtbxFilter";
            this.RtbxFilter.Size = new System.Drawing.Size(344, 34);
            this.RtbxFilter.TabIndex = 37;
            this.RtbxFilter.Text = "Фильтр по названию";
            this.RtbxFilter.TextChanged += new System.EventHandler(this.RtbxFilter_TextChanged);
            this.RtbxFilter.Enter += new System.EventHandler(this.RtbxFilter_Enter);
            this.RtbxFilter.Leave += new System.EventHandler(this.RtbxFilter_Leave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(126, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 38;
            // 
            // BtnFilter
            // 
            this.BtnFilter.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFilter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFilter.ForeColor = System.Drawing.Color.White;
            this.BtnFilter.Location = new System.Drawing.Point(476, 246);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(61, 34);
            this.BtnFilter.TabIndex = 39;
            this.BtnFilter.Text = "…";
            this.BtnFilter.UseVisualStyleBackColor = false;
            // 
            // TovarsBS
            // 
            this.TovarsBS.DataMember = "Tovar";
            this.TovarsBS.DataSource = this.dBPracticeDataSet;
            // 
            // idTovarDataGridViewTextBoxColumn
            // 
            this.idTovarDataGridViewTextBoxColumn.DataPropertyName = "Id_Tovar";
            this.idTovarDataGridViewTextBoxColumn.HeaderText = "Id_Tovar";
            this.idTovarDataGridViewTextBoxColumn.Name = "idTovarDataGridViewTextBoxColumn";
            this.idTovarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTovarDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 140;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикль";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleDataGridViewTextBoxColumn.Width = 140;
            // 
            // countTovarDataGridViewTextBoxColumn
            // 
            this.countTovarDataGridViewTextBoxColumn.DataPropertyName = "CountTovar";
            this.countTovarDataGridViewTextBoxColumn.HeaderText = "В упаковке";
            this.countTovarDataGridViewTextBoxColumn.Name = "countTovarDataGridViewTextBoxColumn";
            this.countTovarDataGridViewTextBoxColumn.ReadOnly = true;
            this.countTovarDataGridViewTextBoxColumn.Width = 140;
            // 
            // countInStorageDataGridViewTextBoxColumn
            // 
            this.countInStorageDataGridViewTextBoxColumn.DataPropertyName = "CountInStorage";
            this.countInStorageDataGridViewTextBoxColumn.HeaderText = "На складе";
            this.countInStorageDataGridViewTextBoxColumn.Name = "countInStorageDataGridViewTextBoxColumn";
            this.countInStorageDataGridViewTextBoxColumn.ReadOnly = true;
            this.countInStorageDataGridViewTextBoxColumn.Width = 140;
            // 
            // whoseDataGridViewTextBoxColumn
            // 
            this.whoseDataGridViewTextBoxColumn.DataPropertyName = "Whose";
            this.whoseDataGridViewTextBoxColumn.HeaderText = "Whose";
            this.whoseDataGridViewTextBoxColumn.Name = "whoseDataGridViewTextBoxColumn";
            this.whoseDataGridViewTextBoxColumn.ReadOnly = true;
            this.whoseDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practice2023.Properties.Resources.ForAllLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1384, 779);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RtbxFilter);
            this.Controls.Add(this.DgvTovars);
            this.Controls.Add(this.BtnPlace);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.BtnEditProfile);
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
            this.Click += new System.EventHandler(this.FormClient_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovarsBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEditProfile;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.Button BtnPlace;
        private System.Windows.Forms.BindingSource BsTovars;
        private System.Windows.Forms.DataGridView DgvTovars;
        private DBPracticeDataSet dBPracticeDataSet;
        private DBPracticeDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.RichTextBox RtbxFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.BindingSource TovarsBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countInStorageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoseDataGridViewTextBoxColumn;
    }
}