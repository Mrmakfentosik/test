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
-- Table structure for table `advt_sell`
--

DROP TABLE IF EXISTS `advt_sell`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `advt_sell` (
  `idadvt_sell` int NOT NULL AUTO_INCREMENT,
  `iduser` int NOT NULL,
  `idhaus_type` int NOT NULL,
  `floor` int NOT NULL,
  `number_of_rooms` int NOT NULL,
  `kv_m` int NOT NULL,
  `adress` varchar(45) NOT NULL,
  `id_rayon` int NOT NULL,
  `description` longtext NOT NULL,
  `price` int NOT NULL,
  PRIMARY KEY (`idadvt_sell`),
  UNIQUE KEY `idadvt_seller_UNIQUE` (`idadvt_sell`),
  KEY `id-ht_idx` (`idhaus_type`),
  KEY `id_r_idx` (`id_rayon`),
  KEY `id-u_idx` (`iduser`),
  CONSTRAINT `id-ht` FOREIGN KEY (`idhaus_type`) REFERENCES `haus_type` (`idhaus_type`),
  CONSTRAINT `id-u` FOREIGN KEY (`iduser`) REFERENCES `user` (`iduser`),
  CONSTRAINT `id_r` FOREIGN KEY (`id_rayon`) REFERENCES `rayon` (`idrayon`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `advt_sell`
--

LOCK TABLES `advt_sell` WRITE;
/*!40000 ALTER TABLE `advt_sell` DISABLE KEYS */;
INSERT INTO `advt_sell` VALUES (11,21,4,1,2,34,'4',4,'asd',123),(12,1,2,1,2,34,'2',5,'asd',123),(13,1,2,12,2,34,'2',5,'asd',123),(14,1,3,1,2,3,'4',4,'qsad',1233);
/*!40000 ALTER TABLE `advt_sell` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-19  0:35:43
