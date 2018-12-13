using CarRentalService.Data.Domains;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;

namespace CarRentalService.Data
{
    public class DataBaseRepository
    {
        private static readonly string connection = @"Data Source=MORGAN\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        private static readonly string Licensekey = @"GurkaMazurka";

        public CustomerInfo GetCustomer(CustomerRequest customerRequest)
        {
            var customer = new Customer();
            int id = customerRequest.CustomerId;

            if (customerRequest.LicenseKey == Licensekey)
            {
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    customer = db.Query<Customer>($@"exec CarRentalDataBase.dbo.GetCustomerById @Id= {id}").FirstOrDefault();
                }
            }
            else
            {
                throw new FaultException(new FaultReason("Licensekey not recognized"));
            }

            return new CustomerInfo(customer);
        }

        public Booking GetBookingById(int id)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                return db.Query<Booking>($@"exec CarRentalDataBase.dbo.GetBookingById @Id = {id}").FirstOrDefault();
            }
        }

        public Car GetCarById(int id)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                return db.Query<Car>($@"exec CarRentalDataBase.dbo.GetCarById @Id = {id}").FirstOrDefault();
            }
        }

        //Remove Car, Customer and booking By Id
        public void RemoveCarById(int id)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.RemoveCarById @Id = {id}");
            }
        }

        public void RemoveCustomer(CustomerRequest customer)
        {
            int id = customer.CustomerId;
            if (customer.LicenseKey == Licensekey)
            {
                using (var db = new SqlConnection(connection))
                {
                    db.Open();
                    db.Query($@"exec CarRentalDataBase.dbo.RemoveCustomerById @Id = {id}");
                }
            }
            else
            {
                throw new FaultException(new FaultReason("Licensekey not recognized"));
            }
        }

        public void RemoveBookingById(int id)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.RemoveBookingById @Id = {id}");
            }
        }

        //Add Booking,Car and Customer
        public void AddBooking(Booking booking)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.AddBooking @CarId = '{booking.CarId}', @CustomerId = '{booking.CustomerId}', @Start = '{booking.Start}', @Stop = '{booking.Stop}'");
            }
        }

        public void AddCar(Car car)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.AddCar @LicensePlate = '{car.LicensePlate}', @Brand = '{car.Brand}', @Model = '{car.Model}', @Year = '{car.Year}'");
            }
        }

        public void AddCustomer(CustomerInfo customer)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.AddCustomer @FirstName = '{customer.FirstName}', @LastName = '{customer.LastName}', @TelephoneNumber = '{customer.TelephoneNumber}', @Email = '{customer.Email}'");
            }
        }

        public void UpdateCustomer(CustomerInfo customer)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.UpdateCustomer  @Id = '{customer.Id}', @FirstName = '{customer.FirstName}', @LastName = '{customer.LastName}', @TelephoneNumber = '{customer.TelephoneNumber}', @Email = '{customer.Email}'");
            }
        }

        public List<Car> AvaliableCars(DateTime start, DateTime stop)
        {
            List<Car> cars = new List<Car>();
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                cars = db.Query<Car>($@"EXECUTE CarRentalDataBase.dbo.AvaliableCars '{start}','{stop}';").ToList();
            }
            return cars;
        }

        public void ReturnCarById(int id)
        {
            using (var db = new SqlConnection(connection))
            {
                db.Open();
                db.Query($@"exec CarRentalDataBase.dbo.ReturnCarById  @Id = '{id}'");
            }
        }
    }
}