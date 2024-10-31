namespace StudentInfo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDegreePursued = new System.Windows.Forms.TextBox();
            this.txtCellPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCensusId = new System.Windows.Forms.TextBox();
            this.studentInfoGroup = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoGroup)).BeginInit();
            this.studentInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(5, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(5, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtDegreePursued
            // 
            this.txtDegreePursued.Location = new System.Drawing.Point(5, 277);
            this.txtDegreePursued.Name = "txtDegreePursued";
            this.txtDegreePursued.Size = new System.Drawing.Size(100, 23);
            this.txtDegreePursued.TabIndex = 4;
            // 
            // txtCellPhoneNumber
            // 
            this.txtCellPhoneNumber.Location = new System.Drawing.Point(5, 218);
            this.txtCellPhoneNumber.Name = "txtCellPhoneNumber";
            this.txtCellPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCellPhoneNumber.TabIndex = 5;
            // 
            // txtCensusId
            // 
            this.txtCensusId.Location = new System.Drawing.Point(5, 159);
            this.txtCensusId.Name = "txtCensusId";
            this.txtCensusId.Size = new System.Drawing.Size(100, 23);
            this.txtCensusId.TabIndex = 6;
            // 
            // studentInfoGroup
            // 
            this.studentInfoGroup.Controls.Add(this.btnDeleteStudent);
            this.studentInfoGroup.Controls.Add(this.btnAddStudent);
            this.studentInfoGroup.Controls.Add(this.label5);
            this.studentInfoGroup.Controls.Add(this.label4);
            this.studentInfoGroup.Controls.Add(this.label3);
            this.studentInfoGroup.Controls.Add(this.label2);
            this.studentInfoGroup.Controls.Add(this.label1);
            this.studentInfoGroup.Controls.Add(this.txtFirstName);
            this.studentInfoGroup.Controls.Add(this.txtDegreePursued);
            this.studentInfoGroup.Controls.Add(this.txtCellPhoneNumber);
            this.studentInfoGroup.Controls.Add(this.txtCensusId);
            this.studentInfoGroup.Controls.Add(this.txtLastName);
            this.studentInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.studentInfoGroup.Name = "studentInfoGroup";
            this.studentInfoGroup.Size = new System.Drawing.Size(360, 314);
            this.studentInfoGroup.TabIndex = 7;
            this.studentInfoGroup.Text = "Student Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Census Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(280, 251);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(280, 286);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 13;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 551);
            this.Controls.Add(this.studentInfoGroup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Student Edit Tab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoGroup)).EndInit();
            this.studentInfoGroup.ResumeLayout(false);
            this.studentInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDegreePursued;
        private System.Windows.Forms.TextBox txtCellPhoneNumber;
        private System.Windows.Forms.TextBox txtCensusId;
        private DevExpress.XtraEditors.GroupControl studentInfoGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
    }
}

