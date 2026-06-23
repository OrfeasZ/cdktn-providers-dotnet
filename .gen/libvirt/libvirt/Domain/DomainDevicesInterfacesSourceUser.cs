using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceUser")]
    public class DomainDevicesInterfacesSourceUser : libvirt.Domain.IDomainDevicesInterfacesSourceUser
    {
        /// <summary>Sets an optional host-side device name or identifier for the user-mode (SLIRP) networking backend;</summary>
        /// <remarks>
        /// value is user-provided and normally omitted.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-slirp">https://libvirt.org/formatdomain.html#userspace-connection-using-slirp</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }
    }
}
