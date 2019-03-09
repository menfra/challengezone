namespace WindowsFormsApp2
{
    partial class frmUserRegistration
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
            this.grbUserDetail = new System.Windows.Forms.GroupBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.grbUserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserDetail
            // 
            this.grbUserDetail.Controls.Add(this.txtAddress2);
            this.grbUserDetail.Controls.Add(this.txtCountry);
            this.grbUserDetail.Controls.Add(this.txtState);
            this.grbUserDetail.Controls.Add(this.txtCity);
            this.grbUserDetail.Controls.Add(this.txtAddress1);
            this.grbUserDetail.Controls.Add(this.txtLName);
            this.grbUserDetail.Controls.Add(this.txtMname);
            this.grbUserDetail.Controls.Add(this.txtFName);
            this.grbUserDetail.Controls.Add(this.btnClear);
            this.grbUserDetail.Controls.Add(this.btnOk);
            this.grbUserDetail.Controls.Add(this.label7);
            this.grbUserDetail.Controls.Add(this.label6);
            this.grbUserDetail.Controls.Add(this.label5);
            this.grbUserDetail.Controls.Add(this.label4);
            this.grbUserDetail.Controls.Add(this.label3);
            this.grbUserDetail.Controls.Add(this.label2);
            this.grbUserDetail.Controls.Add(this.label1);
            this.grbUserDetail.Location = new System.Drawing.Point(21, 23);
            this.grbUserDetail.Name = "grbUserDetail";
            this.grbUserDetail.Size = new System.Drawing.Size(425, 359);
            this.grbUserDetail.TabIndex = 0;
            this.grbUserDetail.TabStop = false;
            this.grbUserDetail.Text = "User details";
            this.grbUserDetail.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(119, 145);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(160, 20);
            this.txtAddress2.TabIndex = 14;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(119, 235);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(160, 20);
            this.txtCountry.TabIndex = 17;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(119, 204);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(160, 20);
            this.txtState.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(119, 173);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 20);
            this.txtCity.TabIndex = 15;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(119, 118);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(160, 20);
            this.txtAddress1.TabIndex = 13;
            this.txtAddress1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(119, 91);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(160, 20);
            this.txtLName.TabIndex = 12;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(119, 64);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(160, 20);
            this.txtMname.TabIndex = 11;
            this.txtMname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(119, 35);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 20);
            this.txtFName.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(110, 283);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTimer.Location = new System.Drawing.Point(494, 58);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(213, 44);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.Text = "00.00.00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timTimer
            // 
            this.timTimer.Enabled = true;
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // frmUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 507);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.grbUserDetail);
            this.Name = "frmUserRegistration";
            this.Text = "User Registration";
            this.grbUserDetail.ResumeLayout(false);
            this.grbUserDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserDetail;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Timer timTimer;
    }
}

