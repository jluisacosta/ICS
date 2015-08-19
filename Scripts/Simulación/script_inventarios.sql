SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `si_inventarios` ;
CREATE SCHEMA IF NOT EXISTS `si_inventarios` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
SHOW WARNINGS;
USE `si_inventarios` ;

-- -----------------------------------------------------
-- Table `Proveedores`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Proveedores` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Proveedores` (
  `id_proveedor` INT(11) NOT NULL,
  `razon_social` VARCHAR(45) NOT NULL,
  `rfc` VARCHAR(45) NOT NULL,
  `contacto` VARCHAR(45) NOT NULL,
  `ciudad` VARCHAR(45) NOT NULL,
  `cp` INT NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id_proveedor`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `rfc_UNIQUE` ON `Proveedores` (`rfc` ASC);

SHOW WARNINGS;
CREATE UNIQUE INDEX `email_UNIQUE` ON `Proveedores` (`email` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Usuarios` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Usuarios` (
  `id_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `user_login` VARCHAR(45) NOT NULL,
  `user_password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Tipos_Empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Tipos_Empleados` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Tipos_Empleados` (
  `id_tipo_empleado` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`id_tipo_empleado`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Empleados` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Empleados` (
  `id_empleado` INT(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` INT(11) NULL,
  `id_tipo_empleado` INT(11) NULL,
  `nombre` VARCHAR(100) NOT NULL,
  `fecha_nacimiento` DATE NOT NULL,
  `direccion` VARCHAR(100) NOT NULL,
  `telefono` VARCHAR(15) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `departamento` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_empleado`),
  CONSTRAINT `fk_user`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `Usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipo_emp`
    FOREIGN KEY (`id_tipo_empleado`)
    REFERENCES `Tipos_Empleados` (`id_tipo_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clientes` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clientes` (
  `id_cliente` INT(11) NOT NULL AUTO_INCREMENT,
  `razon_social` VARCHAR(45) NOT NULL,
  `rfc` VARCHAR(45) NOT NULL,
  `ciudad` VARCHAR(45) NOT NULL,
  `cp` VARCHAR(45) NOT NULL,
  `direccion` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id_cliente`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `rfc_UNIQUE` ON `Clientes` (`rfc` ASC);

SHOW WARNINGS;
CREATE UNIQUE INDEX `email_UNIQUE` ON `Clientes` (`email` ASC);

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Productos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Productos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Productos` (
  `id_producto` INT(11) NOT NULL AUTO_INCREMENT,
  `categoria` VARCHAR(45) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(200) NOT NULL,
  `precio` DECIMAL(10,2) NOT NULL,
  `stock` INT NOT NULL,
  `stock_minimo` INT NOT NULL,
  `stock_maximo` INT NOT NULL,
  `fecha_ingreso` DATE NOT NULL,
  `unidad` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id_producto`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Ventas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ventas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Ventas` (
  `id_venta` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `fecha` DATE NOT NULL,
  `iva` DECIMAL(5,2) NOT NULL,
  `total` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`id_venta`),
  CONSTRAINT `fk_emp`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `Empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Detalle_Venta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Detalle_Venta` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Detalle_Venta` (
  `id_venta` INT(11) NOT NULL,
  `id_producto` INT(11) NOT NULL,
  `cantidad` INT NOT NULL,
  `subtotal` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`id_venta`, `id_producto`),
  CONSTRAINT `fk_venta`
    FOREIGN KEY (`id_venta`)
    REFERENCES `Ventas` (`id_venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_art`
    FOREIGN KEY (`id_producto`)
    REFERENCES `Productos` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Facturas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Facturas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Facturas` (
  `id_factura` INT(11) NOT NULL AUTO_INCREMENT,
  `id_venta` INT(11) NOT NULL,
  `id_cliente` INT(11) NOT NULL,
  `fecha` DATE NULL,
  PRIMARY KEY (`id_factura`),
  CONSTRAINT `fk_ven`
    FOREIGN KEY (`id_venta`)
    REFERENCES `Ventas` (`id_venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cli`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `Clientes` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Ordenes_Compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ordenes_Compra` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Ordenes_Compra` (
  `id_orden_compra` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `id_proveedor` INT(11) NOT NULL,
  `iva` DECIMAL(2,2) NOT NULL,
  `fecha_pedido` DATE NOT NULL,
  `costo_total` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`id_orden_compra`),
  CONSTRAINT `fk_empleado`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `Empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_provedor`
    FOREIGN KEY (`id_proveedor`)
    REFERENCES `Proveedores` (`id_proveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Materias_Primas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Materias_Primas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Materias_Primas` (
  `id_materia` INT NOT NULL AUTO_INCREMENT,
  `id_proveedor` INT NULL,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  `precio` DECIMAL(10,2) NULL,
  `stock` DECIMAL(10,5) NULL,
  `stock_minimo` DECIMAL NULL,
  `stock_maximo` DECIMAL NULL,
  `fecha_ingreso` DATE NULL,
  `unidad` VARCHAR(20) NULL,
  PRIMARY KEY (`id_materia`),
  CONSTRAINT `fk_p`
    FOREIGN KEY (`id_proveedor`)
    REFERENCES `Proveedores` (`id_proveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Detalle_Compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Detalle_Compra` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Detalle_Compra` (
  `id_orden_compra` INT(11) NOT NULL,
  `id_materia_prima` INT(11) NOT NULL,
  `cantidad` INT NOT NULL,
  `subtotal` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`id_orden_compra`, `id_materia_prima`),
  CONSTRAINT `fk_orden_compra`
    FOREIGN KEY (`id_orden_compra`)
    REFERENCES `Ordenes_Compra` (`id_orden_compra`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mat_pri`
    FOREIGN KEY (`id_materia_prima`)
    REFERENCES `Materias_Primas` (`id_materia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Ordenes_Produccion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ordenes_Produccion` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Ordenes_Produccion` (
  `id_orden_produccion` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `id_producto` INT(11) NOT NULL,
  `fecha_inicio` DATE NOT NULL,
  `fecha_entrega` DATE NULL,
  `cantidad` INT NOT NULL,
  PRIMARY KEY (`id_orden_produccion`),
  CONSTRAINT `fk_emple`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `Empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_artic`
    FOREIGN KEY (`id_producto`)
    REFERENCES `Productos` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Requisiciones_Material`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Requisiciones_Material` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Requisiciones_Material` (
  `id_requisicion` INT(11) NOT NULL AUTO_INCREMENT,
  `id_orden_produccion` INT(11) NOT NULL,
  `id_empleado` INT(11) NOT NULL,
  `fecha` DATE NOT NULL,
  PRIMARY KEY (`id_requisicion`),
  CONSTRAINT `fk_orden_producto`
    FOREIGN KEY (`id_orden_produccion`)
    REFERENCES `Ordenes_Produccion` (`id_orden_produccion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_emp_1`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `Empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Permisos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Permisos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Permisos` (
  `id_permiso` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_permiso`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Permisos_X_Usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Permisos_X_Usuario` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Permisos_X_Usuario` (
  `id_permiso` INT(11) NOT NULL,
  `id_usuario` INT(11) NOT NULL,
  PRIMARY KEY (`id_permiso`, `id_usuario`),
  CONSTRAINT `fk_perm_usu`
    FOREIGN KEY (`id_permiso`)
    REFERENCES `Permisos` (`id_permiso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarios`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `Usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Movimientos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Movimientos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Movimientos` (
  `id_movimiento` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `fecha` DATE NULL,
  `tipo_movimiento` VARCHAR(20) NULL,
  PRIMARY KEY (`id_movimiento`),
  CONSTRAINT `fk_emp_2`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `Empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Detalle_Movimiento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Detalle_Movimiento` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Detalle_Movimiento` (
  `id_movimiento` INT(11) NOT NULL,
  `id_materia_prima` INT(11) NOT NULL,
  `cantidad` DECIMAL(10,5) NOT NULL,
  PRIMARY KEY (`id_movimiento`, `id_materia_prima`),
  CONSTRAINT `fk_mov_2`
    FOREIGN KEY (`id_movimiento`)
    REFERENCES `Movimientos` (`id_movimiento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mp`
    FOREIGN KEY (`id_materia_prima`)
    REFERENCES `Materias_Primas` (`id_materia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `MateriaPorProducto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `MateriaPorProducto` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `MateriaPorProducto` (
  `id_materia` INT(11) NULL,
  `id_producto` INT(11) NULL,
  `cantidad` DECIMAL(10,5) NULL,
  CONSTRAINT `fk_mat_p`
    FOREIGN KEY (`id_materia`)
    REFERENCES `Materias_Primas` (`id_materia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_prod`
    FOREIGN KEY (`id_producto`)
    REFERENCES `Productos` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
