using UnityEngine;

namespace InTheHand.Net.Bluetooth
{

public class BluetoothRadio
{
    static AndroidJavaClass _JavaClass = null!;
    static AndroidJavaClass JavaClass =>
		_JavaClass ??= new AndroidJavaClass("android.bluetooth.BluetoothAdapter");

    internal AndroidJavaObject JavaObject;

	public RadioMode Mode {
		get {
			using var _ = new AndroidJniScope();
			int scanMode = JavaObject.Call<int>("getScanMode");
			return scanMode switch {
				20 => RadioMode.PowerOff,
				21 => RadioMode.Connectable,
				23 => RadioMode.Discoverable,
				_ => throw new System.Exception($"Unknown scan mode: {scanMode}")
			};
		}
		set => throw new System.NotSupportedException("Setting scan mode is not supported directly via BluetoothAdapter");
	}
	public string Name { get {
		using var _ = new AndroidJniScope();
		string name = JavaObject.Call<string>("getName");
		return name;
	} }

    public static BluetoothRadio Default { get {
		using var _ = new AndroidJniScope();
        var obj = JavaClass.CallStatic<AndroidJavaObject>("getDefaultAdapter")
			?? throw new System.Exception("Bluetooth adapter not available");
		return new BluetoothRadio(obj);
    } }

    BluetoothRadio(AndroidJavaObject obj)
    {
        JavaObject = obj;
    }

    public bool IsEnabled()
    {
		using var _ = new AndroidJniScope();
        return JavaObject.Call<bool>("isEnabled");
    }
}

public enum RadioMode {
	PowerOff,
	Connectable,
	Discoverable
}
}
