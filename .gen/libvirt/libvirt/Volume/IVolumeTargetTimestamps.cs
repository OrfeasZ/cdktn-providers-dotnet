using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeTargetTimestamps), fullyQualifiedName: "libvirt.volume.VolumeTargetTimestamps")]
    public interface IVolumeTargetTimestamps
    {
        /// <summary>Sets the last access time of the volume, typically as a UNIX timestamp in seconds (and optional nanoseconds) since the epoch.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#atime Volume#atime}
        /// </remarks>
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
        string Atime
        {
            get;
        }

        /// <summary>Sets the last metadata change time of the volume, typically as a UNIX timestamp in seconds (and optional nanoseconds) since the epoch.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#ctime Volume#ctime}
        /// </remarks>
        [JsiiProperty(name: "ctime", typeJson: "{\"primitive\":\"string\"}")]
        string Ctime
        {
            get;
        }

        /// <summary>Sets the last modification time (mtime) metadata for the volume target, using a user-provided timestamp value (seconds plus optional nanoseconds) that must be present for the volume definition.</summary>
        /// <remarks>
        /// Examples: <c>seconds = 1716900000</c>, <c>seconds = 1716900000</c>, <c>nanoseconds = 123456789</c>.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#mtime Volume#mtime}
        /// </remarks>
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
        string Mtime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeTargetTimestamps), fullyQualifiedName: "libvirt.volume.VolumeTargetTimestamps")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeTargetTimestamps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the last access time of the volume, typically as a UNIX timestamp in seconds (and optional nanoseconds) since the epoch.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#atime Volume#atime}
            /// </remarks>
            [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
            public string Atime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the last metadata change time of the volume, typically as a UNIX timestamp in seconds (and optional nanoseconds) since the epoch.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#ctime Volume#ctime}
            /// </remarks>
            [JsiiProperty(name: "ctime", typeJson: "{\"primitive\":\"string\"}")]
            public string Ctime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the last modification time (mtime) metadata for the volume target, using a user-provided timestamp value (seconds plus optional nanoseconds) that must be present for the volume definition.</summary>
            /// <remarks>
            /// Examples: <c>seconds = 1716900000</c>, <c>seconds = 1716900000</c>, <c>nanoseconds = 123456789</c>.
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#storage-volume-target-elements">https://libvirt.org/formatstorage.html#storage-volume-target-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#mtime Volume#mtime}
            /// </remarks>
            [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Mtime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
