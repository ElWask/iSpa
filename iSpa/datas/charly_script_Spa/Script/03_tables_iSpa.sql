-- ====================================================================
-- Script : 03_tables_iSpa.sql
-- Objet  : Création et suppression des tables iSpa 
-- ====================================================================
-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (12/11/2019 21:05:25)
-- -----------------------------------------------------------------------------
--      Nom de la base : MLR1
--      Projet : Espace de travail
--      Auteur : DSI
--      Date de dernière modification : 12/11/2019 21:04:24
-- -----------------------------------------------------------------------------

DROP TABLE PRODUCT_SPA CASCADE CONSTRAINTS;

DROP TABLE USER_SPA CASCADE CONSTRAINTS;

DROP TABLE AGENDA_SPA CASCADE CONSTRAINTS;

DROP TABLE CLIENT_SPA CASCADE CONSTRAINTS;

DROP TABLE FACTURE_SPA CASCADE CONSTRAINTS;

DROP TABLE A_ETE_VENDUE_PAR CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       TABLE : PRODUCT_SPA
-- -----------------------------------------------------------------------------

CREATE TABLE PRODUCT_SPA
   (
    PROD_ID NUMBER(4)  NOT NULL,
    PROD_NOM CHAR(32)  NULL,
    PROD_DESC CHAR(32)  NULL,
    PROD_FOURNISSEUR CHAR(32)  NULL,
    PROD_PRIX CHAR(32)  NULL
,   CONSTRAINT PK_PRODUCT_SPA PRIMARY KEY (PROD_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : USER_SPA
-- -----------------------------------------------------------------------------

CREATE TABLE USER_SPA
   (
    USR_ID NUMBER(4)  NOT NULL,
    USR_NOM CHAR(32)  NULL,
    USR_PWD CHAR(32)  NULL,
    USR_TYPE CHAR(32)  NULL,
    USR_ACTIF NUMBER(1)  NULL
,   CONSTRAINT PK_USER_SPA PRIMARY KEY (USR_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : AGENDA_SPA
-- -----------------------------------------------------------------------------

CREATE TABLE AGENDA_SPA
   (
    AGE_ID NUMBER(4)  NOT NULL,
    CLI_ID NUMBER(4)  NULL,
    USR_ID NUMBER(4)   NULL,
    AGE_DATE DATE  NULL,
    AGE_HEURE DATE  NULL,
    AGE_NOMCLIENT CHAR(32)  NULL,
    AGE_TYPE CHAR(32)  NULL
,   CONSTRAINT PK_AGENDA_SPA PRIMARY KEY (AGE_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE AGENDA_SPA
-- -----------------------------------------------------------------------------

CREATE UNIQUE INDEX I_FK_AGENDA_SPA_CLIENT_SPA
     ON AGENDA_SPA (CLI_ID ASC)
    ;

CREATE UNIQUE INDEX I_FK_AGENDA_SPA_USER_SPA
     ON AGENDA_SPA (USR_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : CLIENT_SPA
-- -----------------------------------------------------------------------------

CREATE TABLE CLIENT_SPA
   (
    CLI_ID NUMBER(4)  NOT NULL,
    CLI_PRENOM CHAR(32)  NULL,
    CLI_NOM CHAR(32)  NULL,
    CLI_DOB DATE  NULL,
    CLI_EMAIL CHAR(32)  NULL,
    CLI_ADRESSE CHAR(32)  NULL
,   CONSTRAINT PK_CLIENT_SPA PRIMARY KEY (CLI_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : FACTURE_SPA
-- -----------------------------------------------------------------------------

CREATE TABLE FACTURE_SPA
   (
    FACT_ID NUMBER(4)  NOT NULL,
    AGE_ID NUMBER(4)  NOT NULL,
    FACT_DATE DATE  NULL,
    FACT_HEURE DATE  NULL,
    FACT_NOMCLIENT CHAR(32)  NULL,
    FACT_TYPESEANCE CHAR(32)  NULL,
    FACT_PRIX CHAR(32)  NULL,
    FACT_PAYE NUMBER(1)  NULL
,   CONSTRAINT PK_FACTURE_SPA PRIMARY KEY (FACT_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FACTURE_SPA
-- -----------------------------------------------------------------------------

CREATE UNIQUE INDEX I_FK_FACTURE_SPA_AGENDA_SPA
     ON FACTURE_SPA (AGE_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : A_ETE_VENDUE_PAR
-- -----------------------------------------------------------------------------

CREATE TABLE A_ETE_VENDUE_PAR
   (
    PROD_ID NUMBER(4)  NOT NULL,
    FACT_ID CHAR(32)  NOT NULL,
    FACT_PROD_QTY NUMBER(2)  NULL,
    FACT_PROD_PRIX_UNIT NUMBER(10,2)  NULL
,   CONSTRAINT PK_A_ETE_VENDUE_PAR PRIMARY KEY (PROD_ID, FACT_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE AGENDA_SPA ADD (
     CONSTRAINT FK_AGENDA_SPA_CLIENT_SPA
          FOREIGN KEY (CLI_ID)
               REFERENCES CLIENT_SPA (CLI_ID))   ;

ALTER TABLE AGENDA_SPA ADD (
     CONSTRAINT FK_AGENDA_SPA_USER_SPA
          FOREIGN KEY (USR_ID)
               REFERENCES USER_SPA (USR_ID))   ;

ALTER TABLE FACTURE_SPA ADD (
     CONSTRAINT FK_FACTURE_SPA_AGENDA_SPA
          FOREIGN KEY (AGE_ID)
               REFERENCES AGENDA_SPA (AGE_ID))   ;

ALTER TABLE A_ETE_VENDUE_PAR ADD (
     CONSTRAINT FK_A_ETE_VENDUE_PAR_PRODUCT_SP
          FOREIGN KEY (PROD_ID)
               REFERENCES PRODUCT_SPA (PROD_ID))   ;

ALTER TABLE A_ETE_VENDUE_PAR ADD (
     CONSTRAINT FK_A_ETE_VENDUE_PAR_FACTURE_SP
          FOREIGN KEY (FACT_ID)
               REFERENCES FACTURE_SPA (FACT_ID))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------