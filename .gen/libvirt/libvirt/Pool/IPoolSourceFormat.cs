using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceFormat), fullyQualifiedName: "libvirt.pool.PoolSourceFormat")]
    public interface IPoolSourceFormat
    {
        /// <summary>Sets the source format type string, such as "ext4", "xfs", "nfs", or other backend-specific formats;</summary>
        /// <remarks>
        /// the value is user-provided but must be valid for the chosen pool type.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#type Pool#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceFormat), fullyQualifiedName: "libvirt.pool.PoolSourceFormat")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the source format type string, such as "ext4", "xfs", "nfs", or other backend-specific formats;</summary>
            /// <remarks>
            /// the value is user-provided but must be valid for the chosen pool type.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#type Pool#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
