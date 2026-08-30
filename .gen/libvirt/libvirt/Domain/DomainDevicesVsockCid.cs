using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesVsockCid")]
    public class DomainDevicesVsockCid : libvirt.Domain.IDomainDevicesVsockCid
    {
        /// <summary>Sets a fixed 32‑bit vsock context ID (CID) value to be used by the guest;</summary>
        /// <remarks>
        /// the value is user‑provided and must be valid for the chosen vsock backend (for example, a positive integer like 3).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Controls whether the vsock CID is assigned automatically;</summary>
        /// <remarks>
        /// when set (typically "yes"/"no"), libvirt or the hypervisor chooses an appropriate CID if automatic assignment is enabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vsock">https://libvirt.org/formatdomain.html#vsock</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto Domain#auto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Auto
        {
            get;
            set;
        }
    }
}
