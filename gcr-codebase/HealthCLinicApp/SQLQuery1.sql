-- Create the main database
CREATE DATABASE DotNet_DBMS;
GO

-- Use the created database
USE DotNet_DBMS;
GO


-- =========================
-- Table: Specialties
-- Stores medical specialties (e.g., Cardiology, Neurology)
-- =========================
CREATE TABLE specialties (
    specialty_id INT IDENTITY PRIMARY KEY,   -- Auto-increment primary key
    specialty_name VARCHAR(50) UNIQUE NOT NULL -- Specialty name must be unique
);


-- =========================
-- Table: Patients
-- Stores patient personal details
-- =========================
CREATE TABLE patients (
    patient_id INT IDENTITY PRIMARY KEY, -- Unique patient ID
    name VARCHAR(100),                    -- Patient name
    phone VARCHAR(15) UNIQUE,             -- Phone number (unique)
    email VARCHAR(100) UNIQUE,            -- Email address (unique)
    dob DATE                              -- Date of birth
);


-- =========================
-- Table: Doctors
-- Stores doctor details and their specialties
-- =========================
CREATE TABLE doctors (
    doctor_id INT IDENTITY PRIMARY KEY, -- Unique doctor ID
    name VARCHAR(100),                  -- Doctor name
    specialty_id INT,                   -- Reference to specialty
    is_active BIT DEFAULT 1,             -- Doctor active status
    FOREIGN KEY (specialty_id) REFERENCES specialties(specialty_id)
);


-- =========================
-- Table: Appointments
-- Stores appointment details between patients and doctors
-- =========================
CREATE TABLE appointments (
    appointment_id INT IDENTITY PRIMARY KEY, -- Unique appointment ID
    patient_id INT,                          -- Reference to patient
    doctor_id INT,                           -- Reference to doctor
    appointment_date DATE,                   -- Appointment date
    status VARCHAR(20),                      -- Appointment status
    FOREIGN KEY (patient_id) REFERENCES patients(patient_id),
    FOREIGN KEY (doctor_id) REFERENCES doctors(doctor_id)
);


-- =========================
-- Table: Appointment Audit
-- Logs insert and update actions on appointments
-- =========================
CREATE TABLE appointment_audit (
    audit_id INT IDENTITY PRIMARY KEY, -- Audit record ID
    appointment_id INT,                -- Related appointment ID
    action VARCHAR(20),                -- Action performed
    action_date DATETIME DEFAULT GETDATE() -- Timestamp
);


-- Trigger to track appointment insert/update
CREATE TRIGGER trg_appointment_audit
ON appointments
AFTER INSERT, UPDATE
AS
BEGIN
    INSERT INTO appointment_audit (appointment_id, action)
    SELECT appointment_id, 'INSERT/UPDATE'
    FROM inserted;
END;


-- =========================
-- Stored Procedure: Register Patient
-- Inserts a new patient record
-- =========================
CREATE PROCEDURE sp_register_patient
    @name VARCHAR(100),
    @phone VARCHAR(15),
    @email VARCHAR(100),
    @dob DATE
AS
BEGIN
    INSERT INTO patients
    VALUES (@name, @phone, @email, @dob);
END;


-- =========================
-- Stored Procedure: Add Doctor
-- Inserts a new doctor record
-- =========================
CREATE PROCEDURE sp_add_doctor
    @name VARCHAR(100),
    @specialty_id INT
AS
BEGIN
    INSERT INTO doctors (name, specialty_id)
    VALUES (@name, @specialty_id);
END;


-- =========================
-- Stored Procedure: Book Appointment
-- Schedules a new appointment
-- =========================
CREATE PROCEDURE sp_book_appointment
    @patient_id INT,
    @doctor_id INT,
    @date DATE
AS
BEGIN
    INSERT INTO appointments
    VALUES (@patient_id, @doctor_id, @date, 'SCHEDULED');
END;


-- =========================
-- Table: Visits
-- Stores visit details after appointment completion
-- =========================
CREATE TABLE visits (
    visit_id INT IDENTITY PRIMARY KEY,  -- Unique visit ID
    appointment_id INT UNIQUE,          -- One visit per appointment
    diagnosis VARCHAR(200),             -- Diagnosis details
    visit_date DATE DEFAULT GETDATE(),  -- Visit date
    FOREIGN KEY (appointment_id) REFERENCES appointments(appointment_id)
);


-- =========================
-- Table: Prescriptions
-- Stores medicines prescribed during visits
-- =========================
CREATE TABLE prescriptions (
    prescription_id INT IDENTITY PRIMARY KEY,
    visit_id INT,                       -- Reference to visit
    medicine_name VARCHAR(100),
    dosage VARCHAR(50),
    duration VARCHAR(50),
    FOREIGN KEY (visit_id) REFERENCES visits(visit_id)
);


-- =========================
-- Table: Bills
-- Stores billing information for visits
-- =========================
CREATE TABLE bills (
    bill_id INT IDENTITY PRIMARY KEY,
    visit_id INT UNIQUE,               -- One bill per visit
    amount DECIMAL(10,2),              -- Bill amount
    status VARCHAR(20) DEFAULT 'UNPAID',
    FOREIGN KEY (visit_id) REFERENCES visits(visit_id)
);


-- =========================
-- Table: Bill Audit
-- Logs bill insert and update actions
-- =========================
CREATE TABLE bill_audit (
    audit_id INT IDENTITY PRIMARY KEY,
    bill_id INT,
    action VARCHAR(30),
    action_date DATETIME DEFAULT GETDATE()
);


-- Trigger to track bill insert/update
CREATE TRIGGER trg_bill_audit
ON bills
AFTER INSERT, UPDATE
AS
BEGIN
    INSERT INTO bill_audit (bill_id, action)
    SELECT bill_id, 'INSERT_OR_UPDATE'
    FROM inserted;
END;


-- =========================
-- Stored Procedure: Record Visit
-- Marks appointment as completed and records visit
-- =========================
CREATE PROCEDURE sp_record_visit
    @appointment_id INT,
    @diagnosis VARCHAR(200)
AS
BEGIN
    INSERT INTO visits (appointment_id, diagnosis)
    VALUES (@appointment_id, @diagnosis);

    UPDATE appointments
    SET status = 'COMPLETED'
    WHERE appointment_id = @appointment_id;
END;


-- =========================
-- Stored Procedure: Generate Bill
-- Creates a bill for a visit
-- =========================
CREATE PROCEDURE sp_generate_bill
    @visit_id INT,
    @amount DECIMAL(10,2)
AS
BEGIN
    INSERT INTO bills (visit_id, amount)
    VALUES (@visit_id, @amount);
END;


-- =========================
-- Table: Payments
-- Stores payment details for bills
-- =========================
CREATE TABLE payments (
    payment_id INT IDENTITY PRIMARY KEY,
    bill_id INT UNIQUE,
    payment_date DATETIME DEFAULT GETDATE(),
    payment_mode VARCHAR(30),
    FOREIGN KEY (bill_id) REFERENCES bills(bill_id)
);


-- =========================
-- Table: Payment Audit
-- Logs payment actions
-- =========================
CREATE TABLE payment_audit (
    audit_id INT IDENTITY PRIMARY KEY,
    bill_id INT,
    action VARCHAR(30),
    action_date DATETIME DEFAULT GETDATE()
);


-- Trigger to track payments
CREATE TRIGGER trg_payment_audit
ON payments
AFTER INSERT
AS
BEGIN
    INSERT INTO payment_audit (bill_id, action)
    SELECT bill_id, 'PAYMENT_DONE'
    FROM inserted;
END;


-- =========================
-- Stored Procedure: Record Payment
-- Marks bill as paid and records payment
-- =========================
CREATE PROCEDURE sp_record_payment
    @bill_id INT,
    @payment_mode VARCHAR(30)
AS
BEGIN
    INSERT INTO payments (bill_id, payment_mode)
    VALUES (@bill_id, @payment_mode);

    UPDATE bills
    SET status = 'PAID'
    WHERE bill_id = @bill_id;
END;


-- =========================
-- Stored Procedure: Add Prescription
-- Adds prescribed medicine for a visit
-- =========================
CREATE PROCEDURE sp_add_prescription
    @visit_id INT,
    @medicine_name VARCHAR(100),
    @dosage VARCHAR(50),
    @duration VARCHAR(50)
AS
BEGIN
    INSERT INTO prescriptions
    VALUES (@visit_id, @medicine_name, @dosage, @duration);
END;
