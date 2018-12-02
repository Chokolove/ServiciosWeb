
create database `encuestadb`;
use `encuestadb`;




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
  `fechaCreacion` datetime NOT NULL default now(),
  `idTipoUsuario` int(11) NOT NULL references tipousuario,
  `idEstado` int(11) NOT NULL references tipoestado,
  token varchar(100),
  app_secret varchar(100)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `Login`, `Pass`, `nomUsu`, `fechaCreacion`, `idTipoUsuario`, `idEstado`) VALUES
(1, 'Dev1', 'facil123', 'CarlosLL', '2018-11-17', 1, 2);



CREATE TABLE `usuario_empresa` (
  idUsuarioEmpresa int(11) not null primary key auto_increment,
    idEmpresa int(11) references empresa(idEmpresa),
    idUsuario int(11) references usuario(idUsuario)
);


--
-- Estructura de tabla para la tabla `encuesta`
--

CREATE TABLE `encuesta` (
  `idEncuesta` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL references usuario,
  `nomEncuesta` varchar(40) NOT NULL,
  `fechaCreacion` datetime NOT NULL default now(),
  `idEstado` int(11) NOT NULL references tipoestado
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `encuesta`
--

INSERT INTO `encuesta` (`idEncuesta`, `idUsuario`, `nomEncuesta`, `fechaCreacion`, `idEstado`) VALUES
(1, 1, 'PruebaEncuesta1', '2018-11-17', 2),
(2, 1, 'PruebaEncuesta2', '2018-11-17', 2),
(3, 1, 'PruebaEncuesta2', '2018-11-17', 1);


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
-- Estructura de tabla para la tabla `pregunta`
--

CREATE TABLE `pregunta` (
  `idPregunta` int(11) NOT NULL,
  `idEncuesta` int(11) NOT NULL references encuesta,
  `descPregunta` varchar(255) NOT NULL,
  `idTipoPregunta` int(11) NOT NULL references tipopregunta
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
  `idPregunta` int(11) NOT NULL references pregunta,
  `descRespuesta` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `respuesta`
--

INSERT INTO `respuesta` (`idRespuesta`, `idPregunta`, `descRespuesta`) VALUES
(1, 1, 'Respuesta1 Pregunta1'),
(2, 1, 'Respuesta2 Pregunta1'),
(3, 1, 'Respuesta3 Pregunta1'), 
(10, 3, '--Abierta--');


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_respuesta`
--

CREATE TABLE `cliente_encuesta` (
  `idClienteEncuesta` int(11) NOT NULL,
  `idEncuesta` int(11) NOT NULL references encuesta,
  `userAgent` varchar(255),
  `fechaCreacion` datetime NOT NULL default now()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_respuesta`
--

CREATE TABLE `cliente_respuesta` (
  `idClienteRespuesta` int(11) NOT NULL,
  `idClienteEncuesta` int(11) NOT NULL references cliente_encuesta,
  `idPregunta` int(11) NOT NULL references pregunta,
  `string_value` varchar(255),
  `string_value` varchar(255),
  `int_value` int,
  `double_value` double,
  `fechaCreacion` datetime NOT NULL default now()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_lista_respuesta`
--

CREATE TABLE `cliente_lista_respuesta` (
  `idClienteListaRespuesta` int(11) NOT NULL,
  `idClienteEncuesta` int(11) NOT NULL references cliente_encuesta,
  `idPregunta` int(11) NOT NULL references pregunta,
  `idRespuesta` int(11) NOT NULL references respuesta,
  `fechaCreacion` datetime NOT NULL default now()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


