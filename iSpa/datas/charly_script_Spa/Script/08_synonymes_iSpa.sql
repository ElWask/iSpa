-- ======================================================================
--  Script: 07_synonymes_iSpa.sql 
--  Objet : Création des synonymes de la base iSpa 
-- ======================================================================

CREATE OR REPLACE SYNONYM iSpa_user.vw_produit FOR iSpa_data.vw_produit;
CREATE OR REPLACE SYNONYM iSpa_user.vw_user FOR iSpa_data.vw_user;
CREATE OR REPLACE SYNONYM iSpa_user.vw_agenda FOR iSpa_data.vw_agenda;
CREATE OR REPLACE SYNONYM iSpa_user.vw_client FOR iSpa_data.vw_client;
CREATE OR REPLACE SYNONYM iSpa_user.vw_facture FOR iSpa_data.vw_facture;
CREATE OR REPLACE SYNONYM iSpa_user.vw_vendue_par FOR iSpa_data.vw_vendue_par;


CREATE OR REPLACE SYNONYM iSpa_user.pkg_insert_Blob FOR iSpa_data.pkg_insertBlob;

CREATE OR REPLACE SYNONYM iSpa_user.sq_product FOR iSpa_data.sq_product;
CREATE OR REPLACE SYNONYM iSpa_user.sq_user FOR iSpa_data.sq_user;
CREATE OR REPLACE SYNONYM iSpa_user.sq_agenda FOR iSpa_data.sq_agenda;
CREATE OR REPLACE SYNONYM iSpa_user.sq_client FOR iSpa_data.sq_client;
CREATE OR REPLACE SYNONYM iSpa_user.sq_facture FOR iSpa_data.sq_facture;