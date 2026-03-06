CREATE DATABASE WellmeadowsDB
ON PRIMARY 
(
    NAME = WellmeadowsDB_DAT,
    FILENAME = 'Your Databases Path',
    SIZE = 100MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 10%
)
LOG ON
(
    NAME = WellmeadowsDB_LOG,
    FILENAME = 'Your Databases Path',
    SIZE = 50MB,
    MAXSIZE = 2048GB, 
    FILEGROWTH = 10%
);

---------------------------------------

CREATE TABLE Staff
(
	StaffID int PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	DateBirth date NOT NULL,
	Sex Char(6) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone char(10) NOT NULL,
	NIN char(13) NOT NULL,
	Position varchar(30) NOT NULL,
	Salary decimal(10,2) NOT NULL,
	SalaryScale int NOT NULL,
	ContractType char(9) NOT NULL,
	HoursPerWeek int NOT NULL,
	PayType char(7) NOT NULL
)


INSERT INTO Staff
(StaffID, FirstName, LastName, DateBirth, Sex, Address, Phone, NIN, Position, Salary, SalaryScale, ContractType, HoursPerWeek, PayType)
VALUES
(35, 'Suda', 'Chanthira', '1990-07-25', 'Female', '45 Ratchada, Bangkok', '0898765432', '2234567890123', 'Nurse', 28000.00, 5, 'FullTime', 36, 'Monthly'),
(36, 'Prasert', 'Thongchai', '1978-11-03', 'Male', '88 Chiang Mai Rd, Chiang Mai', '0861122334', '3234567890123', 'Surgeon', 72000.00, 9, 'FullTime', 45, 'Monthly'),
(37, 'Anong', 'Phanthip', '1988-01-19', 'Female', '99 Khon Kaen City', '0859988776', '4234567890123', 'Pharmacist', 40000.00, 6, 'FullTime', 38, 'Monthly'),
(38, 'Kittipong', 'Manop', '1995-05-10', 'Male', '12 Phuket Town', '0843344556', '5234567890123', 'Technician', 22000.00, 4, 'PartTime', 20, 'Hourly'),
(39, 'Malinee', 'Sirikul', '1992-09-14', 'Female', '77 Pattaya City', '0835566778', '6234567890123', 'Receptionist', 18000.00, 3, 'FullTime', 35, 'Monthly');

---------------------------------------

CREATE TABLE StaffQualification
(
	QualID int PRIMARY KEY,
	StaffID int NOT NULL,
	Type varchar(50) NOT NULL,
	Institution varchar(50) NOT NULL,	
	Date DATE NOT NULL,
    CONSTRAINT staffIDQual_fk FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

INSERT INTO StaffQualification (QualID, StaffID, Type, Institution, Date)
VALUES
(8, 34, 'Bachelor of Nursing', 'Chulalongkorn University', '2013-06-20'),
(9, 35, 'Surgery Residency', 'Siriraj Hospital', '2012-09-10'),
(10, 36, 'Bachelor of Pharmacy', 'Chiang Mai University', '2011-05-30'),
(11, 37, 'Medical Technician Diploma', 'Khon Kaen University', '2016-07-12'),
(12, 38, 'Certificate in Hospital Admin', 'Burapha University', '2017-11-25');

---------------------------------------

CREATE TABLE StaffWorkExp
(
	ExpID int PRIMARY KEY,
	StaffID int NOT NULL,
	Organization varchar(50) NOT NULL,
	Position varchar(50) NOT NULL,	
	StartDate date NOT NULL,
	EndDate date NOT NULL,
    CONSTRAINT staffIDWork_fk FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

INSERT INTO StaffWorkExp (ExpID, StaffID, Organization, Position, StartDate, EndDate)
VALUES
(12, 33, 'Siriraj Hospital', 'Attending Physician', '2015-06-01', '2019-12-31'),
(13, 34, 'Chulalongkorn Hospital', 'Registered Nurse', '2014-01-01', '2018-12-31'),
(14, 35, 'Ramathibodi Hospital', 'Surgical Fellow', '2013-01-01', '2017-12-31'),
(15, 36, 'Chiang Mai Hospital', 'Pharmacist', '2012-06-01', '2016-12-31'),
(16, 37, 'Khon Kaen Lab Center', 'Lab Technician', '2017-01-01', '2020-12-31');

---------------------------------------

CREATE TABLE Ward
(
    WardID      INT          NOT NULL PRIMARY KEY,
    WardName    VARCHAR(30)  NOT NULL,
    Location    VARCHAR(30)  NOT NULL,
    TelExtn     CHAR(4)      NOT NULL,
    ChargeNurseID INT NULL,
    CONSTRAINT ChargeNurseID_FK FOREIGN KEY (ChargeNurseID) REFERENCES Staff(StaffID)
);

INSERT INTO Ward (WardID, WardName, Location, TelExtn, ChargeNurseID)
VALUES
(18, 'Surgical Ward',  'Building A - Floor 3', '2102', 34),
(19, 'Pediatric Ward', 'Building B - Floor 1', '3101', 34),
(20, 'ICU',            'Building B - Floor 2', '3102', NULL),
(21, 'Maternity Ward', 'Building C - Floor 1', '4101', 34);
(22, 'Psychiatric Ward', 'Building C - Floor 2', '4102', 36);

---------------------------------------

CREATE TABLE Week
(
    WeekID INT NOT NULL PRIMARY KEY,
    WeekNo VARCHAR(30)  NOT NULL,
	StartDate date NOT NULL,
	EndDate date NOT NULL
);

INSERT INTO Week (WeekID, WeekNo, StartDate, EndDate)
VALUES
(8, 8, '2025-02-27', '2025-03-06'),
(9, 9, '2025-03-07', '2025-03-14'),
(10, 10, '2025-03-15', '2025-03-22'),
(11, 11, '2025-03-23', '2025-03-30'),
(12, 12, '2025-03-31', '2025-04-07');


---------------------------------------

CREATE TABLE StaffAllocation
(
    StaffAllocationID INT NOT NULL PRIMARY KEY,
    StaffID INT NOT NULL,
    WardID INT  NOT NULL,
    WeekID INT  NOT NULL,
    ShiftName VARCHAR(20) NOT NULL,
    CONSTRAINT StaffIDAllocate_FK FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
	CONSTRAINT WardIDAllocate_FK FOREIGN KEY (WardID) REFERENCES Ward(WardID),
	CONSTRAINT WeekIDAllocate_FK FOREIGN KEY (WeekID) REFERENCES Week(WeekID)
);

INSERT INTO StaffAllocation (StaffAllocationID, StaffID, WardID, WeekID, ShiftName)
VALUES
(10, 30, 5, 2, 'Morning'),
(11, 31, 5, 1, 'Evening'),
(12, 32, 7, 1, 'Night'),
(13, 33, 12, 2, 'Morning'),
(14, 34, 15, 2, 'Night');


---------------------------------------

CREATE TABLE Clinic
(
	ClinicNo int PRIMARY KEY,
	ClinicName varchar(50) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone char(10) NULL,
);

INSERT INTO Clinic (ClinicNo, ClinicName, Address, Phone)
VALUES
(7, 'Pediatric Clinic', 'Building B, Floor 2', '0898765432'),
(8, 'Surgical Clinic', 'Building A, Floor 3', '0823456789'),
(9, 'Dental Clinic', 'Building C, Floor 1', '0865432198'),
(10, 'Psychiatric Clinic', 'Building C, Floor 2', '0854321987'),
(11, 'Dermatology Clinic', 'Building B, Floor 3', '0834567890');


---------------------------------------

CREATE TABLE LocalDoctor
(
	LocalDoctorID int PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone char(10) NULL,
	ClinicNo int NULL,
	CONSTRAINT ClinicNo_FK FOREIGN KEY (ClinicNo) REFERENCES Clinic(ClinicNo)
);

INSERT INTO LocalDoctor (LocalDoctorID, FirstName, LastName, Address, Phone, ClinicNo)
VALUES
(7, 'Anong', 'Sirilak', '45 Ratchada Rd, Bangkok', '0822222222', 1),
(8, 'Kittipong', 'Manop', '88 Nimmanhaemin Rd, Chiang Mai', '0833333333', 2),
(9, 'Malinee', 'Chanthra', '12 Jomtien Beach, Pattaya', '0844444444', 3),
(10, 'Worawut', 'Kanchana', '77 Samkong, Phuket', '0855555555', 4),
(11, 'Supaporn', 'Decha', '99 Thapae Rd, Chiang Mai', '0866666666', 5);

---------------------------------------

CREATE TABLE Patient
(
	PatientID int PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	DateBirth date NOT NULL,
	Sex Char(6) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone char(10) NULL,
	MartialStatus char(10) NOT NULL,
	DateRegistered date NOT NULL,
	LocalDoctorID int NULL,
	CONSTRAINT LocalDoctorID_FK FOREIGN KEY (LocalDoctorID) REFERENCES LocalDoctor(LocalDoctorID)
);

INSERT INTO dbo.Patient
    (PatientID, FirstName, LastName, DateBirth, Sex, Address, Phone, MartialStatus, DateRegistered, LocalDoctorID)
VALUES
(17, 'Somchai', 'Prasert', '1985-04-12', 'Male', '99/1 Sukhumvit Rd, Bangkok', '0812345678', 'Married', '2023-01-15', 1),
(18, 'Anong', 'Chaiyasit', '1990-09-25', 'Female', '12/45 Rama 9 Rd, Bangkok', '0823456789', 'Single',  '2023-02-10', 2),
(19, 'Wirote', 'Boonsong', '1978-07-03', 'Male', '45/3 Chiang Mai Rd, Chiang Mai', '0834567890', 'Married', '2023-03-05', 1),
(20, 'Sasithorn', 'Wattanakorn', '2000-12-20', 'Female', '22/7 Pattaya Rd, Chonburi', '0845678901', 'Single', '2023-04-18', 3),
(21, 'Kittipong', 'Rattanakorn', '1995-05-30', 'Male', '88/9 Phuket Town, Phuket', '0856789012', 'Single', '2023-05-22', NULL);

---------------------------------------

CREATE TABLE NextOfKin
(
	NextOfKinID int PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	Relationship varchar(20) NOT NULL,
	Address varchar(100) NOT NULL,
	Phone char(10) NULL,
	PatientID int NOT NULL,
	CONSTRAINT PatientNOK_FK FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);

INSERT INTO NextOfKin (NextOfKinID, FirstName, LastName, Relationship, Address, Phone, PatientID)
VALUES
(10, 'Wilawan',  'Worawong',   'Mother',  '45 Chiang Mai',   '0823334455', 12),
(11, 'Chaiwat',  'Pradit',     'Spouse',  '88 Khon Kaen',    '0834445566', 13),
(12, 'Sunee',    'Chantra',    'Sister',  '12 Phuket Town',  '0845556677', 14),
(13, 'Prasert',  'Kanchana',   'Brother', '77 Pattaya',      '0856667788', 15),
(14, 'Kanokwan', 'Decha',      'Mother',  '99 Bangkok',      '0867778899', 16);


---------------------------------------

CREATE TABLE Room
(
	RoomID int PRIMARY KEY,
	RoomNo varchar(10) NOT NULL UNIQUE,
	RoomType varchar(50) NULL,
	Capacity INT NOT NULL,
	Status varchar(20) NULL
);

INSERT INTO Room (RoomID, RoomNo, RoomType, Capacity, Status)
VALUES
(12, '112', 'General', 4, 'Occupied'),
(13, '113', 'Private', 1, 'Available'),
(14, '114', 'ICU', 2, 'Occupied'),
(15, '115', 'Maternity', 3, 'Available'),
(16, '116', 'Pediatric', 2, 'Available');

---------------------------------------

CREATE TABLE Appointment
(
    AppointmentID INT PRIMARY KEY, 
    Date date NOT NULL,
	Time varchar(20) NOT NULL,
    PatientID INT NOT NULL,
    ConsultantStaffID INT NOT NULL,
    RoomID INT NOT NULL,
    CONSTRAINT AppointPatient_FK FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
    CONSTRAINT AppointStaff_FK FOREIGN KEY (ConsultantStaffID) REFERENCES Staff(StaffID),
    CONSTRAINT AppointRoom_FK FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);

INSERT INTO Appointment (AppointmentID, Date, Time, PatientID, ConsultantStaffID, RoomID)
VALUES
(12, '2025-02-05', '10:30', 12, 34, 12),
(13, '2025-02-06', '14:00', 13, 35, 13),
(14, '2025-02-06', '15:00', 14, 36, 14),
(15, '2025-02-07', '09:30', 15, 37, 15),
(16, '2025-02-07', '11:00', 16, 38, 16);


---------------------------------------

Create Table Bed
(
	BedID int PRIMARY KEY,
	BedNo varchar(10) NOT NULL,
	Status varchar(20) NULL,
	Description varchar(50) NULL,
	WardID int NOT NULL,
	CONSTRAINT BedWardID_FK FOREIGN KEY (WardID) REFERENCES Ward(WardID)
);

INSERT INTO Bed (BedID, BedNo, Status, Description, WardID)
VALUES
(29, 'W4-02', 'Available', 'Ward 4 - Bed 2', 4), 
(30, 'W4-03', 'Available', 'Ward 4 - Bed 3', 4),  
(31, 'W5-02', 'Available', 'Ward 5 - Bed 2', 5),  
(32, 'W6-02', 'Available', 'Ward 6 - Bed 2', 6), 
(33, 'W7-02', 'Available', 'Ward 7 - Bed 2', 7);   


---------------------------------------

CREATE TABLE Inpatient
(
    InpatientID INT PRIMARY KEY, 
    DateWaitingList date NOT NULL,
	ExpectedDayStay char(10) NOT NULL,
	DatePlaced date NULL,
	DateLeave date NULL,
	DateActualLeave date NULL,
	PatientID int NOT NULL,
	BedID int NOT NULL,
	WardID int NOT NULL,
    StaffID INT NULL,
    CONSTRAINT InpatientStaff_FK FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
    CONSTRAINT InpatientPatient_FK FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
    CONSTRAINT InpatientBed_FK FOREIGN KEY (BedID) REFERENCES Bed(BedID),
    CONSTRAINT InpatientWard_FK FOREIGN KEY (WardID) REFERENCES Ward(WardID)
);


INSERT INTO Inpatient (InpatientID, DateWaitingList, ExpectedDayStay, DatePlaced, DateLeave, DateActualLeave, PatientID, BedID, WardID)
VALUES
(12, '2025-02-02', '7', NULL, NULL, NULL, 12, 7, 3),
(13, '2025-02-03', '10', NULL, NULL, NULL, 13, 8, 4),
(14, '2025-02-03', '3', NULL, NULL, NULL, 14, 9, 5),
(15, '2025-01-25', '4', '2025-01-26', '2025-01-30', '2025-01-29', 15, 10, 6),
(16, '2025-01-28', '6', '2025-01-29', '2025-02-04', '2025-02-03', 16, 11, 7);


---------------------------------------

CREATE TABLE Supplier
(
	SupplierID int PRIMARY KEY,
	SupplierName varchar(30) NOT NULL,
	Address varchar(100) NULL,
	Phone char(10) NOT NULL,
	Fax char(10) NULL
);

INSERT INTO Supplier (SupplierID, SupplierName, Address, Phone, Fax)
VALUES
(8, 'MedSupply Ltd.', '45 Ratchada Rd, Bangkok', '0822222222', '0222222222'),
(9, 'Chiang Mai Medical', '88 Nimmanhaemin Rd, Chiang Mai', '0833333333', '0533333333'),
(10, 'Isan Healthcare', '12 Khon Kaen City', '0844444444', '0434444444'),
(11, 'Pattaya Wellness', '77 Beach Rd, Pattaya', '0855555555', '0385555555'),
(12, 'Phuket MedEquip', '99 Samkong, Phuket', '0866666666', '0766666666');

---------------------------------------

CREATE TABLE PharmaSupply
(
	DrugID int PRIMARY KEY,
	DrugName varchar(50) NOT NULL,
	DrugDesc varchar(100) NULL,
	Dosage varchar(30) NOT NULL,
	MethodOfAdmin varchar(30) NOT NULL,
	QtyInStock INT NOT NULL,
	ReorderLevel INT NULL,
	CostPerUnit DECIMAl(10,2) NULL,
	SupplierID INT NOT NULL,
	CONSTRAINT PharmaSupplier_FK FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);

INSERT INTO PharmaSupply(DrugID, DrugName, DrugDesc, Dosage, MethodOfAdmin, QtyInStock, ReorderLevel, CostPerUnit, SupplierID)
VALUES
(12, 'Clarithromycin', 'Macrolide antibiotic for respiratory infections', '250 mg', 'Oral', 1200, 300, 3.00, 5),
(13, 'Diclofenac', 'NSAID for pain and inflammation relief', '50 mg', 'Oral', 1500, 400, 2.50, 4),
(14, 'Meropenem', 'Broad-spectrum carbapenem antibiotic', '1 g', 'Injection', 800, 200, 18.00, 1),
(15, 'Pantoprazole', 'Proton pump inhibitor (acid reflux, GERD)', '40 mg', 'Oral', 1000, 250, 5.00, 6),
(16, 'Formoterol', 'Long-acting bronchodilator for asthma/COPD', '12 mcg', 'Inhalation', 600, 150, 9.00, 7);


---------------------------------------

CREATE TABLE MedRecord
(
	MedID int PRIMARY KEY,
	MethodOfAdmin varchar(50) NOT NULL,
	UnitsPerDay INT NOT NULL,
	DiagName varchar(50) NOT NULL,
	DiagDesc varchar(100) NULL,
	StartDate DATE NOT NULL,
	FinishDate DATE NOT NULL,
	DrugID INT NOT NULL,
	PatientID INT NOT NULL,
	Qty INT NOT NULL,
	CONSTRAINT DrugMedRec_FK FOREIGN KEY (DrugID) REFERENCES PharmaSupply(DrugID),
	CONSTRAINT PatientMedRec_FK FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
    CONSTRAINT CK_MedRecord_Qty_Positive CHECK (Qty >= 0)
);


INSERT INTO MedRecord (MedID, MethodOfAdmin, UnitsPerDay, DiagName, DiagDesc, StartDate, FinishDate, DrugID, PatientID)
VALUES
(12, 'Oral', 2, 'Tonsillitis', 'Bacterial throat infection', '2025-02-02', '2025-02-09', 12, 12),
(13, 'Oral', 3, 'Back Pain', 'Inflammatory pain at lower back', '2025-02-03', '2025-02-10', 13, 13),
(14, 'Injection', 1, 'Pneumonia', 'Severe lung infection', '2025-02-03', '2025-02-13', 14, 14),
(15, 'Oral', 1, 'GERD', 'Acid reflux and stomach pain', '2025-02-04', '2025-02-11', 15, 15),
(16, 'Inhalation', 2, 'Asthma', 'Shortness of breath and wheezing', '2025-02-05', '2025-02-12', 16, 16);

----------------------------------

CREATE TABLE SurgicalSupply
(
	SurItemID int PRIMARY KEY,
	SurName varchar(50) NOT NULL,
	SurDesc varchar(100) NULL,
	QtyInStock INT NOT NULL,
	ReorderLevel INT NULL,
	CostPerUnit DECIMAL(10,2) NULL,
	SupplierID INT NOT NULL,
	CONSTRAINT SurgicalSupplier_FK FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);

INSERT INTO SurgicalSupply (SurItemID, SurName, SurDesc, QtyInStock, ReorderLevel, CostPerUnit, SupplierID)
VALUES
(7, 'Surgical Suit', 'Used for cutting tissues', 200, 50, 40.00, 1),
(8, 'Suture Kit', 'Complete set for wound stitching', 150, 40, 120.00, 2),
(9, 'Surgical Syringe 10ml', 'Disposable sterile syringes', 1000, 300, 2.50, 3),
(10, 'IV Set', 'Intravenous infusion set', 800, 250, 5.00, 4),
(11, 'Surgical Gloves', 'Sterile disposable gloves', 5000, 1000, 1.20, 5);

----------------------------------

CREATE TABLE NonSurgicalSupply
(
	NonSurItemID int PRIMARY KEY,
	NonSurName varchar(50) NOT NULL,
	NonSurDesc varchar(100) NULL,
	QtyInStock INT NOT NULL,
	ReorderLevel INT NULL,
	CostPerUnit DECIMAL(10,2) NULL,
	SupplierID INT NOT NULL,
	CONSTRAINT NonSurgicalSupplier_FK FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);

INSERT INTO NonSurgicalSupply (NonSurItemID, NonSurName, NonSurDesc, QtyInStock, ReorderLevel, CostPerUnit, SupplierID)
VALUES
(7, 'Face Mask', 'Disposable 3-ply medical mask', 5000, 1000, 0.50, 8),
(8, 'Hand Sanitizer', 'Alcohol-based disinfectant 500ml', 600, 150, 2.50, 9),
(9, 'Adhesive Bandage', NULL, 150, 30, 5.00, 10),
(10, 'Wheelchair', 'Standard hospital wheelchair', 25, 5, 120.00, 11),
(11, 'Hospital Bed Sheet', 'Cotton bed sheet for hospital beds', 300, 60, 8.00, 12);

----------------------------------

CREATE TABLE Requisition
(
    ReqID INT IDENTITY(1,1) PRIMARY KEY, 
    ReqDesc VARCHAR(100) NULL,
    DrugID INT NULL,
    SurItemID INT NULL,
    NonSurItemID INT NULL,
    Quantity INT NOT NULL,
    RequestDate DATE NOT NULL,
    DeliveryDate DATE NOT NULL,
    Dosage VARCHAR(30) NULL,
    MethodOfAdmin VARCHAR(30) NULL,
    Staff_RequestedBy INT NOT NULL,
    Staff_ReceivedBy INT NULL,
    WardID INT NOT NULL,
    CONSTRAINT CK_Requisition_OneItemOnly CHECK (
      (CASE WHEN DrugID IS NOT NULL THEN 1 ELSE 0 END) +
      (CASE WHEN SurItemID IS NOT NULL THEN 1 ELSE 0 END) +
      (CASE WHEN NonSurItemID IS NOT NULL THEN 1 ELSE 0 END) = 1
    ),
    CONSTRAINT DrugIDReq_FK FOREIGN KEY (DrugID) REFERENCES PharmaSupply(DrugID),
    CONSTRAINT SurItemIDReq_FK FOREIGN KEY (SurItemID) REFERENCES SurgicalSupply(SurItemID),
    CONSTRAINT NonSurItemIDReq_FK FOREIGN KEY (NonSurItemID) REFERENCES NonSurgicalSupply(NonSurItemID),
    CONSTRAINT StaffRequestedReq_FK FOREIGN KEY (Staff_RequestedBy) REFERENCES Staff(StaffID),
    CONSTRAINT StaffReceivedReq_FK FOREIGN KEY (Staff_ReceivedBy) REFERENCES Staff(StaffID),
    CONSTRAINT WardIDReq_FK FOREIGN KEY (WardID) REFERENCES Ward(WardID)
);

INSERT INTO Requisition 
(ReqDesc, DrugID, SurItemID, NonSurItemID, Quantity, RequestDate, DeliveryDate, Dosage, MethodOfAdmin, Staff_RequestedBy, Staff_ReceivedBy, WardID)
VALUES
( 'Disposable Gloves for ward', NULL, NULL, 3, 200, '2025-09-21', '2025-09-22', NULL, NULL, 15, 16, 4 ),
( 'Thermometer Digital replacement', NULL, NULL, 5, 5, '2025-09-22', '2025-09-23', NULL, NULL, 17, 18, 3 ),
( 'Scalpel sterile set', NULL, 6, NULL, 20, '2025-09-22', '2025-09-23', NULL, NULL, 19, 20, 12 ),
( 'Surgical Scissors requisition', NULL, 2, NULL, 10, '2025-09-23', '2025-09-24', NULL, NULL, 21, 22, 8 ),
( 'Suture Needle stock', NULL, 5, NULL, 100, '2025-09-23', '2025-09-24', NULL, NULL, 23, 24, 17 );


----------------------------------

CREATE TABLE Users
(
	UserID INT NOT NULL PRIMARY KEY,
	Username VARCHAR(30) NOT NULL UNIQUE,
	Password VARCHAR(30) NOT NULL,
	Role VARCHAR(30) NOT NULL,
    StaffID INT NOT NULL,
    CONSTRAINT FK_Users_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

INSERT INTO Users (UserID, Username, Password, Role, StaffID)
VALUES 
(9, 'juta.i', '1234', 'Charge Nurse', 4),
(10, 'juta.i', '1234', 'Doctor', 5),
(11, 'phawat.k', '1234', 'Nurse', 6),
(12, 'emily.s', '1234', 'Doctor', 7),
(13, 'gwen.s', '1234', 'Nurse', 8);

----------------------------------

CREATE TABLE Insurance (
    InsuranceID   INT IDENTITY(1,1) PRIMARY KEY,
    InsuranceName NVARCHAR(100) NOT NULL, 
    CovType       NVARCHAR(50)  NULL,      
    CovPercent    DECIMAL(5,2)  NULL,      
    ContactNo     VARCHAR(20)   NULL,
    Address       NVARCHAR(200) NULL,
    Notes         NVARCHAR(255) NULL
);

INSERT INTO Insurance (InsuranceName, CovType, CovPercent, ContactNo, Address, Notes)
VALUES
('Bangkok Insurance', 'Partial', 60.00, '02-600-7000', 'Bangkok, Thailand', 'Corporate and individual health insurance'),
('Muang Thai Life Assurance', 'Partial', 85.00, '02-700-8000', 'Bangkok, Thailand', 'Covers medical expenses with life insurance benefits'),
('Allianz Ayudhya', 'Partial', 80.00, '02-800-9000', 'Bangkok, Thailand', 'International health coverage with co-pay options'),
('AXA Thailand', 'Partial', 65.00, '02-900-1000', 'Bangkok, Thailand', 'Outpatient and inpatient medical coverage'),
('Thai Health Insurance', 'Partial', 50.00, '02-111-2222', 'Bangkok, Thailand', 'Basic health coverage for individuals');

------------------------------------

CREATE TABLE PatientInsurance(
  PatientInsuranceID INT IDENTITY PRIMARY KEY,
  PatientID INT NOT NULL REFERENCES Patient(PatientID),
  InsuranceID INT NOT NULL REFERENCES Insurance(InsuranceID),
  IsPrimary BIT NOT NULL DEFAULT(0),   -- ตัวหลัก/รอง
  Notes NVARCHAR(200) NULL
);

CREATE UNIQUE INDEX UX_PatientInsurance_Primary
ON PatientInsurance(PatientID)
WHERE IsPrimary = 1;

INSERT INTO dbo.PatientInsurance (PatientID, InsuranceID, Notes)
VALUES
(6, 2, N'Limited to in-patient only'),
(7, 5, N'Premium coverage'),
(8, 3, N'Chronic illness supported'),
(9, 4, N'Family package plan'),
(10, 2, N'Expires next year');




------------------------------------
------------------------------------
------------------------------------
------------------------------------




-- TRIGGER ON REQUISITION

CREATE OR ALTER TRIGGER dbo.trg_Requisition_AU_MarkReceived
ON dbo.Requisition
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- เก็บแถวที่เพิ่งถูก mark received (จาก NULL -> NOT NULL)
    DECLARE @ToReceive TABLE
    (
        ReqID INT,
        Quantity INT,
        DrugID INT NULL,
        SurItemID INT NULL,
        NonSurItemID INT NULL
    );

    INSERT INTO @ToReceive (ReqID, Quantity, DrugID, SurItemID, NonSurItemID)
    SELECT i.ReqID, i.Quantity, i.DrugID, i.SurItemID, i.NonSurItemID
    FROM inserted i
    JOIN deleted d ON d.ReqID = i.ReqID
    WHERE (d.Staff_ReceivedBy IS NULL AND i.Staff_ReceivedBy IS NOT NULL)
       OR (d.DeliveryDate     IS NULL AND i.DeliveryDate     IS NOT NULL);

    -- ถ้าไม่มีแถวที่ต้องหักสต็อก ก็จบ
    IF NOT EXISTS (SELECT 1 FROM @ToReceive) RETURN;

    -- ===== เช็คสต็อกพอไหม =====
    -- Drug
    IF EXISTS (
        SELECT 1
        FROM @ToReceive r
        JOIN dbo.PharmaSupply ps ON ps.DrugID = r.DrugID
        WHERE r.DrugID IS NOT NULL AND ps.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 51001, 'Not enough DRUG stock.', 1;
    END

    -- Surgical
    IF EXISTS (
        SELECT 1
        FROM @ToReceive r
        JOIN dbo.SurgicalSupply ss ON ss.SurItemID = r.SurItemID
        WHERE r.SurItemID IS NOT NULL AND ss.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 51002, 'Not enough SURGICAL stock.', 1;
    END

    -- NonSurgical
    IF EXISTS (
        SELECT 1
        FROM @ToReceive r
        JOIN dbo.NonSurgicalSupply ns ON ns.NonSurItemID = r.NonSurItemID
        WHERE r.NonSurItemID IS NOT NULL AND ns.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 51003, 'Not enough NON-SURGICAL stock.', 1;
    END

    -- ===== หักสต็อกจริง =====
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock - r.Quantity
    FROM dbo.PharmaSupply ps
    JOIN @ToReceive r ON r.DrugID = ps.DrugID
    WHERE r.DrugID IS NOT NULL;

    UPDATE ss
    SET ss.QtyInStock = ss.QtyInStock - r.Quantity
    FROM dbo.SurgicalSupply ss
    JOIN @ToReceive r ON r.SurItemID = ss.SurItemID
    WHERE r.SurItemID IS NOT NULL;

    UPDATE ns
    SET ns.QtyInStock = ns.QtyInStock - r.Quantity
    FROM dbo.NonSurgicalSupply ns
    JOIN @ToReceive r ON r.NonSurItemID = ns.NonSurItemID
    WHERE r.NonSurItemID IS NOT NULL;
END;
GO


CREATE OR ALTER TRIGGER dbo.trg_Requisition_AI
ON dbo.Requisition
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ToInsert TABLE
    (
        ReqID         INT,
        Quantity      INT NOT NULL,
        DrugID        INT NULL,
        SurItemID     INT NULL,
        NonSurItemID  INT NULL
    );

    INSERT INTO @ToInsert (ReqID, Quantity, DrugID, SurItemID, NonSurItemID)
    SELECT i.ReqID, i.Quantity, i.DrugID, i.SurItemID, i.NonSurItemID
    FROM inserted i;

    IF NOT EXISTS (SELECT 1 FROM @ToInsert) RETURN;

    -- ===== เช็คสต็อกพอไหม =====
    IF EXISTS (
        SELECT 1
        FROM @ToInsert r
        JOIN dbo.PharmaSupply ps ON ps.DrugID = r.DrugID
        WHERE r.DrugID IS NOT NULL AND ps.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 52011, 'Not enough DRUG stock (on insert).', 1;
    END

    IF EXISTS (
        SELECT 1
        FROM @ToInsert r
        JOIN dbo.SurgicalSupply ss ON ss.SurItemID = r.SurItemID
        WHERE r.SurItemID IS NOT NULL AND ss.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 52012, 'Not enough SURGICAL stock (on insert).', 1;
    END

    IF EXISTS (
        SELECT 1
        FROM @ToInsert r
        JOIN dbo.NonSurgicalSupply ns ON ns.NonSurItemID = r.NonSurItemID
        WHERE r.NonSurItemID IS NOT NULL AND ns.QtyInStock < r.Quantity
    )
    BEGIN
        THROW 52013, 'Not enough NON-SURGICAL stock (on insert).', 1;
    END

    -- ===== หักสต็อกจริง =====
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock - r.Quantity
    FROM dbo.PharmaSupply ps
    JOIN @ToInsert r ON r.DrugID = ps.DrugID
    WHERE r.DrugID IS NOT NULL;

    UPDATE ss
    SET ss.QtyInStock = ss.QtyInStock - r.Quantity
    FROM dbo.SurgicalSupply ss
    JOIN @ToInsert r ON r.SurItemID = ss.SurItemID
    WHERE r.SurItemID IS NOT NULL;

    UPDATE ns
    SET ns.QtyInStock = ns.QtyInStock - r.Quantity
    FROM dbo.NonSurgicalSupply ns
    JOIN @ToInsert r ON r.NonSurItemID = ns.NonSurItemID
    WHERE r.NonSurItemID IS NOT NULL;
END;
GO


CREATE OR ALTER TRIGGER dbo.trg_Requisition_AU_Unreceive
ON dbo.Requisition
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ToUnreceive TABLE
    (
        ReqID         INT,
        Quantity      INT NOT NULL,
        DrugID        INT NULL,
        SurItemID     INT NULL,
        NonSurItemID  INT NULL
    );

    -- จากเดิมมีผู้รับ/มีวันที่ → กลับเป็น NULL = ยกเลิกการรับของ
    INSERT INTO @ToUnreceive (ReqID, Quantity, DrugID, SurItemID, NonSurItemID)
    SELECT d.ReqID, d.Quantity, d.DrugID, d.SurItemID, d.NonSurItemID
    FROM inserted i
    JOIN deleted  d ON d.ReqID = i.ReqID
    WHERE (d.Staff_ReceivedBy IS NOT NULL AND i.Staff_ReceivedBy IS NULL)
       OR (d.DeliveryDate     IS NOT NULL AND i.DeliveryDate     IS NULL);

    IF NOT EXISTS (SELECT 1 FROM @ToUnreceive) RETURN;

    -- คืนสต็อก
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock + r.Quantity
    FROM dbo.PharmaSupply ps
    JOIN @ToUnreceive r ON r.DrugID = ps.DrugID
    WHERE r.DrugID IS NOT NULL;

    UPDATE ss
    SET ss.QtyInStock = ss.QtyInStock + r.Quantity
    FROM dbo.SurgicalSupply ss
    JOIN @ToUnreceive r ON r.SurItemID = ss.SurItemID
    WHERE r.SurItemID IS NOT NULL;

    UPDATE ns
    SET ns.QtyInStock = ns.QtyInStock + r.Quantity
    FROM dbo.NonSurgicalSupply ns
    JOIN @ToUnreceive r ON r.NonSurItemID = ns.NonSurItemID
    WHERE r.NonSurItemID IS NOT NULL;
END;
GO


CREATE OR ALTER TRIGGER dbo.trg_Requisition_AD
ON dbo.Requisition
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @WasReceived TABLE
    (
        ReqID         INT,
        Quantity      INT NOT NULL,
        DrugID        INT NULL,
        SurItemID     INT NULL,
        NonSurItemID  INT NULL
    );

    INSERT INTO @WasReceived (ReqID, Quantity, DrugID, SurItemID, NonSurItemID)
    SELECT d.ReqID, d.Quantity, d.DrugID, d.SurItemID, d.NonSurItemID
    FROM deleted d
    WHERE d.Staff_ReceivedBy IS NOT NULL OR d.DeliveryDate IS NOT NULL;

    IF NOT EXISTS (SELECT 1 FROM @WasReceived) RETURN;

    -- คืนสต็อก
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock + r.Quantity
    FROM dbo.PharmaSupply ps
    JOIN @WasReceived r ON r.DrugID = ps.DrugID
    WHERE r.DrugID IS NOT NULL;

    UPDATE ss
    SET ss.QtyInStock = ss.QtyInStock + r.Quantity
    FROM dbo.SurgicalSupply ss
    JOIN @WasReceived r ON r.SurItemID = ss.SurItemID
    WHERE r.SurItemID IS NOT NULL;

    UPDATE ns
    SET ns.QtyInStock = ns.QtyInStock + r.Quantity
    FROM dbo.NonSurgicalSupply ns
    JOIN @WasReceived r ON r.NonSurItemID = ns.NonSurItemID
    WHERE r.NonSurItemID IS NOT NULL;
END;
GO

----------------------------------

-- TRIGGER ON MEDRECORD --
CREATE OR ALTER TRIGGER trg_MedRecord_AI
ON dbo.MedRecord
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- กันสต็อกติดลบ
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN dbo.PharmaSupply ps ON ps.DrugID = i.DrugID
        WHERE ps.QtyInStock < i.Qty
    )
    BEGIN
        RAISERROR('Not enough stock for this drug.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- หักสต็อก
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock - i.Qty
    FROM dbo.PharmaSupply ps
    JOIN inserted i ON ps.DrugID = i.DrugID;
END;
GO

CREATE OR ALTER TRIGGER trg_MedRecord_AD
ON dbo.MedRecord
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock + d.Qty
    FROM dbo.PharmaSupply ps
    JOIN deleted d ON ps.DrugID = d.DrugID;
END;
GO

CREATE OR ALTER TRIGGER dbo.trg_MedRecord_AU
ON dbo.MedRecord
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- ถ้าไม่ได้แก้ Qty หรือ DrugID ก็ออกเลย
    IF NOT (UPDATE(Qty) OR UPDATE(DrugID)) RETURN;

    -- คำนวณส่วนต่างด้วยตารางตัวแปร (รองรับหลายแถว)
    DECLARE @Diff TABLE (DrugID INT, Delta INT);

    INSERT INTO @Diff (DrugID, Delta)
    SELECT
        COALESCE(i.DrugID, d.DrugID) AS DrugID,
        ISNULL(i.Qty, 0) - ISNULL(d.Qty, 0) AS Delta
    FROM inserted i
    FULL JOIN deleted d
        ON i.MedID = d.MedID;  -- ใช้คีย์ของตารางคุณ

    -- เช็คสต็อกพอก่อน (เช็คเฉพาะ Delta > 0 = ต้องหักเพิ่ม)
    IF EXISTS (
        SELECT 1
        FROM @Diff x
        JOIN dbo.PharmaSupply ps ON ps.DrugID = x.DrugID
        WHERE x.Delta > 0 AND ps.QtyInStock < x.Delta
    )
    BEGIN
        THROW 50010, 'Not enough stock for update.', 1;
    END

    -- ปรับยอดตามส่วนต่าง (Delta บวก = หักเพิ่ม, ลบ = คืนสต็อก)
    UPDATE ps
    SET ps.QtyInStock = ps.QtyInStock - x.Delta
    FROM dbo.PharmaSupply ps
    JOIN @Diff x ON x.DrugID = ps.DrugID
    WHERE x.Delta <> 0;
END;
GO