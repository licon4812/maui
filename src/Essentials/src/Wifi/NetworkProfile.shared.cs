using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui.Devices.Sensors
{
	/// <summary>
	/// Provides a Network profile for the Wifi Adapter.
	/// </summary>
	public class NetworkProfile
	{
		/// <summary>
		/// Gets or sets the ProfileName of the network connection.
		/// </summary>
		public string ProfileName { get; set; }
		/// <summary>
		/// Gets or sets ssid (network name).
		/// </summary>
		public string Ssid { get; set; }
		/// <summary>
		/// Gets or sets the network SecurityKey. This should be encrypted
		/// </summary>
		public string SecurityKey { get; set; }
		/// <summary>
		/// Gets or sets the SignalStrength.
		/// </summary>
		public int SignalStrength { get; set; }
		/// <summary>
		/// Gets or sets the Ipv4Address.
		/// </summary>
		public string Ipv4Address { get; set; }
		/// <summary>
		/// Gets or sets the Ipv6Address. 
		/// </summary>
		public string Ipv6Address { get; set; }
		/// <summary>
		/// Gets or sets the AdapterMACAddress
		/// </summary>
		public string AdapterMACAddress { get; set; }
		/// <summary>
		/// Gets or sets the network Band. 
		/// </summary>
		public string Band { get; set; }
	}
}
