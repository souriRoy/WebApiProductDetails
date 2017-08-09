namespace ProductCatalogue
{
    partial class delete_A_Product
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
            this.lbldlt = new System.Windows.Forms.Label();
            this.lbldlete = new System.Windows.Forms.Label();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldlt
            // 
            this.lbldlt.AutoSize = true;
            this.lbldlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldlt.Location = new System.Drawing.Point(1, 9);
            this.lbldlt.Name = "lbldlt";
            this.lbldlt.Size = new System.Drawing.Size(297, 15);
            this.lbldlt.TabIndex = 0;
            this.lbldlt.Text = "Please enter th Product Id you want to delete.";
            // 
            // lbldlete
            // 
            this.lbldlete.AutoSize = true;
            this.lbldlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldlete.Location = new System.Drawing.Point(12, 55);
            this.lbldlete.Name = "lbldlete";
            this.lbldlete.Size = new System.Drawing.Size(72, 15);
            this.lbldlete.TabIndex = 1;
            this.lbldlete.Text = "Product Id";
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(104, 50);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(201, 20);
            this.txtdelete.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(115, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Submit";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // delete_A_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 277);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.lbldlete);
            this.Controls.Add(this.lbldlt);
            this.Name = "delete_A_Product";
            this.Text = "delete_A_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldlt;
        private System.Windows.Forms.Label lbldlete;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.Button btnDelete;
    }
}