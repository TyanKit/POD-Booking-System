using System;
using System.Windows.Forms;

namespace PODBookingSystem
{
    static class Program
    {
        /// <summary>
        /// Điểm bắt đầu của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy form đăng nhập
            Application.Run(new LoginForm());  // Đảm bảo rằng LoginForm được tạo trong dự án.
        }
    }
}
