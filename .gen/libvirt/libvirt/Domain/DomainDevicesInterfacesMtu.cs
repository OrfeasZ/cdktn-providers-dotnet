using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesMtu")]
    public class DomainDevicesInterfacesMtu : libvirt.Domain.IDomainDevicesInterfacesMtu
    {
        /// <summary>Sets the MTU size for the virtual network link as a non-negative integer (for example, 1500 or 9000).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#mtu-configuration">https://libvirt.org/formatdomain.html#mtu-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }
    }
}
