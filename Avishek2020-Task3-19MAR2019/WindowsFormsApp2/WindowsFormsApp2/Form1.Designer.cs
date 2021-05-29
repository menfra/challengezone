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
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.DateDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
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
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUserDetail
            // 
            this.grbUserDetail.Controls.Add(this.btnQuery);
            this.grbUserDetail.Controls.Add(this.txtId);
            this.grbUserDetail.Controls.Add(this.btnDelete);
            this.grbUserDetail.Controls.Add(this.btnUpdate);
            this.grbUserDetail.Controls.Add(this.btnInsert);
            this.grbUserDetail.Controls.Add(this.DateDOB);
            this.grbUserDetail.Controls.Add(this.label8);
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
            this.grbUserDetail.Size = new System.Drawing.Size(425, 372);
            this.grbUserDetail.TabIndex = 0;
            this.grbUserDetail.TabStop = false;
            this.grbUserDetail.Text = "User details";
            this.grbUserDetail.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(332, 105);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 24);
            this.btnQuery.TabIndex = 26;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Visible = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(159, 20);
            this.txtId.TabIndex = 25;
            this.txtId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(332, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(332, 153);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // DateDOB
            // 
            this.DateDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateDOB.CustomFormat = "yyyy/MM/dd";
            this.DateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDOB.Location = new System.Drawing.Point(119, 184);
            this.DateDOB.Name = "DateDOB";
            this.DateDOB.Size = new System.Drawing.Size(160, 20);
            this.DateDOB.TabIndex = 15;
            this.DateDOB.Value = new System.DateTime(2019, 3, 19, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date of Birth";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(119, 157);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(160, 20);
            this.txtAddress2.TabIndex = 14;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(119, 272);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(160, 20);
            this.txtCountry.TabIndex = 18;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(119, 244);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(160, 20);
            this.txtState.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(119, 214);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 20);
            this.txtCity.TabIndex = 16;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(119, 130);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(160, 20);
            this.txtAddress1.TabIndex = 13;
            this.txtAddress1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(119, 103);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(160, 20);
            this.txtLName.TabIndex = 12;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(119, 76);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(160, 20);
            this.txtMname.TabIndex = 11;
            this.txtMname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(119, 47);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 20);
            this.txtFName.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(110, 305);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // timTimer
            // 
            this.timTimer.Enabled = true;
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTimer.Location = new System.Drawing.Point(494, 26);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(208, 44);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.Text = "00.00.00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 296);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 704);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.grbUserDetail);
            this.Name = "frmUserRegistration";
            this.Text = "User Registration";
            this.grbUserDetail.ResumeLayout(false);
            this.grbUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.DateTimePicker DateDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

