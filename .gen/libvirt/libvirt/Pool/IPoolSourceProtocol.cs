using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceProtocol), fullyQualifiedName: "libvirt.pool.PoolSourceProtocol")]
    public interface IPoolSourceProtocol
    {
        /// <summary>Sets the required protocol version string used by the storage pool source (for example, an RBD or protocol-specific version);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#version Pool#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceProtocol), fullyQualifiedName: "libvirt.pool.PoolSourceProtocol")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceProtocol
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the required protocol version string used by the storage pool source (for example, an RBD or protocol-specific version);</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#version Pool#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
