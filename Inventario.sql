
CREATE TABLE Users(
    [Id] INT PRIMARY KEY IDENTITY,
    [Login] VARCHAR(128) NOT NULL UNIQUE,
    [Password] VARCHAR(512) NOT NULL,
    [Name] VARCHAR(128) NOT NULL,
    [Phone] VARCHAR(20) NOT NULL,
    [Email] VARCHAR(128) NOT NULL,
    [RegistrationDate] DATETIME2 NOT NULL DEFAULT GETDATE(),
    [IsActive] BIT NOT NULL DEFAULT(1),
    CONSTRAINT UQ_Users_Login_Email UNIQUE([Login], [Email])
);

INSERT INTO Users([Login], [Password], [Name], [Phone], [Email]) VALUES ('teste', 'teste', 'Teste','(00) 0 0000-5555', 'teste@email.com')

SELECT COUNT(*) FROM Users WHERE Login = 'testee'
SELECT COUNT(*) AS Qtd FROM Users WHERE Login = 'tes'AND Password ='ts' AND IsActive = 1
CREATE TABLE Products(
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(128) NOT NULL,
    Features VARCHAR(512) NOT NULL,
    Quantity INT NOT NULL CHECK(Quantity > 0),
    Price DECIMAL(10,2) NOT NULL CHECK(Price > 0.0),
    CategorieId INT,
    CompanyId INT,
    CONSTRAINT FK_Product_Categorie FOREIGN KEY (CategorieId) REFERENCES Categories(Id),
    CONSTRAINT FK_Product_Company FOREIGN KEY (CompanyId) REFERENCES Companies(Id),
    CONSTRAINT UQ_Product_Name_Feaure_Category_Company UNIQUE([Name], Features, CategorieId, CompanyId)
)

alter table Products add CategoryId INT;
alter table Products add CompanyId INT;

INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Laptop Dell XPS 13', '13.4" FHD+, Intel i7, 16GB RAM, 512GB SSD', 15, 1299.99);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Mouse Logitech MX Master 3S', 'Wireless, Ergonomic, High Precision', 50, 99.90);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Keyboard Corsair K70 RGB', 'Mechanical, RGB Backlit, Cherry MX Switches', 30, 149.50);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Monitor Samsung 27" Curved', '1080p, 144Hz, FreeSync', 25, 249.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Headphones Sony WH-1000XM5', 'Wireless, Noise Cancelling, Bluetooth', 40, 349.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Webcam Logitech C920s', '1080p, HD, Autofocus', 60, 79.99);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('SSD Samsung 980 Pro 1TB', 'NVMe, PCIe 4.0, High Speed', 20, 179.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Printer HP LaserJet Pro M404dn', 'Laser, Duplex, Network Ready', 10, 299.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Router TP-Link Archer AX50', 'Wi-Fi 6, Dual-Band, Gigabit', 35, 129.99);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Tablet Samsung Galaxy Tab S8', '11" LCD, Snapdragon 8 Gen 1, 128GB', 18, 699.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Smartphone Google Pixel 7', '6.3" OLED, Google Tensor G2, 128GB', 22, 599.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Smartwatch Apple Watch Series 8', 'GPS, Health Tracking, Water Resistant', 28, 399.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('External Hard Drive Seagate 2TB', 'Portable, USB 3.0', 45, 79.50);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Gaming Chair Secretlab Titan Evo', 'Ergonomic, Adjustable, Premium', 12, 549.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Microphone Blue Yeti', 'USB, Condenser, Studio Quality', 32, 129.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('VR Headset Oculus Quest 2', 'Wireless, Standalone, Immersive', 16, 399.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Projector Epson Home Cinema 2250', '1080p, 3LCD, Wireless', 8, 899.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Graphics Card NVIDIA GeForce RTX 3060', '12GB GDDR6, Ray Tracing', 14, 399.99);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Soundbar Sonos Arc', 'Home Theater, Dolby Atmos, Wireless', 9, 899.00);
INSERT INTO Products (Name, Features, Quantity, Price) VALUES ('Camera Canon EOS Rebel T8i', 'DSLR, 24.1MP, 4K Video', 11, 749.00);

SELECT Id, Name, Features, Price, sum(Quantity) AS Quantity, sum(Price) AS Price 
FROM Products WHERE Name LIKE '%%' GROUP BY Id, Name, Features, Price, Quantity HAVING(quantity > 0) ORDER BY Name

CREATE TABLE Categories(
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(128) NOT NULL,
    [Description] VARCHAR(512) NOT NULL
)

INSERT INTO Categories (Name, Description) VALUES ('Eletrônicos', 'Produtos eletrônicos em geral.');
INSERT INTO Categories (Name, Description) VALUES ('Livros', 'Livros de diversos gêneros e autores.');
INSERT INTO Categories (Name, Description) VALUES ('Roupas', 'Vestuário para homens, mulheres e crianças.');
INSERT INTO Categories (Name, Description) VALUES ('Alimentos', 'Produtos alimentícios e bebidas.');
INSERT INTO Categories (Name, Description) VALUES ('Esportes', 'Equipamentos e acessórios para esportes.');
INSERT INTO Categories (Name, Description) VALUES ('Ferramentas', 'Ferramentas manuais e elétricas.');
INSERT INTO Categories (Name, Description) VALUES ('Móveis', 'Móveis para casa e escritório.');
INSERT INTO Categories (Name, Description) VALUES ('Brinquedos', 'Brinquedos e jogos para crianças.');
INSERT INTO Categories (Name, Description) VALUES ('Beleza', 'Produtos de beleza e cuidados pessoais.');
INSERT INTO Categories (Name, Description) VALUES ('Automotivo', 'Peças e acessórios para veículos.');

CREATE TABLE Companies(
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(128) NOT NULL,
    [Description] VARCHAR(512) NOT NULL
);

INSERT INTO Companies (Name, Description) VALUES ('Tech Solutions Inc.', 'Desenvolvimento de software e soluções tecnológicas.');
INSERT INTO Companies (Name, Description) VALUES ('Global Retail Ltd.', 'Comércio varejista de diversos produtos.');
INSERT INTO Companies (Name, Description) VALUES ('Food Industries SA', 'Produção e distribuição de alimentos e bebidas.');
INSERT INTO Companies (Name, Description) VALUES ('Auto Parts Corp.', 'Fabricação e venda de peças automotivas.');
INSERT INTO Companies (Name, Description) VALUES ('Edu Services Group', 'Serviços educacionais e treinamento profissional.');
INSERT INTO Companies (Name, Description) VALUES ('Build Masters Co.', 'Construção civil e projetos arquitetônicos.');
INSERT INTO Companies (Name, Description) VALUES ('Health Care Systems', 'Desenvolvimento de sistemas para saúde e bem-estar.');
INSERT INTO Companies (Name, Description) VALUES ('Logistics Express', 'Serviços de logística e transporte de cargas.');
INSERT INTO Companies (Name, Description) VALUES ('Creative Media Ltd.', 'Produção de conteúdo audiovisual e marketing digital.');
INSERT INTO Companies (Name, Description) VALUES ('Energy Innovations', 'Desenvolvimento de tecnologias de energia renovável.');



SELECT Id, Name, Description FROM Categories ORDER BY Name OFFSET 2 ROWS FETCH NEXT 5 ROWS ONLY