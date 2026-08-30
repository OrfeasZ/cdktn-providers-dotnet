using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorSourceFile), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceFile")]
    public interface IDomainDevicesTpmsBackendEmulatorSourceFile
    {
        /// <summary>Sets the host file path used by the TPM emulator to persist its state;</summary>
        /// <remarks>
        /// the value is a host filesystem path (for example, "/var/lib/swtpm/state.tpm").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorSourceFile), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceFile")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSourceFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host file path used by the TPM emulator to persist its state;</summary>
            /// <remarks>
            /// the value is a host filesystem path (for example, "/var/lib/swtpm/state.tpm").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
