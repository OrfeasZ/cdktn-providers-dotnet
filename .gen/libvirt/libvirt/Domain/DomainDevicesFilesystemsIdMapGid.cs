using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsIdMapGid")]
    public class DomainDevicesFilesystemsIdMapGid : libvirt.Domain.IDomainDevicesFilesystemsIdMapGid
    {
        /// <summary>Sets the size of the GID mapping range (number of consecutive IDs) for this mapping entry;</summary>
        /// <remarks>
        /// must be a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#count Domain#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }

        /// <summary>Sets the starting host GID to which the guest GID range is mapped; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        public double Target
        {
            get;
            set;
        }
    }
}
