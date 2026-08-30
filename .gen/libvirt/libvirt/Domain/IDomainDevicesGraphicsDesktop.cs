using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsDesktop), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDesktop")]
    public interface IDomainDevicesGraphicsDesktop
    {
        /// <summary>Sets the X11 display string for the SDL graphics desktop (for example, ":0.0") when using the SDL graphics backend; the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
        /// </remarks>
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Display
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the SDL desktop window starts in fullscreen mode; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#full_screen Domain#full_screen}
        /// </remarks>
        [JsiiProperty(name: "fullScreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FullScreen
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsDesktop), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsDesktop")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsDesktop
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the X11 display string for the SDL graphics desktop (for example, ":0.0") when using the SDL graphics backend; the value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#display Domain#display}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Display
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the SDL desktop window starts in fullscreen mode; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#full_screen Domain#full_screen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fullScreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FullScreen
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
