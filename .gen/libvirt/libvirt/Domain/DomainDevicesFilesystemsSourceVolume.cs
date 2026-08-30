using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsSourceVolume")]
    public class DomainDevicesFilesystemsSourceVolume : libvirt.Domain.IDomainDevicesFilesystemsSourceVolume
    {
        /// <summary>Sets the name of the storage pool that contains the volume used as the filesystem source;</summary>
        /// <remarks>
        /// the value is user-provided and must match an existing pool (for example, "default").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool Domain#pool}
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}")]
        public string Pool
        {
            get;
            set;
        }

        /// <summary>Sets the name of the storage volume within the specified pool to expose as the filesystem source (for example, "myshare.img"); the value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}")]
        public string Volume
        {
            get;
            set;
        }
    }
}
