--------------------------------------------------------------------------------------------
--Script : uninstall_iSpa.sql
--Objet  : Création des synonymes de la BDD démonstration sur SGBD Oracle en Local (HEGLOCAL)
--
--Mise à jour des versions
--Version  Visa   Date      Commentaires
-------  ------ --------    ----------------------------------------------------------------
--1.0	     SC   12.11.19    Création
--------------------------------------------------------------------------------------------

-- Suppression des utilisateurs (CASCADE), rôles et profil
SPOOL .\Logs\uninstall_iSpa.log

--=============================================
--Suppression des rôles, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER iSpa_data CASCADE;
DROP USER iSpa_user CASCADE;

--Suppression des rôles
DROP ROLE role_iSpa_data CASCADE;
DROP ROLE role_iSpa_user CASCADE;

--Suppression du profil
DROP PROFILE iSpa_profil;

SPOOL OFF

EXIT;