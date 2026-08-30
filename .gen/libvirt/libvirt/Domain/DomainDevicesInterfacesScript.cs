using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesScript")]
    public class DomainDevicesInterfacesScript : libvirt.Domain.IDomainDevicesInterfacesScript
    {
        /// <summary>Sets the absolute or relative filesystem path to the script that is run when the interface is torn down (for example, "/etc/qemu-ifdown").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
