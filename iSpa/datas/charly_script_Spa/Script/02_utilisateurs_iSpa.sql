-- ====================================================================
-- Script : 02_utilisateurs_iSpa.sql
-- Objet  : Création des utilisateurs BDD iSpa sur SGBD Oracle en Local (HEGLOCAL)
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     CS   12.11.19    Création utilisateurs
-- ====================================================================
-- =============================================================================================
-- Suppression des rôles, utilisateurs et profil
-- =============================================================================================
-- Suppression des utilisateurs
DROP USER iSpa_data CASCADE;
DROP USER iSpa_user CASCADE;

-- Suppression des rôles
DROP ROLE role_iSpa_data CASCADE;
DROP ROLE role_iSpa_user CASCADE;

-- Suppression du profil
DROP PROFILE iSpa_profil;

-- =============================================================================================
-- Création du profil
-- =============================================================================================
-- Création du profil iSpa_profil
CREATE PROFILE iSpa_profil LIMIT
	SESSIONS_PER_USER 3
	FAILED_LOGIN_ATTEMPTS 3 
	PASSWORD_LOCK_TIME 1/24
	PASSWORD_LIFE_TIME 180 
	PASSWORD_REUSE_TIME 180 
	PASSWORD_REUSE_MAX UNLIMITED
	PASSWORD_GRACE_TIME 7;

-- =============================================================================================
-- Création du rôle role_iSpa_data (rôle de l'utilisateur propriétaire des objets de la base)
-- =============================================================================================
-- Creation du rôle role_iSpa_data
CREATE ROLE role_iSpa_data;

-- droit de se connecter à la BDD
GRANT CONNECT TO role_iSpa_data;

-- droit de créer des triggers, séquence, tables, packages, ...
GRANT RESOURCE TO role_iSpa_data;

-- droit de créer des vues
GRANT CREATE VIEW TO role_iSpa_data;

-- droit de créer des synonymes
-- GRANT CREATE ANY SYNONYM TO role_iSpa_data;
-- ! fonctionne mais donne trop de privilèges, à éviter

-- ===============================
-- Création du rôle role_iSpa_user (rôle de l'utilisateur de l'application)
-- ===============================
-- Creation du rôle role_iSpa_user
CREATE ROLE role_iSpa_user;

-- droit de se connecter à la BDD
GRANT CREATE SESSION TO role_iSpa_user;

-- ===================================
-- Création de l'utilisateur iSpa_data (propriétaire des objets de schéma de la base)
-- ===================================
-- Creation de l'utilisateur iSpa_data 
CREATE USER iSpa_data
	PROFILE iSpa_profil
	IDENTIFIED BY iSpa_data
	DEFAULT TABLESPACE USERS
	TEMPORARY TABLESPACE TEMP
;
GRANT role_iSpa_data TO iSpa_data;
ALTER USER iSpa_data quota unlimited ON USERS;

--===================================
--Création de l'utilisateur iSpa_user (utilisateur de l'application)
--===================================
CREATE USER iSpa_user
	PROFILE iSpa_profil
	IDENTIFIED BY iSpa_user
;
GRANT role_iSpa_user TO iSpa_user;
