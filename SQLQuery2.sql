INSERT INTO PartnerTypes (TypeName)
VALUES ('������������'), ('��������'), ('�����'), ('������� �� ��������'), ('�������������� �����');


INSERT INTO Partners (Name, IdPartnerType, Rating, Address, DirectorFirstName, DirectorMiddleName, DirectorLastName, Phone, Email)
VALUES
('��� "�����"', 1, 95, '��. ������, �. 10', '����', '��������', '������', '+7 900 123-45-67', 'ivanov@trade.ru'),
('��� "�������"', 2, 85, '��. ����, �. 15', '����', '��������', '������', '+7 910 987-65-43', 'petrov@system.ru'),
('�� �������', 3, 78, '��. �������, �. 20', '�������', '����������', '�������', '+7 920 123-11-22', 'smirnov@ip.ru'),
('������ �������� "����"', 4, 90, '��. ����������, �. 50', '�����', '����������', '�������', '+7 930 456-78-90', 'kozlova@ecos.com'),
('��� "��������"', 5, 88, '��. ��������, �. 5', '������', '���������', '������', '+7 940 333-22-11', 'volkov@lightsoft.ru');

INSERT INTO ProductTypes (TypeName)
VALUES ('�����'), ('������'), ('�������������'), ('����������� �����������'), ('������������');

INSERT INTO Products (Name, IdProductType)
VALUES
('������� LCD-22', 1),
('���������� USB', 1),
('������������ �������', 2),
('SSD ���� 512 ��', 3),
('��������� Kaspersky', 4);

INSERT INTO Sales (IdPartner, IdProduct, Quantity, SaleDate)
VALUES
(1, 1, 10, '2024-03-01'),
(1, 2, 25, '2024-03-02'),
(2, 3, 5, '2024-03-03'),
(3, 4, 15, '2024-03-04'),
(4, 5, 2, '2024-03-05');