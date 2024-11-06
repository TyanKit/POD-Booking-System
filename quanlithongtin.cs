using System;
using System.Collections.Generic;

public class BookingSystem
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Feedback
    {
        public int CustomerId { get; set; }
        public int Rating { get; set; } 
        public string Comment { get; set; }
    }

    public class BookingHistory
    {
        public int CustomerId { get; set; }
        public DateTime BookingDate { get; set; }
        public string ServiceUsed { get; set; }
    }

    private List<Customer> customers = new List<Customer>();
    private List<Feedback> feedbacks = new List<Feedback>();
    private List<BookingHistory> histories = new List<BookingHistory>();

    public void AddCustomer(int id, string name, string email, string phoneNumber)
    {
        customers.Add(new Customer { Id = id, Name = name, Email = email, PhoneNumber = phoneNumber });
    }

    public List<Customer> GetAllCustomers()
    {
        return customers;
    }

    public void UpdateCustomer(int id, string name, string email, string phoneNumber)
    {
        var customer = customers.Find(c => c.Id == id);
        if (customer != null)
        {
            customer.Name = name;
            customer.Email = email;
            customer.PhoneNumber = phoneNumber;
        }
    }

    public void SubmitFeedback(int customerId, int rating, string comment)
    {
        feedbacks.Add(new Feedback { CustomerId = customerId, Rating = rating, Comment = comment });
    }

    public List<Feedback> GetAllFeedbacks()
    {
        return feedbacks;
    }

    public void AddBookingHistory(int customerId, DateTime bookingDate, string serviceUsed)
    {
        histories.Add(new BookingHistory { CustomerId = customerId, BookingDate = bookingDate, ServiceUsed = serviceUsed });
    }

    public List<BookingHistory> GetHistoryByCustomerId(int customerId)
    {
        return histories.FindAll(h => h.CustomerId == customerId);
    }
}

class Program
{
    static void Main()
    {
        BookingSystem system = new BookingSystem();

        system.AddCustomer(1, "Nguyen Van A", "nguyenvana@example.com", "0123456789");

        foreach (var c in system.GetAllCustomers())
        {
            Console.WriteLine($"khach hang: {c.Name}, Email: {c.Email}, So dien thoai: {c.PhoneNumber}");
        }

        system.SubmitFeedback(1, 5, "Dich vu rat tot!");

        foreach (var fb in system.GetAllFeedbacks())
        {
            Console.WriteLine($"Khach hang ID: {fb.CustomerId}, danh gia: {fb.Rating}, Nhan xet: {fb.Comment}");
        }

        system.AddBookingHistory(1, DateTime.Now, "Thue phong lam viec ca nhan");

        foreach (var h in system.GetHistoryByCustomerId(1))
        {
            Console.WriteLine($"Ngay su dung: {h.BookingDate}, Dich vu: {h.ServiceUsed}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
