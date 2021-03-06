-- ====================================================================
-- Script : 04_insertions_iSpa.sql
-- Objet  : Insertions de données sur les tables iSpa 
-- ====================================================================
-- ====================================================
-- Insertion Table : PRODUCT_SPA NUMBER(4),CHAR(32),CHAR(32)CHAR(32),NUMBER(10,2)
-- ====================================================
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (2, 'Acetaminophen', 'Synovectomy-site NEC', 'Oozz', 3.33);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (3, 'hydrocodone bitartrate', 'Pacemaker volt threshold', 'Thoughtblab', 6.60);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (1, 'Solidago Borax', 'Penile biopsy', 'Realbuzz', 0.10);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (4, 'Megestrol Acetate', 'Rep cornea postop dehisc', 'Fadeo', 7.00);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (5, 'ARANEUS', 'Micro exam-ent/laryn NEC', 'Thoughtworks', 5.40);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (6, 'Diphenhydramine HCl', 'NOS', 'Innojam', 5.90);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (7, 'PIPERACILLIN SODIUM', 'Clos bx saliv gland/duct', 'Browseblab', 2.50);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (8, 'Passiflora incarnata', 'Dacryocystorhinostomy', 'Vipe', 6.95);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (9, 'OCTINOXATE', 'wound', 'Oodoo', 7.55);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (10, 'Levonorgestrel', 'Shoulder arthroscopy', 'Edgeclub',7.80);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (11, 'aztreonam', 'Other diaphragm repair', 'Geba', 7.30);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (12, 'BENZALKONIUM CHLORIDE', 'Oth remove ovaries/tubes', 'Shufflester', 9.30);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (13, 'magnesium sulfate', 'Aspirat curet-post deliv', 'Skyvu', 6.50);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (14, 'Pramipexole Dihydrochloride', 'Cardioplegia', 'Reallinks', 9.20);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (15, 'Mesquite', 'Transureth prostatectomy', 'Eazzy', 8.10);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (16, 'voriconazole', 'Ot cerv fusion post/post', 'Aivee', 6.30);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (17, 'Sertraline Hydrochloride', 'Pancreatic homotransplan', 'Dazzlesphere', 1.80);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (18, 'OCTINOXATE, TITANIUM DIOXIDE', 'Symbleph rep w free grft', 'Kwideo', 3.10);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (19, 'Zinc Oxide 7%', 'Ext audit canal reconstr', 'Centidel', 8.90);
insert into PRODUCT_SPA (PROD_ID, PROD_NOM, PROD_DESC, PROD_FOURNISSEUR, PROD_PRIX) values (20, 'Alcohol', 'Thymus transplantation', 'Skippad', 6.50);

COMMIT;
-- ====================================================
-- Insertion Table : USER_SPA  NUMBER(4),CHAR(32),CHAR(32),CHAR(32),NUMBER(1)
-- ====================================================
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (1, 'admin', 'admin', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (2, 'mrevans1', 'NWl2sAeRQ66', 'user', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (3, 'hsandells2', '2Qb9qae', 'user', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (4, 'lgammack3', '6fsrI9Gh', 'user', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (5, 'crenault4', 'K34yx25Du61u', 'user', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (6, 'ningliby5', 'aDz2k0z', 'admin', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (7, 'pwingfield6', 'wXGLrbXX0', 'admin', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (8, 'staffs7', 'oNlliY3g', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (9, 'yglanert8', 'Ngk1cz4uT', 'user', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (10, 'scoatsworth9', 'wwLnVpjFJh', 'admin', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (11, 'tstrettlea', '4aSfF4OCk', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (12, 'ahallgoughb', 'IIF9qO1', 'user', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (13, 'rbiasionic', 'fXo1czvjam', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (14, 'jbruntond', 'Ri42Rlk1po', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (15, 'cbrandoe', 'Pia1I4', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (16, 'bkalff', 'a2mZiOM', 'admin', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (17, 'htippingsg', 'tt2guN', 'admin', 0);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (18, 'oskirvingh', 'eKzchoUlJ', 'user', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (19, 'sschwaigeri', 'PxYs79TlzoFI', 'admin', 1);
insert into USER_SPA (USR_ID, USR_NOM, USR_PWD, USR_TYPE, USR_ACTIF) values (20, 'wleyrroydj', 's4frA0639DrW', 'user', 0);

COMMIT;

-- ====================================================
-- Insertion Table : CLIENT_SPA NUMBER(4),CHAR(32),CHAR(32),DATE,CHAR(32),CHAR(32)
-- ====================================================
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (1, 'Zoé', 'Richten', TO_DATE('22.12.2001','dd.mm.yyyy'), 'grichten0@foxnews.com', '2674 Lake View Street');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (2, 'Lauréna', 'Grinnov', TO_DATE('21.08.1987','dd.mm.yyyy'), 'fgrinnov1@businessinsider.com', '2509 5th Park');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (3, 'Marie-françoise', 'Tommaseo', TO_DATE('25.01.1993','dd.mm.yyyy'), 'htommaseo2@opera.com', '026 Moland Park');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (4, 'Daphnée', 'Dragon', TO_DATE('19.04.2006','dd.mm.yyyy'), 'fdragon3@dyndns.org', '39 Marcy Lane');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (5, 'Amélie', 'Pollastrino', TO_DATE('23.12.1989','dd.mm.yyyy'), 'fpollastrino4@google.it', '9 Truax Court');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (6, 'Zoé', 'Hacquard', TO_DATE('25.02.1986','dd.mm.yyyy'), 'zhacquard5@163.com', '973 Graceland Place');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (7, 'Léonore', 'Edmonstone', TO_DATE('26.08.2001','dd.mm.yyyy'), 'aedmonstone6@rakuten.co.jp', '49302 Carey Junction');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (8, 'Rébecca', 'Eakle', TO_DATE('20.01.1980','dd.mm.yyyy'), 'teakle7@eventbrite.com', '76135 Harbort Center');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (9, 'Danièle', 'Vedmore', TO_DATE('27.07.1986','dd.mm.yyyy'), 'bvedmore8@apache.org', '61870 Monterey Circle');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (10, 'Maïwenn', 'Billings', TO_DATE('19.07.1982','dd.mm.yyyy'), 'dbillings9@netvibes.com', '74364 Morningstar Plaza');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (11, 'Maïwenn', 'Rosenfeld', TO_DATE('17.09.1999','dd.mm.yyyy'), 'drosenfelda@senate.gov', '503 Donald Center');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (12, 'Réjane', 'Annice', TO_DATE('11.07.1986','dd.mm.yyyy'), 'sanniceb@odnoklassniki.ru', '0283 Buhler Junction');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (13, 'Réjane', 'Tythacott', TO_DATE('12.11.1988','dd.mm.yyyy'), 'ctythacottc@webeden.co.uk', '4 Parkside Junction');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (14, 'Géraldine', 'Slixby', TO_DATE('20.02.1982','dd.mm.yyyy'), 'aslixbyd@reuters.com', '740 Northfield Road');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (15, 'Léandre', 'Arnell', TO_DATE('07.03.1990','dd.mm.yyyy'), 'warnelle@nps.gov', '8890 Thackeray Hill');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (16, 'Cinéma', 'Aland', TO_DATE('03.03.1999','dd.mm.yyyy'), 'ealandf@yellowpages.com', '49 Golf Street');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (17, 'Publicité', 'Farrey', TO_DATE('11.10.1992','dd.mm.yyyy'), 'vfarreyg@eventbrite.com', '12460 Packers Alley');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (18, 'Anaïs', 'Kett', TO_DATE('08.03.1992','dd.mm.yyyy'), 'aketth@japanpost.jp', '3 Arrowood Avenue');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (19, 'Françoise', 'Aers', TO_DATE('27.08.2004','dd.mm.yyyy'), 'aaersi@cmu.edu', '9 Coolidge Drive');
insert into CLIENT_SPA (CLI_ID, CLI_PRENOM, CLI_NOM, CLI_DOB, CLI_EMAIL, CLI_ADRESSE) values (20, 'Irène', 'Malcolm', TO_DATE('08.03.1987','dd.mm.yyyy'), 'gmalcolmj@utexas.edu', '6034 Walton Park');

COMMIT;

-- ====================================================
-- Insertion Table : AGENDA_SPA  AGE_ID NUMBER(4),NUMBER(4),NUMBER(4),DATE,DATE,CHAR(32),CHAR(32)
-- ====================================================
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (1, 1, 1, TO_DATE('27.11.2018','dd.mm.yyyy'), TO_DATE('19:00','hh24:mi'), 'Glenna Cuppleditch', 'Sport');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (2, 2, 2, TO_DATE('11.07.2019','dd.mm.yyyy'), TO_DATE('16:19','hh24:mi'), 'Ida Smartman', 'Massage');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (3, 3, 3, TO_DATE('17.02.2019','dd.mm.yyyy'), TO_DATE('16:16','hh24:mi'), 'Dukie Turone', 'Massage');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (4, 4, 4, TO_DATE('03.04.2019','dd.mm.yyyy'), TO_DATE('8:23','hh24:mi'), 'Lanae McLanaghan', 'Reiki');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (5, 5, 5, TO_DATE('18.02.2019','dd.mm.yyyy'), TO_DATE('17:06','hh24:mi'), 'Gran Alelsandrovich', 'Acupuncture');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (6, 6, 6, TO_DATE('14.08.2019','dd.mm.yyyy'), TO_DATE('8:15','hh24:mi'), 'Adda Dowty', 'Sport');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (7, 7, 7, TO_DATE('05.07.2019','dd.mm.yyyy'), TO_DATE('15:02','hh24:mi'), 'Cody Littell', 'Sport');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (8, 8, 8, TO_DATE('13.08.2019','dd.mm.yyyy'), TO_DATE('12:12','hh24:mi'), 'Mauricio Treneer', 'Sport');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (9, 9, 9, TO_DATE('01.07.2019','dd.mm.yyyy'), TO_DATE('11:32','hh24:mi'), 'Shell Seine', 'Sauna');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (10, 10, 10, TO_DATE('23.12.2018','dd.mm.yyyy'), TO_DATE('11:27','hh24:mi'), 'Kelcey Magor', 'Sport');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (11, 11, 11, TO_DATE('23.07.2019','dd.mm.yyyy'), TO_DATE('9:48','hh24:mi'), 'Aloysia Cesaric', 'Reiki');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (12, 12, 12, TO_DATE('05.01.2019','dd.mm.yyyy'), TO_DATE('19:15','hh24:mi'), 'Christan Eastabrook', 'Acupuncture');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (13, 13, 13, TO_DATE('16.09.2019','dd.mm.yyyy'), TO_DATE('17:14','hh24:mi'), 'Diahann Snead', 'Massage');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (14, 14, 14, TO_DATE('02.11.2019','dd.mm.yyyy'), TO_DATE('19:16','hh24:mi'), 'Samantha Insko', 'Sauna');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (15, 15, 15, TO_DATE('01.01.2019','dd.mm.yyyy'), TO_DATE('15:07','hh24:mi'), 'Ileana Lorkings', 'Sauna');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (16, 16, 16, TO_DATE('06.02.2019','dd.mm.yyyy'), TO_DATE('15:21','hh24:mi'), 'Giusto McFadin', 'Reiki');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (17, 17, 17, TO_DATE('04.07.2019','dd.mm.yyyy'), TO_DATE('13:05','hh24:mi'), 'Feliks Moresby', 'Acupuncture');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (18, 18, 18, TO_DATE('03.05.2019','dd.mm.yyyy'), TO_DATE('16:27','hh24:mi'), 'Viviana Prate', 'Reiki');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (19, 19, 19, TO_DATE('10.06.2019','dd.mm.yyyy'), TO_DATE('11:15','hh24:mi'), 'Micky Cleiment', 'Acupuncture');
insert into AGENDA_SPA (AGE_ID, CLI_ID, USR_ID, AGE_DATE, AGE_HEURE, AGE_NOMCLIENT, AGE_TYPE) values (20, 20, 20, TO_DATE('23.01.2019','dd.mm.yyyy'), TO_DATE('11:27','hh24:mi'), 'Benedict Rosson', 'Massage');

COMMIT;

-- ====================================================
-- Insertion Table : FACTURE_SPA  CHAR(32),NUMBER(4),CHAR(32),CHAR(32),CHAR(32),CHAR(32),CHAR(32),CHAR(32)

-- ====================================================
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (1, 1, TO_DATE('19.01.1998', 'dd.mm.yyyy'), TO_DATE('15:46','hh24:mi'), 'Vin Tumasian', 'Reiki', 123.10, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (2, 2, TO_DATE('30.06.1980', 'dd.mm.yyyy'), TO_DATE('17:25','hh24:mi'), 'Gae Scamerdine', 'Acupuncture', 141.90, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (3, 3, TO_DATE('14.09.1990', 'dd.mm.yyyy'), TO_DATE('19:47','hh24:mi'), 'Michaeline McIleen', 'Reiki', 83.60, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (4, 4, TO_DATE('12.08.1999', 'dd.mm.yyyy'), TO_DATE('13:41','hh24:mi'), 'Borg Schroeder', 'Reiki', 132.20, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (5, 5, TO_DATE('19.06.1981', 'dd.mm.yyyy'), TO_DATE('13:18','hh24:mi'), 'Kara Kaliszewski', 'Sauna', 166.40, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (6, 6, TO_DATE('05.10.1983', 'dd.mm.yyyy'), TO_DATE('11:02','hh24:mi'), 'Riane Llewellin', 'Reiki', 141.60, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (7, 7, TO_DATE('17.07.1980', 'dd.mm.yyyy'), TO_DATE('19:58','hh24:mi'), 'Alphard Labbett', 'Sauna', 161.40, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (8, 8, TO_DATE('01.02.1996', 'dd.mm.yyyy'), TO_DATE('14:51','hh24:mi'), 'Babs Stubs', 'Sport', 117.10, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (9, 9, TO_DATE('11.11.1986', 'dd.mm.yyyy'), TO_DATE('12:29','hh24:mi'), 'Delano Ambroisin', 'Reiki', 58.70, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (10, 10, TO_DATE('15.02.1981', 'dd.mm.yyyy'), TO_DATE('15:23','hh24:mi'), 'Margaux Hayward', 'Massage', 145.00, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (11, 11, TO_DATE('24.12.1995', 'dd.mm.yyyy'), TO_DATE('12:16','hh24:mi'), 'Johna Muscott', 'Sport', 96.00, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (12, 12, TO_DATE('07.11.1981', 'dd.mm.yyyy'), TO_DATE('14:35','hh24:mi'), 'Michale Walaron', 'Massage', 79.25, 0);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (13, 13, TO_DATE('27.04.1989', 'dd.mm.yyyy'), TO_DATE('16:31','hh24:mi'), 'Valerie Bottjer', 'Sauna', 154.30, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (14, 14, TO_DATE('17.11.1990', 'dd.mm.yyyy'), TO_DATE('10:16','hh24:mi'), 'Shanan Sevior', 'Massage', 109.60, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (15, 15, TO_DATE('06.07.1987', 'dd.mm.yyyy'), TO_DATE('14:26','hh24:mi'), 'Park Hatchard', 'Sauna', 59.80, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (16, 16, TO_DATE('15.10.1990', 'dd.mm.yyyy'), TO_DATE('11:17','hh24:mi'), 'Erika Kidgell', 'Sauna', 112.00, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (17, 17, TO_DATE('09.08.1992', 'dd.mm.yyyy'), TO_DATE('10:58','hh24:mi'), 'Christiane Rideout', 'Reiki', 108.60, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (18, 18, TO_DATE('12.07.1984', 'dd.mm.yyyy'), TO_DATE('17:47','hh24:mi'), 'Dore Lait', 'Reiki', 63.55, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (19, 19, TO_DATE('03.01.1992', 'dd.mm.yyyy'), TO_DATE('18:21','hh24:mi'), 'Xerxes Von Salzberg', 'Reiki', 139.50, 1);
insert into FACTURE_SPA (FACT_ID, AGE_ID, FACT_DATE, FACT_HEURE, FACT_NOMCLIENT, FACT_TYPESEANCE, FACT_PRIX, FACT_PAYE) values (20, 20, TO_DATE('24.08.2006', 'dd.mm.yyyy'), TO_DATE('10:05','hh24:mi'), 'Talia Haill', 'Sauna', 30.85, 1);

COMMIT;
-- ====================================================
-- Insertion Table : A_ETE_VENDUE_PAR PROD_ID NUMBER(4),CHAR(32),NUMBER(2),NUMBER(10,2)  

-- ====================================================

insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (1, 1, 78, 9.35);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (2, 2, 7, 2.75);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (3, 3, 96, 7.70);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (4, 4, 19, 7.35);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (5, 5, 41, 4.00);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (6, 6, 34, 5.45);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (7, 7, 19, 8.75);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (8, 8, 30, 8.90);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (9, 9, 99, 1.45);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (10, 10, 17, 9.80);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (11, 11, 2, 5.10);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (12, 12, 15, 0.60);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (13, 13, 99, 5.75);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (14, 14, 35, 9.65);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (15, 15, 95, 4.85);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (16, 16, 75, 4.95);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (17, 17, 50, 8.75);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (18, 18, 6, 2.45);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (19, 19, 68, 7.65);
insert into A_ETE_VENDUE_PAR (PROD_ID, FACT_ID, FACT_PROD_QTY, FACT_PROD_PRIX_UNIT) values (20, 20, 27, 8.30);

COMMIT;

-- SELECT * FROM A_ETE_VENDUE_PAR;
-- SELECT * FROM FACTURE_SPA;
-- SELECT * FROM CLIENT_SPA;
-- SELECT * FROM AGENDA_SPA;
-- SELECT * FROM USER_SPA ;
-- SELECT * FROM PRODUCT_SPA;
