using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesLeasesTarget")]
    public class DomainDevicesLeasesTarget : libvirt.Domain.IDomainDevicesLeasesTarget
    {
        /// <summary>Sets the path to the file or block device used as the lease target that must be acquired before the domain is allowed to start.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Sets an optional byte offset within the lease target file or device where this VM’s lease record starts;</summary>
        /// <remarks>
        /// value is user-provided and typically a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#offset Domain#offset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Offset
        {
            get;
            set;
        }
    }
}
