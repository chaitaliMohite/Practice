namespace demo
{
    partial class mainform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnget = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnins = new System.Windows.Forms.Button();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmob);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Logout);
            this.groupBox1.Controls.Add(this.btnget);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupd);
            this.groupBox1.Controls.Add(this.btnins);
            this.groupBox1.Controls.Add(this.txtsal);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtename);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnget
            // 
            this.btnget.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnget.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnget.FlatAppearance.BorderSize = 0;
            this.btnget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnget.Location = new System.Drawing.Point(671, 198);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(132, 38);
            this.btnget.TabIndex = 13;
            this.btnget.Text = "GetData";
            this.btnget.UseVisualStyleBackColor = false;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.Location = new System.Drawing.Point(519, 199);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(132, 36);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupd
            // 
            this.btnupd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupd.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnupd.FlatAppearance.BorderSize = 0;
            this.btnupd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupd.Location = new System.Drawing.Point(364, 199);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(132, 37);
            this.btnupd.TabIndex = 11;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = false;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btnins
            // 
            this.btnins.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnins.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnins.FlatAppearance.BorderSize = 0;
            this.btnins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnins.Location = new System.Drawing.Point(207, 199);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(132, 39);
            this.btnins.TabIndex = 10;
            this.btnins.Text = "Insert";
            this.btnins.UseVisualStyleBackColor = false;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(740, 21);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(236, 34);
            this.txtsal.TabIndex = 9;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(334, 146);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 34);
            this.txtage.TabIndex = 8;
            // 
            // txtename
            // 
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.Location = new System.Drawing.Point(334, 81);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(241, 34);
            this.txtename.TabIndex = 7;
            this.txtename.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(334, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(241, 34);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(930, 209);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(93, 29);
            this.Logout.TabIndex = 14;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(740, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(236, 34);
            this.txtemail.TabIndex = 16;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtmob
            // 
            this.txtmob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmob.Location = new System.Drawing.Point(740, 149);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(236, 34);
            this.txtmob.TabIndex = 18;
            this.txtmob.TextChanged += new System.EventHandler(this.txtmob_TextChanged);
            this.txtmob.Leave += new System.EventHandler(this.txtmob_Leave);
            this.txtmob.Validated += new System.EventHandler(this.txtmob_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mobile";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1097, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
    }
}