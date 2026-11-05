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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetFullName();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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
            ResetControls();
        }

        private void Save()
        {
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();

            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First name and last name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // call database()
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}

