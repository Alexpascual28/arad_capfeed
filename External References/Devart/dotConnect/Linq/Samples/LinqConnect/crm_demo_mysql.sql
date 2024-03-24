-- ALTER TABLE `Company` DROP FOREIGN KEY Company_PrimaryContact;
-- DROP TABLE `Order Details` CASCADE;
-- DROP TABLE `Orders` CASCADE;
-- DROP TABLE `Products` CASCADE;
-- DROP TABLE `Product Categories` CASCADE;
-- DROP TABLE `Person Contact` CASCADE;
-- DROP TABLE `Company` CASCADE;


CREATE TABLE `Product Categories` (
  CategoryID INT NOT NULL,
  CategoryName VARCHAR(20) NOT NULL,  
  ParentCategory INT COMMENT 'A reference to the major category which includes this one',
  PRIMARY KEY (CategoryID),
  -- A self-reference (from a child category to the parent one)
  CONSTRAINT ProductCategories_Parent FOREIGN KEY (ParentCategory)
    REFERENCES `Product Categories` (CategoryID)
)
COMMENT 'The tree of product categories'
ENGINE = INNODB;

CREATE TABLE `Products` (
  ProductID INT NOT NULL,
  ProductName VARCHAR(50) NOT NULL,
  CategoryID INT COMMENT 'A category to which the product belongs',
  UnitName VARCHAR(20) COMMENT 'Specifies whether a single product unit consists of one (Unit) or several (Parcel) items',
  UnitScale SMALLINT COMMENT 'Specifies the number of items in a parcel',
  InStock INT COMMENT 'Product quantity available in the stock',
  Price DECIMAL(10, 2) COMMENT 'Regular price of the product',
  DiscontinuedPrice DECIMAL(10, 2) COMMENT 'Actual price of discontinued products',
  Discontinued BIT(1) DEFAULT 0 COMMENT 'Specifies whether the product is being sold off',
  PRIMARY KEY (ProductID),
  INDEX Product_Category USING BTREE (CategoryID),
  -- An association to the Product Categories (to the category to which the product belongs)
  CONSTRAINT Product_Category FOREIGN KEY (CategoryID)
    REFERENCES `Product Categories`(CategoryID)
)
COMMENT 'Table containing data about products'
ENGINE = INNODB;

CREATE TABLE `Company` (
  CompanyID INT NOT NULL,
  CompanyName VARCHAR(40) NOT NULL,
  PrimaryContact INT COMMENT 'A reference to the employee who is the preferable company contact',
  Web VARCHAR(100),
  Email VARCHAR(50),
  AddressTitle VARCHAR(120) COMMENT 'Specifies the address type, i.e., if it is legal, physical or other',
  Address VARCHAR(60),
  City VARCHAR(30),
  Region VARCHAR(20),
  PostalCode VARCHAR(15),
  Country VARCHAR(20),
  Phone VARCHAR(25),
  Fax VARCHAR(25),
  PRIMARY KEY (CompanyID)  
)
COMMENT 'The table of customer and shipping companies'
ENGINE = INNODB;

CREATE TABLE `Person Contact` (
  ContactID INT NOT NULL,
  Title VARCHAR(8),
  FirstName VARCHAR(50),
  MiddleName VARCHAR(50),
  LastName VARCHAR(50),
  CompanyID INT COMMENT 'Reference to the company where the person is employed',
  HomePhone VARCHAR(25),
  MobilePhone VARCHAR(25), 
  AddressTitle VARCHAR(120) COMMENT 'Specifies the address type which may be Home or Work',
  Address VARCHAR(60),
  City VARCHAR(30),
  Region VARCHAR(20),
  PostalCode VARCHAR(15),
  Country VARCHAR(20),
  Phone VARCHAR(25) COMMENT 'Working phone',
  Fax VARCHAR(25) COMMENT 'Working fax',
  PRIMARY KEY (ContactID),
  INDEX PersonContact_Company USING BTREE (CompanyID),
  -- An association to the company table (from employee to the employer company)
  CONSTRAINT PersonContact_Company FOREIGN KEY (CompanyID)
    REFERENCES `Company`(CompanyID)
)
COMMENT 'The table for information on persons related to the store activities'
ENGINE = INNODB;

CREATE TABLE `Orders` (
  OrderID INT NOT NULL,
  CompanyID INT COMMENT 'The customer company',
  ContactID INT COMMENT 'The person to contact regarding the order',
  OrderDate DATETIME COMMENT 'The date when the order was made',
  Freight DECIMAL(10, 2) COMMENT 'Freight cost of the order',
  ShipDate DATETIME COMMENT 'The date of order to be shipped',
  ShipCompanyID INT COMMENT 'The shipping contractor',
  Discount DECIMAL(10, 2) COMMENT 'Discount available for the order',
  PRIMARY KEY (OrderID),
  INDEX Orders_Company USING BTREE (CompanyID),
  INDEX Orders_Contact USING BTREE (ContactID),
  INDEX Orders_ShipCompany USING BTREE (ShipCompanyID),
  -- An association to the Company table (to the customer company)	
  CONSTRAINT Orders_Company FOREIGN KEY (CompanyID)
    REFERENCES `Company`(CompanyID),
  -- An association to the Person Contact table (to the person related to this order)
  CONSTRAINT Orders_Contact FOREIGN KEY (ContactID)
    REFERENCES `Person Contact`(ContactID),
  -- An association to the Company table (to the shipping company)
  CONSTRAINT Orders_ShipCompany FOREIGN KEY (ShipCompanyID)
    REFERENCES `Company`(CompanyID)
)
COMMENT 'Table storing the general data about orders'
ENGINE = INNODB;

CREATE TABLE `Order Details` (
  OrderID INT NOT NULL,
  ProductID INT COMMENT 'A product present in the order',
  Price DECIMAL(10, 2),
  Quantity DECIMAL(10, 4) COMMENT 'Quantity of the product specified',
  CONSTRAINT OrderDetails_Order_Product PRIMARY KEY (OrderID, productid),
  INDEX OrderDetails_Order USING BTREE (OrderID),
  INDEX OrderDetails_Product USING BTREE (ProductID),
  -- An association to the Orders table (to the described order)
  CONSTRAINT OrderDetails_Order FOREIGN KEY (OrderID)
    REFERENCES `Orders`(OrderID),
  -- An association to the Products table (to the product ordered)
  CONSTRAINT OrderDetails_Product FOREIGN KEY (ProductID)
    REFERENCES `Products`(ProductID)
)
COMMENT 'Table for the detailed information on what the order consists of'
ENGINE = INNODB;


INSERT INTO `Product Categories` VALUES (1, 'prose', NULL);
INSERT INTO `Product Categories` VALUES (2, 'novel', 1);
INSERT INTO `Product Categories` VALUES (3, 'detective story', 2);
INSERT INTO `Product Categories` VALUES (4, 'fiction', 2);
INSERT INTO `Product Categories` VALUES (5, 'short stories', 1);
INSERT INTO `Product Categories` VALUES (6, 'poem', NULL);
INSERT INTO `Product Categories` VALUES (7, 'lyrics', 6);
INSERT INTO `Product Categories` VALUES (8, 'drama', NULL);
INSERT INTO `Product Categories` VALUES (9, 'textbook', NULL);
INSERT INTO `Product Categories` VALUES (10, 'research book', 9);
INSERT INTO `Product Categories` VALUES (11, 'dictionary', 9);
INSERT INTO `Product Categories` VALUES (12, 'other', NULL);

INSERT INTO `Products` VALUES (7007, 'Shakespeare W. Shakespeare''s dramatische Werke', 8, 'parcel', 4, 67, 78, 78, 0);
INSERT INTO `Products` VALUES (7101, 'King Stephen. ''Salem''s Lot', 4, 'parcel', 10, 123, 67, 60, 1);
INSERT INTO `Products` VALUES (7202, 'Lightman Alan. Einstein''s dreams', 12, 'unit', 1, 12, 45, 41, 1);
INSERT INTO `Products` VALUES (7219, 'Swift Jonathan. Gulliver''s travels', 2, 'parcel', 4, 33, 65, 60, 0);
INSERT INTO `Products` VALUES (7303, 'May Charles E. Fiction''s many worlds', 3, 'parcel', 4, 56, 34, 29, 0);
INSERT INTO `Products` VALUES (7319, 'Turgenev Ivan. A sportsman''s notebook ', 1, 'parcel', 5, 2, 100, 90, 0);
INSERT INTO `Products` VALUES (7404, 'Petrarca Francesco. Petrarch''s lyric poems:', 7, 'parcel', 3, 78, 56, 47, 0);
INSERT INTO `Products` VALUES (7419, 'Twain Mark. Adventures of Huckleberry Finn ', 2, 'parcel', 2, 45, 34, 33, 0);
INSERT INTO `Products` VALUES (7505, 'Plutarchus. Plutarch''s moralia', 1, 'unit', 1, 123, 89, 80, 1);
INSERT INTO `Products` VALUES (7519, 'White Edmund. A boy''s own story', 4, 'parcel', 3, 67, 60, 56, 0);
INSERT INTO `Products` VALUES (7606, 'Read Janet. Blue mind''s flower', 7, 'unit', 1, 71, 290, 250, 0);
INSERT INTO `Products` VALUES (7619, 'Wright Eric. Moodie''s tale', 12, 'parcel', 8, 65, 56, 56, 0);
INSERT INTO `Products` VALUES (7707, 'Reader''s digest condensed books', 12, 'parcel', 4, 98, 56, 48, 1);
INSERT INTO `Products` VALUES (7719, 'Zonailo Carolyn. Nature''s grace', 5, 'parcel', 5, 1, 890, 890, 0);
INSERT INTO `Products` VALUES (7807, 'Rustaveli Shota. The knight in the panther''s skin ', 6, 'unit', 1, 90, 67, 61, 0);
INSERT INTO `Products` VALUES (7810, 'Zytokinexpression in T-Helferzellen', 10, 'unit', 1, 32, 36, 34, 1);
INSERT INTO `Products` VALUES (7811, 'Spotlight on Britain''s economy', 9, 'unit', 1, 58, 50, 50, 0);
INSERT INTO `Products` VALUES (7812, 'Andrew (Brother). God''s smuggler ', 2, 'unit', 1, 400, 25, 23, 0);
INSERT INTO `Products` VALUES (7890, 'Highsmith Patricia. The talented Mr. Ripley', 3, 'unit', 1, 750, 120, 115, 1);
INSERT INTO `Products` VALUES (7907, 'Scott Walter. The prose works', 2, 'parcel', 4, 4, 89, 78, 0);
INSERT INTO `Products` VALUES (8001, 'Harrison G. B. England in Shakespeare''s day', 9, 'unit', 1, 50, 540, 520, 0);
INSERT INTO `Products` VALUES (8101, 'Corkett Anne. The salamander''s laughter', 7, 'unit', 1, 1041, 5, 5, 0);
INSERT INTO `Products` VALUES (8102, 'Carroll Lewis. Alice''sventures in Wonderland ', 4, 'unit', 1, 210, 413, 400, 0);
INSERT INTO `Products` VALUES (8201, 'Charles Spenser Chaplin. Selected Stories', 5, 'unit', 1, 12, 43, 3, 1);
INSERT INTO `Products` VALUES (8329, 'Webster''s New World College Dictionary', 11, 'unit', 1, 25, 18, 25, 0);

INSERT INTO `Company` VALUES (1, 'Borland UK CodeGear Division', NULL, 'support.codegear.com/', 'uk.custserv@codegear.com', 'Legal', '8 Pavilions Ruscombe Business Park', 'Twyford', 'Berkshire', 'RG10 9NN', 'United Kingdom', '44(0)1189241400', '44(0)1189241401');
INSERT INTO `Company` VALUES (2, 'Protax Consulting Services', 5, 'www.protaxconsulting.com', 'protax@protaxconsulting.com', 'Physical', '450 Seventh Avenue, Suite 2102', 'New York', 'New York', '10123', 'USA', '(212) 714 - 9070', '(212) 714 - 6654');
INSERT INTO `Company` VALUES (3, 'Alfa-Bank', 3, 'www.alfabank.com', 'mail@alfabank.ru', 'Legal', '27 Kalanchevskaya Street', 'Moscow', 'Moscow', '107078', 'Russia', '+7 495 929-91-91', '+7 495 974-25-15');
INSERT INTO `Company` VALUES (4, 'Pioneer Pole Buildings, Inc.', 4, 'www.pioneerpolebuildings.com', 'rbirnesser@pioneerpolebuildings.com', 'Legal', 'Nezahualcoyotl 109 Piso 8', 'Mexico', '', '06082', 'Mexico', '(484) 400-0557', '(888)-448-2505 Ext 140');
INSERT INTO `Company` VALUES (5, 'Orion Telecoms (Pty) Ltd.', 1, 'www.oriontele.com', 'carlofx@oriontele.com', 'Legal', 'Casilla de Correo 432', 'Buenos Aires', '', 'C1000WAM', 'Argentina', '3455634562', '3455672345');
INSERT INTO `Company` VALUES (6, 'RGS-Consulting', 10, 'www.rgs-dv.com', 'info@rgs-dv.com', 'Legal', 'Warngauer Str.,15', 'Munich', 'Bavaria', '34533', 'Germany', '0049 (0)7444 916215', '0049 (0)7444 916213');
INSERT INTO `Company` VALUES (7, 'Intelli Soft', NULL, 'www.intelli-soft.at', 'h.bacik@intelli-soft.at', 'Legal', 'Hongchan road, 22', 'Antananarivo', NULL, '56767', 'Madagascar', '4567123123', '4567123576');
INSERT INTO `Company` VALUES (8, 'ViewSlip Software', 9, 'www.viewslip.com', 'eric@viewslip.com', 'Legal', 'Rm.2311 No.933 West Zhongshan Rd. Shanghai,China', 'Shanghai', NULL, '200051', 'China', '800 - 720 - 0107', '021 - 5150 4169');
INSERT INTO `Company` VALUES (9, 'Digi Forge', 2, 'www.digiforge.at', 'katrinj@digiforge.at', 'Legal', 'Borgartun 34', 'Reykjavik', NULL, '105', 'Iceland', '1287909456', '1287909457');
INSERT INTO `Company` VALUES (10, 'APRO Consulting Services B.V.', NULL, 'www.apro.nl', 'rvanmaaren@apro.nl', 'Physical', 'Kinkerstraat 5', 'Amsterdam', NULL, '34523', 'Netherlands', '+31 (0)33 2999990', '+31 (0)33 2999898');
INSERT INTO `Company` VALUES (11, 'Argo Computing Services PTY LTD', 11, 'www.argocomputing.com.au', 'home@argocomputing.com.au', 'Physical', 'Suite 32 5A Hartnett Close', 'Mulgrave ', 'Sydney', '12343', 'Australia', '+61 3 8562 2245', '+61 3 8888 5021');
INSERT INTO `Company` VALUES (12, 'Orderbase Consulting GmbH', 7, 'www.orderbase.de', 't.schlick@orderbase.de', 'Legal', 'Schulstrasse 4', 'Hamburg', NULL, '21149', 'Germany', '+49 251 20750-23', '+49 251 20750-28');

INSERT INTO `Person Contact` VALUES (1, 'Mr.', 'Carlo', 'Francis', 'Xavier', 5, '+54-1159839427', '0800-222-0540', 'Work', 'Escuela Rural 45', 'Buenos Aires', 'Buenos Aires', 'X5187XAB', 'Argentina', '+54-1166322065', NULL);
INSERT INTO `Person Contact` VALUES (2, 'Ms.', 'Katrin', 'Jonsdottir', '', 9, '800-9696', NULL, 'Home', 'Postholf 1034', 'Reykjavik', '', '121', 'Iceland', '800-9703', NULL);
INSERT INTO `Person Contact` VALUES (3, 'Mr.', 'Roman', 'Vladimirovich', 'Valesyuk', 3, '495-3189711', '018-3782910', 'Work', 'Ohotny Ryad av., 345b - 102', 'Moscow', 'Moscow', '23461', 'Russia', '495-4789009', '495-4789009');
INSERT INTO `Person Contact` VALUES (4, 'Dr.', 'Ryan', 'J.', 'Birnesser ', 4, '(888)-345-2905', '(484)-417-5957', 'Work', 'Urion 30', 'Mexico', NULL, '02860', 'Mexico', '+52-5511638987', '+52-5546240232');
INSERT INTO `Person Contact` VALUES (5, 'Mr.', 'John', 'Gordon', 'Menson', 2, '988-1355251', '089-5484190', 'Work', '49 Featherstone Street', 'London', '', 'EC1Y 8SY', 'UK', '085-1545122', '085-1545122');
INSERT INTO `Person Contact` VALUES (6, 'Mrs.', 'Mary', '', 'Semenova', 3, '3595112', '780774874', 'Work', 'Sadovaya street, 15', 'Moscow', 'Moscow', '95744', 'Russian Federation', '456-15-15', '456-15-15');
INSERT INTO `Person Contact` VALUES (7, 'Ms.', 'Eva', NULL, 'Schlick', 12, '+49 251 2075412', '+49 251 2071254', 'Work', 'Weier Strasse, 71', 'Leverkusen', 'NRW', '09806', 'Germany', '7894567', NULL);
INSERT INTO `Person Contact` VALUES (8, 'Mr.', 'Andi', 'Alan', 'Kusnadi', NULL, '566-3451239', '5437896512', 'Work', 'Hyrubia str., 11', 'Bangkok', NULL, '675454', 'Thailand', '1187654', NULL);
INSERT INTO `Person Contact` VALUES (9, 'Dr.', 'Eric', '', 'Xu', 8, '4001-204952', '4001-204959', 'Home', '36 BAOSHAN JIUCUN, BAOSHAN DISTRICT', 'Shanghai', '', '201900', 'China', '4001-204936', NULL);
INSERT INTO `Person Contact` VALUES (10, 'Sr.', 'Martin', NULL, 'Schaich', 6, '58 6779594', '61 4619034', 'Home', 'M+R Spedag Group AG Dom: Kriegackerstrasse 91/Muttenz', 'Basel', 'Basel-Stadt', '12432', 'Switzerland ', '7654339', NULL);
INSERT INTO `Person Contact` VALUES (11, 'Sr.', 'Stephen', 'Robert', 'Rudd', 11, '+61-280147951', '089-9048452', 'Work', '200 Broadway Av', 'Sydney', 'New South Wales', 'SA 5024', 'Australia ', '+61-280384651', '+61-280384652');
INSERT INTO `Person Contact` VALUES (12, 'Mrs.', 'Mary', NULL, 'Godwin', 1, '01403-222-0365', NULL, 'Home', '3 High Street', 'Horsham', 'West Sussex', 'RH12', 'United Kingdom', '44(0)1189241400', NULL);
INSERT INTO `Person Contact` VALUES (13, 'Mr.', 'Percy', 'Bysshe', 'Shelley', 1, '01403-222-0365', '(07781) 336-552 ', 'Work', '3 High Street', 'Horsham', 'West Sussex', 'RH12', 'United Kingdom', '44(0)1189241400', '44(0)1189241401');
INSERT INTO `Person Contact` VALUES (14, 'Sr.', 'Koobus', '', 'Venter', NULL, '+27-140-809', '+27-204-837', 'Work', '1234 Church Street', 'Johannesburg', 'Gauteng', '0083', 'South Africa', '+27-140-825', NULL);
INSERT INTO `Person Contact` VALUES (15, 'Pr.', 'Vittorino', NULL, 'Pata', 5, '(39024)792-10-32', '800-789-768', 'Home', 'Viale Europa, 22', 'Roma', NULL, '00144-ROMA', 'Italy ', '(39024)792-32-10', '(39024)792-32-12');

-- An association to the Person Contact table (from a company to its primary contact)
ALTER TABLE Company
  ADD CONSTRAINT Company_PrimaryContact FOREIGN KEY (PrimaryContact)
    REFERENCES `Person Contact` (ContactID);

INSERT INTO `Orders` VALUES (1, 3, 3, '2006-08-06 00:00:00', 29, '2007-07-26 17:06:42', 3, 2);
INSERT INTO `Orders` VALUES (2, 5, 15,'2005-08-06 00:00:00', 24, '2007-07-13 17:06:51', 2, 0);
INSERT INTO `Orders` VALUES (3, 3, 6, '2004-07-06 00:00:00', 56, '2005-08-17 00:00:00', 2, 5);
INSERT INTO `Orders` VALUES (4, 9, 2, '2005-08-06 00:00:00', 154, '2005-08-20 00:00:00', 2, 1);
INSERT INTO `Orders` VALUES (5, 8, 9, '2005-09-06 00:00:00', 214, '2006-08-14 00:00:00', 2, 6);
INSERT INTO `Orders` VALUES (6, 12, 7, '2007-02-06 00:00:00', 244, '2007-08-13 00:00:00', 2, 2);
INSERT INTO `Orders` VALUES (7, 2, 5, '2007-06-06 00:00:00', 4, '2007-08-26 00:00:00', 2, 2);
INSERT INTO `Orders` VALUES (8, 5, 1, '2006-08-01 00:00:00', 25, '2006-08-15 00:00:00', 2, 3);
INSERT INTO `Orders` VALUES (9, NULL, 8, '2006-08-04 00:00:00', 2, '2006-08-31 00:00:00', 1, 0);
INSERT INTO `Orders` VALUES (10, 10, NULL, '2007-03-03 00:00:00', 19, '2007-06-04 00:00:00', 1, 3);
INSERT INTO `Orders` VALUES (11, 1, 13, '2007-04-11 00:00:00', 24, '2007-05-21 00:00:00', 2, 5);
INSERT INTO `Orders` VALUES (12, 1, NULL, '2006-03-11 00:00:00', 18, '2006-08-08 00:00:00', 1, 0);
INSERT INTO `Orders` VALUES (14, 4, 4, '2003-03-01 00:00:00', 98, '2003-08-07 00:00:00', 1, 0);
INSERT INTO `Orders` VALUES (15, 5, 1, '2007-07-01 00:00:00', 198, '2007-08-01 00:00:00', 4, 23);
INSERT INTO `Orders` VALUES (16, 2, 5, '2007-07-06 00:00:00', 254, '2007-07-30 00:00:00', 2, 25);
INSERT INTO `Orders` VALUES (17, NULL, 8, '2007-08-08 16:37:44', 123, '2007-08-09 00:00:00', 4, 0);
INSERT INTO `Orders` VALUES (18, 3, 6, '2007-08-08 16:42:22', 23, '2007-08-08 00:00:00', 4, 0);
INSERT INTO `Orders` VALUES (19, 6, 10, '2007-07-03 00:00:00', 140, '2007-08-09 00:00:00', 1, 15);
INSERT INTO `Orders` VALUES (20, 12, 7, '2007-08-01 00:00:00', 219, '2007-09-02 00:00:00', 2, 13);

INSERT INTO `Order Details` VALUES (1, 7101, 67, 25);
INSERT INTO `Order Details` VALUES (1, 7404, 56, 22);
INSERT INTO `Order Details` VALUES (1, 7505, 90, 10);
INSERT INTO `Order Details` VALUES (2, 7707, 56, 15);
INSERT INTO `Order Details` VALUES (3, 7807, 70, 45);
INSERT INTO `Order Details` VALUES (4, 7619, 56, 10);
INSERT INTO `Order Details` VALUES (4, 7719, 890, 2);
INSERT INTO `Order Details` VALUES (4, 7907, 89, 8);
INSERT INTO `Order Details` VALUES (5, 7101, 67, 14);
INSERT INTO `Order Details` VALUES (5, 7303, 34, 14);
INSERT INTO `Order Details` VALUES (6, 7811, 50, 10);
INSERT INTO `Order Details` VALUES (6, 7907, 89, 24);
INSERT INTO `Order Details` VALUES (7, 7810, 36, 50);
INSERT INTO `Order Details` VALUES (8, 7505, 89, 80);
INSERT INTO `Order Details` VALUES (8, 8101, 5, 100);
INSERT INTO `Order Details` VALUES (9, 8102, 413, 1);
INSERT INTO `Order Details` VALUES (9, 8201, 43, 5);
INSERT INTO `Order Details` VALUES (10, 7303, 34, 54);
INSERT INTO `Order Details` VALUES (10, 7319, 100, 20);
INSERT INTO `Order Details` VALUES (10, 7519, 60, 25);
INSERT INTO `Order Details` VALUES (11, 7606, 290, 5);
INSERT INTO `Order Details` VALUES (12, 7719, 890, 3);
INSERT INTO `Order Details` VALUES (14, 8101, 5447, 77);
INSERT INTO `Order Details` VALUES (15, 7811, 50, 15);
INSERT INTO `Order Details` VALUES (16, 7811, 50, 25);
INSERT INTO `Order Details` VALUES (16, 8101, 45, 15);
INSERT INTO `Order Details` VALUES (17, 7202, 45, 12);
INSERT INTO `Order Details` VALUES (17, 7707, 56, 12);
INSERT INTO `Order Details` VALUES (17, 7807, 67, 12);
INSERT INTO `Order Details` VALUES (17, 7812, 25, 30);
INSERT INTO `Order Details` VALUES (18, 7007, 78, 35);
INSERT INTO `Order Details` VALUES (19, 7007, 40, 25);
INSERT INTO `Order Details` VALUES (19, 8001, 35, 20);
INSERT INTO `Order Details` VALUES (20, 7505, 10, 200);
INSERT INTO `Order Details` VALUES (20, 7619, 45, 38);