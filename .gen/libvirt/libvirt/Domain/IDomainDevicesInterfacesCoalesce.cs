using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesCoalesce), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesCoalesce")]
    public interface IDomainDevicesInterfacesCoalesce
    {
        /// <summary>Configures receive‑side coalescing parameters for this interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rx Domain#rx}
        /// </remarks>
        [JsiiProperty(name: "rx", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRx\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesCoalesceRx? Rx
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesCoalesce), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesCoalesce")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesCoalesce
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures receive‑side coalescing parameters for this interface.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#rx Domain#rx}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rx", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceRx\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesCoalesceRx? Rx
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesCoalesceRx?>();
            }
        }
    }
}
