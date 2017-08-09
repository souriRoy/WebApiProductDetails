namespace ProductCatalogue
{
    partial class ProductPage
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
            this.labelProduct = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(63, 9);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(158, 20);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Product Catalogue";
            this.labelProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Location = new System.Drawing.Point(24, 39);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(131, 13);
            this.Action.TabIndex = 1;
            this.Action.Text = "Please Choose an action .";
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(27, 67);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(235, 40);
            this.btnview.TabIndex = 2;
            this.btnview.Text = "View Products";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add a Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(27, 154);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(235, 40);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update a Product";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete a Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.labelProduct);
            this.Name = "ProductPage";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnDelete;
    }
}