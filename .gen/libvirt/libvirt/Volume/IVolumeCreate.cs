using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeCreate), fullyQualifiedName: "libvirt.volume.VolumeCreate")]
    public interface IVolumeCreate
    {
        /// <summary>Upload content from a URL or local file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#content Volume#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreateContent\"}")]
        libvirt.Volume.IVolumeCreateContent Content
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeCreate), fullyQualifiedName: "libvirt.volume.VolumeCreate")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeCreate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Upload content from a URL or local file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/volume#content Volume#content}
            /// </remarks>
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreateContent\"}")]
            public libvirt.Volume.IVolumeCreateContent Content
            {
                get => GetInstanceProperty<libvirt.Volume.IVolumeCreateContent>()!;
            }
        }
    }
}
