using CarRentalService.Data.Domains;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.

    [ServiceContract]
    public interface ICarRentalService
    {
        [OperationContract]
        void RemoveCarById(int id);

        [OperationContract]
        void RemoveBookingById(int id);

        [OperationContract]
        void AddCar(Car car);

        [OperationContract]
        void AddBooking(Booking booking);

        [OperationContract]
        void ReturnCar(int id);

        [OperationContract]
        List<Car> GetAvaliableCars(DateTime start, DateTime stop);

        [OperationContract]
        Car GetCarById(int id);

        [OperationContract]
        Booking GetBookingById(int id);

        [OperationContract]
        CustomerInfo GetCustomer(CustomerRequest customerRequest);

        [OperationContract]
        void UpdateCustomer(CustomerInfo customer);

        [OperationContract]
        void AddCustomer(CustomerInfo customer);

        [OperationContract]
        void RemoveCustomer(CustomerRequest customer);
    }
}