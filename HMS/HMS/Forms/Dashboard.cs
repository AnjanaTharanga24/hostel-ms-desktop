using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS.Forms
{
    internal class Dashboard : Form
    {
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private Label Title;
        private Button studentbtn;
        private Button guestbtn;
        private Button staffbtn;

        public Dashboard()
        {
            InitializeComponents();
            this.FormClosing += Dashboard_FormClosing;
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1259, 618);
            this.Text = "Dashboard";
            this.BackgroundImage = Properties.Resources.img1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // pic1 PictureBox
            pic1 = new PictureBox();
            pic1.BackgroundImage = Properties.Resources.img3;
            pic1.BackgroundImageLayout = ImageLayout.Stretch;
            pic1.Location = new Point(160, 173);
            pic1.Size = new Size(263, 254);
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            this.Controls.Add(pic1);

            // pic2 PictureBox
            pic2 = new PictureBox();
            pic2.BackgroundImage = Properties.Resources.img3;
            pic2.BackgroundImageLayout = ImageLayout.Stretch;
            pic2.Location = new Point(499, 173);
            pic2.Size = new Size(263, 254);
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            this.Controls.Add(pic2);

            // pic3 PictureBox
            pic3 = new PictureBox();
            pic3.BackgroundImage = Properties.Resources.img3;
            pic3.BackgroundImageLayout = ImageLayout.Stretch;
            pic3.Location = new Point(842, 173);
            pic3.Size = new Size(263, 254);
            pic3.TabIndex = 2;
            pic3.TabStop = false;
            this.Controls.Add(pic3);

            // Title Label
            Title = new Label();
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Microsoft Tai Le", 26F, FontStyle.Bold);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(337, 33);
            Title.Size = new Size(612, 67);
            Title.TabIndex = 6;
            Title.Text = "Welcome To Dashboard";
            this.Controls.Add(Title);

            // studentbtn Button
            studentbtn = new Button();
            studentbtn.BackColor = Color.DarkGreen;
            studentbtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            studentbtn.ForeColor = Color.White;
            studentbtn.Location = new Point(184, 462);
            studentbtn.Size = new Size(221, 56);
            studentbtn.TabIndex = 7;
            studentbtn.Text = "Students";
            studentbtn.UseVisualStyleBackColor = false;
            studentbtn.Click += studentbtn_Click;
            this.Controls.Add(studentbtn);

            // guestbtn Button
            guestbtn = new Button();
            guestbtn.BackColor = Color.DarkGreen;
            guestbtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            guestbtn.ForeColor = Color.White;
            guestbtn.Location = new Point(527, 462);
            guestbtn.Size = new Size(217, 56);
            guestbtn.TabIndex = 8;
            guestbtn.Text = "Guest";
            guestbtn.UseVisualStyleBackColor = false;
            guestbtn.Click += guestbtn_Click;
            this.Controls.Add(guestbtn);

            // staffbtn Button
            staffbtn = new Button();
            staffbtn.BackColor = Color.DarkGreen;
            staffbtn.Font = new Font("Franklin Gothic Medium", 16F, FontStyle.Bold);
            staffbtn.ForeColor = Color.White;
            staffbtn.Location = new Point(875, 462);
            staffbtn.Size = new Size(215, 56);
            staffbtn.TabIndex = 9;
            staffbtn.Text = "Staff";
            staffbtn.UseVisualStyleBackColor = false;
            staffbtn.Click += staffbtn_Click;
            this.Controls.Add(staffbtn);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student(this);
            studentForm.Show();
            this.Hide();
        }

        private void guestbtn_Click(object sender, EventArgs e)
        {
            Guest guestForm = new Guest(this);
            guestForm.Show();
            this.Hide();
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            Staff staffForm = new Staff(this);
            staffForm.Show();
            this.Hide();
        }
    }
}