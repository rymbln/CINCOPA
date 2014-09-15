
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2014 12:29:50
-- Generated from EDMX file: c:\users\rymbln\documents\visual studio 2012\Projects\CINCOPA\CINCOPA\CINCOPAModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CINCOPA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CRFWARD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRF] DROP CONSTRAINT [FK_CRFWARD];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CRF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRF];
GO
IF OBJECT_ID(N'[dbo].[WARD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WARD];
GO
IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CRF'
CREATE TABLE [dbo].[CRF] (
    [Id] uniqueidentifier  NOT NULL,
    [WARDId] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [NUMBER] int  NOT NULL,
    [DATE_BIRTH] datetime  NULL,
    [DATE_HOSPITALISATION] datetime  NULL,
    [DATE_DISCHARGE] datetime  NULL,
    [AE_LOGIC] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WARD'
CREATE TABLE [dbo].[WARD] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [NUMBER] int  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'USERS'
CREATE TABLE [dbo].[USERS] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [PASSWORD] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CRF'
ALTER TABLE [dbo].[CRF]
ADD CONSTRAINT [PK_CRF]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WARD'
ALTER TABLE [dbo].[WARD]
ADD CONSTRAINT [PK_WARD]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WARDId] in table 'CRF'
ALTER TABLE [dbo].[CRF]
ADD CONSTRAINT [FK_CRFWARD]
    FOREIGN KEY ([WARDId])
    REFERENCES [dbo].[WARD]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFWARD'
CREATE INDEX [IX_FK_CRFWARD]
ON [dbo].[CRF]
    ([WARDId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------