using System;
using UnityEngine;

public class AndroidJniScope : IDisposable
{
	bool _didAttach;

	public AndroidJniScope() {
		_didAttach = AndroidJNI.AttachCurrentThread() > 0;
	}

	public void Dispose() {
		if(_didAttach) AndroidJNI.DetachCurrentThread();
	}
}
