namespace customerData
{
    partial class MoneyTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyTransferForm));
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbPay = new System.Windows.Forms.RadioButton();
            this.tbxAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            resources.ApplyResources(this.btnTransfer, "btnTransfer");
            this.eprError.SetError(this.btnTransfer, resources.GetString("btnTransfer.Error"));
            this.eprError.SetIconAlignment(this.btnTransfer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnTransfer.IconAlignment"))));
            this.eprError.SetIconPadding(this.btnTransfer, ((int)(resources.GetObject("btnTransfer.IconPadding"))));
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.eprError.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.eprError.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.eprError.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxMoney
            // 
            resources.ApplyResources(this.tbxMoney, "tbxMoney");
            this.eprError.SetError(this.tbxMoney, resources.GetString("tbxMoney.Error"));
            this.eprError.SetIconAlignment(this.tbxMoney, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxMoney.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxMoney, ((int)(resources.GetObject("tbxMoney.IconPadding"))));
            this.tbxMoney.Name = "tbxMoney";
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            resources.ApplyResources(this.eprError, "eprError");
            // 
            // rdbAdd
            // 
            resources.ApplyResources(this.rdbAdd, "rdbAdd");
            this.rdbAdd.Checked = true;
            this.eprError.SetError(this.rdbAdd, resources.GetString("rdbAdd.Error"));
            this.eprError.SetIconAlignment(this.rdbAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rdbAdd.IconAlignment"))));
            this.eprError.SetIconPadding(this.rdbAdd, ((int)(resources.GetObject("rdbAdd.IconPadding"))));
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.TabStop = true;
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbPay
            // 
            resources.ApplyResources(this.rdbPay, "rdbPay");
            this.eprError.SetError(this.rdbPay, resources.GetString("rdbPay.Error"));
            this.eprError.SetIconAlignment(this.rdbPay, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rdbPay.IconAlignment"))));
            this.eprError.SetIconPadding(this.rdbPay, ((int)(resources.GetObject("rdbPay.IconPadding"))));
            this.rdbPay.Name = "rdbPay";
            this.rdbPay.UseVisualStyleBackColor = true;
            // 
            // tbxAvailable
            // 
            resources.ApplyResources(this.tbxAvailable, "tbxAvailable");
            this.eprError.SetError(this.tbxAvailable, resources.GetString("tbxAvailable.Error"));
            this.eprError.SetIconAlignment(this.tbxAvailable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxAvailable.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxAvailable, ((int)(resources.GetObject("tbxAvailable.IconPadding"))));
            this.tbxAvailable.Name = "tbxAvailable";
            this.tbxAvailable.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.eprError.SetError(this.label1, resources.GetString("label1.Error"));
            this.eprError.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.eprError.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // MoneyTransferForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbPay);
            this.Controls.Add(this.rdbAdd);
            this.Controls.Add(this.tbxAvailable);
            this.Controls.Add(this.tbxMoney);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.Name = "MoneyTransferForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.RadioButton rdbPay;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.TextBox tbxAvailable;
        private System.Windows.Forms.Label label1;
    }
}