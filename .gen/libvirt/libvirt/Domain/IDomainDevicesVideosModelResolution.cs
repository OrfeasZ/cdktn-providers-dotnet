using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesVideosModelResolution), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModelResolution")]
    public interface IDomainDevicesVideosModelResolution
    {
        /// <summary>Sets the horizontal resolution in pixels for the video device; expects a positive integer (for example 1920).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#x Domain#x}
        /// </remarks>
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}")]
        double X
        {
            get;
        }

        /// <summary>Sets the vertical resolution in pixels for the video device; expects a positive integer (for example 1080).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#y Domain#y}
        /// </remarks>
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"number\"}")]
        double Y
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesVideosModelResolution), fullyQualifiedName: "libvirt.domain.DomainDevicesVideosModelResolution")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesVideosModelResolution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the horizontal resolution in pixels for the video device; expects a positive integer (for example 1920).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#video-devices">https://libvirt.org/formatdomain.html#video-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#x Domain#x}
            /// </remarks>
            [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}")]
            public double X
            {
                get => GetInstanceProperty<double>()!;
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
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
