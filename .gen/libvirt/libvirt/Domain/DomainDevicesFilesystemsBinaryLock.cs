using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsBinaryLock")]
    public class DomainDevicesFilesystemsBinaryLock : libvirt.Domain.IDomainDevicesFilesystemsBinaryLock
    {
        /// <summary>Enables or disables use of flock-style locking by the filesystem helper binary;</summary>
        /// <remarks>
        /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#flock Domain#flock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Flock
        {
            get;
            set;
        }

        /// <summary>Enables or disables use of POSIX locks by the filesystem helper binary;</summary>
        /// <remarks>
        /// value is typically "on"/"off" or "yes"/"no" according to libvirt's locking options. When omitted, the driver default is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#posix Domain#posix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "posix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Posix
        {
            get;
            set;
        }
    }
}
