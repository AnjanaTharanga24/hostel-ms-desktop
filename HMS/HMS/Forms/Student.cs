using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

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

        public Student(Dashboard dashboard)
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
            this.ClientSize = new Size(1350, 624);
            this.Text = "Student-info";
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

            // stnbtn TextBox
            stnbtn = new TextBox();
            stnbtn.Location = new Point(452, 141);
            stnbtn.Size = new Size(274, 26);
            stnbtn.TabIndex = 4;
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
            this.Controls.Add(stnsearch);
        }

        private void studentinfo_Load(object sender, EventArgs e)
        {
            // Form load event handler
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // DOB label click handler
        }

        private void stninsert_Click(object sender, EventArgs e)
        {
            // Insert button click handler
        }

        private void stndelete_Click(object sender, EventArgs e)
        {
            // Delete button click handler
        }

        private void stnmodify_Click(object sender, EventArgs e)
        {
            // Modify button click handler
        }

        private void stnback_Click_1(object sender, EventArgs e)
        {
            // Back button click handler - Navigate to Dashboard
            parentDashboard.Show();
            this.Close();
        }

        private void stnsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView cell click handler
        }
    }
}
