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
    }
}