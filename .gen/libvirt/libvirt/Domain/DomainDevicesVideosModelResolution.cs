using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesVideosModelResolution")]
    public class DomainDevicesVideosModelResolution : libvirt.Domain.IDomainDevicesVideosModelResolution
    {
        /// <summary>Sets the horizontal resolution in pixels for the video device; expects a positive integer (for example 1920).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#x Domain#x}
        /// </remarks>
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}")]
        public double X
        {
            get;
            set;
        }

        /// <summary>Sets the vertical resolution in pixels for the video device; expects a positive integer (for example 1080).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#y Domain#y}
        /// </remarks>
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"number\"}")]
        public double Y
        {
            get;
            set;
        }
    }
}
