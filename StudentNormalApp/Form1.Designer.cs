namespace StudentNormalApp
{
    partial class Form1
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
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(44, 83);
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
            btnSave.Location = new Point(133, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(262, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 147);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(44, 147);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name:";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(170, 197);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(150, 31);
            txtFee.TabIndex = 2;
            txtFee.TextChanged += txtFee_TextChanged;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(44, 197);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(43, 25);
            lblFee.TabIndex = 3;
            lblFee.Text = "Fee:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblFirstName);
            Controls.Add(textBox1);
            Controls.Add(lblFee);
            Controls.Add(txtFee);
            Controls.Add(lblFullName);
            Controls.Add(textBox3);
            Controls.Add(lblLastName);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
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
    }
}
