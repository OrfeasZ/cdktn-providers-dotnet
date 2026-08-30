using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesParallelsProtocol), fullyQualifiedName: "libvirt.domain.DomainDevicesParallelsProtocol")]
    public interface IDomainDevicesParallelsProtocol
    {
        /// <summary>Sets the EGD transport type, such as "tcp" or "unix"; value is a user-provided string supported by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesParallelsProtocol), fullyQualifiedName: "libvirt.domain.DomainDevicesParallelsProtocol")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesParallelsProtocol
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the EGD transport type, such as "tcp" or "unix"; value is a user-provided string supported by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
