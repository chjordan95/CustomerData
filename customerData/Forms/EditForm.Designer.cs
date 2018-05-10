namespace customerData
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.tbxEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdbSurname = new System.Windows.Forms.RadioButton();
            this.rdbMail = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEdit
            // 
            resources.ApplyResources(this.tbxEdit, "tbxEdit");
            this.eprError.SetError(this.tbxEdit, resources.GetString("tbxEdit.Error"));
            this.eprError.SetIconAlignment(this.tbxEdit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbxEdit.IconAlignment"))));
            this.eprError.SetIconPadding(this.tbxEdit, ((int)(resources.GetObject("tbxEdit.IconPadding"))));
            this.tbxEdit.Name = "tbxEdit";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.eprError.SetError(this.btnEdit, resources.GetString("btnEdit.Error"));
            this.eprError.SetIconAlignment(this.btnEdit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnEdit.IconAlignment"))));
            this.eprError.SetIconPadding(this.btnEdit, ((int)(resources.GetObject("btnEdit.IconPadding"))));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // eprError
            // 
            this.eprError.ContainerControl = this;
            resources.ApplyResources(this.eprError, "eprError");
            // 
            // rdbSurname
            // 
            resources.ApplyResources(this.rdbSurname, "rdbSurname");
            this.rdbSurname.Checked = true;
            this.eprError.SetError(this.rdbSurname, resources.GetString("rdbSurname.Error"));
            this.eprError.SetIconAlignment(this.rdbSurname, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rdbSurname.IconAlignment"))));
            this.eprError.SetIconPadding(this.rdbSurname, ((int)(resources.GetObject("rdbSurname.IconPadding"))));
            this.rdbSurname.Name = "rdbSurname";
            this.rdbSurname.TabStop = true;
            this.rdbSurname.UseVisualStyleBackColor = true;
            this.rdbSurname.CheckedChanged += new System.EventHandler(this.rdbSurname_CheckedChanged);
            // 
            // rdbMail
            // 
            resources.ApplyResources(this.rdbMail, "rdbMail");
            this.eprError.SetError(this.rdbMail, resources.GetString("rdbMail.Error"));
            this.eprError.SetIconAlignment(this.rdbMail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rdbMail.IconAlignment"))));
            this.eprError.SetIconPadding(this.rdbMail, ((int)(resources.GetObject("rdbMail.IconPadding"))));
            this.rdbMail.Name = "rdbMail";
            this.rdbMail.UseVisualStyleBackColor = true;
            this.rdbMail.CheckedChanged += new System.EventHandler(this.rdbMail_CheckedChanged);
            // 
            // EditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.rdbMail);
            this.Controls.Add(this.rdbSurname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxEdit);
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider eprError;
        private System.Windows.Forms.RadioButton rdbMail;
        private System.Windows.Forms.RadioButton rdbSurname;
    }
}