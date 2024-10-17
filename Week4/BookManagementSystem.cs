using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    /*
        1)Implement a method to filter books by Genre and Price Range using lambda expressions.
        Allow customers to search for books by Author or Title using lambda expressions combined with LINQ.
        Create an object model for a Book, Customer, Order, and Library using proper object-oriented principles:
        Book: Attributes include Title, Author, ISBN, Price, and Genre.
        Customer: Attributes include Name, Email, and a collection of Orders.
        Order: Represents a purchase made by a customer, which includes an OrderID, List of Books, Total Amount, and Order Date.
        Library: A collection of Books that supports adding, removing, and searching books.
            
     */
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public decimal Price { get; private set; }
        public string Genre { get; private set; }

        public Book(string title, string author, string iSBN, decimal price, string genre)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Genre = genre;

        }
    }

    class Customer
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<Orders> orders = new List<Orders>();

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void setName(string name) => Name = name;
        public void setEmail(string email) => Email = email;

        public void AddOrder(Orders order)
        {
            orders.Add(order);
        }
    }
    class Library
    {
        private List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(string isbn)
        {
            Books.RemoveAll(book => book.ISBN==isbn);

        }

        public List<Book> SearchBookByTitle(string title)
        {
            return Books.Where(book => book.Title==title).ToList();
        }
    }
    class Orders
    {
        public int OrderId { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        
        public Orders(int orderId, List<Book> books)
        {
            OrderId = orderId;
            Books = books;
            TotalAmount = books.Sum(book => book.Price);
            OrderDate = DateTime.Now;
        }
    }
    internal class BookManagementSystem
    {
        public static void ManagingBooks()
        {
            Library library = new Library();

            Book book1 = new Book("C#", "John Doe", "123-456-789", 499, "Programming");
            Book book2 = new Book("Java", "James Gosling", "233-456-789", 699, "Programming");
            Book book3 = new Book("Python", "John Doe", "123-406-789", 469, "Programming");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book2);

            Customer newCustomer = new Customer("Ghouse", "ghouse123@gmail.com");

            Orders order = new Orders(1, new List<Book> { book1, book3 });

            newCustomer.AddOrder(order);

            Console.WriteLine($"Customer Details \nName : {newCustomer.Name} \nEmail : {newCustomer.Email}\n\n");

            Console.WriteLine($"Customer {newCustomer.Name} order books worth {order.TotalAmount} on {order.OrderDate}");
            
        }
    }
}
