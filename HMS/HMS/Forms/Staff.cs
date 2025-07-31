using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using HMS.Data;
using HMS.Models;

namespace HMS.Forms
{
    internal class Staff : Form
    {
        private Dashboard parentDashboard;
        private Button stfback;
        private TextBox stfaddressbtn;
        private Label stftitle;
        private Label staffaddress;
        private TextBox stfphonebtn;
        private Button stfmodify;
        private Button stfdelete;
        private Button stfinsert;
        private TextBox stfnamebtn;
        private TextBox stfidbtn;
        private Label staffnum;
        private Label staffname;
        private Label staffid;
        private Button staffsearch;
        private TextBox staffserachbar;
        private DataGridView dataGridView1;

        private StaffRepository _staffRepository;

        public Staff(Dashboard dashboard)
        {
            parentDashboard = dashboard;
            _staffRepository = new StaffRepository();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackgroundImage = Properties.Resources.img1;
            this.ClientSize = new Size(1358, 639);
            this.Text = "Staff Information - HMS";
            this.Load += Staff_Load;

            // stfback Button
            stfback = new Button();
            stfback.BackColor = Color.Red;
            stfback.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            stfback.ForeColor = SystemColors.ButtonHighlight;
            stfback.Location = new Point(39, 563);
            stfback.Size = new Size(122, 40);
            stfback.TabIndex = 46;
            stfback.Text = "Back";
            stfback.UseVisualStyleBackColor = false;
            stfback.Click += stfback_Click;
            this.Controls.Add(stfback);

            // stfaddressbtn TextBox
            stfaddressbtn = new TextBox();
            stfaddressbtn.Location = new Point(442, 376);
            stfaddressbtn.Size = new Size(274, 26);
            stfaddressbtn.TabIndex = 44;
            this.Controls.Add(stfaddressbtn);

            // stftitle Label
            stftitle = new Label();
            stftitle.AutoSize = true;
            stftitle.BackColor = Color.Transparent;
            stftitle.Font = new Font("Microsoft Tai Le", 22F, FontStyle.Bold);
            stftitle.ForeColor = SystemColors.ButtonHighlight;
            stftitle.Location = new Point(468, 29);
            stftitle.Size = new Size(387, 56);
            stftitle.TabIndex = 43;
            stftitle.Text = "Staff Information";
            this.Controls.Add(stftitle);

            // staffaddress Label
            staffaddress = new Label();
            staffaddress.AutoSize = true;
            staffaddress.BackColor = Color.DarkGreen;
            staffaddress.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            staffaddress.ForeColor = SystemColors.ButtonHighlight;
            staffaddress.Location = new Point(153, 361);
            staffaddress.Size = new Size(149, 42);
            staffaddress.TabIndex = 42;
            staffaddress.Text = "Address";
            this.Controls.Add(staffaddress);

            // stfphonebtn TextBox
            stfphonebtn = new TextBox();
            stfphonebtn.Location = new Point(442, 289);
            stfphonebtn.Size = new Size(274, 26);
            stfphonebtn.TabIndex = 41;
            this.Controls.Add(stfphonebtn);

            // stfmodify Button
            stfmodify = new Button();
            stfmodify.BackColor = Color.Blue;
            stfmodify.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stfmodify.ForeColor = SystemColors.ButtonHighlight;
            stfmodify.Location = new Point(827, 279);
            stfmodify.Size = new Size(122, 47);
            stfmodify.TabIndex = 40;
            stfmodify.Text = "Modify";
            stfmodify.UseVisualStyleBackColor = false;
            stfmodify.Click += stfmodify_Click;
            this.Controls.Add(stfmodify);

            // stfdelete Button
            stfdelete = new Button();
            stfdelete.BackColor = Color.Red;
            stfdelete.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stfdelete.ForeColor = SystemColors.ButtonHighlight;
            stfdelete.Location = new Point(827, 210);
            stfdelete.Size = new Size(122, 42);
            stfdelete.TabIndex = 39;
            stfdelete.Text = "Delete";
            stfdelete.UseVisualStyleBackColor = false;
            stfdelete.Click += stfdelete_Click;
            this.Controls.Add(stfdelete);

            // stfinsert Button
            stfinsert = new Button();
            stfinsert.BackColor = Color.FromArgb(192, 192, 0); // Olive
            stfinsert.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            stfinsert.ForeColor = SystemColors.ButtonHighlight;
            stfinsert.Location = new Point(827, 138);
            stfinsert.Size = new Size(122, 42);
            stfinsert.TabIndex = 38;
            stfinsert.Text = "Insert";
            stfinsert.UseVisualStyleBackColor = false;
            stfinsert.Click += stfinsert_Click;
            this.Controls.Add(stfinsert);

            // stfnamebtn TextBox
            stfnamebtn = new TextBox();
            stfnamebtn.Location = new Point(442, 210);
            stfnamebtn.Size = new Size(274, 26);
            stfnamebtn.TabIndex = 37;
            this.Controls.Add(stfnamebtn);

            // stfidbtn TextBox
            stfidbtn = new TextBox();
            stfidbtn.Location = new Point(442, 133);
            stfidbtn.Size = new Size(274, 26);
            stfidbtn.TabIndex = 36;
            stfidbtn.ReadOnly = true;
            stfidbtn.BackColor = Color.LightGray;
            this.Controls.Add(stfidbtn);

            // staffnum Label
            staffnum = new Label();
            staffnum.AutoSize = true;
            staffnum.BackColor = Color.DarkGreen;
            staffnum.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            staffnum.ForeColor = SystemColors.ButtonHighlight;
            staffnum.Location = new Point(153, 274);
            staffnum.Size = new Size(188, 42);
            staffnum.TabIndex = 35;
            staffnum.Text = "Phone No.";
            this.Controls.Add(staffnum);

            // staffname Label
            staffname = new Label();
            staffname.AutoSize = true;
            staffname.BackColor = Color.DarkGreen;
            staffname.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            staffname.ForeColor = SystemColors.ButtonHighlight;
            staffname.Location = new Point(153, 195);
            staffname.Size = new Size(113, 42);
            staffname.TabIndex = 34;
            staffname.Text = "Name";
            this.Controls.Add(staffname);

            // staffid Label
            staffid = new Label();
            staffid.AutoSize = true;
            staffid.BackColor = Color.DarkGreen;
            staffid.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            staffid.ForeColor = SystemColors.ButtonHighlight;
            staffid.Location = new Point(153, 118);
            staffid.Size = new Size(140, 42);
            staffid.TabIndex = 33;
            staffid.Text = "Staff ID";
            this.Controls.Add(staffid);

            // staffsearch Button
            staffsearch = new Button();
            staffsearch.Location = new Point(1051, 403);
            staffsearch.Size = new Size(75, 39);
            staffsearch.TabIndex = 48;
            staffsearch.Text = "Search";
            staffsearch.UseVisualStyleBackColor = true;
            staffsearch.Click += staffsearch_Click;
            this.Controls.Add(staffsearch);

            // staffserachbar TextBox
            staffserachbar = new TextBox();
            staffserachbar.Location = new Point(842, 409);
            staffserachbar.Size = new Size(173, 26);
            staffserachbar.TabIndex = 47;
            this.Controls.Add(staffserachbar);

            // dataGridView1
            dataGridView1 = new DataGridView();
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(378, 453);
            dataGridView1.Size = new Size(550, 150);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            this.Controls.Add(dataGridView1);
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            try
            {
                // Test database connection
                if (!_staffRepository.TestConnection())
                {
                    MessageBox.Show("Unable to connect to database. Please check your connection settings.",
                        "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load all staff
                LoadAllStaff();

                // Clear form fields
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllStaff()
        {
            try
            {
                var staffList = _staffRepository.GetAllStaff();

                var displayData = staffList.Select(s => new
                {
                    StaffID = s.StaffID,
                    StaffName = s.StaffName,
                    PhoneNo = s.PhoneNo,
                    Address = s.Address,
                    CreatedDate = s.CreatedDate
                }).ToList();

                dataGridView1.DataSource = displayData;

                // Format columns
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["StaffID"].HeaderText = "Staff ID";
                    dataGridView1.Columns["StaffName"].HeaderText = "Staff Name";
                    dataGridView1.Columns["PhoneNo"].HeaderText = "Phone No.";
                    dataGridView1.Columns["Address"].HeaderText = "Address";
                    dataGridView1.Columns["CreatedDate"].HeaderText = "Created Date";

                    dataGridView1.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    // Auto-resize columns
                    dataGridView1.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stfinsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(stfnamebtn.Text))
                {
                    MessageBox.Show("Please enter staff name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfnamebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(stfphonebtn.Text))
                {
                    MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(stfaddressbtn.Text))
                {
                    MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfaddressbtn.Focus();
                    return;
                }

                // Validate phone number format
                if (!IsValidPhoneNumber(stfphonebtn.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                // Check if phone number already exists
                if (_staffRepository.IsPhoneNumberExists(stfphonebtn.Text.Trim()))
                {
                    MessageBox.Show("This phone number is already registered to another staff member.", "Duplicate Phone Number",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                // Create new staff
                var staff = new HMS.Models.Staff
                {
                    StaffName = stfnamebtn.Text.Trim(),
                    PhoneNo = stfphonebtn.Text.Trim(),
                    Address = stfaddressbtn.Text.Trim(),
                    CreatedDate = DateTime.Now
                };

                if (_staffRepository.InsertStaff(staff))
                {
                    MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to add staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stfdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff member to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int staffId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StaffID"].Value);

                    if (_staffRepository.DeleteStaff(staffId))
                    {
                        MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStaff();
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stfmodify_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a staff is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff member to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(stfnamebtn.Text))
                {
                    MessageBox.Show("Please enter staff name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfnamebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(stfphonebtn.Text))
                {
                    MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(stfaddressbtn.Text))
                {
                    MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfaddressbtn.Focus();
                    return;
                }

                int staffId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StaffID"].Value);

                // Validate phone number format
                if (!IsValidPhoneNumber(stfphonebtn.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                // Check if phone number already exists (excluding current staff)
                if (_staffRepository.IsPhoneNumberExists(stfphonebtn.Text.Trim(), staffId))
                {
                    MessageBox.Show("This phone number is already registered to another staff member.", "Duplicate Phone Number",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stfphonebtn.Focus();
                    return;
                }

                // Create updated staff
                var staff = new HMS.Models.Staff
                {
                    StaffID = staffId,
                    StaffName = stfnamebtn.Text.Trim(),
                    PhoneNo = stfphonebtn.Text.Trim(),
                    Address = stfaddressbtn.Text.Trim()
                };

                if (_staffRepository.UpdateStaff(staff))
                {
                    MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaff();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to update staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = staffserachbar.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadAllStaff(); // Show all if search is empty
                    return;
                }

                var staffList = _staffRepository.SearchStaff(searchTerm);

                var displayData = staffList.Select(s => new
                {
                    StaffID = s.StaffID,
                    StaffName = s.StaffName,
                    PhoneNo = s.PhoneNo,
                    Address = s.Address,
                    CreatedDate = s.CreatedDate
                }).ToList();

                dataGridView1.DataSource = displayData;

                if (staffList.Count == 0)
                {
                    MessageBox.Show($"No staff members found with search term '{searchTerm}'.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stfback_Click(object sender, EventArgs e)
        {
            // Back button click handler - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];

                    stfidbtn.Text = row.Cells["StaffID"].Value.ToString();
                    stfnamebtn.Text = row.Cells["StaffName"].Value.ToString();
                    stfphonebtn.Text = row.Cells["PhoneNo"].Value.ToString();
                    stfaddressbtn.Text = row.Cells["Address"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            stfidbtn.Clear();
            stfnamebtn.Clear();
            stfphonebtn.Clear();
            stfaddressbtn.Clear();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Basic phone number validation - you can make this more sophisticated
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Remove common phone number characters
            string cleanNumber = phoneNumber.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("+", "");

            // Check if it contains only digits and has reasonable length
            return cleanNumber.All(char.IsDigit) && cleanNumber.Length >= 7 && cleanNumber.Length <= 15;
        }
    }
}