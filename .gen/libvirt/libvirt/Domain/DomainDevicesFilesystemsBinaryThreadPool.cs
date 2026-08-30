using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool")]
    public class DomainDevicesFilesystemsBinaryThreadPool : libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool
    {
        /// <summary>Sets the number of worker threads in the filesystem helper binary's thread pool;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer. For example, 4 or 16.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#size Domain#size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }
    }
}
