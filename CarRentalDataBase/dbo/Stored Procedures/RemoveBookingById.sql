﻿CREATE PROCEDURE RemoveBookingById
@Id INT
AS
BEGIN
DELETE FROM dbo.Booking WHERE Id=@Id;
END