using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsSdlGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSdlGl")]
    public interface IDomainDevicesGraphicsSdlGl
    {
        /// <summary>Controls whether OpenGL rendering is enabled for the SDL graphics backend; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
        /// </remarks>
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsSdlGl), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsSdlGl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsSdlGl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether OpenGL rendering is enabled for the SDL graphics backend; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enable Domain#enable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
