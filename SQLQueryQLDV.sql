﻿CREATE DATABASE QLDV

USE QLDV
GO

-- THEM BANG --
CREATE TABLE THONGTIN
(
	MADV NVARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(300) NOT NULL,
	HOTENKHAISINH NVARCHAR(300),
	BIDANH NVARCHAR(300),
	GIOITINH NVARCHAR(5) DEFAULT 'NAM',
	NGAYSINH DATE,
	QUEQUAN NVARCHAR(300),
	DIACHI NVARCHAR(300),
	DANTOC NVARCHAR(200),
	TONGIAO NVARCHAR(200),
	SDT VARCHAR(20),
	EMAIL NVARCHAR(200),
	 NVARCHAR(200)
)


-- THEM THONG TIN --
CREATE TABLE THEMTHONGTIN
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20) NOT NULL,
	NGAYVAODOAN DATE,
	NOIVAODAON NVARCHAR(200),
	NGAYVAODANG_L1 DATE,
	NOIVAODANG_L1 NVARCHAR(200),
	NGAYCHINHTHUC_L1 DATE,
	NOICONGNHAN_L1 NVARCHAR(200),
	NGUOIGT_L1 NVARCHAR(200),
	CONSTRAINT PK_TTT PRIMARY KEY(ID, MADV)
)

-- NHỮNG LỚP ĐÀO TẠO - BỒI DƯỠNG ĐÃ QUA --
CREATE TABLE DAOTAO_BOIDUONG
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20),
	BATDAU DATE,
	KETTHUC DATE,
	TENLOP NVARCHAR(500),
	HINHTHUC NVARCHAR(100),
	CHUNGCHI NVARCHAR(100),
	CONSTRAINT PK_DT PRIMARY KEY(ID, MADV)
)


-- TRÌNH ĐỘ --
CREATE TABLE TRINHDO
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20),
	TRINHDOPT VARCHAR(10) NOT NULL,
	CHUYENMON NVARCHAR(200),
	HOCVI NVARCHAR(100),
	DATE_HV DATE,
	HOCHAM NVARCHAR(100),
	DATE_HH DATE,
	LYLUANCT NVARCHAR(100),
	NGOAINGU NVARCHAR(300),
	CONSTRAINT PK_TD PRIMARY KEY(ID, MADV)
)



-- QUA TRINH CONG TAC --
CREATE TABLE QUATRINHCT
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20) NOT NULL,
	MAPB NVARCHAR(20) NOT NULL,
	PHONGBAN NVARCHAR(200),
	BATDAU DATE,
	KETTHUC DATE,
	CONGVIEC NVARCHAR(200),
	DIADIEM NVARCHAR(200),
	CHUCVU NVARCHAR(200),
	CONSTRAINT PK_QTRCT PRIMARY KEY(ID, MADV)
)

DROP TABLE QUATRINHCT

-- ĐI NƯỚC NGOÀI --
CREATE TABLE DINUOCNGOAI
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20),
	BATDAU DATE,
	KETTHUC DATE,
	NOIDUNG NVARCHAR(500),
	DIADIEM NVARCHAR(100),
	CONSTRAINT PK_NNG PRIMARY KEY(ID, MADV)
)

-- KHEN THUONG --
CREATE TABLE KHENTHUONG
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20),
	THOIGIAN DATE,
	LYDO NVARCHAR(500),
	HINHTHUC NVARCHAR(200),
	CAPQUYETDINH NVARCHAR(300),
	CONSTRAINT PK_KT PRIMARY KEY(ID, MADV)
)


-- KY LUAT --
CREATE TABLE KYLUAT
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20),
	THOIGIAN DATE,
	LYDO NVARCHAR(500),
	HINHTHUC NVARCHAR(200),
	CAPQUYETDINH NVARCHAR(300),
	CONSTRAINT PK_KL PRIMARY KEY(ID, MADV)
)


-- HOAN CANH GIA DINH --
CREATE TABLE GIADINH
(
	ID INT NOT NULL IDENTITY,
	MADV NVARCHAR(20) NOT NULL,
	QUANHE NVARCHAR(100),
	HOTEN NVARCHAR(300) NOT NULL,
	NAMSINH VARCHAR(20),
	QUEQUAN NVARCHAR(300),
	DIACHI NVARCHAR(300),
	CONSTRAINT PK_GD PRIMARY KEY(ID, MADV)
)


-- NHẬN XÉT --
CREATE TABLE TUNHANXET
(
	MADV NVARCHAR(20) NOT NULL PRIMARY KEY,
	PHAMCHAT NVARCHAR(200) NOT NULL,
	DAODUC NVARCHAR(200) NOT NULL,
	NANGLUC NVARCHAR(200) NOT NULL,
	QUANHE_QC NVARCHAR(200) NOT NULL,
	KHUYETDIEM NVARCHAR(300) NOT NULL
)



CREATE TABLE DANGNHAP 
(
	MADV NVARCHAR(20) NOT NULL PRIMARY KEY,
	MAPB NVARCHAR(20),
	SDT VARCHAR(20),
	EMAIL NVARCHAR(200),
	CHUCVU NVARCHAR(200),
	PASSWD NVARCHAR(20)
)


-- TẠO KHÓA NGOẠI --
ALTER TABLE TUNHANXET
ADD 
	CONSTRAINT FK_TT_NX FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE GIADINH
ADD
	CONSTRAINT FK_TT_GD FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE KYLUAT
ADD
	CONSTRAINT FK_TT_KL FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE KHENTHUONG
ADD
	CONSTRAINT FK_TT_KT FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE DINUOCNGOAI
ADD
	CONSTRAINT FK_TT_NNG FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE DAOTAO_BOIDUONG
ADD
	CONSTRAINT FK_TT_DT FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE QUATRINHCT
ADD
	CONSTRAINT FK_TT_CT FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE TRINHDO
ADD
	CONSTRAINT FK_TT_TRD FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)

ALTER TABLE THEMTHONGTIN
ADD	
	CONSTRAINT FK_TT_THEM FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)


ALTER TABLE DANGNHAP
ADD	
	CONSTRAINT FK_TT_DN FOREIGN KEY(MADV) REFERENCES THONGTIN(MADV)




-- ĐĂNG NHẬP
CREATE PROCEDURE SP_LOGIN
@USER NVARCHAR(20), @PASSWORD NVARCHAR(20)
AS
BEGIN
	SELECT DANGNHAP.MADV, DANGNHAP.MAPB, DANGNHAP.SDT, DANGNHAP.EMAIL, DANGNHAP.CHUCVU, DANGNHAP.PASSWD, THONGTIN.HOTEN
	FROM DANGNHAP, THONGTIN
		WHERE DANGNHAP.MADV=THONGTIN.MADV AND
			(
				(DANGNHAP.MADV=@USER OR DANGNHAP.SDT=@USER OR DANGNHAP.EMAIL=@USER) AND
				DANGNHAP.PASSWD=@PASSWORD
			)
END



-- ĐỔI PASSWORD
CREATE PROCEDURE SP_CHANGE_PASSWORD
@USER NVARCHAR(20), @PASSWORD NVARCHAR(20), @NEWPASSWORD NVARCHAR(20)
AS
BEGIN
	UPDATE DANGNHAP
	SET PASSWD=@NEWPASSWORD
		WHERE DANGNHAP.PASSWD = @PASSWORD AND
		(
			DANGNHAP.MADV = @USER OR DANGNHAP.SDT = @USER OR DANGNHAP.EMAIL = @USER
		)
END



-- INSERT TABLE DANGNHAP.
-- KHI MỚI KHỞI TẠO TÀI KHOẢN THÌ:
	-- - USERNAME = MÃ ĐẢNG VIÊN
	-- - PASSWORD = MÃ ĐẢNG VIÊN


CREATE PROCEDURE SP_INSERT_DANGNHAP
@USER NVARCHAR(20)
AS
BEGIN

	INSERT INTO DANGNHAP(MADV, MAPB, SDT, EMAIL, CHUCVU, PASSWD)
	VALUES((
			SELECT THONGTIN.MADV
			FROM QUATRINHCT, THONGTIN
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		), 
		(
			SELECT QUATRINHCT.MAPB
			FROM THONGTIN, QUATRINHCT
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		),
		(
			SELECT THONGTIN.SDT
			FROM THONGTIN, QUATRINHCT
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		),
		(
			SELECT THONGTIN.EMAIL
			FROM THONGTIN, QUATRINHCT
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		),
		(
			SELECT QUATRINHCT.CHUCVU
			FROM THONGTIN, QUATRINHCT
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		), 
		(
			SELECT THONGTIN.MADV
			FROM THONGTIN, QUATRINHCT
			WHERE QUATRINHCT.MADV = THONGTIN.MADV AND THONGTIN.MADV = @USER
		)
	)

END

EXECUTE SP_INSERT_DANGNHAP 'DV001'



-- LẤY THÔNG TIN CỦA 1 ĐẢNG VIÊN ĐỂ HIỂN THỊ LÊN DANH SÁCH.
CREATE PROCEDURE SP_GET_DANHSACH
AS
BEGIN
	SELECT MADV, HOTEN, GIOITINH, NGAYSINH, QUEQUAN, SDT, EMAIL 
	FROM THONGTIN
END


-- TÌM KIẾM THEO HỌ TÊN HOẶC MÃ ĐV
CREATE PROCEDURE SP_SEARCH_DANHSACH
@INPUT NVARCHAR(100)
AS
BEGIN
	SELECT MADV, HOTEN, GIOITINH, NGAYSINH, QUEQUAN, SDT, EMAIL 
	FROM THONGTIN
	WHERE THONGTIN.HOTEN=@INPUT OR THONGTIN.MADV=@INPUT
END




select *--MAPB, PHONGBAN
from QUATRINHCT
where MADV = N'DV001'

SELECT QUATRINHCT.MAPB, PHONGBAN FROM QUATRINHCT WHERE MADV = 'DV002'


DELETE DANGNHAP WHERE MADV='DV001'








-- INSERT INTO THÔNG TIN.
CREATE PROCEDURE SP_INSERT_THONGTIN
	@MADV NVARCHAR(20),
	@HOTEN NVARCHAR(300),
	@HOTENKHAISINH NVARCHAR(300),
	@BIDANH NVARCHAR(300),
	@GIOITINH NVARCHAR(5),
	@NGAYSINH DATE,
	@QUEQUAN NVARCHAR(300),
	@DIACHI NVARCHAR(300),
	@DANTOC NVARCHAR(200),
	@TONGIAO NVARCHAR(200),
	@SDT VARCHAR(20),
	@EMAIL NVARCHAR(200),
	@ANH NVARCHAR(200)
AS
BEGIN
	INSERT INTO THONGTIN(MADV, HOTEN, HOTENKHAISINH, BIDANH, GIOITINH, NGAYSINH, QUEQUAN, DIACHI, DANTOC, TONGIAO, SDT, EMAIL, ANH)
	VALUES(	@MADV,
			@HOTEN,
			@HOTENKHAISINH,
			@BIDANH,
			@GIOITINH,
			@NGAYSINH,
			@QUEQUAN,
			@DIACHI,
			@DANTOC,
			@TONGIAO,
			@SDT,
			@EMAIL,
			@ANH
		)
END



-- INSERT INTO THÊM THÔNG TIN.
CREATE PROCEDURE SP_INSERT_THEMTHONGTIN_0
@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200),
	@NGAYVAODANG_L1 DATE,
	@NOIVAODANG_L1 NVARCHAR(200),
	@NGAYCHINHTHUC_L1 DATE,
	@NOICONGNHAN_L1 NVARCHAR(200),
	@NGUOIGT_L1 NVARCHAR(200)

AS
BEGIN
	INSERT INTO THEMTHONGTIN(MADV, NGAYVAODOAN, NOIVAODAON, NGAYVAODANG_L1, NOIVAODANG_L1, NGAYCHINHTHUC_L1, NOICONGNHAN_L1, NGUOIGT_L1)
	VALUES(	@MADV,
			@NGAYVAODOAN,
			@NOIVAODAON,
			@NGAYVAODANG_L1,
			@NOIVAODANG_L1,
			@NGAYCHINHTHUC_L1,
			@NOICONGNHAN_L1,
			@NGUOIGT_L1
		)
END


CREATE PROCEDURE SP_INSERT_THEMTHONGTIN_1
@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200),
	@NGAYVAODANG_L1 DATE,
	@NOIVAODANG_L1 NVARCHAR(200),
	@NGUOIGT_L1 NVARCHAR(200)

AS
BEGIN
	INSERT INTO THEMTHONGTIN(MADV, NGAYVAODOAN, NOIVAODAON, NGAYVAODANG_L1, NOIVAODANG_L1, NGUOIGT_L1)
	VALUES(	@MADV,
			@NGAYVAODOAN,
			@NOIVAODAON,
			@NGAYVAODANG_L1,
			@NOIVAODANG_L1,
			@NGUOIGT_L1
		)
END


CREATE PROCEDURE SP_INSERT_THEMTHONGTIN_2
@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200)

AS
BEGIN
	INSERT INTO THEMTHONGTIN(MADV, NGAYVAODOAN, NOIVAODAON)
	VALUES(	@MADV,
			@NGAYVAODOAN,
			@NOIVAODAON
		)
END


DROP PROCEDURE SP_INSERT_THEMTHONGTIN


EXECUTE SP_INSERT_THEMTHONGTIN_2 N'DV001', '03/26/1985', N'THCS ABC'


DELETE THEMTHONGTIN WHERE MADV=N'DV001'




-- INSERT INTO ĐÀO TẠO - BỒI DUÕNG.
CREATE PROCEDURE SP_INSERT_DAOTAO_BOIDUONG
	@MADV NVARCHAR(20),
	@BATDAU DATE,
	@KETTHUC DATE,
	@TENLOP NVARCHAR(500),
	@HINHTHUC NVARCHAR(100),
	@CHUNGCHI NVARCHAR(100)
AS
BEGIN
	INSERT INTO DAOTAO_BOIDUONG(MADV, BATDAU, KETTHUC, TENLOP, HINHTHUC, CHUNGCHI)
	VALUES(	@MADV,
			@BATDAU,
			@KETTHUC,
			@TENLOP,
			@HINHTHUC,
			@CHUNGCHI
		)
END




-- INSERT INTO TRÌNH ĐỘ
CREATE PROCEDURE SP_INSERT_TRINHDO_0
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@HOCVI NVARCHAR(100),
	@DATE_HV DATE,
	@HOCHAM NVARCHAR(100),
	@DATE_HH DATE,
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	INSERT INTO TRINHDO(MADV, TRINHDOPT, CHUYENMON, HOCVI, DATE_HV, HOCHAM, DATE_HH, LYLUANCT, NGOAINGU)
	VALUES(	@MADV,
			@TRINHDOPT,
			@CHUYENMON,
			@HOCVI,
			@DATE_HV,
			@HOCHAM,
			@DATE_HH,
			@LYLUANCT,
			@NGOAINGU
		)
END


CREATE PROCEDURE SP_INSERT_TRINHDO_1
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@HOCVI NVARCHAR(100),
	@DATE_HV DATE,
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	INSERT INTO TRINHDO(MADV, TRINHDOPT, CHUYENMON, HOCVI, DATE_HV, LYLUANCT, NGOAINGU)
	VALUES(	@MADV,
			@TRINHDOPT,
			@CHUYENMON,
			@HOCVI,
			@DATE_HV,
			@LYLUANCT,
			@NGOAINGU
		)
END


CREATE PROCEDURE SP_INSERT_TRINHDO_2
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	INSERT INTO TRINHDO(MADV, TRINHDOPT, CHUYENMON, LYLUANCT, NGOAINGU)
	VALUES(	@MADV,
			@TRINHDOPT,
			@CHUYENMON,
			@LYLUANCT,
			@NGOAINGU
		)
END


DROP PROCEDURE SP_INSERT_TRINHDO


-- INSERT INTO QUÁ TRÌNH CÔNG TÁC
CREATE PROCEDURE SP_INSERT_QUATRINHCT_0
	@MADV NVARCHAR(20),
	@MAPB NVARCHAR(20),
	@PHONGBAN NVARCHAR(200),
	@BATDAU DATE,
	@KETTHUC DATE,
	@CONGVIEC NVARCHAR(200),
	@DIADIEM NVARCHAR(200),
	@CHUCVU NVARCHAR(200)
AS
BEGIN
	INSERT INTO QUATRINHCT(MADV, MAPB, PHONGBAN, BATDAU, KETTHUC, CONGVIEC, DIADIEM, CHUCVU)
	VALUES(	@MADV,
			@MAPB,
			@PHONGBAN,
			@BATDAU,
			@KETTHUC,
			@CONGVIEC,
			@DIADIEM,
			@CHUCVU
		)
END


CREATE PROCEDURE SP_INSERT_QUATRINHCT_1
	@MADV NVARCHAR(20),
	@MAPB NVARCHAR(20),
	@PHONGBAN NVARCHAR(200),
	@BATDAU DATE,
	@CONGVIEC NVARCHAR(200),
	@DIADIEM NVARCHAR(200),
	@CHUCVU NVARCHAR(200)
AS
BEGIN
	INSERT INTO QUATRINHCT(MADV, MAPB, PHONGBAN, BATDAU, CONGVIEC, DIADIEM, CHUCVU)
	VALUES(	@MADV,
			@MAPB,
			@PHONGBAN,
			@BATDAU,
			@CONGVIEC,
			@DIADIEM,
			@CHUCVU
		)
END



-- INSERT INTO ĐI NƯỚC NGOÀI
CREATE PROCEDURE SP_INSERT_DINUOCNGOAI
	@MADV NVARCHAR(20),
	@BATDAU DATE,
	@KETTHUC DATE,
	@NOIDUNG NVARCHAR(500),
	@DIADIEM NVARCHAR(100)
AS
BEGIN
	INSERT INTO DINUOCNGOAI(MADV, BATDAU, KETTHUC, NOIDUNG, DIADIEM)
	VALUES(	@MADV,
			@BATDAU,
			@KETTHUC,
			@NOIDUNG,
			@DIADIEM
		)
END




-- INSERT INTO KHEN THƯỞNG
CREATE PROCEDURE SP_INSERT_KHENTHUONG
	@MADV NVARCHAR(20),
	@THOIGIAN DATE,
	@LYDO NVARCHAR(500),
	@HINHTHUC NVARCHAR(200),
	@CAPQUYETDINH NVARCHAR(300)
AS
BEGIN
	INSERT INTO KHENTHUONG(MADV, THOIGIAN, LYDO, HINHTHUC, CAPQUYETDINH)
	VALUES(	@MADV,
			@THOIGIAN,
			@LYDO,
			@HINHTHUC,
			@CAPQUYETDINH
		)
END




-- INSERT INTO KỶ LUẬT
CREATE PROCEDURE SP_INSERT_KYLUAT
	@MADV NVARCHAR(20),
	@THOIGIAN DATE,
	@LYDO NVARCHAR(500),
	@HINHTHUC NVARCHAR(200),
	@CAPQUYETDINH NVARCHAR(300)
AS
BEGIN
	INSERT INTO KYLUAT(MADV, THOIGIAN, LYDO, HINHTHUC, CAPQUYETDINH)
	VALUES(	@MADV,
			@THOIGIAN,
			@LYDO,
			@HINHTHUC,
			@CAPQUYETDINH
		)
END


-- INSERT INTO GIA ĐÌNH
CREATE PROCEDURE SP_INSERT_GIADINH
	@MADV NVARCHAR(20),
	@QUANHE NVARCHAR(100),
	@HOTEN NVARCHAR(300),
	@NAMSINH VARCHAR(20),
	@QUEQUAN NVARCHAR(300),
	@DIACHI NVARCHAR(300)
AS
BEGIN
	INSERT INTO GIADINH(MADV, QUANHE, HOTEN, NAMSINH, QUEQUAN, DIACHI)
	VALUES(	@MADV,
			@QUANHE,
			@HOTEN,
			@NAMSINH,
			@QUEQUAN,
			@DIACHI
		)
END



-- INSERT INTO TỰ NHẬN XÉT
CREATE PROCEDURE SP_INSERT_TUNHANXET
	@MADV NVARCHAR(20),
	@PHAMCHAT NVARCHAR(200),
	@DAODUC NVARCHAR(200),
	@NANGLUC NVARCHAR(200),
	@QUANHE_QC NVARCHAR(200),
	@KHUYETDIEM NVARCHAR(300)
AS
BEGIN
	INSERT INTO TUNHANXET(MADV, PHAMCHAT, DAODUC, NANGLUC, QUANHE_QC, KHUYETDIEM)
	VALUES(	@MADV,
			@PHAMCHAT,
			@DAODUC,
			@NANGLUC,
			@QUANHE_QC,
			@KHUYETDIEM
		)
END




EXECUTE SP_INSERT_TUNHANXET N'DV001', N'TỐT', N'TỐT', N'TỐT', N'TỐT', N'KHÔNG'

delete TUNHANXET where MADV=N'dv001' or MADV=N'dv002'

insert into TUNHANXET
values(N'DV001', N'TỐT', N'TỐT', N'TỐT', N'TỐT', N'KHÔNG')









-- UPDATE THÔNG TIN.
CREATE PROCEDURE SP_UPDATE_THONGTIN
	@MADV NVARCHAR(20),
	@HOTEN NVARCHAR(300),
	@HOTENKHAISINH NVARCHAR(300),
	@BIDANH NVARCHAR(300),
	@GIOITINH NVARCHAR(5),
	@NGAYSINH DATE,
	@QUEQUAN NVARCHAR(300),
	@DIACHI NVARCHAR(300),
	@DANTOC NVARCHAR(200),
	@TONGIAO NVARCHAR(200),
	@SDT VARCHAR(20),
	@EMAIL NVARCHAR(200),
	@ANH NVARCHAR(200)
AS
BEGIN
	UPDATE THONGTIN
		SET		
				HOTEN = @HOTEN,
				HOTENKHAISINH = @HOTENKHAISINH,
				BIDANH = @BIDANH,
				GIOITINH=@GIOITINH,
				NGAYSINH=@NGAYSINH,
				QUEQUAN = @QUEQUAN,
				DIACHI= @DIACHI,
				DANTOC = @DANTOC,
				TONGIAO = @TONGIAO,
				SDT = @SDT,
				EMAIL = @EMAIL,
				ANH=  @ANH

	WHERE
		THONGTIN.MADV = @MADV
END



-- UPDATE THÊM THÔNG TIN.
CREATE PROCEDURE SP_UPDATE_THEMTHONGTIN_0
	@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200),
	@NGAYVAODANG_L1 DATE,
	@NOIVAODANG_L1 NVARCHAR(200),
	@NGAYCHINHTHUC_L1 DATE,
	@NOICONGNHAN_L1 NVARCHAR(200),
	@NGUOIGT_L1 NVARCHAR(200)

AS
BEGIN
	UPDATE THEMTHONGTIN
	SET		
			NGAYVAODOAN = @NGAYVAODOAN,
			NOIVAODAON = @NOIVAODAON,
			NGAYVAODANG_L1 = @NGAYVAODANG_L1,
			NOIVAODANG_L1 = @NOIVAODANG_L1,
			NGAYCHINHTHUC_L1 = @NGAYCHINHTHUC_L1,
			NOICONGNHAN_L1 = @NOICONGNHAN_L1,
			NGUOIGT_L1 = @NGUOIGT_L1
	WHERE
		THEMTHONGTIN.MADV=@MADV
END


CREATE PROCEDURE SP_UPDATE_THEMTHONGTIN_1
	@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200),
	@NGAYVAODANG_L1 DATE,
	@NOIVAODANG_L1 NVARCHAR(200),
	@NGUOIGT_L1 NVARCHAR(200)

AS
BEGIN
	UPDATE THEMTHONGTIN
	SET		
			NGAYVAODOAN = @NGAYVAODOAN,
			NOIVAODAON = @NOIVAODAON,
			NGAYVAODANG_L1 = @NGAYVAODANG_L1,
			NOIVAODANG_L1 = @NOIVAODANG_L1,
			NGUOIGT_L1 = @NGUOIGT_L1
	WHERE
		THEMTHONGTIN.MADV=@MADV
END


CREATE PROCEDURE SP_UPDATE_THEMTHONGTIN_2
	@MADV NVARCHAR(20),
	@NGAYVAODOAN DATE,
	@NOIVAODAON NVARCHAR(200)

AS
BEGIN
	UPDATE THEMTHONGTIN
	SET		
			NGAYVAODOAN = @NGAYVAODOAN,
			NOIVAODAON = @NOIVAODAON
	WHERE
		THEMTHONGTIN.MADV=@MADV
END






-- UPDATE  ĐÀO TẠO - BỒI DUÕNG.
CREATE PROCEDURE SP_UPDATE_DAOTAO_BOIDUONG
	@MADV NVARCHAR(20),
	@BATDAU DATE,
	@KETTHUC DATE,
	@TENLOP NVARCHAR(500),
	@HINHTHUC NVARCHAR(100),
	@CHUNGCHI NVARCHAR(100)
AS
BEGIN
	UPDATE DAOTAO_BOIDUONG
	SET
			BATDAU= @BATDAU,
			KETTHUC = @KETTHUC,
			TENLOP = @TENLOP,
			HINHTHUC = @HINHTHUC,
			CHUNGCHI = @CHUNGCHI
	WHERE
		DAOTAO_BOIDUONG.MADV=@MADV
END






-- UPDATE TRÌNH ĐỘ
CREATE PROCEDURE SP_UPDATE_TRINHDO_0
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@HOCVI NVARCHAR(100),
	@DATE_HV DATE,
	@HOCHAM NVARCHAR(100),
	@DATE_HH DATE,
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	UPDATE TRINHDO
	SET
			TRINHDOPT = @TRINHDOPT,
			CHUYENMON = @CHUYENMON,
			HOCVI = @HOCVI,
			DATE_HV = @DATE_HV,
			HOCHAM = @HOCHAM,
			DATE_HH = @DATE_HH,
			LYLUANCT = @LYLUANCT,
			NGOAINGU = @NGOAINGU
	WHERE
		TRINHDO.MADV = @MADV
END


CREATE PROCEDURE SP_UPDATE_TRINHDO_1
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@HOCVI NVARCHAR(100),
	@DATE_HV DATE,
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	UPDATE TRINHDO
	SET
			TRINHDOPT = @TRINHDOPT,
			CHUYENMON = @CHUYENMON,
			HOCVI = @HOCVI,
			DATE_HV = @DATE_HV,
			LYLUANCT = @LYLUANCT,
			NGOAINGU = @NGOAINGU
	WHERE
		TRINHDO.MADV = @MADV
END



CREATE PROCEDURE SP_UPDATE_TRINHDO_2
	@MADV NVARCHAR(20),
	@TRINHDOPT VARCHAR(10),
	@CHUYENMON NVARCHAR(200),
	@LYLUANCT NVARCHAR(100),
	@NGOAINGU NVARCHAR(300)
AS
BEGIN
	UPDATE TRINHDO
	SET
			TRINHDOPT = @TRINHDOPT,
			CHUYENMON = @CHUYENMON,
			LYLUANCT = @LYLUANCT,
			NGOAINGU = @NGOAINGU
	WHERE
		TRINHDO.MADV = @MADV
END





-- UPDATE QUÁ TRÌNH CÔNG TÁC
CREATE PROCEDURE SP_UPDATE_QUATRINHCT_0
	@MADV NVARCHAR(20),
	@MAPB NVARCHAR(20),
	@PHONGBAN NVARCHAR(200),
	@BATDAU DATE,
	@KETTHUC DATE,
	@CONGVIEC NVARCHAR(200),
	@DIADIEM NVARCHAR(200),
	@CHUCVU NVARCHAR(200)
AS
BEGIN
	UPDATE QUATRINHCT
	SET
			MAPB = @MAPB,
			PHONGBAN = @PHONGBAN,
			BATDAU = @BATDAU,
			KETTHUC = @KETTHUC,
			CONGVIEC = @CONGVIEC,
			DIADIEM = @DIADIEM,
			CHUCVU = @CHUCVU
	WHERE
		QUATRINHCT.MADV = @MADV
END



CREATE PROCEDURE SP_UPDATE_QUATRINHCT_1
	@MADV NVARCHAR(20),
	@MAPB NVARCHAR(20),
	@PHONGBAN NVARCHAR(200),
	@BATDAU DATE,
	@CONGVIEC NVARCHAR(200),
	@DIADIEM NVARCHAR(200),
	@CHUCVU NVARCHAR(200)
AS
BEGIN
	UPDATE QUATRINHCT
	SET
			MAPB = @MAPB,
			PHONGBAN = @PHONGBAN,
			BATDAU = @BATDAU,
			CONGVIEC = @CONGVIEC,
			DIADIEM = @DIADIEM,
			CHUCVU = @CHUCVU
	WHERE
		QUATRINHCT.MADV = @MADV
END



-- UPDATE INTO ĐI NƯỚC NGOÀI
CREATE PROCEDURE SP_UPDATE_DINUOCNGOAI
	@MADV NVARCHAR(20),
	@BATDAU DATE,
	@KETTHUC DATE,
	@NOIDUNG NVARCHAR(500),
	@DIADIEM NVARCHAR(100)
AS
BEGIN
	UPDATE DINUOCNGOAI
	SET
			BATDAU = @BATDAU,
			KETTHUC = @KETTHUC,
			NOIDUNG = @NOIDUNG,
			DIADIEM = @DIADIEM
	WHERE
		DINUOCNGOAI.MADV=@MADV
END



-- UPDATE KHEN THƯỞNG
CREATE PROCEDURE SP_UPDATE_KHENTHUONG
	@MADV NVARCHAR(20),
	@THOIGIAN DATE,
	@LYDO NVARCHAR(500),
	@HINHTHUC NVARCHAR(200),
	@CAPQUYETDINH NVARCHAR(300)
AS
BEGIN
	UPDATE KHENTHUONG
	SET
			THOIGIAN = @THOIGIAN,
			LYDO = @LYDO,
			HINHTHUC = @HINHTHUC,
			CAPQUYETDINH = @CAPQUYETDINH
	WHERE
		KHENTHUONG.MADV=@MADV
END



-- UPDATE KỶ LUẬT
CREATE PROCEDURE SP_UPDATE_KYLUAT
	@MADV NVARCHAR(20),
	@THOIGIAN DATE,
	@LYDO NVARCHAR(500),
	@HINHTHUC NVARCHAR(200),
	@CAPQUYETDINH NVARCHAR(300)
AS
BEGIN
	UPDATE KYLUAT
	SET
			THOIGIAN = @THOIGIAN,
			LYDO = @LYDO,
			HINHTHUC = @HINHTHUC,
			CAPQUYETDINH = @CAPQUYETDINH
	WHERE
		KYLUAT.MADV=@MADV
END




-- UPDATE GIA ĐÌNH
CREATE PROCEDURE SP_UPDATE_GIADINH
	@MADV NVARCHAR(20),
	@QUANHE NVARCHAR(100),
	@HOTEN NVARCHAR(300),
	@NAMSINH VARCHAR(20),
	@QUEQUAN NVARCHAR(300),
	@DIACHI NVARCHAR(300)
AS
BEGIN
	UPDATE GIADINH
	SET
			QUANHE = @QUANHE,
			HOTEN = @HOTEN,
			NAMSINH = @NAMSINH,
			QUEQUAN = @QUEQUAN,
			DIACHI = @DIACHI
	WHERE 
		GIADINH.MADV=@MADV
END



-- UPDATE TỰ NHẬN XÉT
CREATE PROCEDURE SP_UPDATE_TUNHANXET
	@MADV NVARCHAR(20),
	@PHAMCHAT NVARCHAR(200),
	@DAODUC NVARCHAR(200),
	@NANGLUC NVARCHAR(200),
	@QUANHE_QC NVARCHAR(200),
	@KHUYETDIEM NVARCHAR(300)
AS
BEGIN
	UPDATE TUNHANXET
	SET
			PHAMCHAT = @PHAMCHAT,
			DAODUC = @DAODUC,
			NANGLUC = @NANGLUC,
			QUANHE_QC = @QUANHE_QC,
			KHUYETDIEM = @KHUYETDIEM
	WHERE
		TUNHANXET.MADV=@MADV
END




-- CHEN DU LIEU --
INSERT INTO THONGTIN (MADV, HOTEN, HOTENKHAISINH, BIDANH, GIOITINH, NGAYSINH, QUEQUAN, DIACHI, DANTOC, TONGIAO, SDT, EMAIL, ANH)
VALUES(N'DV001', N'NGUYỄN VĂN A', N'NGUYỄN VĂN A','' , N'NAM', '08/22/1969', N'HÀ NỘI', N'CHIẾN THẮNG - TÂN TRIỀU - THANH TRÌ', N'KINH', N'KHÔNG',0123456789,N'emailA@gmail.com', N'ANH1.JPG')

INSERT INTO THONGTIN (MADV, HOTEN, HOTENKHAISINH, BIDANH, GIOITINH, NGAYSINH, QUEQUAN, DIACHI, DANTOC, TONGIAO, SDT, EMAIL, ANH)
VALUES(N'DV002', N'NGUYỄN THỊ B', N'NGUYỄN VĂN B','' , N'NỮ', '08/19/1972', N'HÀ NỘI', N'SN 02 - TÂN TRIỀU - THANH TRÌ', N'KINH', N'KHÔNG',0123443210,N'emailB@gmail.com', N'ANH2.JPG')




INSERT INTO QUATRINHCT(MADV, MAPB, PHONGBAN, BATDAU, KETTHUC, CONGVIEC, DIADIEM, CHUCVU)
VALUES(N'DV001', N'CTTC', N'CHÍNH TRỊ TỔ CHỨC', '02/21/2010', '09/20/2016', N'CÔNG VIỆC TC A', N'PHÒNG CHÍNH TRỊ TỔ CHỨC', N' TRƯỞNG PHÒNG')



INSERT INTO QUATRINHCT(MADV, MAPB, PHONGBAN, BATDAU, KETTHUC, CONGVIEC, DIADIEM, CHUCVU)
VALUES(N'DV002', N'CTTC', N'CHÍNH TRỊ TỔ CHỨC', '02/21/2010', '09/20/2016', N'CÔNG VIỆC TC B', N'PHÒNG CHÍNH TRỊ TỔ CHỨC', N'PHÓ TRƯỞNG PHÒNG')


DELETE THONGTIN WHERE MADV=N'5'