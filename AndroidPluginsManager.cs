using System.Collections.Generic;
using System.Threading.Tasks;
using InTheHand.Net.Sockets;

public static class AndroidPluginsManager
{
	public static void RequestPermissions() {
		#if UNITY_ANDROID
		BluetoothPermissionHelper.RequestPermissions();
		#endif
	}

	public static Task<IReadOnlyCollection<BluetoothDeviceInfo>> GetBluetoothDevices() {
		return Task.Run(() => new BluetoothClient().DiscoverDevices());
	}
}