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
using System.Threading;
using System.Globalization;

namespace customerData
{
    public partial class MoneyTransferForm : Form
    {
        private Customer customer;
        
        public MoneyTransferForm(Customer customer, CultureInfo myCultureInfo)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            this.customer = customer;
            InitializeComponent();
            this.tbxAvailable.Text = customer.BALANCE.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rdbAdd.Checked)
                {
                    this.customer.AddMoney(Double.Parse(this.tbxMoney.Text));
                }
                else if (this.rdbPay.Checked)
                {
                    this.customer.PayMoney(Double.Parse(this.tbxMoney.Text));
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) 
            {
                this.eprError.Clear();
                this.eprError.SetError(this.tbxMoney, ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
