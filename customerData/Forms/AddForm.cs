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
    public partial class AddForm : Form
    {
        private int customerNr;
        public Customer Customer { get; private set; }

        /// <summary>
        /// Creates a AddForm
        /// </summary>
        public AddForm(int customerNr, CultureInfo myCultureInfo)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.customerNr = customerNr;
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new Customer
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try 
	        {
                if (this.tbxName.Text != "" && this.tbxSurname.Text != "" && this.tbxMail.Text != "")
                {
                    if (this.tbxBalance.Text == "") this.tbxBalance.Text = "0";
                    this.Customer = new Customer(
                                            this.tbxName.Text,
                                            this.tbxSurname.Text,
                                            this.tbxMail.Text,
                                            Double.Parse(this.tbxBalance.Text),
                                            this.customerNr, DateTime.Today);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new FormatException(Properties.Resources.txtEmpty);
                }
                
	        }
	        catch (Exception ex)
	        {
                this.eprError.Clear();
                this.eprError.SetError(this.btnOK, ex.Message);
	        }
        }

        /// <summary>
        /// Cancle the Form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
