#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System.IO;
using UnityEngine;

class RenameAndroidAssembly : IPostBuildPlayerScriptDLLs
{
	public int callbackOrder => 0;

	public void OnPostBuildPlayerScriptDLLs(BuildReport report)
	{
		if(report.summary.platform != BuildTarget.Android) return;

		string buildPath = Path.Combine(report.summary.outputPath, "unityLibrary", "src", "main", "assets", "bin", "Data", "Managed");
		string oldPath = Path.Combine(buildPath, "AndroidUnityBluetooth.dll");
		string newPath = Path.Combine(buildPath, "InTheHand.Net.Bluetooth.dll");

		if(File.Exists(oldPath)) {
			File.Move(oldPath, newPath);
			Debug.Log("Renamed AndroidUnityBluetooth.dll to InTheHand.Net.Bluetooth.dll for Android build.");
		} else {
			Debug.LogWarning("AndroidUnityBluetooth.dll not found in the expected location.");
		}
	}
}
#endif