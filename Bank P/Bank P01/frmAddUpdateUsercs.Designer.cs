namespace Bank_P01
{
    partial class frmAddUpdateUsercs
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUserMode = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMangeUser = new System.Windows.Forms.CheckBox();
            this.chbTrancations = new System.Windows.Forms.CheckBox();
            this.chbUpdateClient = new System.Windows.Forms.CheckBox();
            this.chbDeleteClient = new System.Windows.Forms.CheckBox();
            this.chbAddClient = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.tbPermiossion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Bell MT", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(266, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 24);
            this.lblUserID.TabIndex = 41;
            this.lblUserID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(176, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "UserID";
            // 
            // lblUserMode
            // 
            this.lblUserMode.AutoSize = true;
            this.lblUserMode.Font = new System.Drawing.Font("Bell MT", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblUserMode.ForeColor = System.Drawing.Color.Black;
            this.lblUserMode.Location = new System.Drawing.Point(376, 20);
            this.lblUserMode.Name = "lblUserMode";
            this.lblUserMode.Size = new System.Drawing.Size(104, 24);
            this.lblUserMode.TabIndex = 39;
            this.lblUserMode.Text = "First Name";
            this.lblUserMode.Click += new System.EventHandler(this.lblUserMode_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(600, 370);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(122, 44);
            this.btnsave.TabIndex = 38;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(430, 370);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(122, 44);
            this.btnclose.TabIndex = 37;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(130, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Permiossion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "PassWord";
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(430, 97);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(207, 29);
            this.tbpassword.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(120, 97);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(207, 29);
            this.tbusername.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbMangeUser);
            this.groupBox1.Controls.Add(this.chbTrancations);
            this.groupBox1.Controls.Add(this.chbUpdateClient);
            this.groupBox1.Controls.Add(this.chbDeleteClient);
            this.groupBox1.Controls.Add(this.chbAddClient);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(120, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 151);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // chbMangeUser
            // 
            this.chbMangeUser.AutoSize = true;
            this.chbMangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMangeUser.Location = new System.Drawing.Point(375, 80);
            this.chbMangeUser.Name = "chbMangeUser";
            this.chbMangeUser.Size = new System.Drawing.Size(115, 24);
            this.chbMangeUser.TabIndex = 5;
            this.chbMangeUser.Tag = "16";
            this.chbMangeUser.Text = "Mange User";
            this.chbMangeUser.UseVisualStyleBackColor = true;
            // 
            // chbTrancations
            // 
            this.chbTrancations.AutoSize = true;
            this.chbTrancations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTrancations.Location = new System.Drawing.Point(206, 80);
            this.chbTrancations.Name = "chbTrancations";
            this.chbTrancations.Size = new System.Drawing.Size(103, 24);
            this.chbTrancations.TabIndex = 4;
            this.chbTrancations.Tag = "8";
            this.chbTrancations.Text = "Trancation";
            this.chbTrancations.UseVisualStyleBackColor = true;
            // 
            // chbUpdateClient
            // 
            this.chbUpdateClient.AutoSize = true;
            this.chbUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpdateClient.Location = new System.Drawing.Point(30, 80);
            this.chbUpdateClient.Name = "chbUpdateClient";
            this.chbUpdateClient.Size = new System.Drawing.Size(125, 24);
            this.chbUpdateClient.TabIndex = 3;
            this.chbUpdateClient.Tag = "4";
            this.chbUpdateClient.Text = "Update Client";
            this.chbUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chbDeleteClient
            // 
            this.chbDeleteClient.AutoSize = true;
            this.chbDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDeleteClient.Location = new System.Drawing.Point(375, 19);
            this.chbDeleteClient.Name = "chbDeleteClient";
            this.chbDeleteClient.Size = new System.Drawing.Size(119, 24);
            this.chbDeleteClient.TabIndex = 2;
            this.chbDeleteClient.Tag = "2";
            this.chbDeleteClient.Text = "Delete Client";
            this.chbDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chbAddClient
            // 
            this.chbAddClient.AutoSize = true;
            this.chbAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAddClient.Location = new System.Drawing.Point(30, 19);
            this.chbAddClient.Name = "chbAddClient";
            this.chbAddClient.Size = new System.Drawing.Size(97, 24);
            this.chbAddClient.TabIndex = 1;
            this.chbAddClient.Tag = "1";
            this.chbAddClient.Text = "AddClient";
            this.chbAddClient.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSelect);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Location = new System.Drawing.Point(224, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 44);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelect.Location = new System.Drawing.Point(243, 14);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(72, 24);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            this.rbSelect.CheckedChanged += new System.EventHandler(this.rbSelect_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(69, 14);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 24);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // tbPermiossion
            // 
            this.tbPermiossion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPermiossion.Location = new System.Drawing.Point(134, 370);
            this.tbPermiossion.Multiline = true;
            this.tbPermiossion.Name = "tbPermiossion";
            this.tbPermiossion.Size = new System.Drawing.Size(207, 29);
            this.tbPermiossion.TabIndex = 33;
            this.tbPermiossion.TextChanged += new System.EventHandler(this.tbPermiossion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Permiossion";
            // 
            // frmAddUpdateUsercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserMode);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPermiossion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusername);
            this.Name = "frmAddUpdateUsercs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "     *";
            this.Load += new System.EventHandler(this.frmAddUpdateUsercs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUserMode;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbMangeUser;
        private System.Windows.Forms.CheckBox chbTrancations;
        private System.Windows.Forms.CheckBox chbUpdateClient;
        private System.Windows.Forms.CheckBox chbDeleteClient;
        private System.Windows.Forms.CheckBox chbAddClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.TextBox tbPermiossion;
        private System.Windows.Forms.Label label3;
    }
}