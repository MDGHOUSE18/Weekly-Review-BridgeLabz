using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigments.Week2
{
    /*
     You have two lists: one containing CustomerID and CustomerName, and another containing OrderID, CustomerID, and OrderAmount. 
    Write a LINQ query to:

    Join the two collections based on CustomerID.
    Use a lambda expression to select the CustomerName and OrderAmount for all orders.
    Return the result sorted by OrderAmount.
     */

    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public Customer(int customerId, string customerName)
        {
            CustomerID = customerId;
            CustomerName = customerName;
        }
    }

    class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public decimal OrderAmount { get; set; }

        public Order(int orderID, int customerID, decimal orderAmount)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderAmount = orderAmount;
        }

    }

    internal class LinqJoins
    {
        public static void Joins()
        {
            List<Customer> cutomers = CustomerInitilizer();
            List<Order> orders = OrderInitilizer();

            var result = cutomers.Join(orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c,o) => new
                {
                    CustomerName = c.CustomerName,
                    OrderAmount = o.OrderAmount
                }).OrderBy(c => c.OrderAmount);

            foreach (var res in result)
            {
                Console.WriteLine($"CutomerName : {res.CustomerName}, OrderAmount : {res.OrderAmount}");
            }
        }

        public static List<Customer> CustomerInitilizer()
        {
            return new List<Customer>()
            {

                new Customer(101,"Mahammed"),
                new Customer(102,"Ghouse"),
                new Customer(103,"Lokesh"),
                new Customer(104,"Eran"),
                new Customer(105,"Ram")
            };
        }

        public static List<Order> OrderInitilizer()
        {
            return new List<Order>()
            {
                new Order(1, 101, 1500),
                new Order(2, 102, 1250),
                new Order(3, 103, 1800),
                new Order(4, 104, 1400),
                new Order(5, 105, 2200),
                new Order(6, 101, 1750),
                new Order(7, 102, 1350),
                new Order(8, 103, 1900),
                new Order(9, 104, 2050),
                new Order(10, 105, 2000),
                new Order(11, 101, 1600),
                new Order(12, 102, 1450),
                new Order(13, 103, 2100),
                new Order(14, 104, 1650),
                new Order(15, 105, 1550),
                new Order(16, 101, 1950),
                new Order(17, 102, 1750),
                new Order(18, 103, 1700),
                new Order(19, 104, 1800),
                new Order(20, 105, 1250)
            };
        }
    }
}
