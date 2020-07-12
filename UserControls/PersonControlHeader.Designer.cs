namespace ItemsListViewTestApp.UserControls
{
    partial class PersonControlHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonName = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonName
            // 
            this.PersonName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PersonName.AutoSize = true;
            this.PersonName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonName.Location = new System.Drawing.Point(272, 5);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(64, 24);
            this.PersonName.TabIndex = 2;
            this.PersonName.Text = "Name";
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(36, 5);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(60, 24);
            this.CNIC.TabIndex = 3;
            this.CNIC.Text = "CNIC";
            // 
            // PersonControlHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.PersonName);
            this.Name = "PersonControlHeader";
            this.Size = new System.Drawing.Size(737, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.Label CNIC;
    }
}
