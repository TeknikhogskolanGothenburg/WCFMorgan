
# WCF project CarRentalService,  written by _Morgan Berglund_

* Endpoints included basicHttpBinding,wsHttpBinding,netTcpBinding, mexHttpBinding and webHttpBinding.
* ServiceContract, OperationContract, DataContract, DataMember and Message Contract included.
* Inheritance in was not used so no KnownTypes included.
* Exception handling SOAP: CarRentalService FaultException,GlobalErrorHandler and on REST: CarRentalRestService WebFaultException.
* Rest API included.
* Simple examples of security included.
* Database with stored procedures and seed values included
* Dapper interaction with database and injection safety.
* No clients included.

## Structure of the CarRental Project

![Morgan Berglund WCF project Picture](https://github.com/TeknikhogskolanGothenburg/WCFMorgan/blob/master/MorganBerglundWCF.png?raw=true "Morgan Berglund WCF project")

## Details

### CarRentalServiceFormsHost,App.config

```WCFEndpoints
basicHttpBinding no extra configuration.
wsHttpBinding:  security mode="Transport" and clientCredentialType="Windows".

    Details about netTcpBinding:
     <binding name="netTcp">
          <!-- currently security mode off to view FaultExceptions better.-->
          <security mode="None" />

          <!--   <security mode="Message">
            <message clientCredentialType="Windows" />
          </security>-->
    </binding>

    In order to view details in exceptions:
             <behavior name="mexBehavior">
          <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true" />
          <serviceDebug includeExceptionDetailInFaults="true" />
        </behavior>

```

### CarRentalFormsRestHost,App.config

```WCFEndpoints
webHttpBinding:
endpoint
address="rest"
binding="webHttpBinding"
contract="CarRentalService.ICarRentalWeb"
behaviorConfiguration="restbehavior"
 <behavior name="restbehavior">
          <webHttp />
</behavior>
```

### REST

```REST
ServiceContract and OperationContract
CarRentalservice,ICarRentalWeb

```

### SOAP

```SOAP
ServiceContract and OperationContract
CarRentalservice,ICarRentalService

```

### Common to Soap and REST hosts

```COMMON
DataContract, DataMember and Message Contract.
Location in files.
CarRentalService.Data.Domains
Booking.cs,Car.cs and Customer.cs
Message contract only in Customer.cs

```

### Database

```Database
Database T-sql easy to deploy with stored procedures and seed values to test methods and exceptions.
Change connection string in CarRentalService.Data,DataBaseRepository.cs to your local produced version.
To access database stored procedures i've used Dapper for the project.
```

### SOAP Exceptions

```SoapExceptions
GlobalExceptionHandler with IErrorHandler interface implemented with simple logger.
FaultExceptions is let through the GlobalExceptionHandler unchanged.
The rest of all Exceptions are changed into FaultExceptions and passed on with default 
message to shield information to client.
The thought is to let none sensitive information out of the server.
Most of the filtering exceptions and handling is found in.
CarRentalService\CarRentalService.cs

When soap based host is run exceptions is logged into errors.txt.

```

### Web Exceptions

```WebExceptions
Since I didn't really make an GlobalExceptionHandler with IErrorInterface version for web exception.
A simpler strategy was implemented with the same thought. Turn FaultExceptions and exceptions into
WebFaultException and pass those on to the client side.
All Exceptions that makes it to the last "Catch em all" (Catch(Exception ex)) is logged and throws a general
less descriptive WebFaultException back to the client. This is also to shield from sensitive information
passed on to the client.Most of the filtering exceptions handling is found in.
CarRentalService\CarRentalRestService.cs

When web based host is run exceptions is logged into weberrors.txt.
```

Project by _Morgan Berglund_
