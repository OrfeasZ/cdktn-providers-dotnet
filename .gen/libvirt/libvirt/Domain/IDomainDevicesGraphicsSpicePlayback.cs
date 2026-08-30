using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpicePlayback), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpicePlayback")]
    public interface IDomainDevicesGraphicsSpicePlayback
    {
        /// <summary>Sets the audio compression mode for SPICE playback;</summary>
        /// <remarks>
        /// valid values are those supported by libvirt/QEMU (for example "on", "off", or codec-specific modes), and a value is required when the playback element is present.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#compression Domain#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        string Compression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpicePlayback), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpicePlayback")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpicePlayback
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the audio compression mode for SPICE playback;</summary>
            /// <remarks>
            /// valid values are those supported by libvirt/QEMU (for example "on", "off", or codec-specific modes), and a value is required when the playback element is present.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#compression Domain#compression}
            /// </remarks>
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
            public string Compression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
