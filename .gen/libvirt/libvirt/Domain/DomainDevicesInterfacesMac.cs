using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesMac")]
    public class DomainDevicesInterfacesMac : libvirt.Domain.IDomainDevicesInterfacesMac
    {
        /// <summary>Sets the MAC address of the NIC as a 6-byte hexadecimal address string (for example, "52:54:00:ab:cd:ef");</summary>
        /// <remarks>
        /// must be unique per interface on the same network.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Controls how libvirt handles MAC address conflicts for this NIC;</summary>
        /// <remarks>
        /// valid values are implementation-defined strings such as "none" or "duplicate" where supported, and are user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#network-interfaces">https://libvirt.org/formatdomain.html#network-interfaces</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#check Domain#check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "check", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Check
        {
            get;
            set;
        }

        /// <summary>Sets the MAC address type for the interface; value is user-provided (for example, vendor-specific type strings) and is optional.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
