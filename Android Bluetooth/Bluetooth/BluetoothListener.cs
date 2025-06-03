using System;
using InTheHand.Net.Bluetooth;
using UnityEngine;

namespace InTheHand.Net.Sockets
{

public class BluetoothListener
{
	AndroidJavaObject? ServerSocket;
	static AndroidJavaClass? UUIDClass;
	static AndroidJavaClass UUID => UUIDClass ??= new AndroidJavaClass("java.util.UUID");

	readonly Guid ServiceGuid;
	public bool Active => ServerSocket != null;

	public BluetoothListener(Guid service)
	{
		ServiceGuid = service;
	}

	public void Start()
	{
		using var _ = new AndroidJniScope();
		var adapter = BluetoothRadio.Default.JavaObject;
		var guidObj = UUID.CallStatic<AndroidJavaObject>("fromString", ServiceGuid.ToString());

		ServerSocket = adapter.Call<AndroidJavaObject>(
			"listenUsingRfcommWithServiceRecord",
			"UnityBluetoothService", guidObj);
	}

	public void Stop()
	{
		using var _ = new AndroidJniScope();
		ServerSocket?.Call("close");
		ServerSocket = null;
	}

	public BluetoothClient AcceptBluetoothClient()
	{
		using var _ = new AndroidJniScope();
		var socket = (ServerSocket?.Call<AndroidJavaObject>("accept")) ?? throw new Exception("Failed to accept connection");

		var client = new BluetoothClient {
			JavaObject = socket
		};
		return client;
	}
}
}
