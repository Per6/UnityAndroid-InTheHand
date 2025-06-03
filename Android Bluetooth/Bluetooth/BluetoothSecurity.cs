using UnityEngine;

namespace InTheHand.Net.Bluetooth
{

public sealed class BluetoothSecurity
{
	public static bool PairRequest(BluetoothAddress device, string pin = null!)
	{
		using var _ = new AndroidJniScope();
		using AndroidJavaObject deviceObj = device.JavaObject;
		if(pin != null) {
			bool success = deviceObj.Call<bool>("setPin", AndroidJNI.NewStringUTF(pin));
			if(!success) return false;
		}
		return deviceObj.Call<bool>("createBond");
	}
}
}