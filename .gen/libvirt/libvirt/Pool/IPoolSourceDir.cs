using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceDir), fullyQualifiedName: "libvirt.pool.PoolSourceDir")]
    public interface IPoolSourceDir
    {
        /// <summary>Sets the absolute path to the source directory for the pool, such as "/var/lib/libvirt/images" or a mounted filesystem root.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#path Pool#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceDir), fullyQualifiedName: "libvirt.pool.PoolSourceDir")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceDir
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the absolute path to the source directory for the pool, such as "/var/lib/libvirt/images" or a mounted filesystem root.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#path Pool#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
