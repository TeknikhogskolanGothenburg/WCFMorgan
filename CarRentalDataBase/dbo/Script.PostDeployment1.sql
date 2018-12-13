/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/*******  SEED DATA FOR CUSTOMER TABLE **************/
INSERT INTO Customer VALUES ('Adam', 'Adamsson' , '+1-202-555-0198', 'Adam@example.com');
INSERT INTO Customer VALUES ('Bertil', 'Bertilsson' , '+1-202-555-0187', 'Bertil@example.com');
INSERT INTO Customer VALUES ('Cesar', 'Cesarsson' , '+1-202-555-0105', 'Cesar@example.com');
INSERT INTO Customer VALUES ('David', 'Davidsson' , '+1-202-555-0125', 'David@example.com');
INSERT INTO Customer VALUES ('Erik', 'Eriksson' , '+1-202-555-0125', 'Erik@example.com');
INSERT INTO Customer VALUES ('Filip', 'Filipsson' , '+1-202-555-0194', 'Filip@example.com');
INSERT INTO Customer VALUES ('Gustav', 'Gustavsson' , '+1-202-555-0149', 'Gustav@example.com');
INSERT INTO Customer VALUES ('Helge', 'Helgesson' , '+1-202-555-0124', 'Helge@example.com');
INSERT INTO Customer VALUES ('Ivar', 'Ivarsson' , '+1-202-555-0139', 'Ivar@example.com');
INSERT INTO Customer VALUES ('Johan', 'Johansson' , '+1-202-555-0178', 'Johan@example.com');
INSERT INTO Customer VALUES ('Kalle', 'Kallesson' , '+1-202-555-0140', 'Kalle@example.com');
INSERT INTO Customer VALUES ('Ludvig', 'Ludvigsson' , '+1-202-555-0122', 'Ludvig@example.com');
INSERT INTO Customer VALUES ('Martin', 'Martinsson' , '+1-202-555-0134', 'Martin@example.com');
INSERT INTO Customer VALUES ('Niklas', 'Niklassson' , '+1-202-555-0146', 'Niklas@example.com');
INSERT INTO Customer VALUES ('Olof', 'Olofsson' , '+1-202-555-0115', 'Olof@example.com');
INSERT INTO Customer VALUES ('Petter', 'Pettersson' , '+1-202-555-0126', 'Petter@example.com');
INSERT INTO Customer VALUES ('Quintus', 'Quintussson' , '+1-202-555-0120', 'Quintus@example.com');
INSERT INTO Customer VALUES ('Rudolf', 'Rudolfsson' , '+1-202-555-0156', 'Rudolf@example.com');
INSERT INTO Customer VALUES ('Sigurd', 'Sigurdsson' , '+1-202-555-0175', 'Sigurd@example.com');
INSERT INTO Customer VALUES ('Tore', 'Toresson' , '+1-202-555-0182', 'Tore@example.com');
INSERT INTO Customer VALUES ('Urban', 'Urbansson' , '+1-202-555-0103', 'Urban@example.com');
INSERT INTO Customer VALUES ('Viktor', 'Viktorsson' , '+1-202-555-0179', 'Viktor@example.com');
INSERT INTO Customer VALUES ('Xerxes', 'Xerxessson' , '+1-202-555-0155', 'Xerxes@example.com');
INSERT INTO Customer VALUES ('Yngve', 'Yngvesson' , '+1-202-555-0111', 'Yngve@example.com');
INSERT INTO Customer VALUES ('Zäta', 'Zätasson' , '+1-202-555-0163', 'Zäta@example.com');
INSERT INTO Customer VALUES ('Åke', 'Åkesson' , '+1-202-555-0185', 'Åke@example.com');
INSERT INTO Customer VALUES ('Ärlig', 'Ärligsson' , '+1-202-555-0149', 'Ärlig@example.com');
INSERT INTO Customer VALUES ('Östen', 'Östensson' , '+1-202-555-0189', 'Östen@example.com');




/*******  SEED DATA FOR CAR TABLE **************/
INSERT INTO [Car] VALUES ('WXX542','Volvo', 'XC90',2013);
INSERT INTO [Car] VALUES ('RUY033','Volvo','S60',2013 );
INSERT INTO [Car] VALUES ('BDU671','Toyota', 'Venza',2013);
INSERT INTO [Car] VALUES ('ULB577','Subaru', 'BRZ',2013);
INSERT INTO [Car] VALUES ('JCY563','Rolls-Royce', 'Phantom',2013);
INSERT INTO [Car] VALUES ('ZGO112','Mazda', 'MAZDA6',2013);
INSERT INTO [Car] VALUES ('MIF543','Mazda', 'CX-5',2013);
INSERT INTO [Car] VALUES ('UBV101','Lincoln', 'MKX',2013);
INSERT INTO [Car] VALUES ('TGV363','Lexus', 'RX',2013);
INSERT INTO [Car] VALUES ('ZIA924','Ford', 'Focus',2012);
INSERT INTO [Car] VALUES ('UOQ434','Hyundai', 'Azera',2012);
INSERT INTO [Car] VALUES ('MXN692','Hyundai', 'Equus',2012);
INSERT INTO [Car] VALUES ('LEE723','Hyundai', 'Tucson',2012);
INSERT INTO [Car] VALUES ('EFP013','Saab', '9-4X',2011);
INSERT INTO [Car] VALUES ('UBB426','Audi', 'Q7',2007);
INSERT INTO [Car] VALUES ('KQW398','Ford', 'Explorer Sport Trac',2007);
INSERT INTO [Car] VALUES ('LPI331','Chevrolet', 'Silverado',2007);
INSERT INTO [Car] VALUES ('BUH519','Hummer', 'H2 SUT',2007);
INSERT INTO [Car] VALUES ('MLJ109','Volkswagen', 'New Beetle',2006);
INSERT INTO [Car] VALUES ('NTA219','Bentley', 'Continental GT',2006);
INSERT INTO [Car] VALUES ('VBA143','GMC', 'Savana 3500',2005);
INSERT INTO [Car] VALUES ('JVV208','Mitsubishi', 'Lancer Evolution',2005);
INSERT INTO [Car] VALUES ('WMT777','Suzuki', 'Swift',2005);
INSERT INTO [Car] VALUES ('NYZ392','Pontiac', 'Bonneville',2005);
INSERT INTO [Car] VALUES ('RNH686','Acura', 'MDX',2005);
INSERT INTO [Car] VALUES ('YKZ595','Volvo', 'XC70',2004);
INSERT INTO [Car] VALUES ('LFN555','Chevrolet', 'Impala',2004);
INSERT INTO [Car] VALUES ('GJE657','Volkswagen', 'Golf',2004);
INSERT INTO [Car] VALUES ('PFE163','Subaru', 'Outback',2004);
INSERT INTO [Car] VALUES ('YWY196','Honda', 'Odyssey',2004);
INSERT INTO [Car] VALUES ('SPJ329','Honda', 'Civic',2004);
INSERT INTO [Car] VALUES ('YLW047', 'Porsche', '911',2004);
INSERT INTO [Car] VALUES ('VUZ152','Ford', 'Crown Victoria',2002);
INSERT INTO [Car] VALUES ('XIA211','Ford', 'Mustang',2002);


/*******  SEED DATA FOR BOOKING TABLE **************/
INSERT INTO [Booking] VALUES (1,18,'2018-9-10','2018-12-23');
INSERT INTO [Booking] VALUES (2,17,'2018-7-10','2018-9-23');
INSERT INTO [Booking] VALUES (3,16,'2018-8-10','2018-9-23');
INSERT INTO [Booking] VALUES (4,15,'2018-4-10','2018-5-23');
INSERT INTO [Booking] VALUES (5,14,'2018-9-10','2018-10-23');
INSERT INTO [Booking] VALUES (6,13,'2018-10-10','2018-11-23');
INSERT INTO [Booking] VALUES (7,12,'2018-11-10','2018-11-23');
INSERT INTO [Booking] VALUES (8,11,'2018-9-10','2018-10-23');
INSERT INTO [Booking] VALUES (9,10,'2018-3-10','2018-5-23');
INSERT INTO [Booking] VALUES (10,9,'2018-5-10','2018-7-23');
INSERT INTO [Booking] VALUES (11,8,'2018-8-10','2018-9-23');
INSERT INTO [Booking] VALUES (12,7,'2018-9-10','2018-10-23');
INSERT INTO [Booking] VALUES (13,6,'2018-4-10','2018-12-23');
INSERT INTO [Booking] VALUES (14,5,'2018-1-10','2018-4-23');
INSERT INTO [Booking] VALUES (15,4,'2018-2-10','2018-5-23');
INSERT INTO [Booking] VALUES (16,3,'2018-3-10','2018-6-23');
INSERT INTO [Booking] VALUES (17,2,'2018-5-10','2018-8-23');
INSERT INTO [Booking] VALUES (18,1,'2018-1-10','2018-2-23');
