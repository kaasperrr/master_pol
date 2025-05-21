CREATE TABLE PartnerTypes (
    IdPartnerType INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE
);


CREATE TABLE Partners (
    IdPartner INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    IdPartnerType INT NOT NULL,
    Rating INT CHECK (Rating >= 0),
    Address NVARCHAR(500),
    DirectorFirstName NVARCHAR(100),
    DirectorMiddleName NVARCHAR(100),
    DirectorLastName NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(255),
    FOREIGN KEY (IdPartnerType) REFERENCES PartnerTypes(IdPartnerType)
);


CREATE TABLE ProductTypes (
    IdProductType INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Products (
    IdProduct INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    IdProductType INT NOT NULL,
    FOREIGN KEY (IdProductType) REFERENCES ProductTypes(IdProductType)
);

CREATE TABLE Sales (
    IdSale INT IDENTITY(1,1) PRIMARY KEY,
    IdPartner INT NOT NULL,
    IdProduct INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    SaleDate DATE NOT NULL,
    FOREIGN KEY (IdPartner) REFERENCES Partners(IdPartner),
    FOREIGN KEY (IdProduct) REFERENCES Products(IdProduct)
);