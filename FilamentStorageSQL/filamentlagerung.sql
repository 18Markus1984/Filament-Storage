-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 16. Jun 2020 um 00:12
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `filamentlagerung`
--
CREATE DATABASE IF NOT EXISTS `filamentlagerung` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `filamentlagerung`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `filament`
--

CREATE TABLE `filament` (
  `Filament_ID` int(11) NOT NULL,
  `Durchmesser` text NOT NULL,
  `Farbe` text NOT NULL,
  `RGB` int(11) NOT NULL,
  `Gewicht` int(11) DEFAULT NULL,
  `Bestellnummer` text DEFAULT NULL,
  `Druckkopf` enum('AA','BB','CC') NOT NULL,
  `Menge` int(11) NOT NULL,
  `Geoeffnet` int(11) NOT NULL,
  `BedT` int(11) DEFAULT NULL,
  `ExT` int(11) DEFAULT NULL,
  `Lagerort` text NOT NULL,
  `Notizen` text DEFAULT NULL,
  `NameU` char(30) NOT NULL,
  `NameM` char(30) NOT NULL,
  `Preis` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `filament`
--

INSERT INTO `filament` (`Filament_ID`, `Durchmesser`, `Farbe`, `RGB`, `Gewicht`, `Bestellnummer`, `Druckkopf`, `Menge`, `Geoeffnet`, `BedT`, `ExT`, `Lagerort`, `Notizen`, `NameU`, `NameM`, `Preis`) VALUES
(13, '2,85', 'Schwarz', -128, 750, '124esfs', 'AA', 1, 1, NULL, NULL, 'Schrank', '', 'Ultimaker', 'Though PLA', '15'),
(14, '1,75', 'Raven Black', -16777216, NULL, '', 'AA', 1, 1, NULL, NULL, 'Keller', '', 'LeapFrog', 'PLA', NULL),
(15, '1,75', 'Weiß', -4144960, NULL, '', 'BB', 18, 0, NULL, NULL, 'Keller', '', 'e3dick', 'Soulable Support', NULL),
(16, '1,75', 'Sunny Yellow', -256, NULL, '', 'AA', 1, 0, NULL, NULL, 'Keller', '', 'LeapFrog', 'PLA', NULL),
(17, '1,75', 'Weiß', -1, NULL, '', 'AA', 1, 0, NULL, NULL, 'Schrank', '', 'DasFil', 'TPU', NULL),
(18, '2,85', 'Rot', -65536, NULL, '', 'AA', 4, 0, NULL, NULL, 'Schrank', '', 'Ultimaker', 'TPU 95A', NULL),
(19, '2,85', 'Blau', -16776961, NULL, '', 'AA', 43, 0, NULL, NULL, 'Schrank', '', 'Ultimaker', 'TPU 95A', NULL),
(20, '2,85', 'Weiß', -4144960, NULL, '', 'BB', 3, 0, NULL, NULL, 'Schrank', '', 'Ultimaker', 'Soulable Support', NULL),
(21, '2,85', 'Schwarz', -16777216, NULL, '', 'CC', 2, 2, NULL, NULL, 'Schrank', '', 'Ultimaker', 'Nylon', NULL),
(22, '1,75', 'Jungle Green', -16760832, NULL, '', 'AA', 2, 1, NULL, NULL, 'Keller', '', 'LeapFrog', 'ABS', NULL),
(23, '1,75', 'Neon Orange', -551362, NULL, NULL, 'AA', 2, 0, NULL, NULL, 'Schrank', NULL, 'Prusa', 'PETG', NULL),
(24, '1,75', 'Rot', -65536, NULL, NULL, 'AA', 1, 1, NULL, NULL, 'Schrank', NULL, 'e3dick', 'PLA', NULL),
(25, '2,85', 'Grün', -16744448, NULL, '', 'BB', 2, 1, NULL, NULL, 'Keller', '', 'e3dick', 'PVA', NULL),
(26, '2,85', 'Grün', -16777216, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(27, '2,85', 'Grün', -8323200, NULL, '', 'BB', 2, 1, NULL, NULL, 'Keller', '', 'e3dick', 'PVA', NULL),
(28, '2,85', 'Grün', -16777216, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(29, '2,85', 'Grün', -16744448, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(30, '2,85', 'Grün', -16744448, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(31, '2,85', 'Grün', -16744448, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(32, '2,85', 'Grün', -16744448, NULL, NULL, 'BB', 2, 1, NULL, NULL, 'Keller', NULL, 'e3dick', 'PVA', NULL),
(33, '1,75', 'Orange', -32768, NULL, NULL, 'AA', 20, 1, NULL, NULL, 'Schrank', NULL, 'Prusa', 'PETG', NULL),
(34, '1,75', 'Orange', -32768, NULL, NULL, 'AA', 20, 1, NULL, NULL, 'Schrank', NULL, 'Prusa', 'PETG', NULL),
(35, '1,75', 'Schwarz', -16777216, NULL, NULL, 'AA', 1, 1, NULL, NULL, 'Keller', NULL, 'LeapFrog', 'Nylon', NULL);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `material`
--

CREATE TABLE `material` (
  `NameM` char(30) NOT NULL,
  `Durchschitt Preis` decimal(10,0) NOT NULL,
  `Anzahl` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `material`
--

INSERT INTO `material` (`NameM`, `Durchschitt Preis`, `Anzahl`) VALUES
('ABS', '0', 0),
('Nylon', '0', 0),
('PETG', '0', 0),
('PLA', '0', 0),
('PVA', '0', 0),
('Soulable Support', '0', 0),
('Though PLA', '0', 0),
('TPU', '0', 0),
('TPU 95A', '0', 0);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `unternehmen`
--

CREATE TABLE `unternehmen` (
  `NameU` char(30) NOT NULL,
  `Anzahl` int(11) NOT NULL,
  `Stadt` text DEFAULT NULL,
  `Postleitzahl` int(11) DEFAULT NULL,
  `Straße` text DEFAULT NULL,
  `Hausnummer` int(11) DEFAULT NULL,
  `Telefonnummer` text DEFAULT NULL,
  `Ansprechpartner` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `unternehmen`
--

INSERT INTO `unternehmen` (`NameU`, `Anzahl`, `Stadt`, `Postleitzahl`, `Straße`, `Hausnummer`, `Telefonnummer`, `Ansprechpartner`) VALUES
('DasFil', 0, NULL, NULL, NULL, NULL, NULL, NULL),
('e3dick', 0, NULL, NULL, NULL, NULL, NULL, NULL),
('LeapFrog', 0, NULL, NULL, NULL, NULL, NULL, NULL),
('Prusa', 0, NULL, NULL, NULL, NULL, NULL, NULL),
('Ultimaker', 0, NULL, NULL, NULL, NULL, NULL, NULL);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `filament`
--
ALTER TABLE `filament`
  ADD PRIMARY KEY (`Filament_ID`),
  ADD KEY `Material` (`NameM`),
  ADD KEY `Unternehmen` (`NameU`);

--
-- Indizes für die Tabelle `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`NameM`);

--
-- Indizes für die Tabelle `unternehmen`
--
ALTER TABLE `unternehmen`
  ADD PRIMARY KEY (`NameU`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `filament`
--
ALTER TABLE `filament`
  MODIFY `Filament_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `filament`
--
ALTER TABLE `filament`
  ADD CONSTRAINT `Material` FOREIGN KEY (`NameM`) REFERENCES `material` (`NameM`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Unternehmen` FOREIGN KEY (`NameU`) REFERENCES `unternehmen` (`NameU`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
