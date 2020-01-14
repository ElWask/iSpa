REM Fichier		: BDD_iSpa.cmd
REM Objet		: Désinstallation de la BDD iSpa 

mkdir .\Logs

REM Lancement du script uninstall_iSpa.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/manager@HEGLOCAL @%~dp0\uninstall_iSpa.sql @%~dp0