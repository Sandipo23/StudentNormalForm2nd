namespace StudentNormalApp
{
    public partial class formStudent : Form
    {
        private readonly StudentService _studentService;
        private string _uploadedFile; // this variable is used to store the path of the uploaded image file.
        public formStudent()
        {
            _studentService = new StudentService();
            InitializeComponent();
            InitFormComponent();
            LoadCourse();
            
            LoadStudentsGrid();
        }
        private void LoadStudentsGrid()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.FirstName),
                HeaderText = "First Name",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.FirstName)
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.LastName),
                HeaderText = "Last Name",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.LastName)
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Gender),
                HeaderText = "Gender",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.Gender)
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Agree),
                HeaderText = "Agree",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.Agree)
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Course),
                HeaderText = "Course",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.Course)
            });
            dgvStudents.Columns.Add(new DataGridViewColumn
            {
                Name = nameof(StudentRead.Profile),
                HeaderText = "Profile",
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = nameof(StudentRead.Profile)
            });
            LoadStudents();
        }

        private void LoadStudents() // this method is used to load all the data of student from database or file and
                                    // display it in the DataGridView.
        {
            var students = _studentService.GetAll();
            if (students.Count > 0)
            {
                dgvStudents.DataSource = students;
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
            string imagePath = String.IsNullOrEmpty(txtImage.Text) ? null : Path.Combine(_studentService._folderLocation, txtImage.Text); // this is ternary operator which is used to check if the
                                                                                                                                          // txtImage.Text is null or empty then it will assign null to
                                                                                                                                          // imagePath otherwise it will assign the path of the image to imagePath.

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
                if (!String.IsNullOrEmpty(_uploadedFile) && !String.IsNullOrEmpty(txtImage.Text)) // Check if an image file was uploaded and the image path is not empty
                {
                    _studentService.SaveImage(_uploadedFile, imagePath); // Save the uploaded image to the specified destination path
                }
                LoadStudents(); // Refresh the DataGridView to display the newly added student
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

        private void txtImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

