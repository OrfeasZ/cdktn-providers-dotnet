using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.volume.VolumeCreate")]
    public class VolumeCreate : libvirt.Volume.IVolumeCreate
    {
        /// <summary>Upload content from a URL or local file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#content Volume#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"libvirt.volume.VolumeCreateContent\"}")]
        public libvirt.Volume.IVolumeCreateContent Content
        {
            get;
            set;
        }
    }
}
