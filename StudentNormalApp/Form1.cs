namespace StudentNormalApp
{
    public partial class formStudent : Form
    {
        private readonly StudentService _studentService;
        private string _uploadedFile;
        public formStudent()
        {
            _studentService = new StudentService();
            InitializeComponent();
            InitFormComponent();
            LoadCourse();
            LoadFormData();
        }

        private void LoadFormData()
        {
            var student = _studentService.Get(); // this line is used to get the data of student from the database or file.
                                                 // The Get() method of StudentService class is called which returns the Student object.
            if (student != null)
            {
                textBox1.Text = student.FirstName;
                textBox2.Text = student.LastName;
                if (student.Gender)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                cmbCourse.Text = student.Course;
                chkAgree.Checked = student.Agree;
                if (!String.IsNullOrEmpty(student.Profile) && File.Exists(student.Profile))
                {
                    txtImage.Text = Path.GetFileName(student.Profile);
                    pbStudent.Load(Path.Combine(_studentService._folderLocation, student.Profile));
                }
            }
        }

        private void LoadCourse()
        {
            var courses = _studentService.GetAllCourses();
            cmbCourse.Items.AddRange(courses);

            cmbCourse.SelectedIndex = 0;
        }

        private void InitFormComponent()
        {
            //txtFee.Text = "20,500";
            txtFee.Enabled = false;
            lblFirstNameError.ForeColor = Color.Red;
            lblLastNameError.ForeColor = Color.Red;
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
            lblCourseError.Visible = false;
            rbMale.Checked = true;
            lblCourseError.ForeColor = Color.Red;
            lblCourseError.Visible = false;
            lblAgreeError.ForeColor = Color.Red;
            lblAgreeError.Visible = false;
            pbStudent.BorderStyle = BorderStyle.Fixed3D;
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbStudent.Load(@"D:\Broadway\ferrari.jpg");
            txtImage.Enabled = false;
            txtFee.Text = StudentService._fee;

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
            string course = cmbCourse.Text;  // Get the selected course from the ComboBox
            bool agree = chkAgree.Checked;
            string ImagePath = txtImage.Text.Trim();




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
            if (!agree)
            {
                lblAgreeError.Visible = true;
            }
            else
            {
                lblAgreeError.Visible = false;
            }
            string imagePath = Path.Combine(_studentService._folderLocation, txtImage.Text); // this line is used to get the path of the image which is present in the folder location.

            if (!String.IsNullOrEmpty(firstName.Trim()) && !String.IsNullOrEmpty(lastName.Trim()) && cmbCourse.SelectedIndex > 0 && agree) // Check if all required fields are filled
            {
                StudentService studentService = new StudentService(); // Create an instance of StudentService
                Student student = new Student     // Create a new Student object, where the properties are set based on the form inputs.
                {
                    FirstName = firstName, // Assign the first name to the FirstName property
                    LastName = lastName,
                    Gender = gender,
                    Agree = agree,
                    Course = course,
                    Profile = imagePath
                };

                _studentService.Save(student);
                if (!String.IsNullOrEmpty(_uploadedFile))
                {
                    _studentService.SaveImage(_uploadedFile, imagePath);
                }
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
            rbMale.Checked = true;
            cmbCourse.SelectedIndex = 0;
            chkAgree.Checked = false;
            RemoveImage();
            _uploadedFile = "";
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

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex > 0)
            {
                lblCourseError.Visible = false;
            }
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked)
            {
                lblAgreeError.Visible = false;
            }
        }

        private void lblCourseError_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Images |*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Check if the user selected a file
            {
                // pbStudent.Load(openFileDialog.FileName); // Load the selected image into the PictureBox
                _uploadedFile = openFileDialog.FileName;
                pbStudent.Load(_uploadedFile);
                txtImage.Text = openFileDialog.SafeFileName;  // Set the file name in the TextBox
            }
        }



        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            RemoveImage();

        }
        private void RemoveImage()
        {
            pbStudent.Image = null;
            txtImage.Clear();
        }
    }
}

