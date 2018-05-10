namespace customerData
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.btnPWDOK = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnMoneyTransfer = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.panPWD = new System.Windows.Forms.Panel();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPWD = new System.Windows.Forms.TextBox();
            this.sfdSaveCSV = new System.Windows.Forms.SaveFileDialog();
            this.ofdImportCSV = new System.Windows.Forms.OpenFileDialog();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panPWD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnImportCSV
            // 
            resources.ApplyResources(this.btnImportCSV, "btnImportCSV");
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);
            // 
            // btnSaveCSV
            // 
            resources.ApplyResources(this.btnSaveCSV, "btnSaveCSV");
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // btnPWDOK
            // 
            resources.ApplyResources(this.btnPWDOK, "btnPWDOK");
            this.btnPWDOK.Name = "btnPWDOK";
            this.btnPWDOK.UseVisualStyleBackColor = true;
            this.btnPWDOK.Click += new System.EventHandler(this.btnPWDOK_Click);
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.btnShowAll);
            this.panMain.Controls.Add(this.btnMoneyTransfer);
            this.panMain.Controls.Add(this.btnEdit);
            this.panMain.Controls.Add(this.dgvCustomers);
            this.panMain.Controls.Add(this.btnSearch);
            this.panMain.Controls.Add(this.btnImportCSV);
            this.panMain.Controls.Add(this.btnAdd);
            this.panMain.Controls.Add(this.btnSaveCSV);
            resources.ApplyResources(this.panMain, "panMain");
            this.panMain.Name = "panMain";
            // 
            // btnShowAll
            // 
            resources.ApplyResources(this.btnShowAll, "btnShowAll");
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnMoneyTransfer
            // 
            resources.ApplyResources(this.btnMoneyTransfer, "btnMoneyTransfer");
            this.btnMoneyTransfer.Name = "btnMoneyTransfer";
            this.btnMoneyTransfer.UseVisualStyleBackColor = true;
            this.btnMoneyTransfer.Click += new System.EventHandler(this.btnMoneyTransfer_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.FirstName,
            this.Surname,
            this.Mail,
            this.Balance,
            this.LastChange});
            resources.ApplyResources(this.dgvCustomers, "dgvCustomers");
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 24;
            // 
            // panPWD
            // 
            resources.ApplyResources(this.panPWD, "panPWD");
            this.panPWD.Controls.Add(this.btnLanguage);
            this.panPWD.Controls.Add(this.label1);
            this.panPWD.Controls.Add(this.txbPWD);
            this.panPWD.Controls.Add(this.btnPWDOK);
            this.panPWD.Name = "panPWD";
            // 
            // btnLanguage
            // 
            resources.ApplyResources(this.btnLanguage, "btnLanguage");
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txbPWD
            // 
            resources.ApplyResources(this.txbPWD, "txbPWD");
            this.txbPWD.Name = "txbPWD";
            this.txbPWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPWD_KeyDown);
            // 
            // sfdSaveCSV
            // 
            this.sfdSaveCSV.FileName = "Customers.csv";
            resources.ApplyResources(this.sfdSaveCSV, "sfdSaveCSV");
            // 
            // ofdImportCSV
            // 
            this.ofdImportCSV.FileName = "Customers.csv";
            resources.ApplyResources(this.ofdImportCSV, "ofdImportCSV");
            // 
            // Nr
            // 
            resources.ApplyResources(this.Nr, "Nr");
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Surname
            // 
            resources.ApplyResources(this.Surname, "Surname");
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Mail
            // 
            resources.ApplyResources(this.Mail, "Mail");
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Balance
            // 
            resources.ApplyResources(this.Balance, "Balance");
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // LastChange
            // 
            resources.ApplyResources(this.LastChange, "LastChange");
            this.LastChange.Name = "LastChange";
            this.LastChange.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panPWD);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panPWD.ResumeLayout(false);
            this.panPWD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.Button btnPWDOK;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panPWD;
        private System.Windows.Forms.TextBox txbPWD;
        private System.Windows.Forms.SaveFileDialog sfdSaveCSV;
        private System.Windows.Forms.OpenFileDialog ofdImportCSV;
        private System.Windows.Forms.Button btnMoneyTransfer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastChange;
    }
}

