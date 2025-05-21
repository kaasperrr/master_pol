INSERT INTO PartnerTypes (TypeName)
VALUES ('Дистрибьютор'), ('Реселлер'), ('Агент'), ('Партнер по франшизе'), ('Авторизованный дилер');


INSERT INTO Partners (Name, IdPartnerType, Rating, Address, DirectorFirstName, DirectorMiddleName, DirectorLastName, Phone, Email)
VALUES
('ООО "Трейд"', 1, 95, 'ул. Ленина, д. 10', 'Иван', 'Иванович', 'Иванов', '+7 900 123-45-67', 'ivanov@trade.ru'),
('ЗАО "Система"', 2, 85, 'пр. Мира, д. 15', 'Петр', 'Петрович', 'Петров', '+7 910 987-65-43', 'petrov@system.ru'),
('ИП Смирнов', 3, 78, 'ул. Пушкина, д. 20', 'Алексей', 'Викторович', 'Смирнов', '+7 920 123-11-22', 'smirnov@ip.ru'),
('Группа компаний "Экос"', 4, 90, 'ул. Московская, д. 50', 'Елена', 'Алексеевна', 'Козлова', '+7 930 456-78-90', 'kozlova@ecos.com'),
('ООО "Лайтсофт"', 5, 88, 'ул. Тверская, д. 5', 'Максим', 'Сергеевич', 'Волков', '+7 940 333-22-11', 'volkov@lightsoft.ru');

INSERT INTO ProductTypes (TypeName)
VALUES ('Товар'), ('Услуга'), ('Комплектующее'), ('Программное обеспечение'), ('Консультация');

INSERT INTO Products (Name, IdProductType)
VALUES
('Монитор LCD-22', 1),
('Клавиатура USB', 1),
('Обслуживание сервера', 2),
('SSD диск 512 ГБ', 3),
('Антивирус Kaspersky', 4);

INSERT INTO Sales (IdPartner, IdProduct, Quantity, SaleDate)
VALUES
(1, 1, 10, '2024-03-01'),
(1, 2, 25, '2024-03-02'),
(2, 3, 5, '2024-03-03'),
(3, 4, 15, '2024-03-04'),
(4, 5, 2, '2024-03-05');