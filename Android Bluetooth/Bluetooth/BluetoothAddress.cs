
using UnityEngine;

namespace InTheHand.Net
{

public class BluetoothAddress
{
	public string address;
	public AndroidJavaObject JavaObject;

	public BluetoothAddress(string address, AndroidJavaObject JavaObject)
	{
		this.address = address;
		this.JavaObject = JavaObject;
	}
}
}
