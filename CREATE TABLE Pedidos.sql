CREATE TABLE Pedidos (
    IdPedido INT PRIMARY KEY AUTO_INCREMENT,
    Fecha DATE NOT NULL,
    IdCliente INT NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);