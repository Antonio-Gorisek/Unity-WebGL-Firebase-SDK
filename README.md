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

For security:
- Apply restrictions in **Google APIs and Services**.  
- Update your Firebase rules. 
