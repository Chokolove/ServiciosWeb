-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-12-2018 a las 01:42:15
-- Versión del servidor: 10.1.36-MariaDB
-- Versión de PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `encuestadb`
--
create database `encuestadb`;
use `encuestadb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_encuesta`
--

CREATE TABLE `cliente_encuesta` (
  `idClienteEncuesta` int(11) NOT NULL,
  `idEncuesta` int(11) NOT NULL,
  `userAgent` varchar(255) DEFAULT NULL,
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_lista_respuesta`
--

CREATE TABLE `cliente_lista_respuesta` (
  `idClienteListaRespuesta` int(11) NOT NULL,
  `idClienteEncuesta` int(11) NOT NULL,
  `idPregunta` int(11) NOT NULL,
  `idRespuesta` int(11) NOT NULL,
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_respuesta`
--

CREATE TABLE `cliente_respuesta` (
  `idClienteRespuesta` int(11) NOT NULL,
  `idClienteEncuesta` int(11) NOT NULL,
  `idPregunta` int(11) NOT NULL,
  `string_value` varchar(255) DEFAULT NULL,
  `int_value` int(11) DEFAULT NULL,
  `double_value` double DEFAULT NULL,
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `idEmpresa` int(11) NOT NULL,
  `nomEmpresa` varchar(40) NOT NULL,
  `idTipoEmpresa` int(11) NOT NULL,
  `fechaCreacion` varchar(10) NOT NULL,
  `idEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`idEmpresa`, `nomEmpresa`, `idTipoEmpresa`, `fechaCreacion`, `idEstado`) VALUES
(1, 'Developer', 1, '2018-11-17', 2),
(2, 'Prueba1', 2, '2018-11-17', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encuesta`
--

CREATE TABLE `encuesta` (
  `idEncuesta` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `nomEncuesta` varchar(40) NOT NULL,
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `idEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `encuesta`
--

INSERT INTO `encuesta` (`idEncuesta`, `idUsuario`, `nomEncuesta`, `fechaCreacion`, `idEstado`) VALUES
(1, 1, 'PruebaEncuesta1', '2018-11-17 00:00:00', 2),
(2, 1, 'PruebaEncuesta2', '2018-11-17 00:00:00', 2),
(3, 1, 'PruebaEncuesta2', '2018-11-17 00:00:00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pregunta`
--

CREATE TABLE `pregunta` (
  `idPregunta` int(11) NOT NULL,
  `idEncuesta` int(11) NOT NULL,
  `descPregunta` varchar(255) NOT NULL,
  `idTipoPregunta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pregunta`
--

INSERT INTO `pregunta` (`idPregunta`, `idEncuesta`, `descPregunta`, `idTipoPregunta`) VALUES
(1, 1, 'Pregunta Numero 1', 2),
(2, 1, 'Pregunta Numero 2', 2),
(3, 1, 'Pregunta Numero 3', 1),
(4, 1, 'Pregunta Numero 4', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `respuesta`
--

CREATE TABLE `respuesta` (
  `idRespuesta` int(11) NOT NULL,
  `idPregunta` int(11) NOT NULL,
  `descRespuesta` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `respuesta`
--

INSERT INTO `respuesta` (`idRespuesta`, `idPregunta`, `descRespuesta`) VALUES
(1, 1, 'Respuesta1 Pregunta1'),
(2, 1, 'Respuesta2 Pregunta1'),
(3, 1, 'Respuesta3 Pregunta1'),
(4, 2, 'Respuesta 1 Pregunta 2'),
(5, 2, 'Respuesta 2 Pregunta 2'),
(6, 2, 'Respuesta 3 Pregunta 2'),
(7, 4, 'Respuesta 1 Pregunta 4'),
(8, 4, 'Respuesta 2 Pregunta 4'),
(9, 4, 'Respuesta 3 Pregunta 4'),
(10, 3, '--Abierta--');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoempresa`
--

CREATE TABLE `tipoempresa` (
  `idTipoEmpresa` int(11) NOT NULL,
  `nomTipoEmpresa` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoempresa`
--

INSERT INTO `tipoempresa` (`idTipoEmpresa`, `nomTipoEmpresa`) VALUES
(1, 'Developer'),
(2, 'Comercio');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoestado`
--

CREATE TABLE `tipoestado` (
  `idEstado` int(11) NOT NULL,
  `nomEstado` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoestado`
--

INSERT INTO `tipoestado` (`idEstado`, `nomEstado`) VALUES
(1, 'Desactivado'),
(2, 'Activado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipopregunta`
--

CREATE TABLE `tipopregunta` (
  `idTipoPregunta` int(11) NOT NULL,
  `nomTipoPregunta` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipopregunta`
--

INSERT INTO `tipopregunta` (`idTipoPregunta`, `nomTipoPregunta`) VALUES
(1, 'Abierta'),
(2, 'Radio'),
(3, 'CheckBox');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `idTipoUsuario` int(11) NOT NULL,
  `nomTipoUsuario` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`idTipoUsuario`, `nomTipoUsuario`) VALUES
(1, 'Developer'),
(2, 'Grunt'),
(3, 'Administrador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `Login` varchar(40) NOT NULL,
  `Pass` varchar(40) NOT NULL,
  `nomUsu` varchar(255) NOT NULL,
  `fechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `idTipoUsuario` int(11) NOT NULL,
  `idEstado` int(11) NOT NULL,
  `token` varchar(100) DEFAULT NULL,
  `app_secret` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `Login`, `Pass`, `nomUsu`, `fechaCreacion`, `idTipoUsuario`, `idEstado`, `token`, `app_secret`) VALUES
(1, 'Dev1', 'facil123', 'CarlosLL', '2018-11-17 00:00:00', 1, 2, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_empresa`
--

CREATE TABLE `usuario_empresa` (
  `idUsuarioEmpresa` int(11) NOT NULL,
  `idEmpresa` int(11) DEFAULT NULL,
  `idUsuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente_encuesta`
--
ALTER TABLE `cliente_encuesta`
  ADD PRIMARY KEY (`idClienteEncuesta`),
  ADD KEY `idEncuesta` (`idEncuesta`);

--
-- Indices de la tabla `cliente_lista_respuesta`
--
ALTER TABLE `cliente_lista_respuesta`
  ADD PRIMARY KEY (`idClienteListaRespuesta`),
  ADD KEY `idClienteEncuesta` (`idClienteEncuesta`),
  ADD KEY `idPregunta` (`idPregunta`),
  ADD KEY `idRespuesta` (`idRespuesta`);

--
-- Indices de la tabla `cliente_respuesta`
--
ALTER TABLE `cliente_respuesta`
  ADD PRIMARY KEY (`idClienteRespuesta`),
  ADD KEY `idClienteEncuesta` (`idClienteEncuesta`),
  ADD KEY `idPregunta` (`idPregunta`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`idEmpresa`),
  ADD KEY `idTipoEmpresa` (`idTipoEmpresa`);

--
-- Indices de la tabla `encuesta`
--
ALTER TABLE `encuesta`
  ADD PRIMARY KEY (`idEncuesta`),
  ADD KEY `idUsuario` (`idUsuario`),
  ADD KEY `idEstado` (`idEstado`);

--
-- Indices de la tabla `pregunta`
--
ALTER TABLE `pregunta`
  ADD PRIMARY KEY (`idPregunta`),
  ADD KEY `idEncuesta` (`idEncuesta`),
  ADD KEY `idTipoPregunta` (`idTipoPregunta`);

--
-- Indices de la tabla `respuesta`
--
ALTER TABLE `respuesta`
  ADD PRIMARY KEY (`idRespuesta`),
  ADD KEY `idPregunta` (`idPregunta`);

--
-- Indices de la tabla `tipoempresa`
--
ALTER TABLE `tipoempresa`
  ADD PRIMARY KEY (`idTipoEmpresa`);

--
-- Indices de la tabla `tipoestado`
--
ALTER TABLE `tipoestado`
  ADD PRIMARY KEY (`idEstado`);

--
-- Indices de la tabla `tipopregunta`
--
ALTER TABLE `tipopregunta`
  ADD PRIMARY KEY (`idTipoPregunta`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`idTipoUsuario`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`),
  ADD KEY `idTipoUsuario` (`idTipoUsuario`),
  ADD KEY `idEstado` (`idEstado`);

--
-- Indices de la tabla `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  ADD PRIMARY KEY (`idUsuarioEmpresa`),
  ADD KEY `idEmpresa` (`idEmpresa`),
  ADD KEY `idUsuario` (`idUsuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `idEmpresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tipoempresa`
--
ALTER TABLE `tipoempresa`
  MODIFY `idTipoEmpresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tipoestado`
--
ALTER TABLE `tipoestado`
  MODIFY `idEstado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  MODIFY `idTipoUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  MODIFY `idUsuarioEmpresa` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cliente_encuesta`
--
ALTER TABLE `cliente_encuesta`
  ADD CONSTRAINT `cliente_encuesta_ibfk_1` FOREIGN KEY (`idEncuesta`) REFERENCES `encuesta` (`idEncuesta`);

--
-- Filtros para la tabla `cliente_lista_respuesta`
--
ALTER TABLE `cliente_lista_respuesta`
  ADD CONSTRAINT `cliente_lista_respuesta_ibfk_1` FOREIGN KEY (`idClienteEncuesta`) REFERENCES `cliente_encuesta` (`idClienteEncuesta`),
  ADD CONSTRAINT `cliente_lista_respuesta_ibfk_2` FOREIGN KEY (`idPregunta`) REFERENCES `pregunta` (`idPregunta`),
  ADD CONSTRAINT `cliente_lista_respuesta_ibfk_3` FOREIGN KEY (`idRespuesta`) REFERENCES `respuesta` (`idRespuesta`);

--
-- Filtros para la tabla `cliente_respuesta`
--
ALTER TABLE `cliente_respuesta`
  ADD CONSTRAINT `cliente_respuesta_ibfk_1` FOREIGN KEY (`idClienteEncuesta`) REFERENCES `cliente_encuesta` (`idClienteEncuesta`),
  ADD CONSTRAINT `cliente_respuesta_ibfk_2` FOREIGN KEY (`idPregunta`) REFERENCES `pregunta` (`idPregunta`);

--
-- Filtros para la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD CONSTRAINT `empresa_ibfk_1` FOREIGN KEY (`idTipoEmpresa`) REFERENCES `tipoempresa` (`idTipoEmpresa`);

--
-- Filtros para la tabla `encuesta`
--
ALTER TABLE `encuesta`
  ADD CONSTRAINT `encuesta_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`),
  ADD CONSTRAINT `encuesta_ibfk_2` FOREIGN KEY (`idEstado`) REFERENCES `tipoestado` (`idEstado`);

--
-- Filtros para la tabla `pregunta`
--
ALTER TABLE `pregunta`
  ADD CONSTRAINT `pregunta_ibfk_1` FOREIGN KEY (`idEncuesta`) REFERENCES `encuesta` (`idEncuesta`),
  ADD CONSTRAINT `pregunta_ibfk_2` FOREIGN KEY (`idTipoPregunta`) REFERENCES `tipopregunta` (`idTipoPregunta`);

--
-- Filtros para la tabla `respuesta`
--
ALTER TABLE `respuesta`
  ADD CONSTRAINT `respuesta_ibfk_1` FOREIGN KEY (`idPregunta`) REFERENCES `pregunta` (`idPregunta`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idTipoUsuario`) REFERENCES `tipousuario` (`idTipoUsuario`),
  ADD CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`idEstado`) REFERENCES `tipoestado` (`idEstado`);

--
-- Filtros para la tabla `usuario_empresa`
--
ALTER TABLE `usuario_empresa`
  ADD CONSTRAINT `usuario_empresa_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`),
  ADD CONSTRAINT `usuario_empresa_ibfk_2` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
