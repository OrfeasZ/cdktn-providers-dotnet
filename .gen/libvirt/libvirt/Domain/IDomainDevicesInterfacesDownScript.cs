using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesDownScript), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesDownScript")]
    public interface IDomainDevicesInterfacesDownScript
    {
        /// <summary>Sets the absolute or relative filesystem path to the script that is run when the interface is torn down (for example, "/etc/qemu-ifdown").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesDownScript), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesDownScript")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesDownScript
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the absolute or relative filesystem path to the script that is run when the interface is torn down (for example, "/etc/qemu-ifdown").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
