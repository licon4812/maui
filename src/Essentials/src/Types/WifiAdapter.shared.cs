using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Essentials.Wifi;

namespace Microsoft.Maui.Devices.Sensors
{
	/// <summary>
	/// Represents a Wifi Adapter for the device.
	/// </summary>
	public class WifiAdapter
	{

		/// <summary>
		/// Gets or sets the NetworkProfile to be used by the WifiAdapter.
		/// </summary>
		public List<NetworkProfile> NetworkProfiles { get; set; }
		/// <summary>
		/// Initialises a new instance of the <see cref="WifiAdapter"/> class.
		/// </summary>
		public WifiAdapter()
		{
		}

		/// <summary>
		/// Initialises a new instance of the <see cref="WifiAdapter"/> class with a provided list network profiles.
		/// </summary>
		public WifiAdapter(List<NetworkProfile> networkProfiles)
		{
			NetworkProfiles = networkProfiles;
		}
	}
}
