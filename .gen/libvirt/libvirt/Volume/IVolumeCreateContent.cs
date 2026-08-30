using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiInterface(nativeType: typeof(IVolumeCreateContent), fullyQualifiedName: "libvirt.volume.VolumeCreateContent")]
    public interface IVolumeCreateContent
    {
        /// <summary>URL to download content from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#url Volume#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVolumeCreateContent), fullyQualifiedName: "libvirt.volume.VolumeCreateContent")]
        internal sealed class _Proxy : DeputyBase, libvirt.Volume.IVolumeCreateContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>URL to download content from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#url Volume#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
