using UnityEngine;

namespace InTheHand.Net.Sockets
{

public class BluetoothDeviceInfo
{
    AndroidJavaObject JavaObject;

    public BluetoothDeviceInfo(AndroidJavaObject obj)
    {
        JavaObject = obj;
    }

	public bool Authenticated { get {
		using var _ = new AndroidJniScope();
		int bondState = JavaObject.Call<int>("getBondState");
		return bondState == 12;
	} }

    public BluetoothAddress DeviceAddress { get {
		using var _ = new AndroidJniScope();
		return new(JavaObject.Call<string>("getAddress"), JavaObject);
	} }

    public string DeviceName { get {
		using var _ = new AndroidJniScope();
        return JavaObject.Call<string>("getName");
    } }

	public void Refresh() { }
}
}
