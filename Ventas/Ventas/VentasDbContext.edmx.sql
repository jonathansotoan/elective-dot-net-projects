
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2015 10:01:20
-- Generated from EDMX file: C:\Users\w7\Desktop\Elective.net\Ventas\Ventas\VentasDbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ventas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_detallefacturas_facturas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleFacturas] DROP CONSTRAINT [fk_detallefacturas_facturas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DetalleFacturas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleFacturas];
GO
IF OBJECT_ID(N'[dbo].[Facturas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facturas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DetalleFacturas'
CREATE TABLE [dbo].[DetalleFacturas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdFactura] int  NOT NULL,
    [NombreProducto] varchar(50)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [Precio] decimal(18,1)  NOT NULL,
    [Facturas_Id] int  NOT NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [Id] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [ValorTotal] decimal(18,1)  NOT NULL,
    [Ciudad] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [PK_DetalleFacturas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Facturas_Id] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [fk_detallefacturas_facturas]
    FOREIGN KEY ([Facturas_Id])
    REFERENCES [dbo].[Facturas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_detallefacturas_facturas'
CREATE INDEX [IX_fk_detallefacturas_facturas]
ON [dbo].[DetalleFacturas]
    ([Facturas_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------