using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceProduct), fullyQualifiedName: "libvirt.pool.PoolSourceProduct")]
    public interface IPoolSourceProduct
    {
        /// <summary>Sets the required product name string for the storage pool source (for example, a storage array or disk product identifier);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceProduct), fullyQualifiedName: "libvirt.pool.PoolSourceProduct")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceProduct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the required product name string for the storage pool source (for example, a storage array or disk product identifier);</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
