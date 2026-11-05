namespace StudentNormalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitFormComponent();
        }

        private void InitFormComponent()
        {
            txtFee.Text = "20,500";
            txtFee.Enabled = false;
            lblFirstNameError.ForeColor = Color.Red;
            lblLastNameError.ForeColor = Color.Red;
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
            rbMale.Checked = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                lblFirstNameError.Visible = false;
            }
            SetFullName();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                lblLastNameError.Visible = false;
            }
            SetFullName();
        }

        private void SetFullName()
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string fullName = $"{firstName} {lastName}";
            textBox3.Text = fullName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Student information saved successfully! " + textBox3.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Save();

        }

        private void Save()
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            bool gender = rbMale.Checked;
            string course = cmbCourse.Text;





            if (String.IsNullOrEmpty(firstName.Trim()))
            {
                lblFirstNameError.Visible = true;
            }
            else
            {
                lblFirstNameError.Visible = false;
            }

            if (String.IsNullOrEmpty(lastName.Trim()))
            {
                lblLastNameError.Visible = true;
            }
            else
            {
                lblLastNameError.Visible = false;
            }
            if (cmbCourse.SelectedIndex == 0)
            {
                lblCourseError.Visible = true;
            }
            else
            {
                lblCourseError.Visible = false;
            }

            if (!String.IsNullOrEmpty(firstName.Trim()) && !String.IsNullOrEmpty(lastName.Trim()) && cmbCourse.SelectedIndex > 0)
            {
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
        }

        private void lblLastNameError_Click(object sender, EventArgs e)
        {

        }

        private void lblFee_Click(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

