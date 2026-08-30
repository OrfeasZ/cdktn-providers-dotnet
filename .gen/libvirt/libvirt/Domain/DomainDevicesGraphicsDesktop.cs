using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsDesktop")]
    public class DomainDevicesGraphicsDesktop : libvirt.Domain.IDomainDevicesGraphicsDesktop
    {
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
            get;
            set;
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
            get;
            set;
        }
    }
}
