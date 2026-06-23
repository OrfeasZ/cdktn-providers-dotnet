using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsEglHeadless), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsEglHeadless")]
    public interface IDomainDevicesGraphicsEglHeadless
    {
        /// <summary>Configures OpenGL-related options for the egl-headless graphics backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gl Domain#gl}
        /// </remarks>
        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadlessGl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesGraphicsEglHeadlessGl? Gl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsEglHeadless), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsEglHeadless")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsEglHeadless
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures OpenGL-related options for the egl-headless graphics backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gl Domain#gl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadlessGl\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesGraphicsEglHeadlessGl? Gl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesGraphicsEglHeadlessGl?>();
            }
        }
    }
}
