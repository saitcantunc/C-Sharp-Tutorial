using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1 : "+ sayi1); // Sayı birin değeri kaç olur?

            ////arrays,class,interface... reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]); //Sayılar birin ilk endeksindeki değer nedir?

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;          //Person 2'nin referans değerini person1'e eşitliyoruz.
            person1.FirstName = "Derin"; //Person 2'ninde FirstName değeri Derin olarak değişir.
            
            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;  //Customer bir person olduğu için bu eşitlemeyi yapabiliyoruz.
            customer.FirstName = "Ahmet";




            Console.WriteLine(((Customer) person3).CreditCardNumber); // Person3.CreditCardNumbers'a ulaşmak için yapılan boxing işlemi.
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    //base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmloyeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
