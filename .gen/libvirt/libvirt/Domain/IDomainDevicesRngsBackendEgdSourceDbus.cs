using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRngsBackendEgdSourceDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsBackendEgdSourceDbus")]
    public interface IDomainDevicesRngsBackendEgdSourceDbus
    {
        /// <summary>Sets the D-Bus channel name used when the RNG backend connects to an EGD daemon over D-Bus;</summary>
        /// <remarks>
        /// the value is user-provided (for example, a well-known D-Bus object or channel identifier).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channel Domain#channel}
        /// </remarks>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRngsBackendEgdSourceDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsBackendEgdSourceDbus")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRngsBackendEgdSourceDbus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the D-Bus channel name used when the RNG backend connects to an EGD daemon over D-Bus;</summary>
            /// <remarks>
            /// the value is user-provided (for example, a well-known D-Bus object or channel identifier).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channel Domain#channel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
