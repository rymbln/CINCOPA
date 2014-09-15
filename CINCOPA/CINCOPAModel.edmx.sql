
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2014 14:51:35
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
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFWARD];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_ONE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFVISIT_ONE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_ONE_ONE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFVISIT_ONE_ONE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_THREE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFVISIT_THREE];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFVISIT_TWO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFVISIT_TWO];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFADVERSE_EVENT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ADVERSE_EVENTSet] DROP CONSTRAINT [FK_CRFADVERSE_EVENT];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEANAMNESTIC_DATA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEANAMNESTIC_DATA];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONEXRAY_CHEST_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONEXRAY_CHEST_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONESet] DROP CONSTRAINT [FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_TWOSet] DROP CONSTRAINT [FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_TWOSet] DROP CONSTRAINT [FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_THREESet] DROP CONSTRAINT [FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_ONE_ONESet] DROP CONSTRAINT [FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_CLINICAL_ANALYSIS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFBLOOD_CLINICAL_ANALYSIS];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFBLOOD_CHEMISTRY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFBLOOD_CHEMISTRY];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AB_THERAPYSet] DROP CONSTRAINT [FK_CRFAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_ROUTEAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AB_THERAPYSet] DROP CONSTRAINT [FK_ROUTEAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_DRUGAB_THERAPY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AB_THERAPYSet] DROP CONSTRAINT [FK_DRUGAB_THERAPY];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFTEST_FOR_PNEUMOCOCCAL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRFSet] DROP CONSTRAINT [FK_CRFTEST_FOR_PNEUMOCOCCAL];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFMICROBIOLOGY_SPUTUM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MICROBIOLOGY_SPUTUMSet] DROP CONSTRAINT [FK_CRFMICROBIOLOGY_SPUTUM];
GO
IF OBJECT_ID(N'[dbo].[FK_CRFMICROBIOLOGY_BLOOD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MICROBIOLOGY_BLOODSet] DROP CONSTRAINT [FK_CRFMICROBIOLOGY_BLOOD];
GO
IF OBJECT_ID(N'[dbo].[FK_ORGANISMMICROBIOLOGY_BLOOD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MICROBIOLOGY_BLOODSet] DROP CONSTRAINT [FK_ORGANISMMICROBIOLOGY_BLOOD];
GO
IF OBJECT_ID(N'[dbo].[FK_ORGANISMMICROBIOLOGY_SPUTUM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MICROBIOLOGY_SPUTUMSet] DROP CONSTRAINT [FK_ORGANISMMICROBIOLOGY_SPUTUM];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CRFSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRFSet];
GO
IF OBJECT_ID(N'[dbo].[WARDSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WARDSet];
GO
IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO
IF OBJECT_ID(N'[dbo].[VISIT_ONESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VISIT_ONESet];
GO
IF OBJECT_ID(N'[dbo].[VISIT_ONE_ONESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VISIT_ONE_ONESet];
GO
IF OBJECT_ID(N'[dbo].[VISIT_TWOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VISIT_TWOSet];
GO
IF OBJECT_ID(N'[dbo].[VISIT_THREESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VISIT_THREESet];
GO
IF OBJECT_ID(N'[dbo].[ADVERSE_EVENTSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ADVERSE_EVENTSet];
GO
IF OBJECT_ID(N'[dbo].[BASE_LIVE_INDICATORS_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[ANAMNESTIC_DATA_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ANAMNESTIC_DATA_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[EVALUATION_OF_SYMPTOMS_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[ELECTROCARDIOGRAPHY_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ELECTROCARDIOGRAPHY_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[ECHOCARDIOGRAPHY_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[XRAY_CHEST_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[XRAY_CHEST_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set];
GO
IF OBJECT_ID(N'[dbo].[BASE_LIVE_INDICATORS_VISIT_2Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_2Set];
GO
IF OBJECT_ID(N'[dbo].[EVALUATION_OF_SYMPTOMS_VISIT_2Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_2Set];
GO
IF OBJECT_ID(N'[dbo].[ECHOCARDIOGRAPHY_VISIT_3Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_3Set];
GO
IF OBJECT_ID(N'[dbo].[EVALUATION_OF_SYMPTOMS_VISIT_11Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_11Set];
GO
IF OBJECT_ID(N'[dbo].[BLOOD_CLINICAL_ANALYSISSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BLOOD_CLINICAL_ANALYSISSet];
GO
IF OBJECT_ID(N'[dbo].[BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet];
GO
IF OBJECT_ID(N'[dbo].[BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet];
GO
IF OBJECT_ID(N'[dbo].[BLOOD_CHEMISTRYSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BLOOD_CHEMISTRYSet];
GO
IF OBJECT_ID(N'[dbo].[ORGANISMSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORGANISMSet];
GO
IF OBJECT_ID(N'[dbo].[ROUTESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ROUTESet];
GO
IF OBJECT_ID(N'[dbo].[DRUGSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRUGSet];
GO
IF OBJECT_ID(N'[dbo].[AB_THERAPYSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AB_THERAPYSet];
GO
IF OBJECT_ID(N'[dbo].[TEST_FOR_PNEUMOCOCCALSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TEST_FOR_PNEUMOCOCCALSet];
GO
IF OBJECT_ID(N'[dbo].[MICROBIOLOGY_SPUTUMSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MICROBIOLOGY_SPUTUMSet];
GO
IF OBJECT_ID(N'[dbo].[MICROBIOLOGY_BLOODSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MICROBIOLOGY_BLOODSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CRFSet'
CREATE TABLE [dbo].[CRFSet] (
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
    [StateCode] nvarchar(max)  NOT NULL,
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

-- Creating table 'WARDSet'
CREATE TABLE [dbo].[WARDSet] (
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

-- Creating table 'VISIT_ONESet'
CREATE TABLE [dbo].[VISIT_ONESet] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL,
    [BASE_LIVE_INDICATORS_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ANAMNESTIC_DATA_Id] uniqueidentifier  NOT NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ELECTROCARDIOGRAPHY_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [ECHOCARDIOGRAPHY_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [XRAY_CHEST_VISIT_1_Id] uniqueidentifier  NOT NULL,
    [COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VISIT_ONE_ONESet'
CREATE TABLE [dbo].[VISIT_ONE_ONESet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_11_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VISIT_TWOSet'
CREATE TABLE [dbo].[VISIT_TWOSet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL,
    [CRFId1] uniqueidentifier  NOT NULL,
    [BASE_LIVE_INDICATORS_VISIT_2_Id] uniqueidentifier  NOT NULL,
    [EVALUATION_OF_SYMPTOMS_VISIT_2_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'VISIT_THREESet'
CREATE TABLE [dbo].[VISIT_THREESet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_VISIT] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL,
    [ECHOCARDIOGRAPHY_VISIT_3_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ADVERSE_EVENTSet'
CREATE TABLE [dbo].[ADVERSE_EVENTSet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [DATE_START] datetime  NOT NULL,
    [DATE_END] datetime  NOT NULL,
    [HEAVY] nvarchar(max)  NOT NULL,
    [RESULT] nvarchar(max)  NOT NULL,
    [RELATION] nvarchar(max)  NOT NULL,
    [ACTIONS] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BASE_LIVE_INDICATORS_VISIT_1Set'
CREATE TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [BLOOD_PRESSURE_RIGHT_HAND] int  NOT NULL,
    [BLOOD_PRESSURE_LEFT_HAND] int  NOT NULL,
    [HEART_RATE] int  NOT NULL,
    [RESPIRATORY_RATE] int  NOT NULL,
    [TEMPERATURE] decimal(18,0)  NOT NULL,
    [HEAVY_TYPE] nvarchar(max)  NOT NULL,
    [OXYGEN_THERAPY_NEEDED] nvarchar(max)  NOT NULL,
    [DECOMPENSATION_SIGNS] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ANAMNESTIC_DATA_VISIT_1Set'
CREATE TABLE [dbo].[ANAMNESTIC_DATA_VISIT_1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_SYMPTOM] datetime  NULL,
    [DATE_DIAGNOSIS] datetime  NULL,
    [NUMBER_EPISODES] int  NULL,
    [NUMBER_EPISODES_NODATA] bit  NOT NULL,
    [FUNCTION_CLASS] nvarchar(max)  NULL,
    [OTHER_EPISODES] nvarchar(max)  NOT NULL,
    [SMOKE_STATUS] nvarchar(max)  NOT NULL,
    [SMOKE_AVERAGE] int  NOT NULL,
    [SMOKE_YEARS] int  NOT NULL,
    [SMOKE_PACK_YEARS] decimal(18,0)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EVALUATION_OF_SYMPTOMS_VISIT_1Set'
CREATE TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NOT NULL,
    [COUGH] nvarchar(max)  NOT NULL,
    [SPUTUM] nvarchar(max)  NOT NULL,
    [SPUTUM_TYPE] nvarchar(max)  NOT NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NOT NULL,
    [COLD_SYMPTOM] nvarchar(max)  NOT NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NOT NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NOT NULL,
    [CREPITUS] nvarchar(max)  NOT NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NOT NULL,
    [DRY_RALES] nvarchar(max)  NOT NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ELECTROCARDIOGRAPHY_VISIT_1Set'
CREATE TABLE [dbo].[ELECTROCARDIOGRAPHY_VISIT_1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NOT NULL,
    [SINUS_RHYTHM] bit  NOT NULL,
    [ATRIAL_FIBRILLATION] bit  NOT NULL,
    [ARRYTHMIA_SUPRAVENTRICULAR] bit  NOT NULL,
    [ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS] bit  NOT NULL,
    [HEART_RATE] int  NOT NULL,
    [SIGNIFICANT_CHANGES] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ECHOCARDIOGRAPHY_VISIT_1Set'
CREATE TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_1Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NOT NULL,
    [FV_PERCENT] decimal(18,0)  NOT NULL,
    [EA_LJ] decimal(18,0)  NOT NULL,
    [EA_RJ] decimal(18,0)  NOT NULL,
    [SDLA] decimal(18,0)  NOT NULL,
    [AMOUNT_OF_PERICARDIAL_EFFUSION] decimal(18,0)  NOT NULL,
    [COMMENTS] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'XRAY_CHEST_VISIT_1Set'
CREATE TABLE [dbo].[XRAY_CHEST_VISIT_1Set] (
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
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set'
CREATE TABLE [dbo].[COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set] (
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
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BASE_LIVE_INDICATORS_VISIT_2Set'
CREATE TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_2Set] (
    [Id] uniqueidentifier  NOT NULL,
    [BLOOD_PRESSURE_RIGHT_HAND] int  NOT NULL,
    [BLOOD_PRESSURE_LEFT_HAND] int  NOT NULL,
    [HEART_RATE] int  NOT NULL,
    [RESPIRATORY_RATE] int  NOT NULL,
    [TEMPERATURE] decimal(18,0)  NOT NULL,
    [HEAVY_TYPE] nvarchar(max)  NOT NULL,
    [OXYGEN_THERAPY_NEEDED] nvarchar(max)  NOT NULL,
    [DECOMPENSATION_SIGNS] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EVALUATION_OF_SYMPTOMS_VISIT_2Set'
CREATE TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_2Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NOT NULL,
    [COUGH] nvarchar(max)  NOT NULL,
    [SPUTUM] nvarchar(max)  NOT NULL,
    [SPUTUM_TYPE] nvarchar(max)  NOT NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NOT NULL,
    [COLD_SYMPTOM] nvarchar(max)  NOT NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NOT NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NOT NULL,
    [CREPITUS] nvarchar(max)  NOT NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NOT NULL,
    [DRY_RALES] nvarchar(max)  NOT NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ECHOCARDIOGRAPHY_VISIT_3Set'
CREATE TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_3Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DATE_PROCEDURE] datetime  NOT NULL,
    [FV_PERCENT] decimal(18,0)  NOT NULL,
    [EA_LJ] decimal(18,0)  NOT NULL,
    [EA_RJ] decimal(18,0)  NOT NULL,
    [SDLA] decimal(18,0)  NOT NULL,
    [AMOUNT_OF_PERICARDIAL_EFFUSION] decimal(18,0)  NOT NULL,
    [COMMENTS] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EVALUATION_OF_SYMPTOMS_VISIT_11Set'
CREATE TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_11Set] (
    [Id] uniqueidentifier  NOT NULL,
    [DYSPNEA] nvarchar(max)  NOT NULL,
    [COUGH] nvarchar(max)  NOT NULL,
    [SPUTUM] nvarchar(max)  NOT NULL,
    [SPUTUM_TYPE] nvarchar(max)  NOT NULL,
    [TEMPERATURE_INCREASE] nvarchar(max)  NOT NULL,
    [COLD_SYMPTOM] nvarchar(max)  NOT NULL,
    [SHORTERING_OF_PERCUSSION_SOUNDS] nvarchar(max)  NOT NULL,
    [MOIST_RALES_SOUNDS] nvarchar(max)  NOT NULL,
    [CREPITUS] nvarchar(max)  NOT NULL,
    [PLEURAL_FRICTION_NOISE] nvarchar(max)  NOT NULL,
    [DRY_RALES] nvarchar(max)  NOT NULL,
    [PRESENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [INCIDENCE_OF_EDEMA] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BLOOD_CLINICAL_ANALYSISSet'
CREATE TABLE [dbo].[BLOOD_CLINICAL_ANALYSISSet] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_ONE_LEUKOCYTOSIS] decimal(18,0)  NULL,
    [VISIT_ONE_LUKOCYTOSIS_YOUNG_FORMS] nvarchar(max)  NULL,
    [VISIT_ONE_OTHERS] nvarchar(max)  NULL,
    [VISIT_TWO_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_LEUKOCYTOSIS] decimal(18,0)  NULL,
    [VISIT_TWO_LUKOCYTOSIS_YOUNG_FORMS] nvarchar(max)  NULL,
    [VISIT_TWO_OTHERS] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet'
CREATE TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet] (
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
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet'
CREATE TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet] (
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
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BLOOD_CHEMISTRYSet'
CREATE TABLE [dbo].[BLOOD_CHEMISTRYSet] (
    [Id] uniqueidentifier  NOT NULL,
    [VISIT_ONE_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_ONE_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_SIGNIFICANT_CHANGES] nvarchar(max)  NULL,
    [VISIT_TWO_CHANGES] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ORGANISMSet'
CREATE TABLE [dbo].[ORGANISMSet] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ROUTESet'
CREATE TABLE [dbo].[ROUTESet] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DRUGSet'
CREATE TABLE [dbo].[DRUGSet] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [MNN] nvarchar(max)  NOT NULL,
    [GROUP] nvarchar(max)  NOT NULL,
    [CODE] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AB_THERAPYSet'
CREATE TABLE [dbo].[AB_THERAPYSet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DRUGId] uniqueidentifier  NOT NULL,
    [ROUTEId] uniqueidentifier  NOT NULL,
    [SINGLE_DOSE] nvarchar(max)  NULL,
    [FREQUENCY] nvarchar(max)  NULL,
    [DATE_START] nvarchar(max)  NULL,
    [DATE_END] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TEST_FOR_PNEUMOCOCCALSet'
CREATE TABLE [dbo].[TEST_FOR_PNEUMOCOCCALSet] (
    [Id] uniqueidentifier  NOT NULL,
    [LOGIC] nvarchar(max)  NOT NULL,
    [RESULT] nvarchar(max)  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MICROBIOLOGY_SPUTUMSet'
CREATE TABLE [dbo].[MICROBIOLOGY_SPUTUMSet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_CAPTURE] nvarchar(max)  NULL,
    [LAB_NUMBER] nvarchar(max)  NULL,
    [QUALITY_LEUKOCYTES] nvarchar(max)  NULL,
    [QUALITY_EPITHELIAL] nvarchar(max)  NULL,
    [NOT_REPRESENTATIVE] bit  NULL,
    [GROWTH_PATHOGENS] nvarchar(max)  NULL,
    [ORGANISMId1] uniqueidentifier  NULL,
    [ORGANISMId] uniqueidentifier  NOT NULL,
    [BETA] nvarchar(max)  NULL,
    [MRSA] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MICROBIOLOGY_BLOODSet'
CREATE TABLE [dbo].[MICROBIOLOGY_BLOODSet] (
    [Id] uniqueidentifier  NOT NULL,
    [CRFId] uniqueidentifier  NOT NULL,
    [DATE_CAPTURE] nvarchar(max)  NULL,
    [LAB_NUMBER] nvarchar(max)  NULL,
    [GROWTH_PATHOGENS] nvarchar(max)  NULL,
    [ORGANISMId] uniqueidentifier  NOT NULL,
    [ORGANISMId1] uniqueidentifier  NULL,
    [BETA] nvarchar(max)  NULL,
    [MRSA] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [CreatedByDate] nvarchar(max)  NOT NULL,
    [UpdatedBy] nvarchar(max)  NOT NULL,
    [UpdatedByDate] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [PK_CRFSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WARDSet'
ALTER TABLE [dbo].[WARDSet]
ADD CONSTRAINT [PK_WARDSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [PK_VISIT_ONESet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VISIT_ONE_ONESet'
ALTER TABLE [dbo].[VISIT_ONE_ONESet]
ADD CONSTRAINT [PK_VISIT_ONE_ONESet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VISIT_TWOSet'
ALTER TABLE [dbo].[VISIT_TWOSet]
ADD CONSTRAINT [PK_VISIT_TWOSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VISIT_THREESet'
ALTER TABLE [dbo].[VISIT_THREESet]
ADD CONSTRAINT [PK_VISIT_THREESet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ADVERSE_EVENTSet'
ALTER TABLE [dbo].[ADVERSE_EVENTSet]
ADD CONSTRAINT [PK_ADVERSE_EVENTSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BASE_LIVE_INDICATORS_VISIT_1Set'
ALTER TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_1Set]
ADD CONSTRAINT [PK_BASE_LIVE_INDICATORS_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ANAMNESTIC_DATA_VISIT_1Set'
ALTER TABLE [dbo].[ANAMNESTIC_DATA_VISIT_1Set]
ADD CONSTRAINT [PK_ANAMNESTIC_DATA_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EVALUATION_OF_SYMPTOMS_VISIT_1Set'
ALTER TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_1Set]
ADD CONSTRAINT [PK_EVALUATION_OF_SYMPTOMS_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ELECTROCARDIOGRAPHY_VISIT_1Set'
ALTER TABLE [dbo].[ELECTROCARDIOGRAPHY_VISIT_1Set]
ADD CONSTRAINT [PK_ELECTROCARDIOGRAPHY_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ECHOCARDIOGRAPHY_VISIT_1Set'
ALTER TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_1Set]
ADD CONSTRAINT [PK_ECHOCARDIOGRAPHY_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'XRAY_CHEST_VISIT_1Set'
ALTER TABLE [dbo].[XRAY_CHEST_VISIT_1Set]
ADD CONSTRAINT [PK_XRAY_CHEST_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set'
ALTER TABLE [dbo].[COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set]
ADD CONSTRAINT [PK_COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BASE_LIVE_INDICATORS_VISIT_2Set'
ALTER TABLE [dbo].[BASE_LIVE_INDICATORS_VISIT_2Set]
ADD CONSTRAINT [PK_BASE_LIVE_INDICATORS_VISIT_2Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EVALUATION_OF_SYMPTOMS_VISIT_2Set'
ALTER TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_2Set]
ADD CONSTRAINT [PK_EVALUATION_OF_SYMPTOMS_VISIT_2Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ECHOCARDIOGRAPHY_VISIT_3Set'
ALTER TABLE [dbo].[ECHOCARDIOGRAPHY_VISIT_3Set]
ADD CONSTRAINT [PK_ECHOCARDIOGRAPHY_VISIT_3Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EVALUATION_OF_SYMPTOMS_VISIT_11Set'
ALTER TABLE [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_11Set]
ADD CONSTRAINT [PK_EVALUATION_OF_SYMPTOMS_VISIT_11Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BLOOD_CLINICAL_ANALYSISSet'
ALTER TABLE [dbo].[BLOOD_CLINICAL_ANALYSISSet]
ADD CONSTRAINT [PK_BLOOD_CLINICAL_ANALYSISSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet'
ALTER TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet]
ADD CONSTRAINT [PK_BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet'
ALTER TABLE [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet]
ADD CONSTRAINT [PK_BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BLOOD_CHEMISTRYSet'
ALTER TABLE [dbo].[BLOOD_CHEMISTRYSet]
ADD CONSTRAINT [PK_BLOOD_CHEMISTRYSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORGANISMSet'
ALTER TABLE [dbo].[ORGANISMSet]
ADD CONSTRAINT [PK_ORGANISMSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ROUTESet'
ALTER TABLE [dbo].[ROUTESet]
ADD CONSTRAINT [PK_ROUTESet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DRUGSet'
ALTER TABLE [dbo].[DRUGSet]
ADD CONSTRAINT [PK_DRUGSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AB_THERAPYSet'
ALTER TABLE [dbo].[AB_THERAPYSet]
ADD CONSTRAINT [PK_AB_THERAPYSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TEST_FOR_PNEUMOCOCCALSet'
ALTER TABLE [dbo].[TEST_FOR_PNEUMOCOCCALSet]
ADD CONSTRAINT [PK_TEST_FOR_PNEUMOCOCCALSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MICROBIOLOGY_SPUTUMSet'
ALTER TABLE [dbo].[MICROBIOLOGY_SPUTUMSet]
ADD CONSTRAINT [PK_MICROBIOLOGY_SPUTUMSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MICROBIOLOGY_BLOODSet'
ALTER TABLE [dbo].[MICROBIOLOGY_BLOODSet]
ADD CONSTRAINT [PK_MICROBIOLOGY_BLOODSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [WARDId] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFWARD]
    FOREIGN KEY ([WARDId])
    REFERENCES [dbo].[WARDSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFWARD'
CREATE INDEX [IX_FK_CRFWARD]
ON [dbo].[CRFSet]
    ([WARDId]);
GO

-- Creating foreign key on [VISIT_ONE_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFVISIT_ONE]
    FOREIGN KEY ([VISIT_ONE_Id])
    REFERENCES [dbo].[VISIT_ONESet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_ONE'
CREATE INDEX [IX_FK_CRFVISIT_ONE]
ON [dbo].[CRFSet]
    ([VISIT_ONE_Id]);
GO

-- Creating foreign key on [VISIT_ONE_ONE_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFVISIT_ONE_ONE]
    FOREIGN KEY ([VISIT_ONE_ONE_Id])
    REFERENCES [dbo].[VISIT_ONE_ONESet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_ONE_ONE'
CREATE INDEX [IX_FK_CRFVISIT_ONE_ONE]
ON [dbo].[CRFSet]
    ([VISIT_ONE_ONE_Id]);
GO

-- Creating foreign key on [VISIT_THREE_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFVISIT_THREE]
    FOREIGN KEY ([VISIT_THREE_Id])
    REFERENCES [dbo].[VISIT_THREESet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_THREE'
CREATE INDEX [IX_FK_CRFVISIT_THREE]
ON [dbo].[CRFSet]
    ([VISIT_THREE_Id]);
GO

-- Creating foreign key on [VISIT_TWO_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFVISIT_TWO]
    FOREIGN KEY ([VISIT_TWO_Id])
    REFERENCES [dbo].[VISIT_TWOSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFVISIT_TWO'
CREATE INDEX [IX_FK_CRFVISIT_TWO]
ON [dbo].[CRFSet]
    ([VISIT_TWO_Id]);
GO

-- Creating foreign key on [CRFId] in table 'ADVERSE_EVENTSet'
ALTER TABLE [dbo].[ADVERSE_EVENTSet]
ADD CONSTRAINT [FK_CRFADVERSE_EVENT]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFADVERSE_EVENT'
CREATE INDEX [IX_FK_CRFADVERSE_EVENT]
ON [dbo].[ADVERSE_EVENTSet]
    ([CRFId]);
GO

-- Creating foreign key on [BASE_LIVE_INDICATORS_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]
    FOREIGN KEY ([BASE_LIVE_INDICATORS_VISIT_1_Id])
    REFERENCES [dbo].[BASE_LIVE_INDICATORS_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEBASE_LIVE_INDICATORS_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([BASE_LIVE_INDICATORS_VISIT_1_Id]);
GO

-- Creating foreign key on [ANAMNESTIC_DATA_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEANAMNESTIC_DATA]
    FOREIGN KEY ([ANAMNESTIC_DATA_Id])
    REFERENCES [dbo].[ANAMNESTIC_DATA_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEANAMNESTIC_DATA'
CREATE INDEX [IX_FK_VISIT_ONEANAMNESTIC_DATA]
ON [dbo].[VISIT_ONESet]
    ([ANAMNESTIC_DATA_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_1_Id])
    REFERENCES [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEEVALUATION_OF_SYMPTOMS_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([EVALUATION_OF_SYMPTOMS_VISIT_1_Id]);
GO

-- Creating foreign key on [ELECTROCARDIOGRAPHY_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]
    FOREIGN KEY ([ELECTROCARDIOGRAPHY_VISIT_1_Id])
    REFERENCES [dbo].[ELECTROCARDIOGRAPHY_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEELECTROCARDIOGRAPHY_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([ELECTROCARDIOGRAPHY_VISIT_1_Id]);
GO

-- Creating foreign key on [ECHOCARDIOGRAPHY_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]
    FOREIGN KEY ([ECHOCARDIOGRAPHY_VISIT_1_Id])
    REFERENCES [dbo].[ECHOCARDIOGRAPHY_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEECHOCARDIOGRAPHY_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([ECHOCARDIOGRAPHY_VISIT_1_Id]);
GO

-- Creating foreign key on [XRAY_CHEST_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONEXRAY_CHEST_VISIT_1]
    FOREIGN KEY ([XRAY_CHEST_VISIT_1_Id])
    REFERENCES [dbo].[XRAY_CHEST_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONEXRAY_CHEST_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONEXRAY_CHEST_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([XRAY_CHEST_VISIT_1_Id]);
GO

-- Creating foreign key on [COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id] in table 'VISIT_ONESet'
ALTER TABLE [dbo].[VISIT_ONESet]
ADD CONSTRAINT [FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]
    FOREIGN KEY ([COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id])
    REFERENCES [dbo].[COMPUTED_TOMOGRAPHY_CHEST_VISIT_1Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1'
CREATE INDEX [IX_FK_VISIT_ONECOMPUTED_TOMOGRAPHY_CHEST_VISIT_1]
ON [dbo].[VISIT_ONESet]
    ([COMPUTED_TOMOGRAPHY_CHEST_VISIT_1_Id]);
GO

-- Creating foreign key on [BASE_LIVE_INDICATORS_VISIT_2_Id] in table 'VISIT_TWOSet'
ALTER TABLE [dbo].[VISIT_TWOSet]
ADD CONSTRAINT [FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]
    FOREIGN KEY ([BASE_LIVE_INDICATORS_VISIT_2_Id])
    REFERENCES [dbo].[BASE_LIVE_INDICATORS_VISIT_2Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2'
CREATE INDEX [IX_FK_VISIT_TWOBASE_LIVE_INDICATORS_VISIT_2]
ON [dbo].[VISIT_TWOSet]
    ([BASE_LIVE_INDICATORS_VISIT_2_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_2_Id] in table 'VISIT_TWOSet'
ALTER TABLE [dbo].[VISIT_TWOSet]
ADD CONSTRAINT [FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_2_Id])
    REFERENCES [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_2Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2'
CREATE INDEX [IX_FK_VISIT_TWOEVALUATION_OF_SYMPTOMS_VISIT_2]
ON [dbo].[VISIT_TWOSet]
    ([EVALUATION_OF_SYMPTOMS_VISIT_2_Id]);
GO

-- Creating foreign key on [ECHOCARDIOGRAPHY_VISIT_3_Id] in table 'VISIT_THREESet'
ALTER TABLE [dbo].[VISIT_THREESet]
ADD CONSTRAINT [FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]
    FOREIGN KEY ([ECHOCARDIOGRAPHY_VISIT_3_Id])
    REFERENCES [dbo].[ECHOCARDIOGRAPHY_VISIT_3Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3'
CREATE INDEX [IX_FK_VISIT_THREEECHOCARDIOGRAPHY_VISIT_3]
ON [dbo].[VISIT_THREESet]
    ([ECHOCARDIOGRAPHY_VISIT_3_Id]);
GO

-- Creating foreign key on [EVALUATION_OF_SYMPTOMS_VISIT_11_Id] in table 'VISIT_ONE_ONESet'
ALTER TABLE [dbo].[VISIT_ONE_ONESet]
ADD CONSTRAINT [FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]
    FOREIGN KEY ([EVALUATION_OF_SYMPTOMS_VISIT_11_Id])
    REFERENCES [dbo].[EVALUATION_OF_SYMPTOMS_VISIT_11Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11'
CREATE INDEX [IX_FK_VISIT_ONE_ONEEVALUATION_OF_SYMPTOMS_VISIT_11]
ON [dbo].[VISIT_ONE_ONESet]
    ([EVALUATION_OF_SYMPTOMS_VISIT_11_Id]);
GO

-- Creating foreign key on [BLOOD_CLINICAL_ANALYSIS_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFBLOOD_CLINICAL_ANALYSIS]
    FOREIGN KEY ([BLOOD_CLINICAL_ANALYSIS_Id])
    REFERENCES [dbo].[BLOOD_CLINICAL_ANALYSISSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_CLINICAL_ANALYSIS'
CREATE INDEX [IX_FK_CRFBLOOD_CLINICAL_ANALYSIS]
ON [dbo].[CRFSet]
    ([BLOOD_CLINICAL_ANALYSIS_Id]);
GO

-- Creating foreign key on [BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]
    FOREIGN KEY ([BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id])
    REFERENCES [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATIONSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION'
CREATE INDEX [IX_FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION]
ON [dbo].[CRFSet]
    ([BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION_Id]);
GO

-- Creating foreign key on [BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]
    FOREIGN KEY ([BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id])
    REFERENCES [dbo].[BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTIONSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION'
CREATE INDEX [IX_FK_CRFBLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION]
ON [dbo].[CRFSet]
    ([BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION_Id]);
GO

-- Creating foreign key on [BLOOD_CHEMISTRY_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFBLOOD_CHEMISTRY]
    FOREIGN KEY ([BLOOD_CHEMISTRY_Id])
    REFERENCES [dbo].[BLOOD_CHEMISTRYSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFBLOOD_CHEMISTRY'
CREATE INDEX [IX_FK_CRFBLOOD_CHEMISTRY]
ON [dbo].[CRFSet]
    ([BLOOD_CHEMISTRY_Id]);
GO

-- Creating foreign key on [CRFId] in table 'AB_THERAPYSet'
ALTER TABLE [dbo].[AB_THERAPYSet]
ADD CONSTRAINT [FK_CRFAB_THERAPY]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFAB_THERAPY'
CREATE INDEX [IX_FK_CRFAB_THERAPY]
ON [dbo].[AB_THERAPYSet]
    ([CRFId]);
GO

-- Creating foreign key on [ROUTEId] in table 'AB_THERAPYSet'
ALTER TABLE [dbo].[AB_THERAPYSet]
ADD CONSTRAINT [FK_ROUTEAB_THERAPY]
    FOREIGN KEY ([ROUTEId])
    REFERENCES [dbo].[ROUTESet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ROUTEAB_THERAPY'
CREATE INDEX [IX_FK_ROUTEAB_THERAPY]
ON [dbo].[AB_THERAPYSet]
    ([ROUTEId]);
GO

-- Creating foreign key on [DRUGId] in table 'AB_THERAPYSet'
ALTER TABLE [dbo].[AB_THERAPYSet]
ADD CONSTRAINT [FK_DRUGAB_THERAPY]
    FOREIGN KEY ([DRUGId])
    REFERENCES [dbo].[DRUGSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DRUGAB_THERAPY'
CREATE INDEX [IX_FK_DRUGAB_THERAPY]
ON [dbo].[AB_THERAPYSet]
    ([DRUGId]);
GO

-- Creating foreign key on [TEST_FOR_PNEUMOCOCCAL_Id] in table 'CRFSet'
ALTER TABLE [dbo].[CRFSet]
ADD CONSTRAINT [FK_CRFTEST_FOR_PNEUMOCOCCAL]
    FOREIGN KEY ([TEST_FOR_PNEUMOCOCCAL_Id])
    REFERENCES [dbo].[TEST_FOR_PNEUMOCOCCALSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFTEST_FOR_PNEUMOCOCCAL'
CREATE INDEX [IX_FK_CRFTEST_FOR_PNEUMOCOCCAL]
ON [dbo].[CRFSet]
    ([TEST_FOR_PNEUMOCOCCAL_Id]);
GO

-- Creating foreign key on [CRFId] in table 'MICROBIOLOGY_SPUTUMSet'
ALTER TABLE [dbo].[MICROBIOLOGY_SPUTUMSet]
ADD CONSTRAINT [FK_CRFMICROBIOLOGY_SPUTUM]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFMICROBIOLOGY_SPUTUM'
CREATE INDEX [IX_FK_CRFMICROBIOLOGY_SPUTUM]
ON [dbo].[MICROBIOLOGY_SPUTUMSet]
    ([CRFId]);
GO

-- Creating foreign key on [CRFId] in table 'MICROBIOLOGY_BLOODSet'
ALTER TABLE [dbo].[MICROBIOLOGY_BLOODSet]
ADD CONSTRAINT [FK_CRFMICROBIOLOGY_BLOOD]
    FOREIGN KEY ([CRFId])
    REFERENCES [dbo].[CRFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CRFMICROBIOLOGY_BLOOD'
CREATE INDEX [IX_FK_CRFMICROBIOLOGY_BLOOD]
ON [dbo].[MICROBIOLOGY_BLOODSet]
    ([CRFId]);
GO

-- Creating foreign key on [ORGANISMId1] in table 'MICROBIOLOGY_BLOODSet'
ALTER TABLE [dbo].[MICROBIOLOGY_BLOODSet]
ADD CONSTRAINT [FK_ORGANISMMICROBIOLOGY_BLOOD]
    FOREIGN KEY ([ORGANISMId1])
    REFERENCES [dbo].[ORGANISMSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ORGANISMMICROBIOLOGY_BLOOD'
CREATE INDEX [IX_FK_ORGANISMMICROBIOLOGY_BLOOD]
ON [dbo].[MICROBIOLOGY_BLOODSet]
    ([ORGANISMId1]);
GO

-- Creating foreign key on [ORGANISMId1] in table 'MICROBIOLOGY_SPUTUMSet'
ALTER TABLE [dbo].[MICROBIOLOGY_SPUTUMSet]
ADD CONSTRAINT [FK_ORGANISMMICROBIOLOGY_SPUTUM]
    FOREIGN KEY ([ORGANISMId1])
    REFERENCES [dbo].[ORGANISMSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ORGANISMMICROBIOLOGY_SPUTUM'
CREATE INDEX [IX_FK_ORGANISMMICROBIOLOGY_SPUTUM]
ON [dbo].[MICROBIOLOGY_SPUTUMSet]
    ([ORGANISMId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------