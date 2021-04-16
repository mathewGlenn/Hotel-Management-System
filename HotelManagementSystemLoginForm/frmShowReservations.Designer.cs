namespace WindowsFormsApplication1
{
    partial class frmShowReservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowReservations));
            this.dataGridReservation = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbperson = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblrate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtroomid = new System.Windows.Forms.TextBox();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtroomdescript = new System.Windows.Forms.TextBox();
            this.txtepp = new System.Windows.Forms.TextBox();
            this.txtrpd = new System.Windows.Forms.TextBox();
            this.txtrph = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtvehicle = new System.Windows.Forms.TextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtorhour = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.ptype = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReservation
            // 
            this.dataGridReservation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservation.EnableHeadersVisualStyles = false;
            this.dataGridReservation.Location = new System.Drawing.Point(30, 119);
            this.dataGridReservation.Name = "dataGridReservation";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridReservation.RowHeadersVisible = false;
            this.dataGridReservation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservation.Size = new System.Drawing.Size(690, 310);
            this.dataGridReservation.TabIndex = 0;
            this.dataGridReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservation_CellClick);
            this.dataGridReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservation_CellContentClick);
            this.dataGridReservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservation_CellDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(344, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(410, 85);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 28);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(792, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 17);
            this.label20.TabIndex = 74;
            this.label20.Text = "Guest  Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(787, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Checkin Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(776, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Checkout Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(786, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Checkin Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(760, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "No. of Extra Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(832, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(902, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 83;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button11.Location = new System.Drawing.Point(864, 448);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 93;
            this.button11.Text = "Checkin";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(1026, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 94;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(945, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 95;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(905, 69);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(200, 20);
            this.txtguestname.TabIndex = 96;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmbperson
            // 
            this.cmbperson.FormattingEnabled = true;
            this.cmbperson.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbperson.Location = new System.Drawing.Point(904, 124);
            this.cmbperson.Name = "cmbperson";
            this.cmbperson.Size = new System.Drawing.Size(73, 21);
            this.cmbperson.TabIndex = 108;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(903, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker2.TabIndex = 110;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(903, 181);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker3.TabIndex = 111;
            this.dateTimePicker3.FormatChanged += new System.EventHandler(this.dateTimePicker3_FormatChanged);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dateTimePicker3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker3_KeyPress);
            this.dateTimePicker3.MouseCaptureChanged += new System.EventHandler(this.dateTimePicker3_MouseCaptureChanged);
            this.dateTimePicker3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker3_MouseDown);
            // 
            // lblrate
            // 
            this.lblrate.BackColor = System.Drawing.Color.White;
            this.lblrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblrate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblrate.Location = new System.Drawing.Point(903, 213);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(199, 31);
            this.lblrate.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(898, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 114;
            // 
            // txtroomid
            // 
            this.txtroomid.Location = new System.Drawing.Point(70, 67);
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.Size = new System.Drawing.Size(234, 20);
            this.txtroomid.TabIndex = 115;
            this.txtroomid.Visible = false;
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Reservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(901, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 117;
            // 
            // txtroomdescript
            // 
            this.txtroomdescript.Location = new System.Drawing.Point(50, 67);
            this.txtroomdescript.Name = "txtroomdescript";
            this.txtroomdescript.Size = new System.Drawing.Size(14, 20);
            this.txtroomdescript.TabIndex = 118;
            this.txtroomdescript.Visible = false;
            // 
            // txtepp
            // 
            this.txtepp.Location = new System.Drawing.Point(10, 67);
            this.txtepp.Name = "txtepp";
            this.txtepp.Size = new System.Drawing.Size(14, 20);
            this.txtepp.TabIndex = 119;
            this.txtepp.Visible = false;
            // 
            // txtrpd
            // 
            this.txtrpd.Location = new System.Drawing.Point(50, 41);
            this.txtrpd.Name = "txtrpd";
            this.txtrpd.Size = new System.Drawing.Size(14, 20);
            this.txtrpd.TabIndex = 120;
            this.txtrpd.Visible = false;
            // 
            // txtrph
            // 
            this.txtrph.Location = new System.Drawing.Point(30, 41);
            this.txtrph.Name = "txtrph";
            this.txtrph.Size = new System.Drawing.Size(14, 20);
            this.txtrph.TabIndex = 121;
            this.txtrph.Visible = false;
            // 
            // lblbalance
            // 
            this.lblbalance.BackColor = System.Drawing.Color.White;
            this.lblbalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblbalance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblbalance.Location = new System.Drawing.Point(903, 270);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(199, 31);
            this.lblbalance.TabIndex = 122;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(816, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 123;
            this.label12.Text = "Balance";
            // 
            // txtvehicle
            // 
            this.txtvehicle.Location = new System.Drawing.Point(902, 308);
            this.txtvehicle.Multiline = true;
            this.txtvehicle.Name = "txtvehicle";
            this.txtvehicle.Size = new System.Drawing.Size(200, 68);
            this.txtvehicle.TabIndex = 124;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editToolStripMenuItem.Text = "Edit Reservation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(795, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 125;
            this.label11.Text = "Vehicle Info";
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // txtorhour
            // 
            this.txtorhour.Location = new System.Drawing.Point(30, 67);
            this.txtorhour.Name = "txtorhour";
            this.txtorhour.Size = new System.Drawing.Size(14, 20);
            this.txtorhour.TabIndex = 126;
            this.txtorhour.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 34);
            this.panel4.TabIndex = 127;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(1099, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 26);
            this.button2.TabIndex = 128;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(303, -14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 0);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(203, -14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(0, 0);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(104, -14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(0, 0);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(4, -14);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(0, 0);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Location = new System.Drawing.Point(1, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 42);
            this.panel1.TabIndex = 128;
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button12.Location = new System.Drawing.Point(303, -14);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(0, 0);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button13.Location = new System.Drawing.Point(203, -14);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(0, 0);
            this.button13.TabIndex = 6;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button14.Location = new System.Drawing.Point(104, -14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(0, 0);
            this.button14.TabIndex = 6;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(4, -14);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(0, 0);
            this.button15.TabIndex = 0;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Location = new System.Drawing.Point(903, 98);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(200, 20);
            this.txtroomtype.TabIndex = 130;
            // 
            // ptype
            // 
            this.ptype.AutoSize = true;
            this.ptype.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ptype.Location = new System.Drawing.Point(905, 253);
            this.ptype.Name = "ptype";
            this.ptype.Size = new System.Drawing.Size(35, 17);
            this.ptype.TabIndex = 131;
            this.ptype.Text = "type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(786, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 132;
            this.label10.Text = "Payment Type";
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(323, 67);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(234, 20);
            this.txtcusid.TabIndex = 133;
            this.txtcusid.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(902, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 42);
            this.label14.TabIndex = 156;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(807, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 155;
            this.label16.Text = "Additional";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(983, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 22);
            this.dateTimePicker1.TabIndex = 157;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(983, 151);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(78, 22);
            this.dateTimePicker4.TabIndex = 158;
            // 
            // frmShowReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 595);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.dataGridReservation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ptype);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtorhour);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtvehicle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.txtrph);
            this.Controls.Add(this.txtrpd);
            this.Controls.Add(this.txtepp);
            this.Controls.Add(this.txtroomdescript);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtroomid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.cmbperson);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.Activated += new System.EventHandler(this.frmShowReservations_Activated);
            this.Load += new System.EventHandler(this.frmShowReservations_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmShowReservations_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShowReservations_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridReservation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbperson;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtroomid;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtroomdescript;
        private System.Windows.Forms.TextBox txtepp;
        private System.Windows.Forms.TextBox txtrpd;
        private System.Windows.Forms.TextBox txtrph;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtvehicle;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtorhour;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.Label ptype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;


    }
}