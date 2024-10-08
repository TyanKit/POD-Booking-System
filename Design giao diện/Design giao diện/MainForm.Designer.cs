using System.Drawing;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "POD Booking System";
        this.Size = new Size(800, 600);

        // Menu strip
        MenuStrip menuStrip = new MenuStrip();
        ToolStripMenuItem bookingMenu = new ToolStripMenuItem("Booking");
        bookingMenu.DropDownItems.AddRange(new ToolStripItem[] {
            new ToolStripMenuItem("New Booking"),
            new ToolStripMenuItem("View Bookings"),
            new ToolStripMenuItem("Cancel Booking")
        });

        ToolStripMenuItem podsMenu = new ToolStripMenuItem("PODs");
        ToolStripMenuItem profileMenu = new ToolStripMenuItem("Profile");

        menuStrip.Items.AddRange(new ToolStripItem[] {
            bookingMenu, podsMenu, profileMenu
        });

        // POD listing panel
        Panel podPanel = new Panel();
        podPanel.Dock = DockStyle.Fill;

        ListView podList = new ListView();
        podList.View = View.Details;
        podList.Dock = DockStyle.Fill;
        podList.Columns.AddRange(new ColumnHeader[] {
            new ColumnHeader() { Text = "POD ID", Width = 100 },
            new ColumnHeader() { Text = "Name", Width = 150 },
            new ColumnHeader() { Text = "Capacity", Width = 100 },
            new ColumnHeader() { Text = "Status", Width = 100 },
            new ColumnHeader() { Text = "Price/Hour", Width = 100 }
        });

        // Sample data
        ListViewItem[] pods = new ListViewItem[] {
            new ListViewItem(new string[] { "POD001", "Meeting Pod A", "4", "Available", "$10" }),
            new ListViewItem(new string[] { "POD002", "Focus Pod B", "1", "Occupied", "$5" }),
            new ListViewItem(new string[] { "POD003", "Team Pod C", "6", "Available", "$15" })
        };
        podList.Items.AddRange(pods);

        podPanel.Controls.Add(podList);

        // Add controls to form
        this.Controls.AddRange(new Control[] {
            menuStrip,
            podPanel
        });
        this.MainMenuStrip = menuStrip;
    }
}
