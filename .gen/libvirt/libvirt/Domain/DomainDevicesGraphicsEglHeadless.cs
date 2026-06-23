using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsEglHeadless")]
    public class DomainDevicesGraphicsEglHeadless : libvirt.Domain.IDomainDevicesGraphicsEglHeadless
    {
        /// <summary>Configures OpenGL-related options for the egl-headless graphics backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gl Domain#gl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadlessGl\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsEglHeadlessGl? Gl
        {
            get;
            set;
        }
    }
}
