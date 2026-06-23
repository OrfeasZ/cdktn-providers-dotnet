using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles")]
    public class DomainDevicesFilesystemsBinaryOpenFiles : libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles
    {
        /// <summary>Sets the maximum number of open file descriptors allowed for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is a user-provided positive integer. For example, 1024 or 4096.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max Domain#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }
    }
}
