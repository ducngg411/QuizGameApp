-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2024 at 05:45 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gamenew2024`
--

-- --------------------------------------------------------

--
-- Table structure for table `answer`
--

CREATE TABLE `answer` (
  `AnswerID` int(11) NOT NULL,
  `AnswerText` text NOT NULL,
  `IsCorrect` tinyint(1) DEFAULT 0,
  `QuestionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `game`
--

CREATE TABLE `game` (
  `GameID` int(11) NOT NULL,
  `GameName` varchar(100) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  `QuestionCount` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `game`
--

INSERT INTO `game` (`GameID`, `GameName`, `Description`, `CreatedAt`, `CreatedBy`, `QuestionCount`) VALUES
(1, 'Hello', 'Parker\r\nWord', '2024-11-11 11:03:11', 1, 16),
(4, 'Peter', 'Parker\r\n', '2024-11-11 15:51:22', 1, 0),
(8, 'Peter', 'Parker\r\n', '2024-11-11 17:37:34', 1, 0),
(10, 'DatDepTRai', '123', '2024-11-13 08:19:17', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `QuestionID` int(11) NOT NULL,
  `GameID` int(11) NOT NULL,
  `QuestionText` text NOT NULL,
  `QuestionType` enum('Multiple choice question','True false question','Open-ended question') NOT NULL,
  `AvailableAnswer` varchar(500) NOT NULL,
  `CorrectAnswer` varchar(255) DEFAULT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `UpdatedAt` datetime DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `question`
--

INSERT INTO `question` (`QuestionID`, `GameID`, `QuestionText`, `QuestionType`, `AvailableAnswer`, `CorrectAnswer`, `CreatedAt`, `UpdatedAt`) VALUES
(14, 1, '123', 'True false question', '', 'TRUE', '2024-11-11 18:51:15', NULL),
(16, 1, 'What is the largest continent on Earth?', 'Multiple choice question', '', 'Asia', '2024-11-13 09:43:27', NULL),
(17, 1, 'Which country has the longest coastline?', 'Multiple choice question', '', 'Canada', '2024-11-13 09:43:27', NULL),
(18, 1, 'What is the smallest country in the world?', 'Open-ended question', '', 'Vatican City', '2024-11-13 09:43:27', NULL),
(19, 1, 'What river is the longest in the world?', 'Multiple choice question', '', 'Nile', '2024-11-13 09:43:27', NULL),
(20, 1, 'What is the capital city of Australia?', 'Open-ended question', '', 'Canberra', '2024-11-13 09:43:27', NULL),
(21, 1, 'In which country is Mount Everest located?', 'Multiple choice question', '', 'Nepal', '2024-11-13 09:43:27', NULL),
(22, 1, 'Which desert is the largest in the world?', 'Open-ended question', '', 'Sahara Desert', '2024-11-13 09:43:27', NULL),
(23, 1, 'What is the world’s largest ocean?', 'Multiple choice question', '', 'Pacific Ocean', '2024-11-13 09:43:27', NULL),
(24, 1, 'Which U.S. state is the Grand Canyon located in?', 'Open-ended question', '', 'Arizona', '2024-11-13 09:43:27', NULL),
(25, 1, 'Is Venice known as the City of Canals?', 'True false question', '', 'TRUE', '2024-11-13 09:43:27', NULL),
(26, 1, 'Is it a apple?', 'True false question', '', 'TRUE', '2024-11-13 09:53:38', NULL),
(27, 1, '123', 'Open-ended question', '', '1||2||3', '2024-11-13 10:07:24', NULL),
(28, 1, '123', 'Open-ended question', '', '1||2', '2024-11-13 10:07:44', NULL),
(29, 1, '123', 'True false question', 'TRUE||FALSE', 'TRUE', '2024-11-13 10:21:21', NULL),
(30, 1, 'Dat co dep trai khong ', 'Multiple choice question', 'qua dep trai la qua dep trai ||co ||depp trai nhat vn ||trong dep trai ', 'qua dep trai la qua dep trai ', '2024-11-13 10:28:14', NULL);

--
-- Triggers `question`
--
DELIMITER $$
CREATE TRIGGER `decrement_question_count` AFTER DELETE ON `question` FOR EACH ROW BEGIN
    UPDATE game
    SET QuestionCount = QuestionCount - 1
    WHERE GameID = OLD.GameID;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `increment_question_count` AFTER INSERT ON `question` FOR EACH ROW BEGIN
    UPDATE game
    SET QuestionCount = QuestionCount + 1
    WHERE GameID = NEW.GameID;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `result`
--

CREATE TABLE `result` (
  `ResultID` int(11) NOT NULL,
  `GameID` int(11) DEFAULT NULL,
  `UserID` int(11) DEFAULT NULL,
  `Score` int(11) DEFAULT 0,
  `TimeSpent` time DEFAULT '00:00:00',
  `PlayDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `EmailAddress` varchar(100) DEFAULT NULL,
  `Role` tinyint(1) DEFAULT 0,
  `Score` int(11) DEFAULT 0,
  `PlayTime` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserID`, `UserName`, `Password`, `EmailAddress`, `Role`, `Score`, `PlayTime`) VALUES
(1, 'ducngg411', 'Ducham2004', 'dat723278@gmail.com', 1, 0, '00:00:00'),
(2, 'peterparker', 'Ducham2004', 'truykich6a3@gmail.com', 0, 0, '00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `answer`
--
ALTER TABLE `answer`
  ADD PRIMARY KEY (`AnswerID`),
  ADD KEY `QuestionID` (`QuestionID`);

--
-- Indexes for table `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`GameID`),
  ADD KEY `CreatedBy` (`CreatedBy`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`QuestionID`),
  ADD KEY `GameID` (`GameID`);

--
-- Indexes for table `result`
--
ALTER TABLE `result`
  ADD PRIMARY KEY (`ResultID`),
  ADD KEY `fk_gameid` (`GameID`),
  ADD KEY `fk_userid` (`UserID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `UserName` (`UserName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `answer`
--
ALTER TABLE `answer`
  MODIFY `AnswerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `game`
--
ALTER TABLE `game`
  MODIFY `GameID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `QuestionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `result`
--
ALTER TABLE `result`
  MODIFY `ResultID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `answer`
--
ALTER TABLE `answer`
  ADD CONSTRAINT `answer_ibfk_1` FOREIGN KEY (`QuestionID`) REFERENCES `question` (`QuestionID`) ON DELETE CASCADE;

--
-- Constraints for table `game`
--
ALTER TABLE `game`
  ADD CONSTRAINT `game_ibfk_1` FOREIGN KEY (`CreatedBy`) REFERENCES `user` (`UserID`) ON DELETE SET NULL;

--
-- Constraints for table `question`
--
ALTER TABLE `question`
  ADD CONSTRAINT `question_ibfk_1` FOREIGN KEY (`GameID`) REFERENCES `game` (`GameID`) ON DELETE CASCADE;

--
-- Constraints for table `result`
--
ALTER TABLE `result`
  ADD CONSTRAINT `fk_gameid` FOREIGN KEY (`GameID`) REFERENCES `game` (`GameID`),
  ADD CONSTRAINT `fk_userid` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
