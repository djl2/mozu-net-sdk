namespace Mozu.Api.Sample.ProductHandler
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
            this.getProductsBtn = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getProductsBtn
            // 
            this.getProductsBtn.Location = new System.Drawing.Point(27, 33);
            this.getProductsBtn.Name = "getProductsBtn";
            this.getProductsBtn.Size = new System.Drawing.Size(133, 23);
            this.getProductsBtn.TabIndex = 0;
            this.getProductsBtn.Text = "Get Products";
            this.getProductsBtn.UseVisualStyleBackColor = true;
            this.getProductsBtn.Click += new System.EventHandler(this.getProductsBtn_Click);
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(27, 62);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(335, 251);
            this.productList.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 338);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.getProductsBtn);
            this.Name = "Home";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getProductsBtn;
        private System.Windows.Forms.ListBox productList;
    }
}