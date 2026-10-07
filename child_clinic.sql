-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 07, 2026 at 05:45 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `child_clinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance_records`
--

CREATE TABLE `attendance_records` (
  `id` int(11) NOT NULL,
  `child_id` int(11) DEFAULT NULL,
  `attendance_date` date DEFAULT NULL,
  `attendance_status` varchar(20) DEFAULT NULL,
  `notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `attendance_records`
--

INSERT INTO `attendance_records` (`id`, `child_id`, `attendance_date`, `attendance_status`, `notes`) VALUES
(1, 1, '2026-06-01', 'Present', 'Attended clinic visit'),
(2, 2, '2026-06-01', 'Present', 'Attended clinic visit'),
(3, 3, '2026-06-01', 'Absent', 'Did not attend clinic'),
(4, 4, '2026-06-01', 'Present', 'Growth monitoring completed'),
(5, 5, '2026-06-01', 'Present', 'Received nutrition supplements'),
(6, 6, '2026-06-02', 'Present', 'Routine clinic visit'),
(7, 7, '2026-06-02', 'Absent', 'Parent informed absence'),
(8, 8, '2026-06-02', 'Present', 'Vaccination completed'),
(9, 9, '2026-06-02', 'Present', 'Weight and height recorded'),
(10, 10, '2026-06-02', 'Present', 'Routine checkup'),
(11, 11, '2026-06-03', 'Present', 'Clinic attendance recorded'),
(12, 12, '2026-06-03', 'Absent', 'Missed appointment'),
(13, 13, '2026-06-03', 'Present', 'Nutrition monitoring completed'),
(14, 14, '2026-06-03', 'Present', 'Growth tracking updated'),
(15, 15, '2026-06-03', 'Present', 'Received Thriposha'),
(16, 16, '2026-06-04', 'Present', 'Routine clinic visit'),
(17, 17, '2026-06-04', 'Present', 'Vaccination follow-up'),
(18, 18, '2026-06-04', 'Absent', 'Not attended'),
(19, 19, '2026-06-04', 'Present', 'Weight measurement recorded'),
(20, 20, '2026-06-04', 'Present', 'Health check completed'),
(21, 1, '2026-01-10', 'Present', 'Routine clinic visit'),
(22, 2, '2026-01-15', 'Present', 'Vaccination completed'),
(23, 3, '2026-02-05', 'Absent', 'Missed clinic appointment'),
(24, 4, '2026-02-12', 'Present', 'Growth monitoring completed'),
(25, 5, '2026-02-20', 'Present', 'Received nutrition supplements'),
(26, 6, '2026-03-03', 'Present', 'Routine clinic visit'),
(27, 7, '2026-03-10', 'Absent', 'Parent informed absence'),
(28, 8, '2026-03-15', 'Present', 'Vaccination completed'),
(29, 9, '2026-03-22', 'Present', 'Weight and height recorded'),
(30, 10, '2026-04-02', 'Present', 'Routine health check'),
(31, 11, '2026-04-08', 'Present', 'Clinic attendance recorded'),
(32, 12, '2026-04-18', 'Absent', 'Missed appointment'),
(33, 13, '2026-04-25', 'Present', 'Nutrition monitoring completed'),
(34, 14, '2026-05-05', 'Present', 'Growth tracking updated'),
(35, 15, '2026-05-12', 'Present', 'Received Thriposha'),
(36, 16, '2026-05-20', 'Present', 'Routine clinic visit'),
(37, 17, '2026-06-01', 'Present', 'Vaccination follow-up'),
(38, 18, '2026-06-08', 'Absent', 'Did not attend clinic'),
(39, 19, '2026-06-15', 'Present', 'Weight measurement recorded'),
(40, 20, '2026-06-22', 'Present', 'Health check completed'),
(43, 1, '2026-06-23', 'present', ''),
(44, 7, '2026-06-23', 'present', ''),
(45, 12, '2026-06-23', 'present', ''),
(46, 17, '2026-06-23', 'present', ''),
(49, 1, '2026-06-24', 'present', ''),
(50, 3, '2026-06-24', 'present', ''),
(51, 9, '2026-06-24', 'present', ''),
(52, 15, '2026-06-24', 'present', ''),
(53, 7, '2026-06-24', 'present', ''),
(54, 8, '2026-06-24', 'present', ''),
(56, 20, '2026-06-24', 'present', 'aa');

-- --------------------------------------------------------

--
-- Table structure for table `babies`
--

CREATE TABLE `babies` (
  `id` int(11) NOT NULL,
  `child_id` varchar(20) DEFAULT NULL,
  `full_name` varchar(100) NOT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `mother_id` int(11) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `blood_group` varchar(10) DEFAULT NULL,
  `birth_weight` decimal(5,2) DEFAULT NULL,
  `registration_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `babies`
--

INSERT INTO `babies` (`id`, `child_id`, `full_name`, `gender`, `age`, `mother_id`, `date_of_birth`, `address`, `blood_group`, `birth_weight`, `registration_date`) VALUES
(1, 'CHD-000001', 'Nethmi Perera', 'Female', 2, 1, '2024-03-15', 'Attidiya, Nugegoda', 'A+', 3.10, '2026-01-09 18:30:00'),
(2, 'CHD-000002', 'Senuja Silva', 'Male', 1, 2, '2025-02-10', 'Udahamulla, Nugegoda', 'B+', 3.40, '2026-01-10 18:30:00'),
(3, 'CHD-000003', 'Dinuka Jayasuriya', 'Male', 3, 3, '2023-05-20', 'Gangodawila, Nugegoda', 'O+', 3.00, '2026-01-11 18:30:00'),
(4, 'CHD-000004', 'Yehansa Wickramasinghe', 'Female', 4, 4, '2022-08-11', 'Kalubowila, Nugegoda', 'AB+', 3.20, '2026-01-12 18:30:00'),
(5, 'CHD-000005', 'Minuri Fernando', 'Female', 1, 5, '2025-01-18', 'Kohuwala, Nugegoda', 'A-', 2.90, '2026-01-13 18:30:00'),
(6, 'CHD-000006', 'Kavindu Perera', 'Male', 5, 6, '2021-11-05', 'Delkanda, Nugegoda', 'B-', 3.50, '2026-01-14 18:30:00'),
(7, 'CHD-000007', 'Sathnidu Silva', 'Male', 2, 7, '2024-02-28', 'Mirihana, Nugegoda', 'O-', 3.00, '2026-01-15 18:30:00'),
(8, 'CHD-000008', 'Tharushi Gunawardena', 'Female', 3, 8, '2023-04-12', 'Embuldeniya, Nugegoda', 'A+', 3.10, '2026-01-16 18:30:00'),
(9, 'CHD-000009', 'Methuli Senanayake', 'Female', 2, 9, '2024-06-22', 'Attidiya, Nugegoda', 'B+', 3.30, '2026-01-17 18:30:00'),
(10, 'CHD-000010', 'Dulneth Perera', 'Male', 4, 10, '2022-10-15', 'Udahamulla, Nugegoda', 'AB-', 3.40, '2026-01-18 18:30:00'),
(11, 'CHD-000011', 'Pabasara Silva', 'Female', 1, 11, '2025-03-01', 'Gangodawila, Nugegoda', 'O+', 2.80, '2026-01-19 18:30:00'),
(12, 'CHD-000012', 'Senuka Perera', 'Male', 3, 12, '2023-07-08', 'Kalubowila, Nugegoda', 'A+', 3.20, '2026-01-20 18:30:00'),
(13, 'CHD-000013', 'Savindi Fernando', 'Female', 2, 13, '2024-01-14', 'Kohuwala, Nugegoda', 'B+', 3.10, '2026-01-21 18:30:00'),
(14, 'CHD-000014', 'Nimnadi Jayawardena', 'Female', 5, 14, '2021-09-09', 'Delkanda, Nugegoda', 'O+', 3.60, '2026-01-22 18:30:00'),
(15, 'CHD-000015', 'Ovin Silva', 'Male', 4, 15, '2022-04-25', 'Mirihana, Nugegoda', 'A-', 3.30, '2026-01-23 18:30:00'),
(16, 'CHD-000016', 'Hiruni Perera', 'Female', 2, 16, '2024-05-30', 'Embuldeniya, Nugegoda', 'B-', 3.00, '2026-01-24 18:30:00'),
(17, 'CHD-000017', 'Vihanga Silva', 'Male', 1, 17, '2025-04-12', 'Attidiya, Nugegoda', 'AB+', 2.90, '2026-01-25 18:30:00'),
(18, 'CHD-000018', 'Nethara Perera', 'Female', 3, 18, '2023-03-18', 'Udahamulla, Nugegoda', 'O-', 3.20, '2026-01-26 18:30:00'),
(19, 'CHD-000019', 'Dinesh Fernando', 'Male', 2, 19, '2024-07-10', 'Gangodawila, Nugegoda', 'A+', 3.10, '2026-01-27 18:30:00'),
(20, 'CHD-000020', 'Akenya Silva', 'Female', 1, 20, '2025-05-05', 'Kalubowila, Nugegoda', 'B+', 3.00, '2026-01-28 18:30:00'),
(21, 'CHD-000021', 'malsha', 'Female', 29, 21, '2026-05-26', 'aaa', 'B-', 2.00, '2026-06-24 11:14:22');

-- --------------------------------------------------------

--
-- Table structure for table `mothers`
--

CREATE TABLE `mothers` (
  `id` int(11) NOT NULL,
  `full_name` varchar(100) DEFAULT NULL,
  `nic` varchar(20) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `address` text DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `blood_group` varchar(10) DEFAULT NULL,
  `medical_condition` text DEFAULT NULL,
  `allergies` text DEFAULT NULL,
  `emergency_contact_person` varchar(100) DEFAULT NULL,
  `emergency_contact_number` varchar(20) DEFAULT NULL,
  `pregnancy_status` varchar(10) DEFAULT NULL,
  `pregnancy_month` varchar(20) DEFAULT NULL,
  `expected_delivery_date` date DEFAULT NULL,
  `doctor_name` varchar(100) DEFAULT NULL,
  `registration_date` date DEFAULT NULL,
  `notes` text DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `mothers`
--

INSERT INTO `mothers` (`id`, `full_name`, `nic`, `dob`, `age`, `address`, `phone`, `blood_group`, `medical_condition`, `allergies`, `emergency_contact_person`, `emergency_contact_number`, `pregnancy_status`, `pregnancy_month`, `expected_delivery_date`, `doctor_name`, `registration_date`, `notes`, `created_at`) VALUES
(2, 'Kumari Silva', '928765432V', '1992-08-20', 34, 'Udahamulla, Nugegoda', '0712345679', 'B+', 'Asthma', 'Dust', 'Nimal Silva', '0771234568', 'Yes', '5', '2026-10-15', 'Dr. Fernando', '2026-01-11', 'Regular checkup', '2026-06-23 00:06:56'),
(3, 'Dilani Jayasuriya', '945678901V', '1994-02-15', 32, 'Gangodawila, Nugegoda', '0712345680', 'O+', 'None', 'None', 'Ajith Jayasuriya', '0771234569', 'No', '', '2026-06-23', '', '2026-06-23', 'No issues', '2026-06-23 00:06:56'),
(4, 'Chamari Wickramasinghe', '935678902V', '1993-09-10', 33, 'Kalubowila, Nugegoda', '0712345681', 'AB+', 'Diabetes', 'None', 'Ruwan Wickramasinghe', '0771234570', 'Yes', '7', '2026-08-20', 'Dr. Silva', '2026-01-13', 'Monitoring sugar levels', '2026-06-23 00:06:56'),
(5, 'Tharushi Fernando', '965678903V', '1996-03-18', 30, 'Kohuwala, Nugegoda', '0712345682', 'A-', 'None', 'Peanuts', 'Saman Fernando', '0771234571', 'No', '', '2026-06-23', '', '2026-06-23', 'Healthy', '2026-06-23 00:06:56'),
(6, 'Sanduni Perera', '975678904V', '1997-06-25', 29, 'Delkanda, Nugegoda', '0712345683', 'B-', 'None', 'None', 'Lalith Perera', '0771234572', 'Yes', '4', '2026-11-10', 'Dr. Perera', '2026-01-15', 'Prenatal care', '2026-06-23 00:06:56'),
(7, 'Ishara Silva', '905678905V', '1990-11-30', 35, 'Mirihana, Nugegoda', '0712345684', 'O-', 'Hypertension', 'None', 'Ranjith Silva', '0771234573', 'No', '', '2026-06-23', '', '2026-06-23', 'Blood pressure monitoring', '2026-06-23 00:06:56'),
(8, 'Nirosha Gunawardena', '985678906V', '1998-04-05', 28, 'Embuldeniya, Nugegoda', '0712345685', 'A+', 'None', 'Seafood', 'Mahesh Gunawardena', '0771234574', 'Yes', '6', '2026-09-25', 'Dr. Jayasinghe', '2026-01-17', 'Routine visit', '2026-06-23 00:06:56'),
(9, 'Hashini Senanayake', '945678907V', '1994-12-12', 31, 'Attidiya, Nugegoda', '0712345686', 'B+', 'None', 'None', 'Kasun Senanayake', '0771234575', 'No', NULL, NULL, NULL, '2026-01-18', 'Healthy', '2026-06-23 00:06:56'),
(10, 'Madhavi Perera', '955678908V', '1995-07-21', 31, 'Udahamulla, Nugegoda', '0712345687', 'AB-', 'Anemia', 'None', 'Chathura Perera', '0771234576', 'Yes', '8', '2026-07-30', 'Dr. Fernando', '2026-01-19', 'Iron supplements', '2026-06-23 00:06:56'),
(11, 'Upeksha Silva', '965678909V', '1996-01-15', 30, 'Gangodawila, Nugegoda', '0712345688', 'O+', 'None', 'None', 'Suresh Silva', '0771234577', 'No', NULL, NULL, NULL, '2026-01-20', 'Healthy', '2026-06-23 00:06:56'),
(12, 'Sachini Perera', '975678910V', '1997-05-17', 29, 'Kalubowila, Nugegoda', '0712345689', 'A+', 'None', 'Pollen', 'Kamal Perera', '0771234578', 'Yes', '3', '2026-12-01', 'Dr. Silva', '2026-01-21', 'Routine checkup', '2026-06-23 00:06:56'),
(13, 'Piumi Fernando', '985678911V', '1998-08-08', 28, 'Kohuwala, Nugegoda', '0712345690', 'B+', 'None', 'None', 'Nuwan Fernando', '0771234579', 'No', NULL, NULL, NULL, '2026-01-22', 'Healthy', '2026-06-23 00:06:56'),
(14, 'Anusha Jayawardena', '925678912V', '1992-02-02', 34, 'Delkanda, Nugegoda', '0712345691', 'O+', 'Diabetes', 'None', 'Ramesh Jayawardena', '0771234580', 'Yes', '5', '2026-10-05', 'Dr. Perera', '2026-01-23', 'Regular monitoring', '2026-06-23 00:06:56'),
(15, 'Kanchana Silva', '935678913V', '1993-03-13', 33, 'Mirihana, Nugegoda', '0712345692', 'A-', 'None', 'None', 'Sanjaya Silva', '0771234581', 'No', NULL, NULL, NULL, '2026-01-24', 'Healthy', '2026-06-23 00:06:56'),
(16, 'Ruwani Perera', '945678914V', '1994-09-09', 32, 'Embuldeniya, Nugegoda', '0712345693', 'B-', 'None', 'Milk', 'Pradeep Perera', '0771234582', 'Yes', '6', '2026-09-15', 'Dr. Fernando', '2026-01-25', 'Prenatal care', '2026-06-23 00:06:56'),
(17, 'Dilhani Silva', '955678915V', '1995-10-10', 31, 'Attidiya, Nugegoda', '0712345694', 'AB+', 'None', 'None', 'Roshan Silva', '0771234583', 'No', NULL, NULL, NULL, '2026-01-26', 'Healthy', '2026-06-23 00:06:56'),
(18, 'Shashika Perera', '965678916V', '1996-06-06', 30, 'Udahamulla, Nugegoda', '0712345695', 'O-', 'Hypertension', 'None', 'Anura Perera', '0771234584', 'Yes', '7', '2026-08-10', 'Dr. Jayasinghe', '2026-01-27', 'Monitoring BP', '2026-06-23 00:06:56'),
(19, 'Niluka Fernando', '975678917V', '1997-07-07', 29, 'Gangodawila, Nugegoda', '0712345696', 'A+', 'None', 'None', 'Sampath Fernando', '0771234585', 'No', NULL, NULL, NULL, '2026-01-28', 'Healthy', '2026-06-23 00:06:56'),
(20, 'Harshani Silva', '985678918V', '1998-11-11', 28, 'Kalubowila, Nugegoda', '0712345697', 'B+', 'None', 'Dust', 'Nalin Silva', '0771234586', 'Yes', '4', '2026-11-20', 'Dr. Perera', '2026-01-29', 'Routine checkup', '2026-06-23 00:06:56'),
(21, 'Aliya Sonali', '974563341V', '1997-06-11', 29, 'Delkada, Nugegoda', '0756645432', 'B+', 'good', 'No', 'Saman Perera', '0756645432', 'No', '', '2026-06-23', '', '2026-06-23', '', '2026-06-23 00:27:24');

-- --------------------------------------------------------

--
-- Table structure for table `nutrition_records`
--

CREATE TABLE `nutrition_records` (
  `id` int(11) NOT NULL,
  `child_id` int(11) DEFAULT NULL,
  `nutrition_name` varchar(255) DEFAULT NULL,
  `nutrition_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `nutrition_records`
--

INSERT INTO `nutrition_records` (`id`, `child_id`, `nutrition_name`, `nutrition_date`) VALUES
(1, 1, 'Thriposha', '2026-01-10'),
(2, 2, 'Vitamin A', '2026-01-15'),
(3, 4, 'Thriposha', '2026-02-12'),
(4, 5, 'Iron Supplement', '2026-02-20'),
(5, 6, 'Thriposha', '2026-03-03'),
(6, 8, 'Vitamin A', '2026-03-15'),
(7, 9, 'Thriposha', '2026-03-22'),
(8, 10, 'Iron Supplement', '2026-04-02'),
(9, 11, 'Vitamin A', '2026-04-08'),
(10, 13, 'Thriposha', '2026-04-25'),
(11, 14, 'Iron Supplement', '2026-05-05'),
(12, 15, 'Thriposha', '2026-05-12'),
(13, 16, 'Vitamin A', '2026-05-20'),
(14, 17, 'Thriposha', '2026-06-01'),
(15, 19, 'Iron Supplement', '2026-06-15'),
(16, 20, 'Vitamin A', '2026-06-22'),
(17, 1, 'Vitamin A', '2026-03-10'),
(18, 6, 'Iron Supplement', '2026-04-15'),
(19, 11, 'Thriposha', '2026-05-18'),
(20, 16, 'Vitamin A', '2026-06-20'),
(21, 1, 'Iron Supplement', '2026-04-10'),
(22, 1, 'Thriposha', '2026-06-10'),
(23, 2, 'Thriposha', '2026-03-15'),
(24, 2, 'Iron Supplement', '2026-05-15'),
(25, 4, 'Vitamin A', '2026-04-12'),
(26, 4, 'Thriposha', '2026-06-12'),
(27, 5, 'Vitamin A', '2026-04-20'),
(28, 5, 'Thriposha', '2026-06-20'),
(29, 6, 'Vitamin A', '2026-05-03'),
(30, 6, 'Thriposha', '2026-06-03'),
(31, 8, 'Iron Supplement', '2026-05-15'),
(32, 8, 'Thriposha', '2026-06-15'),
(33, 9, 'Vitamin A', '2026-05-22'),
(34, 9, 'Iron Supplement', '2026-06-22'),
(35, 10, 'Thriposha', '2026-05-02'),
(36, 10, 'Vitamin A', '2026-06-02'),
(37, 11, 'Iron Supplement', '2026-05-08'),
(38, 11, 'Vitamin A', '2026-06-08'),
(39, 13, 'Vitamin A', '2026-05-25'),
(40, 13, 'Iron Supplement', '2026-06-25'),
(41, 14, 'Thriposha', '2026-06-05'),
(42, 15, 'Vitamin A', '2026-06-12'),
(43, 16, 'Iron Supplement', '2026-06-20'),
(44, 17, 'Vitamin A', '2026-07-01'),
(45, 19, 'Thriposha', '2026-07-15'),
(46, 20, 'Iron Supplement', '2026-07-22'),
(47, 21, 'ttt', '2026-06-23'),
(48, 21, 'aaaaa', '2026-06-27'),
(49, 21, 'aaa', '2026-06-24'),
(50, 21, 'aaa aa', '2026-06-10'),
(51, 20, 'aaa', '2026-06-02');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `designation` varchar(50) DEFAULT NULL,
  `nic` varchar(12) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `password_hash` varchar(256) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `full_name`, `designation`, `nic`, `gender`, `password_hash`, `created_at`) VALUES
(1, 'kamal', 'kamal Silva', 'Doctor', '898767754V', 'Male', '0ffe1abd1a08215353c233d6e009613e95eec4253832a761af28ff37ac5a150c', '2026-06-22 23:55:39'),
(2, 'q', 'q', 'Nurse', '976765434V', 'Female', '8e35c2cd3bf6641bdb0e2050b76932cbb2e6034a0ddacc1d9bea82a6ba57f7cf', '2026-06-22 23:56:08'),
(14, 'Aysh', 'Aysh', 'Nurse', '975050041V', 'Female', '0ffe1abd1a08215353c233d6e009613e95eec4253832a761af28ff37ac5a150c', '2026-06-24 16:39:48');

-- --------------------------------------------------------

--
-- Table structure for table `vaccination_records`
--

CREATE TABLE `vaccination_records` (
  `id` int(11) NOT NULL,
  `child_id` int(11) DEFAULT NULL,
  `vaccination_details` varchar(255) DEFAULT NULL,
  `vaccination_date` date DEFAULT NULL,
  `next_vaccine_name` varchar(255) DEFAULT NULL,
  `next_vaccine_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `vaccination_records`
--

INSERT INTO `vaccination_records` (`id`, `child_id`, `vaccination_details`, `vaccination_date`, `next_vaccine_name`, `next_vaccine_date`) VALUES
(1, 1, 'BCG', '2024-03-20', 'Pentavalent 1', '2024-05-20'),
(2, 1, 'Pentavalent 1', '2024-05-20', 'Pentavalent 2', '2024-07-20'),
(3, 2, 'BCG', '2025-02-15', 'Pentavalent 1', '2025-04-15'),
(4, 2, 'Pentavalent 1', '2025-04-15', 'Pentavalent 2', '2025-06-15'),
(5, 3, 'BCG', '2023-05-25', 'Pentavalent 1', '2023-07-25'),
(6, 3, 'Pentavalent 1', '2023-07-25', 'MMR', '2024-05-25'),
(7, 4, 'BCG', '2022-08-15', 'Pentavalent 1', '2022-10-15'),
(8, 4, 'MMR', '2023-08-15', 'Booster Dose', '2026-07-15'),
(9, 5, 'BCG', '2025-01-25', 'Pentavalent 1', '2025-03-25'),
(10, 5, 'Pentavalent 1', '2025-03-25', 'Pentavalent 2', '2025-05-25'),
(11, 6, 'BCG', '2021-11-10', 'Pentavalent 1', '2022-01-10'),
(12, 6, 'MMR', '2022-11-10', 'Booster Dose', '2026-08-10'),
(13, 7, 'BCG', '2024-03-05', 'Pentavalent 1', '2024-05-05'),
(14, 7, 'Pentavalent 1', '2024-05-05', 'Pentavalent 2', '2024-07-05'),
(15, 8, 'BCG', '2023-04-20', 'Pentavalent 1', '2023-06-20'),
(16, 8, 'MMR', '2024-04-20', 'Booster Dose', '2026-07-20'),
(17, 9, 'BCG', '2024-06-25', 'Pentavalent 1', '2024-08-25'),
(18, 9, 'Pentavalent 1', '2024-08-25', 'Pentavalent 2', '2024-10-25'),
(19, 10, 'BCG', '2022-10-20', 'Pentavalent 1', '2022-12-20'),
(20, 10, 'MMR', '2023-10-20', 'Booster Dose', '2026-08-20'),
(21, 11, 'BCG', '2025-03-05', 'Pentavalent 1', '2025-05-05'),
(22, 11, 'Pentavalent 1', '2025-05-05', 'Pentavalent 2', '2025-07-05'),
(23, 12, 'BCG', '2023-07-15', 'Pentavalent 1', '2023-09-15'),
(24, 12, 'MMR', '2024-07-15', 'Booster Dose', '2026-09-15'),
(25, 13, 'BCG', '2024-01-20', 'Pentavalent 1', '2024-03-20'),
(26, 13, 'Pentavalent 1', '2024-03-20', 'Pentavalent 2', '2024-05-20'),
(27, 14, 'BCG', '2021-09-15', 'Pentavalent 1', '2021-11-15'),
(28, 14, 'MMR', '2022-09-15', 'Booster Dose', '2026-10-15'),
(29, 15, 'BCG', '2022-05-01', 'Pentavalent 1', '2022-07-01'),
(30, 15, 'MMR', '2023-05-01', 'Booster Dose', '2026-08-01'),
(31, 16, 'BCG', '2024-06-05', 'Pentavalent 1', '2024-08-05'),
(32, 16, 'Pentavalent 1', '2024-08-05', 'Pentavalent 2', '2024-10-05'),
(33, 17, 'BCG', '2025-04-18', 'Pentavalent 1', '2025-06-18'),
(34, 17, 'Pentavalent 1', '2025-06-18', 'Pentavalent 2', '2025-08-18'),
(35, 18, 'BCG', '2023-03-25', 'Pentavalent 1', '2023-05-25'),
(36, 18, 'MMR', '2024-03-25', 'Booster Dose', '2026-09-25'),
(37, 19, 'BCG', '2024-07-15', 'Pentavalent 1', '2024-09-15'),
(38, 19, 'Pentavalent 1', '2024-09-15', 'Pentavalent 2', '2024-11-15'),
(39, 20, 'BCG', '2025-05-10', 'Pentavalent 1', '2025-07-10'),
(40, 20, 'Pentavalent 1', '2025-07-10', 'Pentavalent 2', '2025-09-10'),
(41, 1, 'Pentavalent 2', '2026-06-10', 'MMR', '2026-06-24'),
(42, 2, 'Pentavalent 2', '2026-06-12', 'MMR', '2026-06-25'),
(43, 3, 'Pentavalent 2', '2026-06-14', 'MMR', '2026-06-26'),
(44, 4, 'Pentavalent 2', '2026-06-15', 'MMR', '2026-06-27'),
(45, 5, 'Pentavalent 2', '2026-06-16', 'MMR', '2026-06-28'),
(46, 6, 'MMR', '2026-06-10', 'Booster Dose', '2026-06-29'),
(47, 7, 'MMR', '2026-06-11', 'Booster Dose', '2026-06-30'),
(48, 8, 'MMR', '2026-06-12', 'Booster Dose', '2026-07-01'),
(49, 9, 'MMR', '2026-06-13', 'Booster Dose', '2026-07-02'),
(50, 10, 'MMR', '2026-06-14', 'Booster Dose', '2026-07-03'),
(51, 21, 'aa', '2026-06-23', 'bbb', '2026-06-28'),
(52, 21, 'aaa', '2026-06-23', 'aaaa', '2026-06-20'),
(53, 21, 'aaa ', '2026-06-24', 'aaaa', '2026-06-27'),
(54, 21, 'aaaa', '2026-06-24', 'aaa', '2026-06-27'),
(55, 20, 'aaa', '2026-06-24', 'bbb', '2026-06-21');

-- --------------------------------------------------------

--
-- Table structure for table `weight_tracking`
--

CREATE TABLE `weight_tracking` (
  `id` int(11) NOT NULL,
  `child_id` int(11) DEFAULT NULL,
  `weight` decimal(5,2) DEFAULT NULL,
  `height` decimal(5,2) DEFAULT NULL,
  `bmi` decimal(5,2) DEFAULT NULL,
  `recorded_date` date DEFAULT NULL,
  `created_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `weight_tracking`
--

INSERT INTO `weight_tracking` (`id`, `child_id`, `weight`, `height`, `bmi`, `recorded_date`, `created_date`) VALUES
(1, 1, 9.50, 0.90, 11.70, '2026-01-10', '2026-06-22 18:46:11'),
(2, 1, 10.00, 0.92, 11.80, '2026-04-10', '2026-06-22 18:46:11'),
(3, 2, 10.50, 0.95, 11.60, '2026-01-15', '2026-06-22 18:46:11'),
(4, 2, 11.00, 0.98, 11.50, '2026-05-15', '2026-06-22 18:46:11'),
(5, 3, 12.00, 1.00, 12.00, '2026-02-05', '2026-06-22 18:46:11'),
(6, 4, 13.00, 1.05, 11.80, '2026-02-12', '2026-06-22 18:46:11'),
(7, 5, 11.50, 0.95, 12.70, '2026-02-20', '2026-06-22 18:46:11'),
(8, 6, 15.00, 1.00, 15.00, '2026-03-03', '2026-06-22 18:46:11'),
(9, 6, 16.00, 1.03, 15.10, '2026-06-03', '2026-06-22 18:46:11'),
(10, 7, 16.00, 1.05, 14.50, '2026-03-10', '2026-06-22 18:46:11'),
(11, 8, 17.00, 1.08, 14.60, '2026-03-15', '2026-06-22 18:46:11'),
(12, 8, 18.00, 1.10, 14.90, '2026-06-15', '2026-06-22 18:46:11'),
(13, 9, 18.00, 1.10, 14.90, '2026-03-22', '2026-06-22 18:46:11'),
(14, 10, 19.00, 1.12, 15.10, '2026-04-02', '2026-06-22 18:46:11'),
(15, 11, 20.00, 1.15, 15.10, '2026-04-08', '2026-06-22 18:46:11'),
(16, 12, 21.00, 1.18, 15.10, '2026-04-18', '2026-06-22 18:46:11'),
(17, 13, 23.00, 1.15, 17.40, '2026-04-25', '2026-06-22 18:46:11'),
(18, 13, 24.00, 1.16, 17.80, '2026-06-25', '2026-06-22 18:46:11'),
(19, 14, 24.00, 1.18, 17.20, '2026-05-05', '2026-06-22 18:46:11'),
(20, 15, 25.00, 1.20, 17.40, '2026-05-12', '2026-06-22 18:46:11'),
(21, 16, 26.00, 1.22, 17.50, '2026-05-20', '2026-06-22 18:46:11'),
(22, 17, 30.00, 1.20, 20.80, '2026-06-01', '2026-06-22 18:46:11'),
(23, 17, 31.00, 1.21, 21.20, '2026-07-01', '2026-06-22 18:46:11'),
(24, 18, 32.00, 1.22, 21.50, '2026-06-08', '2026-06-22 18:46:11'),
(25, 19, 34.00, 1.25, 21.80, '2026-06-15', '2026-06-22 18:46:11'),
(41, 21, 4.00, 55.00, 13.22, '2026-06-24', '2026-06-24 05:32:29'),
(42, 21, 5.00, 59.00, 14.36, '2026-06-25', '2026-06-24 05:33:01'),
(43, 21, 6.00, 59.00, 17.24, '2026-06-26', '2026-06-24 05:33:14'),
(44, 21, 10.00, 60.00, 27.78, '2026-06-27', '2026-06-24 05:33:32'),
(46, 20, 4.00, 55.00, 13.22, '2026-07-02', '2026-06-24 09:54:52'),
(47, 20, 4.00, 55.00, 13.22, '2026-07-10', '2026-06-24 09:55:05'),
(48, 20, 5.00, 59.00, 14.36, '2026-07-11', '2026-06-24 09:55:16'),
(49, 20, 6.00, 60.00, 16.67, '2026-07-31', '2026-06-24 09:55:31'),
(50, 21, 4.00, 55.00, 13.22, '2026-06-28', '2026-06-24 11:15:56'),
(51, 21, 5.00, 59.00, 14.36, '2026-06-29', '2026-06-24 11:16:08'),
(52, 21, 6.00, 59.00, 17.24, '2026-07-01', '2026-06-24 11:16:32');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance_records`
--
ALTER TABLE `attendance_records`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `babies`
--
ALTER TABLE `babies`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `child_id` (`child_id`);

--
-- Indexes for table `mothers`
--
ALTER TABLE `mothers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nutrition_records`
--
ALTER TABLE `nutrition_records`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `nic` (`nic`);

--
-- Indexes for table `vaccination_records`
--
ALTER TABLE `vaccination_records`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `weight_tracking`
--
ALTER TABLE `weight_tracking`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance_records`
--
ALTER TABLE `attendance_records`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `babies`
--
ALTER TABLE `babies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `mothers`
--
ALTER TABLE `mothers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `nutrition_records`
--
ALTER TABLE `nutrition_records`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `vaccination_records`
--
ALTER TABLE `vaccination_records`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT for table `weight_tracking`
--
ALTER TABLE `weight_tracking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
