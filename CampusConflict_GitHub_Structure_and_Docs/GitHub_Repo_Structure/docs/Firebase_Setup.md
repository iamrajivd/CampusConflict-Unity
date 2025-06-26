# Firebase Setup for Campus Conflict (Unity)

1. Go to [Firebase Console](https://console.firebase.google.com/)
2. Create a new project named "Campus Conflict"
3. Add an Android app and register your game’s package name (e.g., `com.campus.conflict`)
4. Download the `google-services.json` file and place it in the `Assets/` folder of your Unity project.
5. In Unity:
   - Install Firebase SDK via Unity Package Manager
   - Import Auth and Realtime DB SDKs
   - Enable Realtime Database in Firebase Console (set to test mode)
6. Replace Firebase keys in `FirebaseManager.cs` if needed

Done!
