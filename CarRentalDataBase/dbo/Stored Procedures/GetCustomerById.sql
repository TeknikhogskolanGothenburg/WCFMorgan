Create procedure [GetCustomerById]
@Id int
as
Begin
  Select Id, FirstName, LastName, TelephoneNumber, Email
  from Customer
  where Id = @Id
End