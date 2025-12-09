-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyQuanCafe;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QuanLyQuanCafe;
GO

-- Tạo bảng TableFood
CREATE TABLE TableFood (
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
    status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trạng thái: Trống || Có người
);
GO


-- Tạo bảng Account
CREATE TABLE Account (
    UserName NVARCHAR(100) PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Nhân viên',
    Password NVARCHAR(1000) NOT NULL,
    Type INT NOT NULL DEFAULT 0 -- 0: nhân viên, 1: admin
);
GO

-- Tạo bảng FoodCategory
CREATE TABLE FoodCategory (
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
);
GO

-- Tạo bảng Food
CREATE TABLE Food (
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
    idCategory INT NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
);
GO

-- Tạo bảng Bill
CREATE TABLE Bill (
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 0: chưa thanh toán, 1: đã thanh toán
    FOREIGN KEY (idTable) REFERENCES TableFood(id)
);
GO

-- Tạo bảng BillInfo
CREATE TABLE BillInfo (
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES Bill(id),
    FOREIGN KEY (idFood) REFERENCES Food(id)
);
GO

INSERT INTO Account (UserName, DisplayName, Password, Type)
VALUES 
(N'admin', N'Quản trị viên', N'123456', 1),
(N'nhanvien1', N'Nhân viên A', N'123', 0),
(N'nhanvien2', N'Nhân viên B', N'123', 0),
(N'ketoan', N'Kế toán', N'abc123', 0);
GO

CREATE PROCEDURE USP_Login
    @UserName NVARCHAR(100),
    @Password NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Account 
    WHERE UserName = @UserName AND Password = @Password
END
GO
EXEC USP_Login @userName = N'admin', @passWord = N'123456'

INSERT INTO TableFood (name, status) VALUES (N'Bàn 1', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 2', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 3', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 4', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 5', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 6', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 7', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 8', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 9', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 10', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 11', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 12', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 13', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 14', N'Trống');
INSERT INTO TableFood (name, status) VALUES (N'Bàn 15', N'Trống');
DELETE TableFood
DECLARE @i INT = 1;

WHILE @i <= 30
BEGIN
    INSERT INTO TableFood (name, status)
    VALUES (N'Bàn ' + CAST(@i AS NVARCHAR), N'Trống');
    SET @i = @i + 1;
END;


CREATE PROC USP_GetTableList
AS
BEGIN
    SELECT * FROM dbo.TableFood;
END;
GO
EXEC USP_GetTableList;


-- Thêm các loại món ăn
INSERT INTO FoodCategory (name) VALUES (N'Món chính');
INSERT INTO FoodCategory (name) VALUES (N'Món phụ');
INSERT INTO FoodCategory (name) VALUES (N'Thức uống');
INSERT INTO FoodCategory (name) VALUES (N'Tráng miệng');


-- Món chính
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm gà', 1, 35000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm sườn', 1, 40000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Mì xào bò', 1, 42000);

-- Món phụ
INSERT INTO Food (name, idCategory, price) VALUES (N'Khoai tây chiên', 2, 25000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi cuốn', 2, 30000);

-- Thức uống
INSERT INTO Food (name, idCategory, price) VALUES (N'Trà đá', 3, 5000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Cà phê sữa', 3, 25000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Sting dâu', 3, 12000);

-- Tráng miệng
INSERT INTO Food (name, idCategory, price) VALUES (N'Rau câu', 4, 10000);
INSERT INTO Food (name, idCategory, price) VALUES (N'Bánh flan', 4, 15000);

-- Hóa đơn 1: bàn 1, chưa thanh toán
INSERT INTO Bill (DateCheckIn, idTable, status)
VALUES (GETDATE(), 1, 0);

-- Hóa đơn 2: bàn 2, đã thanh toán
INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status)
VALUES ('2025-04-18', '2025-04-18', 2, 1);

-- Hóa đơn 3: bàn 3, chưa thanh toán
INSERT INTO Bill (DateCheckIn, idTable, status)
VALUES (GETDATE(), 3, 0);

-- Hóa đơn 4: bàn 4, đã thanh toán
INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status)
VALUES ('2025-04-17', '2025-04-17', 4, 1);

-- Hóa đơn 5: bàn 5, đã thanh toán
INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status)
VALUES ('2025-04-16', '2025-04-16', 5, 1);

-- Hóa đơn 1 (bàn 1, chưa thanh toán)
INSERT INTO BillInfo (idBill, idFood, count) VALUES (1, 1, 2); -- Cơm gà x2
INSERT INTO BillInfo (idBill, idFood, count) VALUES (1, 6, 2); -- Trà đá x2

-- Hóa đơn 2 (bàn 2, đã thanh toán)
INSERT INTO BillInfo (idBill, idFood, count) VALUES (2, 2, 1); -- Cơm sườn x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (2, 5, 1); -- Gỏi cuốn x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (2, 7, 1); -- Cà phê sữa x1

-- Hóa đơn 3 (bàn 3, chưa thanh toán)
INSERT INTO BillInfo (idBill, idFood, count) VALUES (3, 3, 1); -- Mì xào bò x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (3, 8, 1); -- Sting dâu x1

-- Hóa đơn 4 (bàn 4, đã thanh toán)
INSERT INTO BillInfo (idBill, idFood, count) VALUES (4, 1, 1); -- Cơm gà x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (4, 4, 1); -- Khoai tây chiên x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (4, 10, 2); -- Bánh flan x2

-- Hóa đơn 5 (bàn 5, đã thanh toán)
INSERT INTO BillInfo (idBill, idFood, count) VALUES (5, 2, 1); -- Cơm sườn x1
INSERT INTO BillInfo (idBill, idFood, count) VALUES (5, 6, 1); -- Trà đá x1

DELETE BillInfo
DELETE Bill
delete TableFood
SELECT * FROM TableFood;
SELECT * FROM FoodCategory;
SELECT * FROM Food;
SELECT * FROM Bill;
SELECT * FROM BillInfo;


SELECT 
    b.id AS BillID,
    f.name AS FoodName,
    bi.count,
    f.price,
    (bi.count * f.price) AS Total
FROM BillInfo bi
JOIN Bill b ON bi.idBill = b.id
JOIN Food f ON bi.idFood = f.id;

SELECT *  FROM BillInfo where idBill = 5;

SELECT idFood, count FROM BillInfo WHERE idBill = 5

SELECT 
    b.id AS BillID,
    tf.name AS TableName,
    f.name AS FoodName,
    bi.count,
    f.price,
    (bi.count * f.price) AS TotalPrice,
    b.DateCheckIn,
    b.DateCheckOut,
    b.status
FROM Bill b
JOIN TableFood tf ON b.idTable = tf.id
JOIN BillInfo bi ON b.id = bi.idBill
JOIN Food f ON bi.idFood = f.id
WHERE b.idTable = 5;
SELECT * FROM dbo.Bill WHERE idTable = 5 AND status = 1
SELECT id, idBill, idFood, count FROM BillInfo WHERE idBill = 2

SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice
FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 1


alter PROC USP_InsertBill
    @idTable INT
AS
BEGIN
    INSERT INTO dbo.Bill (
        DateCheckIn,
        DateCheckOut,
        idTable,
        status,
		discount
    )
    VALUES (
        GETDATE(),    -- DateCheckIn: ngày hiện tại
        NULL,         -- DateCheckOut: chưa có (chưa thanh toán)
        @idTable,     -- ID của bàn
        0 ,-- status = 0: chưa thanh toán
		0
    );
END;
GO

ALTER PROC USP_InsertBILLINFO
@idBill INT, @idFood INT, @count INT
AS
BEGIN
    DECLARE @isExistsBILLINFO INT
    DECLARE @foodCount INT = 1

    SELECT @isExistsBILLINFO = id, @foodCount = b.count
    FROM dbo.BillInfo AS b
    WHERE idBill = @idBill AND idFood = @idFood

    IF (@isExistsBILLINFO > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
            UPDATE dbo.BillInfo SET count = @foodCount + @count
        ELSE
            DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
    END
    ELSE
        INSERT dbo.BillInfo
        (
            idBill, idFood, count
        )
        VALUES
        (
            @idBill, @idFood, @count
        )
END
GO


Select Max(id) from dbo.Bill


alter TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @idBill INT
    SELECT @idBill = idBill FROM Inserted

    DECLARE @idTable INT
    SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

    UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

ALTER TRIGGER UTG_UpdateBill
ON dbo.Bill
FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT
    SELECT @idBill = id FROM Inserted

    DECLARE @idTable INT
    SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

    DECLARE @count int = 0
    SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

    IF (@count = 0)
        UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

 
 ALTer Table Bill
 ADD discount INT
 Update Bill Set discount =0
 select discount from Bill

 select * from Bill
 select * from BillInfo
 select * from TableFood

 Delete BillInfo
 delete Bill
 DELETE tableFood

Select Max(id) from dbo.Bill
select * from Bill
alter table Bill 
add totalprice float


creATE PROC USP_GetListBillByDate
    @checkIn DATE, 
    @checkOut DATE
AS
BEGIN
    SELECT 
        t.name AS [Tên bàn], 
        b.totalPrice AS [Tổng tiền], 
        DateCheckIn AS [Ngày vào], 
        DateCheckOut AS [Ngày ra], 
        discount AS [Giảm giá]
    FROM dbo.Bill AS b, dbo.TableFood AS t
    WHERE DateCheckIn >= @checkIn 
      AND DateCheckOut <= @checkOut 
      AND b.status = 1
      AND t.id = b.idTable
END

select * from account		

CREATE PROC USP_UpdateAccount
    @userName NVARCHAR(100), 
    @displayName NVARCHAR(100), 
    @password NVARCHAR(100), 
    @newPassword NVARCHAR(100)
AS
BEGIN
    DECLARE @isRightPass INT = 0

    SELECT @isRightPass = COUNT(*) 
    FROM dbo.Account 
    WHERE UserName = @userName AND PassWord = @password

    IF (@isRightPass = 1)
    BEGIN
        IF (@newPassword = NULL OR @newPassword = '')
        BEGIN
            UPDATE dbo.Account 
            SET DisplayName = @displayName 
            WHERE UserName = @userName
        END
        ELSE
        BEGIN
            UPDATE dbo.Account 
            SET DisplayName = @displayName, PassWord = @newPassword
            WHERE UserName = @userName
        END
    END
END

select * from Food


CREATE FUNCTION [dbo].[fuConvertToUnsign1]
(
    @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN
    IF @strInput IS NULL RETURN NULL;

    DECLARE @RT NVARCHAR(4000);
    SET @RT = @strInput;

    -- Chuyển các ký tự có dấu thành không dấu
    -- Chuyển sang kiểu XML để xử lý dấu
    SET @RT = 
        CAST(
            CAST(@RT AS VARCHAR(4000)) COLLATE SQL_Latin1_General_CP1253_CI_AI
            AS NVARCHAR(4000)
        );

    RETURN @RT;
END
SELECT * 
FROM dbo.Food 
WHERE dbo.fuConvertToUnsign1(name) 
LIKE N'%' + dbo.fuConvertToUnsign1(N'ca') + N'%'
