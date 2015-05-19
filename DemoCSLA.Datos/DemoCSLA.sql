
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2015 21:58:29
-- Generated from EDMX file: E:\HD\GitHub\DemoCSLA\DemoCSLA.Datos\DemoCSLA.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DemoCSLADb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RazonSocial] nvarchar(200)  NOT NULL,
    [RUC] nvarchar(200)  NOT NULL,
    [Telefono] nvarchar(200)  NOT NULL,
    [Correo] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'ProductoSet'
CREATE TABLE [dbo].[ProductoSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(200)  NOT NULL,
    [Descripcion] nvarchar(200)  NOT NULL,
    [PrecioUnitario] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'FacturaCabeceraSet'
CREATE TABLE [dbo].[FacturaCabeceraSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(200)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [SubTotal] decimal(18,0)  NOT NULL,
    [Impuestos] decimal(18,0)  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [Cliente_ID] int  NOT NULL
);
GO

-- Creating table 'FacturaDetalleSet'
CREATE TABLE [dbo].[FacturaDetalleSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PrecioUnitario] decimal(18,0)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [Producto_ID] int  NOT NULL,
    [Factura_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [PK_ProductoSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FacturaCabeceraSet'
ALTER TABLE [dbo].[FacturaCabeceraSet]
ADD CONSTRAINT [PK_FacturaCabeceraSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FacturaDetalleSet'
ALTER TABLE [dbo].[FacturaDetalleSet]
ADD CONSTRAINT [PK_FacturaDetalleSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_ID] in table 'FacturaCabeceraSet'
ALTER TABLE [dbo].[FacturaCabeceraSet]
ADD CONSTRAINT [FK_ClienteFacturaCabecera]
    FOREIGN KEY ([Cliente_ID])
    REFERENCES [dbo].[ClienteSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFacturaCabecera'
CREATE INDEX [IX_FK_ClienteFacturaCabecera]
ON [dbo].[FacturaCabeceraSet]
    ([Cliente_ID]);
GO

-- Creating foreign key on [Producto_ID] in table 'FacturaDetalleSet'
ALTER TABLE [dbo].[FacturaDetalleSet]
ADD CONSTRAINT [FK_ProductoFacturaDetalle]
    FOREIGN KEY ([Producto_ID])
    REFERENCES [dbo].[ProductoSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoFacturaDetalle'
CREATE INDEX [IX_FK_ProductoFacturaDetalle]
ON [dbo].[FacturaDetalleSet]
    ([Producto_ID]);
GO

-- Creating foreign key on [Factura_ID] in table 'FacturaDetalleSet'
ALTER TABLE [dbo].[FacturaDetalleSet]
ADD CONSTRAINT [FK_FacturaCabeceraFacturaDetalle]
    FOREIGN KEY ([Factura_ID])
    REFERENCES [dbo].[FacturaCabeceraSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaCabeceraFacturaDetalle'
CREATE INDEX [IX_FK_FacturaCabeceraFacturaDetalle]
ON [dbo].[FacturaDetalleSet]
    ([Factura_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------