using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesChannelsSourceTcpReconnect), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsSourceTcpReconnect")]
    public interface IDomainDevicesChannelsSourceTcpReconnect
    {
        /// <summary>Sets whether the UNIX socket connection to the EGD RNG backend is automatically re-established when it drops;</summary>
        /// <remarks>
        /// accepts "yes" or "no" as a required value.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        string Enabled
        {
            get;
        }

        /// <summary>Sets the reconnect timeout (in seconds) for the UNIX socket connection to the EGD RNG backend;</summary>
        /// <remarks>
        /// the value is user-provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesChannelsSourceTcpReconnect), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsSourceTcpReconnect")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesChannelsSourceTcpReconnect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether the UNIX socket connection to the EGD RNG backend is automatically re-established when it drops;</summary>
            /// <remarks>
            /// accepts "yes" or "no" as a required value.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
            public string Enabled
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the reconnect timeout (in seconds) for the UNIX socket connection to the EGD RNG backend;</summary>
            /// <remarks>
            /// the value is user-provided and must be a non‑negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
