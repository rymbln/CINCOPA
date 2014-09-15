
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2014 22:12:44
-- Generated from EDMX file: c:\users\rymbln\documents\visual studio 2012\Projects\CINCOPA\CINCOPA\Model\CINCOPAModel.edmx
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
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFWARD];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_ONE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFVISIT_ONE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_ONE_ONE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFVISIT_ONE_ONE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_THREE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFVISIT_THREE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_TWO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFVISIT_TWO];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFADVERSE_EVENT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AEs] DROP CONSTRAINT [FK_CRFADVERSE_EVENT];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEANAMNESTIC_DATA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEANAMNESTIC_DATA];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEXRAY_CHEST_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONEXRAY_CHEST_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOnes] DROP CONSTRAINT [FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitTwoes] DROP CONSTRAINT [FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitTwoes] DROP CONSTRAINT [FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitThrees] DROP CONSTRAINT [FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitOneOnes] DROP CONSTRAINT [FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_CLINICAL_ANALYSIS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFBLOOD_CLINICAL_ANALYSIS];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_CHEMISTRY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFBLOOD_CHEMISTRY];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AbTherapys] DROP CONSTRAINT [FK_CRFAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_ROUTEAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AbTherapys] DROP CONSTRAINT [FK_ROUTEAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_DRUGAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AbTherapys] DROP CONSTRAINT [FK_DRUGAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFTEST_FOR_PNEUMOCOCCAL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFs] DROP CONSTRAINT [FK_CRFTEST_FOR_PNEUMOCOCCAL];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFMICROBIOLOGY_SPUTUM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MicrobiologySputums] DROP CONSTRAINT [FK_CRFMICROBIOLOGY_SPUTUM];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFMICROBIOLOGY_BLOOD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MicrobiologyBloods] DROP CONSTRAINT [FK_CRFMICROBIOLOGY_BLOOD];
GO
IF OBJECT_ID(N'[dbo].[FK_ORGANISMMICROBIOLOGY_BLOOD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MicrobiologyBloods] DROP CONSTRAINT [FK_ORGANISMMICROBIOLOGY_BLOOD];
GO
IF OBJECT_ID(N'[dbo].[FK_ORGANISMMICROBIOLOGY_SPUTUM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MicrobiologySputums] DROP CONSTRAINT [FK_ORGANISMMICROBIOLOGY_SPUTUM];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CRFs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRFs];
GO
IF OBJECT_ID(N'[dbo].[Wards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wards];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[VisitOnes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitOnes];
GO
IF OBJECT_ID(N'[dbo].[VisitOneOnes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitOneOnes];
GO
IF OBJECT_ID(N'[dbo].[VisitTwoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitTwoes];
GO
IF OBJECT_ID(N'[dbo].[VisitThrees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitThrees];
GO
IF OBJECT_ID(N'[dbo].[AEs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AEs];
GO
IF OBJECT_ID(N'[dbo].[BaseLiveIndicatorsVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BaseLiveIndicatorsVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[AnamnesticDataVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamnesticDataVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[EvaluationOfSymptomsVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvaluationOfSymptomsVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[ElectrocardiographyVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElectrocardiographyVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[EchocardiographyVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EchocardiographyVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[XrayChestVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[XrayChestVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[ComputedTomographyChestVisit1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComputedTomographyChestVisit1Set];
GO
IF OBJECT_ID(N'[dbo].[BaseLiveIndicatorsVisit2Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BaseLiveIndicatorsVisit2Set];
GO
IF OBJECT_ID(N'[dbo].[EvaluationOfSymptomsVisit2Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvaluationOfSymptomsVisit2Set];
GO
IF OBJECT_ID(N'[dbo].[EchocardiographyVisit3Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EchocardiographyVisit3Set];
GO
IF OBJECT_ID(N'[dbo].[EvaluationOfSymptomsVisit11Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvaluationOfSymptomsVisit11Set];
GO
IF OBJECT_ID(N'[dbo].[BloodClinicalAnalyses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BloodClinicalAnalyses];
GO
IF OBJECT_ID(N'[dbo].[BloodTestsForMarkersOfInflammations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BloodTestsForMarkersOfInflammations];
GO
IF OBJECT_ID(N'[dbo].[BloodTestsForMarkersOfCardiacDysfunctions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BloodTestsForMarkersOfCardiacDysfunctions];
GO
IF OBJECT_ID(N'[dbo].[BloodChemistrys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BloodChemistrys];
GO
IF OBJECT_ID(N'[dbo].[Organisms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Organisms];
GO
IF OBJECT_ID(N'[dbo].[Routes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Routes];
GO
IF OBJECT_ID(N'[dbo].[Drugs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drugs];
GO
IF OBJECT_ID(N'[dbo].[AbTherapys]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AbTherapys];
GO
IF OBJECT_ID(N'[dbo].[TestForPneumococcals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestForPneumococcals];
GO
IF OBJECT_ID(N'[dbo].[MicrobiologySputums]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MicrobiologySputums];
GO
IF OBJECT_ID(N'[dbo].[MicrobiologyBloods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MicrobiologyBloods];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CRFs'
CREATE TABLE [dbo].[CRFs] (
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
    [StateCode] nvarchar(max)  NULL,
    [VISIT_ONE_Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_ONE_Id] uniqueidentifier  NOT NULL,
    [VISIT_THREE_Id] uniqueidentifier  NOT NULL,
    [VISIT_TWO_Id] uniqueidentifier  NOT NULL,
    [BLOOD_CLINICAL_ANALYSIS_Id] uniqueidentifier  NOT NULL,
    [BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id] uniqueidentifier  NOT NULL,
    [BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id] uniqueidentifier  NOT NULL,
    [BLOOD_CHEMISTRY_Id] uniqueidentifier  NOT NULL,
    [TEST_FOR_PNEUMOCOCCAL_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Wards'
CREATE TABLE [dbo].[Wards] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [NUMBER] int  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [PASSWORD] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VisitOnes'
CREATE TABLE [dbo].[VisitOnes] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL,
    [BASE_LIVE_INDICATORS_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ANAMNESTIC_DATA_Id] uniqueidentifier  NOT NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ELECTROCARDIOGRAPHY_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ECHOCARDIOGRAPHY_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [XRAY_CHEST_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VisitOneOnes'
CREATE TABLE [dbo].[VisitOneOnes] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_11_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VisitTwoes'
CREATE TABLE [dbo].[VisitTwoes] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL,
    [BASE_LIVE_INDICATORS_VISIT_2_Id] uniqueidentifier  NOT NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_2_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VisitThrees'
CREATE TABLE [dbo].[VisitThrees] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL,
    [ECHOCARDIOGRAPHY_VISIT_3_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'AEs'
CREATE TABLE [dbo].[AEs] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NULL,
    [DATE_START] datetime  NULL,
    [DATE_END] datetime  NULL,
    [HEAVY] nvarchar(max)  NULL,
    [RESULT] nvarchar(max)  NULL,
    [RELATION] nvarchar(max)  NULL,
    [ACTIONS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BaseLiveIndicatorsVisit1Set'
CREATE TABLE [dbo].[BaseLiveIndicatorsVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [BLOOD_PRESSURE_RIGHT_HAND] int  NULL,
    [BLOOD_PRESSURE_LEFT_HAND] int  NULL,
    [HEART_RATE] int  NULL,
    [RESPIRATORY_RATE] int  NULL,
    [TEMPERATURE] decimal(18,0)  NULL,
    [HEAVY_TYPE] nvarchar(max)  NULL,
    [OXYGEN_THERAPY_NEEDED] nvarchar(max)  NULL,
    [DECOMPENSATION_SIGNS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'AnamnesticDataVisit1Set'
CREATE TABLE [dbo].[AnamnesticDataVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_SYMPTOM] datetime  NULL,
    [DATE_DIAGNOSIS] datetime  NULL,
    [NUMBER_EPISODES] int  NULL,
    [NUMBER_EPISODES_NODATA] bit  NULL,
    [FUNCTION_CLASS] nvarchar(max)  NULL,
    [OTHER_EPISODES] nvarchar(max)  NULL,
    [SMOKE_STATUS] nvarchar(max)  NULL,
    [SMOKE_AVERAGE] int  NULL,
    [SMOKE_YEARS] int  NULL,
    [SMOKE_PACK_YEARS] decimal(18,0)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'EvaluationOfSymptomsVisit1Set'
CREATE TABLE [dbo].[EvaluationOfSymptomsVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NULL,
    [COUGH] nvarchar(max)  NULL,
    [SPUTUM] nvarchar(max)  NULL,
    [SPUTUM_TYPE] nvarchar(max)  NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NULL,
    [COLD_SYMPTOM] nvarchar(max)  NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NULL,
    [CREPITUS] nvarchar(max)  NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NULL,
    [DRY_RALES] nvarchar(max)  NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'ElectrocardiographyVisit1Set'
CREATE TABLE [dbo].[ElectrocardiographyVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NULL,
    [SINUS_RHYTHM] bit  NULL,
    [ATRIAL_FIBRILLATION] bit  NULL,
    [ARRYTHMIA_SUPRAVENTRICULAR] bit  NULL,
    [ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS] bit  NULL,
    [HEART_RATE] int  NULL,
    [SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'EchocardiographyVisit1Set'
CREATE TABLE [dbo].[EchocardiographyVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NULL,
    [FV_PERCENT] decimal(18,0)  NULL,
    [EA_LJ] decimal(18,0)  NULL,
    [EA_RJ] decimal(18,0)  NULL,
    [SDLA] decimal(18,0)  NULL,
    [AMOUNT_OF_PERICARDIAL_EFFUSION] decimal(18,0)  NULL,
    [COMMENTS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'XrayChestVisit1Set'
CREATE TABLE [dbo].[XrayChestVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NULL,
    [PNEUMONIA_SIGNS] nvarchar(max)  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_TOP] bit  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_MIDDLE] bit  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_BOTTOM] bit  NULL,
    [ALVEOLAR_INFILTRATION_LEFT_TOP] bit  NULL,
    [ALVEOLAR_INFILTRATION_LEFT_BOTTOM] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_TOP] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM] bit  NULL,
    [INTERSTITIAL_INFILTRATION_LEFT_TOP] bit  NULL,
    [INTERSTITIAL_INFILTRATION_LEFT_BOTTOM] bit  NULL,
    [PLEURAL_EFFUSION_NONE] bit  NULL,
    [PLEURAL_EFFUSION_RIGHT] bit  NULL,
    [PLEURAL_EFFUSION_LEFT] bit  NULL,
    [PLEURAL_EFFUSION_DOUBLE] bit  NULL,
    [OTHER] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'ComputedTomographyChestVisit1Set'
CREATE TABLE [dbo].[ComputedTomographyChestVisit1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NULL,
    [PNEUMONIA_SIGNS] nvarchar(max)  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_TOP] bit  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_MIDDLE] bit  NULL,
    [ALVEOLAR_INFILTRATION_RIGHT_BOTTOM] bit  NULL,
    [ALVEOLAR_INFILTRATION_LEFT_TOP] bit  NULL,
    [ALVEOLAR_INFILTRATION_LEFT_BOTTOM] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_TOP] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE] bit  NULL,
    [INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM] bit  NULL,
    [INTERSTITIAL_INFILTRATION_LEFT_TOP] bit  NULL,
    [INTERSTITIAL_INFILTRATION_LEFT_BOTTOM] bit  NULL,
    [PLEURAL_EFFUSION_NONE] bit  NULL,
    [PLEURAL_EFFUSION_RIGHT] bit  NULL,
    [PLEURAL_EFFUSION_LEFT] bit  NULL,
    [PLEURAL_EFFUSION_DOUBLE] bit  NULL,
    [OTHER] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BaseLiveIndicatorsVisit2Set'
CREATE TABLE [dbo].[BaseLiveIndicatorsVisit2Set] (
    [Id] uniqueidentifier  NOT NULL,
    [BLOOD_PRESSURE_RIGHT_HAND] int  NULL,
    [BLOOD_PRESSURE_LEFT_HAND] int  NULL,
    [HEART_RATE] int  NULL,
    [RESPIRATORY_RATE] int  NULL,
    [TEMPERATURE] decimal(18,0)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'EvaluationOfSymptomsVisit2Set'
CREATE TABLE [dbo].[EvaluationOfSymptomsVisit2Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NULL,
    [COUGH] nvarchar(max)  NULL,
    [SPUTUM] nvarchar(max)  NULL,
    [SPUTUM_TYPE] nvarchar(max)  NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NULL,
    [COLD_SYMPTOM] nvarchar(max)  NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NULL,
    [CREPITUS] nvarchar(max)  NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NULL,
    [DRY_RALES] nvarchar(max)  NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NULL,
    [THERAPY_EFFICIENCY] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'EchocardiographyVisit3Set'
CREATE TABLE [dbo].[EchocardiographyVisit3Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NULL,
    [FV_PERCENT] decimal(18,0)  NULL,
    [EA_LJ] decimal(18,0)  NULL,
    [EA_RJ] decimal(18,0)  NULL,
    [SDLA] decimal(18,0)  NULL,
    [AMOUNT_OF_PERICARDIAL_EFFUSION] decimal(18,0)  NULL,
    [COMMENTS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'EvaluationOfSymptomsVisit11Set'
CREATE TABLE [dbo].[EvaluationOfSymptomsVisit11Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NULL,
    [COUGH] nvarchar(max)  NULL,
    [SPUTUM] nvarchar(max)  NULL,
    [SPUTUM_TYPE] nvarchar(max)  NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NULL,
    [COLD_SYMPTOM] nvarchar(max)  NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NULL,
    [CREPITUS] nvarchar(max)  NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NULL,
    [DRY_RALES] nvarchar(max)  NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NULL,
    [THERAPY_EFFICIENCY] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BloodClinicalAnalyses'
CREATE TABLE [dbo].[BloodClinicalAnalyses] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_ONE_LEUKOCYTOSIS] decimal(18,0)  NULL,
    [VISIT_ONE_LUKOCYTOSIS_YOUNG_FORMS] nvarchar(max)  NULL,
    [VISIT_ONE_OTHERS] nvarchar(max)  NULL,
    [VISIT_TWO_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_LEUKOCYTOSIS] decimal(18,0)  NULL,
    [VISIT_TWO_LUKOCYTOSIS_YOUNG_FORMS] nvarchar(max)  NULL,
    [VISIT_TWO_OTHERS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BloodTestsForMarkersOfInflammations'
CREATE TABLE [dbo].[BloodTestsForMarkersOfInflammations] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_C_REACTIVE_PROTEIN] nvarchar(max)  NULL,
    [VISIT_ONE_PROCALCITONIN] nvarchar(max)  NULL,
    [VISIT_ONE_IL6] nvarchar(max)  NULL,
    [VISIT_ONE_FNO] nvarchar(max)  NULL,
    [VISIT_TWO_C_REACTIVE_PROTEIN] nvarchar(max)  NULL,
    [VISIT_TWO_PROCALCITONIN] nvarchar(max)  NULL,
    [VISIT_TWO_IL6] nvarchar(max)  NULL,
    [VISIT_TWO_FNO] nvarchar(max)  NULL,
    [VISIT_THREE_C_REACTIVE_PROTEIN] nvarchar(max)  NULL,
    [VISIT_THREE_PROCALCITONIN] nvarchar(max)  NULL,
    [VISIT_THREE_IL6] nvarchar(max)  NULL,
    [VISIT_THREE_FNO] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BloodTestsForMarkersOfCardiacDysfunctions'
CREATE TABLE [dbo].[BloodTestsForMarkersOfCardiacDysfunctions] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE] nvarchar(max)  NULL,
    [VISIT_ONE_KOPEPTIN] nvarchar(max)  NULL,
    [VISIT_ONE_PROADRENOMEDULLIN] nvarchar(max)  NULL,
    [VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE] nvarchar(max)  NULL,
    [VISIT_TWO_KOPEPTIN] nvarchar(max)  NULL,
    [VISIT_TWO_PROADRENOMEDULLIN] nvarchar(max)  NULL,
    [VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE] nvarchar(max)  NULL,
    [VISIT_THREE_KOPEPTIN] nvarchar(max)  NULL,
    [VISIT_THREE_PROADRENOMEDULLIN] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'BloodChemistrys'
CREATE TABLE [dbo].[BloodChemistrys] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_ONE_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_CHANGES] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'Organisms'
CREATE TABLE [dbo].[Organisms] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'Routes'
CREATE TABLE [dbo].[Routes] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'Drugs'
CREATE TABLE [dbo].[Drugs] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [MNN] nvarchar(max)  NULL,
    [GROUP] nvarchar(max)  NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'AbTherapys'
CREATE TABLE [dbo].[AbTherapys] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DRUGId] uniqueidentifier  NOT NULL,
    [ROUTEId] uniqueidentifier  NOT NULL,
    [SINGLE_DOSE] nvarchar(max)  NULL,
    [FREQUENCY] nvarchar(max)  NULL,
    [DATE_START] nvarchar(max)  NULL,
    [DATE_END] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'TestForPneumococcals'
CREATE TABLE [dbo].[TestForPneumococcals] (
    [Id] uniqueidentifier  NOT NULL,
    [LOGIC] nvarchar(max)  NULL,
    [RESULT] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'MicrobiologySputums'
CREATE TABLE [dbo].[MicrobiologySputums] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_CAPTURE] nvarchar(max)  NULL,
    [LAB_NUMBER] nvarchar(max)  NULL,
    [QUALITY_LEUKOCYTES] nvarchar(max)  NULL,
    [QUALITY_EPITHELIAL] nvarchar(max)  NULL,
    [NOT_REPRESENTATIVE] bit  NULL,
    [GROWTH_PATHOGENS] nvarchar(max)  NULL,
    [ORGANISMId] uniqueidentifier  NULL,
    [BETA] nvarchar(max)  NULL,
    [MRSA] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- Creating table 'MicrobiologyBloods'
CREATE TABLE [dbo].[MicrobiologyBloods] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_CAPTURE] nvarchar(max)  NULL,
    [LAB_NUMBER] nvarchar(max)  NULL,
    [GROWTH_PATHOGENS] nvarchar(max)  NULL,
    [ORGANISMId] uniqueidentifier  NULL,
    [BETA] nvarchar(max)  NULL,
    [MRSA] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedByDate] nvarchar(max)  NULL,
    [UpdatedBy] nvarchar(max)  NULL,
    [UpdatedByDate] nvarchar(max)  NULL,
    [StateCode] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [PK_CRFs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Wards'
ALTER TABLE [dbo].[Wards]
ADD CONSTRAINT [PK_Wards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [PK_VisitOnes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VisitOneOnes'
ALTER TABLE [dbo].[VisitOneOnes]
ADD CONSTRAINT [PK_VisitOneOnes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VisitTwoes'
ALTER TABLE [dbo].[VisitTwoes]
ADD CONSTRAINT [PK_VisitTwoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VisitThrees'
ALTER TABLE [dbo].[VisitThrees]
ADD CONSTRAINT [PK_VisitThrees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AEs'
ALTER TABLE [dbo].[AEs]
ADD CONSTRAINT [PK_AEs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseLiveIndicatorsVisit1Set'
ALTER TABLE [dbo].[BaseLiveIndicatorsVisit1Set]
ADD CONSTRAINT [PK_BaseLiveIndicatorsVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnamnesticDataVisit1Set'
ALTER TABLE [dbo].[AnamnesticDataVisit1Set]
ADD CONSTRAINT [PK_AnamnesticDataVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EvaluationOfSymptomsVisit1Set'
ALTER TABLE [dbo].[EvaluationOfSymptomsVisit1Set]
ADD CONSTRAINT [PK_EvaluationOfSymptomsVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ElectrocardiographyVisit1Set'
ALTER TABLE [dbo].[ElectrocardiographyVisit1Set]
ADD CONSTRAINT [PK_ElectrocardiographyVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EchocardiographyVisit1Set'
ALTER TABLE [dbo].[EchocardiographyVisit1Set]
ADD CONSTRAINT [PK_EchocardiographyVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'XrayChestVisit1Set'
ALTER TABLE [dbo].[XrayChestVisit1Set]
ADD CONSTRAINT [PK_XrayChestVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComputedTomographyChestVisit1Set'
ALTER TABLE [dbo].[ComputedTomographyChestVisit1Set]
ADD CONSTRAINT [PK_ComputedTomographyChestVisit1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseLiveIndicatorsVisit2Set'
ALTER TABLE [dbo].[BaseLiveIndicatorsVisit2Set]
ADD CONSTRAINT [PK_BaseLiveIndicatorsVisit2Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EvaluationOfSymptomsVisit2Set'
ALTER TABLE [dbo].[EvaluationOfSymptomsVisit2Set]
ADD CONSTRAINT [PK_EvaluationOfSymptomsVisit2Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EchocardiographyVisit3Set'
ALTER TABLE [dbo].[EchocardiographyVisit3Set]
ADD CONSTRAINT [PK_EchocardiographyVisit3Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EvaluationOfSymptomsVisit11Set'
ALTER TABLE [dbo].[EvaluationOfSymptomsVisit11Set]
ADD CONSTRAINT [PK_EvaluationOfSymptomsVisit11Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BloodClinicalAnalyses'
ALTER TABLE [dbo].[BloodClinicalAnalyses]
ADD CONSTRAINT [PK_BloodClinicalAnalyses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BloodTestsForMarkersOfInflammations'
ALTER TABLE [dbo].[BloodTestsForMarkersOfInflammations]
ADD CONSTRAINT [PK_BloodTestsForMarkersOfInflammations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BloodTestsForMarkersOfCardiacDysfunctions'
ALTER TABLE [dbo].[BloodTestsForMarkersOfCardiacDysfunctions]
ADD CONSTRAINT [PK_BloodTestsForMarkersOfCardiacDysfunctions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BloodChemistrys'
ALTER TABLE [dbo].[BloodChemistrys]
ADD CONSTRAINT [PK_BloodChemistrys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Organisms'
ALTER TABLE [dbo].[Organisms]
ADD CONSTRAINT [PK_Organisms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [PK_Routes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Drugs'
ALTER TABLE [dbo].[Drugs]
ADD CONSTRAINT [PK_Drugs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AbTherapys'
ALTER TABLE [dbo].[AbTherapys]
ADD CONSTRAINT [PK_AbTherapys]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestForPneumococcals'
ALTER TABLE [dbo].[TestForPneumococcals]
ADD CONSTRAINT [PK_TestForPneumococcals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MicrobiologySputums'
ALTER TABLE [dbo].[MicrobiologySputums]
ADD CONSTRAINT [PK_MicrobiologySputums]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MicrobiologyBloods'
ALTER TABLE [dbo].[MicrobiologyBloods]
ADD CONSTRAINT [PK_MicrobiologyBloods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WARDId] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFWARD]
    FOREIGN KEY ([WARDId])
    REFERENCES [dbo].[Wards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFWARD'
CREATE INDEX [IX_FK_CRFWARD]
ON [dbo].[CRFs]
    ([WARDId]);
GO

-- Creating foreign key on [VISIT_ONE_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFVISIT_ONE]
    FOREIGN KEY ([VISIT_ONE_Id])
    REFERENCES [dbo].[VisitOnes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_ONE'
CREATE INDEX [IX_FK_CRFVISIT_ONE]
ON [dbo].[CRFs]
    ([VISIT_ONE_Id]);
GO

-- Creating foreign key on [VISIT_ONE_ONE_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFVISIT_ONE_ONE]
    FOREIGN KEY ([VISIT_ONE_ONE_Id])
    REFERENCES [dbo].[VisitOneOnes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_ONE_ONE'
CREATE INDEX [IX_FK_CRFVISIT_ONE_ONE]
ON [dbo].[CRFs]
    ([VISIT_ONE_ONE_Id]);
GO

-- Creating foreign key on [VISIT_THREE_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFVISIT_THREE]
    FOREIGN KEY ([VISIT_THREE_Id])
    REFERENCES [dbo].[VisitThrees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_THREE'
CREATE INDEX [IX_FK_CRFVISIT_THREE]
ON [dbo].[CRFs]
    ([VISIT_THREE_Id]);
GO

-- Creating foreign key on [VISIT_TWO_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFVISIT_TWO]
    FOREIGN KEY ([VISIT_TWO_Id])
    REFERENCES [dbo].[VisitTwoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_TWO'
CREATE INDEX [IX_FK_CRFVISIT_TWO]
ON [dbo].[CRFs]
    ([VISIT_TWO_Id]);
GO

-- Creating foreign key on [CRFId] in table 'AEs'
ALTER TABLE [dbo].[AEs]
ADD CONSTRAINT [FK_CRFADVERSE_EVENT]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFADVERSE_EVENT'
CREATE INDEX [IX_FK_CRFADVERSE_EVENT]
ON [dbo].[AEs]
    ([CRFId]);
GO

-- Creating foreign key on [BASE_LIVE_INDICATORS_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]
    FOREIGN KEY ([BASE_LIVE_INDICATORS_VISIT_1_Id])
    REFERENCES [dbo].[BaseLiveIndicatorsVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]
ON [dbo].[VisitOnes]
    ([BASE_LIVE_INDICATORS_VISIT_1_Id]);
GO

-- Creating foreign key on [ANAMNESTIC_DATA_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEANAMNESTIC_DATA]
    FOREIGN KEY ([ANAMNESTIC_DATA_Id])
    REFERENCES [dbo].[AnamnesticDataVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEANAMNESTIC_DATA'
CREATE INDEX [IX_FK_VISIT_ONEANAMNESTIC_DATA]
ON [dbo].[VisitOnes]
    ([ANAMNESTIC_DATA_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_1_Id])
    REFERENCES [dbo].[EvaluationOfSymptomsVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]
ON [dbo].[VisitOnes]
    ([EVALUATION_OF_SYMPTOMS_VISIT_1_Id]);
GO

-- Creating foreign key on [ELECTROCARDIOGRAPHY_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]
    FOREIGN KEY ([ELECTROCARDIOGRAPHY_VISIT_1_Id])
    REFERENCES [dbo].[ElectrocardiographyVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]
ON [dbo].[VisitOnes]
    ([ELECTROCARDIOGRAPHY_VISIT_1_Id]);
GO

-- Creating foreign key on [ECHOCARDIOGRAPHY_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]
    FOREIGN KEY ([ECHOCARDIOGRAPHY_VISIT_1_Id])
    REFERENCES [dbo].[EchocardiographyVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]
ON [dbo].[VisitOnes]
    ([ECHOCARDIOGRAPHY_VISIT_1_Id]);
GO

-- Creating foreign key on [XRAY_CHEST_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONEXRAY_CHEST_VISIT_1]
    FOREIGN KEY ([XRAY_CHEST_VISIT_1_Id])
    REFERENCES [dbo].[XrayChestVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEXRAY_CHEST_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEXRAY_CHEST_VISIT_1]
ON [dbo].[VisitOnes]
    ([XRAY_CHEST_VISIT_1_Id]);
GO

-- Creating foreign key on [COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id] in table 'VisitOnes'
ALTER TABLE [dbo].[VisitOnes]
ADD CONSTRAINT [FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]
    FOREIGN KEY ([COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id])
    REFERENCES [dbo].[ComputedTomographyChestVisit1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]
ON [dbo].[VisitOnes]
    ([COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id]);
GO

-- Creating foreign key on [BASE_LIVE_INDICATORS_VISIT_2_Id] in table 'VisitTwoes'
ALTER TABLE [dbo].[VisitTwoes]
ADD CONSTRAINT [FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]
    FOREIGN KEY ([BASE_LIVE_INDICATORS_VISIT_2_Id])
    REFERENCES [dbo].[BaseLiveIndicatorsVisit2Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2'
CREATE INDEX [IX_FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]
ON [dbo].[VisitTwoes]
    ([BASE_LIVE_INDICATORS_VISIT_2_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_2_Id] in table 'VisitTwoes'
ALTER TABLE [dbo].[VisitTwoes]
ADD CONSTRAINT [FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_2_Id])
    REFERENCES [dbo].[EvaluationOfSymptomsVisit2Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2'
CREATE INDEX [IX_FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]
ON [dbo].[VisitTwoes]
    ([EVALUATION_OF_SYMPTOMS_VISIT_2_Id]);
GO

-- Creating foreign key on [ECHOCARDIOGRAPHY_VISIT_3_Id] in table 'VisitThrees'
ALTER TABLE [dbo].[VisitThrees]
ADD CONSTRAINT [FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]
    FOREIGN KEY ([ECHOCARDIOGRAPHY_VISIT_3_Id])
    REFERENCES [dbo].[EchocardiographyVisit3Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3'
CREATE INDEX [IX_FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]
ON [dbo].[VisitThrees]
    ([ECHOCARDIOGRAPHY_VISIT_3_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_11_Id] in table 'VisitOneOnes'
ALTER TABLE [dbo].[VisitOneOnes]
ADD CONSTRAINT [FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_11_Id])
    REFERENCES [dbo].[EvaluationOfSymptomsVisit11Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11'
CREATE INDEX [IX_FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]
ON [dbo].[VisitOneOnes]
    ([EVALUATION_OF_SYMPTOMS_VISIT_11_Id]);
GO

-- Creating foreign key on [BLOOD_CLINICAL_ANALYSIS_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFBLOOD_CLINICAL_ANALYSIS]
    FOREIGN KEY ([BLOOD_CLINICAL_ANALYSIS_Id])
    REFERENCES [dbo].[BloodClinicalAnalyses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_CLINICAL_ANALYSIS'
CREATE INDEX [IX_FK_CRFBLOOD_CLINICAL_ANALYSIS]
ON [dbo].[CRFs]
    ([BLOOD_CLINICAL_ANALYSIS_Id]);
GO

-- Creating foreign key on [BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]
    FOREIGN KEY ([BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id])
    REFERENCES [dbo].[BloodTestsForMarkersOfInflammations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION'
CREATE INDEX [IX_FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]
ON [dbo].[CRFs]
    ([BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id]);
GO

-- Creating foreign key on [BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]
    FOREIGN KEY ([BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id])
    REFERENCES [dbo].[BloodTestsForMarkersOfCardiacDysfunctions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION'
CREATE INDEX [IX_FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]
ON [dbo].[CRFs]
    ([BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id]);
GO

-- Creating foreign key on [BLOOD_CHEMISTRY_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFBLOOD_CHEMISTRY]
    FOREIGN KEY ([BLOOD_CHEMISTRY_Id])
    REFERENCES [dbo].[BloodChemistrys]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_CHEMISTRY'
CREATE INDEX [IX_FK_CRFBLOOD_CHEMISTRY]
ON [dbo].[CRFs]
    ([BLOOD_CHEMISTRY_Id]);
GO

-- Creating foreign key on [CRFId] in table 'AbTherapys'
ALTER TABLE [dbo].[AbTherapys]
ADD CONSTRAINT [FK_CRFAB_THERAPY]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFAB_THERAPY'
CREATE INDEX [IX_FK_CRFAB_THERAPY]
ON [dbo].[AbTherapys]
    ([CRFId]);
GO

-- Creating foreign key on [ROUTEId] in table 'AbTherapys'
ALTER TABLE [dbo].[AbTherapys]
ADD CONSTRAINT [FK_ROUTEAB_THERAPY]
    FOREIGN KEY ([ROUTEId])
    REFERENCES [dbo].[Routes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ROUTEAB_THERAPY'
CREATE INDEX [IX_FK_ROUTEAB_THERAPY]
ON [dbo].[AbTherapys]
    ([ROUTEId]);
GO

-- Creating foreign key on [DRUGId] in table 'AbTherapys'
ALTER TABLE [dbo].[AbTherapys]
ADD CONSTRAINT [FK_DRUGAB_THERAPY]
    FOREIGN KEY ([DRUGId])
    REFERENCES [dbo].[Drugs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DRUGAB_THERAPY'
CREATE INDEX [IX_FK_DRUGAB_THERAPY]
ON [dbo].[AbTherapys]
    ([DRUGId]);
GO

-- Creating foreign key on [TEST_FOR_PNEUMOCOCCAL_Id] in table 'CRFs'
ALTER TABLE [dbo].[CRFs]
ADD CONSTRAINT [FK_CRFTEST_FOR_PNEUMOCOCCAL]
    FOREIGN KEY ([TEST_FOR_PNEUMOCOCCAL_Id])
    REFERENCES [dbo].[TestForPneumococcals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFTEST_FOR_PNEUMOCOCCAL'
CREATE INDEX [IX_FK_CRFTEST_FOR_PNEUMOCOCCAL]
ON [dbo].[CRFs]
    ([TEST_FOR_PNEUMOCOCCAL_Id]);
GO

-- Creating foreign key on [CRFId] in table 'MicrobiologySputums'
ALTER TABLE [dbo].[MicrobiologySputums]
ADD CONSTRAINT [FK_CRFMICROBIOLOGY_SPUTUM]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFMICROBIOLOGY_SPUTUM'
CREATE INDEX [IX_FK_CRFMICROBIOLOGY_SPUTUM]
ON [dbo].[MicrobiologySputums]
    ([CRFId]);
GO

-- Creating foreign key on [CRFId] in table 'MicrobiologyBloods'
ALTER TABLE [dbo].[MicrobiologyBloods]
ADD CONSTRAINT [FK_CRFMICROBIOLOGY_BLOOD]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFMICROBIOLOGY_BLOOD'
CREATE INDEX [IX_FK_CRFMICROBIOLOGY_BLOOD]
ON [dbo].[MicrobiologyBloods]
    ([CRFId]);
GO

-- Creating foreign key on [ORGANISMId] in table 'MicrobiologyBloods'
ALTER TABLE [dbo].[MicrobiologyBloods]
ADD CONSTRAINT [FK_ORGANISMMICROBIOLOGY_BLOOD]
    FOREIGN KEY ([ORGANISMId])
    REFERENCES [dbo].[Organisms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ORGANISMMICROBIOLOGY_BLOOD'
CREATE INDEX [IX_FK_ORGANISMMICROBIOLOGY_BLOOD]
ON [dbo].[MicrobiologyBloods]
    ([ORGANISMId]);
GO

-- Creating foreign key on [ORGANISMId] in table 'MicrobiologySputums'
ALTER TABLE [dbo].[MicrobiologySputums]
ADD CONSTRAINT [FK_ORGANISMMICROBIOLOGY_SPUTUM]
    FOREIGN KEY ([ORGANISMId])
    REFERENCES [dbo].[Organisms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ORGANISMMICROBIOLOGY_SPUTUM'
CREATE INDEX [IX_FK_ORGANISMMICROBIOLOGY_SPUTUM]
ON [dbo].[MicrobiologySputums]
    ([ORGANISMId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------