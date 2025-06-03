using System;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

namespace InTheHand.Net.Bluetooth
{
public class BluetoothNetworkStream : NetworkStream
{
    AndroidJavaObject InputJavaObject;
	AndroidJavaObject OutputJavaObject;

    public override bool CanRead { get { return true; } }
    public override bool CanSeek { get { return false; } }
    public override bool CanWrite { get { return true; } }
    public override long Length { get { throw new NotSupportedException(); } }
    public override long Position
    {
        get { throw new NotSupportedException(); }
        set { throw new NotSupportedException(); }
    }

    public BluetoothNetworkStream(AndroidJavaObject inputStream, AndroidJavaObject outputStream)
		: base(CreateDummySocket(out TcpListener listener))
    {
        InputJavaObject = inputStream;
        OutputJavaObject = outputStream;
		listener.Stop();
    }

	static Socket CreateDummySocket(out TcpListener listener) {
		listener = new(IPAddress.Loopback, 0);
		listener.Start();
		int port = ((IPEndPoint)listener.LocalEndpoint).Port;
		Socket client = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		client.Connect(IPAddress.Loopback, port);
		return client;
	}

    public override void Flush()
    {
        /*
         * we don't do any buffering, so
         * nothing to do here
         */
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
		using var _ = new AndroidJniScope();
        /*
         * TODO: investigate if it's possible to make the
         * byte array buffer managment more efficient
         *
         * Right now for each read call we:
         *  - create new temp JNI array
         *  - use that when calling Java's InputStream.read() method
         *  - convert that temp array to managed array
         *  - copy from the converted array to callers provided buffer array
         *
         * This involved a lot of allocations and memory copy operations,
         * perhaps there is a way to directly write at the right memory location
         * in the caller provided buffer array.
         */

        var jniBuffer = AndroidJNI.NewSByteArray(count);
        jvalue[] args = new jvalue[3];
        args[0].l = jniBuffer;
        args[1].i = 0;
        args[2].i = count;

        IntPtr methodId = AndroidJNIHelper.GetMethodID(
            InputJavaObject.GetRawClass(),
            "read", "([BII)I");

        var r = AndroidJNI.CallIntMethod(
            InputJavaObject.GetRawObject(),
            methodId,
            args);

        sbyte[] manBuff = AndroidJNI.FromSByteArray(jniBuffer);

		Buffer.BlockCopy(manBuff, 0, buffer, offset, r);
        return r;
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
		using var _ = new AndroidJniScope();
		sbyte[] sbuffer = new sbyte[count];
		Buffer.BlockCopy(buffer, offset, sbuffer, offset, count);
        var jniBuffer = AndroidJNIHelper.ConvertToJNIArray(sbuffer);
        jvalue[] args = new jvalue[3];
        args[0].l = jniBuffer;
        args[1].i = offset;
        args[2].i = count;

        IntPtr methodId = AndroidJNIHelper.GetMethodID(
            OutputJavaObject.GetRawClass(),
            "write", "([BII)V");

        AndroidJNI.CallVoidMethod(
            OutputJavaObject.GetRawObject(),
            methodId,
            args);
    }

    public override long Seek(long offset, System.IO.SeekOrigin origin)
    {
        throw new NotSupportedException();
    }

    public override void SetLength(long value)
    {
        throw new NotSupportedException();
    }

	public override void Close()
	{
		InputJavaObject?.Call("close");
		OutputJavaObject?.Call("close");
	}

	protected override void Dispose(bool disposing)
	{
		if(disposing) {
			InputJavaObject?.Call("close");
			OutputJavaObject?.Call("close");
		}
	}
}
}
