using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysMDevSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDevSource")]
    public interface IDomainDevicesHostdevsSubsysMDevSource
    {
        /// <summary>Defines the host-side address for the mediated device source;</summary>
        /// <remarks>
        /// for mdev this typically contains the UUID identifying the mediated device instance on the host.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSourceAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSourceAddress? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysMDevSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysMDevSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the host-side address for the mediated device source;</summary>
            /// <remarks>
            /// for mdev this typically contains the UUID identifying the mediated device instance on the host.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevSourceAddress\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSourceAddress? Address
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysMDevSourceAddress?>();
            }
        }
    }
}
