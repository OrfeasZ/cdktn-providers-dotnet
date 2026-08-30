using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendPassthroughDevice), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice")]
    public interface IDomainDevicesTpmsBackendPassthroughDevice
    {
        /// <summary>Sets the path of the host TPM device node for a passthrough TPM backend (for example `/dev/tpm0`);</summary>
        /// <remarks>
        /// the value is user‑provided and required when passthrough is used.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendPassthroughDevice), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path of the host TPM device node for a passthrough TPM backend (for example `/dev/tpm0`);</summary>
            /// <remarks>
            /// the value is user‑provided and required when passthrough is used.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
