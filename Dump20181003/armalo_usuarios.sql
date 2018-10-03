-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: armalo
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
  PRIMARY KEY (`ID_USR`),
  KEY `fk_usuarios_roles_idx` (`TipoUSR`),
  CONSTRAINT `fk_usuarios_roles` FOREIGN KEY (`TipoUSR`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (2,'Divertido, trabajador',2,'Luis Alvarez','9e95619ba34147165572025bc4ac2e55','luis.alvarez.gil@gmail.com'),(3,'Divertido, trabajador',1,'Jose Santiago','9e95619ba34147165572025bc4ac2e55','jose.santiago@gmail.com'),(4,'Divertido, trabajador',2,'Brandon Mendoza','9e95619ba34147165572025bc4ac2e55','brandon@gmail.com'),(5,'Divertido, trabajador',1,'Diego Aquino','9e95619ba34147165572025bc4ac2e55','diego.aquino@gmail.com'),(6,'Bonit alto y guapo',1,'Drax','123456','el_aneuri24@hotmail.com'),(7,'Bonit alto y guapo',1,'Drax','123456','el_aneuri31@hotmail.com'),(8,'Bonit alto y guapo',1,'Drax','123456','el_aneuri33@hotmail.com'),(9,'Bonit alto y guapo',1,'Drax','123456','el_aneuri34@hotmail.com'),(10,'Desarrollador, locutor, entrenador y luchador profesional ademas de musico, parte del equipo de armalo!',1,'Brandon','123456','brandonthera10@gmail.com');
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

-- Dump completed on 2018-10-03 18:42:27
