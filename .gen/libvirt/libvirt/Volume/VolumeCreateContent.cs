using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.volume.VolumeCreateContent")]
    public class VolumeCreateContent : libvirt.Volume.IVolumeCreateContent
    {
        /// <summary>URL to download content from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/volume#url Volume#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
