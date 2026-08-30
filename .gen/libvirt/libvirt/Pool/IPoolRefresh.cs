using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolRefresh), fullyQualifiedName: "libvirt.pool.PoolRefresh")]
    public interface IPoolRefresh
    {
        /// <summary>Configures per-volume refresh behavior for the pool, including how each volume’s allocation is calculated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#volume Pool#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefreshVolume\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolRefreshVolume? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolRefresh), fullyQualifiedName: "libvirt.pool.PoolRefresh")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolRefresh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures per-volume refresh behavior for the pool, including how each volume’s allocation is calculated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#volume Pool#volume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.pool.PoolRefreshVolume\"}", isOptional: true)]
            public libvirt.Pool.IPoolRefreshVolume? Volume
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolRefreshVolume?>();
            }
        }
    }
}
