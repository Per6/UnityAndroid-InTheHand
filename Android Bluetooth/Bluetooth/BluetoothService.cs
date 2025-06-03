using System;

namespace InTheHand.Net.Bluetooth
{

//
// Summary:
//     Standard Bluetooth Profile identifiers.
//
// Remarks:
//     See the list at http://www.bluetooth.org/Technical/AssignedNumbers/service_discovery.htm.
//
//
//     The Bluetooth Base UUID is {00000000-0000-1000-8000-00805F9B34FB}
public static class BluetoothService
{
	//
	// Summary:
	//     Represents an empty service Guid.
	public static readonly Guid Empty = Guid.Empty;

	//
	// Summary:
	//     Represents the base Guid from which all standard Bluetooth profiles are derived
	//     - not used for connections. Is {00000000-0000-1000-8000-00805F9B34FB}
	public static readonly Guid BluetoothBase = new Guid(0, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1000]
	public static readonly Guid ServiceDiscoveryServer = new Guid(4096, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1001]
	public static readonly Guid BrowseGroupDescriptor = new Guid(4097, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1002]
	public static readonly Guid PublicBrowseGroup = new Guid(4098, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Provides a basic Serial emulation connect over Bluetooth. [0x1101]
	public static readonly Guid SerialPort = new Guid(4353, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Used to establish PPP connections over RFComm channels. [0x1102]
	public static readonly Guid LanAccessUsingPpp = new Guid(4354, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1103]
	public static readonly Guid DialupNetworking = new Guid(4355, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1104]
	public static readonly Guid IrMCSync = new Guid(4356, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Used for sending binary objects between devices. [0x1105]
	public static readonly Guid ObexObjectPush = new Guid(4357, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     OBEX version of an FTP server. [0x1106]
	public static readonly Guid ObexFileTransfer = new Guid(4358, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1107]
	public static readonly Guid IrMCSyncCommand = new Guid(4359, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     HSP (Headset Profile) — Supports Bluetooth headset devices. [0x1108]
	//
	//     See also InTheHand.Net.Bluetooth.BluetoothService.HeadsetHeadset InTheHand.Net.Bluetooth.BluetoothService.HeadsetAudioGateway
	public static readonly Guid Headset = new Guid(4360, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1109]
	public static readonly Guid CordlessTelephony = new Guid(4361, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110A]
	public static readonly Guid AudioSource = new Guid(4362, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110B]
	public static readonly Guid AudioSink = new Guid(4363, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110C]
	public static readonly Guid AVRemoteControlTarget = new Guid(4364, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110D]
	public static readonly Guid AdvancedAudioDistribution = new Guid(4365, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110E]
	public static readonly Guid AVRemoteControl = new Guid(4366, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x110F]
	public static readonly Guid AVRemoteControlController = new Guid(4367, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1110]
	public static readonly Guid Intercom = new Guid(4368, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1111]
	public static readonly Guid Fax = new Guid(4369, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1112] See also InTheHand.Net.Bluetooth.BluetoothService.Headset InTheHand.Net.Bluetooth.BluetoothService.HeadsetHeadset
	public static readonly Guid HeadsetAudioGateway = new Guid(4370, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1113]
	public static readonly Guid Wap = new Guid(4371, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1114]
	public static readonly Guid WapClient = new Guid(4372, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1115]
	public static readonly Guid Panu = new Guid(4373, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1116]
	public static readonly Guid Nap = new Guid(4374, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1117]
	public static readonly Guid GN = new Guid(4375, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1118]
	public static readonly Guid DirectPrinting = new Guid(4376, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1119]
	public static readonly Guid ReferencePrinting = new Guid(4377, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x111A]
	public static readonly Guid Imaging = new Guid(4378, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x111B]
	public static readonly Guid ImagingResponder = new Guid(4379, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x111C]
	public static readonly Guid ImagingAutomaticArchive = new Guid(4380, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x111D]
	public static readonly Guid ImagingReferenceObjects = new Guid(4381, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Supports hands free kits such as a car kits which provide audio and more advanced
	//     call control than the Headset profile. [0x111E]
	public static readonly Guid Handsfree = new Guid(4382, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x111F]
	public static readonly Guid HandsfreeAudioGateway = new Guid(4383, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1120]
	public static readonly Guid DirectPrintingReferenceObjects = new Guid(4384, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1121]
	public static readonly Guid ReflectedUI = new Guid(4385, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Used for printing simple text, HTML, vCard objects and similar. [0x1122]
	public static readonly Guid BasicPrinting = new Guid(4386, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1123]
	public static readonly Guid PrintingStatus = new Guid(4387, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Supports human interface devices such as keyboards and mice. [0x1124]
	public static readonly Guid HumanInterfaceDevice = new Guid(4388, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1125]
	public static readonly Guid HardcopyCableReplacement = new Guid(4389, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1126]
	public static readonly Guid HardcopyCableReplacementPrint = new Guid(4390, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     [0x1127]
	public static readonly Guid HardcopyCableReplacementScan = new Guid(4391, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Common_ISDN_Access [0x1128]
	public static readonly Guid CommonIsdnAccess = new Guid(4392, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     SIM_Access [0x112D]
	public static readonly Guid SimAccess = new Guid(4397, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Phonebook Access - PCE [0x112E]
	public static readonly Guid PhonebookAccessPce = new Guid(4398, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Phonebook Access - PSE [0x112F]
	public static readonly Guid PhonebookAccessPse = new Guid(4399, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Phonebook Access [0x1130]
	public static readonly Guid PhonebookAccess = new Guid(4400, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Headset [0x1131] See also InTheHand.Net.Bluetooth.BluetoothService.Headset InTheHand.Net.Bluetooth.BluetoothService.HeadsetAudioGateway
	public static readonly Guid HeadsetHeadset = new Guid(4401, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Message Access Server [0x1132]
	public static readonly Guid MessageAccessServer = new Guid(4402, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Message Notification Server [0x1133]
	public static readonly Guid MessageNotificationServer = new Guid(4403, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Message Access Profile [0x1134]
	public static readonly Guid MessageAccessProfile = new Guid(4404, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GlobalNavigationSatelliteSystem [0x1135]
	public static readonly Guid GlobalNavigationSatelliteSystem = new Guid(4405, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GlobalNavigationSatelliteSystemServer [0x1136]
	public static readonly Guid GlobalNavigationSatelliteSystemServer = new Guid(4406, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     3D Display [0x1137]
	public static readonly Guid ThreeDimensionalDisplay = new Guid(4407, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     3D Glasses [0x1138]
	public static readonly Guid ThreeDimensionalGlasses = new Guid(4408, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     3D Synchronization [0x1139]
	public static readonly Guid ThreeDimensionalSynchronization = new Guid(4409, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     MPS Profile [0x113A]
	public static readonly Guid MultiProfile = new Guid(4410, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     MPS SC [0x113B]
	public static readonly Guid MultiProfileService = new Guid(4411, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     CTN Access Service [0x113C]
	public static readonly Guid CalendarTaskNoteAccess = new Guid(4412, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     CTN Notification Service [0x113D]
	public static readonly Guid CalendarTaskNoteNotification = new Guid(4413, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     CTN Profile [0x113E]
	public static readonly Guid CalendarTaskNotes = new Guid(4414, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Bluetooth Device Identification. [0x1200]
	public static readonly Guid PnPInformation = new Guid(4608, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GenericNetworking [0x1201]
	public static readonly Guid GenericNetworking = new Guid(4609, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GenericFileTransfer [0x1202]
	public static readonly Guid GenericFileTransfer = new Guid(4610, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GenericAudio [0x1203]
	public static readonly Guid GenericAudio = new Guid(4611, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     GenericTelephony [0x1204]
	public static readonly Guid GenericTelephony = new Guid(4612, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     UPNP_Service [0x1205]
	public static readonly Guid UPnp = new Guid(4613, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     UPNP_IP_Service [0x1206]
	public static readonly Guid UPnpIP = new Guid(4614, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     ESDP_UPNP_IP_PAN [0x1300]
	public static readonly Guid UPnpIPPan = new Guid(4864, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     ESDP_UPNP_IP_LAP [0x1301]
	public static readonly Guid UPnpIPLap = new Guid(4865, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     ESDP_UPNP_L2CAP [0x1302]
	public static readonly Guid UPnpIPL2Cap = new Guid(4866, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Video Distribution Profile - Source [0x1303]
	public static readonly Guid VideoSource = new Guid(4867, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Video Distribution Profile - Sink [0x1304]
	public static readonly Guid VideoSink = new Guid(4868, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Video Distribution Profile [0x1305]
	public static readonly Guid VideoDistribution = new Guid(4869, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Health Device Profile (HDP) [0x1400]
	public static readonly Guid HealthDevice = new Guid(5120, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Health Device Profile (HDP) - Source [0x1401]
	public static readonly Guid HealthDeviceSource = new Guid(5121, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Health Device Profile (HDP) - Sink [0x1402]
	public static readonly Guid HealthDeviceSink = new Guid(5122, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);

	//
	// Summary:
	//     Create a full 128-bit Service class UUID from its 16-bit short form.
	//
	// Parameters:
	//   uuid32:
	//     The service class UUID in the 32-bit UUID short form as a System.Int32.
	//
	// Returns:
	//     A System.Guid containing the full 128-bit form of the supplied Bluetooth service
	//     class UUID.
	public static Guid CreateBluetoothUuid(int uuid32)
	{
		return new Guid(uuid32, 0, 4096, 128, 0, 0, 128, 95, 155, 52, 251);
	}

	//
	// Summary:
	//     Create a full 128-bit Service class UUID from its 16-bit short form.
	//
	// Parameters:
	//   uuid32:
	//     The service class UUID in the 32-bit UUID short form as a System.UInt32.
	//
	// Returns:
	//     A System.Guid containing the full 128-bit form of the supplied Bluetooth service
	//     class UUID.
	public static Guid CreateBluetoothUuid(uint uuid32)
	{
		return CreateBluetoothUuid((int)uuid32);
	}

	internal static ushort? GetAsClassId16(Guid service)
	{
		byte[] value = service.ToByteArray();
		ushort num = BitConverter.ToUInt16(value, 0);
		Guid guid = CreateBluetoothUuid(num);
		if (service == guid)
		{
			return num;
		}

		return null;
	}
}
}
