﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public Customer this[int i]
        {
            get
            {
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        public Customer this[string email]
        {
            get
            {
                foreach (Customer c in customers)
                {
                    if (c.Email == email)
                        return c;
                }

                return null;
            }
        }

        public Customer GetCustomer(string email)
        {
            foreach(Customer c in customers)
            {
                if (c.Email == email)
                    return c;
            }
            Customer custError = new Customer();
            return custError;
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(int id, string fName, string lName, string email, string phone)
        {
            Customer c = new Customer(id, fName, lName, email, phone);
            customers.Add(c);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator +(Customer c, CustomerList cl)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }

        public static CustomerList operator -(Customer c, CustomerList cl)
        {
            cl.Remove(c);
            return cl;
        }

        public override string ToString()
        {
            string output = "";
            foreach(Customer c in customers)
                output += c.ToString() + "\n";
            return output;
        }
    }
}
