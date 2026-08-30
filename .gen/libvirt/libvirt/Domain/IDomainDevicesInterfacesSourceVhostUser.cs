using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUser")]
    public interface IDomainDevicesInterfacesSourceVhostUser
    {
        /// <summary>Sets the vhost-user device path for the interface, typically the UNIX socket path used by the vhost-user backend (for example, "/var/run/vhost-user.sock").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vhost-user-connection">https://libvirt.org/formatdomain.html#vhost-user-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chardev Domain#chardev}
        /// </remarks>
        [JsiiProperty(name: "chardev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardev\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardev? Chardev
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUser), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUser")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the vhost-user device path for the interface, typically the UNIX socket path used by the vhost-user backend (for example, "/var/run/vhost-user.sock").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#vhost-user-connection">https://libvirt.org/formatdomain.html#vhost-user-connection</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chardev Domain#chardev}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chardev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardev\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardev? Chardev
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardev?>();
            }
        }
    }
}
