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

        private void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private void SetEmailAddress(string emailAddress)
        {
            _emailAddress = emailAddress;
        }

        private void SetDateOfBirth(DateTime dateOfBirth)
        {
            _dateOfBirth = DateOnly.FromDateTime(dateTime: dateOfBirth);
        }

        private void Validate()
        {
            if (_firstName.Length > 40)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "Must have a maximum of 40 characters (FirstName).";
            }
            if (_lastName.Length > 40)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "Must have a maximum of 40 characters (LastName).";
            }

            DateTime dateNow = DateTime.Now;

            if (_dateOfBirth.ToDateTime(TimeOnly.MinValue).ToUniversalTime().Date > dateNow.Date)
            {
                _isValid = false;
                ErrorMessageIfIsNotValid = "You cannot put the date with the day after today.";
            }

            if (ErrorMessageIfIsNotValid == string.Empty)
            {
                _isValid = true;
            }
        }
    }
}