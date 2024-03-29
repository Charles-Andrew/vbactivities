CREATE DATABASE  IF NOT EXISTS `activitydb` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `activitydb`;
-- MariaDB dump 10.19  Distrib 10.4.22-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: activitydb
-- ------------------------------------------------------
-- Server version	10.4.22-MariaDB

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
-- Table structure for table `active_sy`
--

DROP TABLE IF EXISTS `active_sy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `active_sy` (
  `idsy` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `idadmin` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `isloggedin` tinyint(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idadmin`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `class_offering`
--

DROP TABLE IF EXISTS `class_offering`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class_offering` (
  `idclass_offering` int(11) NOT NULL AUTO_INCREMENT,
  `idsubject` int(11) NOT NULL,
  `idsy` int(11) NOT NULL,
  `idteacher` int(11) NOT NULL,
  `day` varchar(45) NOT NULL,
  `time` varchar(45) NOT NULL,
  `room` varchar(45) NOT NULL,
  PRIMARY KEY (`idclass_offering`),
  KEY `subject_fk_idx` (`idsubject`),
  KEY `schoolyear_fk_idx` (`idsy`),
  KEY `teacher_fk_idx` (`idteacher`),
  CONSTRAINT `co_schoolyear_fk` FOREIGN KEY (`idsy`) REFERENCES `schoolyear_sem` (`idsy`) ON UPDATE CASCADE,
  CONSTRAINT `co_subject_fk` FOREIGN KEY (`idsubject`) REFERENCES `subject` (`idsubject`) ON UPDATE CASCADE,
  CONSTRAINT `co_teacher_fk` FOREIGN KEY (`idteacher`) REFERENCES `teacher` (`idteacher`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course` (
  `idcourse` int(11) NOT NULL AUTO_INCREMENT,
  `course_name` varchar(250) NOT NULL,
  `course_code` varchar(250) NOT NULL,
  PRIMARY KEY (`idcourse`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `schoolyear_sem`
--

DROP TABLE IF EXISTS `schoolyear_sem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schoolyear_sem` (
  `idsy` int(11) NOT NULL AUTO_INCREMENT,
  `year` varchar(45) NOT NULL,
  `sem` varchar(45) NOT NULL,
  PRIMARY KEY (`idsy`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `stud_course`
--

DROP TABLE IF EXISTS `stud_course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stud_course` (
  `idstudent` int(11) NOT NULL,
  `idsy` int(11) NOT NULL,
  `idcourse` int(11) NOT NULL,
  `year_level` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  KEY `student_fk_idx` (`idstudent`),
  KEY `cours_fk_idx` (`idcourse`),
  KEY `schoolyear_fk_idx` (`idsy`),
  CONSTRAINT `course_fk` FOREIGN KEY (`idcourse`) REFERENCES `course` (`idcourse`) ON UPDATE CASCADE,
  CONSTRAINT `schoolyear_fk` FOREIGN KEY (`idsy`) REFERENCES `schoolyear_sem` (`idsy`) ON UPDATE CASCADE,
  CONSTRAINT `student_fk` FOREIGN KEY (`idstudent`) REFERENCES `student` (`idstudent`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `idstudent` int(11) NOT NULL AUTO_INCREMENT,
  `LName` varchar(250) NOT NULL,
  `FName` varchar(250) NOT NULL,
  `MName` varchar(250) NOT NULL,
  `Gender` varchar(45) NOT NULL,
  `DOB` date NOT NULL,
  `ParentName` varchar(250) NOT NULL,
  `Address` varchar(250) NOT NULL,
  `ContactNo` varchar(45) NOT NULL,
  PRIMARY KEY (`idstudent`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `student_enroll_class`
--

DROP TABLE IF EXISTS `student_enroll_class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_enroll_class` (
  `idstudent` int(11) NOT NULL,
  `idclass_offering` int(11) NOT NULL,
  `midterm_grade` int(11) NOT NULL DEFAULT 0,
  `finals_grade` int(11) NOT NULL DEFAULT 0,
  `FinalGrade` int(11) NOT NULL DEFAULT 0,
  `remarks` varchar(255) NOT NULL DEFAULT 'N/A',
  KEY `sec_student_fk_idx` (`idstudent`),
  KEY `sec_co_fk_idx` (`idclass_offering`),
  CONSTRAINT `sec_co_fk` FOREIGN KEY (`idclass_offering`) REFERENCES `class_offering` (`idclass_offering`) ON UPDATE CASCADE,
  CONSTRAINT `sec_student_fk` FOREIGN KEY (`idstudent`) REFERENCES `student` (`idstudent`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject` (
  `idsubject` int(11) NOT NULL AUTO_INCREMENT,
  `subject_name` varchar(250) NOT NULL,
  `units` decimal(10,1) NOT NULL,
  PRIMARY KEY (`idsubject`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teacher` (
  `idteacher` int(11) NOT NULL AUTO_INCREMENT,
  `FName` varchar(250) NOT NULL,
  `MName` varchar(250) NOT NULL,
  `LName` varchar(250) NOT NULL,
  PRIMARY KEY (`idteacher`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `email` varchar(250) NOT NULL,
  PRIMARY KEY (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-19 10:40:20
