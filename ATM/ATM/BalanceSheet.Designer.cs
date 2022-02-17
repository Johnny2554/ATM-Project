namespace ATM
{
    partial class BalanceSheet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.aTMAccountDataSet = new ATM.ATMAccountDataSet();
            this.atrmloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atrmloginTableAdapter = new ATM.ATMAccountDataSetTableAdapters.atrmloginTableAdapter();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountHolderTableAdapter = new ATM.ATMAccountDataSetTableAdapters.AccountHolderTableAdapter();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMAccountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrmloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountHolderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNoDataGridViewTextBoxColumn,
            this.userpassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.atrmloginBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 111);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.balanceDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userSurnameDataGridViewTextBoxColumn,
            this.accountLinkDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accountHolderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 125);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aTMAccountDataSet
            // 
            this.aTMAccountDataSet.DataSetName = "ATMAccountDataSet";
            this.aTMAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atrmloginBindingSource
            // 
            this.atrmloginBindingSource.DataMember = "atrmlogin";
            this.atrmloginBindingSource.DataSource = this.aTMAccountDataSet;
            // 
            // atrmloginTableAdapter
            // 
            this.atrmloginTableAdapter.ClearBeforeFill = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Account_No";
            this.accountNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // userpassDataGridViewTextBoxColumn
            // 
            this.userpassDataGridViewTextBoxColumn.DataPropertyName = "Userpass";
            this.userpassDataGridViewTextBoxColumn.HeaderText = "Userpass";
            this.userpassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userpassDataGridViewTextBoxColumn.Name = "userpassDataGridViewTextBoxColumn";
            this.userpassDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountHolderBindingSource
            // 
            this.accountHolderBindingSource.DataMember = "AccountHolder";
            this.accountHolderBindingSource.DataSource = this.aTMAccountDataSet;
            // 
            // accountHolderTableAdapter
            // 
            this.accountHolderTableAdapter.ClearBeforeFill = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userSurnameDataGridViewTextBoxColumn
            // 
            this.userSurnameDataGridViewTextBoxColumn.DataPropertyName = "UserSurname";
            this.userSurnameDataGridViewTextBoxColumn.HeaderText = "UserSurname";
            this.userSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userSurnameDataGridViewTextBoxColumn.Name = "userSurnameDataGridViewTextBoxColumn";
            this.userSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountLinkDataGridViewTextBoxColumn
            // 
            this.accountLinkDataGridViewTextBoxColumn.DataPropertyName = "AccountLink";
            this.accountLinkDataGridViewTextBoxColumn.HeaderText = "AccountLink";
            this.accountLinkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountLinkDataGridViewTextBoxColumn.Name = "accountLinkDataGridViewTextBoxColumn";
            this.accountLinkDataGridViewTextBoxColumn.Width = 125;
            // 
            // BalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "BalanceSheet";
            this.Text = "BalanceSheet";
            this.Load += new System.EventHandler(this.BalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMAccountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrmloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountHolderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ATMAccountDataSet aTMAccountDataSet;
        private System.Windows.Forms.BindingSource atrmloginBindingSource;
        private ATMAccountDataSetTableAdapters.atrmloginTableAdapter atrmloginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountHolderBindingSource;
        private ATMAccountDataSetTableAdapters.AccountHolderTableAdapter accountHolderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountLinkDataGridViewTextBoxColumn;
    }
}