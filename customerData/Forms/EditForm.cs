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

namespace customerData
{
    public partial class EditForm : Form
    {
        private Customer customer;
        private ListOfCustomer listOfCustomer;

        /// <summary>
        /// Creates a new EditForm, where customer can be edited / istOfCustomer is used for checking individual Mail
        /// Show surname or mail in the Textbox
        /// </summary>
        public EditForm(ListOfCustomer listOfCustomer, Customer customer, CultureInfo myCultureInfo)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            this.customer = customer;
            this.listOfCustomer = listOfCustomer;
            InitializeComponent();
            if (this.rdbSurname.Checked) this.tbxEdit.Text = this.customer.SURNAME;
            else if (this.rdbMail.Checked) this.tbxEdit.Text = this.customer.MAIL;
            
 
        }

        /// <summary>
        /// Check surname and individual Mail. Edit referenced Customer
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rdbSurname.Checked) this.customer.ChangeSurname(this.tbxEdit.Text);
                else if (this.rdbMail.Checked 
                            &&
                            this.customer.MAIL != this.tbxEdit.Text) this.listOfCustomer.ChangeMail(this.customer, this.tbxEdit.Text);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                this.eprError.Clear();
                this.eprError.SetError(this.tbxEdit, ex.Message);
            }
            
        }

        /// <summary>
        /// Cancel Form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Radiobutton pressed, switch the Textfield to surname of customer
        /// </summary>
        private void rdbSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbSurname.Checked) this.tbxEdit.Text = this.customer.SURNAME;
            
        }

        /// <summary>
        /// Radiobutton pressed, switch the Textfield to Mail of customer
        /// </summary>
        private void rdbMail_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbMail.Checked) this.tbxEdit.Text = this.customer.MAIL;
        }

    }
}
