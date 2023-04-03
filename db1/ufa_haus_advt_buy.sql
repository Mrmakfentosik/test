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
-- Table structure for table `advt_buy`
--

DROP TABLE IF EXISTS `advt_buy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `advt_buy` (
  `idadvt_buy` int NOT NULL AUTO_INCREMENT,
  `iduser` int NOT NULL,
  `idhaus__type` int NOT NULL,
  `min_floor` int NOT NULL,
  `max_floor` int NOT NULL,
  `min_n_rows` int NOT NULL,
  `max_n_rows` int NOT NULL,
  `idrayon` int NOT NULL,
  `descrtiption` longtext NOT NULL,
  `min_price` int NOT NULL,
  `max_price` int NOT NULL,
  PRIMARY KEY (`idadvt_buy`),
  UNIQUE KEY `idadvt_buyer_UNIQUE` (`idadvt_buy`),
  KEY `id-h-t_idx` (`idhaus__type`),
  KEY `id-r_idx` (`idrayon`),
  KEY `id-uu_idx` (`iduser`),
  CONSTRAINT `id-h-t` FOREIGN KEY (`idhaus__type`) REFERENCES `haus_type` (`idhaus_type`),
  CONSTRAINT `id-r` FOREIGN KEY (`idrayon`) REFERENCES `rayon` (`idrayon`),
  CONSTRAINT `id-uu` FOREIGN KEY (`iduser`) REFERENCES `user` (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `advt_buy`
--

LOCK TABLES `advt_buy` WRITE;
/*!40000 ALTER TABLE `advt_buy` DISABLE KEYS */;
INSERT INTO `advt_buy` VALUES (1,1,2,1,2,3,2,2,'Куплю квартиру в центре города с евроремонтом.',5,6),(2,1,3,1,3,1,3,4,'asdas',3,4),(3,1,14,1,2,1,2,1,'asda',1,2),(4,1,3,1,4,1,4,4,'12efgfbf',1,1),(5,1,14,1,2,1,2,1,'12qwefdsvscxz',12,213),(6,1,2,1,2,3,2,4,'dsa',5,6),(7,1,2,1,2,3,2,3,'asd',5,6);
/*!40000 ALTER TABLE `advt_buy` ENABLE KEYS */;
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
