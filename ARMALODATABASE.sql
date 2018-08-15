-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema ARMALO
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ARMALO
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ARMALO` DEFAULT CHARACTER SET utf8 ;
USE `ARMALO` ;

-- -----------------------------------------------------
-- Table `ARMALO`.`USUARIOS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`USUARIOS` (
  `ID_USR` INT NOT NULL,
  `Resume` VARCHAR(300) NULL,
  `TipoUSR` INT NOT NULL,
  PRIMARY KEY (`ID_USR`, `TipoUSR`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ARMALO`.`Historia_de_eventos_ORG`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`Historia_de_eventos_ORG` (
  `ID_ORG` INT NULL,
  `ID_EVENT` INT NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ARMALO`.`LISTA_DE_ASISTENTES`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`LISTA_DE_ASISTENTES` (
  `ID_LISTA` INT NOT NULL,
  `ID_USR` INT NULL,
  `ID_EVENT` INT NOT NULL,
  PRIMARY KEY (`ID_LISTA`),
  INDEX `ID_USR_idx` (`ID_USR` ASC) VISIBLE,
  CONSTRAINT `ID_USR`
    FOREIGN KEY (`ID_USR`)
    REFERENCES `ARMALO`.`USUARIOS` (`ID_USR`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ARMALO`.`Publicidad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`Publicidad` (
  `ID_EVENT` INT NULL,
  `ID_ADMIN` INT NULL,
  `Monto` INT NULL,
  `Duracion` INT NULL,
  `Fecha` DATE NULL,
  INDEX `ID_ADMIN_idx` (`ID_ADMIN` ASC) VISIBLE,
  CONSTRAINT `ID_ADMIN`
    FOREIGN KEY (`ID_ADMIN`)
    REFERENCES `ARMALO`.`USUARIOS` (`ID_USR`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ARMALO`.`Evento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`Evento` (
  `ID_EVENT` INT NOT NULL,
  `ID_LISTA` INT NULL,
  `ID_ORG` INT NULL,
  `Ubicacion` VARCHAR(45) NULL,
  `Tipo` VARCHAR(45) NULL,
  `CUPO_MAX` INT NOT NULL,
  `CUPO_OCU` INT NULL,
  `FECHA` DATE NULL,
  `ESTADO` VARCHAR(45) NULL,
  PRIMARY KEY (`ID_EVENT`),
  INDEX `ID_ORG_idx` (`ID_ORG` ASC) VISIBLE,
  CONSTRAINT `ID_ORG`
    FOREIGN KEY (`ID_ORG`)
    REFERENCES `ARMALO`.`USUARIOS` (`ID_USR`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ARMALO`.`Historia_de_eventos_USR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ARMALO`.`Historia_de_eventos_USR` (
  `ID_USR` INT NULL,
  `ID_EVENT` INT NULL)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
