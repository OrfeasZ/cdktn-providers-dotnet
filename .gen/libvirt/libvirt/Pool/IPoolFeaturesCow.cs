using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolFeaturesCow), fullyQualifiedName: "libvirt.pool.PoolFeaturesCow")]
    public interface IPoolFeaturesCow
    {
        /// <summary>Sets whether filesystem-level copy-on-write is enabled for images in the pool; valid values are "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#features">https://libvirt.org/formatstorage.html#features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#state Pool#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolFeaturesCow), fullyQualifiedName: "libvirt.pool.PoolFeaturesCow")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolFeaturesCow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets whether filesystem-level copy-on-write is enabled for images in the pool; valid values are "on" or "off".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#features">https://libvirt.org/formatstorage.html#features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#state Pool#state}
            /// </remarks>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
