using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TestProductConstructors();
            TestProductToString();
            TestProductPropertyGetters();
            TestProductPropertySetters();
            
            TestCustomertConstructors();
            TestCustomerToString();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
            
            TestProductListConstructor();
            TestProductListAdd();
            */

            TestCustomerListConstructors();
            TestAddAndDelete();
            TestFillAndSave();
            TestCount();
            TestEquals();
            TestIndexers();
        }

        static public void TestCustomerListConstructors()
        {
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");
            Customer c3 = new Customer();
            CustomerList cl1 = new CustomerList();

            Console.WriteLine("Testing product list default constructor");
            Console.WriteLine("Count.  Expecting 0. " + cl1.Count);
            Console.WriteLine("ToString.  Expect an empty string. " + cl1.ToString());
            Console.WriteLine();
        }

        static public void TestAddAndDelete()
        {
            CustomerList cl1 = new CustomerList();
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");

            Console.WriteLine("Testing add and delete customers");
            cl1.Add(c1);
            Console.WriteLine("Expecting 1 Fred Phillips freddPhil@gmail.com 098-765-4321: " + cl1.ToString());
            Console.WriteLine("Expecting 1: " + cl1.Count);
            cl1 += c2;
            Console.WriteLine("Expecting 2 customers: " + cl1.ToString());
            Console.WriteLine("Expecting 2: " + cl1.Count);
            cl1 -= c2;
            Console.WriteLine("Expecting only 1 Fred Phillips freddPhil@gmail.com 098-765-4321: " + cl1.ToString());
            Console.WriteLine("Expecting 1: " + cl1.Count);
        }

        static public void TestFillAndSave()
        {
            CustomerList cl = new CustomerList();
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");
            cl.Add(c1);
            cl += c2;
            cl.Save();

            cl = new CustomerList();
            cl.Fill();
            Console.WriteLine("Testing customer list save and fill.");
            Console.WriteLine("After Fill Count.  Expecting 2. " + cl.Count);
            Console.WriteLine("ToString.  Expect two customers " + cl.ToString());
            Console.WriteLine();
        }

        static public void TestCount()
        {
            CustomerList cl = new CustomerList();
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");
            cl.Add(c1);
            cl += c2;

            Console.WriteLine("Testing count method in customer list");
            Console.WriteLine("Expected count of 2: " + cl.Count);

            cl -= c2;
            Console.WriteLine("Expected count of only 1: " + cl.Count);
        }

        static public void TestEquals()
        {
            CustomerList cl = new CustomerList();
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c3 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");
            cl += c1;
            cl += c2;
            cl += c3;

            Console.WriteLine("Testing equals method");
            Console.WriteLine("Expecting True: " + c1.Equals(c2));
            Console.WriteLine("Expecting False: " + c1.Equals(c3));
        }

        static public void TestIndexers()
        {
            CustomerList cl = new CustomerList();
            Customer c1 = new Customer(1, "Fred", "Phillips", "freddyPhil@gmail.com", "098-765-4321");
            Customer c2 = new Customer(2, "Edward", "Evans", "EddieE@hotmail.com", "123-456-7890");
            cl += c1;
            cl += c2;

            Console.WriteLine("Testing Indexer by Array");
            Console.WriteLine("Expecting Customer Fred: " + cl[0].ToString());

            Console.WriteLine("Testing Indexer by email");
            Console.WriteLine("Expecting Customer Edward: " + cl["EddieE@hotmail.com"].ToString());

            Customer c3 = new Customer(3, "Marcus", "Wilson", "MarkShark@email.com", "246-802-4680");
            cl[0] = c3;
            Console.WriteLine("Testing chaninging customer based on index");
            Console.WriteLine("Expecting Marcus Customer: " + cl[0].ToString());
        }



        /*Old Testers
        static void TestProductListConstructor()
        {
            ProductList list = new ProductList();

            Console.WriteLine("Testing product list default constructor");
            Console.WriteLine("Count.  Expecting 0. " + list.Count);
            Console.WriteLine("ToString.  Expect an empty string. " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductListAdd()
        {
            ProductList list = new ProductList();
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);
            Product p2 = new Product(2, "T200", "This is a test product 2", 200M, 20);

            Console.WriteLine("Testing product list add.");
            Console.WriteLine("BEFORE Count.  Expecting 0. " + list.Count);
            list.Add(p1);
            Console.WriteLine("AFTER Add Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect one product " + list.ToString());
            list += p2;
            Console.WriteLine("AFTER Second Add Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString.  Expect two products " + list.ToString());
            Console.WriteLine();
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();
            Product p2 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, T100, 100, This is a test product, 10 " + p2.ToString());
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1.ToString());
            Console.WriteLine("Expecting 1, T100, 100, This is a test product, 10 " + p1);
            Console.WriteLine();
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Id.  Expecting 1. " + p1.Id);
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.UnitPrice);
            Console.WriteLine("Quantity.  Expecting 10. " + p1.QuantityOnHand);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product(1, "T100", "This is a test product", 100M, 10);

            Console.WriteLine("Testing setters");
            p1.Id = 2;
            p1.Code = "T000";
            p1.Description = "First product";
            p1.UnitPrice = 200;
            p1.QuantityOnHand = 20;
            Console.WriteLine("Expecting 2, T000, 200, First product, 20 " + p1);
            Console.WriteLine();
        }

        //Test Methods for Customer classes
        static void TestCustomertConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer(1, "Andrew", "Simmons", "asimmons@email.com", "541-822-7899");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 1, Andrew, Simmons, asimmons@gmail.com, 541-822-7899 " + c2.ToString());
            Console.WriteLine();
        }

        static void TestCustomerToString()
        {
            Customer c1 = new Customer(1, "Andrew", "Simmons", "asimmons@email.com", "541-822-7899");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 1, Andrew, Simmons, asimmons@gmail.com, 541-822-7899 " + c1.ToString());
            Console.WriteLine("Expecting 1, Andrew, Simmons, asimmons@gmail.com, 541-822-7899 " + c1);
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer(1, "Andrew", "Simmons", "asimmons@email.com", "541-822-7899");

            Console.WriteLine("Testing getters");
            Console.WriteLine("Id.  Expecting 1. " + c1.Id);
            Console.WriteLine("First Name.  Expecting Andrew. " + c1.FirstName);
            Console.WriteLine("Last Name.  Expecting Simmons. " + c1.LastName);
            Console.WriteLine("Email.  Expecting aimmons@gmail.com. " + c1.Email);
            Console.WriteLine("Phone Number.  Expecting 541-822-7899. " + c1.Phone);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer(1, "Andrew", "Simmons", "asimmons@email.com", "541-822-7899");

            Console.WriteLine("Testing setters");
            c1.Id = 2;
            c1.FirstName = "Andy";
            c1.LastName = "Kent";
            c1.Email = "akent@hotmail.com";
            c1.Phone = "541-228-9987";
            Console.WriteLine("Expecting 2, Andy, Kent, akent@hotmail.com, 54-228-9987 " + c1);
            Console.WriteLine();
        }
        */
    }
}
