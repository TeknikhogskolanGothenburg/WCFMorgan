
CREATE PROCEDURE UpdateCustomer
@Id INT,
@FirstName NvarChar(50),
@LastName NvarChar(50),
@TelephoneNumber NvarChar(50),
@Email NvarChar(50)
AS
Begin
UPDATE dbo.Customer
SET  FirstName = @FirstName,LastName=@LastName, TelephoneNumber = @TelephoneNumber, Email = @Email
WHERE Id = @Id;
END