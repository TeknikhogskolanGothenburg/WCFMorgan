using System;
using System.Runtime.Serialization;

namespace CarRentalService.Data.Domains
{
    [DataContract(Namespace = @"http://morgan.berglund.se/20181123/Booking")]
    public class Booking
    {
        public Booking()
        {
        }

        private int _id;
        private int _carId;
        private int _rustomerID;
        private DateTime _start;
        private DateTime _stop;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public int CarId
        {
            get { return _carId; }
            set { _carId = value; }
        }

        [DataMember(Order = 3)]
        public int CustomerId
        {
            get { return _rustomerID; }
            set { _rustomerID = value; }
        }

        [DataMember(Order = 4)]
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        [DataMember(Order = 5)]
        public DateTime Stop
        {
            get { return _stop; }
            set { _stop = value; }
        }
    }
}