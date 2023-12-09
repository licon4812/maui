using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;

namespace Microsoft.Maui.Devices.Sensors
{
	/// <summary>
	/// Provides a way to use the Wifi capabilities of the device.
	/// </summary>
	public interface IWifi
	{
		/// <summary>
		/// Gets the current Wifi Adapter of the device.
		/// </summary>
		/// <returns>A <see cref="WifiAdapter"/> WifiAdapter</returns>
		Task<WifiAdapter> GetWifiAdapterAsync();

		/// <summary>
		/// Gets a list of Network Profiles for the Wifi Adapter.
		/// </summary>
		/// <returns>A list of <see cref="NetworkProfile"/></returns>
		Task<List<NetworkProfile>> GetNetworkProfilesAsync();
		/// <summary>
		///  Connects to a Wifi Network using a <see cref="NetworkProfile"/>
		/// </summary>
		/// <returns>Whether the connection succeeded or failed</returns>
		Task<bool> ConnectToWifiAsync(NetworkProfile networkProfile);
		/// <summary>
		/// Disconnects from a Wifi Network using a <see cref="NetworkProfile"/>
		/// </summary>
		/// <returns>Whether the disconnection succeeded or failed</returns>
		Task<bool> DisconnectWifiAsync(NetworkProfile networkProfile);
		/// <summary>
		///  Enables the Wifi Adapter
		/// </summary>
		Task EnableWifiAdapterAsync();
		/// <summary>
		/// Disables the Wifi Adapter
		/// </summary>
		/// <returns></returns>
		Task DisableWifiAdapterAsync();
	}

	/// <summary>
	/// Provides a way to use the wifi capabilities of the device.
	/// </summary>
	public static partial class Wifi
	{
		static Task<WifiAdapter> PlatformGetWifiAdapterAsync() => throw ExceptionUtils.NotSupportedOrImplementedException;
		static Task<List<NetworkProfile>> PlatformGetNetworkProfilesAsync() => throw ExceptionUtils.NotSupportedOrImplementedException;
		static Task<bool> PlatformConnectToWifiAsync(NetworkProfile networkProfile) => throw ExceptionUtils.NotSupportedOrImplementedException;
		static Task<bool> PlatformDisconnectWifiAsync(NetworkProfile networkProfile) => throw ExceptionUtils.NotSupportedOrImplementedException;
		static Task PlatformEnableWifiAdapterAsync() => throw ExceptionUtils.NotSupportedOrImplementedException;
		static Task PlatformDisableWifiAdapterAsync() => throw ExceptionUtils.NotSupportedOrImplementedException;

		static IWifi Current => Devices.Sensors.Wifi.Default;

		/// <summary>
		/// Provides the default implementation for static usage of this API.
		/// </summary>
		public static IWifi Default =>
			defaultImplementation ??= new WifiImplementation();

		static IWifi defaultImplementation;
	}

	partial class WifiImplementation : IWifi
	{
		public Task<WifiAdapter> GetWifiAdapterAsync()
		{
			throw new NotImplementedException();
		}

		public Task<List<NetworkProfile>> GetNetworkProfilesAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> ConnectToWifiAsync(NetworkProfile networkProfile)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DisconnectWifiAsync(NetworkProfile networkProfile)
		{
			throw new NotImplementedException();
		}

		public Task EnableWifiAdapterAsync()
		{
			throw new NotImplementedException();
		}

		public Task DisableWifiAdapterAsync()
		{
			throw new NotImplementedException();
		}
	}
}
