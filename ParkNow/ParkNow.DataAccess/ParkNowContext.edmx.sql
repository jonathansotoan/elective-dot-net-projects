
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2015 23:11:10
-- Generated from EDMX file: D:\workspaces\dotNet\ParkNow\ParkNow.DataAccess\ParkNowContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ParkNow];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_VehicleParking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parkings] DROP CONSTRAINT [FK_VehicleParking];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeParking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parkings] DROP CONSTRAINT [FK_EmployeeParking];
GO
IF OBJECT_ID(N'[dbo].[FK_Motorcicle_inherits_Vehicle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles_Motorcicle] DROP CONSTRAINT [FK_Motorcicle_inherits_Vehicle];
GO
IF OBJECT_ID(N'[dbo].[FK_Car_inherits_Vehicle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles_Car] DROP CONSTRAINT [FK_Car_inherits_Vehicle];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Vehicles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles];
GO
IF OBJECT_ID(N'[dbo].[Parkings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parkings];
GO
IF OBJECT_ID(N'[dbo].[Vehicles_Motorcicle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles_Motorcicle];
GO
IF OBJECT_ID(N'[dbo].[Vehicles_Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles_Car];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Role] tinyint  NOT NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Plate] nchar(6)  NOT NULL
);
GO

-- Creating table 'Parkings'
CREATE TABLE [dbo].[Parkings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [InDate] datetime  NOT NULL,
    [OutDate] datetime  NULL,
    [Vehicle_Plate] nchar(6)  NOT NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- Creating table 'Vehicles_Motorcicle'
CREATE TABLE [dbo].[Vehicles_Motorcicle] (
    [Plate] nchar(6)  NOT NULL
);
GO

-- Creating table 'Vehicles_Car'
CREATE TABLE [dbo].[Vehicles_Car] (
    [Plate] nchar(6)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Plate] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([Plate] ASC);
GO

-- Creating primary key on [Id] in table 'Parkings'
ALTER TABLE [dbo].[Parkings]
ADD CONSTRAINT [PK_Parkings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Plate] in table 'Vehicles_Motorcicle'
ALTER TABLE [dbo].[Vehicles_Motorcicle]
ADD CONSTRAINT [PK_Vehicles_Motorcicle]
    PRIMARY KEY CLUSTERED ([Plate] ASC);
GO

-- Creating primary key on [Plate] in table 'Vehicles_Car'
ALTER TABLE [dbo].[Vehicles_Car]
ADD CONSTRAINT [PK_Vehicles_Car]
    PRIMARY KEY CLUSTERED ([Plate] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Vehicle_Plate] in table 'Parkings'
ALTER TABLE [dbo].[Parkings]
ADD CONSTRAINT [FK_VehicleParking]
    FOREIGN KEY ([Vehicle_Plate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleParking'
CREATE INDEX [IX_FK_VehicleParking]
ON [dbo].[Parkings]
    ([Vehicle_Plate]);
GO

-- Creating foreign key on [Employee_Id] in table 'Parkings'
ALTER TABLE [dbo].[Parkings]
ADD CONSTRAINT [FK_EmployeeParking]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeParking'
CREATE INDEX [IX_FK_EmployeeParking]
ON [dbo].[Parkings]
    ([Employee_Id]);
GO

-- Creating foreign key on [Plate] in table 'Vehicles_Motorcicle'
ALTER TABLE [dbo].[Vehicles_Motorcicle]
ADD CONSTRAINT [FK_Motorcicle_inherits_Vehicle]
    FOREIGN KEY ([Plate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Plate] in table 'Vehicles_Car'
ALTER TABLE [dbo].[Vehicles_Car]
ADD CONSTRAINT [FK_Car_inherits_Vehicle]
    FOREIGN KEY ([Plate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------