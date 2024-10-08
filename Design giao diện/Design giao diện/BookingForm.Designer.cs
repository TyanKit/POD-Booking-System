using System.Drawing;
using System.Windows.Forms;

public partial class BookingForm : Form
{
    public BookingForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "New Booking";
        this.Size = new Size(500, 400);

        // Booking controls
        Label lblPod = new Label();
        lblPod.Text = "Select POD:";
        lblPod.Location = new Point(50, 50);

        ComboBox cboPod = new ComboBox();
        cboPod.Location = new Point(150, 50);
        cboPod.Size = new Size(200, 25);
        cboPod.Items.AddRange(new string[] { "POD001", "POD002", "POD003" });

        Label lblDate = new Label();
        lblDate.Text = "Date:";
        lblDate.Location = new Point(50, 90);

        DateTimePicker dtpDate = new DateTimePicker();
        dtpDate.Location = new Point(150, 90);
        dtpDate.Size = new Size(200, 25);

        Label lblTime = new Label();
        lblTime.Text = "Time:";
        lblTime.Location = new Point(50, 130);

        ComboBox cboTime = new ComboBox();
        cboTime.Location = new Point(150, 130);
        cboTime.Size = new Size(200, 25);
        cboTime.Items.AddRange(new string[] {
            "09:00", "10:00", "11:00", "12:00",
            "13:00", "14:00", "15:00", "16:00"
        });

        Label lblDuration = new Label();
        lblDuration.Text = "Duration (hours):";
        lblDuration.Location = new Point(50, 170);

        NumericUpDown nudDuration = new NumericUpDown();
        nudDuration.Location = new Point(150, 170);
        nudDuration.Size = new Size(100, 25);
        nudDuration.Minimum = 1;
        nudDuration.Maximum = 8;

        Button btnBook = new Button();
        btnBook.Text = "Book Now";
        btnBook.Location = new Point(150, 220);
        btnBook.Size = new Size(100, 30);
        btnBook.Click += (s, e) =>
        {
            // Add booking logic here
            MessageBox.Show("Booking successful!");
            this.Close();
        };

        // Add controls to form
        this.Controls.AddRange(new Control[] {
            lblPod, cboPod,
            lblDate, dtpDate,
            lblTime, cboTime,
            lblDuration, nudDuration,
            btnBook
        });
    }
}
