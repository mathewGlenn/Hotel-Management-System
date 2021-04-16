namespace WindowsFormsApplication1
{
    partial class frmmessagebox1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmessagebox1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldialog = new System.Windows.Forms.Label();
            this.btnokay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbldialog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 130);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbldialog
            // 
            this.lbldialog.AutoSize = true;
            this.lbldialog.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldialog.Location = new System.Drawing.Point(3, 31);
            this.lbldialog.Name = "lbldialog";
            this.lbldialog.Size = new System.Drawing.Size(84, 27);
            this.lbldialog.TabIndex = 0;
            this.lbldialog.Text = "label1";
            this.lbldialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnokay
            // 
            this.btnokay.BackColor = System.Drawing.Color.Transparent;
            this.btnokay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnokay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnokay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnokay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnokay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnokay.ForeColor = System.Drawing.Color.Silver;
            this.btnokay.Location = new System.Drawing.Point(0, 148);
            this.btnokay.Name = "btnokay";
            this.btnokay.Size = new System.Drawing.Size(377, 33);
            this.btnokay.TabIndex = 3;
            this.btnokay.Text = "OKAY";
            this.btnokay.UseVisualStyleBackColor = false;
            this.btnokay.Click += new System.EventHandler(this.btnokay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmmessagebox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 181);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnokay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmessagebox1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmessagebox1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbldialog;
        public System.Windows.Forms.Button btnokay;
        public System.Windows.Forms.Label label1;
    }
}