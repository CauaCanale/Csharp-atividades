-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 15:59
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_carros`
--

CREATE TABLE `tb_carros` (
  `Id_carros` int(11) NOT NULL,
  `proprietario` varchar(150) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Marca` varchar(50) NOT NULL,
  `Modelo` varchar(100) NOT NULL,
  `Placa` varchar(7) NOT NULL,
  `Ano` varchar(4) NOT NULL,
  `Chassi` varchar(17) NOT NULL,
  `Cor` varchar(50) NOT NULL,
  `Acessorios` varchar(255) NOT NULL,
  `Valor` int(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_carros`
--

INSERT INTO `tb_carros` (`Id_carros`, `proprietario`, `Telefone`, `Cpf`, `Marca`, `Modelo`, `Placa`, `Ano`, `Chassi`, `Cor`, `Acessorios`, `Valor`) VALUES
(1, 'adadsa', '(23) 43224-424', '534.482.388-64', '423423', '2424', '2342432', '2342', '  32424', '34432', '4ww', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_clientes`
--

CREATE TABLE `tb_clientes` (
  `Id_Cliente` int(11) NOT NULL,
  `NomeCompleto` varchar(100) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `CEP` varchar(20) NOT NULL,
  `Numero` int(11) NOT NULL,
  `Telefone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`Id_Cliente`, `NomeCompleto`, `CPF`, `Email`, `CEP`, `Numero`, `Telefone`) VALUES
(4, 'caua', '534.482.388-64', 'sfsfsfdfsfsd@gmail.com', '23232-323', 233232, '(32) 32323-3232');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  ADD PRIMARY KEY (`Id_carros`);

--
-- Índices de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  ADD PRIMARY KEY (`Id_Cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_carros`
--
ALTER TABLE `tb_carros`
  MODIFY `Id_carros` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  MODIFY `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
