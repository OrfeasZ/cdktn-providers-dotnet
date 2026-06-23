using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceBridge")]
    public class DomainDevicesInterfacesSourceBridge : libvirt.Domain.IDomainDevicesInterfacesSourceBridge
    {
        /// <summary>Sets the name of the existing host bridge device to which the interface connects (for example, "br0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bridge-to-lan">https://libvirt.org/formatdomain.html#bridge-to-lan</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#bridge Domain#bridge}
        /// </remarks>
        [JsiiProperty(name: "bridge", typeJson: "{\"primitive\":\"string\"}")]
        public string Bridge
        {
            get;
            set;
        }
    }
}
