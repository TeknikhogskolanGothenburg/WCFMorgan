﻿CREATE PROCEDURE ReturnCarById
@Id INT,
@currDate DATETIME = GETDATE
AS
BEGIN
UPDATE dbo.Booking
SET Stop = @currDate
WHERE Id=@Id;
END