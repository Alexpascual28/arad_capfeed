/*
SQLyog Community v12.16 (64 bit)
MySQL - 5.5.29 : Database - merlintest
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`merlin` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `merlin`;

/*Table structure for table `tbl_parameters` */

DROP TABLE IF EXISTS `tbl_parameters`;

CREATE TABLE `tbl_parameters` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `section` varchar(45) DEFAULT NULL,
  `name` varchar(45) NOT NULL,
  `value` varchar(45) NOT NULL,
  `units` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `tbl_parameters` */

LOCK TABLES `tbl_parameters` WRITE;

insert  into `tbl_parameters`(`id`,`section`,`name`,`value`,`units`,`description`) values 
(1,'Process','Dispense Time (example)','5','Seconds','Example process parameter'),
(2,'Process','Loading Position (example)','2','','Example process parameter'),
(3,'System','Global Target Weight (example)','200','mg','Example system parameter');

UNLOCK TABLES;

/*Table structure for table `tbl_positions` */

DROP TABLE IF EXISTS `tbl_positions`;

CREATE TABLE `tbl_positions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `groupname` varchar(50) NOT NULL DEFAULT '',
  `area` varchar(50) NOT NULL DEFAULT '',
  `areatype` int(11) NOT NULL DEFAULT '0',
  `lowindex` int(11) NOT NULL DEFAULT '1',
  `highindex` int(11) NOT NULL DEFAULT '100',
  `offsetx` double NOT NULL DEFAULT '0',
  `offsety` double NOT NULL DEFAULT '0',
  `offsetz` double NOT NULL DEFAULT '0',
  `incrementx` double NOT NULL DEFAULT '0',
  `incrementy` double NOT NULL DEFAULT '0',
  `incrementz` double NOT NULL DEFAULT '0',
  `lineincrementx` double NOT NULL DEFAULT '0',
  `lineincrementy` double NOT NULL DEFAULT '0',
  `lineincrementz` double NOT NULL DEFAULT '0',
  `linelength` int(11) NOT NULL DEFAULT '1',
  `firstanglex` double NOT NULL DEFAULT '0',
  `firstangley` double NOT NULL DEFAULT '0',
  `firstanglez` double NOT NULL DEFAULT '0',
  `incrementangle` double NOT NULL DEFAULT '0',
  `pickslowmovedistance` double NOT NULL DEFAULT '20',
  `pickslowmovespeedpercentage` int(11) NOT NULL DEFAULT '10',
  `placeslowmovedistance` double NOT NULL DEFAULT '20',
  `placeslowmovespeedpercentage` int(11) NOT NULL DEFAULT '10',
  `zplaceoffset` double NOT NULL DEFAULT '-5',
  PRIMARY KEY (`id`),
  KEY `Area` (`groupname`,`area`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_positions` */

LOCK TABLES `tbl_positions` WRITE;

insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (1,'Main Gantry','Rack 1',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (2,'Main Gantry','Rack 2',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (3,'Main Gantry','Rack 3',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (4,'Main Gantry','Rack 4',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (5,'Main Gantry','Rack 5',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (6,'Main Gantry','Rack 6',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (7,'Main Gantry','Rack 7',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (8,'Main Gantry','Rack 8',0,1,16,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (9,'Main Gantry','Heater',0,1,8,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (10,'Main Gantry','Rheometer',0,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (11,'Rheometer','Measurement',0,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (12,'Rheometer','Wash',0,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (13,'Rheometer','Dry',0,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,20,20,10,0);
insert  into `tbl_positions`(`id`,`groupname`,`area`,`areatype`,`lowindex`,`highindex`,`offsetx`,`offsety`,`offsetz`,`incrementx`,`incrementy`,`incrementz`,`lineincrementx`,`lineincrementy`,`lineincrementz`,`linelength`,`firstanglex`,`firstangley`,`firstanglez`,`incrementangle`,`pickslowmovedistance`,`pickslowmovespeedpercentage`,`placeslowmovedistance`,`placeslowmovespeedpercentage`,`zplaceoffset`) values (14,'Main Gantry','Barcode Reader',0,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,20,20,10,0);

UNLOCK TABLES;

/*Table structure for table `tbl_processstates` */

DROP TABLE IF EXISTS `tbl_processstates`;

CREATE TABLE `tbl_processstates` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `processname` varchar(50) NOT NULL DEFAULT '',
  `state` int(11) NOT NULL DEFAULT '0',
  `statelastchanged` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_processstates` */

LOCK TABLES `tbl_processstates` WRITE;

insert  into `tbl_processstates`(`id`,`processname`,`state`,`statelastchanged`) values (1,'Dispenser 1',4,'2012-07-30 10:48:46');
insert  into `tbl_processstates`(`id`,`processname`,`state`,`statelastchanged`) values (2,'Dispenser 2',1,'2012-07-29 19:49:23');
insert  into `tbl_processstates`(`id`,`processname`,`state`,`statelastchanged`) values (3,'Dispenser 3',1,'2012-07-29 19:49:23');
insert  into `tbl_processstates`(`id`,`processname`,`state`,`statelastchanged`) values (4,'Main Gantry',2,'2012-07-30 10:48:52');

UNLOCK TABLES;

/*Table structure for table `tbl_rackstatuses` */

DROP TABLE IF EXISTS `tbl_rackstatuses`;

CREATE TABLE `tbl_rackstatuses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rackname` varchar(50) NOT NULL DEFAULT '',
  `position` int(11) NOT NULL DEFAULT '0',
  `status` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_rackstatuses` */

LOCK TABLES `tbl_rackstatuses` WRITE;

UNLOCK TABLES;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;