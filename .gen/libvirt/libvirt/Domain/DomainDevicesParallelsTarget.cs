using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesParallelsTarget")]
    public class DomainDevicesParallelsTarget : libvirt.Domain.IDomainDevicesParallelsTarget
    {
        /// <summary>Sets the guest parallel port number (non-negative integer, usually 0, 1, or 2) that this device is exposed as.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#parallel-port">https://libvirt.org/formatdomain.html#parallel-port</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Defines the kind of guest-facing target for the parallel device (for example a specific controller/model type);</summary>
        /// <remarks>
        /// the exact value is user-provided and driver-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#parallel-port">https://libvirt.org/formatdomain.html#parallel-port</a>
        ///
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
