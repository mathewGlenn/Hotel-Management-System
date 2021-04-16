-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2017 at 02:40 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelmanagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_adminusers`
--

CREATE TABLE `tbl_adminusers` (
  `Admin_ID` int(11) NOT NULL,
  `Admin_Username` varchar(50) NOT NULL,
  `Admin_Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_adminusers`
--

INSERT INTO `tbl_adminusers` (`Admin_ID`, `Admin_Username`, `Admin_Password`) VALUES
(1, 'glenn', 'glenn'),
(2, 'angelica', 'angelica');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_allcheckins`
--

CREATE TABLE `tbl_allcheckins` (
  `Room_ID` varchar(50) NOT NULL,
  `Customer_ID` int(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `Person_No` int(50) NOT NULL,
  `Description` varchar(50) NOT NULL,
  `Vehicle_Info` varchar(50) NOT NULL,
  `Checkin` varchar(50) NOT NULL,
  `Checkout` varchar(50) NOT NULL,
  `orHour` varchar(50) NOT NULL,
  `Total_Amount` varchar(50) NOT NULL,
  `Cash` varchar(77) NOT NULL,
  `Cash_Change` varchar(77) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_allcheckins`
--

INSERT INTO `tbl_allcheckins` (`Room_ID`, `Customer_ID`, `Room_Type`, `Room_Name`, `Person_No`, `Description`, `Vehicle_Info`, `Checkin`, `Checkout`, `orHour`, `Total_Amount`, `Cash`, `Cash_Change`) VALUES
('6737687394932', 1, 'Standard', '101', 2, '', 'Ferrari', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '6', '?600 ', '', ''),
('76473940243', 2, 'Family', '103', 2, '', 'lambo', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '3', '?900 ', '', ''),
('', 3, 'Family', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('', 4, 'Family', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('', 5, 'Family', '101', 2, '', 'yhhfjkhkhdfndg', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('', 6, 'Family', '101', 3, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '7', '?2100 ', '', ''),
('', 7, 'Family', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('', 8, 'Family', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('2147483647', 9, 'Family', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?2999 ', '', ''),
('2147483647', 10, 'Family', '103', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?5998 ', '', ''),
('6737687394932', 11, 'Standard', '101', 0, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', '', ''),
('6737687394932', 12, 'Standard', '101', 2, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', '', ''),
('826337998792', 13, 'Family', '103', 0, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?8997 ', '', ''),
('76473940243', 14, 'Family', '102', 1, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?8997 ', '', ''),
('76473940243', 15, 'Family', '102', 3, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?8997 ', '', ''),
('826337998792', 16, 'Deluxe', '103', 0, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', '', ''),
('826337998792', 17, 'Family', '103', 0, '', '', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?5998 ', '', ''),
('76473940243', 18, 'Family', '102', 3, '', 'Red Camaro', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '?14995 ', '', ''),
('76473940243', 19, 'Family', '102', 6, '', 'Van', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '7', '?2100 ', '', ''),
('826337998792', 20, 'Deluxe', '103', 3, '', '', 'Tuesday, September 26, 2017', 'Tuesday, September 26, 2017', '10', '', '', ''),
('6737687394932', 21, 'Standard', '101', 0, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '', '', ''),
('826337998792', 22, 'Deluxe', '103', 2, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '', '', ''),
('826337998792', 23, 'Deluxe', '103', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '', '', ''),
('6737687394932', 24, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?1998 ', '', ''),
('826337998792', 25, 'Deluxe', '103', 1, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?9998 ', '', ''),
('76473940243', 26, 'Family', '102', 2, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '?2900 ', '', ''),
('826337998792', 27, 'Deluxe', '103', 2, '', '', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '', '?14997 ', '', ''),
('6737687394932', 28, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?1998 ', '', ''),
('6737687394932', 29, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '', '', ''),
('826337998792', 30, 'Deluxe', '103', 0, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?9998 ', '', ''),
('826337998792', 31, 'Deluxe', '103', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '8', '?9998 ', '', ''),
('76473940243', 32, 'Family', '102', 3, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '', '?8700 ', '', ''),
('6737687394932', 33, 'Standard', '101', 1, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?1998 ', '', ''),
('76473940243', 34, 'Family', '102', 1, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?5800 ', '', ''),
('826337998792', 35, 'Deluxe', '103', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?9998 ', '', ''),
('6737687394932', 36, 'Standard', '101', 0, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?1998 ', '', ''),
('76473940243', 37, 'Family', '102', 2, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '', '?8700 ', '', ''),
('826337998792', 38, 'Deluxe', '103', 0, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '', '', '', ''),
('76473940243', 39, 'Family', '102', 0, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?5800 ', '', ''),
('6737687394932', 40, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '', '?2997 ', '', ''),
('6737687394932', 41, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?1998 ', '', ''),
('76473940243', 42, 'Family', '102', 6, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?5800 ', '', ''),
('826337998792', 43, 'Deluxe', '103', 0, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '8', '?4999 ', '', ''),
('87783240990950', 44, 'Double', '104', 3, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '8', '', '', ''),
('826337998792', 45, 'Deluxe', '103', 3, '', '', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '', '?9998 ', '', ''),
('6737687394932', 46, 'Standard', '101', 2, '', '', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '?999 ', '', ''),
('76473940243', 47, 'Family', '102', 4, '', '', 'Tuesday, September 26, 2017', 'Saturday, September 30, 2017', '', '?8700 ', '', ''),
('6737687394932', 48, 'Standard', '101', 3, '', '', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '', '?1998 ', '', ''),
('76473940243', 49, 'Family', '102', 2, '', 'red', 'Wednesday, September 27, 2017', 'Friday, September 29, 2017', '', '?2900 ', '', ''),
('76473940243', 50, 'Family', '102', 0, '', '', 'Thursday, September 28, 2017', 'Thursday, September 28, 2017', '', '?2999 ', '', ''),
('6737687394932', 51, 'Standard', '101', 2, '', '', 'Thursday, September 28, 2017', 'Thursday, September 28, 2017', '9', '?900 ', '', ''),
('826337998792', 52, 'Deluxe', '103', 2, '', '', 'Thursday, September 28, 2017', 'Thursday, September 28, 2017', '', '?11997 ', '', ''),
('76473940243', 53, 'Family', '102', 0, '', '', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '', '?2900 ', '', ''),
('6737687394932', 54, 'Standard', '101', 3, '', '', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '', '?1299 ', '', ''),
('6737687394932', 55, 'Standard', '101', 0, '', '', 'Thursday, September 28, 2017', 'Thursday, September 28, 2017', '', '?3996 ', '', ''),
('826337998792', 56, 'Deluxe', '103', 4, '', '', 'Thursday, September 28, 2017', 'Thursday, September 28, 2017', '', '?31190 ', '', ''),
('76473940243', 57, 'Family', '102', 2, '', '', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '', '?3300 ', '', ''),
('6737687394932', 58, 'Standard', '101', 2, '', '', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '', '?1197 ', '', ''),
('826337998792', 59, 'Deluxe', '103', 2, '', '', 'Thursday, September 28, 2017', 'Sunday, October 1, 2017', '', '?10596 ', '', ''),
('76473940243', 60, 'Family', '102', 2, '', '', 'Friday, September 29, 2017', 'Monday, October 2, 2017', '', '?6200 ', '', ''),
('76473940243', 61, 'Family', '102', 5, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '', '?3900 ', '', ''),
('6737687394932', 62, 'Standard', '101', 2, '', '', 'Sunday, October 1, 2017', 'Friday, October 13, 2017', '', '?11187 ', '', ''),
('6737687394932', 63, 'Standard', '101', 3, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '', '?11286 ', '', ''),
('87783240990950', 64, 'Double', '104', 4, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '6', '?1999 ', '', ''),
('826337998792', 65, 'Deluxe', '103', 7, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '', '', '', ''),
('6737687394932', 66, 'Standard', '101', 2, '', '', 'Sunday, October 1, 2017', 'Thursday, October 5, 2017', '', '?3492 ', '', ''),
('76473940243', 67, 'Family', '102', 5, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '', '?1200 ', '', ''),
('87783240990950', 68, 'Double', '104', 4, '', '', 'Sunday, October 1, 2017', 'Sunday, October 1, 2017', '', '', '', ''),
('826337998792', 69, 'Deluxe', '103', 3, '', '', 'Sunday, October 1, 2017', 'Thursday, October 5, 2017', '', '?16492 ', '', ''),
('6737687394932', 70, 'Standard', '101', 2, '', '', 'Sunday, October 1, 2017', 'Friday, October 6, 2017', '', '?4392 ', '', ''),
('76473940243', 71, 'Family', '102', 5, '', '', 'Sunday, October 1, 2017', 'Tuesday, October 3, 2017', '', '?4300 ', '', ''),
('6737687394932', 72, 'Standard', '101', 2, '', '', 'Monday, October 2, 2017', 'Monday, October 2, 2017', '', '?9189 ', '', ''),
('76473940243', 73, 'Family', '102', 2, '', 'Red sedan', 'Monday, October 2, 2017', 'Monday, October 2, 2017', '', '?9100 ', '', ''),
('87783240990950', 74, 'Double', '104', 3, '', '', 'Wednesday, 4 October 2017', 'Saturday, 7 October 2017', '2', '?4794 ', '', ''),
('87783240990950', 75, 'Double', '104', 1, '', '', 'Wednesday, 4 October 2017', 'Wednesday, 4 October 2017', '', '?2198 ', '', ''),
('6737687394932', 76, 'Standard', '101', 2, '', '', 'Wednesday, 4 October 2017', 'Wednesday, 4 October 2017', '', '?2196 ', '', ''),
('6737687394932', 77, 'Standard', '101', 4, '', '', 'Wednesday, 4 October 2017', 'Wednesday, 4 October 2017', '', '?5391 ', '', ''),
('826337998792', 78, 'Deluxe', '103', 0, '', '', 'Wednesday, 4 October 2017', 'Wednesday, 4 October 2017', '', '?24995 ', '', ''),
('76473940243', 79, 'Family 108', 'Family 108', 5, '', '', 'Thursday, 5 October 2017', 'Thursday, 5 October 2017', '11', '3300', '4000', '700.00'),
('87783240990950', 80, 'Double 105', 'Double 105', 1, '', '', 'Thursday, 5 October 2017', 'Saturday, 14 October 2017', '', '16191', '17000', '809.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_availablerooms`
--

CREATE TABLE `tbl_availablerooms` (
  `Room_ID` varchar(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `Person_No` int(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Rate_Per_Hour` varchar(50) NOT NULL,
  `Rate_Per_Day` varchar(50) NOT NULL,
  `Extra_Person_PH` int(50) NOT NULL,
  `uid` int(78) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_availablerooms`
--

INSERT INTO `tbl_availablerooms` (`Room_ID`, `Room_Type`, `Room_Name`, `Person_No`, `Description`, `Rate_Per_Hour`, `Rate_Per_Day`, `Extra_Person_PH`, `uid`) VALUES
('6737687394932', 'Standard 101', '', 2, 'Air conditioned room; installed TV; 1 Queen-size bed. minimum of 2 person.maximum of 4 person. \r\nper hour= 99. per day=999. \r\nextra-person=99. ', '99', '999', 99, 69),
('826337998792', 'Deluxe 111', '', 0, 'Air conditioned; Hot Tub; Free Dinner; 2 King-size and 1 Queen-size bed. Installed cabled TV with Stereo.\ngood for 3 person;\nmaximum of 5 persons;\nper hour= 399;\nper day= 4999;\nextra-person=299;', '399', '4999', 299, 70),
('749343840924', 'Standard 102', '', 2, 'Air conditioned room; installed TV; 1 Queen-size bed. minimum of 2 person.maximum of 4 person. \r\nper hour= 99. per day=999. \r\nextra-person=99. ', '99', '999', 99, 71),
('578573848534859', 'Double 106', '', 3, 'Air-conditioned; Free lunch; Installed cabled TV.  2 bedrooms; \r\ngood for 4 persons.\r\nmaximum of 6 persons;\r\nper  hour= 300;\r\nper day= 1999;\r\nextra-person=199', '300', '1999', 199, 73),
('85385093534055', 'Family 109', '', 5, '1 queen-size bed & 2 extra-long bed; Airconditioned; installed cabled tv; free lunch good for 5 person. maximum of 7 person.\r\nper hour= 300;\r\nper day= 2900;\r\nextra-person=200;', '300', '2900', 200, 74),
('242742492948', 'Deluxe 112', '', 3, 'Air conditioned; Hot Tub; Free Dinner; 2 King-size and 1 Queen-size bed. Installed cabled TV with Stereo.\r\ngood for 3 person;\r\nmaximum of 5 persons;\r\nper hour= 399;\r\nper day= 4999;\r\nextra-person=299;', '399', '4999', 299, 75),
('76473940243', 'Family 108', 'Family 108', 5, '1 queen-size bed & 2 extra-long bed; Airconditioned; installed cabled tv; free lunch good for 5 person. maximum of 7 person.\r\nper hour= 300;\r\nper day= 2900;\r\nextra-person=200;', '300', '2900', 200, 76),
('87783240990950', 'Double 105', 'Double 105', 1, 'Air-conditioned; Free lunch; Installed cabled TV.  2 bedrooms; \r\ngood for 4 persons.\r\nmaximum of 6 persons;\r\nper  hour= 300;\r\nper day= 1999;\r\nextra-person=199', '300', '1999', 199, 77);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_checkincheckout`
--

CREATE TABLE `tbl_checkincheckout` (
  `Room_Type` varchar(50) NOT NULL,
  `Checkin_Date/Time` varchar(50) NOT NULL,
  `CheckOut_Date/Time` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_occupiedrooms`
--

CREATE TABLE `tbl_occupiedrooms` (
  `Room_ID` varchar(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `Person_No` int(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Rate_Per_Hour` varchar(50) NOT NULL,
  `Rate_Per_Day` varchar(50) NOT NULL,
  `Extra_Person_PH` int(50) NOT NULL,
  `Vehicle_Info` varchar(50) NOT NULL,
  `Checkin` varchar(50) NOT NULL,
  `Checkout` varchar(50) NOT NULL,
  `orHour` varchar(50) NOT NULL,
  `Total_Amount` varchar(50) NOT NULL,
  `uid` int(78) NOT NULL,
  `extra_person` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_products`
--

CREATE TABLE `tbl_products` (
  `Prdouct_ID` int(200) NOT NULL,
  `Product_Name` int(50) NOT NULL,
  `Product_Prize` int(50) NOT NULL,
  `Product_Category` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reservation`
--

CREATE TABLE `tbl_reservation` (
  `Customer_ID` int(50) NOT NULL,
  `Room_ID` varchar(50) NOT NULL,
  `Customer_Name` varchar(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `No_Person` int(50) NOT NULL,
  `Booking_Date` varchar(50) NOT NULL,
  `Checkin_Date` varchar(50) NOT NULL,
  `Checkout_Date` varchar(50) NOT NULL,
  `Total_Amount` varchar(50) NOT NULL,
  `Down_Payment` varchar(50) DEFAULT NULL,
  `Payment_Type` varchar(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Rate_Per_Hour` varchar(50) NOT NULL,
  `Rate_Per_Day` varchar(50) NOT NULL,
  `Rate_Per_Extra_PH` varchar(50) NOT NULL,
  `Checkin_Time` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_reservation`
--

INSERT INTO `tbl_reservation` (`Customer_ID`, `Room_ID`, `Customer_Name`, `Room_Type`, `Room_Name`, `No_Person`, `Booking_Date`, `Checkin_Date`, `Checkout_Date`, `Total_Amount`, `Down_Payment`, `Payment_Type`, `Description`, `Rate_Per_Hour`, `Rate_Per_Day`, `Rate_Per_Extra_PH`, `Checkin_Time`) VALUES
(1, '826337998792', 'Antonette', 'Deluxe 111', 'Deluxe 111', 5, 'Thursday, 5 October 2017', 'Saturday, 7 October 2017', 'Friday, 13 October 2017', '31489', '15744', 'Half Paid', 'Air conditioned; Hot Tub; Free Dinner; 2 King-size and 1 Queen-size bed. Installed cabled TV with Stereo.\ngood for 3 person;\nmaximum of 5 persons;\nper hour= 399;\nper day= 4999;\nextra-person=299;', '399', '4999', '299', '9:00:28 AM');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reservationhistory`
--

CREATE TABLE `tbl_reservationhistory` (
  `Customer_ID` int(50) NOT NULL,
  `Room_ID` int(50) NOT NULL,
  `Customer_Name` varchar(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `No_Person` int(50) NOT NULL,
  `Booking_Date` varchar(50) NOT NULL,
  `Checkin_Date` varchar(50) NOT NULL,
  `Checkout_Date` varchar(50) NOT NULL,
  `Total_Amount` varchar(50) NOT NULL,
  `Down_Payment` varchar(50) DEFAULT NULL,
  `Payment_Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_reservationhistory`
--

INSERT INTO `tbl_reservationhistory` (`Customer_ID`, `Room_ID`, `Customer_Name`, `Room_Type`, `Room_Name`, `No_Person`, `Booking_Date`, `Checkin_Date`, `Checkout_Date`, `Total_Amount`, `Down_Payment`, `Payment_Type`) VALUES
(1, 0, 'Johny English', 'Triple', '104', 3, 'Saturday, September 23, 2017', 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', '?4000 ', '?1000 ', ''),
(2, 0, 'Bruce Wayne', 'Twin', '104', 2, 'Saturday, September 23, 2017', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '?9000 ', '?1500 ', 'Half Paid'),
(3, 0, 'Sheldon Cooper', 'Triple', '104', 4, 'Saturday, September 23, 2017', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '?4000 ', '?1000 ', 'Fully Paid'),
(4, 0, 'Diane jane', 'Single', '105', 2, 'Saturday, September 23, 2017', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '?2000 ', '?1000 ', 'Half Paid'),
(5, 0, 'Lopez Reed', 'Triple', '103', 2, 'Saturday, September 23, 2017', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '?6000 ', '?1500 ', 'Fully Paid'),
(6, 0, 'Glenn Mathew Garma', 'Triple', '105', 2, 'Saturday, September 23, 2017', 'Sunday, September 24, 2017', 'Wednesday, September 27, 2017', '?6000 ', '?1500 ', 'Fully Paid'),
(7, 0, 'Bruce  Wayne', 'Single', '103', 2, 'Saturday, September 23, 2017', 'Sunday, September 24, 2017', 'Wednesday, September 27, 2017', '?3000 ', '?1500 ', 'Fully Paid'),
(8, 0, 'Jack Collins', 'Triple', '103', 4, 'Saturday, September 23, 2017', 'Monday, September 25, 2017', 'Thursday, September 28, 2017', '?6000 ', '?1500 ', 'Fully Paid'),
(9, 0, 'Sheldon Cooper', 'Family', '101', 2, 'Monday, September 25, 2017', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '?8997 ', '?4498 ', 'Fully Paid'),
(10, 0, 'Sheldon Cooper', 'Family', '101', 5, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '?8997 ', '?4498 ', 'Fully Paid'),
(11, 0, 'Bruce Wayne', 'Family', '101', 2, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Thursday, September 28, 2017', '?2999 ', '?1499 ', 'Half Paid'),
(12, 0, 'Batman', 'Family', '103', 2, 'Monday, September 25, 2017', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '?5998 ', '?2999 ', 'Fully Paid'),
(13, 0, 'batgirl', 'Family', '103', 3, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Friday, September 29, 2017', '?5998 ', '?2999 ', 'Fully Paid'),
(14, 0, 'Garma', 'Standard', '101', 1, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Friday, September 29, 2017', '', '', ''),
(15, 0, 'jjjjjj', 'Family', '103', 0, 'Monday, September 25, 2017', 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', '', '', ''),
(16, 0, 'wdxas', 'Standard', '101', 2, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '', '', ''),
(17, 0, 'dfdfdf', 'Standard', '101', 3, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Friday, September 29, 2017', '', '', ''),
(18, 0, 'gfffg', 'Family', '103', 0, 'Monday, September 25, 2017', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', ''),
(19, 0, 'ituyyhi', 'Standard', '101', 0, 'Monday, September 25, 2017', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', ''),
(20, 0, 'lllllllllll', 'Standard', '101', 0, 'Monday, September 25, 2017', 'Monday, September 25, 2017', 'Monday, September 25, 2017', '', '', ''),
(21, 0, 'glenn', 'Standard', '101', 2, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '', '', ''),
(22, 0, 'Sheldon Cooper', 'Family', '103', 0, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '?8997 ', '?4498 ', 'Half Paid'),
(23, 0, 'Jham Gumaro', 'Family', '102', 1, 'Monday, September 25, 2017', 'Wednesday, September 27, 2017', 'Saturday, September 30, 2017', '?8997 ', '?4498 ', 'Half Paid'),
(24, 0, 'Dogman', 'Family', '102', 3, 'Monday, September 25, 2017', 'Tuesday, September 26, 2017', 'Friday, September 29, 2017', '?8997 ', '?4498 ', 'Fully Paid'),
(25, 0, 'Glenn Mathew Garma', 'Deluxe', '103', 0, 'Monday, September 25, 2017', 'Wednesday, September 20, 2017', 'Friday, October 6, 2017', '', '', ''),
(26, 0, 'asopusa', 'Family', '103', 0, 'Monday, September 25, 2017', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '?5998 ', '?2999 ', 'Half Paid'),
(27, 0, 'Angel', 'Family', '102', 3, 'Monday, September 25, 2017', 'Thursday, September 28, 2017', 'Tuesday, October 3, 2017', '?14995 ', '?7497 ', 'Fully Paid'),
(28, 0, 'Glenn Mathew Garma', 'Family', '102', 5, 'Tuesday, September 26, 2017', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '?5998 ', '?2999 ', 'Fully Paid'),
(29, 0, 'Mary Grace Mauricio', 'Family', '102', 5, 'Wednesday, September 27, 2017', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '?5998 ', '?2999 ', 'Half Paid'),
(30, 0, 'Hanah', 'Family', '102', 0, 'Wednesday, September 27, 2017', 'Friday, September 29, 2017', 'Saturday, September 30, 2017', '?2999 ', '?1499 ', 'Fully Paid'),
(31, 0, 'Angelica Angeles', 'Deluxe', '103', 2, 'Thursday, September 28, 2017', 'Friday, September 29, 2017', 'Monday, October 2, 2017', '?11997 ', '?5998 ', 'Half Paid'),
(32, 0, 'Glenn Mathew Garma', 'Standard', '101', 0, 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', 'Wednesday, October 4, 2017', '?3996 ', '?1998 ', 'Fully Paid'),
(33, 0, 'Mathew Garma', 'Deluxe', '103', 4, 'Thursday, September 28, 2017', 'Sunday, October 1, 2017', 'Saturday, October 7, 2017', '?31190 ', '?15595 ', 'Fully Paid'),
(34, 0, 'John Doe', 'Standard', '101', 0, 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', 'Tuesday, October 3, 2017', '?2997 ', '?1498 ', 'Fully Paid'),
(35, 0, 'Michelle', 'Family', '102', 5, '', 'Thursday, September 28, 2017', 'Saturday, September 30, 2017', '?3900 ', '?1950 ', 'Fully Paid'),
(36, 0, 'Garcia Jay', 'Standard', '101', 3, '', 'Sunday, October 1, 2017', 'Friday, October 13, 2017', '?11286 ', '?5643 ', 'Half Paid'),
(37, 0, 'Nicole', 'Family', '102', 2, '', 'Friday, October 6, 2017', 'Tuesday, October 10, 2017', '?9100 ', '?4550 ', 'Fully Paid'),
(38, 0, 'Aiza', 'Standard', '101', 2, '', 'Wednesday, October 18, 2017', 'Friday, October 27, 2017', '?9189 ', '?4594 ', 'Half Paid'),
(39, 0, 'Guillian', 'Family', '102', 5, 'Monday, October 2, 2017', 'Saturday, October 7, 2017', 'Wednesday, October 11, 2017', '?12600 ', '0', 'Fully Paid'),
(40, 0, 'alllen', 'Standard', '101', 4, 'Monday, October 2, 2017', 'Thursday, October 5, 2017', 'Tuesday, October 10, 2017', '?5391 ', '?2695 ', 'Half Paid'),
(41, 0, 'George Martin', 'Standard', '101', 2, 'Monday, October 2, 2017', 'Wednesday, October 11, 2017', 'Friday, October 13, 2017', '?2196 ', '0', 'Fully Paid'),
(42, 0, 'Ariza', 'Double', '104', 1, 'Monday, October 2, 2017', 'Monday, October 2, 2017', 'Wednesday, October 4, 2017', '?2198 ', '?1099 ', 'Half Paid'),
(43, 0, 'glenn', 'Deluxe', '103', 0, 'Wednesday, 4 October 2017', 'Sunday, 8 October 2017', 'Friday, 13 October 2017', '?24995 ', '0', 'Fully Paid'),
(44, 0, 'Antonette', 'Deluxe 111', 'Deluxe 111', 5, 'Thursday, 5 October 2017', 'Saturday, 7 October 2017', 'Friday, 13 October 2017', '31489', '15744', 'Half Paid');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rooms`
--

CREATE TABLE `tbl_rooms` (
  `Room_ID` varchar(50) NOT NULL,
  `Room_Type` varchar(50) NOT NULL,
  `Room_Name` varchar(50) NOT NULL,
  `Person_No` int(50) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Rate_Per_Hour` varchar(50) NOT NULL,
  `Rate_Per_Day` varchar(50) NOT NULL,
  `Extra_Person_PH` int(50) NOT NULL,
  `uid` int(78) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_rooms`
--

INSERT INTO `tbl_rooms` (`Room_ID`, `Room_Type`, `Room_Name`, `Person_No`, `Description`, `Rate_Per_Hour`, `Rate_Per_Day`, `Extra_Person_PH`, `uid`) VALUES
('6737687394932', 'Standard 101', '', 2, 'Air conditioned room; installed TV; 1 Queen-size bed. minimum of 2 person.maximum of 4 person. \r\nper hour= 99. per day=999. \r\nextra-person=99. ', '99', '999', 99, 69),
('826337998792', 'Deluxe 111', '', 0, 'Air conditioned; Hot Tub; Free Dinner; 2 King-size and 1 Queen-size bed. Installed cabled TV with Stereo.\ngood for 3 person;\nmaximum of 5 persons;\nper hour= 399;\nper day= 4999;\nextra-person=299;', '399', '4999', 299, 70),
('749343840924', 'Standard 102', '', 2, 'Air conditioned room; installed TV; 1 Queen-size bed. minimum of 2 person.maximum of 4 person. \r\nper hour= 99. per day=999. \r\nextra-person=99. ', '99', '999', 99, 71),
('578573848534859', 'Double 106', '', 3, 'Air-conditioned; Free lunch; Installed cabled TV.  2 bedrooms; \r\ngood for 4 persons.\r\nmaximum of 6 persons;\r\nper  hour= 300;\r\nper day= 1999;\r\nextra-person=199', '300', '1999', 199, 73),
('85385093534055', 'Family 109', '', 5, '1 queen-size bed & 2 extra-long bed; Airconditioned; installed cabled tv; free lunch good for 5 person. maximum of 7 person.\r\nper hour= 300;\r\nper day= 2900;\r\nextra-person=200;', '300', '2900', 200, 74),
('242742492948', 'Deluxe 112', '', 3, 'Air conditioned; Hot Tub; Free Dinner; 2 King-size and 1 Queen-size bed. Installed cabled TV with Stereo.\r\ngood for 3 person;\r\nmaximum of 5 persons;\r\nper hour= 399;\r\nper day= 4999;\r\nextra-person=299;', '399', '4999', 299, 75),
('76473940243', 'Family 108', 'Family 108', 5, '1 queen-size bed & 2 extra-long bed; Airconditioned; installed cabled tv; free lunch good for 5 person. maximum of 7 person.\r\nper hour= 300;\r\nper day= 2900;\r\nextra-person=200;', '300', '2900', 200, 76),
('87783240990950', 'Double 105', 'Double 105', 1, 'Air-conditioned; Free lunch; Installed cabled TV.  2 bedrooms; \r\ngood for 4 persons.\r\nmaximum of 6 persons;\r\nper  hour= 300;\r\nper day= 1999;\r\nextra-person=199', '300', '1999', 199, 77);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `Admin_ID` int(11) NOT NULL,
  `Admin_Username` varchar(50) NOT NULL,
  `Admin_Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`Admin_ID`, `Admin_Username`, `Admin_Password`) VALUES
(1, 'Glenn ', 'admin'),
(2, 'Angelica', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_adminusers`
--
ALTER TABLE `tbl_adminusers`
  ADD PRIMARY KEY (`Admin_ID`);

--
-- Indexes for table `tbl_allcheckins`
--
ALTER TABLE `tbl_allcheckins`
  ADD PRIMARY KEY (`Customer_ID`);

--
-- Indexes for table `tbl_availablerooms`
--
ALTER TABLE `tbl_availablerooms`
  ADD PRIMARY KEY (`uid`);

--
-- Indexes for table `tbl_occupiedrooms`
--
ALTER TABLE `tbl_occupiedrooms`
  ADD PRIMARY KEY (`uid`);

--
-- Indexes for table `tbl_products`
--
ALTER TABLE `tbl_products`
  ADD PRIMARY KEY (`Prdouct_ID`);

--
-- Indexes for table `tbl_reservation`
--
ALTER TABLE `tbl_reservation`
  ADD PRIMARY KEY (`Customer_ID`);

--
-- Indexes for table `tbl_reservationhistory`
--
ALTER TABLE `tbl_reservationhistory`
  ADD PRIMARY KEY (`Customer_ID`),
  ADD UNIQUE KEY `Customer_ID` (`Customer_ID`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`Admin_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_adminusers`
--
ALTER TABLE `tbl_adminusers`
  MODIFY `Admin_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_allcheckins`
--
ALTER TABLE `tbl_allcheckins`
  MODIFY `Customer_ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;
--
-- AUTO_INCREMENT for table `tbl_availablerooms`
--
ALTER TABLE `tbl_availablerooms`
  MODIFY `uid` int(78) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;
--
-- AUTO_INCREMENT for table `tbl_occupiedrooms`
--
ALTER TABLE `tbl_occupiedrooms`
  MODIFY `uid` int(78) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `Prdouct_ID` int(200) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_reservation`
--
ALTER TABLE `tbl_reservation`
  MODIFY `Customer_ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_reservationhistory`
--
ALTER TABLE `tbl_reservationhistory`
  MODIFY `Customer_ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `Admin_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
