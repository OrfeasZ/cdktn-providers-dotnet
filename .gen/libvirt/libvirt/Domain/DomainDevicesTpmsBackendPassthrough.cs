using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesTpmsBackendPassthrough")]
    public class DomainDevicesTpmsBackendPassthrough : libvirt.Domain.IDomainDevicesTpmsBackendPassthrough
    {
        /// <summary>Sets the host character or TPM device used by the passthrough TPM backend;</summary>
        /// <remarks>
        /// the device element groups attributes describing the host TPM node.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice? Device
        {
            get;
            set;
        }
    }
}
