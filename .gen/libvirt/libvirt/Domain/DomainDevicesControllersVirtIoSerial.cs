using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersVirtIoSerial")]
    public class DomainDevicesControllersVirtIoSerial : libvirt.Domain.IDomainDevicesControllersVirtIoSerial
    {
        /// <summary>Sets the maximum number of virtio-serial ports that this controller can provide; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ports Domain#ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ports
        {
            get;
            set;
        }

        /// <summary>Sets the number of MSI/MSI‑X vectors used by the virtio-serial controller for interrupts; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vectors Domain#vectors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vectors
        {
            get;
            set;
        }
    }
}
