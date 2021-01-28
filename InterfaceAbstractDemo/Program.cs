﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServisAdapter());
            customerManager.Save(new Customer {DateOfBrith = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            Console.ReadLine();
        }
    }
}
