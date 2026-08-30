using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesChannelsTargetGuestFwd), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTargetGuestFwd")]
    public interface IDomainDevicesChannelsTargetGuestFwd
    {
        /// <summary>Sets the host IP address or hostname that the guestfwd channel forwards traffic to; value is user-provided (e.g. "127.0.0.1").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TCP port number on the host that the guestfwd channel forwards traffic to;</summary>
        /// <remarks>
        /// must be a valid TCP port (1–65535).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesChannelsTargetGuestFwd), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTargetGuestFwd")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host IP address or hostname that the guestfwd channel forwards traffic to; value is user-provided (e.g. "127.0.0.1").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the TCP port number on the host that the guestfwd channel forwards traffic to;</summary>
            /// <remarks>
            /// must be a valid TCP port (1–65535).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Port
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
