using System.Runtime.Serialization;
using System.ServiceModel;

namespace CarRentalService.Data.Domains
{
    [MessageContract(IsWrapped = true,
        WrapperName = "CustomerRequestObject",
        WrapperNamespace = @"http://morgan.berglund.se/20181123/Customer")]
    public class CustomerRequest
    {
        [MessageBodyMember(Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public int CustomerId { get; set; }
    }

    [MessageContract(IsWrapped = true,
        WrapperName = "CustomerInfoObject",
        WrapperNamespace = @"http://morgan.berglund.se/20181123/Customer")]
    public class CustomerInfo
    {
        public CustomerInfo()
        {
        }

        public CustomerInfo(Customer customer)
        {
            this.Id = customer.Id;
            this.Email = customer.Email;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.TelephoneNumber = customer.TelephoneNumber;
        }

        [MessageBodyMember(Order = 1, Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public string Email { get; set; }

        [MessageBodyMember(Order = 3, Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public string FirstName { get; set; }

        [MessageBodyMember(Order = 4, Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public string LastName { get; set; }

        [MessageBodyMember(Order = 5, Namespace = @"http://morgan.berglund.se/20181123/Customer")]
        public string TelephoneNumber { get; set; }
    }

    [DataContract(Namespace = @"http://morgan.berglund.se/20181123/Customer")]
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _telephoneNumber;
        private string _email;

        public Customer()
        {
        }

        [DataMember(Order = 1)]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Order = 2)]
        public string FirstName { get => _firstName; set => _firstName = value; }

        [DataMember(Order = 3)]
        public string LastName { get => _lastName; set => _lastName = value; }

        [DataMember(Order = 4)]
        public string TelephoneNumber { get => _telephoneNumber; set => _telephoneNumber = value; }

        [DataMember(Order = 5)]
        public string Email { get => _email; set => _email = value; }
    }
}