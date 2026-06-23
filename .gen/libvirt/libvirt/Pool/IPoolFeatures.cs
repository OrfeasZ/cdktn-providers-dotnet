using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolFeatures), fullyQualifiedName: "libvirt.pool.PoolFeatures")]
    public interface IPoolFeatures
    {
        /// <summary>Enables configuration of the copy-on-write (COW) feature for filesystems that support it in this storage pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#cow Pool#cow}
        /// </remarks>
        [JsiiProperty(name: "cow", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeaturesCow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolFeaturesCow? Cow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolFeatures), fullyQualifiedName: "libvirt.pool.PoolFeatures")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables configuration of the copy-on-write (COW) feature for filesystems that support it in this storage pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#cow Pool#cow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cow", typeJson: "{\"fqn\":\"libvirt.pool.PoolFeaturesCow\"}", isOptional: true)]
            public libvirt.Pool.IPoolFeaturesCow? Cow
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolFeaturesCow?>();
            }
        }
    }
}
