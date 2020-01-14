create or replace package pkg_insertProduct
AS
       FUNCTION ProductInsert(xName IN VARCHAR, xDesc IN VARCHAR, xFournisseur IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER;
       FUNCTION ProductGet(xName IN VARCHAR)RETURN NUMBER;    
       FUNCTION ProductSetData(xName IN VARCHAR, xDesc IN VARCHAR, xFournisseur IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER;
END pkg_insertProduct;
/
create or replace package body pkg_insertProduct
AS

FUNCTION ProductInsert(xName IN VARCHAR, xDesc IN VARCHAR, xFournisseur IN VARCHAR, xPrix IN VARCHAR )RETURN NUMBER
AS
   v_insert_confirmed NUMBER;
   v_id NUMBER;
BEGIN
         SELECT PRODUCT_SPA.PROD_ID INTO v_id FROM PRODUCT_SPA WHERE PRODUCT_SPA.PROD_NOM = xName;
         IF v_id  is null THEN
            insert into PRODUCT_SPA  (PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX ) values  (xName, xDesc, xFournisseur, xPrix);
            v_insert_confirmed := 1;
         ELSE
            v_insert_confirmed := 0;
         END IF;
         RETURN v_insert_confirmed;
END ProductInsert;

FUNCTION ProductGet(xName IN VARCHAR)RETURN NUMBER
AS
         v_id NUMBER;
BEGIN
         SELECT PRODUCT_SPA.PROD_ID INTO v_id FROM PRODUCT_SPA WHERE PRODUCT_SPA.PROD_NOM = xName;
         RETURN v_id;
END ProductGet;

FUNCTION ProductSetData(xName IN VARCHAR, xDesc IN VARCHAR, xFournisseur IN VARCHAR, xPrix IN VARCHAR)RETURN NUMBER
AS
         v_edit_confirmed NUMBER;
         v_id NUMBER;
BEGIN
         SELECT PRODUCT_SPA.PROD_ID INTO v_id FROM PRODUCT_SPA WHERE PRODUCT_SPA.PROD_NOM = xName;
         IF v_id  is not null THEN
            UPDATE PRODUCT_SPA SET PROD_NOM = xName, PROD_DESC = xDesc, PROD_FOURNISSEUR = xFournisseur, PROD_PRIX = xPrix WHERE PRODUCT_SPA.PROD_ID = v_id;
            v_edit_confirmed := 1;
         ELSE
            v_edit_confirmed := 0;
         END IF;
         RETURN v_edit_confirmed;
END ProductSetData;
END pkg_insertProduct;
/
GRANT EXECUTE ON pkg_insertProduct TO role_iSpa_Data;

create or replace package pkg_insertUser
AS
       FUNCTION UserInsert(xUsername IN VARCHAR, xPassword IN VARCHAR, xType IN VARCHAR, xActif IN NUMBER)RETURN NUMBER;
       FUNCTION UserGet(xUsername IN VARCHAR)RETURN NUMBER;    
       FUNCTION UserSetData(xUsername IN VARCHAR, xPassword IN VARCHAR, xType IN VARCHAR, xActif IN NUMBER)RETURN NUMBER;       
END pkg_insertUser;
/
create or replace package body pkg_insertUser
AS

FUNCTION UserInsert(xUsername IN VARCHAR, xPassword IN VARCHAR, xType IN VARCHAR, xActif IN NUMBER)RETURN NUMBER
AS
   v_insert_confirmed NUMBER;
   v_id NUMBER;
BEGIN
         SELECT USER_SPA.USR_ID INTO v_id FROM USER_SPA WHERE USER_SPA.USR_NOM = xUsername;
         IF v_id  is null THEN
            insert into USER_SPA  (USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values  (xUsername, xPassword, xType, xActif);
            v_insert_confirmed := 1;
         ELSE
            v_insert_confirmed := 0;
         END IF;
         RETURN v_insert_confirmed;
END UserInsert;

FUNCTION UserGet(xUsername IN VARCHAR)RETURN NUMBER
AS
         v_id NUMBER;
BEGIN
         SELECT USR_ID INTO v_id FROM USER_SPA WHERE USR_NOM = xUsername;
         RETURN v_id;
END UserGet;

FUNCTION UserSetData(xUsername IN VARCHAR, xPassword IN VARCHAR, xType IN VARCHAR, xActif IN NUMBER)RETURN NUMBER
AS
         v_edit_confirmed NUMBER;
         v_id NUMBER;
BEGIN
         SELECT USER_SPA.USR_ID INTO v_id FROM USER_SPA WHERE USER_SPA.USR_NOM = xUsername;
         IF v_id  is not null THEN
            UPDATE USER_SPA SET USR_NOM = xUsername, USR_PWD = xPassword, USR_TYPE = xType, USR_ACTIF = xActif WHERE USER_SPA.USR_ID = v_id;
            v_edit_confirmed := 1;
         ELSE
            v_edit_confirmed := 0;
         END IF;
         RETURN v_edit_confirmed;
END UserSetData;
END pkg_insertUser;
/
GRANT EXECUTE ON pkg_insertUser TO role_iSpa_Data;

create or replace package pkg_insertAgenda
AS
       FUNCTION AgendaInsert(xIdClient IN VARCHAR, xIdUser IN VARCHAR, xDate IN VARCHAR, xHeure IN VARCHAR, xNomClient IN VARCHAR, xType IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER;
       FUNCTION AgendaSetData(xIdClient IN VARCHAR, xIdUser IN VARCHAR, xDate IN VARCHAR, xHeure IN VARCHAR, xNomClient IN VARCHAR, xType IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER;       
END pkg_insertAgenda;
/
create or replace package body pkg_insertAgenda
AS

FUNCTION AgendaInsert(xIdClient IN VARCHAR, xIdUser IN VARCHAR, xDate IN VARCHAR, xHeure IN VARCHAR, xNomClient IN VARCHAR, xType IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER
AS
   v_insert_confirmed NUMBER;
   v_id NUMBER;
BEGIN
         SELECT AGENDA_SPA.AGE_ID INTO v_id FROM AGENDA_SPA WHERE AGENDA_SPA.AGE_DATE = xDate AND AGENDA_SPA.AGE_HEURE = xHeure AND AGENDA_SPA.AGE_NOMCLIENT = xNomClient AND AGENDA_SPA.AGE_TYPE = xType;
         IF v_id  is null THEN
            insert into AGENDA_SPA  (CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (xIdClient, xIdUser, xDate, xHeure, xType, xNomClient);
            v_insert_confirmed := 1;
         ELSE
            v_insert_confirmed := 0;
         END IF;
         RETURN v_insert_confirmed;
END AgendaInsert;

FUNCTION AgendaSetData( xIdClient IN VARCHAR, xIdUser IN VARCHAR, xDate IN VARCHAR, xHeure IN VARCHAR, xNomClient IN VARCHAR, xType IN VARCHAR, xPrix IN NUMBER)RETURN NUMBER
AS
         v_edit_confirmed NUMBER;
         v_id NUMBER;
BEGIN
         SELECT AGENDA_SPA.AGE_ID INTO v_id FROM AGENDA_SPA WHERE AGENDA_SPA.AGE_DATE = xDate AND AGENDA_SPA.AGE_HEURE = xHeure AND AGENDA_SPA.AGE_NOMCLIENT = xNomClient AND AGENDA_SPA.AGE_TYPE = xType;
         IF v_id  is not null THEN
            UPDATE AGENDA_SPA SET CLI_ID = xIdClient, USR_ID = xIdUser, AGE_DATE = xDate, AGE_HEURE = xHeure, AGE_NOMCLIENT = xNomClient WHERE USR_ID = v_id;
            v_edit_confirmed := 1;
         ELSE
            v_edit_confirmed := 0;
         END IF;
         RETURN v_edit_confirmed;
END AgendaSetData;
END pkg_insertAgenda;
/
sho err
/
GRANT EXECUTE ON pkg_insertAgenda TO role_iSpa_Data;


create or replace package pkg_insertClient
AS
       FUNCTION ClientInsert(xName IN VARCHAR, xLastName IN VARCHAR, xDob IN DATE, xEmail IN VARCHAR, xAdresse IN VARCHAR)RETURN NUMBER;
       FUNCTION ClientGet(xName IN VARCHAR, xLastName IN VARCHAR)RETURN NUMBER;    
       FUNCTION ClientSetData(xName IN VARCHAR, xLastName IN VARCHAR, xDob IN DATE, xEmail IN VARCHAR, xAdresse IN VARCHAR)RETURN NUMBER;       
END pkg_insertClient;
/
create or replace package body pkg_insertClient
AS

FUNCTION ClientInsert(xName IN VARCHAR, xLastName IN VARCHAR, xDob IN DATE, xEmail IN VARCHAR, xAdresse IN VARCHAR)RETURN NUMBER
AS
   v_insert_confirmed NUMBER;
   v_id NUMBER;
BEGIN
         SELECT CLIENT_SPA.CLI_ID INTO v_id FROM CLIENT_SPA WHERE CLIENT_SPA.CLI_PRENOM = xName AND CLIENT_SPA.CLI_NOM = xLastName AND CLIENT_SPA.CLI_DOB = xDob ;
         IF v_id  is null THEN
            insert into CLIENT_SPA  (CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values  (xName, xLastName, xDob, xEmail, xAdresse);
            v_insert_confirmed := 1;
         ELSE
            v_insert_confirmed := 0;
         END IF;
         RETURN v_insert_confirmed;
END ClientInsert;

FUNCTION ClientGet(xName IN VARCHAR, xLastName IN VARCHAR)RETURN NUMBER
AS
         v_id NUMBER;
BEGIN
         SELECT CLIENT_SPA.CLI_ID INTO v_id FROM CLIENT_SPA WHERE CLIENT_SPA.CLI_PRENOM = xName AND CLIENT_SPA.CLI_NOM = xLastName;
         RETURN v_id;
END ClientGet;

FUNCTION ClientSetData(xName IN VARCHAR, xLastName IN VARCHAR, xDob IN DATE, xEmail IN VARCHAR, xAdresse IN VARCHAR)RETURN NUMBER
AS
         v_edit_confirmed NUMBER;
         v_id NUMBER;
BEGIN
         SELECT CLIENT_SPA.CLI_ID INTO v_id FROM CLIENT_SPA WHERE CLIENT_SPA.CLI_NOM = xName;
         IF v_id  is not null THEN
            UPDATE CLIENT_SPA SET CLI_NOM = xLastName, CLI_PRENOM = xName, CLI_DOB = xDob WHERE CLI_ID = v_id;
            v_edit_confirmed := 1;
         ELSE
            v_edit_confirmed := 0;
         END IF;
         RETURN v_edit_confirmed;
END ClientSetData;
END pkg_insertClient;
/
sho err
/
GRANT EXECUTE ON pkg_insertClient TO role_iSpa_Data;

create or replace package pkg_insertFacture
AS
       FUNCTION FactureInsert(xAgeId IN NUMBER, xDate in DATE, xHeure in DATE, xNomClient IN VARCHAR, xTypeSeance IN VARCHAR, xPrix IN NUMBER, xPaye IN NUMBER)RETURN NUMBER;
       FUNCTION FactureGet(xDate in DATE, xHeure in DATE, xNomClient IN VARCHAR)RETURN NUMBER;    
       FUNCTION FactureSetData(xAgeId IN NUMBER, xDate in DATE, xHeure in DATE, xNomClient IN VARCHAR, xTypeSeance IN VARCHAR, xPrix IN NUMBER, xPaye IN NUMBER)RETURN NUMBER;       
END pkg_insertFacture;
/
create or replace package body pkg_insertFacture
AS

FUNCTION FactureInsert(xAgeId IN NUMBER, xDate in DATE, xHeure in DATE, xNomClient IN VARCHAR, xTypeSeance IN VARCHAR, xPrix IN NUMBER, xPaye IN NUMBER)RETURN NUMBER
AS
   v_insert_confirmed NUMBER;
   v_id NUMBER;
BEGIN
         SELECT FACT_ID INTO v_id FROM FACTURE_SPA WHERE FACT_DATE = xDate AND FACT_HEURE = xHeure AND FACT_NOMCLIENT = xNomClient ;
         IF v_id  is null THEN
            insert into FACTURE_SPA  (AGE_ID,FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX,FACT_PAYE) values  (xAgeId, xDate, xHeure, xNomClient, xTypeSeance, xPrix, xPaye);
            v_insert_confirmed := 1;
         ELSE
            v_insert_confirmed := 0;
         END IF;
         RETURN v_insert_confirmed;
END FactureInsert;

FUNCTION FactureGet( xDate in DATE, xHeure in DATE,xNomClient IN VARCHAR)RETURN NUMBER
AS
         v_id NUMBER;
BEGIN
         SELECT FACT_ID INTO v_id FROM FACTURE_SPA WHERE FACT_DATE = xDate AND FACT_HEURE = xHeure AND FACT_NOMCLIENT = xNomClient;
         RETURN v_id;
END FactureGet;

FUNCTION FactureSetData(xAgeId IN NUMBER, xDate in DATE, xHeure in DATE, xNomClient IN VARCHAR, xTypeSeance IN VARCHAR, xPrix IN NUMBER, xPaye IN NUMBER)RETURN NUMBER
AS
         v_edit_confirmed NUMBER;
         v_id NUMBER;
BEGIN
         SELECT FACT_ID INTO v_id FROM FACTURE_SPA WHERE FACT_DATE = xDate AND FACT_HEURE = xHeure AND FACT_NOMCLIENT = xNomClient;
         IF v_id  is not null THEN
            UPDATE FACTURE_SPA SET AGE_ID = xAgeId, FACT_DATE = xDate, FACT_HEURE = xHeure, FACT_NOMCLIENT = xNomClient, FACT_TYPESEANCE = xTypeSeance, FACT_PRIX = xPrix, FACT_PAYE = xPaye  WHERE FACT_ID = v_id;
            v_edit_confirmed := 1;
         ELSE
            v_edit_confirmed := 0;
         END IF;
         RETURN v_edit_confirmed;
END FactureSetData;
END pkg_insertFacture;
/
sho err
/
GRANT EXECUTE ON pkg_insertFacture TO role_iSpa_Data;
