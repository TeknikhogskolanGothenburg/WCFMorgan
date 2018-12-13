using CarRentalService.Data.Domains;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarRentalService
{
    [ServiceContract]
    public interface ICarRentalWeb
    {
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/CUSTOMER",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateCustomer(CustomerInfo customer);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/CUSTOMER",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void RemoveCustomer(CustomerRequest customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CUSTOMER", RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json)]
        void AddCustomer(CustomerInfo customer);

        [OperationContract]
        [FaultContract(typeof(WebFaultException))]
        [WebInvoke(Method = "GET", UriTemplate = "/CUSTOMER/{CustomerId}/{License}",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        CustomerInfo GetCustomer(string customerId, string license);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CAR/avaliable/{starttime}/{stoptime}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAvaliableCars(string starttime, string stoptime);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/CAR/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Car GetCarById(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/CAR/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void RemoveCarById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CAR",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void AddCar(Car car);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/CAR/returnCarByBookngId/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void ReturnCar(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/BOOKING/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void RemoveBookingById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/BOOKING/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Booking GetBookingById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/BOOKING",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void AddBooking(Booking booking);
    }
}