using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorSource), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorSource")]
    public interface IDomainDevicesTpmsBackendEmulatorSource
    {
        /// <summary>Selects a directory-based backend for TPM emulator state and metadata storage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceDir\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceDir? Dir
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a file-based backend for TPM emulator state, pointing directly at a state file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceFile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceFile? File
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorSource), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects a directory-based backend for TPM emulator state and metadata storage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dir Domain#dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceDir\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceDir? Dir
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceDir?>();
            }

            /// <summary>Selects a file-based backend for TPM emulator state, pointing directly at a state file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceFile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceFile? File
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceFile?>();
            }
        }
    }
}
