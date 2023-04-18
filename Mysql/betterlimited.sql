-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2023 at 08:27 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `betterlimited`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `CompanyName` varchar(30) NOT NULL,
  `ContactPersion` varchar(50) NOT NULL,
  `Phone1` varchar(13) NOT NULL,
  `Phone2` varchar(13) DEFAULT NULL,
  `AddressLine1` varchar(50) NOT NULL,
  `AddressLine2` varchar(50) DEFAULT NULL,
  `AddressLine3` varchar(50) DEFAULT NULL,
  `Region` varchar(25) DEFAULT NULL,
  `Districts` int(11) DEFAULT NULL,
  `EmailAddress` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerID`, `FirstName`, `LastName`, `CompanyName`, `ContactPersion`, `Phone1`, `Phone2`, `AddressLine1`, `AddressLine2`, `AddressLine3`, `Region`, `Districts`, `EmailAddress`) VALUES
(10024, '23', '/32323', '/232', '/32', '/32', '/32', '/3232', '/3232', '/3232', NULL, NULL, '/2'),
(10025, 'HR', 'HT', 'HT', 'HT', '+85245621262', NULL, 'XAS', 'XADA', 'AWEWA', NULL, NULL, 'billy@gmail.com'),
(10026, 'dsada', 'adsads', 'dsada', 'dadad', '+85224245646', NULL, 'sadada', 'dsada', 'sadsadsadsa', NULL, NULL, 'billy@mgail.com'),
(10027, 'adsadsa', 'sdadsadsa', 'sdadsa', 'sadadsadsa', '+85237574944', NULL, 'dadada', 'dsadad', 'adsadsad', NULL, NULL, 'billy_0310@hornamail.com'),
(10028, 'qedwe', 'eweae', 'ewaewa', 'waewaewa', '+85223232354', NULL, 'adasda', 'dsada', 'dasdada', NULL, NULL, 'aaa@gmail.com'),
(10031, '/asdsa', '/sadad', '/asdsa', '/dsasdsa', '/35436553', '/3543543', '/', '/', '/', NULL, NULL, '/'),
(10032, '/asdad', '/adad', '/dsad', '/dsad', '/asda', '/', '/adsa', '/dsad', '/dsad', NULL, NULL, '/dsadsa'),
(10033, 'HAha', 'Wong', '/', 'Wong Hin', '+85248545677', '/', '26', 'r3', '345s ROad', NULL, NULL, 'hah@gmail.com'),
(10034, 'sada', 'dsad', '/', '/', '/', '/', '/', '/', '/', NULL, NULL, '/'),
(10035, 'Lai wa', 'Yuen', '/', 'Yuen Lai wa', '+85294587455', '/', '/', '/', '/', NULL, NULL, '/'),
(10036, 'Tat Shing Billy', 'Yuen', 'Billy\'s Company', 'Yuen Tat Shing Billy', '+852584034321', '/', 'Room 7,6/F', 'Sheung Shui Centre', '3, Chi Cheong Road', NULL, NULL, 'billy_0310@hotmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `defectitem`
--

CREATE TABLE `defectitem` (
  `defectItemID` int(11) NOT NULL,
  `SaleOrderID` int(11) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Reason` varchar(100) DEFAULT NULL,
  `HandleMethod` varchar(40) DEFAULT NULL,
  `RefundAmount` double DEFAULT NULL,
  `SupplierReply` varchar(100) DEFAULT NULL,
  `Handle` varchar(60) DEFAULT NULL,
  `dateofreturn` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `defectitem`
--

INSERT INTO `defectitem` (`defectItemID`, `SaleOrderID`, `ProductID`, `Quantity`, `Reason`, `HandleMethod`, `RefundAmount`, `SupplierReply`, `Handle`, `dateofreturn`) VALUES
(18, 62, 10, 1, 'the item is broken', 'Refund', 7000, 'the supplier will be receive', 'Handled', '2022-07-04');

-- --------------------------------------------------------

--
-- Table structure for table `deliveryorder`
--

CREATE TABLE `deliveryorder` (
  `DeliveryOrderID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `DWorkerID` int(11) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `timeofDelivery` time DEFAULT NULL,
  `SessionID` int(11) DEFAULT NULL,
  `CustomerID` int(11) DEFAULT NULL,
  `D_Status` varchar(30) DEFAULT NULL,
  `DeliveryProductID_1` int(3) NOT NULL,
  `DeliveryProductID_2` int(3) DEFAULT NULL,
  `DeliveryProductID_3` int(3) DEFAULT NULL,
  `DeliveryProductID_4` int(3) DEFAULT NULL,
  `DeliveryProductID_5` int(3) DEFAULT NULL,
  `DeliveryProductID_6` int(3) DEFAULT NULL,
  `DeliveryProductID_7` int(3) DEFAULT NULL,
  `DeliveryProductID_8` int(3) DEFAULT NULL,
  `DeliveryProductID_9` int(3) DEFAULT NULL,
  `DeliveryProductID_10` int(3) DEFAULT NULL,
  `DeliveryProductID_1qty` int(11) NOT NULL,
  `DeliveryProductID_2qty` int(11) NOT NULL,
  `DeliveryProductID_3qty` int(11) NOT NULL,
  `DeliveryProductID_4qty` int(11) NOT NULL,
  `DeliveryProductID_5qty` int(11) NOT NULL,
  `DeliveryProductID_6qty` int(11) NOT NULL,
  `DeliveryProductID_7qty` int(11) NOT NULL,
  `DeliveryProductID_8qty` int(11) NOT NULL,
  `DeliveryProductID_9qty` int(11) NOT NULL,
  `DeliveryProductID_10qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deliveryorder`
--

INSERT INTO `deliveryorder` (`DeliveryOrderID`, `OrderID`, `DWorkerID`, `DeliveryDate`, `timeofDelivery`, `SessionID`, `CustomerID`, `D_Status`, `DeliveryProductID_1`, `DeliveryProductID_2`, `DeliveryProductID_3`, `DeliveryProductID_4`, `DeliveryProductID_5`, `DeliveryProductID_6`, `DeliveryProductID_7`, `DeliveryProductID_8`, `DeliveryProductID_9`, `DeliveryProductID_10`, `DeliveryProductID_1qty`, `DeliveryProductID_2qty`, `DeliveryProductID_3qty`, `DeliveryProductID_4qty`, `DeliveryProductID_5qty`, `DeliveryProductID_6qty`, `DeliveryProductID_7qty`, `DeliveryProductID_8qty`, `DeliveryProductID_9qty`, `DeliveryProductID_10qty`) VALUES
(94, 48, 10, '2022-06-28', '10:00:00', 1, NULL, 'Not Delivered', 29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(95, 54, 10, '2022-07-04', '13:00:00', 2, NULL, 'Delivery Successful!', 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(96, 53, 10, '2022-07-01', '11:00:00', 1, NULL, 'Not Delivered', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 2, 1, 2, 0, 0, 0, 0, 0, 0, 0),
(97, 50, 10, '2022-07-09', '10:00:00', 1, NULL, 'Not Delivered', 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(98, 51, 10, '2022-07-16', '14:00:00', 2, NULL, 'Not Delivered', 13, 28, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(99, 55, 10, '2022-07-01', '15:00:00', 2, NULL, 'Not Delivered', 10, 13, 31, 28, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0),
(100, 56, 10, '2022-07-04', '11:00:00', 1, NULL, 'Delivery Successful!', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0),
(101, 52, 10, '2022-07-05', '09:00:00', 1, NULL, 'Not Delivered', 13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(102, 57, 10, '2022-07-09', '09:00:00', 1, NULL, 'Not Delivered', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0),
(103, 59, 10, '2022-07-05', '10:00:00', 1, NULL, 'Delivered', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0),
(104, 62, 10, '2022-07-06', '13:00:00', 2, NULL, 'Delivery Successful!', 10, 13, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `DepartmentID` int(2) NOT NULL,
  `DepartmentName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`DepartmentID`, `DepartmentName`) VALUES
(0, 'Inavailable'),
(1, 'Testing'),
(2, 'Admin'),
(3, 'Shop Manager'),
(4, 'Shop Sale'),
(5, 'Purchasing Department Manager'),
(6, 'Purchasing Department Clerk'),
(7, 'Inventory Department Manager'),
(8, 'Inventory Department Clerk'),
(9, 'Delivery Manager'),
(10, 'Accounting Department Clerk'),
(11, 'Delivery Worker'),
(12, 'Installation Worker'),
(15, 'Installation Manager');

-- --------------------------------------------------------

--
-- Table structure for table `installationorder`
--

CREATE TABLE `installationorder` (
  `InstallationOrderID` int(11) NOT NULL,
  `SaleOrderID` int(11) DEFAULT NULL,
  `I_Worker` int(11) DEFAULT NULL,
  `SessionID` int(11) DEFAULT NULL,
  `I_status` varchar(30) DEFAULT NULL,
  `InstallationTime` time NOT NULL,
  `InstallationDate` date DEFAULT NULL,
  `InstallProduct1` int(11) NOT NULL,
  `InstallProduct2` int(11) NOT NULL,
  `InstallProduct3` int(11) NOT NULL,
  `InstallProduct4` int(11) NOT NULL,
  `InstallProduct5` int(11) NOT NULL,
  `InstallProduct6` int(11) NOT NULL,
  `InstallProduct7` int(11) NOT NULL,
  `InstallProduct8` int(11) NOT NULL,
  `InstallProduct9` int(11) NOT NULL,
  `InstallProduct10` int(11) NOT NULL,
  `InstallProduct1_qty` int(11) NOT NULL,
  `InstallProduct2_qty` int(11) NOT NULL,
  `InstallProduct3_qty` int(11) NOT NULL,
  `InstallProduct4_qty` int(11) NOT NULL,
  `InstallProduct5_qty` int(11) NOT NULL,
  `InstallProduct6_qty` int(11) NOT NULL,
  `InstallProduct7_qty` int(11) NOT NULL,
  `InstallProduct8_qty` int(11) NOT NULL,
  `InstallProduct9_qty` int(11) NOT NULL,
  `InstallProduct10_qty` int(11) NOT NULL,
  `InstallationStaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `installationorder`
--

INSERT INTO `installationorder` (`InstallationOrderID`, `SaleOrderID`, `I_Worker`, `SessionID`, `I_status`, `InstallationTime`, `InstallationDate`, `InstallProduct1`, `InstallProduct2`, `InstallProduct3`, `InstallProduct4`, `InstallProduct5`, `InstallProduct6`, `InstallProduct7`, `InstallProduct8`, `InstallProduct9`, `InstallProduct10`, `InstallProduct1_qty`, `InstallProduct2_qty`, `InstallProduct3_qty`, `InstallProduct4_qty`, `InstallProduct5_qty`, `InstallProduct6_qty`, `InstallProduct7_qty`, `InstallProduct8_qty`, `InstallProduct9_qty`, `InstallProduct10_qty`, `InstallationStaffID`) VALUES
(40, 35, 64, 1, 'Not Installing', '12:00:00', '2022-06-28', 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(41, 46, 64, 1, 'Not Installing', '11:00:00', '2022-06-27', 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(42, 47, 64, 1, 'Departure Installation', '10:00:00', '2022-06-30', 31, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(43, 48, 11, 1, 'Not Installing', '12:00:00', '2022-06-28', 29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(44, 54, 62, 1, 'Not Installing', '10:00:00', '2022-07-08', 24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(46, 50, 62, 1, 'Not Installing', '11:00:00', '2022-07-01', 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(47, 51, 62, 2, 'Installation Successful!', '16:00:00', '2022-07-15', 13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(48, 55, 62, 1, 'Not Installing', '12:00:00', '2022-07-08', 10, 13, 31, 28, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0),
(49, 56, 62, 1, 'Installation Successful!', '11:00:00', '2022-07-08', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(50, 52, 62, 1, 'Not Installing', '11:00:00', '2022-07-05', 13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(51, 57, 62, 1, 'Not Installing', '11:00:00', '2022-07-09', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(52, 59, 62, 2, 'Not Installing', '13:00:00', '2022-07-05', 10, 13, 31, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0),
(53, 62, 0, 1, 'Not Installing', '09:00:00', '2022-07-07', 13, 10, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `Reorder` int(11) NOT NULL,
  `RequireInstall` int(1) DEFAULT NULL,
  `SerialNum` varchar(100) DEFAULT NULL,
  `ProductName` varchar(100) NOT NULL,
  `Available` int(1) NOT NULL DEFAULT 1,
  `TypeID` int(11) NOT NULL,
  `Price` int(5) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `StockLevel` int(11) DEFAULT NULL,
  `Low_Standard` int(4) NOT NULL,
  `KBStore` int(3) NOT NULL,
  `KBdisplay` int(3) DEFAULT NULL,
  `TWStore` int(3) NOT NULL,
  `TWdisplay` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ProductID`, `Reorder`, `RequireInstall`, `SerialNum`, `ProductName`, `Available`, `TypeID`, `Price`, `SupplierID`, `StockLevel`, `Low_Standard`, `KBStore`, `KBdisplay`, `TWStore`, `TWdisplay`) VALUES
(0, 0, NULL, NULL, '', 1, 0, 0, 0, NULL, 0, 0, 0, 0, 0),
(10, 0, NULL, 'UA50BU8000JXZK', '50\" BU8000 Crystal UHD 4K', 1, 20, 7000, 1, 76, 21, 6, 1, 63, 1),
(13, 0, NULL, 'QA43Q60BAJXZK', '43\" Q60B QLED 4K', 1, 20, 6000, 1, 85, 0, 132, 1, 192, 1),
(14, 1, NULL, NULL, 'W41 Pro', 1, 3, 5500, 3, 112, 140, 50, 0, 50, 0),
(15, 2, NULL, NULL, 'MatePad 10.4 (2022)', 0, 4, 6600, 4, 109, 140, 50, 0, 50, 0),
(19, 1, NULL, '', 'G Pad 8.3', 1, 4, 3500, 3, 100, 100, 50, 0, 50, 0),
(20, 1, NULL, NULL, 'i7 9700K', 0, 16, 3000, 9, 5, 0, 0, 0, 0, 0),
(21, 1, NULL, NULL, 'DDR4 Ram', 0, 15, 3000, 1, -2, 140, -2, 0, -2, 0),
(22, 1, NULL, NULL, 'Sm5200', 1, 4, 3000, 1, 0, 0, 0, 0, 0, 0),
(23, 0, NULL, NULL, 'i5 3470', 1, 16, 1500, 9, 25, 10, 5, 0, 5, 0),
(24, 1, NULL, NULL, 'Hyper Quatcast', 0, 4, 1500, 7, 99, 20, -1, 0, 0, 0),
(25, 0, NULL, '', 'Samsung S20', 1, 3, 8000, 0, 25, 10, 0, 0, 0, 0),
(28, 0, NULL, 'RB34T675FB1/SH', '2-Door Refrigerator 340L Black', 1, 21, 6000, 1, 23, 10, 0, NULL, -1, NULL),
(29, 0, NULL, '', 'PlayStation 4', 1, 22, 3200, 2, 17, 10, 1, NULL, 6, NULL),
(30, 0, NULL, 'OLED88Z2PCA', '83\'\' LG OLED Z2', 1, 20, 35000, 3, 21, 5, 0, NULL, 0, NULL),
(31, 1, NULL, 'RB30N4180 284L', '284L 2 door Refrigerator', 1, 21, 4590, 1, 3, 10, -1, NULL, 17, NULL),
(32, 0, NULL, 'QA43Q60AAJXZK', '43\" Q60A QLED 4K Smart TV (2021)', 1, 20, 6000, 1, 100, 10, 0, NULL, 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `purchaseitem`
--

CREATE TABLE `purchaseitem` (
  `PurchaseOrderID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quanity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `Status` varchar(20) NOT NULL,
  `dateofcreate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `purchaseitem`
--

INSERT INTO `purchaseitem` (`PurchaseOrderID`, `ProductID`, `Quanity`, `Price`, `Status`, `dateofcreate`) VALUES
(21, 14, 4, 4000, 'Processed', '2022-07-02'),
(24, 14, 10, 60000, 'Approved', '2022-07-04'),
(21, 15, 3, 3000, 'Processed', '2022-07-02'),
(22, 23, 10, 30000, 'Processed', '2022-07-02'),
(22, 25, 10, 30000, 'Processed', '2022-07-02'),
(22, 28, 10, 30000, 'Processed', '2022-07-02'),
(23, 30, 10, 20000, 'Processed', '2022-07-02');

-- --------------------------------------------------------

--
-- Table structure for table `purchasingorder`
--

CREATE TABLE `purchasingorder` (
  `purchasingorderID` int(11) NOT NULL,
  `PurchaseOrderCreateDate` date NOT NULL,
  `StaffID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `purchasingorder`
--

INSERT INTO `purchasingorder` (`purchasingorderID`, `PurchaseOrderCreateDate`, `StaffID`) VALUES
(15, '2022-06-23', 1),
(16, '2022-06-26', 1),
(17, '2022-07-02', 1),
(18, '2022-07-02', 1),
(21, '2022-07-02', 1),
(22, '2022-07-02', 1),
(23, '2022-07-02', 1),
(24, '2022-07-04', 1);

-- --------------------------------------------------------

--
-- Table structure for table `reorder`
--

CREATE TABLE `reorder` (
  `ReorderID` int(11) NOT NULL,
  `ReorderCreatedDate` date NOT NULL,
  `Approve` varchar(30) DEFAULT NULL,
  `Product1` int(3) NOT NULL,
  `Product2` int(3) DEFAULT NULL,
  `Product3` int(3) DEFAULT NULL,
  `Product4` int(3) DEFAULT NULL,
  `Product5` int(3) DEFAULT NULL,
  `Product6` int(3) DEFAULT NULL,
  `Product7` int(3) DEFAULT NULL,
  `Product8` int(3) DEFAULT NULL,
  `Product9` int(3) DEFAULT NULL,
  `Product10` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reorder`
--

INSERT INTO `reorder` (`ReorderID`, `ReorderCreatedDate`, `Approve`, `Product1`, `Product2`, `Product3`, `Product4`, `Product5`, `Product6`, `Product7`, `Product8`, `Product9`, `Product10`) VALUES
(23, '2022-06-10', 'Approve', 15, 30, 20, 0, 0, 0, 0, 0, 0, 0),
(25, '2022-06-26', 'Processed', 21, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(26, '2022-07-02', 'Processed', 14, 15, 21, 0, 0, 0, 0, 0, 0, 0),
(27, '2022-07-02', 'Processed', 23, 28, 25, 0, 0, 0, 0, 0, 0, 0),
(28, '2022-07-02', 'Processed', 30, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(30, '2022-07-04', 'Waiting Approve', 14, 15, 0, 0, 0, 0, 0, 0, 0, 0),
(31, '2022-07-04', 'Approve', 14, 15, 21, 0, 0, 0, 0, 0, 0, 0),
(32, '2022-07-04', 'Processed', 14, 15, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `saleorder`
--

CREATE TABLE `saleorder` (
  `orderID` int(11) NOT NULL,
  `Date_Of_Purchase` date NOT NULL,
  `orderType` varchar(30) NOT NULL,
  `DeliveryOrderID` int(11) DEFAULT NULL,
  `InstallationOrderID` int(11) DEFAULT NULL,
  `storeID` int(11) DEFAULT NULL,
  `staffID` int(11) DEFAULT NULL,
  `CustomerID` int(11) DEFAULT NULL,
  `TotalCharge` double NOT NULL,
  `Addition_Charge` double DEFAULT NULL,
  `DepositCharge` double DEFAULT NULL,
  `PayAmount` double DEFAULT NULL,
  `PayMethod` varchar(20) DEFAULT NULL,
  `Active` varchar(20) NOT NULL,
  `Status` varchar(30) DEFAULT NULL,
  `Product1_ID` int(11) DEFAULT NULL,
  `Product1_Qty` int(11) DEFAULT NULL,
  `Product2_ID` int(11) DEFAULT NULL,
  `Product2_Qty` int(11) DEFAULT NULL,
  `Product3_ID` int(11) DEFAULT NULL,
  `Product3_Qty` int(11) DEFAULT NULL,
  `Product4_ID` int(11) DEFAULT NULL,
  `Product4_Qty` int(11) DEFAULT NULL,
  `Product5_ID` int(11) DEFAULT NULL,
  `Product5_Qty` int(11) DEFAULT NULL,
  `Product6_ID` int(11) DEFAULT NULL,
  `Product6_Qty` int(11) DEFAULT NULL,
  `Product7_ID` int(11) DEFAULT NULL,
  `Product7_Qty` int(11) DEFAULT NULL,
  `Product8_ID` int(11) DEFAULT NULL,
  `Product8_Qty` int(11) DEFAULT NULL,
  `Product9_ID` int(11) DEFAULT NULL,
  `Product9_Qty` int(11) DEFAULT NULL,
  `Product10_ID` int(11) DEFAULT NULL,
  `Product10_Qty` int(11) DEFAULT NULL,
  `Product1_display` int(11) DEFAULT NULL,
  `Product2_display` int(11) DEFAULT NULL,
  `Product3_display` int(11) DEFAULT NULL,
  `Product4_display` int(11) DEFAULT NULL,
  `Product5_display` int(11) DEFAULT NULL,
  `Product6_display` int(11) DEFAULT NULL,
  `Product7_display` int(11) DEFAULT NULL,
  `Product8_display` int(11) DEFAULT NULL,
  `Product9_display` int(11) DEFAULT NULL,
  `Product10_display` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `saleorder`
--

INSERT INTO `saleorder` (`orderID`, `Date_Of_Purchase`, `orderType`, `DeliveryOrderID`, `InstallationOrderID`, `storeID`, `staffID`, `CustomerID`, `TotalCharge`, `Addition_Charge`, `DepositCharge`, `PayAmount`, `PayMethod`, `Active`, `Status`, `Product1_ID`, `Product1_Qty`, `Product2_ID`, `Product2_Qty`, `Product3_ID`, `Product3_Qty`, `Product4_ID`, `Product4_Qty`, `Product5_ID`, `Product5_Qty`, `Product6_ID`, `Product6_Qty`, `Product7_ID`, `Product7_Qty`, `Product8_ID`, `Product8_Qty`, `Product9_ID`, `Product9_Qty`, `Product10_ID`, `Product10_Qty`, `Product1_display`, `Product2_display`, `Product3_display`, `Product4_display`, `Product5_display`, `Product6_display`, `Product7_display`, `Product8_display`, `Product9_display`, `Product10_display`) VALUES
(46, '2022-06-25', 'Sale Order', 92, 41, 2, NULL, 10032, 12980, 0, 0, 12980, 'Cash', 'Active', '', 10, 1, 13, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(47, '2022-06-26', 'Sale Order', 93, 42, 2, NULL, 10029, 18550, 0, 0, 18550, 'Cash', 'Active', '', 31, 1, 10, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(48, '2022-06-26', 'Sale Order', 94, 43, 2, NULL, 10033, 6400, 0, 0, 6400, 'Cash', 'Active', '', 29, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(49, '2022-06-26', 'Sale Order', NULL, NULL, 1, 73, 10025, 17570, 0, 0, 17570, 'Cash', 'Active', '', 10, 1, 13, 1, 31, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(50, '2022-06-27', 'Deposit Order', 97, 46, 1, NULL, 10034, 13960, 0, 2792, 2792, 'Cash', 'Active', 'Noticed', 10, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(51, '2022-06-27', 'Sale Order', 98, 47, 2, NULL, 10035, 12000, 0, 0, 18980, 'Cash', 'Active', NULL, 10, 1, 13, 1, 28, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(52, '2022-06-29', 'New Item Order', 101, 50, 1, NULL, 10036, 12000, 12000, 0, 22180, 'Cash', 'Active', NULL, 10, 1, 29, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(53, '2022-06-30', 'New Item Order', 96, 0, 1, 73, 10036, 29140, 9180, 0, 35140, 'Cash', 'Active', NULL, 10, 2, 13, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(54, '2022-06-30', 'Deposit Payment', 95, 44, 1, 73, 10036, 1500, 0, 0, 1500, 'Cash', 'Active', NULL, 24, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(55, '2022-07-01', 'Sale Order', 99, 48, 2, 3, 10030, 23570, 0, 0, 23570, 'Cash', 'Active', NULL, 10, 1, 13, 1, 28, 1, 31, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(56, '2022-07-02', 'Sale Order', 100, 49, 2, 2, 10029, 21000, 0, 0, 38570, 'Cash', 'Active', NULL, 10, 1, 13, 1, 31, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(57, '2022-07-04', 'New Item Order', 102, 51, 1, 69, 10036, 6000, 6000, 0, 23590, 'Cash', 'Active', NULL, 0, 0, 13, 1, 31, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(58, '2022-07-04', 'Deposit Payment', NULL, NULL, 1, 69, 10036, 0, 0, 1800, 9000, 'Cash', 'Active', NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(59, '2022-07-04', 'New Item Order', 103, 52, 2, 2, 10036, 17590, 3200, 0, 20790, 'Cash', 'Active', NULL, 10, 1, 13, 1, 31, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(62, '2022-07-04', 'Sale Order', 104, 53, 1, 69, 10036, 13000, 0, 0, 20000, 'Cash', 'InActive', NULL, 0, 0, 13, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(63, '2022-07-04', 'Deposit Payment', NULL, NULL, 1, 69, 10036, 6000, 0, 1200, 6000, 'Cash', 'Active', 'Noticed', 21, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(64, '2022-07-04', 'Sale Order', NULL, NULL, 1, 73, 10036, 26000, 0, 0, 26000, 'Cash', 'Active', NULL, 10, 2, 13, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(65, '2022-07-04', 'New Item Order', NULL, NULL, 1, 73, 10036, 33000, 3200, 0, 32400, 'Cash', 'Active', NULL, 10, 2, 13, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `dateofservice` date NOT NULL,
  `SessionID` int(11) NOT NULL,
  `D_staffID` int(11) NOT NULL,
  `D_staff2ID` int(11) NOT NULL,
  `I_staffID` int(11) NOT NULL,
  `I_staffID2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`dateofservice`, `SessionID`, `D_staffID`, `D_staff2ID`, `I_staffID`, `I_staffID2`) VALUES
('2022-06-04', 1, 0, 0, 0, 0),
('2022-06-04', 2, 0, 0, 0, 0),
('2022-06-04', 3, 0, 0, 0, 0),
('2022-06-05', 1, 0, 0, 0, 0),
('2022-06-05', 2, 0, 0, 0, 0),
('2022-06-05', 3, 0, 0, 0, 0),
('2022-06-06', 2, 1, 0, 0, 0),
('2022-06-06', 3, 0, 0, 0, 0),
('2022-06-07', 1, 0, 0, 0, 0),
('2022-06-07', 2, 0, 0, 0, 0),
('2022-06-07', 3, 0, 0, 0, 0),
('2022-06-08', 1, 0, 0, 0, 0),
('2022-06-08', 2, 0, 0, 0, 0),
('2022-06-08', 3, 0, 0, 0, 0),
('2022-06-11', 2, 1, 0, 0, 0),
('2022-06-11', 3, 0, 0, 0, 0),
('2022-06-12', 1, 0, 0, 0, 0),
('2022-06-12', 2, 0, 0, 0, 0),
('2022-06-12', 3, 0, 0, 0, 0),
('2022-06-13', 2, 0, 0, 0, 0),
('2022-06-13', 3, 0, 0, 0, 0),
('2022-06-14', 1, 0, 0, 0, 0),
('2022-06-14', 2, 0, 0, 0, 0),
('2022-06-14', 3, 0, 0, 0, 0),
('2022-06-15', 1, 0, 0, 0, 0),
('2022-06-15', 2, 0, 0, 0, 0),
('2022-06-15', 3, 0, 0, 0, 0),
('2022-06-16', 1, 1, 0, 0, 0),
('2022-06-16', 2, 0, 0, 0, 0),
('2022-06-16', 3, 0, 0, 0, 0),
('2022-06-17', 1, 0, 0, 0, 0),
('2022-06-17', 2, 0, 0, 0, 0),
('2022-06-17', 3, 0, 0, 0, 0),
('2022-06-18', 1, 0, 0, 0, 0),
('2022-06-18', 2, 0, 0, 0, 0),
('2022-06-18', 3, 0, 0, 0, 0),
('2022-06-19', 1, 0, 0, 0, 0),
('2022-06-19', 2, 0, 0, 0, 0),
('2022-06-19', 3, 0, 0, 0, 0),
('2022-06-20', 1, 0, 0, 0, 0),
('2022-06-20', 2, 0, 0, 0, 0),
('2022-06-20', 3, 0, 0, 0, 0),
('2022-06-21', 1, 0, 0, 0, 0),
('2022-06-21', 2, 0, 0, 0, 0),
('2022-06-21', 3, 0, 0, 0, 0),
('2022-06-22', 1, 0, 0, 0, 0),
('2022-06-22', 2, 0, 0, 0, 0),
('2022-06-22', 3, 0, 0, 0, 0),
('2022-06-23', 1, 0, 0, 0, 0),
('2022-06-23', 2, 0, 0, 0, 0),
('2022-06-23', 3, 0, 0, 0, 0),
('2022-06-24', 1, 0, 0, 0, 0),
('2022-06-24', 2, 0, 0, 0, 0),
('2022-06-24', 3, 0, 0, 0, 0),
('2022-06-25', 1, 0, 0, 11, 0),
('2022-06-25', 2, 0, 0, 11, 0),
('2022-06-25', 3, 0, 0, 11, 0),
('2022-06-26', 1, 0, 0, 0, 0),
('2022-06-26', 2, 0, 0, 0, 0),
('2022-06-26', 3, 0, 0, 0, 0),
('2022-06-27', 1, 10, 0, 64, 0),
('2022-06-27', 2, 0, 0, 11, 0),
('2022-06-27', 3, 0, 0, 11, 0),
('2022-06-28', 1, 0, 0, 11, 0),
('2022-06-28', 2, 0, 0, 11, 0),
('2022-06-28', 3, 0, 0, 11, 0),
('2022-06-29', 1, 0, 0, 0, 0),
('2022-06-29', 2, 0, 0, 11, 0),
('2022-06-29', 3, 0, 0, 0, 0),
('2022-06-30', 1, 10, 0, 0, 0),
('2022-06-30', 2, 10, 0, 0, 0),
('2022-06-30', 3, 0, 0, 0, 0),
('2022-07-01', 1, 0, 0, 0, 0),
('2022-07-01', 2, 0, 0, 0, 0),
('2022-07-01', 3, 0, 0, 0, 0),
('2022-07-02', 1, 10, 0, 0, 0),
('2022-07-02', 2, 0, 0, 0, 0),
('2022-07-02', 3, 0, 0, 0, 0),
('2022-07-03', 1, 0, 0, 0, 0),
('2022-07-03', 2, 0, 0, 0, 0),
('2022-07-03', 3, 0, 0, 0, 0),
('2022-07-04', 1, 10, 0, 62, 0),
('2022-07-04', 2, 0, 0, 0, 0),
('2022-07-04', 3, 10, 0, 0, 0),
('2022-07-05', 1, 10, 0, 62, 0),
('2022-07-05', 2, 0, 0, 0, 0),
('2022-07-05', 3, 0, 0, 0, 0),
('2022-07-06', 1, 0, 0, 0, 0),
('2022-07-06', 2, 10, 0, 62, 0),
('2022-07-06', 3, 0, 0, 0, 0),
('2022-07-07', 1, 0, 0, 0, 0),
('2022-07-07', 2, 0, 0, 0, 0),
('2022-07-07', 3, 0, 0, 0, 0),
('2022-07-08', 1, 0, 0, 0, 0),
('2022-07-08', 2, 0, 0, 0, 0),
('2022-07-08', 3, 0, 0, 0, 0),
('2022-07-09', 1, 0, 0, 0, 0),
('2022-07-09', 2, 0, 0, 0, 0),
('2022-07-09', 3, 0, 0, 0, 0),
('2022-07-10', 1, 0, 0, 0, 0),
('2022-07-10', 2, 0, 0, 0, 0),
('2022-07-10', 3, 0, 0, 0, 0),
('2022-07-11', 1, 0, 0, 0, 0),
('2022-07-11', 2, 0, 0, 0, 0),
('2022-07-11', 3, 0, 0, 0, 0),
('2022-07-12', 1, 0, 0, 0, 0),
('2022-07-12', 2, 0, 0, 0, 0),
('2022-07-12', 3, 0, 0, 0, 0),
('2022-07-13', 1, 0, 0, 0, 0),
('2022-07-13', 2, 0, 0, 0, 0),
('2022-07-13', 3, 0, 0, 0, 0),
('2022-07-14', 1, 0, 0, 0, 0),
('2022-07-14', 2, 0, 0, 0, 0),
('2022-07-14', 3, 0, 0, 0, 0),
('2022-07-15', 1, 0, 0, 0, 0),
('2022-07-15', 2, 0, 0, 0, 0),
('2022-07-15', 3, 0, 0, 0, 0),
('2022-07-16', 1, 0, 0, 0, 0),
('2022-07-16', 2, 0, 0, 0, 0),
('2022-07-16', 3, 0, 0, 0, 0),
('2022-07-17', 1, 0, 0, 0, 0),
('2022-07-17', 2, 0, 0, 0, 0),
('2022-07-17', 3, 0, 0, 0, 0),
('2022-07-18', 1, 0, 0, 0, 0),
('2022-07-18', 2, 0, 0, 0, 0),
('2022-07-18', 3, 0, 0, 0, 0),
('2022-07-19', 1, 0, 0, 0, 0),
('2022-07-19', 2, 0, 0, 0, 0),
('2022-07-19', 3, 0, 0, 0, 0),
('2022-07-20', 1, 0, 0, 0, 0),
('2022-07-20', 2, 0, 0, 0, 0),
('2022-07-20', 3, 0, 0, 0, 0),
('2022-07-21', 1, 0, 0, 0, 0),
('2022-07-21', 2, 0, 0, 0, 0),
('2022-07-21', 3, 0, 0, 0, 0),
('2022-07-22', 1, 0, 0, 0, 0),
('2022-07-22', 2, 0, 0, 0, 0),
('2022-07-22', 3, 0, 0, 0, 0),
('2022-07-23', 1, 0, 0, 0, 0),
('2022-07-23', 2, 0, 0, 0, 0),
('2022-07-23', 3, 0, 0, 0, 0),
('2022-07-24', 1, 0, 0, 0, 0),
('2022-07-24', 2, 0, 0, 0, 0),
('2022-07-24', 3, 0, 0, 0, 0),
('2022-07-25', 1, 0, 0, 0, 0),
('2022-07-25', 2, 0, 0, 0, 0),
('2022-07-25', 3, 0, 0, 0, 0),
('2022-07-26', 1, 0, 0, 0, 0),
('2022-07-26', 2, 0, 0, 0, 0),
('2022-07-26', 3, 0, 0, 0, 0),
('2022-07-27', 1, 0, 0, 0, 0),
('2022-07-27', 2, 0, 0, 0, 0),
('2022-07-27', 3, 0, 0, 0, 0),
('2022-07-28', 1, 0, 0, 0, 0),
('2022-07-28', 2, 0, 0, 0, 0),
('2022-07-28', 3, 0, 0, 0, 0),
('2022-07-29', 1, 0, 0, 0, 0),
('2022-07-29', 2, 0, 0, 0, 0),
('2022-07-29', 3, 0, 0, 0, 0),
('2022-07-30', 1, 0, 0, 0, 0),
('2022-07-30', 2, 0, 0, 0, 0),
('2022-07-30', 3, 0, 0, 0, 0),
('2022-07-31', 1, 0, 0, 0, 0),
('2022-07-31', 2, 0, 0, 0, 0),
('2022-07-31', 3, 0, 0, 0, 0),
('2022-08-01', 1, 0, 0, 0, 0),
('2022-08-01', 2, 0, 0, 0, 0),
('2022-08-01', 3, 0, 0, 0, 0),
('2022-08-02', 1, 0, 0, 0, 0),
('2022-08-02', 2, 0, 0, 0, 0),
('2022-08-02', 3, 0, 0, 0, 0),
('2022-08-03', 1, 0, 0, 0, 0),
('2022-08-03', 2, 0, 0, 0, 0),
('2022-08-03', 3, 0, 0, 0, 0),
('2022-08-04', 1, 0, 0, 0, 0),
('2022-08-04', 2, 0, 0, 0, 0),
('2022-08-04', 3, 0, 0, 0, 0),
('2022-08-05', 1, 0, 0, 0, 0),
('2022-08-05', 2, 0, 0, 0, 0),
('2022-08-05', 3, 0, 0, 0, 0),
('2022-08-06', 1, 0, 0, 0, 0),
('2022-08-06', 2, 0, 0, 0, 0),
('2022-08-06', 3, 0, 0, 0, 0),
('2022-08-07', 1, 0, 0, 0, 0),
('2022-08-07', 2, 0, 0, 0, 0),
('2022-08-07', 3, 0, 0, 0, 0),
('2022-08-08', 1, 0, 0, 0, 0),
('2022-08-08', 2, 0, 0, 0, 0),
('2022-08-08', 3, 0, 0, 0, 0),
('2022-08-09', 1, 0, 0, 0, 0),
('2022-08-09', 2, 0, 0, 0, 0),
('2022-08-09', 3, 0, 0, 0, 0),
('2022-08-10', 1, 0, 0, 0, 0),
('2022-08-10', 2, 0, 0, 0, 0),
('2022-08-10', 3, 0, 0, 0, 0),
('2022-08-11', 1, 0, 0, 0, 0),
('2022-08-11', 2, 0, 0, 0, 0),
('2022-08-11', 3, 0, 0, 0, 0),
('2022-08-12', 1, 0, 0, 0, 0),
('2022-08-12', 2, 0, 0, 0, 0),
('2022-08-12', 3, 0, 0, 0, 0),
('2022-08-13', 1, 0, 0, 0, 0),
('2022-08-13', 2, 0, 0, 0, 0),
('2022-08-13', 3, 0, 0, 0, 0),
('2022-08-14', 1, 0, 0, 0, 0),
('2022-08-14', 2, 0, 0, 0, 0),
('2022-08-14', 3, 0, 0, 0, 0),
('2022-08-15', 1, 0, 0, 0, 0),
('2022-08-15', 2, 0, 0, 0, 0),
('2022-08-15', 3, 0, 0, 0, 0),
('2022-08-16', 1, 0, 0, 0, 0),
('2022-08-16', 2, 0, 0, 0, 0),
('2022-08-16', 3, 0, 0, 0, 0),
('2022-08-17', 1, 0, 0, 0, 0),
('2022-08-17', 2, 0, 0, 0, 0),
('2022-08-17', 3, 0, 0, 0, 0),
('2022-08-18', 1, 0, 0, 0, 0),
('2022-08-18', 2, 0, 0, 0, 0),
('2022-08-18', 3, 0, 0, 0, 0),
('2022-08-19', 1, 0, 0, 0, 0),
('2022-08-19', 2, 0, 0, 0, 0),
('2022-08-19', 3, 0, 0, 0, 0),
('2022-08-20', 1, 0, 0, 0, 0),
('2022-08-20', 2, 0, 0, 0, 0),
('2022-08-20', 3, 0, 0, 0, 0),
('2022-08-21', 1, 0, 0, 0, 0),
('2022-08-21', 2, 0, 0, 0, 0),
('2022-08-21', 3, 0, 0, 0, 0),
('2022-08-22', 1, 0, 0, 0, 0),
('2022-08-22', 2, 0, 0, 0, 0),
('2022-08-22', 3, 0, 0, 0, 0),
('2022-08-23', 1, 0, 0, 0, 0),
('2022-08-23', 2, 0, 0, 0, 0),
('2022-08-23', 3, 0, 0, 0, 0),
('2022-08-24', 1, 0, 0, 0, 0),
('2022-08-24', 2, 0, 0, 0, 0),
('2022-08-24', 3, 0, 0, 0, 0),
('2022-08-25', 1, 0, 0, 0, 0),
('2022-08-25', 2, 0, 0, 0, 0),
('2022-08-25', 3, 0, 0, 0, 0),
('2022-08-26', 1, 0, 0, 0, 0),
('2022-08-26', 2, 0, 0, 0, 0),
('2022-08-26', 3, 0, 0, 0, 0),
('2022-08-27', 1, 0, 0, 0, 0),
('2022-08-27', 2, 0, 0, 0, 0),
('2022-08-27', 3, 0, 0, 0, 0),
('2022-08-28', 1, 0, 0, 0, 0),
('2022-08-28', 2, 0, 0, 0, 0),
('2022-08-28', 3, 0, 0, 0, 0),
('2022-08-29', 1, 0, 0, 0, 0),
('2022-08-29', 2, 0, 0, 0, 0),
('2022-08-29', 3, 0, 0, 0, 0),
('2022-08-30', 1, 0, 0, 0, 0),
('2022-08-30', 2, 0, 0, 0, 0),
('2022-08-30', 3, 0, 0, 0, 0),
('2022-08-31', 1, 0, 0, 0, 0),
('2022-08-31', 2, 0, 0, 0, 0),
('2022-08-31', 3, 0, 0, 0, 0),
('2022-09-01', 1, 0, 0, 0, 0),
('2022-09-01', 2, 0, 0, 0, 0),
('2022-09-01', 3, 0, 0, 0, 0),
('2022-09-02', 1, 0, 0, 0, 0),
('2022-09-02', 2, 0, 0, 0, 0),
('2022-09-02', 3, 0, 0, 0, 0),
('2022-09-03', 1, 0, 0, 0, 0),
('2022-09-03', 2, 0, 0, 0, 0),
('2022-09-03', 3, 0, 0, 0, 0),
('2022-09-04', 1, 0, 0, 0, 0),
('2022-09-04', 2, 0, 0, 0, 0),
('2022-09-04', 3, 0, 0, 0, 0),
('2022-09-05', 1, 0, 0, 0, 0),
('2022-09-05', 2, 0, 0, 0, 0),
('2022-09-05', 3, 0, 0, 0, 0),
('2022-09-06', 1, 0, 0, 0, 0),
('2022-09-06', 2, 0, 0, 0, 0),
('2022-09-06', 3, 0, 0, 0, 0),
('2022-09-07', 1, 0, 0, 0, 0),
('2022-09-07', 2, 0, 0, 0, 0),
('2022-09-07', 3, 0, 0, 0, 0),
('2022-09-08', 1, 0, 0, 0, 0),
('2022-09-08', 2, 0, 0, 0, 0),
('2022-09-08', 3, 0, 0, 0, 0),
('2022-09-09', 1, 0, 0, 0, 0),
('2022-09-09', 2, 0, 0, 0, 0),
('2022-09-09', 3, 0, 0, 0, 0),
('2022-09-10', 1, 0, 0, 0, 0),
('2022-09-10', 2, 0, 0, 0, 0),
('2022-09-10', 3, 0, 0, 0, 0),
('2022-09-11', 1, 0, 0, 0, 0),
('2022-09-11', 2, 0, 0, 0, 0),
('2022-09-11', 3, 0, 0, 0, 0),
('2022-09-12', 1, 0, 0, 0, 0),
('2022-09-12', 2, 0, 0, 0, 0),
('2022-09-12', 3, 0, 0, 0, 0),
('2022-09-13', 1, 0, 0, 0, 0),
('2022-09-13', 2, 0, 0, 0, 0),
('2022-09-13', 3, 0, 0, 0, 0),
('2022-09-14', 1, 0, 0, 0, 0),
('2022-09-14', 2, 0, 0, 0, 0),
('2022-09-14', 3, 0, 0, 0, 0),
('2022-09-15', 1, 0, 0, 0, 0),
('2022-09-15', 2, 0, 0, 0, 0),
('2022-09-15', 3, 0, 0, 0, 0),
('2022-09-16', 1, 0, 0, 0, 0),
('2022-09-16', 2, 0, 0, 0, 0),
('2022-09-16', 3, 0, 0, 0, 0),
('2022-09-17', 1, 0, 0, 0, 0),
('2022-09-17', 2, 0, 0, 0, 0),
('2022-09-17', 3, 0, 0, 0, 0),
('2022-09-18', 1, 0, 0, 0, 0),
('2022-09-18', 2, 0, 0, 0, 0),
('2022-09-18', 3, 0, 0, 0, 0),
('2022-09-19', 1, 0, 0, 0, 0),
('2022-09-19', 2, 0, 0, 0, 0),
('2022-09-19', 3, 0, 0, 0, 0),
('2022-09-20', 1, 0, 0, 0, 0),
('2022-09-20', 2, 0, 0, 0, 0),
('2022-09-20', 3, 0, 0, 0, 0),
('2022-09-21', 1, 0, 0, 0, 0),
('2022-09-21', 2, 0, 0, 0, 0),
('2022-09-21', 3, 0, 0, 0, 0),
('2022-09-22', 1, 0, 0, 0, 0),
('2022-09-22', 2, 0, 0, 0, 0),
('2022-09-22', 3, 0, 0, 0, 0),
('2022-09-23', 1, 0, 0, 0, 0),
('2022-09-23', 2, 0, 0, 0, 0),
('2022-09-23', 3, 0, 0, 0, 0),
('2022-09-24', 1, 0, 0, 0, 0),
('2022-09-24', 2, 0, 0, 0, 0),
('2022-09-24', 3, 0, 0, 0, 0),
('2022-09-25', 1, 0, 0, 0, 0),
('2022-09-25', 2, 0, 0, 0, 0),
('2022-09-25', 3, 0, 0, 0, 0),
('2022-09-26', 1, 0, 0, 0, 0),
('2022-09-26', 2, 0, 0, 0, 0),
('2022-09-26', 3, 0, 0, 0, 0),
('2022-09-27', 1, 0, 0, 0, 0),
('2022-09-27', 2, 0, 0, 0, 0),
('2022-09-27', 3, 0, 0, 0, 0),
('2022-09-28', 1, 0, 0, 0, 0),
('2022-09-28', 2, 0, 0, 0, 0),
('2022-09-28', 3, 0, 0, 0, 0),
('2022-09-29', 1, 0, 0, 0, 0),
('2022-09-29', 2, 0, 0, 0, 0),
('2022-09-29', 3, 0, 0, 0, 0),
('2022-09-30', 1, 0, 0, 0, 0),
('2022-09-30', 2, 0, 0, 0, 0),
('2022-09-30', 3, 0, 0, 0, 0),
('2022-10-01', 1, 0, 0, 0, 0),
('2022-10-01', 2, 0, 0, 0, 0),
('2022-10-01', 3, 0, 0, 0, 0),
('2022-10-02', 1, 0, 0, 0, 0),
('2022-10-02', 2, 0, 0, 0, 0),
('2022-10-02', 3, 0, 0, 0, 0),
('2022-10-03', 1, 0, 0, 0, 0),
('2022-10-03', 2, 0, 0, 0, 0),
('2022-10-03', 3, 0, 0, 0, 0),
('2022-10-04', 1, 0, 0, 0, 0),
('2022-10-04', 2, 0, 0, 0, 0),
('2022-10-04', 3, 0, 0, 0, 0),
('2022-10-05', 1, 0, 0, 0, 0),
('2022-10-05', 2, 0, 0, 0, 0),
('2022-10-05', 3, 0, 0, 0, 0),
('2022-10-06', 1, 0, 0, 0, 0),
('2022-10-06', 2, 0, 0, 0, 0),
('2022-10-06', 3, 0, 0, 0, 0),
('2022-10-07', 1, 0, 0, 0, 0),
('2022-10-07', 2, 0, 0, 0, 0),
('2022-10-07', 3, 0, 0, 0, 0),
('2022-10-08', 1, 0, 0, 0, 0),
('2022-10-08', 2, 0, 0, 0, 0),
('2022-10-08', 3, 0, 0, 0, 0),
('2022-10-09', 1, 0, 0, 0, 0),
('2022-10-09', 2, 0, 0, 0, 0),
('2022-10-09', 3, 0, 0, 0, 0),
('2022-10-10', 1, 0, 0, 0, 0),
('2022-10-10', 2, 0, 0, 0, 0),
('2022-10-10', 3, 0, 0, 0, 0),
('2022-10-11', 1, 0, 0, 0, 0),
('2022-10-11', 2, 0, 0, 0, 0),
('2022-10-11', 3, 0, 0, 0, 0),
('2022-10-12', 1, 0, 0, 0, 0),
('2022-10-12', 2, 0, 0, 0, 0),
('2022-10-12', 3, 0, 0, 0, 0),
('2022-10-13', 1, 0, 0, 0, 0),
('2022-10-13', 2, 0, 0, 0, 0),
('2022-10-13', 3, 0, 0, 0, 0),
('2022-10-14', 1, 0, 0, 0, 0),
('2022-10-14', 2, 0, 0, 0, 0),
('2022-10-14', 3, 0, 0, 0, 0),
('2022-10-15', 1, 0, 0, 0, 0),
('2022-10-15', 2, 0, 0, 0, 0),
('2022-10-15', 3, 0, 0, 0, 0),
('2022-10-16', 1, 0, 0, 0, 0),
('2022-10-16', 2, 0, 0, 0, 0),
('2022-10-16', 3, 0, 0, 0, 0),
('2022-10-17', 1, 0, 0, 0, 0),
('2022-10-17', 2, 0, 0, 0, 0),
('2022-10-17', 3, 0, 0, 0, 0),
('2022-10-18', 1, 0, 0, 0, 0),
('2022-10-18', 2, 0, 0, 0, 0),
('2022-10-18', 3, 0, 0, 0, 0),
('2022-10-19', 1, 0, 0, 0, 0),
('2022-10-19', 2, 0, 0, 0, 0),
('2022-10-19', 3, 0, 0, 0, 0),
('2022-10-20', 1, 0, 0, 0, 0),
('2022-10-20', 2, 0, 0, 0, 0),
('2022-10-20', 3, 0, 0, 0, 0),
('2022-10-21', 1, 0, 0, 0, 0),
('2022-10-21', 2, 0, 0, 0, 0),
('2022-10-21', 3, 0, 0, 0, 0),
('2022-10-22', 1, 0, 0, 0, 0),
('2022-10-22', 2, 0, 0, 0, 0),
('2022-10-22', 3, 0, 0, 0, 0),
('2022-10-23', 1, 0, 0, 0, 0),
('2022-10-23', 2, 0, 0, 0, 0),
('2022-10-23', 3, 0, 0, 0, 0),
('2022-10-24', 1, 0, 0, 0, 0),
('2022-10-24', 2, 0, 0, 0, 0),
('2022-10-24', 3, 0, 0, 0, 0),
('2022-10-25', 1, 0, 0, 0, 0),
('2022-10-25', 2, 0, 0, 0, 0),
('2022-10-25', 3, 0, 0, 0, 0),
('2022-10-26', 1, 0, 0, 0, 0),
('2022-10-26', 2, 0, 0, 0, 0),
('2022-10-26', 3, 0, 0, 0, 0),
('2022-10-27', 1, 0, 0, 0, 0),
('2022-10-27', 2, 0, 0, 0, 0),
('2022-10-27', 3, 0, 0, 0, 0),
('2022-10-28', 1, 0, 0, 0, 0),
('2022-10-28', 2, 0, 0, 0, 0),
('2022-10-28', 3, 0, 0, 0, 0),
('2022-10-29', 1, 0, 0, 0, 0),
('2022-10-29', 2, 0, 0, 0, 0),
('2022-10-29', 3, 0, 0, 0, 0),
('2022-10-30', 1, 0, 0, 0, 0),
('2022-10-30', 2, 0, 0, 0, 0),
('2022-10-30', 3, 0, 0, 0, 0),
('2022-10-31', 1, 0, 0, 0, 0),
('2022-10-31', 2, 0, 0, 0, 0),
('2022-10-31', 3, 0, 0, 0, 0),
('2022-11-01', 1, 0, 0, 0, 0),
('2022-11-01', 2, 0, 0, 0, 0),
('2022-11-01', 3, 0, 0, 0, 0),
('2022-11-02', 1, 0, 0, 0, 0),
('2022-11-02', 2, 0, 0, 0, 0),
('2022-11-02', 3, 0, 0, 0, 0),
('2022-11-03', 1, 0, 0, 0, 0),
('2022-11-03', 2, 0, 0, 0, 0),
('2022-11-03', 3, 0, 0, 0, 0),
('2022-11-04', 1, 0, 0, 0, 0),
('2022-11-04', 2, 0, 0, 0, 0),
('2022-11-04', 3, 0, 0, 0, 0),
('2022-11-05', 1, 0, 0, 0, 0),
('2022-11-05', 2, 0, 0, 0, 0),
('2022-11-05', 3, 0, 0, 0, 0),
('2022-11-06', 1, 0, 0, 0, 0),
('2022-11-06', 2, 0, 0, 0, 0),
('2022-11-06', 3, 0, 0, 0, 0),
('2022-11-07', 1, 0, 0, 0, 0),
('2022-11-07', 2, 0, 0, 0, 0),
('2022-11-07', 3, 0, 0, 0, 0),
('2022-11-08', 1, 0, 0, 0, 0),
('2022-11-08', 2, 0, 0, 0, 0),
('2022-11-08', 3, 0, 0, 0, 0),
('2022-11-09', 1, 0, 0, 0, 0),
('2022-11-09', 2, 0, 0, 0, 0),
('2022-11-09', 3, 0, 0, 0, 0),
('2022-11-10', 1, 0, 0, 0, 0),
('2022-11-10', 2, 0, 0, 0, 0),
('2022-11-10', 3, 0, 0, 0, 0),
('2022-11-11', 1, 0, 0, 0, 0),
('2022-11-11', 2, 0, 0, 0, 0),
('2022-11-11', 3, 0, 0, 0, 0),
('2022-11-12', 1, 0, 0, 0, 0),
('2022-11-12', 2, 0, 0, 0, 0),
('2022-11-12', 3, 0, 0, 0, 0),
('2022-11-13', 1, 0, 0, 0, 0),
('2022-11-13', 2, 0, 0, 0, 0),
('2022-11-13', 3, 0, 0, 0, 0),
('2022-11-14', 1, 0, 0, 0, 0),
('2022-11-14', 2, 0, 0, 0, 0),
('2022-11-14', 3, 0, 0, 0, 0),
('2022-11-15', 1, 0, 0, 0, 0),
('2022-11-15', 2, 0, 0, 0, 0),
('2022-11-15', 3, 0, 0, 0, 0),
('2022-11-16', 1, 0, 0, 0, 0),
('2022-11-16', 2, 0, 0, 0, 0),
('2022-11-16', 3, 0, 0, 0, 0),
('2022-11-17', 1, 0, 0, 0, 0),
('2022-11-17', 2, 0, 0, 0, 0),
('2022-11-17', 3, 0, 0, 0, 0),
('2022-11-18', 1, 0, 0, 0, 0),
('2022-11-18', 2, 0, 0, 0, 0),
('2022-11-18', 3, 0, 0, 0, 0),
('2022-11-19', 1, 0, 0, 0, 0),
('2022-11-19', 2, 0, 0, 0, 0),
('2022-11-19', 3, 0, 0, 0, 0),
('2022-11-20', 1, 0, 0, 0, 0),
('2022-11-20', 2, 0, 0, 0, 0),
('2022-11-20', 3, 0, 0, 0, 0),
('2022-11-21', 1, 0, 0, 0, 0),
('2022-11-21', 2, 0, 0, 0, 0),
('2022-11-21', 3, 0, 0, 0, 0),
('2022-11-22', 1, 0, 0, 0, 0),
('2022-11-22', 2, 0, 0, 0, 0),
('2022-11-22', 3, 0, 0, 0, 0),
('2022-11-23', 1, 0, 0, 0, 0),
('2022-11-23', 2, 0, 0, 0, 0),
('2022-11-23', 3, 0, 0, 0, 0),
('2022-11-24', 1, 0, 0, 0, 0),
('2022-11-24', 2, 0, 0, 0, 0),
('2022-11-24', 3, 0, 0, 0, 0),
('2022-11-25', 1, 0, 0, 0, 0),
('2022-11-25', 2, 0, 0, 0, 0),
('2022-11-25', 3, 0, 0, 0, 0),
('2022-11-26', 1, 0, 0, 0, 0),
('2022-11-26', 2, 0, 0, 0, 0),
('2022-11-26', 3, 0, 0, 0, 0),
('2022-11-27', 1, 0, 0, 0, 0),
('2022-11-27', 2, 0, 0, 0, 0),
('2022-11-27', 3, 0, 0, 0, 0),
('2022-11-28', 1, 0, 0, 0, 0),
('2022-11-28', 2, 0, 0, 0, 0),
('2022-11-28', 3, 0, 0, 0, 0),
('2022-11-29', 1, 0, 0, 0, 0),
('2022-11-29', 2, 0, 0, 0, 0),
('2022-11-29', 3, 0, 0, 0, 0),
('2022-11-30', 1, 0, 0, 0, 0),
('2022-11-30', 2, 0, 0, 0, 0),
('2022-11-30', 3, 0, 0, 0, 0),
('2022-12-01', 1, 0, 0, 0, 0),
('2022-12-01', 2, 0, 0, 0, 0),
('2022-12-01', 3, 0, 0, 0, 0),
('2022-12-02', 1, 0, 0, 0, 0),
('2022-12-02', 2, 0, 0, 0, 0),
('2022-12-02', 3, 0, 0, 0, 0),
('2022-12-03', 1, 0, 0, 0, 0),
('2022-12-03', 2, 0, 0, 0, 0),
('2022-12-03', 3, 0, 0, 0, 0),
('2022-12-04', 1, 0, 0, 0, 0),
('2022-12-04', 2, 0, 0, 0, 0),
('2022-12-04', 3, 0, 0, 0, 0),
('2022-12-05', 1, 0, 0, 0, 0),
('2022-12-05', 2, 0, 0, 0, 0),
('2022-12-05', 3, 0, 0, 0, 0),
('2022-12-06', 1, 0, 0, 0, 0),
('2022-12-06', 2, 0, 0, 0, 0),
('2022-12-06', 3, 0, 0, 0, 0),
('2022-12-07', 1, 0, 0, 0, 0),
('2022-12-07', 2, 0, 0, 0, 0),
('2022-12-07', 3, 0, 0, 0, 0),
('2022-12-08', 1, 0, 0, 0, 0),
('2022-12-08', 2, 0, 0, 0, 0),
('2022-12-08', 3, 0, 0, 0, 0),
('2022-12-09', 1, 0, 0, 0, 0),
('2022-12-09', 2, 0, 0, 0, 0),
('2022-12-09', 3, 0, 0, 0, 0),
('2022-12-10', 1, 0, 0, 0, 0),
('2022-12-10', 2, 0, 0, 0, 0),
('2022-12-10', 3, 0, 0, 0, 0),
('2022-12-11', 1, 0, 0, 0, 0),
('2022-12-11', 2, 0, 0, 0, 0),
('2022-12-11', 3, 0, 0, 0, 0),
('2022-12-12', 1, 0, 0, 0, 0),
('2022-12-12', 2, 0, 0, 0, 0),
('2022-12-12', 3, 0, 0, 0, 0),
('2022-12-13', 1, 0, 0, 0, 0),
('2022-12-13', 2, 0, 0, 0, 0),
('2022-12-13', 3, 0, 0, 0, 0),
('2022-12-14', 1, 0, 0, 0, 0),
('2022-12-14', 2, 0, 0, 0, 0),
('2022-12-14', 3, 0, 0, 0, 0),
('2022-12-15', 1, 0, 0, 0, 0),
('2022-12-15', 2, 0, 0, 0, 0),
('2022-12-15', 3, 0, 0, 0, 0),
('2022-12-16', 1, 0, 0, 0, 0),
('2022-12-16', 2, 0, 0, 0, 0),
('2022-12-16', 3, 0, 0, 0, 0),
('2022-12-17', 1, 0, 0, 0, 0),
('2022-12-17', 2, 0, 0, 0, 0),
('2022-12-17', 3, 0, 0, 0, 0),
('2022-12-18', 1, 0, 0, 0, 0),
('2022-12-18', 2, 0, 0, 0, 0),
('2022-12-18', 3, 0, 0, 0, 0),
('2022-12-19', 1, 0, 0, 0, 0),
('2022-12-19', 2, 0, 0, 0, 0),
('2022-12-19', 3, 0, 0, 0, 0),
('2022-12-20', 1, 0, 0, 0, 0),
('2022-12-20', 2, 0, 0, 0, 0),
('2022-12-20', 3, 0, 0, 0, 0),
('2022-12-21', 1, 0, 0, 0, 0),
('2022-12-21', 2, 0, 0, 0, 0),
('2022-12-21', 3, 0, 0, 0, 0),
('2022-12-22', 1, 0, 0, 0, 0),
('2022-12-22', 2, 0, 0, 0, 0),
('2022-12-22', 3, 0, 0, 0, 0),
('2022-12-23', 1, 0, 0, 0, 0),
('2022-12-23', 2, 0, 0, 0, 0),
('2022-12-23', 3, 0, 0, 0, 0),
('2022-12-24', 1, 0, 0, 0, 0),
('2022-12-24', 2, 0, 0, 0, 0),
('2022-12-24', 3, 0, 0, 0, 0),
('2022-12-25', 1, 0, 0, 0, 0),
('2022-12-25', 2, 0, 0, 0, 0),
('2022-12-25', 3, 0, 0, 0, 0),
('2022-12-26', 1, 0, 0, 0, 0),
('2022-12-26', 2, 0, 0, 0, 0),
('2022-12-26', 3, 0, 0, 0, 0),
('2022-12-27', 1, 0, 0, 0, 0),
('2022-12-27', 2, 0, 0, 0, 0),
('2022-12-27', 3, 0, 0, 0, 0),
('2022-12-28', 1, 0, 0, 0, 0),
('2022-12-28', 2, 0, 0, 0, 0),
('2022-12-28', 3, 0, 0, 0, 0),
('2022-12-29', 1, 0, 0, 0, 0),
('2022-12-29', 2, 0, 0, 0, 0),
('2022-12-29', 3, 0, 0, 0, 0),
('2022-12-30', 1, 0, 0, 0, 0),
('2022-12-30', 2, 0, 0, 0, 0),
('2022-12-30', 3, 0, 0, 0, 0),
('2022-12-31', 1, 0, 0, 0, 0),
('2022-12-31', 2, 0, 0, 0, 0),
('2022-12-31', 3, 0, 0, 0, 0),
('2023-01-01', 1, 0, 0, 0, 0),
('2023-01-01', 2, 0, 0, 0, 0),
('2023-01-01', 3, 0, 0, 0, 0),
('2023-01-02', 1, 0, 0, 0, 0),
('2023-01-02', 2, 0, 0, 0, 0),
('2023-01-02', 3, 0, 0, 0, 0),
('2023-01-03', 1, 0, 0, 0, 0),
('2023-01-03', 2, 0, 0, 0, 0),
('2023-01-03', 3, 0, 0, 0, 0),
('2023-01-04', 1, 0, 0, 0, 0),
('2023-01-04', 2, 0, 0, 0, 0),
('2023-01-04', 3, 0, 0, 0, 0),
('2023-01-05', 1, 0, 0, 0, 0),
('2023-01-05', 2, 0, 0, 0, 0),
('2023-01-05', 3, 0, 0, 0, 0),
('2023-01-06', 1, 0, 0, 0, 0),
('2023-01-06', 2, 0, 0, 0, 0),
('2023-01-06', 3, 0, 0, 0, 0),
('2023-01-07', 1, 0, 0, 0, 0),
('2023-01-07', 2, 0, 0, 0, 0),
('2023-01-07', 3, 0, 0, 0, 0),
('2023-01-08', 1, 0, 0, 0, 0),
('2023-01-08', 2, 0, 0, 0, 0),
('2023-01-08', 3, 0, 0, 0, 0),
('2023-01-09', 1, 0, 0, 0, 0),
('2023-01-09', 2, 0, 0, 0, 0),
('2023-01-09', 3, 0, 0, 0, 0),
('2023-01-10', 1, 0, 0, 0, 0),
('2023-01-10', 2, 0, 0, 0, 0),
('2023-01-10', 3, 0, 0, 0, 0),
('2023-01-11', 1, 0, 0, 0, 0),
('2023-01-11', 2, 0, 0, 0, 0),
('2023-01-11', 3, 0, 0, 0, 0),
('2023-01-12', 1, 0, 0, 0, 0),
('2023-01-12', 2, 0, 0, 0, 0),
('2023-01-12', 3, 0, 0, 0, 0),
('2023-01-13', 1, 0, 0, 0, 0),
('2023-01-13', 2, 0, 0, 0, 0),
('2023-01-13', 3, 0, 0, 0, 0),
('2023-01-14', 1, 0, 0, 0, 0),
('2023-01-14', 2, 0, 0, 0, 0),
('2023-01-14', 3, 0, 0, 0, 0),
('2023-01-15', 1, 0, 0, 0, 0),
('2023-01-15', 2, 0, 0, 0, 0),
('2023-01-15', 3, 0, 0, 0, 0),
('2023-01-16', 1, 0, 0, 0, 0),
('2023-01-16', 2, 0, 0, 0, 0),
('2023-01-16', 3, 0, 0, 0, 0),
('2023-01-17', 1, 0, 0, 0, 0),
('2023-01-17', 2, 0, 0, 0, 0),
('2023-01-17', 3, 0, 0, 0, 0),
('2023-01-18', 1, 0, 0, 0, 0),
('2023-01-18', 2, 0, 0, 0, 0),
('2023-01-18', 3, 0, 0, 0, 0),
('2023-01-19', 1, 0, 0, 0, 0),
('2023-01-19', 2, 0, 0, 0, 0),
('2023-01-19', 3, 0, 0, 0, 0),
('2023-01-20', 1, 0, 0, 0, 0),
('2023-01-20', 2, 0, 0, 0, 0),
('2023-01-20', 3, 0, 0, 0, 0),
('2023-01-21', 1, 0, 0, 0, 0),
('2023-01-21', 2, 0, 0, 0, 0),
('2023-01-21', 3, 0, 0, 0, 0),
('2023-01-22', 1, 0, 0, 0, 0),
('2023-01-22', 2, 0, 0, 0, 0),
('2023-01-22', 3, 0, 0, 0, 0),
('2023-01-23', 1, 0, 0, 0, 0),
('2023-01-23', 2, 0, 0, 0, 0),
('2023-01-23', 3, 0, 0, 0, 0),
('2023-01-24', 1, 0, 0, 0, 0),
('2023-01-24', 2, 0, 0, 0, 0),
('2023-01-24', 3, 0, 0, 0, 0),
('2023-01-25', 1, 0, 0, 0, 0),
('2023-01-25', 2, 0, 0, 0, 0),
('2023-01-25', 3, 0, 0, 0, 0),
('2023-01-26', 1, 0, 0, 0, 0),
('2023-01-26', 2, 0, 0, 0, 0),
('2023-01-26', 3, 0, 0, 0, 0),
('2023-01-27', 1, 0, 0, 0, 0),
('2023-01-27', 2, 0, 0, 0, 0),
('2023-01-27', 3, 0, 0, 0, 0),
('2023-01-28', 1, 0, 0, 0, 0),
('2023-01-28', 2, 0, 0, 0, 0),
('2023-01-28', 3, 0, 0, 0, 0),
('2023-01-29', 1, 0, 0, 0, 0),
('2023-01-29', 2, 0, 0, 0, 0),
('2023-01-29', 3, 0, 0, 0, 0),
('2023-01-30', 1, 0, 0, 0, 0),
('2023-01-30', 2, 0, 0, 0, 0),
('2023-01-30', 3, 0, 0, 0, 0),
('2023-01-31', 1, 0, 0, 0, 0),
('2023-01-31', 2, 0, 0, 0, 0),
('2023-01-31', 3, 0, 0, 0, 0),
('2023-02-01', 1, 0, 0, 0, 0),
('2023-02-01', 2, 0, 0, 0, 0),
('2023-02-01', 3, 0, 0, 0, 0),
('2023-02-02', 1, 0, 0, 0, 0),
('2023-02-02', 2, 0, 0, 0, 0),
('2023-02-02', 3, 0, 0, 0, 0),
('2023-02-03', 1, 0, 0, 0, 0),
('2023-02-03', 2, 0, 0, 0, 0),
('2023-02-03', 3, 0, 0, 0, 0),
('2023-02-04', 1, 0, 0, 0, 0),
('2023-02-04', 2, 0, 0, 0, 0),
('2023-02-04', 3, 0, 0, 0, 0),
('2023-02-05', 1, 0, 0, 0, 0),
('2023-02-05', 2, 0, 0, 0, 0),
('2023-02-05', 3, 0, 0, 0, 0),
('2023-02-06', 1, 0, 0, 0, 0),
('2023-02-06', 2, 0, 0, 0, 0),
('2023-02-06', 3, 0, 0, 0, 0),
('2023-02-07', 1, 0, 0, 0, 0),
('2023-02-07', 2, 0, 0, 0, 0),
('2023-02-07', 3, 0, 0, 0, 0),
('2023-02-08', 1, 0, 0, 0, 0),
('2023-02-08', 2, 0, 0, 0, 0),
('2023-02-08', 3, 0, 0, 0, 0),
('2023-02-09', 1, 0, 0, 0, 0),
('2023-02-09', 2, 0, 0, 0, 0),
('2023-02-09', 3, 0, 0, 0, 0),
('2023-02-10', 1, 0, 0, 0, 0),
('2023-02-10', 2, 0, 0, 0, 0),
('2023-02-10', 3, 0, 0, 0, 0),
('2023-02-11', 1, 0, 0, 0, 0),
('2023-02-11', 2, 0, 0, 0, 0),
('2023-02-11', 3, 0, 0, 0, 0),
('2023-02-12', 1, 0, 0, 0, 0),
('2023-02-12', 2, 0, 0, 0, 0),
('2023-02-12', 3, 0, 0, 0, 0),
('2023-02-13', 1, 0, 0, 0, 0),
('2023-02-13', 2, 0, 0, 0, 0),
('2023-02-13', 3, 0, 0, 0, 0),
('2023-02-14', 1, 0, 0, 0, 0),
('2023-02-14', 2, 0, 0, 0, 0),
('2023-02-14', 3, 0, 0, 0, 0),
('2023-02-15', 1, 0, 0, 0, 0),
('2023-02-15', 2, 0, 0, 0, 0),
('2023-02-15', 3, 0, 0, 0, 0),
('2023-02-16', 1, 0, 0, 0, 0),
('2023-02-16', 2, 0, 0, 0, 0),
('2023-02-16', 3, 0, 0, 0, 0),
('2023-02-17', 1, 0, 0, 0, 0),
('2023-02-17', 2, 0, 0, 0, 0),
('2023-02-17', 3, 0, 0, 0, 0),
('2023-02-18', 1, 0, 0, 0, 0),
('2023-02-18', 2, 0, 0, 0, 0),
('2023-02-18', 3, 0, 0, 0, 0),
('2023-02-19', 1, 0, 0, 0, 0),
('2023-02-19', 2, 0, 0, 0, 0),
('2023-02-19', 3, 0, 0, 0, 0),
('2023-02-20', 1, 0, 0, 0, 0),
('2023-02-20', 2, 0, 0, 0, 0),
('2023-02-20', 3, 0, 0, 0, 0),
('2023-02-21', 1, 0, 0, 0, 0),
('2023-02-21', 2, 0, 0, 0, 0),
('2023-02-21', 3, 0, 0, 0, 0),
('2023-02-22', 1, 0, 0, 0, 0),
('2023-02-22', 2, 0, 0, 0, 0),
('2023-02-22', 3, 0, 0, 0, 0),
('2023-02-23', 1, 0, 0, 0, 0),
('2023-02-23', 2, 0, 0, 0, 0),
('2023-02-23', 3, 0, 0, 0, 0),
('2023-02-24', 1, 0, 0, 0, 0),
('2023-02-24', 2, 0, 0, 0, 0),
('2023-02-24', 3, 0, 0, 0, 0),
('2023-02-25', 1, 0, 0, 0, 0),
('2023-02-25', 2, 0, 0, 0, 0),
('2023-02-25', 3, 0, 0, 0, 0),
('2023-02-26', 1, 0, 0, 0, 0),
('2023-02-26', 2, 0, 0, 0, 0),
('2023-02-26', 3, 0, 0, 0, 0),
('2023-02-27', 1, 0, 0, 0, 0),
('2023-02-27', 2, 0, 0, 0, 0),
('2023-02-27', 3, 0, 0, 0, 0),
('2023-02-28', 1, 0, 0, 0, 0),
('2023-02-28', 2, 0, 0, 0, 0),
('2023-02-28', 3, 0, 0, 0, 0),
('2023-03-01', 1, 0, 0, 0, 0),
('2023-03-01', 2, 0, 0, 0, 0),
('2023-03-01', 3, 0, 0, 0, 0),
('2023-03-02', 1, 0, 0, 0, 0),
('2023-03-02', 2, 0, 0, 0, 0),
('2023-03-02', 3, 0, 0, 0, 0),
('2023-03-03', 1, 0, 0, 0, 0),
('2023-03-03', 2, 0, 0, 0, 0),
('2023-03-03', 3, 0, 0, 0, 0),
('2023-03-04', 1, 0, 0, 0, 0),
('2023-03-04', 2, 0, 0, 0, 0),
('2023-03-04', 3, 0, 0, 0, 0),
('2023-03-05', 1, 0, 0, 0, 0),
('2023-03-05', 2, 0, 0, 0, 0),
('2023-03-05', 3, 0, 0, 0, 0),
('2023-03-06', 1, 0, 0, 0, 0),
('2023-03-06', 2, 0, 0, 0, 0),
('2023-03-06', 3, 0, 0, 0, 0),
('2023-03-07', 1, 0, 0, 0, 0),
('2023-03-07', 2, 0, 0, 0, 0),
('2023-03-07', 3, 0, 0, 0, 0),
('2023-03-08', 1, 0, 0, 0, 0),
('2023-03-08', 2, 0, 0, 0, 0),
('2023-03-08', 3, 0, 0, 0, 0),
('2023-03-09', 1, 0, 0, 0, 0),
('2023-03-09', 2, 0, 0, 0, 0),
('2023-03-09', 3, 0, 0, 0, 0),
('2023-03-10', 1, 0, 0, 0, 0),
('2023-03-10', 2, 0, 0, 0, 0),
('2023-03-10', 3, 0, 0, 0, 0),
('2023-03-11', 1, 0, 0, 0, 0),
('2023-03-11', 2, 0, 0, 0, 0),
('2023-03-11', 3, 0, 0, 0, 0),
('2023-03-12', 1, 0, 0, 0, 0),
('2023-03-12', 2, 0, 0, 0, 0),
('2023-03-12', 3, 0, 0, 0, 0),
('2023-03-13', 1, 0, 0, 0, 0),
('2023-03-13', 2, 0, 0, 0, 0),
('2023-03-13', 3, 0, 0, 0, 0),
('2023-03-14', 1, 0, 0, 0, 0),
('2023-03-14', 2, 0, 0, 0, 0),
('2023-03-14', 3, 0, 0, 0, 0),
('2023-03-15', 1, 0, 0, 0, 0),
('2023-03-15', 2, 0, 0, 0, 0),
('2023-03-15', 3, 0, 0, 0, 0),
('2023-03-16', 1, 0, 0, 0, 0),
('2023-03-16', 2, 0, 0, 0, 0),
('2023-03-16', 3, 0, 0, 0, 0),
('2023-03-17', 1, 0, 0, 0, 0),
('2023-03-17', 2, 0, 0, 0, 0),
('2023-03-17', 3, 0, 0, 0, 0),
('2023-03-18', 1, 0, 0, 0, 0),
('2023-03-18', 2, 0, 0, 0, 0),
('2023-03-18', 3, 0, 0, 0, 0),
('2023-03-19', 1, 0, 0, 0, 0),
('2023-03-19', 2, 0, 0, 0, 0),
('2023-03-19', 3, 0, 0, 0, 0),
('2023-03-20', 1, 0, 0, 0, 0),
('2023-03-20', 2, 0, 0, 0, 0),
('2023-03-20', 3, 0, 0, 0, 0),
('2023-03-21', 1, 0, 0, 0, 0),
('2023-03-21', 2, 0, 0, 0, 0),
('2023-03-21', 3, 0, 0, 0, 0),
('2023-03-22', 1, 0, 0, 0, 0),
('2023-03-22', 2, 0, 0, 0, 0),
('2023-03-22', 3, 0, 0, 0, 0),
('2023-03-23', 1, 0, 0, 0, 0),
('2023-03-23', 2, 0, 0, 0, 0),
('2023-03-23', 3, 0, 0, 0, 0),
('2023-03-24', 1, 0, 0, 0, 0),
('2023-03-24', 2, 0, 0, 0, 0),
('2023-03-24', 3, 0, 0, 0, 0),
('2023-03-25', 1, 0, 0, 0, 0),
('2023-03-25', 2, 0, 0, 0, 0),
('2023-03-25', 3, 0, 0, 0, 0),
('2023-03-26', 1, 0, 0, 0, 0),
('2023-03-26', 2, 0, 0, 0, 0),
('2023-03-26', 3, 0, 0, 0, 0),
('2023-03-27', 1, 0, 0, 0, 0),
('2023-03-27', 2, 0, 0, 0, 0),
('2023-03-27', 3, 0, 0, 0, 0),
('2023-03-28', 1, 0, 0, 0, 0),
('2023-03-28', 2, 0, 0, 0, 0),
('2023-03-28', 3, 0, 0, 0, 0),
('2023-03-29', 1, 0, 0, 0, 0),
('2023-03-29', 2, 0, 0, 0, 0),
('2023-03-29', 3, 0, 0, 0, 0),
('2023-03-30', 1, 0, 0, 0, 0),
('2023-03-30', 2, 0, 0, 0, 0),
('2023-03-30', 3, 0, 0, 0, 0),
('2023-03-31', 1, 0, 0, 0, 0),
('2023-03-31', 2, 0, 0, 0, 0),
('2023-03-31', 3, 0, 0, 0, 0),
('2023-04-01', 1, 0, 0, 0, 0),
('2023-04-01', 2, 0, 0, 0, 0),
('2023-04-01', 3, 0, 0, 0, 0),
('2023-04-02', 1, 0, 0, 0, 0),
('2023-04-02', 2, 0, 0, 0, 0),
('2023-04-02', 3, 0, 0, 0, 0),
('2023-04-03', 1, 0, 0, 0, 0),
('2023-04-03', 2, 0, 0, 0, 0),
('2023-04-03', 3, 0, 0, 0, 0),
('2023-04-04', 1, 0, 0, 0, 0),
('2023-04-04', 2, 0, 0, 0, 0),
('2023-04-04', 3, 0, 0, 0, 0),
('2023-04-05', 1, 0, 0, 0, 0),
('2023-04-05', 2, 0, 0, 0, 0),
('2023-04-05', 3, 0, 0, 0, 0),
('2023-04-06', 1, 0, 0, 0, 0),
('2023-04-06', 2, 0, 0, 0, 0),
('2023-04-06', 3, 0, 0, 0, 0),
('2023-04-07', 1, 0, 0, 0, 0),
('2023-04-07', 2, 0, 0, 0, 0),
('2023-04-07', 3, 0, 0, 0, 0),
('2023-04-08', 1, 0, 0, 0, 0),
('2023-04-08', 2, 0, 0, 0, 0),
('2023-04-08', 3, 0, 0, 0, 0),
('2023-04-09', 1, 0, 0, 0, 0),
('2023-04-09', 2, 0, 0, 0, 0),
('2023-04-09', 3, 0, 0, 0, 0),
('2023-04-10', 1, 0, 0, 0, 0),
('2023-04-10', 2, 0, 0, 0, 0),
('2023-04-10', 3, 0, 0, 0, 0),
('2023-04-11', 1, 0, 0, 0, 0),
('2023-04-11', 2, 0, 0, 0, 0),
('2023-04-11', 3, 0, 0, 0, 0),
('2023-04-12', 1, 0, 0, 0, 0),
('2023-04-12', 2, 0, 0, 0, 0),
('2023-04-12', 3, 0, 0, 0, 0),
('2023-04-13', 1, 0, 0, 0, 0),
('2023-04-13', 2, 0, 0, 0, 0),
('2023-04-13', 3, 0, 0, 0, 0),
('2023-04-14', 1, 0, 0, 0, 0),
('2023-04-14', 2, 0, 0, 0, 0),
('2023-04-14', 3, 0, 0, 0, 0),
('2023-04-15', 1, 0, 0, 0, 0),
('2023-04-15', 2, 0, 0, 0, 0),
('2023-04-15', 3, 0, 0, 0, 0),
('2023-04-16', 1, 0, 0, 0, 0),
('2023-04-16', 2, 0, 0, 0, 0),
('2023-04-16', 3, 0, 0, 0, 0),
('2023-04-17', 1, 0, 0, 0, 0),
('2023-04-17', 2, 0, 0, 0, 0),
('2023-04-17', 3, 0, 0, 0, 0),
('2023-04-18', 1, 0, 0, 0, 0),
('2023-04-18', 2, 0, 0, 0, 0),
('2023-04-18', 3, 0, 0, 0, 0),
('2023-04-19', 1, 0, 0, 0, 0),
('2023-04-19', 2, 0, 0, 0, 0),
('2023-04-19', 3, 0, 0, 0, 0),
('2023-04-20', 1, 0, 0, 0, 0),
('2023-04-20', 2, 0, 0, 0, 0),
('2023-04-20', 3, 0, 0, 0, 0),
('2023-04-21', 1, 0, 0, 0, 0),
('2023-04-21', 2, 0, 0, 0, 0),
('2023-04-21', 3, 0, 0, 0, 0),
('2023-04-22', 1, 0, 0, 0, 0),
('2023-04-22', 2, 0, 0, 0, 0),
('2023-04-22', 3, 0, 0, 0, 0),
('2023-04-23', 1, 0, 0, 0, 0),
('2023-04-23', 2, 0, 0, 0, 0),
('2023-04-23', 3, 0, 0, 0, 0),
('2023-04-24', 1, 0, 0, 0, 0),
('2023-04-24', 2, 0, 0, 0, 0),
('2023-04-24', 3, 0, 0, 0, 0),
('2023-04-25', 1, 0, 0, 0, 0),
('2023-04-25', 2, 0, 0, 0, 0),
('2023-04-25', 3, 0, 0, 0, 0),
('2023-04-26', 1, 0, 0, 0, 0),
('2023-04-26', 2, 0, 0, 0, 0),
('2023-04-26', 3, 0, 0, 0, 0),
('2023-04-27', 1, 0, 0, 0, 0),
('2023-04-27', 2, 0, 0, 0, 0),
('2023-04-27', 3, 0, 0, 0, 0),
('2023-04-28', 1, 0, 0, 0, 0),
('2023-04-28', 2, 0, 0, 0, 0),
('2023-04-28', 3, 0, 0, 0, 0),
('2023-04-29', 1, 0, 0, 0, 0),
('2023-04-29', 2, 0, 0, 0, 0),
('2023-04-29', 3, 0, 0, 0, 0),
('2023-04-30', 1, 0, 0, 0, 0),
('2023-04-30', 2, 0, 0, 0, 0),
('2023-04-30', 3, 0, 0, 0, 0),
('2023-05-01', 1, 0, 0, 0, 0),
('2023-05-01', 2, 0, 0, 0, 0),
('2023-05-01', 3, 0, 0, 0, 0),
('2023-05-02', 1, 0, 0, 0, 0),
('2023-05-02', 2, 0, 0, 0, 0),
('2023-05-02', 3, 0, 0, 0, 0),
('2023-05-03', 1, 0, 0, 0, 0),
('2023-05-03', 2, 0, 0, 0, 0),
('2023-05-03', 3, 0, 0, 0, 0),
('2023-05-04', 1, 0, 0, 0, 0),
('2023-05-04', 2, 0, 0, 0, 0),
('2023-05-04', 3, 0, 0, 0, 0),
('2023-05-05', 1, 0, 0, 0, 0),
('2023-05-05', 2, 0, 0, 0, 0),
('2023-05-05', 3, 0, 0, 0, 0),
('2023-05-06', 1, 0, 0, 0, 0),
('2023-05-06', 2, 0, 0, 0, 0),
('2023-05-06', 3, 0, 0, 0, 0),
('2023-05-07', 1, 0, 0, 0, 0),
('2023-05-07', 2, 0, 0, 0, 0),
('2023-05-07', 3, 0, 0, 0, 0),
('2023-05-08', 1, 0, 0, 0, 0),
('2023-05-08', 2, 0, 0, 0, 0),
('2023-05-08', 3, 0, 0, 0, 0),
('2023-05-09', 1, 0, 0, 0, 0),
('2023-05-09', 2, 0, 0, 0, 0),
('2023-05-09', 3, 0, 0, 0, 0),
('2023-05-10', 1, 0, 0, 0, 0),
('2023-05-10', 2, 0, 0, 0, 0),
('2023-05-10', 3, 0, 0, 0, 0),
('2023-05-11', 1, 0, 0, 0, 0),
('2023-05-11', 2, 0, 0, 0, 0),
('2023-05-11', 3, 0, 0, 0, 0),
('2023-05-12', 1, 0, 0, 0, 0),
('2023-05-12', 2, 0, 0, 0, 0),
('2023-05-12', 3, 0, 0, 0, 0),
('2023-05-13', 1, 0, 0, 0, 0),
('2023-05-13', 2, 0, 0, 0, 0),
('2023-05-13', 3, 0, 0, 0, 0),
('2023-05-14', 1, 0, 0, 0, 0),
('2023-05-14', 2, 0, 0, 0, 0),
('2023-05-14', 3, 0, 0, 0, 0),
('2023-05-15', 1, 0, 0, 0, 0),
('2023-05-15', 2, 0, 0, 0, 0),
('2023-05-15', 3, 0, 0, 0, 0),
('2023-05-16', 1, 0, 0, 0, 0),
('2023-05-16', 2, 0, 0, 0, 0),
('2023-05-16', 3, 0, 0, 0, 0),
('2023-05-17', 1, 0, 0, 0, 0),
('2023-05-17', 2, 0, 0, 0, 0),
('2023-05-17', 3, 0, 0, 0, 0),
('2023-05-18', 1, 0, 0, 0, 0),
('2023-05-18', 2, 0, 0, 0, 0),
('2023-05-18', 3, 0, 0, 0, 0),
('2023-05-19', 1, 0, 0, 0, 0),
('2023-05-19', 2, 0, 0, 0, 0),
('2023-05-19', 3, 0, 0, 0, 0),
('2023-05-20', 1, 0, 0, 0, 0),
('2023-05-20', 2, 0, 0, 0, 0),
('2023-05-20', 3, 0, 0, 0, 0),
('2023-05-21', 1, 0, 0, 0, 0),
('2023-05-21', 2, 0, 0, 0, 0),
('2023-05-21', 3, 0, 0, 0, 0),
('2023-05-22', 1, 0, 0, 0, 0),
('2023-05-22', 2, 0, 0, 0, 0),
('2023-05-22', 3, 0, 0, 0, 0),
('2023-05-23', 1, 0, 0, 0, 0),
('2023-05-23', 2, 0, 0, 0, 0),
('2023-05-23', 3, 0, 0, 0, 0),
('2023-05-24', 1, 0, 0, 0, 0),
('2023-05-24', 2, 0, 0, 0, 0),
('2023-05-24', 3, 0, 0, 0, 0),
('2023-05-25', 1, 0, 0, 0, 0),
('2023-05-25', 2, 0, 0, 0, 0),
('2023-05-25', 3, 0, 0, 0, 0),
('2023-05-26', 1, 0, 0, 0, 0),
('2023-05-26', 2, 0, 0, 0, 0),
('2023-05-26', 3, 0, 0, 0, 0),
('2023-05-27', 1, 0, 0, 0, 0),
('2023-05-27', 2, 0, 0, 0, 0),
('2023-05-27', 3, 0, 0, 0, 0),
('2023-05-28', 1, 0, 0, 0, 0),
('2023-05-28', 2, 0, 0, 0, 0),
('2023-05-28', 3, 0, 0, 0, 0),
('2023-05-29', 1, 0, 0, 0, 0),
('2023-05-29', 2, 0, 0, 0, 0),
('2023-05-29', 3, 0, 0, 0, 0),
('2023-05-30', 1, 0, 0, 0, 0),
('2023-05-30', 2, 0, 0, 0, 0),
('2023-05-30', 3, 0, 0, 0, 0),
('2023-05-31', 1, 0, 0, 0, 0),
('2023-05-31', 2, 0, 0, 0, 0),
('2023-05-31', 3, 0, 0, 0, 0),
('2023-06-01', 1, 0, 0, 0, 0),
('2023-06-01', 2, 0, 0, 0, 0),
('2023-06-01', 3, 0, 0, 0, 0),
('2023-06-02', 1, 0, 0, 0, 0),
('2023-06-02', 2, 0, 0, 0, 0),
('2023-06-02', 3, 0, 0, 0, 0),
('2023-06-03', 1, 0, 0, 0, 0),
('2023-06-03', 2, 0, 0, 0, 0),
('2023-06-03', 3, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

CREATE TABLE `session` (
  `Session` int(11) NOT NULL,
  `SessionTime` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`Session`, `SessionTime`) VALUES
(1, 'Morning'),
(2, 'Afternoon'),
(3, 'Evening');

-- --------------------------------------------------------

--
-- Table structure for table `shoprecovery`
--

CREATE TABLE `shoprecovery` (
  `recoveryid` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `StoreID` int(11) NOT NULL,
  `Quanity` int(11) NOT NULL,
  `status` varchar(50) NOT NULL,
  `Reason` varchar(100) DEFAULT NULL,
  `dateofcreate` date NOT NULL,
  `dateofrecover` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shoprecovery`
--

INSERT INTO `shoprecovery` (`recoveryid`, `ProductID`, `StoreID`, `Quanity`, `status`, `Reason`, `dateofcreate`, `dateofrecover`) VALUES
(1, 10, 1, 10, '', '', '2022-06-25', NULL),
(2, 10, 1, 10, 'Accepted', '', '2022-06-25', '2022-06-30'),
(3, 10, 2, 10, 'Accepted', NULL, '2022-06-26', '2022-06-30'),
(4, 31, 2, 10, 'Accepted', NULL, '2022-06-27', '2022-06-30'),
(5, 10, 2, 10, 'Refused', 'No There is Not Enough Stock ', '2022-07-04', NULL),
(6, 10, 2, 2, 'Accepted', NULL, '2022-07-04', '2022-07-08'),
(7, 10, 2, 10, 'Refused', '', '2022-07-04', NULL),
(8, 10, 2, 20, 'Waiting For Reply', NULL, '2022-07-04', NULL),
(9, 13, 2, 20, 'Accepted', 'stock is not enough', '2022-07-04', '2022-07-04');

-- --------------------------------------------------------

--
-- Table structure for table `soldproduct`
--

CREATE TABLE `soldproduct` (
  `soldproductid` int(11) NOT NULL,
  `SaleorderID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  `ProductPrePrice` double NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Displayed` int(11) NOT NULL,
  `TotalAmount` double NOT NULL,
  `Able` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `soldproduct`
--

INSERT INTO `soldproduct` (`soldproductid`, `SaleorderID`, `productID`, `ProductPrePrice`, `Quantity`, `Displayed`, `TotalAmount`, `Able`) VALUES
(50, 34, 10, 6980, 4, 0, 27920, 'Disabled'),
(51, 34, 14, 5500, 4, 0, 22000, 'Disabled'),
(52, 34, 29, 0, 2, 0, 6400, 'Disabled'),
(53, 35, 10, 6980, 2, 0, 13960, 'Disabled'),
(54, 35, 13, 6000, 1, 0, 6000, 'Disabled'),
(55, 36, 10, 6980, 3, 0, 20940, 'Enable'),
(56, 36, 13, 6000, 1, 0, 6000, 'Enable'),
(57, 37, 10, 6980, 3, 0, 20940, 'Enable'),
(58, 37, 13, 6000, 2, 0, 12000, 'Enable'),
(59, 38, 14, 5500, 2, 0, 11000, 'Enable'),
(60, 38, 29, 3200, 2, 0, 6400, 'Enable'),
(61, 38, 15, 6600, 1, 0, 6600, 'Enable'),
(62, 39, 13, 6000, 2, 0, 12000, 'Enable'),
(63, 39, 10, 6980, 1, 0, 6980, 'Enable'),
(64, 36, 10, 6980, 1, 0, 6980, 'Enable'),
(65, 40, 10, 6980, 2, 0, 13960, 'Enable'),
(66, 40, 13, 6000, 2, 0, 12000, 'Enable'),
(67, 40, 14, 5500, 2, 0, 11000, 'Enable'),
(68, 40, 29, 3200, 1, 0, 3200, 'Enable'),
(69, 41, 13, 6000, 2, 0, 12000, 'Enable'),
(70, 41, 15, 6600, 2, 0, 13200, 'Enable'),
(71, 41, 10, 6980, 2, 0, 13960, 'Enable'),
(72, 42, 10, 6980, 2, 0, 13960, 'Enable'),
(73, 42, 14, 5500, 2, 0, 11000, 'Enable'),
(74, 43, 10, 6980, 2, 0, 13960, 'Enable'),
(75, 44, 10, 6980, 1, 0, 6980, 'Enable'),
(76, 45, 31, 4590, 1, 0, 4590, 'Enable'),
(77, 45, 13, 6000, 1, 0, 6000, 'Enable'),
(78, 45, 10, 6980, 1, 0, 6980, 'Enable'),
(79, 46, 10, 6980, 1, 0, 6980, 'Enable'),
(80, 46, 13, 6000, 1, 0, 6000, 'Enable'),
(81, 47, 31, 4590, 1, 0, 4590, 'Enable'),
(82, 47, 10, 6980, 2, 0, 13960, 'Enable'),
(83, 48, 29, 3200, 2, 0, 6400, 'Enable'),
(84, 49, 10, 6980, 1, 0, 6980, 'Enable'),
(85, 49, 13, 6000, 1, 0, 6000, 'Enable'),
(86, 49, 31, 4590, 1, 0, 4590, 'Enable'),
(87, 50, 10, 6980, 2, 0, 13960, 'Enable'),
(88, 51, 10, 6980, 1, 0, 6980, 'Disabled'),
(89, 51, 13, 6000, 1, 0, 6000, 'Enable'),
(90, 51, 28, 6000, 1, 0, 6000, 'Enable'),
(91, 52, 10, 6980, 1, 0, 6980, 'Disabled'),
(92, 52, 29, 3200, 1, 0, 3200, 'Disabled'),
(93, 52, 13, 6000, 2, 0, 12000, 'Enable'),
(94, 53, 10, 6980, 2, 0, 13960, 'Enable'),
(95, 53, 13, 6000, 1, 0, 6000, 'Enable'),
(96, 53, 31, 4590, 0, 0, 0, 'Disabled'),
(97, 53, 31, 4590, 2, 0, 9180, 'Enable'),
(98, 54, 24, 1500, 1, 0, 1500, 'Enable'),
(99, 55, 10, 6980, 1, 0, 6980, 'Enable'),
(100, 55, 13, 6000, 1, 0, 6000, 'Enable'),
(101, 55, 28, 6000, 1, 0, 6000, 'Enable'),
(102, 55, 31, 4590, 1, 0, 4590, 'Enable'),
(103, 56, 10, 7000, 3, 0, 21000, 'Enable'),
(104, 56, 13, 6000, 1, 0, 6000, 'Disabled'),
(105, 56, 31, 4590, 1, 0, 4590, 'Disabled'),
(106, 57, 10, 7000, 3, 0, 21000, 'Disabled'),
(107, 57, 13, 6000, 1, 0, 6000, 'Disabled'),
(108, 57, 31, 4590, 1, 0, 4590, 'Disabled'),
(109, 58, 21, 3000, 3, 0, 9000, 'Enable'),
(110, 57, 13, 6000, 1, 0, 6000, 'Enable'),
(111, 59, 10, 7000, 1, 0, 7000, 'Enable'),
(112, 59, 13, 6000, 1, 0, 6000, 'Enable'),
(113, 59, 31, 4590, 1, 0, 4590, 'Enable'),
(114, 60, 21, 3000, 2, 0, 6000, 'Enable'),
(115, 59, 29, 3200, 1, 0, 3200, 'Disabled'),
(116, 61, 21, 3000, 2, 0, 6000, 'Enable'),
(117, 62, 10, 7000, 2, 0, 14000, 'Enable'),
(118, 62, 13, 6000, 1, 0, 6000, 'Enable'),
(119, 63, 21, 3000, 2, 0, 6000, 'Enable'),
(120, 64, 10, 7000, 2, 0, 14000, 'Enable'),
(121, 64, 13, 6000, 2, 0, 12000, 'Enable'),
(122, 65, 10, 7000, 3, 0, 21000, 'Enable'),
(123, 65, 13, 6000, 2, 0, 12000, 'Enable'),
(124, 65, 29, 3200, 1, 0, 3200, 'Disabled');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `StaffID` int(11) NOT NULL,
  `HKID` varchar(16) DEFAULT NULL,
  `Username` varchar(24) NOT NULL,
  `Firstname` varchar(30) NOT NULL,
  `Lastname` varchar(30) NOT NULL,
  `Password` varchar(32) NOT NULL,
  `PhoneNumber` varchar(14) NOT NULL,
  `EmailAddress` varchar(30) DEFAULT NULL,
  `Region` varchar(30) NOT NULL,
  `AddressLine1` varchar(50) NOT NULL,
  `AddressLine2` varchar(50) DEFAULT NULL,
  `AddressLine3` varchar(50) DEFAULT NULL,
  `Gender` varchar(1) NOT NULL,
  `DepartmentID` int(2) DEFAULT NULL,
  `StoreID` int(11) DEFAULT NULL,
  `BrithDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `HKID`, `Username`, `Firstname`, `Lastname`, `Password`, `PhoneNumber`, `EmailAddress`, `Region`, `AddressLine1`, `AddressLine2`, `AddressLine3`, `Gender`, `DepartmentID`, `StoreID`, `BrithDate`) VALUES
(0, NULL, 'Test', '/', '/', '/', '/', NULL, '/', '/', '/', '/', '/', 1, 0, NULL),
(1, NULL, 'Admin', '', '', 'Admin', '', '', 'Hong Kong,Hong Kong Island', '', '', '', 'M', 2, NULL, '2000-01-01'),
(2, NULL, 'Amy0101', 'Lil', 'Pump', 'Amy0101', '', NULL, '', '', '', '', 'F', 3, 2, NULL),
(3, NULL, 'Shop_Sale', 'Christine', 'Chan', 'Shop_Sale', '', NULL, '', '', '', '', 'F', 4, 2, NULL),
(4, NULL, 'Purchasing_Manager', '', '', 'Purchasing_Manager', '', NULL, '', '', '', '', 'M', 5, NULL, NULL),
(5, NULL, 'Purchasing_Clerk', '', '', 'Purchasing_Clerk', '', NULL, '', '', NULL, NULL, '', 6, NULL, NULL),
(6, NULL, 'Larry0313', '', '', 'Larry0313', '', NULL, '', '', NULL, NULL, '', 7, NULL, NULL),
(7, NULL, 'Inventory_Clerk', '', '', 'Inventory_Clerk', '', NULL, '', '', NULL, NULL, '', 8, NULL, NULL),
(8, NULL, 'Franky0323', '', '', 'Franky0323', '', NULL, '', '', NULL, NULL, '', 9, NULL, NULL),
(9, NULL, 'Accounting_Clerk', '', '', 'Accounting_Clerk', '', NULL, '', '', NULL, NULL, '', 10, NULL, NULL),
(10, NULL, 'Jamie131', 'Lai Yi Jamie', 'Chan', 'Jamie131', '', NULL, '', '', NULL, NULL, '', 11, NULL, NULL),
(11, NULL, 'Installation_Worker', 'Lai Hai', 'Wei', 'Installation_Worker', '', NULL, '', '', NULL, NULL, '', 12, NULL, NULL),
(62, 'F343424(4)', 'Wilson313', 'Hoi Wa Wilson', 'Lam', 'Wilson313', '+85243434333', 'sadsdad@', 'Hong Kong,New Territories', 'dasdad', 'asdadsa', 'dsadas', 'M', 12, NULL, '2000-02-01'),
(64, 'W434343(4)', 'StatME', 'Stat', 'ME', 'StatME', '+85223232323', 'adsadsadsad', 'Hong Kong,New Territories', '232323', '23232', '32323', 'M', 12, NULL, '2000-02-01'),
(65, 'A343434(3)', 'StartIT', 'Start', 'IT', 'StartIT', '+85223233232', 'asdadsadsa', 'Hong Kong,New Territories', 'assadsadsadas', 'dsadsadsad', 'dsadsads', 'M', 12, NULL, '2000-02-01'),
(66, 'D243434(2)', 'StopIT', 'Stop', 'IT', 'StopIT', '+85224424242', 'ad@gmail.com', 'Hong Kong,New Territories', 'adasd', 'dsadsa', 'dsaad', 'M', 12, NULL, '2000-02-01'),
(68, NULL, 'ReallyInstall', 'Install', 'Really', 'ReallyInstall', '', NULL, '', '', NULL, NULL, '', 15, NULL, NULL),
(69, 'K343434(9)', 'Yips0651', 'Kit Haung', 'Yip', 'Yip0651', '+85254965656', 'yipkithung@gmail.com', 'Hong Kong,New Territories', '2', '2', '2', 'M', 4, 1, '2000-02-01'),
(70, 'G232323(3)', 'NBwan232', 'Yesyuod', 'Ki', 'NBwan232', '+85223029322', 'Hah2@hotmail.com', 'Hong Kong,New Territories', 'Room 5 Fanling', 'Centrelaf Centre', 'San wan road 232', 'M', 4, 1, '2000-02-01'),
(71, 'Y322323(3)', 'Low320311', 'Wing Sum', 'Yeung', 'Low320311', '+85223203232', 'Billy_9319@hotmail.com', 'Hong Kong,New Territories', 'Room9 ', 'Fanling Plaza', 'San WAn 820', 'F', 4, 1, '2001-03-01'),
(72, 'F232323(3)', 'Lorali23', 'Wai Kit', 'Loi', 'Lorali23', '+85244538798', 'Billy_03109@hotmail.com', 'Hong Kong,New Territories', '234', '343', '432', 'M', 4, 1, '2000-02-01'),
(73, 'R038239(3)', 'Daota243', 'Jai Wau', 'Jer', 'Daota243', '+85223424242', 'billy_3290@hotmail.com', 'Hong Kong,New Territories', '323', '343', '4343', 'M', 3, 1, '2000-01-31'),
(74, 'A232333(3)', 'HayYeung102', 'Hay Hay', 'Yeung', 'HayYeung102', '+85225556666', 'harry@gmail.com', 'Hong Kong,New Territories', 'Stop', 'Stop', 'Stop', 'M', 11, NULL, '2000-02-11'),
(75, 'T343434(3)', 'YUe130232', 'Yaweo Yeung', 'Yop', 'YUe130232', '+85245121354', 'Bily@hitmail.com', 'Hong Kong,New Territories', 'sadsa', 'sadsa', 'sadadsa', 'M', 11, NULL, '2000-07-13'),
(76, 'R343444(4)', 'Billy031002', 'Yuen Tat Shing', 'Yuen', 'Billy031002', '+85245658952', 'nilly_22@hotmail.com', 'Hong Kong,New Territories', 'asdsa', 'asdad', 'dsad', 'M', 2, NULL, '2000-02-01');

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `StoreID` int(11) NOT NULL,
  `StoreName` varchar(30) NOT NULL,
  `StoreManager` int(11) DEFAULT NULL,
  `Phonenumber` varchar(20) NOT NULL,
  `Address1` varchar(50) NOT NULL,
  `Address2` varchar(50) NOT NULL,
  `Address3` varchar(50) NOT NULL,
  `Region` varchar(60) NOT NULL,
  `Available` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `store`
--

INSERT INTO `store` (`StoreID`, `StoreName`, `StoreManager`, `Phonenumber`, `Address1`, `Address2`, `Address3`, `Region`, `Available`) VALUES
(0, '', 0, '/', '/', '', '', '/', 0),
(1, 'Kowloon Bay Store', 2, '', '', '', '', '', 1),
(2, 'Tsuen Wan Store', 2, '+85243434343', 'a3', 'a232', 'a323', 'Hong Kong', 1);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(30) NOT NULL,
  `Address1` varchar(70) NOT NULL,
  `Address2` varchar(70) DEFAULT NULL,
  `Address3` varchar(70) DEFAULT NULL,
  `PhoneNumber` varchar(13) NOT NULL,
  `Available` int(1) NOT NULL,
  `Region` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `Address1`, `Address2`, `Address3`, `PhoneNumber`, `Available`, `Region`) VALUES
(0, '', '', '', '', '', 1, '/'),
(1, 'Samsung', 'Flat 3, 25/F', 'Mongkok Centre', 'MongKong', '23450493', 1, ''),
(2, 'Sony', '16/F', 'East', '', '+85282038863', 1, 'Hong Kong,China'),
(3, 'LG', 'Evergrand Technologies Ltd', 'Unit A-C 11/F Por Yen Building 478 Castle Peak Roa', 'Lai Chi Kok', '+85235437777', 1, 'Hong Kong,China'),
(4, 'Huawei', '10/F 700 Nathan Rd, Mong Kok', NULL, NULL, '+85236953012', 1, 'Hong Kong,China'),
(7, 'HyperX', '18/F Kowloon', NULL, NULL, '+85284849494', 1, 'Hong Kong,China'),
(9, 'Intel', 'HK', NULL, NULL, '+8523454555', 1, 'Hong Kong,China'),
(12, 'Western Digital', 'Unit A-C 11/F', 'Por Yen Building ', '478 Castle Peak Road', '+85283230484', 0, 'Kowloon Peninsula    Hong Kong'),
(13, 'sadsad', 'asdsad', 'dsadsad', 'sadsaasd', '+85223232323', 1, 'New Territories    Hong Kong');

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

CREATE TABLE `type` (
  `TypeID` int(11) NOT NULL,
  `TypeName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`TypeID`, `TypeName`) VALUES
(0, 'Test'),
(3, 'SmartPhone'),
(4, 'Tablet'),
(15, 'Ram'),
(16, 'CPU'),
(17, 'Motherboard'),
(18, 'Power Supply'),
(20, 'TV'),
(21, 'Refrigerator'),
(22, 'Home console');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `defectitem`
--
ALTER TABLE `defectitem`
  ADD PRIMARY KEY (`defectItemID`);

--
-- Indexes for table `deliveryorder`
--
ALTER TABLE `deliveryorder`
  ADD PRIMARY KEY (`DeliveryOrderID`),
  ADD KEY `ForeignKey_DProductID2` (`DeliveryProductID_2`),
  ADD KEY `ForeignKey_DProductID3` (`DeliveryProductID_3`),
  ADD KEY `ForeignKey_DProductID4` (`DeliveryProductID_4`),
  ADD KEY `ForeignKey_DProductID5` (`DeliveryProductID_5`),
  ADD KEY `ForeignKey_DProductID6` (`DeliveryProductID_6`),
  ADD KEY `ForeignKey_DProductID7` (`DeliveryProductID_7`),
  ADD KEY `ForeignKey_DProductID8` (`DeliveryProductID_8`),
  ADD KEY `ForeignKey_DProductID9` (`DeliveryProductID_9`),
  ADD KEY `ForeignKey_DProductID10` (`DeliveryProductID_10`),
  ADD KEY `ForeignKey_DProductID1` (`DeliveryProductID_1`),
  ADD KEY `ForeignKey_DCustomerID` (`CustomerID`),
  ADD KEY `ForeignKey_SessionID` (`SessionID`),
  ADD KEY `ForeignKey_DWorkerID` (`DWorkerID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepartmentID`);

--
-- Indexes for table `installationorder`
--
ALTER TABLE `installationorder`
  ADD PRIMARY KEY (`InstallationOrderID`),
  ADD KEY `ForeignKey_iProductID1` (`InstallProduct1`),
  ADD KEY `ForeignKey_iProductID2` (`InstallProduct2`),
  ADD KEY `ForeignKey_iProductID3` (`InstallProduct3`),
  ADD KEY `ForeignKey_iProductID4` (`InstallProduct4`),
  ADD KEY `ForeignKey_iProductID5` (`InstallProduct5`),
  ADD KEY `ForeignKey_iProductID6` (`InstallProduct6`),
  ADD KEY `ForeignKey_iProductID7` (`InstallProduct7`),
  ADD KEY `ForeignKey_iProductID8` (`InstallProduct8`),
  ADD KEY `ForeignKey_iProductID9` (`InstallProduct9`),
  ADD KEY `ForeignKey_iProductID10` (`InstallProduct10`),
  ADD KEY `ForeignKey_IWorker` (`I_Worker`),
  ADD KEY `SessionID` (`SessionID`),
  ADD KEY `ForeignKey_SaleOrderID` (`SaleOrderID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`),
  ADD KEY `SupplierID` (`SupplierID`),
  ADD KEY `ForeignKey_TypeID` (`TypeID`);

--
-- Indexes for table `purchaseitem`
--
ALTER TABLE `purchaseitem`
  ADD PRIMARY KEY (`ProductID`,`dateofcreate`) USING BTREE,
  ADD KEY `ForeignKey_PurchaseOrderID` (`PurchaseOrderID`);

--
-- Indexes for table `purchasingorder`
--
ALTER TABLE `purchasingorder`
  ADD PRIMARY KEY (`purchasingorderID`) USING BTREE,
  ADD KEY `ForeignKey_StaffID` (`StaffID`);

--
-- Indexes for table `reorder`
--
ALTER TABLE `reorder`
  ADD PRIMARY KEY (`ReorderID`),
  ADD KEY `ForeignKey_ProductID1` (`Product1`),
  ADD KEY `ForeignKey_ProductID2` (`Product2`),
  ADD KEY `ForeignKey_ProductID3` (`Product3`),
  ADD KEY `ForeignKey_ProductID4` (`Product4`),
  ADD KEY `ForeignKey_ProductID5` (`Product5`),
  ADD KEY `ForeignKey_ProductID6` (`Product6`),
  ADD KEY `ForeignKey_ProductID7` (`Product7`),
  ADD KEY `ForeignKey_ProductID8` (`Product8`),
  ADD KEY `ForeignKey_ProductID9` (`Product9`),
  ADD KEY `ForeignKey_ProductID10` (`Product10`);

--
-- Indexes for table `saleorder`
--
ALTER TABLE `saleorder`
  ADD PRIMARY KEY (`orderID`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`dateofservice`,`SessionID`) USING BTREE,
  ADD KEY `ForeignKey_StaffID_I1` (`I_staffID`),
  ADD KEY `ForeignKey_Session` (`SessionID`),
  ADD KEY `ForeignKey_StaffID_D` (`D_staffID`),
  ADD KEY `ForeignKey_StaffID_D1` (`D_staff2ID`),
  ADD KEY `ForeignKey_StaffID_I2` (`I_staffID2`);

--
-- Indexes for table `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`Session`);

--
-- Indexes for table `shoprecovery`
--
ALTER TABLE `shoprecovery`
  ADD PRIMARY KEY (`recoveryid`);

--
-- Indexes for table `soldproduct`
--
ALTER TABLE `soldproduct`
  ADD PRIMARY KEY (`soldproductid`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD KEY `ForeignKey_DepartmentID` (`DepartmentID`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`StoreID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`);

--
-- Indexes for table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`TypeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10037;

--
-- AUTO_INCREMENT for table `defectitem`
--
ALTER TABLE `defectitem`
  MODIFY `defectItemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `deliveryorder`
--
ALTER TABLE `deliveryorder`
  MODIFY `DeliveryOrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=105;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `DepartmentID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `installationorder`
--
ALTER TABLE `installationorder`
  MODIFY `InstallationOrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `purchasingorder`
--
ALTER TABLE `purchasingorder`
  MODIFY `purchasingorderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `reorder`
--
ALTER TABLE `reorder`
  MODIFY `ReorderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `saleorder`
--
ALTER TABLE `saleorder`
  MODIFY `orderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `session`
--
ALTER TABLE `session`
  MODIFY `Session` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `shoprecovery`
--
ALTER TABLE `shoprecovery`
  MODIFY `recoveryid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `soldproduct`
--
ALTER TABLE `soldproduct`
  MODIFY `soldproductid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `StoreID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SupplierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `type`
--
ALTER TABLE `type`
  MODIFY `TypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deliveryorder`
--
ALTER TABLE `deliveryorder`
  ADD CONSTRAINT `ForeignKey_DCustomerID` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID10` FOREIGN KEY (`DeliveryProductID_10`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID2` FOREIGN KEY (`DeliveryProductID_2`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID3` FOREIGN KEY (`DeliveryProductID_3`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID4` FOREIGN KEY (`DeliveryProductID_4`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID5` FOREIGN KEY (`DeliveryProductID_5`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID6` FOREIGN KEY (`DeliveryProductID_6`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID7` FOREIGN KEY (`DeliveryProductID_7`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID8` FOREIGN KEY (`DeliveryProductID_8`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DProductID9` FOREIGN KEY (`DeliveryProductID_9`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_DWorkerID` FOREIGN KEY (`DWorkerID`) REFERENCES `schedule` (`D_staffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_SessionID` FOREIGN KEY (`SessionID`) REFERENCES `session` (`Session`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `installationorder`
--
ALTER TABLE `installationorder`
  ADD CONSTRAINT `ForeignKey_IWorker` FOREIGN KEY (`I_Worker`) REFERENCES `schedule` (`I_staffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID1` FOREIGN KEY (`InstallProduct1`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID10` FOREIGN KEY (`InstallProduct10`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID2` FOREIGN KEY (`InstallProduct2`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID3` FOREIGN KEY (`InstallProduct3`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID4` FOREIGN KEY (`InstallProduct4`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID5` FOREIGN KEY (`InstallProduct5`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID6` FOREIGN KEY (`InstallProduct6`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID7` FOREIGN KEY (`InstallProduct7`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID8` FOREIGN KEY (`InstallProduct8`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_iProductID9` FOREIGN KEY (`InstallProduct9`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `ForeignKey_SupplierID` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_TypeID` FOREIGN KEY (`TypeID`) REFERENCES `type` (`TypeID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchaseitem`
--
ALTER TABLE `purchaseitem`
  ADD CONSTRAINT `ForeignKey_ProductID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_PurchaseOrderID` FOREIGN KEY (`PurchaseOrderID`) REFERENCES `purchasingorder` (`purchasingorderID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `purchasingorder`
--
ALTER TABLE `purchasingorder`
  ADD CONSTRAINT `ForeignKey_StaffID` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `reorder`
--
ALTER TABLE `reorder`
  ADD CONSTRAINT `ForeignKey_ProductID1` FOREIGN KEY (`Product1`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID10` FOREIGN KEY (`Product10`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID2` FOREIGN KEY (`Product2`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID3` FOREIGN KEY (`Product3`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID4` FOREIGN KEY (`Product4`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID5` FOREIGN KEY (`Product5`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID6` FOREIGN KEY (`Product6`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID7` FOREIGN KEY (`Product7`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID8` FOREIGN KEY (`Product8`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_ProductID9` FOREIGN KEY (`Product9`) REFERENCES `product` (`ProductID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `ForeignKey_Session` FOREIGN KEY (`SessionID`) REFERENCES `session` (`Session`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_StaffID_D` FOREIGN KEY (`D_staffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_StaffID_D1` FOREIGN KEY (`D_staff2ID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_StaffID_I1` FOREIGN KEY (`I_staffID`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ForeignKey_StaffID_I2` FOREIGN KEY (`I_staffID2`) REFERENCES `staff` (`StaffID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `ForeignKey_DepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`DepartmentID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
