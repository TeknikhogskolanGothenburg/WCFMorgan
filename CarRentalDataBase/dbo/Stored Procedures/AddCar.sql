CREATE PROCEDURE AddCar
@LicensePlate nvarchar(10),
@Brand nvarchar(50) = null,
@Model nvarchar(50) = null,
@Year int =null
AS
BEGIN
INSERT INTO dbo.Car
VALUES(@LicensePlate, @Brand, @Model, @Year)
End