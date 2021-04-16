namespace WindowsFormsApplication1
{
    partial class frmmessagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmessagebox));
            this.btnokay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldialog = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnokay
            // 
            this.btnokay.BackColor = System.Drawing.Color.Transparent;
            this.btnokay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnokay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnokay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnokay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnokay.ForeColor = System.Drawing.Color.Silver;
            this.btnokay.Location = new System.Drawing.Point(-4, 118);
            this.btnokay.Name = "btnokay";
            this.btnokay.Size = new System.Drawing.Size(287, 53);
            this.btnokay.TabIndex = 0;
            this.btnokay.Text = "OKAY";
            this.btnokay.UseVisualStyleBackColor = false;
            this.btnokay.Click += new System.EventHandler(this.btnokay_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbldialog);
            this.panel2.Location = new System.Drawing.Point(-7, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 93);
            this.panel2.TabIndex = 2;
            // 
            // lbldialog
            // 
            this.lbldialog.AutoSize = true;
            this.lbldialog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldialog.Location = new System.Drawing.Point(98, 39);
            this.lbldialog.Name = "lbldialog";
            this.lbldialog.Size = new System.Drawing.Size(47, 17);
            this.lbldialog.TabIndex = 0;
            this.lbldialog.Text = "label1";
            // 
            // frmmessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(283, 170);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnokay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmessagebox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbldialog;
        public System.Windows.Forms.Button btnokay;
    }
}