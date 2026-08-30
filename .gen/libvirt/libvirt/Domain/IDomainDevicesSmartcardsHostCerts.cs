using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSmartcardsHostCerts), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcardsHostCerts")]
    public interface IDomainDevicesSmartcardsHostCerts
    {
        /// <summary>Sets the path to a certificate file included in the host-certificates smartcard configuration; value is a user-provided filesystem path.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSmartcardsHostCerts), fullyQualifiedName: "libvirt.domain.DomainDevicesSmartcardsHostCerts")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSmartcardsHostCerts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path to a certificate file included in the host-certificates smartcard configuration; value is a user-provided filesystem path.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
