using System.Net.Sockets;

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
    }
}