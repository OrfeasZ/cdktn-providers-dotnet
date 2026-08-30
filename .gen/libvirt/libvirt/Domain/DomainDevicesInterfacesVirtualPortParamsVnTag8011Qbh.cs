using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh")]
    public class DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh : libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh
    {
        /// <summary>Sets the 802.1Qbh VN-Tag profile identifier associated with this virtual port; the value is user-provided and must match the upstream fabric configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#profile_id Domain#profile_id}
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
