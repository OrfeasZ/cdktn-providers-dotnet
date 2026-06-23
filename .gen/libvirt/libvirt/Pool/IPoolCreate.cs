using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolCreate), fullyQualifiedName: "libvirt.pool.PoolCreate")]
    public interface IPoolCreate
    {
        /// <summary>Experimental: whether to set pool autostart on the host. Defaults to true. Subject to change.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#autostart Pool#autostart}
        /// </remarks>
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autostart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Experimental: whether to run StoragePoolBuild for this pool. If unset, provider default behavior applies. Subject to change.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#build Pool#build}
        /// </remarks>
        [JsiiProperty(name: "buildAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuildAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Experimental: whether to start the pool after definition. Defaults to true. Subject to change.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#start Pool#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolCreate), fullyQualifiedName: "libvirt.pool.PoolCreate")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolCreate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Experimental: whether to set pool autostart on the host. Defaults to true. Subject to change.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#autostart Pool#autostart}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Autostart
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Experimental: whether to run StoragePoolBuild for this pool. If unset, provider default behavior applies. Subject to change.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#build Pool#build}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BuildAttribute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Experimental: whether to start the pool after definition. Defaults to true. Subject to change.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#start Pool#start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Start
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
