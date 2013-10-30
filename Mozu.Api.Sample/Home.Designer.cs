namespace Mozu.Api.Sample
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEnvironment = new System.Windows.Forms.ComboBox();
            this.environmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtApplicationID = new System.Windows.Forms.TextBox();
            this.txtSharedSecret = new System.Windows.Forms.TextBox();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAPI = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTenant = new System.Windows.Forms.Panel();
            this.cbTenant = new System.Windows.Forms.ComboBox();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.environmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.panelAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shared Secret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Environment:";
            // 
            // cbEnvironment
            // 
            this.cbEnvironment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.environmentBindingSource, "Value", true));
            this.cbEnvironment.DataSource = this.environmentBindingSource;
            this.cbEnvironment.DisplayMember = "Key";
            this.cbEnvironment.FormattingEnabled = true;
            this.cbEnvironment.Location = new System.Drawing.Point(112, 67);
            this.cbEnvironment.Name = "cbEnvironment";
            this.cbEnvironment.Size = new System.Drawing.Size(211, 21);
            this.cbEnvironment.TabIndex = 3;
            this.cbEnvironment.ValueMember = "Value";
            this.cbEnvironment.SelectedIndexChanged += new System.EventHandler(this.AuthValuesChanged);
            // 
            // environmentBindingSource
            // 
            this.environmentBindingSource.DataSource = typeof(Mozu.Api.Sample.Models.Environment);
            // 
            // txtApplicationID
            // 
            this.txtApplicationID.Location = new System.Drawing.Point(112, 99);
            this.txtApplicationID.Name = "txtApplicationID";
            this.txtApplicationID.Size = new System.Drawing.Size(211, 20);
            this.txtApplicationID.TabIndex = 4;
            this.txtApplicationID.TextChanged += new System.EventHandler(this.AuthValuesChanged);
            // 
            // txtSharedSecret
            // 
            this.txtSharedSecret.Location = new System.Drawing.Point(112, 129);
            this.txtSharedSecret.Name = "txtSharedSecret";
            this.txtSharedSecret.PasswordChar = '*';
            this.txtSharedSecret.Size = new System.Drawing.Size(211, 20);
            this.txtSharedSecret.TabIndex = 5;
            this.txtSharedSecret.TextChanged += new System.EventHandler(this.AuthValuesChanged);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(248, 227);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(75, 23);
            this.btnAuthenticate.TabIndex = 6;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(Mozu.Api.Contracts.Tenant.Site);
            // 
            // panelAPI
            // 
            this.panelAPI.Controls.Add(this.btnOrder);
            this.panelAPI.Controls.Add(this.btnProduct);
            this.panelAPI.Location = new System.Drawing.Point(23, 354);
            this.panelAPI.Name = "panelAPI";
            this.panelAPI.Size = new System.Drawing.Size(315, 64);
            this.panelAPI.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(191, 19);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 23);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Orders";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(9, 19);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(109, 23);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cbSite
            // 
            this.cbSite.DataSource = this.siteBindingSource;
            this.cbSite.DisplayMember = "Name";
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Location = new System.Drawing.Point(82, 45);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(218, 21);
            this.cbSite.TabIndex = 11;
            this.cbSite.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tenant ID:";
            // 
            // panelTenant
            // 
            this.panelTenant.Controls.Add(this.cbTenant);
            this.panelTenant.Controls.Add(this.label6);
            this.panelTenant.Controls.Add(this.label4);
            this.panelTenant.Controls.Add(this.cbSite);
            this.panelTenant.Location = new System.Drawing.Point(23, 272);
            this.panelTenant.Name = "panelTenant";
            this.panelTenant.Size = new System.Drawing.Size(315, 76);
            this.panelTenant.TabIndex = 13;
            // 
            // cbTenant
            // 
            this.cbTenant.DataSource = this.tenantBindingSource;
            this.cbTenant.DisplayMember = "Name";
            this.cbTenant.FormattingEnabled = true;
            this.cbTenant.Location = new System.Drawing.Point(81, 13);
            this.cbTenant.Name = "cbTenant";
            this.cbTenant.Size = new System.Drawing.Size(218, 21);
            this.cbTenant.TabIndex = 18;
            this.cbTenant.ValueMember = "Id";
            this.cbTenant.SelectedIndexChanged += new System.EventHandler(this.cbTenant_changed);
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataSource = typeof(Mozu.Api.Contracts.Tenant.Tenant);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Site:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Tag = "Email";
            this.label8.Text = "Email:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 432);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTenant);
            this.Controls.Add(this.panelAPI);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.txtSharedSecret);
            this.Controls.Add(this.txtApplicationID);
            this.Controls.Add(this.cbEnvironment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Mozu SDK Sample";
            ((System.ComponentModel.ISupportInitialize)(this.environmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.panelAPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTenant.ResumeLayout(false);
            this.panelTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEnvironment;
        private System.Windows.Forms.TextBox txtApplicationID;
        private System.Windows.Forms.TextBox txtSharedSecret;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.BindingSource environmentBindingSource;
        private System.Windows.Forms.Panel panelAPI;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTenant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTenant;
        private System.Windows.Forms.BindingSource tenantBindingSource;
    }
}

