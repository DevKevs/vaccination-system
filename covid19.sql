-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-07-2021 a las 21:48:30
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `covid19`
--
CREATE DATABASE IF NOT EXISTS `covid19` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `covid19`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--
-- Creación: 14-07-2021 a las 20:18:55
-- Última actualización: 25-07-2021 a las 18:05:06
--

CREATE TABLE `persona` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Telefono` varchar(25) NOT NULL,
  `Cedula` varchar(13) NOT NULL,
  `FechaNac` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`ID`, `Nombre`, `Apellido`, `Telefono`, `Cedula`, `FechaNac`) VALUES
(1, 'Kevin', 'Feliz', '+18496269698', '402-3321195-8', '06/02/2002'),
(2, 'Grichal', 'Perez Melo', '809-558-9887', '402-3207026-4', '05/08/1997'),
(3, 'Maria', 'Ogando', '809-558-3022', '013-2354555-8', '16/04/1997');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincias`
--
-- Creación: 14-07-2021 a las 20:22:48
--

CREATE TABLE `provincias` (
  `ID` int(11) NOT NULL,
  `Provincia` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `provincias`
--

INSERT INTO `provincias` (`ID`, `Provincia`) VALUES
(1, 'San jose de Ocoa'),
(2, 'Santo Domingo'),
(3, 'Azua'),
(4, 'Dajabon');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacuna`
--
-- Creación: 14-07-2021 a las 20:25:54
--

CREATE TABLE `vacuna` (
  `ID` int(11) NOT NULL,
  `Nombre_vacuna` varchar(50) NOT NULL,
  `FechaIngreso` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vacuna`
--

INSERT INTO `vacuna` (`ID`, `Nombre_vacuna`, `FechaIngreso`) VALUES
(1, 'Sinovac', '2021-07-14 21:35:51'),
(2, 'Faizer', '2021-07-14 21:42:25'),
(3, 'AstraCNK', '2021-07-14 23:58:19'),
(4, 'Jhonson', '2021-07-16 22:23:39');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacunados`
--
-- Creación: 14-07-2021 a las 20:34:46
-- Última actualización: 25-07-2021 a las 18:05:06
--

CREATE TABLE `vacunados` (
  `ID` int(11) NOT NULL,
  `id_persona` int(11) NOT NULL,
  `id_vacuna` int(11) NOT NULL,
  `id_provincia` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `vacunados`
--

INSERT INTO `vacunados` (`ID`, `id_persona`, `id_vacuna`, `id_provincia`, `fecha`) VALUES
(1, 1, 2, 1, '2021-07-14 23:50:15'),
(2, 1, 2, 2, '2021-07-15 18:56:47'),
(3, 1, 1, 1, '2021-07-15 18:58:13'),
(4, 2, 3, 2, '2021-07-15 19:01:36'),
(5, 1, 4, 3, '2021-07-16 22:25:10'),
(6, 3, 1, 4, '2021-07-25 18:05:06');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Cedula` (`Cedula`);

--
-- Indices de la tabla `provincias`
--
ALTER TABLE `provincias`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `vacuna`
--
ALTER TABLE `vacuna`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `vacunados`
--
ALTER TABLE `vacunados`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `id_persona` (`id_persona`),
  ADD KEY `id_vacuna` (`id_vacuna`),
  ADD KEY `id_provincia` (`id_provincia`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `provincias`
--
ALTER TABLE `provincias`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `vacuna`
--
ALTER TABLE `vacuna`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `vacunados`
--
ALTER TABLE `vacunados`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `vacunados`
--
ALTER TABLE `vacunados`
  ADD CONSTRAINT `vacunados_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `vacunados_ibfk_2` FOREIGN KEY (`id_vacuna`) REFERENCES `vacuna` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `vacunados_ibfk_3` FOREIGN KEY (`id_provincia`) REFERENCES `provincias` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
