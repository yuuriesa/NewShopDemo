using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;

namespace NewShopDemo.Models
{
    public class Customer
    {
        // private properties
        private string _firstName;
        private string _lastName;
        private string _emailAddress;
        private DateOnly _dateOfBirth;
        //private ICollection<Address> _addresses = new List<Address>();
        private bool _isValid { get; set; } = false;

        // public properties
        public int CustomerId { get; private set; }
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string EmailAddress => _emailAddress;
        public DateOnly DateOfBirth => _dateOfBirth;
        //public ICollection<Address> Addresses => _addresses;
        //public ICollection<Order> Orders { get; set; } = new List<Order>();
        public string ErrorMessageIfIsNotValid { get; private set; } = string.Empty;

        // constructors
        private Customer()
        {

        }
        private Customer
        (
            int customerId,
            string firstName,
            string lastName,
            string emailAddress,
            DateOnly dateOfBirth
        )
        {
            CustomerId = customerId;
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;

            //Validate()
        }

        // public methods
        public static Customer RegisterNew
        (
            string firstName,
            string lastName,
            string emailAddress,
            DateTime dateOfBirth
        )
        {
            Customer customer = new Customer();
            //customer.SetFirstName(firstName: firstName);
            //customer.SetLastName(lastName: lastName);
            //customer.SetEmailAddress(emailAddress: emailAddress);
            //customer.SetDateOfBirth(dateOfBirth: dateOfBirth);
            //customer.Validate();

            return customer;
        }

        public static Customer SetExistingInfo
        (
            int customerId,
            string firstName,
            string lastName,
            string emailAddress,
            DateOnly dateOfBirth
        )
        {
            Customer customer = new Customer
            (
                customerId: customerId,
                firstName: firstName,
                lastName: lastName,
                emailAddress: emailAddress,
                dateOfBirth: dateOfBirth
            );

            return customer;
        }

        public bool IsValid()
        {
            return _isValid;
        }

        // private methods
        private void SetCustomerId(int customerId)
        {
            if (customerId < 1)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "CustomerId must be greater than zero.";
            }
            CustomerId = customerId;
        }

        private void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
    }
}