namespace Practice2023
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.transTableAdapter = new Practice2023.DBPracticeDataSetTableAdapters.TransTableAdapter();
            this.DgvTovars = new System.Windows.Forms.DataGridView();
            this.dBPracticeDataSet = new Practice2023.DBPracticeDataSet();
            this.idTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatBoughtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howManyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoCompleteTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsHistory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTovars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // transTableAdapter
            // 
            this.transTableAdapter.ClearBeforeFill = true;
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
            this.idTransDataGridViewTextBoxColumn,
            this.numberTransDataGridViewTextBoxColumn,
            this.whatBoughtDataGridViewTextBoxColumn,
            this.timeTransDataGridViewTextBoxColumn,
            this.howManyDataGridViewTextBoxColumn,
            this.whoCompleteTransDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.DgvTovars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvTovars.DataSource = this.BsHistory;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTovars.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTovars.EnableHeadersVisualStyles = false;
            this.DgvTovars.GridColor = System.Drawing.Color.White;
            this.DgvTovars.Location = new System.Drawing.Point(0, 0);
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
            this.DgvTovars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTovars.Size = new System.Drawing.Size(833, 438);
            this.DgvTovars.TabIndex = 48;
            this.DgvTovars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTovars_CellDoubleClick);
            // 
            // dBPracticeDataSet
            // 
            this.dBPracticeDataSet.DataSetName = "DBPracticeDataSet";
            this.dBPracticeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTransDataGridViewTextBoxColumn
            // 
            this.idTransDataGridViewTextBoxColumn.DataPropertyName = "Id_Trans";
            this.idTransDataGridViewTextBoxColumn.HeaderText = "Id_Trans";
            this.idTransDataGridViewTextBoxColumn.Name = "idTransDataGridViewTextBoxColumn";
            this.idTransDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTransDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberTransDataGridViewTextBoxColumn
            // 
            this.numberTransDataGridViewTextBoxColumn.DataPropertyName = "NumberTrans";
            this.numberTransDataGridViewTextBoxColumn.HeaderText = "№ Транзакции";
            this.numberTransDataGridViewTextBoxColumn.Name = "numberTransDataGridViewTextBoxColumn";
            this.numberTransDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberTransDataGridViewTextBoxColumn.Width = 160;
            // 
            // whatBoughtDataGridViewTextBoxColumn
            // 
            this.whatBoughtDataGridViewTextBoxColumn.DataPropertyName = "WhatBought";
            this.whatBoughtDataGridViewTextBoxColumn.HeaderText = "Артикул товара";
            this.whatBoughtDataGridViewTextBoxColumn.Name = "whatBoughtDataGridViewTextBoxColumn";
            this.whatBoughtDataGridViewTextBoxColumn.ReadOnly = true;
            this.whatBoughtDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeTransDataGridViewTextBoxColumn
            // 
            this.timeTransDataGridViewTextBoxColumn.DataPropertyName = "TimeTrans";
            this.timeTransDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeTransDataGridViewTextBoxColumn.Name = "timeTransDataGridViewTextBoxColumn";
            this.timeTransDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeTransDataGridViewTextBoxColumn.Width = 220;
            // 
            // howManyDataGridViewTextBoxColumn
            // 
            this.howManyDataGridViewTextBoxColumn.DataPropertyName = "HowMany";
            this.howManyDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.howManyDataGridViewTextBoxColumn.Name = "howManyDataGridViewTextBoxColumn";
            this.howManyDataGridViewTextBoxColumn.ReadOnly = true;
            this.howManyDataGridViewTextBoxColumn.Width = 150;
            // 
            // whoCompleteTransDataGridViewTextBoxColumn
            // 
            this.whoCompleteTransDataGridViewTextBoxColumn.DataPropertyName = "WhoCompleteTrans";
            this.whoCompleteTransDataGridViewTextBoxColumn.HeaderText = "WhoCompleteTrans";
            this.whoCompleteTransDataGridViewTextBoxColumn.Name = "whoCompleteTransDataGridViewTextBoxColumn";
            this.whoCompleteTransDataGridViewTextBoxColumn.ReadOnly = true;
            this.whoCompleteTransDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 150;
            // 
            // BsHistory
            // 
            this.BsHistory.DataMember = "Trans";
            this.BsHistory.DataSource = this.dBPracticeDataSet;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 438);
            this.Controls.Add(this.DgvTovars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(853, 481);
            this.MinimumSize = new System.Drawing.Size(853, 481);
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"OK_Magazine\" > История покупок";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTovars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPracticeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BsHistory;
        private DBPracticeDataSetTableAdapters.TransTableAdapter transTableAdapter;
        public System.Windows.Forms.DataGridView DgvTovars;
        private DBPracticeDataSet dBPracticeDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatBoughtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howManyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoCompleteTransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}