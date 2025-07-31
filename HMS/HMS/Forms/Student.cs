using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using HMS.Data;
using HMS.Models;

namespace HMS.Forms
{
    internal class Student : Form
    {
        private Dashboard parentDashboard;
        private Label studentid;
        private Label studentname;
        private Label dob;
        private TextBox stnbtn;
        private TextBox namebtn;
        private DateTimePicker dobbtn;
        private Button stninsert;
        private Button stndelete;
        private Button stnmodify;
        private TextBox roombtn;
        private Label room;
        private Label stntitle;
        private Button stnback;
        private Button stnsearchbtn;
        private TextBox stnsearchbar;
        private DataGridView stnsearch;

        private StudentRepository _studentRepository;

        public Student(Dashboard dashboard)
        {
            parentDashboard = dashboard;
            _studentRepository = new StudentRepository();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.img1; // Make sure you have img1 in resources
            this.ClientSize = new Size(1350, 624);
            this.Text = "Student Information - HMS";
            this.Load += studentinfo_Load;

            // studentid Label
            studentid = new Label();
            studentid.AutoSize = true;
            studentid.BackColor = Color.DarkGreen;
            studentid.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            studentid.ForeColor = SystemColors.ButtonHighlight;
            studentid.Location = new Point(153, 126);
            studentid.Size = new Size(191, 42);
            studentid.TabIndex = 0;
            studentid.Text = "Student ID";
            this.Controls.Add(studentid);

            // studentname Label
            studentname = new Label();
            studentname.AutoSize = true;
            studentname.BackColor = Color.DarkGreen;
            studentname.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            studentname.ForeColor = SystemColors.ButtonHighlight;
            studentname.Location = new Point(153, 206);
            studentname.Size = new Size(113, 42);
            studentname.TabIndex = 1;
            studentname.Text = "Name";
            this.Controls.Add(studentname);

            // dob Label
            dob = new Label();
            dob.AutoSize = true;
            dob.BackColor = Color.DarkGreen;
            dob.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            dob.ForeColor = SystemColors.ButtonHighlight;
            dob.Location = new Point(153, 285);
            dob.Size = new Size(231, 42);
            dob.TabIndex = 2;
            dob.Text = "Date Of Birth";
            dob.Click += label3_Click;
            this.Controls.Add(dob);

            // stnbtn TextBox (Student ID)
            stnbtn = new TextBox();
            stnbtn.Location = new Point(452, 141);
            stnbtn.Size = new Size(274, 26);
            stnbtn.TabIndex = 4;
            stnbtn.ReadOnly = true;
            stnbtn.BackColor = Color.LightGray;
            this.Controls.Add(stnbtn);

            // namebtn TextBox
            namebtn = new TextBox();
            namebtn.Location = new Point(452, 228);
            namebtn.Size = new Size(274, 26);
            namebtn.TabIndex = 5;
            this.Controls.Add(namebtn);

            // dobbtn DateTimePicker
            dobbtn = new DateTimePicker();
            dobbtn.Font = new Font("Microsoft Sans Serif", 10F);
            dobbtn.Location = new Point(452, 305);
            dobbtn.Size = new Size(274, 30);
            dobbtn.TabIndex = 10;
            this.Controls.Add(dobbtn);

            // stninsert Button
            stninsert = new Button();
            stninsert.BackColor = Color.FromArgb(192, 192, 0); // Olive
            stninsert.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stninsert.ForeColor = SystemColors.ButtonHighlight;
            stninsert.Location = new Point(818, 133);
            stninsert.Size = new Size(122, 42);
            stninsert.TabIndex = 11;
            stninsert.Text = "Insert";
            stninsert.UseVisualStyleBackColor = false;
            stninsert.Click += stninsert_Click;
            this.Controls.Add(stninsert);

            // stndelete Button
            stndelete = new Button();
            stndelete.BackColor = Color.Red;
            stndelete.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stndelete.ForeColor = SystemColors.ButtonHighlight;
            stndelete.Location = new Point(818, 213);
            stndelete.Size = new Size(122, 42);
            stndelete.TabIndex = 12;
            stndelete.Text = "Delete";
            stndelete.UseVisualStyleBackColor = false;
            stndelete.Click += stndelete_Click;
            this.Controls.Add(stndelete);

            // stnmodify Button
            stnmodify = new Button();
            stnmodify.BackColor = Color.Blue;
            stnmodify.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stnmodify.ForeColor = SystemColors.ButtonHighlight;
            stnmodify.Location = new Point(818, 290);
            stnmodify.Size = new Size(122, 47);
            stnmodify.TabIndex = 13;
            stnmodify.Text = "Modify";
            stnmodify.UseVisualStyleBackColor = false;
            stnmodify.Click += stnmodify_Click;
            this.Controls.Add(stnmodify);

            // roombtn TextBox
            roombtn = new TextBox();
            roombtn.Location = new Point(452, 383);
            roombtn.Size = new Size(274, 26);
            roombtn.TabIndex = 14;
            this.Controls.Add(roombtn);

            // room Label
            room = new Label();
            room.AutoSize = true;
            room.BackColor = Color.DarkGreen;
            room.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            room.ForeColor = SystemColors.ButtonHighlight;
            room.Location = new Point(153, 368);
            room.Size = new Size(180, 42);
            room.TabIndex = 15;
            room.Text = "Room No.";
            this.Controls.Add(room);

            // stntitle Label
            stntitle = new Label();
            stntitle.AutoSize = true;
            stntitle.BackColor = Color.Transparent;
            stntitle.Font = new Font("Microsoft Tai Le", 22F, FontStyle.Bold);
            stntitle.ForeColor = SystemColors.ButtonHighlight;
            stntitle.Location = new Point(458, 26);
            stntitle.Size = new Size(451, 56);
            stntitle.TabIndex = 17;
            stntitle.Text = "Student Information";
            this.Controls.Add(stntitle);

            // stnback Button
            stnback = new Button();
            stnback.BackColor = Color.Red;
            stnback.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            stnback.ForeColor = SystemColors.ButtonHighlight;
            stnback.Location = new Point(35, 572);
            stnback.Size = new Size(122, 40);
            stnback.TabIndex = 18;
            stnback.Text = "Back";
            stnback.UseVisualStyleBackColor = false;
            stnback.Click += stnback_Click_1;
            this.Controls.Add(stnback);

            // stnsearchbtn Button
            stnsearchbtn = new Button();
            stnsearchbtn.Location = new Point(1027, 407);
            stnsearchbtn.Size = new Size(75, 39);
            stnsearchbtn.TabIndex = 36;
            stnsearchbtn.Text = "Search";
            stnsearchbtn.UseVisualStyleBackColor = true;
            stnsearchbtn.Click += stnsearchbtn_Click;
            this.Controls.Add(stnsearchbtn);

            // stnsearchbar TextBox
            stnsearchbar = new TextBox();
            stnsearchbar.Location = new Point(818, 413);
            stnsearchbar.Size = new Size(173, 26);
            stnsearchbar.TabIndex = 35;
            this.Controls.Add(stnsearchbar);

            // stnsearch DataGridView
            stnsearch = new DataGridView();
            stnsearch.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Microsoft Sans Serif", 8F),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };
            stnsearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stnsearch.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft Sans Serif", 8F),
                ForeColor = SystemColors.ControlText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
            stnsearch.Location = new Point(332, 445);
            stnsearch.RowHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Microsoft Sans Serif", 8F),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };
            stnsearch.RowTemplate.Height = 28;
            stnsearch.Size = new Size(552, 150);
            stnsearch.TabIndex = 37;
            stnsearch.CellContentClick += stnsearch_CellContentClick;
            stnsearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stnsearch.MultiSelect = false;
            stnsearch.ReadOnly = true;
            this.Controls.Add(stnsearch);
        }

        private void studentinfo_Load(object sender, EventArgs e)
        {
            try
            {
                // Test database connection
                if (!_studentRepository.TestConnection())
                {
                    MessageBox.Show("Unable to connect to database. Please check your connection settings.",
                        "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load all students
                LoadAllStudents();

                // Clear form fields
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllStudents()
        {
            try
            {
                var students = _studentRepository.GetAllStudents();

                var displayData = students.Select(s => new
                {
                    StudentID = s.StudentID,
                    StudentName = s.StudentName,
                    DateOfBirth = s.DateOfBirth,
                    RoomNo = s.RoomNo,
                    CreatedDate = s.CreatedDate
                }).ToList();

                stnsearch.DataSource = displayData;

                // Format columns
                if (stnsearch.Columns.Count > 0)
                {
                    stnsearch.Columns["StudentID"].HeaderText = "Student ID";
                    stnsearch.Columns["StudentName"].HeaderText = "Student Name";
                    stnsearch.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    stnsearch.Columns["RoomNo"].HeaderText = "Room No.";
                    stnsearch.Columns["CreatedDate"].HeaderText = "Created Date";

                    stnsearch.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    stnsearch.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    // Auto-resize columns
                    stnsearch.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // DOB label click handler
        }

        private void stninsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(namebtn.Text))
                {
                    MessageBox.Show("Please enter student name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    namebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(roombtn.Text))
                {
                    MessageBox.Show("Please enter room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roombtn.Focus();
                    return;
                }

                // Create new student
                var student = new HMS.Models.Student
                {
                    StudentName = namebtn.Text.Trim(),
                    DateOfBirth = dobbtn.Value.Date,
                    RoomNo = roombtn.Text.Trim(),
                    CreatedDate = DateTime.Now
                };

                if (_studentRepository.InsertStudent(student))
                {
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStudents();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to add student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (stnsearch.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int studentId = Convert.ToInt32(stnsearch.SelectedRows[0].Cells["StudentID"].Value);

                    if (_studentRepository.DeleteStudent(studentId))
                    {
                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStudents();
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a student is selected
                if (stnsearch.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(namebtn.Text))
                {
                    MessageBox.Show("Please enter student name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    namebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(roombtn.Text))
                {
                    MessageBox.Show("Please enter room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roombtn.Focus();
                    return;
                }

                int studentId = Convert.ToInt32(stnsearch.SelectedRows[0].Cells["StudentID"].Value);

                // Create updated student
                var student = new HMS.Models.Student
                {
                    StudentID = studentId,
                    StudentName = namebtn.Text.Trim(),
                    DateOfBirth = dobbtn.Value.Date,
                    RoomNo = roombtn.Text.Trim()
                };

                if (_studentRepository.UpdateStudent(student))
                {
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStudents();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to update student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stnsearchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = stnsearchbar.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadAllStudents(); // Show all if search is empty
                    return;
                }

                var students = _studentRepository.SearchStudents(searchTerm);

                var displayData = students.Select(s => new
                {
                    StudentID = s.StudentID,
                    StudentName = s.StudentName,
                    DateOfBirth = s.DateOfBirth,
                    RoomNo = s.RoomNo,
                    CreatedDate = s.CreatedDate
                }).ToList();

                stnsearch.DataSource = displayData;

                if (students.Count == 0)
                {
                    MessageBox.Show($"No students found with search term '{searchTerm}'.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stnback_Click_1(object sender, EventArgs e)
        {
            // Back button click handler - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void stnsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && stnsearch.SelectedRows.Count > 0)
                {
                    var row = stnsearch.SelectedRows[0];

                    stnbtn.Text = row.Cells["StudentID"].Value.ToString();
                    namebtn.Text = row.Cells["StudentName"].Value.ToString();
                    dobbtn.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                    roombtn.Text = row.Cells["RoomNo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            stnbtn.Clear();
            namebtn.Clear();
            dobbtn.Value = DateTime.Now;
            roombtn.Clear();
        }
    }
}