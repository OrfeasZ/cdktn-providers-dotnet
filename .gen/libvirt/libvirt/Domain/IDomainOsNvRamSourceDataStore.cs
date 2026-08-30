using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceDataStore), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceDataStore")]
    public interface IDomainOsNvRamSourceDataStore
    {
        /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStoreFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainOsNvRamSourceDataStoreFormat? Format
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceDataStore), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceDataStore")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceDataStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the on-disk format settings for the mirrored backing store’s data store, including format type and optional metadata cache tuning.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStoreFormat\"}", isOptional: true)]
            public libvirt.Domain.IDomainOsNvRamSourceDataStoreFormat? Format
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainOsNvRamSourceDataStoreFormat?>();
            }
        }
    }
}
