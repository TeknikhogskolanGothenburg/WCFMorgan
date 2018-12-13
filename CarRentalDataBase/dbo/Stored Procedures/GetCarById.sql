Create procedure [GetCarById]
@Id int
as
Begin
  Select Id, LicensePlate, Brand, Model,[Year]
  from Car
  where Id = @Id
End