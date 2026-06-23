using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceVhostUser")]
    public class DomainDevicesInterfacesSourceVhostUser : libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser
    {
        /// <summary>Sets the vhost-user device path for the interface, typically the UNIX socket path used by the vhost-user backend (for example, "/var/run/vhost-user.sock").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vhost-user-connection">https://libvirt.org/formatdomain.html#vhost-user-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        public string Dev
        {
            get;
            set;
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#chardev Domain#chardev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chardev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardev\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardev? Chardev
        {
            get;
            set;
        }
    }
}
