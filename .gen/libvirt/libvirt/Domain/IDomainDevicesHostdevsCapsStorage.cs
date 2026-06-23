using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsStorage), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsStorage")]
    public interface IDomainDevicesHostdevsCapsStorage
    {
        /// <summary>Defines the storage source information for the passthrough host device, typically pointing to a host block device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorageSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsCapsStorageSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsStorage), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsStorage")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the storage source information for the passthrough host device, typically pointing to a host block device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorageSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsCapsStorageSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsCapsStorageSource?>();
            }
        }
    }
}
