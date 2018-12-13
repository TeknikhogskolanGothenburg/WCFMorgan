CREATE PROCEDURE AddCustomer
@FirstName NvarChar(50),
@LastName NvarChar(50),
@TelephoneNumber NvarChar(50),
@Email NvarChar(50)
as
Begin 
Insert into dbo.Customer
VALUES (@FirstName, @LastName,@TelephoneNumber,@Email)
End