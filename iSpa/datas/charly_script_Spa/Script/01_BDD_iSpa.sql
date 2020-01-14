-- ====================================================================
-- Script : 01_iSpa.sql
-- Objet  : Création BDD iSpa sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ---------------------------------------------
-- 1.0	     CS   12.11.19    Création
-- ====================================================================

SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Création des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_iSpa.log
@.\02_utilisateurs_iSpa.sql
SPOOL OFF

-- Connexion à HEGLOCAL en tant que iSpa_data (propirétaires des objets de schéma)
CONNECT iSpa_data/iSpa_data@HEGLOCAL

-- Création des tables
SPOOL .\Logs\03_tables_iSpa.log
@.\03_tables_iSpa.sql
SPOOL OFF

-- Chargement des données
SPOOL .\Logs\04_insertions_iSpa.log
@.\04_insertions_iSpa.sql;
SPOOL OFF

-- Création des vues
SPOOL .\Logs\05_vues_iSpa.log
@.\05_vues_iSpa.sql
SPOOL OFF

-- Création des triggers pour les clefs primaires
SPOOL .\Logs\06_triggers_iSpa.log
@.\06_triggers_iSpa.sql;
SPOOL OFF

-- Création des packages
SPOOL .\Logs\07_package_iSpa.log
@.\07_package_iSpa.sql;
SPOOL OFF

-- Connexion à HEGLOCAL en tant que system
CONNECT system/manager@HEGLOCAL

-- Création des synonymes
SPOOL .\Logs\08_synonymes_iSpa.log
@.\08_synonymes_iSpa.sql;
SPOOL OFF

SET ECHO OFF


