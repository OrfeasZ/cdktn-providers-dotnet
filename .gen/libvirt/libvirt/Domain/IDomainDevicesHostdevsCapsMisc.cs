using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsMisc), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsMisc")]
    public interface IDomainDevicesHostdevsCapsMisc
    {
        /// <summary>Defines the source configuration for the miscellaneous capability, such as underlying host resources or paths needed by that capability.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMiscSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsCapsMiscSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsMisc), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsMisc")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsMisc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the source configuration for the miscellaneous capability, such as underlying host resources or paths needed by that capability.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMiscSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsCapsMiscSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsCapsMiscSource?>();
            }
        }
    }
}
