CREATE PROCEDURE AddBooking
@CarId INT = null,
@CustomerId INT = null,
@Start DateTime,
@Stop DateTime
AS
BEGIN
INSERT INTO dbo.Booking
	VALUES(@CarId, @CustomerId, @Start, @Stop)
END 
