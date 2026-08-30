using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkBandwidthInbound), fullyQualifiedName: "libvirt.network.NetworkBandwidthInbound")]
    public interface INetworkBandwidthInbound
    {
        /// <summary>Sets the long-term average outbound bandwidth limit in kilobytes per second; value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#average Network#average}
        /// </remarks>
        [JsiiProperty(name: "average", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Average
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum instantaneous outbound bandwidth burst size in kilobytes per second that may temporarily exceed the average;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#burst Network#burst}
        /// </remarks>
        [JsiiProperty(name: "burst", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Burst
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a minimum guaranteed outbound bandwidth in kilobytes per second when supported by the backend;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#floor Network#floor}
        /// </remarks>
        [JsiiProperty(name: "floor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Floor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an upper cap on outbound bandwidth in kilobytes per second, typically higher than average but not exceeding burst;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#peak Network#peak}
        /// </remarks>
        [JsiiProperty(name: "peak", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Peak
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkBandwidthInbound), fullyQualifiedName: "libvirt.network.NetworkBandwidthInbound")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkBandwidthInbound
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the long-term average outbound bandwidth limit in kilobytes per second; value is a user-provided non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#average Network#average}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "average", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Average
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum instantaneous outbound bandwidth burst size in kilobytes per second that may temporarily exceed the average;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#burst Network#burst}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "burst", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Burst
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets a minimum guaranteed outbound bandwidth in kilobytes per second when supported by the backend;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#floor Network#floor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "floor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Floor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets an upper cap on outbound bandwidth in kilobytes per second, typically higher than average but not exceeding burst;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#quality-of-service">https://libvirt.org/formatnetwork.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#peak Network#peak}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peak", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Peak
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
