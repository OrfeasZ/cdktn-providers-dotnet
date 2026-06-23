using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesCoalesceRx), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesCoalesceRx")]
    public interface IDomainDevicesInterfacesCoalesceRx
    {
        /// <summary>Configures coalescing based on the number of received frames before an interrupt or notification is generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#frames Domain#frames}
        /// </remarks>
        [JsiiProperty(name: "frames", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRxFrames\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesCoalesceRxFrames? Frames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesCoalesceRx), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesCoalesceRx")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesCoalesceRx
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures coalescing based on the number of received frames before an interrupt or notification is generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#frames Domain#frames}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frames", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRxFrames\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesCoalesceRxFrames? Frames
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesCoalesceRxFrames?>();
            }
        }
    }
}
