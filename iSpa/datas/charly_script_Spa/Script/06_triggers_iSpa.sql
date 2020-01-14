-- ====================================================================
-- Script : 06_triggers_iSpa.sql
-- Objet  : Création des triggers iSpa sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     CS   19.11.2019    Création trigers
-- ====================================================================

-- ====================================================
-- Trigger product
-- ====================================================

 CREATE SEQUENCE   sq_product  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 21 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_product 
  before insert on PRODUCT_SPA               
  for each row  
begin   
    select sq_product.nextval into :NEW.PROD_ID from dual; 
end; 

/
ALTER TRIGGER  tr_product ENABLE
/

-- ====================================================
-- Trigger user
-- ====================================================

 CREATE SEQUENCE   sq_user MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 21 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_user
  before insert on USER_SPA              
  for each row  
begin   
    select sq_user.nextval into :NEW.USR_ID from dual; 
end; 

/
ALTER TRIGGER  tr_user ENABLE
/
-- ====================================================
-- Trigger agenda
-- ====================================================

 CREATE SEQUENCE   sq_agenda  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 21 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_agenda 
  before insert on AGENDA_SPA              
  for each row  
begin   
    select sq_agenda.nextval into :NEW.AGE_ID from dual; 
end; 

/
ALTER TRIGGER  tr_agenda ENABLE
/

-- ====================================================
-- Trigger client
-- ====================================================

 CREATE SEQUENCE   sq_client  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 21 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_client 
  before insert on CLIENT_SPA              
  for each row  
begin   
    select sq_client.nextval into :NEW.CLI_ID from dual; 
end; 

/
ALTER TRIGGER  tr_client ENABLE
/

-- ====================================================
-- Trigger facture
-- ====================================================

 CREATE SEQUENCE   sq_facture  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 21 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_facture 
  before insert on FACTURE_SPA              
  for each row  
begin   
    select sq_facture.nextval into :NEW.FACT_ID from dual; 
end; 

/
ALTER TRIGGER  tr_facture ENABLE
/













