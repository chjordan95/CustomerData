namespace customerData
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblStartBalance = new System.Windows.Forms.Label();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            resources.ApplyResources(this.tbxName, "tbxName");
            this.eprError.SetError(this.tbxName, resources.GetString("tbxName.Error"));
            this.eprError.SetIconAlignment(this.tbxName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxName.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxName, ((int)(resources.GetObject("tbxName.IconPadding"))));
            this.tbxName.Name = "tbxName";
            // 
            // tbxSurname
            // 
            resources.ApplyResources(this.tbxSurname, "tbxSurname");
            this.eprError.SetError(this.tbxSurname, resources.GetString("tbxSurname.Error"));
            this.eprError.SetIconAlignment(this.tbxSurname, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxSurname.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxSurname, ((int)(resources.GetObject("tbxSurname.IconPadding"))));
            this.tbxSurname.Name = "tbxSurname";
            // 
            // tbxMail
            // 
            resources.ApplyResources(this.tbxMail, "tbxMail");
            this.eprError.SetError(this.tbxMail, resources.GetString("tbxMail.Error"));
            this.eprError.SetIconAlignment(this.tbxMail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxMail.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxMail, ((int)(resources.GetObject("tbxMail.IconPadding"))));
            this.tbxMail.Name = "tbxMail";
            // 
            // tbxBalance
            // 
            resources.ApplyResources(this.tbxBalance, "tbxBalance");
            this.eprError.SetError(this.tbxBalance, resources.GetString("tbxBalance.Error"));
            this.eprError.SetIconAlignment(this.tbxBalance, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxBalance.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxBalance, ((int)(resources.GetObject("tbxBalance.IconPadding"))));
            this.tbxBalance.Name = "tbxBalance";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.eprError.SetError(this.btnOK, resources.GetString("btnOK.Error"));
            this.eprError.SetIconAlignment(this.btnOK, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOK.IconAlignment"))));
            this.eprError.SetIconPadding(this.btnOK, ((int)(resources.GetObject("btnOK.IconPadding"))));
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.eprError.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.eprError.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.eprError.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.lblName.Name = "lblName";
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.eprError.SetError(this.lblSurname, resources.GetString("lblSurname.Error"));
            this.eprError.SetIconAlignment(this.lblSurname, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblSurname.IconAlignment"))));
            this.eprError.SetIconPadding(this.lblSurname, ((int)(resources.GetObject("lblSurname.IconPadding"))));
            this.lblSurname.Name = "lblSurname";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.eprError.SetError(this.lblMail, resources.GetString("lblMail.Error"));
            this.eprError.SetIconAlignment(this.lblMail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblMail.IconAlignment"))));
            this.eprError.SetIconPadding(this.lblMail, ((int)(resources.GetObject("lblMail.IconPadding"))));
            this.lblMail.Name = "lblMail";
            // 
            // lblStartBalance
            // 
            resources.ApplyResources(this.lblStartBalance, "lblStartBalance");
            this.eprError.SetError(this.lblStartBalance, resources.GetString("lblStartBalance.Error"));
            this.eprError.SetIconAlignment(this.lblStartBalance, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblStartBalance.IconAlignment"))));
            this.eprError.SetIconPadding(this.lblStartBalance, ((int)(resources.GetObject("lblStartBalance.IconPadding"))));
            this.lblStartBalance.Name = "lblStartBalance";
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            resources.ApplyResources(this.eprError, "eprError");
            // 
            // AddForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblStartBalance);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Name = "AddForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblStartBalance;
        private System.Windows.Forms.ErrorProvider eprError;
    }
}