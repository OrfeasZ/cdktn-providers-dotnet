using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceVdpa), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVdpa")]
    public interface IDomainDevicesInterfacesSourceVdpa
    {
        /// <summary>Sets the path or name of the vDPA device (e.g. "/dev/vhost-vdpaX") used as the source for the interface; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vdpa-devices">https://libvirt.org/formatdomain.html#vdpa-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Device
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceVdpa), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVdpa")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceVdpa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path or name of the vDPA device (e.g. "/dev/vhost-vdpaX") used as the source for the interface; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#vdpa-devices">https://libvirt.org/formatdomain.html#vdpa-devices</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#device Domain#device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Device
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
