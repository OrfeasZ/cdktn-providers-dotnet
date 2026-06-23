using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolDestroy), fullyQualifiedName: "libvirt.pool.PoolDestroy")]
    public interface IPoolDestroy
    {
        /// <summary>Experimental: whether to run StoragePoolDelete on destroy. If unset, provider default behavior applies. Subject to change.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#delete Pool#delete}
        /// </remarks>
        [JsiiProperty(name: "delete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolDestroy), fullyQualifiedName: "libvirt.pool.PoolDestroy")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolDestroy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Experimental: whether to run StoragePoolDelete on destroy. If unset, provider default behavior applies. Subject to change.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#delete Pool#delete}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Delete
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
