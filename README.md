# Firebase for All Devices

This setup provides a foundation for communication with Firebase across all devices, ensuring compatibility for future projects.

### 1. Create a Firebase Database
The first step is to create a Firebase database.

Once the database is created, navigate to **Project Settings**.  
![Screenshot_29](https://github.com/IndigoGameStudio/Firebase-PC-and-WebGl-SDK/assets/29728342/ac14d18c-7d0b-4956-abd0-1c162e175837)

### 2. Configure SDKs
Within the **Project Settings**, create SDK configurations for both **Web** and **Unity**.  
![Screenshot_30](https://github.com/IndigoGameStudio/Firebase-PC-and-WebGl-SDK/assets/29728342/47302415-9950-45ec-9b23-4c7a30836b7e)

- Replace the **Web SDK data** inside your HTML file.  
- Replace the **Unity SDK data** using the `google.services.json` file.

Additionally, export the file **FirebaseCppApp-11_4_0.rar** located at:  
This is necessary because the file exceeds 100 MB and cannot be pushed directly.

### 3. Security and Restrictions
The project already contains several demo scenes that can be reviewed for implementation examples.

# Firebase WebGL SDK – Full Unity SDK Functionality

The Firebase WebGL SDK provides the same functionality as the Unity SDK, ensuring that your web builds can access all Firebase services just like your Unity projects. 
This includes:

- **Realtime Database**  
  Listen to value changes, child added/removed/changed events, and automatically trigger callbacks when data updates occur.

- **Authentication**  
  Support for all Firebase authentication methods (Email/Password, Google, Facebook, etc.) with proper event callbacks for sign-in, sign-out, and state changes.

- **Cloud Firestore**  
  Real-time listeners for documents and collections, enabling WebGL builds to respond immediately to data changes, just like in Unity.

- **Cloud Functions & Cloud Messaging**  
  Trigger server-side functions and receive messages/events in your WebGL application.

- **Storage**  
  Upload, download, and monitor files in Firebase Storage with progress callbacks.

In short, anything that works with the Firebase Unity SDK—callbacks, events, real-time updates, authentication flows, storage operations, and cloud interactions—is fully supported in WebGL builds. This ensures feature parity and allows seamless cross-platform development without rewriting your Firebase logic.
