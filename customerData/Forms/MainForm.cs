using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerLibrary;
using System.Globalization;
using System.Threading;
using System.IO;

namespace customerData
{
    public partial class MainForm : Form
    {
        #region Variables
        private string password;
        private bool listHasChanged;
        private ListOfCustomer listOfCustomer;
        private CultureInfo myCultureInfo;
        private string language;
        #endregion


        /// <summary>
        /// Creates a MainForm
        /// </summary>
        public MainForm(string password)
        {
            LoadLanguage();
            this.myCultureInfo = new CultureInfo(language);
            this.password = password;
            this.listHasChanged = false;
            this.listOfCustomer = new ListOfCustomer();
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            LoadMainForm();
            SaveLanguage();
        }

        /// <summary>
        /// Method to initalize the components e.g. when language is changed
        /// </summary>
        public void LoadMainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }


        #region Events
        /// <summary>
        /// Checks password and switch to customer entry
        /// </summary>
        private void btnPWDOK_Click(object sender, EventArgs e)
        {
            if (this.txbPWD.Text == this.password)
            {
                this.panPWD.Visible = false;
                this.panMain.Visible = true;
            }
            else
            {
                MessageBox.Show(Properties.Resources.stringPassword, Properties.Resources.stringAccess, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txbPWD.Text = "";
            }
        }

        /// <summary>
        /// Checks if Enter is Pressed
        /// </summary>
        private void txbPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPWDOK.PerformClick();
            }
        }

        /// <summary>
        /// Opens AddForm where add a new customer in the ListOfCustomer
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(listOfCustomer.Count, myCultureInfo);
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        this.listOfCustomer.AddCustomer(addForm.Customer);
                        UpdateDatagridview(listOfCustomer);
                        listHasChanged = true;

                    }
                    repeat = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        /// <summary>
        /// Opens SearchForm and show the founded results
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(myCultureInfo);
            ListOfCustomer searchedCustomers = new ListOfCustomer();

            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                foreach (Customer oneCustomer in this.listOfCustomer)
                {
                    if (oneCustomer.NAME.ToUpper().Contains(searchForm.Searchtext.ToUpper())
                        ||
                        oneCustomer.SURNAME.ToUpper().Contains(searchForm.Searchtext.ToUpper())
                        ||
                        oneCustomer.MAIL.ToUpper().Contains(searchForm.Searchtext.ToUpper())
                        )
                    {
                        searchedCustomers.Add(oneCustomer);
                    }
                }
                if (searchedCustomers.Count != 0)
                {
                    UpdateDatagridview(searchedCustomers);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.stringSearch, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        /// <summary>
        /// Opens a dialog and imports a CSV File with crypted ListOfCustomer
        /// </summary>
        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            if (this.ofdImportCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.listOfCustomer.ImportCSV(this.ofdImportCSV.FileName);
                    UpdateDatagridview(listOfCustomer);
                    listHasChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Opens a dialog and save a CSV File with crypted ListOfCustomer
        /// </summary>
        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }

        /// <summary>
        /// Opens EdidForm and allows the User to edit Surname or Mail
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index;
            Customer customer = GetSelectedCustomer(out index);

            if (customer != null)
            {
                EditForm editForm = new EditForm(this.listOfCustomer, customer, myCultureInfo);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateDatagridview(listOfCustomer);
                    listHasChanged = true;
                }
            }

            else MessageBox.Show(Properties.Resources.stringCustomer, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Opens MoneyTransferForm and allows the User to transfer Money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoneyTransfer_Click(object sender, EventArgs e)
        {
            int index;
            Customer customer = GetSelectedCustomer(out index);
            if (customer != null)
            {
                MoneyTransferForm moneyTransferForm = new MoneyTransferForm(customer, myCultureInfo);
                if (moneyTransferForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateDatagridview(listOfCustomer);
                    listHasChanged = true;
                }
            }
            else MessageBox.Show(Properties.Resources.stringCustomer, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Uptate the Datagridview e.g. after searching
        /// </summary>
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateDatagridview(this.listOfCustomer);
        }

        /// <summary>
        /// Changes the language when button is pressed
        /// </summary>
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (language == "en")
            {
                language = "de";
            }
            else
            {
                language = "en";
            }
            myCultureInfo = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            this.Controls.Clear();
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            LoadMainForm();     
            SaveLanguage();
        }

        /// <summary>
        /// Check changes and ask user for saving the file
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dgvCustomers.Rows.Count != 0
                &&
                this.listHasChanged)
            {
                DialogResult result = MessageBox.Show(Properties.Resources.stringData, Properties.Resources.stringClosing, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if ((result == DialogResult.Yes
                            &&
                            SaveCSV() != DialogResult.OK)
                    ||
                    result == DialogResult.Cancel) e.Cancel = true;
            }
        }
        #endregion

        #region private Methods
        /// <summary>
        /// Update the data in datagridview with any ListOfCustomer
        /// </summary>
        private void UpdateDatagridview(ListOfCustomer customers)
        {
            this.dgvCustomers.Rows.Clear();
            foreach (Customer customer in customers)
            {
                this.dgvCustomers.Rows.Add(new object[]{
                        customer.CUSTOMERNR,
                        customer.NAME,
                        customer.SURNAME,
                        customer.MAIL,
                        customer.BALANCE,
                        customer.LASTCHANGE.ToShortDateString()});
            }
        }

        /// <summary>
        /// gives the the selected customer from the datagridview
        /// </summary>
        private Customer GetSelectedCustomer(out int index)
        {
            index = 0;
            int customerNr;

            if (this.dgvCustomers.CurrentRow != null
                &&
                Int32.TryParse(this.dgvCustomers.Rows[this.dgvCustomers.CurrentRow.Index].Cells[0].Value.ToString(), out customerNr))
            {
                foreach (Customer customer in listOfCustomer)
                {
                    if (customer.CUSTOMERNR == customerNr) return customer;
                    index++;
                }
            }

            return null;
        }

        /// <summary>
        /// Show Dialog and save to CSV
        /// </summary>
        private DialogResult SaveCSV()
        {
            if (this.sfdSaveCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.listOfCustomer.SaveToCSV(this.sfdSaveCSV.FileName);
                    listHasChanged = false;
                    return DialogResult.OK;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.stringError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return DialogResult.Abort;
        }

        /// <summary>
        /// Saves the selected language to a txt file
        /// </summary>
        private void SaveLanguage()
        {
            StreamWriter writer = new StreamWriter(@"Language.txt", false);
            writer.WriteLine(myCultureInfo);
            writer.Close();
        }

        /// <summary>
        /// loades a txt file for the selected language
        /// </summary>
        private void LoadLanguage()
        {
            if (File.Exists(@"Language.txt"))
            {
                StreamReader reader = new StreamReader(@"Language.txt", false);
                language = reader.ReadLine();
                reader.Close();
            }
            else
            {
                language = "en";
            }

        }
        #endregion

    }
}
