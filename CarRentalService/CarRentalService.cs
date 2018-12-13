using CarRentalService.Data;
using CarRentalService.Data.Domains;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarRentalService
{
    /*
      Global errorhandler takes all exceptions and turns those into FaultException  and a default message.
      all other FaultException that is produced by choice will be passed on to the client unchanged with their own messages and information.
     */

    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class CarRentalService : ICarRentalService
    {
        private DataBaseRepository dataBaseRepository = new DataBaseRepository();

        public void AddBooking(Booking booking)
        {
            dataBaseRepository.AddBooking(booking);
        }

        public void AddCar(Car car)
        {
            dataBaseRepository.AddCar(car);
        }

        public List<Car> GetAvaliableCars(DateTime start, DateTime stop)
        {
            return dataBaseRepository.AvaliableCars(start, stop);
        }

        public Booking GetBookingById(int id)
        {
            var booking = dataBaseRepository.GetBookingById(id);
            if (booking == null)
            {
                throw new FaultException("Sorry no car booking found");
            }
            return booking;
        }

        public Car GetCarById(int id)
        {
            Car car = dataBaseRepository.GetCarById(id);
            if (car == null)
            {
                throw new FaultException("Sorry no car found");
            }

            return car;
        }

        public void RemoveBookingById(int id)
        {
            dataBaseRepository.RemoveBookingById(id);
        }

        public void RemoveCarById(int id)
        {
            dataBaseRepository.RemoveCarById(id);
        }

        public void ReturnCar(int id)
        {
            dataBaseRepository.ReturnCarById(id);
        }

        public void RemoveCustomer(CustomerRequest customerRequest)
        {
            dataBaseRepository.RemoveCustomer(customerRequest);
        }

        public void UpdateCustomer(CustomerInfo customer)
        {
            dataBaseRepository.UpdateCustomer(customer);
        }

        public void AddCustomer(CustomerInfo customer)
        {
            dataBaseRepository.AddCustomer(customer);
        }

        public CustomerInfo GetCustomer(CustomerRequest customerRequest)
        {
            var customer = dataBaseRepository.GetCustomer(customerRequest);

            if (customer == null)
            {
                throw new FaultException("Sorry no car customer found");
            }
            return customer;
        }
    }
}