-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: armalo
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agenda`
--

DROP TABLE IF EXISTS `agenda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agenda` (
  `id_agenda` int(11) NOT NULL AUTO_INCREMENT,
  `Eventos` varchar(5000) NOT NULL,
  PRIMARY KEY (`id_agenda`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenda`
--

LOCK TABLES `agenda` WRITE;
/*!40000 ALTER TABLE `agenda` DISABLE KEYS */;
INSERT INTO `agenda` VALUES (1,'Tomar Cafe'),(2,'beber refresco'),(3,'netflix and chill'),(4,'probar armalo'),(5,'no se casen carajo!!'),(6,'mentira, pero graduense primero'),(7,'another placeholder text, no time to be creative'),(8,'viaje manin, viaje'),(9,'hay que dormir'),(10,'amanecer');
/*!40000 ALTER TABLE `agenda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_evento`
--

DROP TABLE IF EXISTS `categoria_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categoria_evento` (
  `categoria_id` int(11) NOT NULL,
  `evento_id` int(11) NOT NULL,
  PRIMARY KEY (`categoria_id`,`evento_id`),
  KEY `fk_categoria_evento_1_idx` (`evento_id`),
  CONSTRAINT `fk_categoria_evento_id_categoria` FOREIGN KEY (`categoria_id`) REFERENCES `categories` (`id`),
  CONSTRAINT `fk_categoria_evento_id_evento` FOREIGN KEY (`evento_id`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_evento`
--

LOCK TABLES `categoria_evento` WRITE;
/*!40000 ALTER TABLE `categoria_evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
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
  CONSTRAINT `Invitados` FOREIGN KEY (`ID_LISTA`) REFERENCES `lista_de_asistentes` (`id_lista`),
  CONSTRAINT `Organizador` FOREIGN KEY (`ID_ORG`) REFERENCES `usuarios` (`id_usr`),
  CONSTRAINT `staff` FOREIGN KEY (`Staff`) REFERENCES `staff` (`id_staff`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (2,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(3,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(4,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(5,NULL,NULL,'default',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(6,NULL,NULL,'armalo',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(7,NULL,NULL,'mi casa',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(8,NULL,NULL,'no lean esto',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(9,NULL,NULL,'pero que paso hijo mio?',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(10,NULL,NULL,'el decimo papa',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(11,NULL,NULL,'entonces?',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(12,NULL,NULL,'vamonos',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(13,NULL,NULL,'beta',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(14,NULL,NULL,'testing',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00','Hola'),(15,NULL,NULL,'de',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(16,NULL,NULL,'armalo',1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:00:00','00:00:00',NULL),(17,NULL,NULL,NULL,1,0,NULL,'2018-10-04','ACTIVO',1,2,NULL,NULL,0,'00:16:00','02:00:00',NULL);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento_tags`
--

DROP TABLE IF EXISTS `evento_tags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `evento_tags` (
  `ID_EVENTO` int(11) NOT NULL,
  `ID_TAG` int(11) NOT NULL,
  PRIMARY KEY (`ID_EVENTO`,`ID_TAG`),
  KEY `fl_tag_id_idx` (`ID_TAG`),
  CONSTRAINT `fk_evento_id` FOREIGN KEY (`ID_EVENTO`) REFERENCES `evento` (`id_event`),
  CONSTRAINT `fl_tag_id` FOREIGN KEY (`ID_TAG`) REFERENCES `tags` (`id_tag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento_tags`
--

LOCK TABLES `evento_tags` WRITE;
/*!40000 ALTER TABLE `evento_tags` DISABLE KEYS */;
INSERT INTO `evento_tags` VALUES (2,1),(2,2);
/*!40000 ALTER TABLE `evento_tags` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historia_de_eventos_org`
--

DROP TABLE IF EXISTS `historia_de_eventos_org`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `historia_de_eventos_org` (
  `ID_ORG` int(11) NOT NULL,
  `ID_EVENT` int(11) NOT NULL,
  PRIMARY KEY (`ID_ORG`),
  KEY `ID_EVENTO_idx` (`ID_EVENT`),
  CONSTRAINT `ID_EVENTO` FOREIGN KEY (`ID_EVENT`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historia_de_eventos_org`
--

LOCK TABLES `historia_de_eventos_org` WRITE;
/*!40000 ALTER TABLE `historia_de_eventos_org` DISABLE KEYS */;
/*!40000 ALTER TABLE `historia_de_eventos_org` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historia_de_eventos_usr`
--

DROP TABLE IF EXISTS `historia_de_eventos_usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `historia_de_eventos_usr` (
  `ID_USR` int(11) DEFAULT NULL,
  `ID_EVENT` int(11) DEFAULT NULL,
  KEY `ID_EVENTO_idx` (`ID_EVENT`),
  CONSTRAINT `Event` FOREIGN KEY (`ID_EVENT`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historia_de_eventos_usr`
--

LOCK TABLES `historia_de_eventos_usr` WRITE;
/*!40000 ALTER TABLE `historia_de_eventos_usr` DISABLE KEYS */;
/*!40000 ALTER TABLE `historia_de_eventos_usr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `items` (
  `ID_ITEM` int(11) NOT NULL,
  `Orden` int(11) NOT NULL DEFAULT '0',
  `AGENDA_ID` int(11) NOT NULL,
  `Actividad` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM`),
  KEY `fk_items_agenda_idx` (`AGENDA_ID`),
  CONSTRAINT `fk_items_agenda` FOREIGN KEY (`AGENDA_ID`) REFERENCES `agenda` (`id_agenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items`
--

LOCK TABLES `items` WRITE;
/*!40000 ALTER TABLE `items` DISABLE KEYS */;
/*!40000 ALTER TABLE `items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lista_de_asistentes`
--

DROP TABLE IF EXISTS `lista_de_asistentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lista_de_asistentes` (
  `ID_LISTA` int(11) NOT NULL AUTO_INCREMENT,
  `ID_USR` int(11) DEFAULT NULL,
  `ID_EVENT` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_LISTA`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_de_asistentes`
--

LOCK TABLES `lista_de_asistentes` WRITE;
/*!40000 ALTER TABLE `lista_de_asistentes` DISABLE KEYS */;
INSERT INTO `lista_de_asistentes` VALUES (1,3,5,'Lista de prueba');
/*!40000 ALTER TABLE `lista_de_asistentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `publicidad` (
  `ID_EVENT` int(11) DEFAULT NULL,
  `ID_ADMIN` int(11) DEFAULT NULL,
  `Monto` int(11) DEFAULT NULL,
  `Duracion` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  KEY `Administrador_idx` (`ID_ADMIN`),
  KEY `Evento_idx` (`ID_EVENT`),
  CONSTRAINT `Administrador` FOREIGN KEY (`ID_ADMIN`) REFERENCES `usuarios` (`id_usr`),
  CONSTRAINT `Evento` FOREIGN KEY (`ID_EVENT`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidad`
--

LOCK TABLES `publicidad` WRITE;
/*!40000 ALTER TABLE `publicidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `publicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retro_alimentacion`
--

DROP TABLE IF EXISTS `retro_alimentacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `retro_alimentacion` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` text CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `id_evento` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_retro_alimentacion_evento_idx` (`id_evento`),
  CONSTRAINT `fk_retro_alimentacion_evento` FOREIGN KEY (`id_evento`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retro_alimentacion`
--

LOCK TABLES `retro_alimentacion` WRITE;
/*!40000 ALTER TABLE `retro_alimentacion` DISABLE KEYS */;
INSERT INTO `retro_alimentacion` VALUES (1,'Buen evento',2);
/*!40000 ALTER TABLE `retro_alimentacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `roles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rol` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Usuario');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `staff` (
  `ID_STAFF` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(45) NOT NULL,
  `ID_EVENTO` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_STAFF`),
  KEY `fk_staff_evento_idx` (`ID_EVENTO`),
  CONSTRAINT `fk_staff_evento` FOREIGN KEY (`ID_EVENTO`) REFERENCES `evento` (`id_event`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (2,'leones',NULL),(3,'',NULL),(4,'',NULL),(5,'equipo beta',NULL),(6,'',NULL),(7,'',2),(8,'',3),(9,'',4),(10,'',5),(11,'aguilas',6);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tags`
--

DROP TABLE IF EXISTS `tags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tags` (
  `ID_TAG` int(11) NOT NULL,
  `Nombre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`ID_TAG`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tags`
--

LOCK TABLES `tags` WRITE;
/*!40000 ALTER TABLE `tags` DISABLE KEYS */;
INSERT INTO `tags` VALUES (1,'Mañana'),(2,'Tarde'),(3,'Noche');
/*!40000 ALTER TABLE `tags` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `ID_USR` int(11) NOT NULL AUTO_INCREMENT,
  `Resume` varchar(300) DEFAULT NULL,
  `TipoUSR` int(11) NOT NULL,
  `Nombre_USR` varchar(45) NOT NULL,
  `Pass` varchar(45) NOT NULL,
  `Correo` varchar(200) NOT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `ID_STAFF` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_USR`),
  KEY `fk_usuarios_roles_idx` (`TipoUSR`),
  KEY `fk_group_staffs_idx` (`ID_STAFF`),
  CONSTRAINT `fk_group_staffs` FOREIGN KEY (`ID_STAFF`) REFERENCES `staff` (`id_staff`),
  CONSTRAINT `fk_usuarios_roles` FOREIGN KEY (`TipoUSR`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (2,'Divertido, trabajador',2,'Luis Alvarez','9e95619ba34147165572025bc4ac2e55','luis.alvarez.gil@gmail.com',NULL,7),(3,'Divertido, trabajador',1,'Jose Santiago','9e95619ba34147165572025bc4ac2e55','jose.santiago@gmail.com',NULL,7),(4,'Divertido, trabajador',2,'Brandon Mendoza','9e95619ba34147165572025bc4ac2e55','brandon@gmail.com',NULL,7),(5,'Divertido, trabajador',1,'Diego Aquino','9e95619ba34147165572025bc4ac2e55','diego.aquino@gmail.com',NULL,8),(6,'Bonit alto y guapo',1,'Drax','123456','el_aneuri24@hotmail.com',NULL,8),(7,'Bonit alto y guapo',1,'Drax','123456','el_aneuri31@hotmail.com',NULL,8),(8,'Bonit alto y guapo',1,'Drax','123456','el_aneuri33@hotmail.com',NULL,9),(9,'Bonit alto y guapo',1,'Drax','123456','el_aneuri34@hotmail.com',NULL,9),(10,'Desarrollador, locutor, entrenador y luchador profesional ademas de musico, parte del equipo de armalo!',1,'Brandon','123456','brandonthera10@gmail.com',NULL,9);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-08  1:27:01
