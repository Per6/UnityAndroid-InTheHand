#if UNITY_ANDROID

using UnityEngine;

public static class BluetoothPermissionHelper
{
	const int RequestCode = 1337;
	static bool hasBeenUsed = false;

	public static void RequestPermissions()
	{
		if(hasBeenUsed)
			return;

		hasBeenUsed = true;

		if(Application.platform != RuntimePlatform.Android)
			return;
		
		using var activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer")
			.GetStatic<AndroidJavaObject>("currentActivity");

		int sdkInt = new AndroidJavaClass("android.os.Build$VERSION").GetStatic<int>("SDK_INT");

		if(sdkInt < 31) return;

		var permissions = new[] {
			"android.permission.BLUETOOTH_CONNECT",
			"android.permission.BLUETOOTH_SCAN"
		};

		foreach(var permission in permissions) {
			int check = activity.Call<int>("checkSelfPermission", permission);
			const int PERMISSION_GRANTED = 0;

			if(check != PERMISSION_GRANTED) {
				activity.Call("requestPermissions", permissions, RequestCode);
				break;
			}
		}
	}
}

#endif
