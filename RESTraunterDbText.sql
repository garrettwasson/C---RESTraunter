-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema restraunterdb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema restraunterdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `restraunterdb` DEFAULT CHARACTER SET utf8 ;
USE `restraunterdb` ;

-- -----------------------------------------------------
-- Table `restraunterdb`.`reviews`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `restraunterdb`.`reviews` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `reviewerName` VARCHAR(255) NULL,
  `restaurantName` VARCHAR(255) NULL,
  `review` TEXT NULL,
  `stars` INT NULL,
  `date` DATETIME NULL,
  `createdAt` DATETIME NULL,
  `updatedAt` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
