using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

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

        public Staff(Dashboard dashboard)
        {
            parentDashboard = dashboard;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources.img1; // Make sure you have img1 in resources
            this.ClientSize = new Size(1358, 639);
            this.Text = "Staff_Info";

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
            stfinsert.Click += button1_Click;
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
            this.Controls.Add(dataGridView1);
        }

        private void stfback_Click(object sender, EventArgs e)
        {
            // Handle back button click - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle insert button click
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle data grid view cell click
        }
    }
}
