namespace ItemsListViewTestApp.UserControls
{
    partial class PersonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonControl));
            this.CNIC = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.SelectionIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(36, 5);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(60, 24);
            this.CNIC.TabIndex = 0;
            this.CNIC.Text = "CNIC";
            // 
            // PersonName
            // 
            this.PersonName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PersonName.AutoSize = true;
            this.PersonName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonName.Location = new System.Drawing.Point(272, 3);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(64, 24);
            this.PersonName.TabIndex = 1;
            this.PersonName.Text = "Name";
            // 
            // SelectionIndicator
            // 
            this.SelectionIndicator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectionIndicator.Image = ((System.Drawing.Image)(resources.GetObject("SelectionIndicator.Image")));
            this.SelectionIndicator.Location = new System.Drawing.Point(4, 5);
            this.SelectionIndicator.Name = "SelectionIndicator";
            this.SelectionIndicator.Size = new System.Drawing.Size(25, 25);
            this.SelectionIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectionIndicator.TabIndex = 2;
            this.SelectionIndicator.TabStop = false;
            this.SelectionIndicator.Visible = false;
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SelectionIndicator);
            this.Controls.Add(this.PersonName);
            this.Controls.Add(this.CNIC);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(737, 33);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CNIC;
        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.PictureBox SelectionIndicator;
    }
}
