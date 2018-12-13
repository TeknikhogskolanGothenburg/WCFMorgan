using System.Runtime.Serialization;

namespace CarRentalService.Data.Domains
{
    [DataContract(Namespace = @"http://morgan.berglund.se/20181123/Car")]
    public class Car
    {
        public Car()
        {
        }

        private int _id;

        private string _licensePlate;

        private string _brand;

        private string _model;

        private int _year;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        [DataMember(Order = 3)]
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        [DataMember(Order = 4)]
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        [DataMember(Order = 5)]
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}