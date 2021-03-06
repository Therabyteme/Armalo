-- MySQL dump 10.13  Distrib 5.7.20, for Linux (x86_64)
--
-- Host: 127.0.0.1    Database: armalo
-- ------------------------------------------------------
-- Server version	5.7.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `evento` (
  `ID_EVENT` int(11) NOT NULL AUTO_INCREMENT,
  `ID_LISTA` int(11) DEFAULT NULL,
  `ID_ORG` int(11) DEFAULT NULL,
  `location` varchar(45) DEFAULT NULL,
  `Tipo` int(11) DEFAULT NULL,
  `CUPO_MAX` int(11) NOT NULL,
  `CUPO_OCU` int(11) DEFAULT '0',
  `FECHA` date DEFAULT NULL,
  `ESTADO` varchar(45) DEFAULT NULL,
  `Agenda` int(11) DEFAULT NULL,
  `Staff` int(11) NOT NULL,
  `Imagen` varchar(200) DEFAULT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Precio` int(11) NOT NULL DEFAULT '0',
  `Inicio` time NOT NULL,
  `Fin` time NOT NULL,
  `Descripcion` text,
  PRIMARY KEY (`ID_EVENT`),
  KEY `Invitados_idx` (`ID_LISTA`),
  KEY `Organizador_idx` (`ID_ORG`),
  KEY `Agenda_idx` (`Agenda`),
  KEY `staff_idx` (`Staff`),
  CONSTRAINT `Agenda` FOREIGN KEY (`Agenda`) REFERENCES `agenda` (`id_agenda`),
  CONSTRAINT `Invitados` FOREIGN KEY (`ID_LISTA`) REFERENCES `lista_de_asistentes` (`ID_LISTA`),
  CONSTRAINT `Organizador` FOREIGN KEY (`ID_ORG`) REFERENCES `usuarios` (`ID_USR`),
  CONSTRAINT `staff` FOREIGN KEY (`Staff`) REFERENCES `staff` (`ID_STAFF`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (2,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(3,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(4,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(5,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(6,NULL,NULL,'armalo',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(7,NULL,NULL,'mi casa',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(8,NULL,NULL,'no lean esto',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(9,NULL,NULL,'pero que paso hijo mio?',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(10,NULL,NULL,'el decimo papa',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(11,NULL,NULL,'entonces?',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(12,NULL,NULL,'vamonos',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(13,NULL,NULL,'beta',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(14,NULL,NULL,'testing',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(15,NULL,NULL,'de',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(16,NULL,NULL,'armalo',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(17,NULL,NULL,NULL,1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:16:00','02:00:00',NULL);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-07 15:19:42
