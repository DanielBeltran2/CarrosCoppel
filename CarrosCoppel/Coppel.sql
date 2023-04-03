create database Carros
use carros


create table carros(
CarID int not null,
CarMod varchar(20) not null,
CarAño int not null,
CarMarcaID int not null,
CarTipID int not null,
CarColorID int not null)
Go

create table marca(
 CarMarcaID int not null,
 CarMarca varchar(20)not null)
 Go

create table tipo(
CarTipID int not null,
CarTip varchar(20)not null)
Go


create table Color(
CarColorID int not null,
CarColor varchar(20)not null)
Go

ALTER TABLE carros ADD CONSTRAINT PK_carros_CarID PRIMARY KEY (CarID)
ALTER TABLE marca ADD CONSTRAINT PK_marca_CarMarcaID PRIMARY KEY (CarMarcaID)
ALTER TABLE tipo ADD CONSTRAINT PK_tipo_CarTipID PRIMARY KEY (CarTipID)
ALTER TABLE Color ADD CONSTRAINT PK_Color_CarColorID PRIMARY KEY (CarColorID)
GO

ALTER TABLE carros ADD CONSTRAINT FK_carros_CarMarcaID FOREIGN KEY (CarMarcaID) REFERENCES marca(CarMarcaID)
ALTER TABLE carros ADD CONSTRAINT FK_carros_CarTipID FOREIGN KEY (CarTipID) REFERENCES tipo(CarTipID)
ALTER TABLE carros ADD CONSTRAINT FK_carros_CarColorID FOREIGN KEY (CarColorID) REFERENCES Color(CarColorID)
Go

INSERT INTO marca (CarMarcaID, CarMarca) VALUES (1, 'Toyota')
INSERT INTO marca (CarMarcaID, CarMarca) VALUES (2, 'Ford')
INSERT INTO marca (CarMarcaID, CarMarca) VALUES (3, 'Chevrolet')
INSERT INTO marca (CarMarcaID, CarMarca) VALUES (4, 'Honda')
INSERT INTO marca (CarMarcaID, CarMarca) VALUES (5, 'Jeep')

INSERT INTO tipo (CarTipID, CarTip) VALUES (1, 'Sedán')
INSERT INTO tipo (CarTipID, CarTip) VALUES (2, 'SUV')
INSERT INTO tipo (CarTipID, CarTip) VALUES (3, 'Pickup')
INSERT INTO tipo (CarTipID, CarTip) VALUES (4, 'Hatchback')
INSERT INTO tipo (CarTipID, CarTip) VALUES (5, 'Convertible')

INSERT INTO Color (CarColorID, CarColor) VALUES (1, 'Rojo')
INSERT INTO Color (CarColorID, CarColor) VALUES (2, 'Azul')
INSERT INTO Color (CarColorID, CarColor) VALUES (3, 'Verde')
INSERT INTO Color (CarColorID, CarColor) VALUES (4, 'Negro')
INSERT INTO Color (CarColorID, CarColor) VALUES (5, 'Blanco')

INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (1, 'Camry', 2019, 1, 1, 1)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (2, 'Escape', 2020, 2, 2, 2)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (3, 'F-150', 2021, 2, 3, 4)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (4, 'Civic', 2018, 4, 1, 5)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (5, 'Wrangler', 2022, 5, 2, 3)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (6, 'Accord', 2019, 4, 1, 2)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (7, 'Tacoma', 2020, 1, 3, 4)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (8, 'Corolla', 2021, 1, 1, 1)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (9, 'Cherokee', 2020, 4, 2, 2)
INSERT INTO carros (CarID, CarMod, CarAño, CarMarcaID, CarTipID, CarColorID) VALUES (10, 'Silverado', 2021, 5, 3, 5)


select * from carros
select * from marca
select * from tipo
select * from Color



SELECT c.CarID AS 'Carro iD', c.CarMod AS 'Modelo', c.CarAño AS 'Año', 
m.CarMarca AS 'Marca', t.CarTip AS 'Tipo', co.CarColor AS 'Color'
FROM carros c
JOIN marca m ON c.CarMarcaID = m.CarMarcaID
JOIN tipo t ON c.CarTipID = t.CarTipID
JOIN color co ON c.CarColorID = co.CarColorID
WHERE co.CarColor LIKE '%negro%' and m.CarMarca LIKE '%yota%'
GO
   
SELECT CarID as 'Carro ID', CarMod as 'Modelo', CarAño as 'Año', marca.CarMarca as 'Marca', CarTip as 'Tipo', CarColor as 'Color' FROM carros JOIN marca ON carros.CarMarcaID = marca.CarMarcaID JOIN tipo ON carros.CarTipID = tipo.CarTipID JOIN Color ON carros.CarColorID = Color.CarColorID

ALTER PROC SP_MTTOCARROS
@CARID INT OUTPUT, @CARMOD VARCHAR(20), @CARAÑO INT, @CARMARCAID INT, @CARTIPID INT, @CARCOLORID INT AS
BEGIN
    IF EXISTS(SELECT * FROM carros WHERE CarID = @CARID)
    BEGIN
        UPDATE carros SET CarMod  = @CARMOD, CarAño  = @CARAÑO, CarMarcaID  = @CARMARCAID, CarTipID  = @CARTIPID, CarColorID  = @CARCOLORID WHERE CarID = @CARID

        IF @@ERROR <>0
        BEGIN
            RAISERROR('Error al Actualizar en la tabla Carros',16,10)
        END
    END
    ELSE
    BEGIN
        
        SELECT @CARID = COALESCE(MAX(CarID),0)+1 FROM carros

        INSERT carros VALUES(@CARID, @CARMOD, @CARAÑO, @CARMARCAID, @CARTIPID,@CARCOLORID)
        IF @@ERROR <>0
        BEGIN
            RAISERROR('Error al Actualizar en la tabla Carros',16,10)
        END
        SELECT @CARID
    END
END


Declare @CARID int
exec SP_MTTOCARROS @CARID output ,'Prius',2022,1,1,5
