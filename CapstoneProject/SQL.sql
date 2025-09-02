use master;

create database SmartHomeDb;

use SmartHomeDb;

CREATE TABLE Users ( 
	  Id INT PRIMARY KEY IDENTITY,
	  Username NVARCHAR(50) NOT NULL,
	  Password NVARCHAR(255) NOT NULL 
	  );
 
CREATE TABLE Devices ( 
	  DeviceId INT PRIMARY KEY Identity,
	  DeviceName VARCHAR(100) NOT NULL,
	  DeviceType VARCHAR(50), -- e.g., Light, Thermostat, 
	  Camera Location VARCHAR(50), -- e.g., Living Room, Kitchen 
	  UserId INT FOREIGN KEY REFERENCES Users(UserId) -- which user owns it 
	  );

CREATE TABLE SensorsData (
	  SensorId INT PRIMARY KEY Identity,
	  DeviceId INT FOREIGN KEY REFERENCES Devices(DeviceId),
	  SensorType VARCHAR(50), -- e.g., Temperature, Motion
	  SensorStatus VARCHAR(20), -- e.g., C, %, On/Off
	  ReadingTime DATETIME DEFAULT GETDATE() 
	  );

CREATE TABLE ControlLog ( 
	  LogId INT PRIMARY KEY IDENTITY, -- unique log entry ID
	  SensorId int foreign key references SensorsData (SensorId),
	  Action VARCHAR(50), -- e.g., "ON", "OFF", "LOCKED" 
	  ActionTime DATETIME DEFAULT GETDATE() 
	  );

CREATE TABLE Notifications ( 
	  NotificationId INT PRIMARY KEY IDENTITY,
	  UserId INT NOT NULL,
	  DeviceId INT NOT NULL,
	  SensorId INT NULL, -- optional for sensor-based alerts
	  Message VARCHAR(500) NOT NULL,
	  CreatedAt DATETIME DEFAULT GETDATE(),
	  IsRead BIT DEFAULT 0,
	  FOREIGN KEY (UserId) REFERENCES Users(UserId),
	  FOREIGN KEY (DeviceId) REFERENCES Devices(DeviceId),
	  FOREIGN KEY (SensorId) REFERENCES SensorsData(SensorId) 
	  );


--Trigger

CREATE TRIGGER dbo.trg_UpdateSensorsDataOnControl
ON dbo.ControlLog
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE sd
    SET 
        sd.SensorStatus = i.Action,       -- update ON/OFF/LOCKED
        sd.ReadingTime = GETDATE()        -- refresh timestamp
    FROM dbo.SensorsData sd
    INNER JOIN INSERTED i ON sd.SensorId = i.SensorId;
END;

--Stored Procedure

CREATE OR ALTER PROCEDURE CheckNotifications
AS
BEGIN
    -- AC ON > 5 hours
    INSERT INTO Notifications (UserId, DeviceId, SensorId, Message)
    SELECT d.UserId, s.DeviceId, s.SensorId,
           'AC has been ON for more than 5 hours!'
    FROM SensorsData s
    INNER JOIN Devices d ON s.DeviceId = d.DeviceId
    WHERE UPPER(s.SensorType) = 'AC'
      AND UPPER(s.SensorStatus) = 'ON'
      AND s.ReadingTime <= DATEADD(HOUR, -5, GETDATE())
      AND NOT EXISTS (
          SELECT 1 FROM Notifications n
          WHERE n.SensorId = s.SensorId
            AND n.Message LIKE 'AC has been ON%'
      );

    -- Main Door OPEN > 15 minutes
    INSERT INTO Notifications (UserId, DeviceId, SensorId, Message)
    SELECT d.UserId, s.DeviceId, s.SensorId,
           'Main Door has been OPEN for more than 15 minutes!'
    FROM SensorsData s
    INNER JOIN Devices d ON s.DeviceId = d.DeviceId
    WHERE UPPER(s.SensorType) = 'MAIN DOOR'
      AND UPPER(s.SensorStatus) = 'OPEN'
      AND s.ReadingTime <= DATEADD(MINUTE, -15, GETDATE())
      AND NOT EXISTS (
          SELECT 1 FROM Notifications n
          WHERE n.SensorId = s.SensorId
            AND n.Message LIKE 'Main Door has been OPEN%'
      );

    -- Tap ON > 20 minutes
    INSERT INTO Notifications (UserId, DeviceId, SensorId, Message)
    SELECT d.UserId, s.DeviceId, s.SensorId,
           'Tap has been ON for more than 20 minutes!'
    FROM SensorsData s
    INNER JOIN Devices d ON s.DeviceId = d.DeviceId
    WHERE UPPER(s.SensorType) = 'TAP'
      AND UPPER(s.SensorStatus) = 'ON'
      AND s.ReadingTime <= DATEADD(MINUTE, -20, GETDATE())
      AND NOT EXISTS (
          SELECT 1 FROM Notifications n
          WHERE n.SensorId = s.SensorId
            AND n.Message LIKE 'Tap has been ON%'
      );

    -- Geyser ON > 20 minutes
    INSERT INTO Notifications (UserId, DeviceId, SensorId, Message)
    SELECT d.UserId, s.DeviceId, s.SensorId,
           'Geyser has been ON for more than 20 minutes!'
    FROM SensorsData s
    INNER JOIN Devices d ON s.DeviceId = d.DeviceId
    WHERE UPPER(s.SensorType) = 'GEYSER'
      AND UPPER(s.SensorStatus) = 'ON'
      AND s.ReadingTime <= DATEADD(MINUTE, -20, GETDATE())
      AND NOT EXISTS (
          SELECT 1 FROM Notifications n
          WHERE n.SensorId = s.SensorId
            AND n.Message LIKE 'Geyser has been ON%'
      );
END;

