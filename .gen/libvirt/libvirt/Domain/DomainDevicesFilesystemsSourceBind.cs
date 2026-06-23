using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsSourceBind")]
    public class DomainDevicesFilesystemsSourceBind : libvirt.Domain.IDomainDevicesFilesystemsSourceBind
    {
        /// <summary>Sets the absolute path of the host directory that is bind-mounted into the guest filesystem when using a bind source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dir Domain#dir}
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}")]
        public string Dir
        {
            get;
            set;
        }
    }
}
