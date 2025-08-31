using UnityEngine;

// Works only for WebGL platform
#if UNITY_WEBGL && !UNITY_EDITOR
using FirebaseWebGL.Examples.Database;
using FirebaseWebGL.Examples.Utils;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
#endif

// Works on all platforms except WebGL
#if !UNITY_WEBGL || UNITY_EDITOR
using Firebase;
using Firebase.Auth;
#endif

public class ConnectionManager : MonoBehaviour {
    // Firebase Auth instance for non-WebGL platforms
#if !UNITY_WEBGL || UNITY_EDITOR
    private FirebaseAuth auth;
#endif

    void Start() {
        // Non-WebGL platforms
#if !UNITY_WEBGL || UNITY_EDITOR
        // Initialize Firebase app
        FirebaseApp app = FirebaseApp.DefaultInstance;

        // Initialize Firebase Authentication
        auth = FirebaseAuth.DefaultInstance;

        // Example email and password (replace with real credentials)
        string email = "user@example.com";
        string password = "userPassword123";

        // Sign in asynchronously
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled) {
                Debug.LogError("Login canceled.");
            } else if (task.IsFaulted) {
                Debug.LogError("Login failed: " + task.Exception?.Message);
            } else {
                Debug.Log("Login successful. User ID: " + auth.CurrentUser.UserId);
            }
        });

        // WebGL platform
#else
        // Example email and password for WebGL (replace with real credentials)
        string email = "user@example.com";
        string password = "userPassword123";

        // Use Firebase WebGL login method
        FirebaseAuth.SignInWithEmailAndPassword(email, password, "InfoManager", "DisplayInfo", "DisplayErrorObject");
#endif
    }
}
