using System.Drawing;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "POD Booking System - Login";
        this.Size = new Size(400, 300);

        // Login controls
        Label lblUsername = new Label();
        lblUsername.Text = "Username:";
        lblUsername.Location = new Point(50, 50);

        TextBox txtUsername = new TextBox();
        txtUsername.Location = new Point(150, 50);
        txtUsername.Size = new Size(200, 25);

        Label lblPassword = new Label();
        lblPassword.Text = "Password:";
        lblPassword.Location = new Point(50, 90);

        TextBox txtPassword = new TextBox();
        txtPassword.Location = new Point(150, 90);
        txtPassword.Size = new Size(200, 25);
        txtPassword.PasswordChar = '*';

        Button btnLogin = new Button();
        btnLogin.Text = "Login";
        btnLogin.Location = new Point(150, 130);
        btnLogin.Size = new Size(100, 30);
        btnLogin.Click += (s, e) =>
        {
            // Add login logic here
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        };

        // Add controls to form
        this.Controls.AddRange(new Control[] {
            lblUsername, txtUsername,
            lblPassword, txtPassword,
            btnLogin
        });
    }
}
