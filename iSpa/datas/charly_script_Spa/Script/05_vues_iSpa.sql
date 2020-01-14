-- ======================================================================
--  Script: 05_vues_iSpa.sql 
--  Objet : Création des vues schéma de la base iSpa
--  Objectif : créer des vues et tester l'interrogation et la mise-à-jour à travers ces vues. 
-- ======================================================================

-- ====================================================
-- Création des VUES
-- ====================================================
-- ====================================================
-- Vue d'affichage des produits
-- ====================================================
CREATE OR REPLACE VIEW vw_produit(xNom, xDescription, xFournisseur, xPrix) AS
       SELECT PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX
       FROM PRODUCT_SPA 
         ORDER BY PROD_NOM
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_produit TO iSpa_user;
-- ====================================================
-- Vue d'affichage des users
-- ====================================================
CREATE OR REPLACE VIEW vw_user(xNom, xPassword, xType, xActif) AS
       SELECT USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF
       FROM USER_SPA 
         ORDER BY USR_NOM
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_user TO iSpa_user;
-- ====================================================
-- Vue d'affichage des agendas
-- ====================================================
CREATE OR REPLACE VIEW vw_agenda(xDate, xHeure, xNomClient, xType) AS
      SELECT AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE
      FROM AGENDA_SPA
      --INNER JOIN CLIENT_SPA ON CLIENT_SPA.CLI_ID = AGENDA_SPA.CLI_ID 
      --INNER JOIN USER_SPA ON USER_SPA.USR_ID = AGENDA_SPA.USR_ID
         ORDER BY AGE_DATE
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_agenda TO iSpa_user;
-- ====================================================
-- Vue d'affichage des clients
-- ====================================================
CREATE OR REPLACE VIEW vw_client(xPrenom, xNom, xDob, xEmail, xAdresse) AS
       SELECT CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE
       FROM CLIENT_SPA 
         ORDER BY CLI_PRENOM
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_client TO iSpa_user;
-- ====================================================
-- Vue d'affichage des factures
-- ====================================================
CREATE OR REPLACE VIEW vw_facture( xDate, xHeure, xNomClient, xTypeSeance, xPrix, xPaye) AS
       SELECT FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE
       FROM FACTURE_SPA 
       INNER JOIN AGENDA_SPA ON FACTURE_SPA.AGE_ID = AGENDA_SPA.AGE_ID 
         ORDER BY FACT_DATE
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_facture TO iSpa_user;
-- ====================================================
-- Vue d'affichage des users
-- ====================================================
CREATE OR REPLACE VIEW vw_vendue_par(xQuantite, xPrixUnitaire) AS
      SELECT FACT_PROD_QTY, FACT_PROD_PRIX_UNIT
      FROM A_ETE_VENDUE_PAR 
      INNER JOIN PRODUCT_SPA ON PRODUCT_SPA.PROD_ID = A_ETE_VENDUE_PAR.PROD_ID 
      INNER JOIN FACTURE_SPA ON FACTURE_SPA.FACT_ID = A_ETE_VENDUE_PAR.FACT_ID
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_vendue_par TO iSpa_user;



-- SELECT * FROM vw_ami;
-- SELECT * FROM vw_ingredient;
-- SELECT * FROM vw_recette;
-- SELECT * FROM vw_achat;
  
