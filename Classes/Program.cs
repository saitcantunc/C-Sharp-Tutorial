using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Update();
            productManager.Add();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin"; // set işlemidir
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName); // get işlemidir.


            Console.ReadLine();
        }
    }

    

    
}
