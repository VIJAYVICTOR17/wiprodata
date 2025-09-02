import { useState } from "react"; 
import Login from "./Login";
import Register from "./Register";
import Devices from "./Devices";
import AddDevice from "./AddDevice";
import GetDeviceById from "./GetDeviceById";
import UpdateDeviceById from "./UpdateDevice";
import DeleteDeviceById from "./DeleteDevice";
import ControlLogs from "./ControlLog"; 
import AddControl from "./AddControl"; 
import SensorsData from "./SensorsData"; 
import AddSensorData from "./AddSensorData"; 
import Notification from "./Notification"; 
import shd from "../assets/shd.jpg"; 
import loginBg from "../assets/login.jpg";   // login background
import deviceBg from "../assets/device.jpg"; // device background
import controlBg from "../assets/control.jpg"; // control background
import sensorBg from "../assets/sensor.jpg";  // sensor background
import notificationBg from "../assets/notification.jpg"; // ✅ notification background

const AuthContainer = () => {
  const [showRegister, setShowRegister] = useState(false);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [showDevices, setShowDevices] = useState(false);
  const [showAddDevice, setShowAddDevice] = useState(false);
  const [showGetById, setShowGetById] = useState(false);
  const [showUpdateById, setShowUpdateById] = useState(false);
  const [showDeleteById, setShowDeleteById] = useState(false);
  const [showControls, setShowControls] = useState(false); 
  const [showAddControl, setShowAddControl] = useState(false); 
  const [showSensors, setShowSensors] = useState(false); 
  const [showAddSensor, setShowAddSensor] = useState(false); 
  const [showNotifications, setShowNotifications] = useState(false); 

  const handleLogout = () => {
    localStorage.removeItem("token");
    setIsLoggedIn(false);
    setShowDevices(false);
    setShowRegister(false);
    setShowAddDevice(false);
    setShowGetById(false);
    setShowUpdateById(false);
    setShowDeleteById(false);
    setShowControls(false);
    setShowAddControl(false);
    setShowSensors(false);
    setShowAddSensor(false);
    setShowNotifications(false);
  };

  const handleBackToDashboard = () => {
    setShowDevices(false);
    setShowAddDevice(false);
    setShowGetById(false);
    setShowUpdateById(false);
    setShowDeleteById(false);
    setShowControls(false);
    setShowAddControl(false);
    setShowSensors(false);
    setShowAddSensor(false);
    setShowNotifications(false);
  };

  // reusable wrapper for page content with optional background
  const PageWrapper = ({ children, background }) => (
    <div
      style={{
        width: "100%",
        minHeight: "100vh",
        backgroundImage: background ? `url(${background})` : "none",
        backgroundSize: "cover",
        backgroundPosition: "center",
        backgroundRepeat: "no-repeat",
        display: "flex",
        justifyContent: "center",
        alignItems: "flex-start",
        paddingTop: "30px",
      }}
    >
      <div
        style={{
          width: "90%",
          backgroundColor: "rgba(255, 255, 255, 0.8)",
          borderRadius: "10px",
          padding: "20px",
          boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
          textAlign: "center",
        }}
      >
        {children}
      </div>
    </div>
  );

  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        minHeight: "100vh",
        paddingTop: !isLoggedIn ? "40px" : "0px",               
        backgroundImage: !isLoggedIn ? `url(${loginBg})` : "none",   
        backgroundSize: "cover",
        backgroundPosition: "center",
        backgroundRepeat: "no-repeat",
        backgroundColor: !isLoggedIn ? "transparent" : "transparent",
      }}
    >
      {!isLoggedIn ? (
        <div
          style={{
            backgroundColor: "rgba(255,255,255,0.7)",
            padding: "40px",
            borderRadius: "8px",
            boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
            minWidth: "350px",
          }}
        >
          {showRegister ? (
            <Register onShowLogin={() => setShowRegister(false)} />
          ) : (
            <Login
              onShowRegister={() => setShowRegister(true)}
              onLoginSuccess={() => setIsLoggedIn(true)}
            />
          )}
        </div>
      ) : showAddDevice ? (
        <PageWrapper background={deviceBg}>
          <AddDevice onBack={() => setShowAddDevice(false)} />
        </PageWrapper>
      ) : showGetById ? (
        <PageWrapper background={deviceBg}>
          <GetDeviceById onBack={() => setShowGetById(false)} />
        </PageWrapper>
      ) : showUpdateById ? (
        <PageWrapper background={deviceBg}>
          <UpdateDeviceById onBack={() => setShowUpdateById(false)} />
        </PageWrapper>
      ) : showDeleteById ? (
        <PageWrapper background={deviceBg}>
          <DeleteDeviceById onBack={() => setShowDeleteById(false)} />
        </PageWrapper>
      ) : showControls ? (
        <PageWrapper background={controlBg}>
          {showAddControl ? (
            <AddControl onBack={() => setShowAddControl(false)} />
          ) : (
            <>
              <ControlLogs />
              <div
                style={{
                  marginTop: "15px",
                  display: "flex",
                  justifyContent: "center",
                  gap: "10px",
                }}
              >
                <button
                  onClick={() => setShowAddControl(true)}
                  style={{
                    padding: "8px 16px",
                    borderRadius: "6px",
                    border: "none",
                    backgroundColor: "#4CAF50",
                    color: "#fff",
                    cursor: "pointer",
                  }}
                >
                  Add Control
                </button>
                <button
                  onClick={handleBackToDashboard}
                  style={{
                    padding: "8px 16px",
                    borderRadius: "6px",
                    border: "none",
                    backgroundColor: "#9e9e9e",
                    color: "#fff",
                    cursor: "pointer",
                  }}
                >
                  Back to Dashboard
                </button>
              </div>
            </>
          )}
        </PageWrapper>
      ) : showDevices ? (
        <PageWrapper background={deviceBg}>
          <div
            style={{
              marginBottom: "15px",
              display: "flex",
              gap: "10px",
              justifyContent: "center",
              flexWrap: "wrap",
            }}
          >
            <button onClick={() => setShowAddDevice(true)} style={{ padding: "8px 16px", fontWeight: "bold", borderRadius: "6px", border: "none", backgroundColor: "#4CAF50", color: "#fff" }}>Add Device</button>
            <button onClick={() => setShowGetById(true)} style={{ padding: "8px 16px", fontWeight: "bold", borderRadius: "6px", border: "none", backgroundColor: "#2196F3", color: "#fff" }}>Get Device</button>
            <button onClick={() => setShowUpdateById(true)} style={{ padding: "8px 16px", fontWeight: "bold", borderRadius: "6px", border: "none", backgroundColor: "#FF9800", color: "#fff" }}>Update Device</button>
            <button onClick={() => setShowDeleteById(true)} style={{ padding: "8px 16px", fontWeight: "bold", borderRadius: "6px", border: "none", backgroundColor: "#f44336", color: "#fff" }}>Delete Device</button>
          </div>
          <Devices />
          <button
            onClick={handleBackToDashboard}
            style={{
              marginTop: "15px",
              padding: "8px 16px",
              borderRadius: "6px",
              border: "none",
              backgroundColor: "#9e9e9e",
              color: "#fff",
              cursor: "pointer",
            }}
          >
            Back to Dashboard
          </button>
        </PageWrapper>
      ) : showSensors ? (
        <PageWrapper background={sensorBg}>
          {showAddSensor ? (
            <AddSensorData onBack={() => setShowAddSensor(false)} />
          ) : (
            <>
              <SensorsData />
              <div
                style={{
                  marginTop: "15px",
                  display: "flex",
                  justifyContent: "center",
                  gap: "10px",
                }}
              >
                <button
                  onClick={() => setShowAddSensor(true)}
                  style={{
                    padding: "8px 16px",
                    borderRadius: "6px",
                    border: "none",
                    backgroundColor: "#4CAF50",
                    color: "#fff",
                    cursor: "pointer",
                  }}
                >
                  Add Sensor
                </button>
                <button
                  onClick={handleBackToDashboard}
                  style={{
                    padding: "8px 16px",
                    borderRadius: "6px",
                    border: "none",
                    backgroundColor: "#9e9e9e",
                    color: "#fff",
                    cursor: "pointer",
                  }}
                >
                  Back to Dashboard
                </button>
              </div>
            </>
          )}
        </PageWrapper>
      ) : showNotifications ? (
        <PageWrapper background={notificationBg}>   {/* ✅ Added background */}
          <Notification />
          <button
            onClick={handleBackToDashboard}
            style={{
              marginTop: "15px",
              padding: "8px 16px",
              borderRadius: "6px",
              border: "none",
              backgroundColor: "#9e9e9e",
              color: "#fff",
              cursor: "pointer",
            }}
          >
            Back to Dashboard
          </button>
        </PageWrapper>
      ) : (
        // Dashboard Home
        <div
          style={{
            width: "100%",
            minHeight: "100vh",
            backgroundImage: `url(${shd})`,
            backgroundSize: "cover",
            backgroundPosition: "center",
            backgroundRepeat: "no-repeat",
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
          }}
        >
          <header
            style={{
              width: "100%",
              display: "flex",
              justifyContent: "space-between",
              alignItems: "center",
              backgroundColor: "rgba(0,0,0,0.7)",
              color: "white",
              padding: "20px 30px",
              fontSize: "20px",
              fontWeight: "bold",
            }}
          >
            <span>SmartHomeDashboard</span>
            <button
              onClick={handleLogout}
              style={{
                backgroundColor: "#f44336",
                border: "none",
                padding: "8px 15px",
                borderRadius: "5px",
                color: "white",
                cursor: "pointer",
                fontSize: "14px",
              }}
            >
              Logout
            </button>
          </header>

          {/* Dashboard Options */}
          <div
            style={{
              backgroundColor: "#fff",
              padding: "20px 40px",
              borderRadius: "8px",
              boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
              fontWeight: "bold",
              fontSize: "20px",
              marginTop: "40px",
              cursor: "pointer",
            }}
            onClick={() => setShowDevices(true)}
          >
            Devices
          </div>
          <div
            style={{
              backgroundColor: "#fff",
              padding: "20px 40px",
              borderRadius: "8px",
              boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
              fontWeight: "bold",
              fontSize: "20px",
              marginTop: "20px",
              cursor: "pointer",
            }}
            onClick={() => setShowControls(true)}
          >
            Controls
          </div>
          <div
            style={{
              backgroundColor: "#fff",
              padding: "20px 40px",
              borderRadius: "8px",
              boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
              fontWeight: "bold",
              fontSize: "20px",
              marginTop: "20px",
              cursor: "pointer",
            }}
            onClick={() => setShowSensors(true)}
          >
            Sensor Data
          </div>
          <div
            style={{
              backgroundColor: "#fff",
              padding: "20px 40px",
              borderRadius: "8px",
              boxShadow: "0 4px 12px rgba(0,0,0,0.1)",
              fontWeight: "bold",
              fontSize: "20px",
              marginTop: "20px",
              cursor: "pointer",
            }}
            onClick={() => setShowNotifications(true)}
          >
            Notifications
          </div>
        </div>
      )}
    </div>
  );
};

export default AuthContainer;
