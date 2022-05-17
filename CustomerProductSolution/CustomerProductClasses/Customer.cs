using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;

        public Customer()
        {
            firstName = "Anonymous";
            lastName = "Anon";
        }

        public Customer(int id, string fName, string lName, string email, string phone)
        {
            this.id = id;
            firstName = fName;
            lastName = lName;
            this.email = email;
            this.phone = phone;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Id: {0} FIrst Name: {1} Last Name: {2} Email: {3:C} Phone Number: {4}", id, firstName, lastName, email, phone);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            else
            {
                Customer other = (Customer)obj;
                return other.Id == Id &&
                    other.FirstName == FirstName &&
                    other.LastName == LastName &&
                    other.Email == Email &&
                    other.Phone == Phone;
            }
        }

        public override int GetHashCode()
        {
            return 13 + 7 * id.GetHashCode() +
                7 * firstName.GetHashCode() +
                7 * lastName.GetHashCode() +
                7 * email.GetHashCode() +
                7 * phone.GetHashCode();
        }
        
    }
}
