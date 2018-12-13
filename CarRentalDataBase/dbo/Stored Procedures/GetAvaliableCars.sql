CREATE PROCEDURE AvaliableCars
@StartDate DateTime,
@StopDate DateTime
AS
BEGIN
SELECT * FROM CarRentalDataBase.dbo.Car WHERE CarRentalDataBase.dbo.Car.Id NOT IN (SELECT Car.Id FROM CarRentalDataBase.dbo.Car JOIN CarRentalDataBase.dbo.Booking
ON Car.Id = CarRentalDataBase.dbo.Booking.CarId WHERE (((CarRentalDataBase.dbo.Booking.Start > @StartDate) AND (CarRentalDataBase.dbo.Booking.Stop < @StopDate)))) 
END

