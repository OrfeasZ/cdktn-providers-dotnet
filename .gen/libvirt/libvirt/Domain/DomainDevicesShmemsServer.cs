using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesShmemsServer")]
    public class DomainDevicesShmemsServer : libvirt.Domain.IDomainDevicesShmemsServer
    {
        /// <summary>Sets the filesystem path used by the shmem server (for example, a memory-backend or socket path) as a user-provided string.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#shared-memory-device">https://libvirt.org/formatdomain.html#shared-memory-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
