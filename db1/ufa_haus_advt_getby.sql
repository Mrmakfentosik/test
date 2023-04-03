-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: ufa_haus
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `advt_getby`
--

DROP TABLE IF EXISTS `advt_getby`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `advt_getby` (
  `idadvt_getby` int NOT NULL AUTO_INCREMENT,
  `iduser` int NOT NULL,
  `idhaus_type` int NOT NULL,
  `floor` int NOT NULL,
  `number_of_rooms` int NOT NULL,
  `kv_m` int NOT NULL,
  `adress` varchar(45) NOT NULL,
  `id_rayon` int NOT NULL,
  `min_arenda` date NOT NULL,
  `max_arenda` date NOT NULL,
  `description` longtext NOT NULL,
  `price` int NOT NULL,
  PRIMARY KEY (`idadvt_getby`),
  UNIQUE KEY `idadvt_getby_UNIQUE` (`idadvt_getby`),
  KEY `id-us_idx` (`iduser`),
  KEY `id-ht_idx` (`idhaus_type`),
  KEY `id=ray_idx` (`id_rayon`),
  CONSTRAINT `i=htp` FOREIGN KEY (`idhaus_type`) REFERENCES `haus_type` (`idhaus_type`),
  CONSTRAINT `id-us` FOREIGN KEY (`iduser`) REFERENCES `user` (`iduser`),
  CONSTRAINT `id=ray` FOREIGN KEY (`id_rayon`) REFERENCES `rayon` (`idrayon`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `advt_getby`
--

LOCK TABLES `advt_getby` WRITE;
/*!40000 ALTER TABLE `advt_getby` DISABLE KEYS */;
INSERT INTO `advt_getby` VALUES (1,1,2,1,2,34,'asd',4,'2021-03-15','2021-03-18','adas',123),(2,1,10,1,2,3,'as',2,'2021-03-15','2021-03-26','asdas',123),(3,1,13,1,2,1,'asd',2,'2021-03-15','2021-03-18','asd',123);
/*!40000 ALTER TABLE `advt_getby` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-19  0:35:44
