namespace StudentNormalApp
{
    partial class formStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLastName = new Label();
            textBox2 = new TextBox();
            lblFirstName = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            textBox3 = new TextBox();
            lblFullName = new Label();
            txtFee = new TextBox();
            lblFee = new Label();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            lblCourseError = new Label();
            chkAgree = new CheckBox();
            lblAgreeError = new Label();
            pbStudent = new PictureBox();
            btnUpload = new Button();
            btnRemove = new Button();
            txtImage = new TextBox();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(40, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(44, 29);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 25);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(122, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 128);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(44, 128);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name:";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(170, 178);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(150, 31);
            txtFee.TabIndex = 2;
            txtFee.TextChanged += txtFee_TextChanged;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(44, 184);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(43, 25);
            lblFee.TabIndex = 3;
            lblFee.Text = "Fee:";
            lblFee.Click += lblFee_Click;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Location = new Point(349, 26);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(189, 25);
            lblFirstNameError.TabIndex = 5;
            lblFirstNameError.Text = "First Name is Required";
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Location = new Point(349, 83);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(187, 25);
            lblLastNameError.TabIndex = 3;
            lblLastNameError.Text = "Last Name is Required";
            lblLastNameError.Click += lblLastNameError_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(44, 252);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 25);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender:";
            lblGender.Click += lblFee_Click;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(170, 248);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 6;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(264, 248);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(93, 29);
            rbFemale.TabIndex = 7;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(44, 309);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(71, 25);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course:";
            lblCourse.Click += lblFee_Click;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(170, 309);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(150, 33);
            cmbCourse.TabIndex = 8;
            cmbCourse.SelectedIndexChanged += cmbCourse_SelectedIndexChanged;
            // 
            // lblCourseError
            // 
            lblCourseError.AutoSize = true;
            lblCourseError.Location = new Point(349, 312);
            lblCourseError.Name = "lblCourseError";
            lblCourseError.Size = new Size(159, 25);
            lblCourseError.TabIndex = 9;
            lblCourseError.Text = "Course is Required";
            lblCourseError.Visible = false;
            lblCourseError.Click += lblCourseError_Click;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(170, 382);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(295, 29);
            chkAgree.TabIndex = 11;
            chkAgree.Text = "I agree the terms and conditions";
            chkAgree.UseVisualStyleBackColor = true;
            chkAgree.CheckedChanged += chkAgree_CheckedChanged;
            // 
            // lblAgreeError
            // 
            lblAgreeError.AutoSize = true;
            lblAgreeError.Location = new Point(204, 426);
            lblAgreeError.Name = "lblAgreeError";
            lblAgreeError.Size = new Size(304, 25);
            lblAgreeError.TabIndex = 9;
            lblAgreeError.Text = "Must agree the terms and conditions";
            // 
            // pbStudent
            // 
            pbStudent.Location = new Point(795, 33);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(205, 176);
            pbStudent.TabIndex = 12;
            pbStudent.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(795, 268);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(90, 34);
            btnUpload.TabIndex = 13;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(891, 268);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(99, 34);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(795, 231);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(150, 31);
            txtImage.TabIndex = 15;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // formStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 662);
            Controls.Add(txtImage);
            Controls.Add(btnRemove);
            Controls.Add(btnUpload);
            Controls.Add(pbStudent);
            Controls.Add(chkAgree);
            Controls.Add(lblAgreeError);
            Controls.Add(lblCourseError);
            Controls.Add(cmbCourse);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblFirstNameError);
            Controls.Add(lblFirstName);
            Controls.Add(textBox1);
            Controls.Add(lblCourse);
            Controls.Add(lblGender);
            Controls.Add(lblFee);
            Controls.Add(txtFee);
            Controls.Add(lblFullName);
            Controls.Add(textBox3);
            Controls.Add(lblLastNameError);
            Controls.Add(lblLastName);
            Controls.Add(textBox2);
            Name = "formStudent";
            Text = "Student Registration Form";
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //  private Label label2;
        private Label lblLastName;
        private TextBox textBox2;
        private Label lblFirstName;
        //private Label lblName;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox3;
        private Label lblFullName;
        private TextBox txtFee;
        private Label lblFee;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Label lblCourseError;
        private CheckBox chkAgree;
        private Label lblAgreeError;
        private PictureBox pbStudent;
        private Button btnUpload;
        private Button btnRemove;
        private TextBox txtImage;
        private OpenFileDialog openFileDialog;
    }
}
