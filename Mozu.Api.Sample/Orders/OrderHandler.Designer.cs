namespace Mozu.Api.Sample.OrderHandler
{
    partial class Orders
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
            this.getOrdersBtn = new System.Windows.Forms.Button();
            this.ordersList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getOrdersBtn
            // 
            this.getOrdersBtn.Location = new System.Drawing.Point(37, 22);
            this.getOrdersBtn.Name = "getOrdersBtn";
            this.getOrdersBtn.Size = new System.Drawing.Size(141, 29);
            this.getOrdersBtn.TabIndex = 0;
            this.getOrdersBtn.Text = "Get Orders";
            this.getOrdersBtn.UseVisualStyleBackColor = true;
            this.getOrdersBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordersList
            // 
            this.ordersList.FormattingEnabled = true;
            this.ordersList.Location = new System.Drawing.Point(37, 68);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(462, 212);
            this.ordersList.TabIndex = 1;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 307);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.getOrdersBtn);
            this.Name = "Orders";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getOrdersBtn;
        private System.Windows.Forms.ListBox ordersList;
    }
}