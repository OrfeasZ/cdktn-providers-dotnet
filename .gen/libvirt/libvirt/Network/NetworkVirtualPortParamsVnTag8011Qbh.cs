using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkVirtualPortParamsVnTag8011Qbh")]
    public class NetworkVirtualPortParamsVnTag8011Qbh : libvirt.Network.INetworkVirtualPortParamsVnTag8011Qbh
    {
        /// <summary>Sets the 802.1Qbh VN-Tag profile identifier (profileid) for this portgroup; value is user-provided and should match the profile configured on the VN-Tag–aware switch.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#profile_id Network#profile_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileId
        {
            get;
            set;
        }
    }
}
