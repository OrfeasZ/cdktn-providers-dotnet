using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesBandwidthInbound), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBandwidthInbound")]
    public interface IDomainDevicesInterfacesBandwidthInbound
    {
        /// <summary>Sets the long‑term average outbound bandwidth for this interface in kilobytes per second;</summary>
        /// <remarks>
        /// the hypervisor shapes egress traffic around this sustained rate.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#average Domain#average}
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

        /// <summary>Sets the maximum size of a temporary outbound bandwidth burst, in kilobytes, that can exceed the average rate before throttling applies.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#burst Domain#burst}
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

        /// <summary>Sets a minimum guaranteed outbound bandwidth for this interface in kilobytes per second, below which the traffic should not be throttled if capacity is available.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#floor Domain#floor}
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

        /// <summary>Sets an absolute peak outbound bandwidth limit for this interface in kilobytes per second that cannot be exceeded even during bursts.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#peak Domain#peak}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesBandwidthInbound), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBandwidthInbound")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesBandwidthInbound
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the long‑term average outbound bandwidth for this interface in kilobytes per second;</summary>
            /// <remarks>
            /// the hypervisor shapes egress traffic around this sustained rate.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#average Domain#average}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "average", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Average
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum size of a temporary outbound bandwidth burst, in kilobytes, that can exceed the average rate before throttling applies.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#burst Domain#burst}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "burst", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Burst
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets a minimum guaranteed outbound bandwidth for this interface in kilobytes per second, below which the traffic should not be throttled if capacity is available.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#floor Domain#floor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "floor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Floor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets an absolute peak outbound bandwidth limit for this interface in kilobytes per second that cannot be exceeded even during bursts.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#quality-of-service">https://libvirt.org/formatdomain.html#quality-of-service</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#peak Domain#peak}
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
