using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceVendor), fullyQualifiedName: "libvirt.pool.PoolSourceVendor")]
    public interface IPoolSourceVendor
    {
        /// <summary>Sets the required vendor name string for the storage pool source (for example, "Red Hat" or a storage vendor identifier);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceVendor), fullyQualifiedName: "libvirt.pool.PoolSourceVendor")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceVendor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the required vendor name string for the storage pool source (for example, "Red Hat" or a storage vendor identifier);</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
