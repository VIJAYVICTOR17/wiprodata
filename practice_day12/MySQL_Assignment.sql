

CREATE TABLE DOCTOR_MASTER (
    doctor_id VARCHAR(15) PRIMARY KEY,
    doctor_name VARCHAR(15) NOT NULL,
    dept VARCHAR(15) NOT NULL
);

-- Insert sample data
INSERT INTO DOCTOR_MASTER (doctor_id,doctor_name,dept)
VALUES ('D0001', 'Ram', 'ENT'),('D0002', 'Rajan', 'ENT'),('D0003', 'Smita', 'Eye'),('D0004', 'Bhavan', 'Surgery'),
('D0005', 'Sheela', 'Surgery'),('D0006', 'Nethra', 'Surgery');



CREATE TABLE ROOM_MASTER (
    room_no VARCHAR(15) PRIMARY KEY,
    room_type VARCHAR(15) NOT NULL,
    status VARCHAR(15) NOT NULL
);

-- Insert sample data
INSERT INTO ROOM_MASTER VALUES ('R0001', 'AC', 'occupied'),('R0002', 'Suite', 'vacant'),('R0003', 'NonAC', 'vacant'),
('R0004', 'NonAC', 'occupied'),('R0005', 'AC', 'vacant'),('R0006', 'AC', 'occupied');


CREATE TABLE PATIENT_MASTER (
    pid VARCHAR(15) PRIMARY KEY,
    name VARCHAR(15) NOT NULL,
    age int NOT NULL,
    weight int NOT NULL,
    gender VARCHAR(10) NOT NULL,
    address VARCHAR(50) NOT NULL,
    phoneno VARCHAR(10) NOT NULL,
    disease VARCHAR(50) NOT NULL,
    doctor_id VARCHAR(15) NOT NULL,
    CONSTRAINT fk_patient_doctor FOREIGN KEY (doctor_id) REFERENCES DOCTOR_MASTER(doctor_id)
);

-- Insert sample data
INSERT INTO PATIENT_MASTER VALUES ('P0001', 'Gita', 35, 65, 'F', 'Chennai', '9867145678', 'Eye Infection', 'D0003'),
('P0002', 'Ashish', 40, 70, 'M', 'Delhi', '9845675678', 'Asthma', 'D0003'),
('P0003', 'Radha', 25, 60, 'F', 'Chennai', '9867166678', 'Pain in heart', 'D0005'),
('P0004', 'Chandra', 28, 55, 'F', 'Bangalore', '9978675567', 'Asthma', 'D0001'),
('P0005', 'Goyal', 42, 65, 'M', 'Delhi', '8967533223', 'Pain in Stomach', 'D0004');


CREATE TABLE ROOM_ALLOCATION (
    room_no VARCHAR(15),
    pid VARCHAR(15),
    admission_date DATE NOT NULL,
    release_date DATE,
    FOREIGN KEY (room_no) REFERENCES ROOM_MASTER(room_no),
    FOREIGN KEY (pid) REFERENCES PATIENT_MASTER(pid)
);

-- Insert sample data using ISO date format (SQL Server-friendly)
INSERT INTO ROOM_ALLOCATION (room_no, pid, admission_date, release_date) VALUES
('R0001', 'P0001', '2016-10-15', '2016-10-26'),
('R0002', 'P0002', '2016-11-15', '2016-11-26'),
('R0002', 'P0003', '2016-12-01', '2016-12-30'),
('R0004', 'P0001', '2017-01-01', '2017-01-30');



--Query #1: Display the patients who were admitted in the month of january.
--Query #2: Display the female patient who is not suffering from ashma
--Query #3: Count the number of male and female patients.
--Query #4: Display the patient_id,patient_name, doctor_id, doctor_name, room_no, room_type and admission_date.
--Query #5: Display the room_no which was never allocated to any patient.
--Query #6: Display the room_no, room_type which are allocated more than once.


--Query #1: Display the patients who were admitted in the month of january.

SELECT * FROM PATIENT_MASTER
WHERE pid IN (
    SELECT pid
    FROM ROOM_ALLOCATION
    WHERE MONTH(admission_date) = 1
);

--Query #2: Display the female patient who is not suffering from asthma

SELECT * FROM PATIENT_MASTER
WHERE gender = 'F'
  AND disease NOT LIKE '%asthma%';

--Query #3: Count the number of male and female patients.

SELECT gender, COUNT(*) AS total_count
FROM PATIENT_MASTER
GROUP BY gender;

--Query #5: Display the room_no which was never allocated to any patient.

SELECT room_no FROM ROOM_MASTER
WHERE room_no NOT IN (
    SELECT room_no
    FROM ROOM_ALLOCATION
);

--Query #6: Display the room_no, room_type which are allocated more than once.

SELECT room_no FROM ROOM_ALLOCATION
GROUP BY room_no
HAVING COUNT(*) > 1;

