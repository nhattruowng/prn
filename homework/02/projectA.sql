create database ClothesShop
go
create table Users
(
    id        INT                      NOT NULL IDENTITY (1,1),
    email     NVARCHAR(50) PRIMARY KEY NOT NULL,
    firstname NVARCHAR(30)             NOT NULL,
    lastname  NVARCHAR(30)             NOT NULL,

    avatar    VARBINARY(MAX)           Not null,
    username  VARCHAR(30)              NOT NULL,
    password  VARCHAR(64)              NOT NULL,
    address   NVARCHAR(200)            NOT NULL,
    phone     NVARCHAR(15)             NOT NULL,
    roleid    INT                      NOT NULL,
    status    BIT                      NOT NULL,
)
go
CREATE TABLE Types
(
    id   INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    name NVARCHAR(100)
)
go
go
CREATE TABLE Categories
(
    categoryid   INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    categoryname NVARCHAR(30),
    type_id      INT FOREIGN KEY REFERENCES [dbo].Types (id),
)
go
CREATE TABLE Suppliers
(
    supplierid    INT          NOT NULL IDENTITY (1,1) PRIMARY KEY,
    suppliername  NVARCHAR(100),
    supplierimage VARCHAR(255) NOT NULL,
)
go
CREATE TABLE Products
(
    id            INT            NOT NULL IDENTITY (1,1) PRIMARY KEY,
    productname   NVARCHAR(max)  NOT NULL,
    supplierid    INT FOREIGN KEY REFERENCES [dbo].[Suppliers] (supplierid) ON DELETE SET NULL ON UPDATE CASCADE,
    categoryid    INT FOREIGN KEY REFERENCES [dbo].[Categories] (categoryid) ON DELETE SET NULL ON UPDATE CASCADE,
    size          VARCHAR(40)    NOT NULL,
    stock         INT            NOT NULL,
    [description] NVARCHAR(max),
    [images]      VARBINARY(MAX) NOT NULL,
    [colors]      NVARCHAR(255)  NOT NULL,
    releasedate   DATE           NOT NULL,
    discount      FLOAT,
    unitSold      INT,
    price         money          NOT NULL,
    status        bit            not null,
    typeid        int            not null FOREIGN KEY REFERENCES [dbo].[Types] (id) ON DELETE CASCADE ON UPDATE CASCADE
)