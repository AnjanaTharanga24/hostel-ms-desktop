using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace HMS.Forms
{
    internal class Login : Form
    {
        private Label managment;
        private GroupBox grp1;
        private CheckBox checkBox1;
        private Button login;
        private TextBox txt2;
        private TextBox txt1;
        private Label password;
        private Label user;
        private PictureBox pic1;
        private Label label4;

        public Login()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Main Form setup
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size(1258, 600);
            this.ForeColor = SystemColors.ButtonFace;
            this.Text = "Hostel Management System - Login";
            this.Load += form1_Load;

            // Set background image from resources
            this.BackgroundImage = Properties.Resources.img1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // managment Label
            managment = new Label();
            managment.AutoSize = true;
            managment.BackColor = Color.Transparent;
            managment.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold);
            managment.ForeColor = SystemColors.ButtonHighlight;
            managment.Location = new Point(417, 28);
            managment.Size = new Size(500, 61);
            managment.TabIndex = 0;
            managment.Text = "Hostel Management ";
            this.Controls.Add(managment);

            // grp1 GroupBox
            grp1 = new GroupBox();
            grp1.BackColor = Color.FromArgb(0, 64, 0);
            grp1.ForeColor = SystemColors.ButtonHighlight;
            grp1.Location = new Point(497, 147);
            grp1.Size = new Size(612, 352);
            grp1.TabIndex = 1;
            grp1.TabStop = false;
            grp1.Text = "Login";
            this.Controls.Add(grp1);

            // checkBox1
            checkBox1 = new CheckBox();
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(380, 229);
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            grp1.Controls.Add(checkBox1);

            // login Button
            login = new Button();
            login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            login.ForeColor = SystemColors.Desktop;
            login.Location = new Point(230, 279);
            login.Size = new Size(134, 46);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            grp1.Controls.Add(login);

            // txt2 (Password TextBox)
            txt2 = new TextBox();
            txt2.Location = new Point(259, 182);
            txt2.Size = new Size(269, 26);
            txt2.TabIndex = 3;
            txt2.PasswordChar = '•';
            txt2.TextChanged += txt2_TextChanged;
            grp1.Controls.Add(txt2);

            // txt1 (Username TextBox)
            txt1 = new TextBox();
            txt1.Location = new Point(259, 111);
            txt1.Size = new Size(269, 26);
            txt1.TabIndex = 2;
            txt1.TextChanged += txt1_TextChanged;
            grp1.Controls.Add(txt1);

            // password Label
            password = new Label();
            password.AutoSize = true;
            password.Font = new Font("Microsoft Sans Serif", 11F);
            password.ForeColor = SystemColors.ButtonFace;
            password.Location = new Point(77, 180);
            password.Size = new Size(108, 26);
            password.TabIndex = 1;
            password.Text = "Password";
            grp1.Controls.Add(password);

            // user Label
            user = new Label();
            user.AutoSize = true;
            user.Font = new Font("Microsoft Sans Serif", 11F);
            user.ForeColor = SystemColors.ButtonHighlight;
            user.Location = new Point(73, 111);
            user.Size = new Size(123, 26);
            user.TabIndex = 0;
            user.Text = "User Name";
            grp1.Controls.Add(user);

            // pic1 PictureBox
            pic1 = new PictureBox();
            pic1.BackgroundImage = Properties.Resources.img2;
            pic1.BackgroundImageLayout = ImageLayout.Stretch;
            pic1.Location = new Point(127, 164);
            pic1.Size = new Size(274, 245);
            pic1.TabIndex = 2;
            pic1.TabStop = false;
            this.Controls.Add(pic1);

            // label4 Label
            label4 = new Label();
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold);
            label4.Location = new Point(222, 426);
            label4.Size = new Size(95, 46);
            label4.TabIndex = 4;
            label4.Text = "User";
            label4.Click += label4_Click;
            this.Controls.Add(label4);
        }

        private void form1_Load(object sender, EventArgs e)
        {
            // Form load event handler
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txt2.PasswordChar = checkBox1.Checked ? '\0' : '•';
        }

        private void login_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Authentication with username: admin, password: 1234
            if (txt1.Text == "admin" && txt2.Text == "1234")
            {
                MessageBox.Show("Login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                // Hide or close the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e) { }
        private void txt1_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}