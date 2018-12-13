Create procedure [GetBookingById]
@Id int
as
Begin
  Select Id, CarId, CustomerId, [Start], [Stop]
  from Booking
  where Id = @Id
End