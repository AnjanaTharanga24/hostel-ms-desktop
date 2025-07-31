using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using HMS.Data;
using HMS.Models;

namespace HMS.Forms
{
    internal class Guest : Form
    {
        private Dashboard parentDashboard;
        private Label gsttitle;
        private Label label4;
        private TextBox gstnumbtn;
        private Button gstmodify;
        private Button gstdelete;
        private Button gstinsert;
        private TextBox gstnamebtn;
        private TextBox gstidbtn;
        private Label gstnum;
        private Label guestname;
        private Label guestid;
        private TextBox gstroombtn;
        private Button gstback;
        private TextBox searchbar;
        private Button gstsearch;
        private DataGridView gstsearchbar;

        private GuestRepository _guestRepository;

        public Guest(Dashboard dashboard)
        {
            parentDashboard = dashboard;
            _guestRepository = new GuestRepository();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackgroundImage = Properties.Resources.img1; // Make sure you have img1 in resources
            this.ClientSize = new Size(1350, 624);
            this.Text = "Guest Information - HMS";
            this.Load += Guest_Load;

            // gsttitle Label
            gsttitle = new Label();
            gsttitle.AutoSize = true;
            gsttitle.BackColor = Color.Transparent;
            gsttitle.Font = new Font("Microsoft Tai Le", 22F, FontStyle.Bold);
            gsttitle.ForeColor = SystemColors.ButtonHighlight;
            gsttitle.Location = new Point(462, 25);
            gsttitle.Size = new Size(405, 56);
            gsttitle.TabIndex = 29;
            gsttitle.Text = "Guest Information";
            this.Controls.Add(gsttitle);

            // label4 Label
            label4 = new Label();
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(147, 357);
            label4.Size = new Size(180, 42);
            label4.TabIndex = 28;
            label4.Text = "Room No.";
            this.Controls.Add(label4);

            // gstnumbtn TextBox (Phone Number)
            gstnumbtn = new TextBox();
            gstnumbtn.Location = new Point(436, 285);
            gstnumbtn.Size = new Size(274, 26);
            gstnumbtn.TabIndex = 27;
            this.Controls.Add(gstnumbtn);

            // gstmodify Button
            gstmodify = new Button();
            gstmodify.BackColor = Color.Blue;
            gstmodify.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            gstmodify.ForeColor = SystemColors.ButtonHighlight;
            gstmodify.Location = new Point(821, 275);
            gstmodify.Size = new Size(122, 47);
            gstmodify.TabIndex = 26;
            gstmodify.Text = "Modify";
            gstmodify.UseVisualStyleBackColor = false;
            gstmodify.Click += gstmodify_Click;
            this.Controls.Add(gstmodify);

            // gstdelete Button
            gstdelete = new Button();
            gstdelete.BackColor = Color.Red;
            gstdelete.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            gstdelete.ForeColor = SystemColors.ButtonHighlight;
            gstdelete.Location = new Point(821, 206);
            gstdelete.Size = new Size(122, 42);
            gstdelete.TabIndex = 25;
            gstdelete.Text = "Delete";
            gstdelete.UseVisualStyleBackColor = false;
            gstdelete.Click += gstdelete_Click;
            this.Controls.Add(gstdelete);

            // gstinsert Button
            gstinsert = new Button();
            gstinsert.BackColor = Color.FromArgb(192, 192, 0); // Olive
            gstinsert.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            gstinsert.ForeColor = SystemColors.ButtonHighlight;
            gstinsert.Location = new Point(821, 134);
            gstinsert.Size = new Size(122, 42);
            gstinsert.TabIndex = 24;
            gstinsert.Text = "Insert";
            gstinsert.UseVisualStyleBackColor = false;
            gstinsert.Click += gstinsert_Click;
            this.Controls.Add(gstinsert);

            // gstnamebtn TextBox
            gstnamebtn = new TextBox();
            gstnamebtn.Location = new Point(436, 206);
            gstnamebtn.Size = new Size(274, 26);
            gstnamebtn.TabIndex = 22;
            this.Controls.Add(gstnamebtn);

            // gstidbtn TextBox (Guest ID)
            gstidbtn = new TextBox();
            gstidbtn.Location = new Point(436, 129);
            gstidbtn.Size = new Size(274, 26);
            gstidbtn.TabIndex = 21;
            gstidbtn.ReadOnly = true;
            gstidbtn.BackColor = Color.LightGray;
            this.Controls.Add(gstidbtn);

            // gstnum Label
            gstnum = new Label();
            gstnum.AutoSize = true;
            gstnum.BackColor = Color.DarkGreen;
            gstnum.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            gstnum.ForeColor = SystemColors.ButtonHighlight;
            gstnum.Location = new Point(147, 270);
            gstnum.Size = new Size(188, 42);
            gstnum.TabIndex = 20;
            gstnum.Text = "Phone No.";
            this.Controls.Add(gstnum);

            // guestname Label
            guestname = new Label();
            guestname.AutoSize = true;
            guestname.BackColor = Color.DarkGreen;
            guestname.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            guestname.ForeColor = SystemColors.ButtonHighlight;
            guestname.Location = new Point(147, 191);
            guestname.Size = new Size(113, 42);
            guestname.TabIndex = 19;
            guestname.Text = "Name";
            this.Controls.Add(guestname);

            // guestid Label
            guestid = new Label();
            guestid.AutoSize = true;
            guestid.BackColor = Color.DarkGreen;
            guestid.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            guestid.ForeColor = SystemColors.ButtonHighlight;
            guestid.Location = new Point(147, 114);
            guestid.Size = new Size(157, 42);
            guestid.TabIndex = 18;
            guestid.Text = "Guest ID";
            this.Controls.Add(guestid);

            // gstroombtn TextBox
            gstroombtn = new TextBox();
            gstroombtn.Location = new Point(436, 372);
            gstroombtn.Size = new Size(274, 26);
            gstroombtn.TabIndex = 30;
            this.Controls.Add(gstroombtn);

            // gstback Button
            gstback = new Button();
            gstback.BackColor = Color.Red;
            gstback.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            gstback.ForeColor = SystemColors.ButtonHighlight;
            gstback.Location = new Point(33, 559);
            gstback.Size = new Size(122, 40);
            gstback.TabIndex = 32;
            gstback.Text = "Back";
            gstback.UseVisualStyleBackColor = false;
            gstback.Click += gstback_Click;
            this.Controls.Add(gstback);

            // searchbar TextBox
            searchbar = new TextBox();
            searchbar.Location = new Point(844, 412);
            searchbar.Size = new Size(173, 26);
            searchbar.TabIndex = 33;
            this.Controls.Add(searchbar);

            // gstsearch Button
            gstsearch = new Button();
            gstsearch.Location = new Point(1053, 406);
            gstsearch.Size = new Size(75, 39);
            gstsearch.TabIndex = 34;
            gstsearch.Text = "Search";
            gstsearch.UseVisualStyleBackColor = true;
            gstsearch.Click += gstsearch_Click;
            this.Controls.Add(gstsearch);

            // gstsearchbar DataGridView
            gstsearchbar = new DataGridView();
            gstsearchbar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gstsearchbar.Location = new Point(262, 449);
            gstsearchbar.RowTemplate.Height = 28;
            gstsearchbar.Size = new Size(605, 150);
            gstsearchbar.TabIndex = 35;
            gstsearchbar.CellContentClick += gstsearchbar_CellContentClick;
            gstsearchbar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gstsearchbar.MultiSelect = false;
            gstsearchbar.ReadOnly = true;
            this.Controls.Add(gstsearchbar);
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            try
            {
                // Test database connection
                if (!_guestRepository.TestConnection())
                {
                    MessageBox.Show("Unable to connect to database. Please check your connection settings.",
                        "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load all guests
                LoadAllGuests();

                // Clear form fields
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllGuests()
        {
            try
            {
                var guests = _guestRepository.GetAllGuests();

                var displayData = guests.Select(g => new
                {
                    GuestID = g.GuestID,
                    GuestName = g.GuestName,
                    PhoneNo = g.PhoneNo,
                    RoomNo = g.RoomNo,
                    CreatedDate = g.CreatedDate
                }).ToList();

                gstsearchbar.DataSource = displayData;

                // Format columns
                if (gstsearchbar.Columns.Count > 0)
                {
                    gstsearchbar.Columns["GuestID"].HeaderText = "Guest ID";
                    gstsearchbar.Columns["GuestName"].HeaderText = "Guest Name";
                    gstsearchbar.Columns["PhoneNo"].HeaderText = "Phone No.";
                    gstsearchbar.Columns["RoomNo"].HeaderText = "Room No.";
                    gstsearchbar.Columns["CreatedDate"].HeaderText = "Created Date";

                    gstsearchbar.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    // Auto-resize columns
                    gstsearchbar.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gstinsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(gstnamebtn.Text))
                {
                    MessageBox.Show("Please enter guest name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnamebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(gstnumbtn.Text))
                {
                    MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnumbtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(gstroombtn.Text))
                {
                    MessageBox.Show("Please enter room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstroombtn.Focus();
                    return;
                }

                // Check if room is available
                if (!_guestRepository.IsRoomAvailable(gstroombtn.Text.Trim()))
                {
                    MessageBox.Show("This room is already occupied by another guest.", "Room Not Available",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstroombtn.Focus();
                    return;
                }

                // Validate phone number format (basic validation)
                if (!IsValidPhoneNumber(gstnumbtn.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnumbtn.Focus();
                    return;
                }

                // Create new guest
                var guest = new HMS.Models.Guest
                {
                    GuestName = gstnamebtn.Text.Trim(),
                    PhoneNo = gstnumbtn.Text.Trim(),
                    RoomNo = gstroombtn.Text.Trim(),
                    CreatedDate = DateTime.Now
                };

                if (_guestRepository.InsertGuest(guest))
                {
                    MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllGuests();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to add guest. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gstdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gstsearchbar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a guest to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int guestId = Convert.ToInt32(gstsearchbar.SelectedRows[0].Cells["GuestID"].Value);

                    if (_guestRepository.DeleteGuest(guestId))
                    {
                        MessageBox.Show("Guest deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllGuests();
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete guest. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gstmodify_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a guest is selected
                if (gstsearchbar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a guest to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(gstnamebtn.Text))
                {
                    MessageBox.Show("Please enter guest name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnamebtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(gstnumbtn.Text))
                {
                    MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnumbtn.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(gstroombtn.Text))
                {
                    MessageBox.Show("Please enter room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstroombtn.Focus();
                    return;
                }

                int guestId = Convert.ToInt32(gstsearchbar.SelectedRows[0].Cells["GuestID"].Value);

                // Check if room is available (excluding current guest)
                if (!_guestRepository.IsRoomAvailable(gstroombtn.Text.Trim(), guestId))
                {
                    MessageBox.Show("This room is already occupied by another guest.", "Room Not Available",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstroombtn.Focus();
                    return;
                }

                // Validate phone number format
                if (!IsValidPhoneNumber(gstnumbtn.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gstnumbtn.Focus();
                    return;
                }

                // Create updated guest
                var guest = new HMS.Models.Guest
                {
                    GuestID = guestId,
                    GuestName = gstnamebtn.Text.Trim(),
                    PhoneNo = gstnumbtn.Text.Trim(),
                    RoomNo = gstroombtn.Text.Trim()
                };

                if (_guestRepository.UpdateGuest(guest))
                {
                    MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllGuests();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to update guest. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gstsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchbar.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadAllGuests(); // Show all if search is empty
                    return;
                }

                var guests = _guestRepository.SearchGuests(searchTerm);

                var displayData = guests.Select(g => new
                {
                    GuestID = g.GuestID,
                    GuestName = g.GuestName,
                    PhoneNo = g.PhoneNo,
                    RoomNo = g.RoomNo,
                    CreatedDate = g.CreatedDate
                }).ToList();

                gstsearchbar.DataSource = displayData;

                if (guests.Count == 0)
                {
                    MessageBox.Show($"No guests found with search term '{searchTerm}'.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gstback_Click(object sender, EventArgs e)
        {
            // Back button click handler - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void gstsearchbar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && gstsearchbar.SelectedRows.Count > 0)
                {
                    var row = gstsearchbar.SelectedRows[0];

                    gstidbtn.Text = row.Cells["GuestID"].Value.ToString();
                    gstnamebtn.Text = row.Cells["GuestName"].Value.ToString();
                    gstnumbtn.Text = row.Cells["PhoneNo"].Value.ToString();
                    gstroombtn.Text = row.Cells["RoomNo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            gstidbtn.Clear();
            gstnamebtn.Clear();
            gstnumbtn.Clear();
            gstroombtn.Clear();
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