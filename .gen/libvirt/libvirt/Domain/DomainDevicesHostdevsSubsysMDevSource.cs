using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysMDevSource")]
    public class DomainDevicesHostdevsSubsysMDevSource : libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource
    {
        /// <summary>Defines the host-side address for the mediated device source;</summary>
        /// <remarks>
        /// for mdev this typically contains the UUID identifying the mediated device instance on the host.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSourceAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSourceAddress? Address
        {
            get;
            set;
        }
    }
}
