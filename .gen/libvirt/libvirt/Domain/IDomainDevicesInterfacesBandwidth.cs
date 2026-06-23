using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesBandwidth), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBandwidth")]
    public interface IDomainDevicesInterfacesBandwidth
    {
        /// <summary>Configures outbound traffic shaping limits for this interface, allowing you to restrict or prioritize egress bandwidth using the child attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#inbound Domain#inbound}
        /// </remarks>
        [JsiiProperty(name: "inbound", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidthInbound\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBandwidthInbound? Inbound
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures outbound traffic shaping limits for this interface, allowing you to restrict or prioritize egress bandwidth using the child attributes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#outbound Domain#outbound}
        /// </remarks>
        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidthOutbound\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesBandwidthOutbound? Outbound
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesBandwidth), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBandwidth")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesBandwidth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures outbound traffic shaping limits for this interface, allowing you to restrict or prioritize egress bandwidth using the child attributes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#inbound Domain#inbound}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inbound", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidthInbound\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBandwidthInbound? Inbound
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBandwidthInbound?>();
            }

            /// <summary>Configures outbound traffic shaping limits for this interface, allowing you to restrict or prioritize egress bandwidth using the child attributes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#outbound Domain#outbound}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidthOutbound\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesBandwidthOutbound? Outbound
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesBandwidthOutbound?>();
            }
        }
    }
}
