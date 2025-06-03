using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Sockets;
using InTheHand.Net.Bluetooth;
using UnityEngine;

namespace InTheHand.Net.Sockets
{

public class BluetoothClient
{
    internal AndroidJavaObject? JavaObject;
	static AndroidJavaClass _JavaClass = null!;
    static AndroidJavaClass JavaClass => _JavaClass ??= new AndroidJavaClass("java.util.UUID");

    public BluetoothClient() { }

    public void Connect(BluetoothAddress address, Guid service)
    {
		using var _ = new AndroidJniScope();
		var guidObj = JavaClass.CallStatic<AndroidJavaObject>("fromString", service.ToString());
		JavaObject = address.JavaObject.Call<AndroidJavaObject>(
            "createRfcommSocketToServiceRecord",
            guidObj);

        JavaObject.Call("connect");
    }

	public bool Connected => JavaObject != null && JavaObject.Call<bool>("isConnected");

    public void Close()
    {
		using var _ = new AndroidJniScope();
        JavaObject?.Call("close");
    }

    public NetworkStream GetStream()
    {
		using var _ = new AndroidJniScope();
		if(JavaObject == null) throw new Exception("BluetoothClient is not connected");
        var istream = JavaObject.Call<AndroidJavaObject>("getInputStream");
		var ostream = JavaObject.Call<AndroidJavaObject>("getOutputStream");
        return new BluetoothNetworkStream(istream, ostream);
    }

	public IReadOnlyCollection<BluetoothDeviceInfo> DiscoverDevices() {
		using var _ = new AndroidJniScope();
		var devices = new Collection<BluetoothDeviceInfo>();

        var DevsSet = BluetoothRadio.Default.JavaObject.Call<AndroidJavaObject>("getBondedDevices");
        var DevsIter = DevsSet.Call<AndroidJavaObject>("iterator");

        while (DevsIter.Call<bool>("hasNext"))
        {
            var dev = DevsIter.Call<AndroidJavaObject>("next");
            devices.Add(new BluetoothDeviceInfo(dev));
        }

        return devices;
	}
}
}
