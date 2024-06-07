USE BancaEnLinea

--SET IDENTITY_INSERT BancaEnLinea..Cliente ON;

INSERT INTO BancaEnLinea..Cliente (IDENTIFICACION,NOMBRE)
VALUES
('111', 'SEBASTIAN'),
('222', 'MARIO'),
('333', 'ANDRES'),
('444', 'STEVEN'),
('555', 'AXEL');

select * from dbo.Cliente 


INSERT INTO BancaEnLinea..Producto(NUMERO_CUENTA, CLIENTE_ID, TIPO_PRODUCTO, MONEDA, FECHA_APERTURA, IBAN, ESTADO, TASA_INTERES)
VALUES
('111111111', 1 , 'CuentaCorriente', 'Colones', GETDATE(), 'CR000111111111', 'AC', 3.14 ),
('222222222', 2 , 'CuentaCorriente', 'Colones', GETDATE(), 'CR000222222222', 'AC', 3.14 ),
('333333333', 3 , 'CuentaCorriente', 'Colones', GETDATE(), 'CR000333333333', 'AC', 1.14 ),
('444444444', 4 , 'CuentaCorriente', 'Colones', GETDATE(), 'CR000444444444', 'AC', 3.14 ),
('555555555', 5 , 'CuentaCorriente', 'Colones', GETDATE(), 'CR000555555555', 'AC', 2.14 );

select * from dbo.Producto 

INSERT INTO BancaEnLinea..Estado_Cuenta(NUMERO_CUENTA, MONEDA, SALDO, ULTIMA_ACTUALIZACION)
VALUES 
('111111111', 'Colones', '0' , GETDATE()),
('222222222', 'Colones', '0' , GETDATE()),
('333333333', 'Colones', '0' , GETDATE()),
('444444444', 'Colones', '0' , GETDATE()),
('555555555', 'Colones', '0' , GETDATE());

select * from dbo.Estado_Cuenta 
