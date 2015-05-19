
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2015 11:28:40
-- Generated from EDMX file: C:\Users\aarroyave\Documents\JS\elective\ParkNow\ParkNow.DataAccess\ParkNowContext.edmx
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

IF OBJECT_ID(N'[dbo].[FK_UserParking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parkings] DROP CONSTRAINT [FK_UserParking];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleParking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parkings] DROP CONSTRAINT [FK_VehicleParking];
GO
IF OBJECT_ID(N'[dbo].[FK_Car_inherits_Vehicle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles_Car] DROP CONSTRAINT [FK_Car_inherits_Vehicle];
GO
IF OBJECT_ID(N'[dbo].[FK_Motorcicle_inherits_Vehicle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicles_Motorcicle] DROP CONSTRAINT [FK_Motorcicle_inherits_Vehicle];
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
IF OBJECT_ID(N'[dbo].[Vehicles_Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles_Car];
GO
IF OBJECT_ID(N'[dbo].[Vehicles_Motorcicle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicles_Motorcicle];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [NationalId] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Role] int  NOT NULL
);
GO

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [Plate] nvarchar(6)  NOT NULL
);
GO

-- Creating table 'Parkings'
CREATE TABLE [dbo].[Parkings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [InDate] datetime  NOT NULL,
    [OutDate] datetime  NULL,
    [UserNationalId] int  NOT NULL,
    [VehiclePlate] nvarchar(6)  NOT NULL
);
GO

-- Creating table 'Vehicles_Car'
CREATE TABLE [dbo].[Vehicles_Car] (
    [Plate] nvarchar(6)  NOT NULL
);
GO

-- Creating table 'Vehicles_Motorcicle'
CREATE TABLE [dbo].[Vehicles_Motorcicle] (
    [Plate] nvarchar(6)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NationalId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([NationalId] ASC);
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

-- Creating primary key on [Plate] in table 'Vehicles_Car'
ALTER TABLE [dbo].[Vehicles_Car]
ADD CONSTRAINT [PK_Vehicles_Car]
    PRIMARY KEY CLUSTERED ([Plate] ASC);
GO

-- Creating primary key on [Plate] in table 'Vehicles_Motorcicle'
ALTER TABLE [dbo].[Vehicles_Motorcicle]
ADD CONSTRAINT [PK_Vehicles_Motorcicle]
    PRIMARY KEY CLUSTERED ([Plate] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserNationalId] in table 'Parkings'
ALTER TABLE [dbo].[Parkings]
ADD CONSTRAINT [FK_UserParking]
    FOREIGN KEY ([UserNationalId])
    REFERENCES [dbo].[Users]
        ([NationalId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserParking'
CREATE INDEX [IX_FK_UserParking]
ON [dbo].[Parkings]
    ([UserNationalId]);
GO

-- Creating foreign key on [VehiclePlate] in table 'Parkings'
ALTER TABLE [dbo].[Parkings]
ADD CONSTRAINT [FK_VehicleParking]
    FOREIGN KEY ([VehiclePlate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleParking'
CREATE INDEX [IX_FK_VehicleParking]
ON [dbo].[Parkings]
    ([VehiclePlate]);
GO

-- Creating foreign key on [Plate] in table 'Vehicles_Car'
ALTER TABLE [dbo].[Vehicles_Car]
ADD CONSTRAINT [FK_Car_inherits_Vehicle]
    FOREIGN KEY ([Plate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Plate] in table 'Vehicles_Motorcicle'
ALTER TABLE [dbo].[Vehicles_Motorcicle]
ADD CONSTRAINT [FK_Motorcicle_inherits_Vehicle]
    FOREIGN KEY ([Plate])
    REFERENCES [dbo].[Vehicles]
        ([Plate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------