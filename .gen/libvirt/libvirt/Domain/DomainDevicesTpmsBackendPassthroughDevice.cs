using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice")]
    public class DomainDevicesTpmsBackendPassthroughDevice : libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice
    {
        /// <summary>Sets the path of the host TPM device node for a passthrough TPM backend (for example `/dev/tpm0`);</summary>
        /// <remarks>
        /// the value is user‑provided and required when passthrough is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
