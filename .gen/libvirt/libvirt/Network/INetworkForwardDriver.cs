using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkForwardDriver), fullyQualifiedName: "libvirt.network.NetworkForwardDriver")]
    public interface INetworkForwardDriver
    {
        /// <summary>Sets the driver model used for forwarding (for example, a specific macvtap or SR‑IOV mode), with the exact string value being driver-specific and user‑provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#model Network#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the forwarding driver backend name (e.g. a specific implementation used by the hypervisor), with the value being user‑provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkForwardDriver), fullyQualifiedName: "libvirt.network.NetworkForwardDriver")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkForwardDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the driver model used for forwarding (for example, a specific macvtap or SR‑IOV mode), with the exact string value being driver-specific and user‑provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#model Network#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the forwarding driver backend name (e.g. a specific implementation used by the hypervisor), with the value being user‑provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#name Network#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
