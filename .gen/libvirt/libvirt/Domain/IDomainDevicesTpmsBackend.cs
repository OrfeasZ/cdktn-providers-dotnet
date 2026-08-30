using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackend")]
    public interface IDomainDevicesTpmsBackend
    {
        /// <summary>Configures a software-emulated TPM backend (such as swtpm), including its PCR banks, persistence, encryption, and debug behavior.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator Domain#emulator}
        /// </remarks>
        [JsiiProperty(name: "emulator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulator? Emulator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects an external TPM backend, where libvirt connects the guest to an already running TPM service rather than spawning an emulator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#external Domain#external}
        /// </remarks>
        [JsiiProperty(name: "external", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendExternal? External
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures a TPM backend of type `passthrough`, which exposes a host TPM device directly to the guest instead of using an emulator.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthrough\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendPassthrough? Passthrough
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackend")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a software-emulated TPM backend (such as swtpm), including its PCR banks, persistence, encryption, and debug behavior.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#emulator Domain#emulator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emulator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulator? Emulator
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulator?>();
            }

            /// <summary>Selects an external TPM backend, where libvirt connects the guest to an already running TPM service rather than spawning an emulator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#external Domain#external}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "external", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternal\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendExternal? External
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendExternal?>();
            }

            /// <summary>Configures a TPM backend of type `passthrough`, which exposes a host TPM device directly to the guest instead of using an emulator.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passthrough Domain#passthrough}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthrough\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendPassthrough? Passthrough
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendPassthrough?>();
            }
        }
    }
}
