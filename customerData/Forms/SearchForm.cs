using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerData
{
    public partial class SearchForm : Form
    {
        public string Searchtext { get; private set; }

        /// <summary>
        /// Creats a new SearchForm
        /// </summary>
        public SearchForm(CultureInfo myCultureInfo)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            InitializeComponent();
        }

        /// <summary>
        /// Close Dialog and write Text form Textbox to "Searchtext"
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Searchtext = this.tbxSearchtext.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancel the Form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
