using UnityEngine;

public static class FirebaseData
{
	public static void SendData(string path, string value)
	{
		User newUser = new User(path, value);
		string json = JsonUtility.ToJson(newUser);

// Supported on all platforms except WebGL
#if !UNITY_WEBGL || UNITY_EDITOR
        Firebase.Database.DatabaseReference dbReference = Firebase.Database.FirebaseDatabase.DefaultInstance.RootReference;
		dbReference.Child(path).SetRawJsonValueAsync(json);
// Supported only on WebGL platform
#else
		FirebaseWebGL.Scripts.FirebaseBridge.FirebaseDatabase.PostJSON(path, json, "InfoManager", "DisplayInfo", "DisplayErrorObject");
#endif
    }
}
