using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesTpmsBackend")]
    public class DomainDevicesTpmsBackend : libvirt.Domain.IDomainDevicesTpmsBackend
    {
        /// <summary>Configures a software-emulated TPM backend (such as swtpm), including its PCR banks, persistence, encryption, and debug behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator Domain#emulator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emulator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendEmulator? Emulator
        {
            get;
            set;
        }

        /// <summary>Selects an external TPM backend, where libvirt connects the guest to an already running TPM service rather than spawning an emulator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#external Domain#external}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "external", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternal\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendExternal? External
        {
            get;
            set;
        }

        /// <summary>Configures a TPM backend of type `passthrough`, which exposes a host TPM device directly to the guest instead of using an emulator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthrough\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesTpmsBackendPassthrough? Passthrough
        {
            get;
            set;
        }
    }
}
