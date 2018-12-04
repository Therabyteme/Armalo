-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
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
  `flag` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_EVENT`),
  KEY `Invitados_idx` (`ID_LISTA`),
  KEY `Organizador_idx` (`ID_ORG`),
  KEY `Agenda_idx` (`Agenda`),
  KEY `staff_idx` (`Staff`),
  CONSTRAINT `Agenda` FOREIGN KEY (`Agenda`) REFERENCES `agenda` (`id_agenda`),
  CONSTRAINT `Invitados` FOREIGN KEY (`ID_LISTA`) REFERENCES `lista_de_asistentes` (`id_lista`),
  CONSTRAINT `Organizador` FOREIGN KEY (`ID_ORG`) REFERENCES `usuarios` (`id_usr`),
  CONSTRAINT `staff` FOREIGN KEY (`Staff`) REFERENCES `staff` (`id_staff`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (2,NULL,2,'Plazoleta',2,12,0,'2018-11-01','ACTIVO',4,2,'http://directory.fitness-to.com/wp-content/uploads/2014/12/openmat2.jpg','Open Mat',0,'20:00:00','21:00:00','Defensa personal en la colmena, aprende movimientos basicos que te llevaran a tener mayor equilibrio tanto mental como fisico, mente sana, cuerpo sano',4),(3,NULL,3,'Plazoleta',3,0,NULL,'2018-07-04','ACTIVO',9,9,'https://www.malagaldia.es/wp-content/uploads/2018/08/cine-abierto.jpg','Cine en la plazoleta',0,'20:00:00','21:40:00','Juntos veremos la pelicula de drama historico ANNA KARENINA!',4),(4,NULL,3,'Plazoleta',3,0,NULL,'2018-07-04','ACTIVO',9,9,'https://www.malagaldia.es/wp-content/uploads/2018/08/cine-abierto.jpg','Cine en la plazoleta',0,'20:00:00','21:40:00','Juntos veremos la pelicula de drama historico ANNA KARENINA!',4),(5,NULL,3,'Aula Radial',1,40,NULL,'2018-07-09','ACTIVO',10,9,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSWJZdgWZksFsevMbxl_ctyWQiVBf3n5EXttLQq-Npft3p0TXxKw','Como ser feliz',250,'15:00:00','15:40:00','Alcanzar la felicidad es algo que debemos hacer y en esta charla te mostramos como puedes acercarte a ella',1),(6,NULL,3,'Terraza del AH',2,40,NULL,'2018-09-11','ACTIVO',5,9,'https://cdn.shopify.com/s/files/1/1728/2157/articles/Dietitian_Cassie_NEW.png?v=1506536263','Yoga en Intec',250,'15:00:00','15:40:00','Como parte de la semana de la salud tendremos esta leccion muy importante de yoga que podremos aplicar en nuestra vida diaria para combatir el estres del diario vivir',1),(7,NULL,3,'INTEC',3,0,NULL,'2018-10-01','ACTIVO',6,9,'https://elnacional.com.do/wp-content/uploads/2015/12/10_Actualidad_14_2p01.jpg','Inauguracion del hoyo',0,'18:00:00','19:00:00','Acompanenos en este evento cumbre donde inauguraremos el nuevo edificio de ingenierias en el antiguo hoyo, la colmena se expande!',5),(8,NULL,3,'CEGES',1,40,NULL,'2018-11-25','ACTIVO',7,9,'https://assets.trome.pe/files/article_main/uploads/2018/03/07/5aa09b802d9c2.jpeg','El rol de la mujer en la empresa moderna',0,'18:00:00','19:00:00','descubre los nuevos retos que asume la mujer en este siglo XXI y mira como esta lo supera...',2),(9,NULL,3,'Plazoleta',3,0,NULL,'2018-12-01','ACTIVO',8,9,'https://norfipc.com/fotos/felicitacion/feliz-navidad-juntos.jpeg','Navidad INTEC',0,'17:00:00','18:00:00','Unete a la alegria de la navidad junto a la familia inteciana! Acompananos a este agazajo navideno en tu colmena',4),(10,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(11,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(12,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(13,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(14,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00','Hola',1),(15,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(16,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(17,NULL,2,'INTEC',1,0,NULL,'2018-05-04','ACTIVO',3,9,NULL,NULL,0,'09:00:00','11:00:00',NULL,1),(20,NULL,2,'Auditorio',2,12,0,'2018-10-09','ACTIVO',4,3,'http://directory.fitness-to.com/wp-content/uploads/2014/12/openmat2.jpg','test',100,'17:47:00','17:48:00','sdfsdfsdf',9),(22,NULL,2,'Auditorio GC',2,12,0,'2018-12-09','ACTIVO',4,2,'https://firebasestorage.googleapis.com/v0/b/armalo-434d6.appspot.com/o/placeholder.png?alt=media&token=39e0c8ec-2b1a-4301-b3b4-313e20924277','Proyecto Final',0,'19:00:00','21:00:00','Venga a ver los lindos estudiantes de la linda profesora Francia.',1),(25,NULL,2,'Plazoleta',2,12,0,'2018-10-09','ACTIVO',14,2,'https://pythonizame.s3.amazonaws.com/media/uploads/2015/11/19/pycarraibean.jpg','PyCaribbean',2000,'13:50:00','20:00:00','PyCaribbean is the first Python Conference of its kind on the region of the Caribbean. Our goal is to connect the North American and European Developer Community with the Hispanic and Caribbean community',1),(26,NULL,2,'Bosquecito',2,12,0,'2018-12-09','ACTIVO',15,2,'https://pythonizame.s3.amazonaws.com/media/uploads/2015/11/19/pycarraibean.jpg','Boda De Luis',0,'09:20:00','13:20:00','Vengan a la tremenda boda de Luis',1),(27,NULL,2,'Aula Radial',2,12,0,'2018-12-31','ACTIVO',16,2,'https://firebasestorage.googleapis.com/v0/b/armalo-434d6.appspot.com/o/placeholder.png?alt=media&token=39e0c8ec-2b1a-4301-b3b4-313e20924277','Fiesta de Grad',2000,'09:00:00','16:00:00','slkdjfliwoejfoiwejfowiejf',1);
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

-- Dump completed on 2018-12-03 19:54:26
