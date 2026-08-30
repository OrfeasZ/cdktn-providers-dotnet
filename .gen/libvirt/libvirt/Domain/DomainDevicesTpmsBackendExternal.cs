using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesTpmsBackendExternal")]
    public class DomainDevicesTpmsBackendExternal : libvirt.Domain.IDomainDevicesTpmsBackendExternal
    {
        /// <summary>Configures how the external TPM backend is reached, via either a D-Bus service or a character device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternalSource? Source
        {
            get;
            set;
        }
    }
}
