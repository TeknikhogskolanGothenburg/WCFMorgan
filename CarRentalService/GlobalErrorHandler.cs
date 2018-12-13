using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace CarRentalService
{
    //Global error handler to sheild information that might be used for nefarius deeds of the client.
    public class GlobalErrorHandler : IErrorHandler
    {
        // Place to add logging of faults that occurs this is an async call, will not be a performance problem
        // I chosed to just dump into a file the prefered method for real projects is probably to
        // make the dump into a database table
        public bool HandleError(Exception error)
        {
            Exception ex = error;
            SaveException.Log(@"Error.txt", ex);

            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            //passes on FaultExceptions back to client.
            if (error is FaultException)
                return;
            //messageFault contains what SOAP version that is used at the moment
            FaultException faultException = new FaultException("A General service error occured");
            MessageFault messageFault = faultException.CreateMessageFault();
            fault = Message.CreateMessage(version, messageFault, null);
        }
    }
}