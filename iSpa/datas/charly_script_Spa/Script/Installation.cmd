REM Fichier		: Installation.cmd
REM Objet		: Création de la BDD iSpa

mkdir .\Logs

REM Lancement du script 01_BDD_iSpa.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
SET NLS_LANG = FRENCH_FRANCE.UTF8 
sqlplus SYSTEM/manager@HEGLOCAL @%~dp0\01_BDD_iSpa.sql %~dp0
