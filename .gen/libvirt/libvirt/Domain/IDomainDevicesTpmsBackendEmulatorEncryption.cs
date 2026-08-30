using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorEncryption), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption")]
    public interface IDomainDevicesTpmsBackendEmulatorEncryption
    {
        /// <summary>Specifies the identifier of the libvirt secret used to encrypt the emulated TPM’s persistent state;</summary>
        /// <remarks>
        /// value is user-provided and must match a defined secret.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#secret Domain#secret}
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        string Secret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorEncryption), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the identifier of the libvirt secret used to encrypt the emulated TPM’s persistent state;</summary>
            /// <remarks>
            /// value is user-provided and must match a defined secret.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#secret Domain#secret}
            /// </remarks>
            [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
            public string Secret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
