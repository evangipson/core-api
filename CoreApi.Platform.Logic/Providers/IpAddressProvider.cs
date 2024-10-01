using System.Net;
using System.Net.Sockets;

namespace CoreApi.Platform.Logic.Providers
{
    /// <inheritdoc cref="IIpAddressProvider"/>
    public class IpAddressProvider : IIpAddressProvider
    {
        public IPAddress GetPublicIpAddress() => Dns.GetHostEntry(Dns.GetHostName()).AddressList
            .Where(address => address.AddressFamily == AddressFamily.InterNetworkV6)
            .Where(address => !address.ToString().StartsWith("fe80::"))
            .FirstOrDefault() ?? throw new InvalidOperationException($"{nameof(GetPublicIpAddress)}: Failed to get local public IP address.");
    }
}
