using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiByValue(fqn: "libvirt.volume.VolumeBackingStorePermissions")]
    public class VolumeBackingStorePermissions : libvirt.Volume.IVolumeBackingStorePermissions
    {
        /// <summary>Sets the numeric group ID (gid) that owns the backing store file or device;</summary>
        /// <remarks>
        /// the value is user-provided, for example <c>107</c>.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#group Volume#group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Sets an SELinux security label for the backing store, when SELinux labeling is in use; the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#label Volume#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Sets the numeric file mode (permission bits) for the backing store, typically as an octal value such as `0640`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#mode Volume#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Sets the numeric user ID (uid) that owns the backing store file or device;</summary>
        /// <remarks>
        /// the value is user-provided, for example <c>107</c>.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#backing-store-elements">https://libvirt.org/formatstorage.html#backing-store-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#owner Volume#owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Owner
        {
            get;
            set;
        }
    }
}
