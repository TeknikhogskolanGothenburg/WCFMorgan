using CarRentalService.Data;
using CarRentalService.Data.Domains;
using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarRentalService
{
    public class CarRentalRestService : ICarRentalWeb
    {
        private DataBaseRepository dataBaseRepository = new DataBaseRepository();

        public CarRentalRestService()
        {
        }

        public void AddBooking(Booking booking)
        {
            try
            {
                dataBaseRepository.AddBooking(booking);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to add a booking to Database", HttpStatusCode.InternalServerError);
            }
        }

        public void AddCar(Car car)
        {
            try
            {
                dataBaseRepository.AddCar(car);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to add a car to Database", HttpStatusCode.InternalServerError);
            }
        }

        public List<Car> GetAvaliableCars(string starttime, string stoptime)
        {
            try
            {
                return dataBaseRepository.AvaliableCars(Convert.ToDateTime(starttime), Convert.ToDateTime(stoptime));
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to get a list of cars from Database", HttpStatusCode.InternalServerError);
            }
        }

        public void RemoveCustomer(CustomerRequest customerRequest)
        {
            try
            {
                dataBaseRepository.RemoveCustomer(customerRequest);
            }
            catch (FaultException ex)
            {
                throw new WebFaultException<string>(ex.Reason.ToString(), HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to remove customer from Database", HttpStatusCode.InternalServerError);
            }
        }

        public void UpdateCustomer(CustomerInfo customer)
        {
            try
            {
                dataBaseRepository.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to update customer to Database ", HttpStatusCode.InternalServerError);
            }
        }

        public void AddCustomer(CustomerInfo customer)
        {
            try
            {
                dataBaseRepository.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to add customer to Database ", HttpStatusCode.InternalServerError);
            }
        }

        public CustomerInfo GetCustomer(string customerId, string license)
        {
            int id;
            bool success = int.TryParse(customerId, out id);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            CustomerInfo customerInfo = new CustomerInfo();
            CustomerRequest customerRequest = new CustomerRequest();
            customerRequest.LicenseKey = license;
            customerRequest.CustomerId = id;

            try
            {
                customerInfo = dataBaseRepository.GetCustomer(customerRequest);
            }
            catch (FaultException ex)
            {
                throw new WebFaultException<string>(ex.Reason.ToString(), HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to get customer from Database ", HttpStatusCode.InternalServerError);
            }
            if (customerInfo == null)
            {
                throw new WebFaultException<string>("Sorry no customer found at position " + customerId, HttpStatusCode.InternalServerError);
            }

            return customerInfo;
        }

        public Car GetCarById(string id)
        {
            Car car = new Car();
            int idConverted;
            bool success = int.TryParse(id, out idConverted);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            try
            {
                car = dataBaseRepository.GetCarById(idConverted);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to get car from Database ", HttpStatusCode.InternalServerError);
            }
            if (car == null)
            {
                throw new WebFaultException<string>("Sorry no car found at positon" + id, HttpStatusCode.InternalServerError);
            }

            return car;
        }

        public void RemoveCarById(string id)
        {
            int idConverted;
            bool success = int.TryParse(id, out idConverted);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            try
            {
                dataBaseRepository.RemoveCarById(idConverted);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to delete at position " + id, HttpStatusCode.InternalServerError);
            }
        }

        public void ReturnCar(string id)
        {
            int idConverted;
            bool success = int.TryParse(id, out idConverted);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            try
            {
                dataBaseRepository.ReturnCarById(idConverted);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to return at booking position " + id, HttpStatusCode.InternalServerError);
            }
        }

        public void RemoveBookingById(string id)
        {
            int idConverted;
            bool success = int.TryParse(id, out idConverted);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            try
            {
                dataBaseRepository.RemoveBookingById(idConverted);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to delete at position " + id, HttpStatusCode.InternalServerError);
            }
        }

        public Booking GetBookingById(string id)
        {
            Booking booking = new Booking();
            int idConverted;
            bool success = int.TryParse(id, out idConverted);
            if (success == false)
            {
                throw new WebFaultException<string>("Please input a number instead ", HttpStatusCode.BadRequest);
            }

            try
            {
                booking = dataBaseRepository.GetBookingById(idConverted);
            }
            catch (Exception ex)
            {
                SaveException.Log("webErrors.txt", ex);
                throw new WebFaultException<string>("Sorry something went wrong when trying to get booking from Database ", HttpStatusCode.InternalServerError);
            }
            if (booking == null)
            {
                throw new WebFaultException<string>("Sorry no booking found at position " + id, HttpStatusCode.InternalServerError);
            }

            return booking;
        }
    }
}