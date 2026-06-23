using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSpiceImage), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceImage")]
    public interface IDomainDevicesGraphicsSpiceImage
    {
        /// <summary>Sets the SPICE image compression policy; valid values include `auto_glz`, `auto_lz`, `quic`, `glz`, `lz`, `off`, and `always`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#compression Domain#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        string Compression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSpiceImage), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSpiceImage")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSpiceImage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SPICE image compression policy; valid values include `auto_glz`, `auto_lz`, `quic`, `glz`, `lz`, `off`, and `always`.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#compression Domain#compression}
            /// </remarks>
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
            public string Compression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
