using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolRefreshVolume), fullyQualifiedName: "libvirt.pool.PoolRefreshVolume")]
    public interface IPoolRefreshVolume
    {
        /// <summary>Sets the method used to compute volume allocation during refresh;</summary>
        /// <remarks>
        /// valid values are those supported by libvirt for the pool type (user-provided, e.g. "physical" vs "logical" where applicable).
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#refresh-overrides">https://libvirt.org/formatstorage.html#refresh-overrides</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#allocation Pool#allocation}
        /// </remarks>
        [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"string\"}")]
        string Allocation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolRefreshVolume), fullyQualifiedName: "libvirt.pool.PoolRefreshVolume")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolRefreshVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the method used to compute volume allocation during refresh;</summary>
            /// <remarks>
            /// valid values are those supported by libvirt for the pool type (user-provided, e.g. "physical" vs "logical" where applicable).
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#refresh-overrides">https://libvirt.org/formatstorage.html#refresh-overrides</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#allocation Pool#allocation}
            /// </remarks>
            [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"string\"}")]
            public string Allocation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
