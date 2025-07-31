using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

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

        public Guest(Dashboard dashboard)
        {
            parentDashboard = dashboard;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackgroundImage = Properties.Resources.img1; // Make sure you have img1 in resources
            this.ClientSize = new Size(1350, 624);
            this.Text = "Guest_Info";

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

            // gstnumbtn TextBox
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
            gstinsert.Click += button1_Click;
            this.Controls.Add(gstinsert);

            // gstnamebtn TextBox
            gstnamebtn = new TextBox();
            gstnamebtn.Location = new Point(436, 206);
            gstnamebtn.Size = new Size(274, 26);
            gstnamebtn.TabIndex = 22;
            this.Controls.Add(gstnamebtn);

            // gstidbtn TextBox
            gstidbtn = new TextBox();
            gstidbtn.Location = new Point(436, 129);
            gstidbtn.Size = new Size(274, 26);
            gstidbtn.TabIndex = 21;
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
            this.Controls.Add(gstsearch);

            // gstsearchbar DataGridView
            gstsearchbar = new DataGridView();
            gstsearchbar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gstsearchbar.Location = new Point(262, 449);
            gstsearchbar.RowTemplate.Height = 28;
            gstsearchbar.Size = new Size(605, 150);
            gstsearchbar.TabIndex = 35;
            gstsearchbar.CellContentClick += gstsearchbar_CellContentClick;
            this.Controls.Add(gstsearchbar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert button click handler
        }

        private void gstback_Click(object sender, EventArgs e)
        {
            // Back button click handler - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void gstsearchbar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView cell click handler
        }
    }
}