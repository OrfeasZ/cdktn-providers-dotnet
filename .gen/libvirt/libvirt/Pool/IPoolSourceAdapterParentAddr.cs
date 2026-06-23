using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceAdapterParentAddr), fullyQualifiedName: "libvirt.pool.PoolSourceAdapterParentAddr")]
    public interface IPoolSourceAdapterParentAddr
    {
        /// <summary>Sets the required unique identifier for the parent adapter address, used by libvirt to distinguish this adapter instance (user-provided string).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#unique_id Pool#unique_id}
        /// </remarks>
        [JsiiProperty(name: "uniqueId", typeJson: "{\"primitive\":\"number\"}")]
        double UniqueId
        {
            get;
        }

        /// <summary>Provides the structured PCI address of the parent adapter (domain, bus, slot, function).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#address Pool#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapterParentAddrAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolSourceAdapterParentAddrAddress? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceAdapterParentAddr), fullyQualifiedName: "libvirt.pool.PoolSourceAdapterParentAddr")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceAdapterParentAddr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the required unique identifier for the parent adapter address, used by libvirt to distinguish this adapter instance (user-provided string).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#unique_id Pool#unique_id}
            /// </remarks>
            [JsiiProperty(name: "uniqueId", typeJson: "{\"primitive\":\"number\"}")]
            public double UniqueId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Provides the structured PCI address of the parent adapter (domain, bus, slot, function).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#address Pool#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapterParentAddrAddress\"}", isOptional: true)]
            public libvirt.Pool.IPoolSourceAdapterParentAddrAddress? Address
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolSourceAdapterParentAddrAddress?>();
            }
        }
    }
}
