using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolTargetTimestamps), fullyQualifiedName: "libvirt.pool.PoolTargetTimestamps")]
    public interface IPoolTargetTimestamps
    {
        /// <summary>Sets the last access time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided (for example, a seconds or seconds.nanoseconds timestamp as supported by libvirt).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#atime Pool#atime}
        /// </remarks>
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
        string Atime
        {
            get;
        }

        /// <summary>Sets the last metadata change time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided in the timestamp format expected by libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#ctime Pool#ctime}
        /// </remarks>
        [JsiiProperty(name: "ctime", typeJson: "{\"primitive\":\"string\"}")]
        string Ctime
        {
            get;
        }

        /// <summary>Sets the last data modification time for the pool target path;</summary>
        /// <remarks>
        /// the value is user-provided in the timestamp format expected by libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#mtime Pool#mtime}
        /// </remarks>
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
        string Mtime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolTargetTimestamps), fullyQualifiedName: "libvirt.pool.PoolTargetTimestamps")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolTargetTimestamps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the last access time for the pool target path;</summary>
            /// <remarks>
            /// the value is user-provided (for example, a seconds or seconds.nanoseconds timestamp as supported by libvirt).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#atime Pool#atime}
            /// </remarks>
            [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
            public string Atime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the last metadata change time for the pool target path;</summary>
            /// <remarks>
            /// the value is user-provided in the timestamp format expected by libvirt.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#ctime Pool#ctime}
            /// </remarks>
            [JsiiProperty(name: "ctime", typeJson: "{\"primitive\":\"string\"}")]
            public string Ctime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the last data modification time for the pool target path;</summary>
            /// <remarks>
            /// the value is user-provided in the timestamp format expected by libvirt.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#mtime Pool#mtime}
            /// </remarks>
            [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Mtime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
