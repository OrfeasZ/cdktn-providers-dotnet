using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceNmdm")]
    public class DomainDevicesDisksBackingStoreSourceReservationsSourceNmdm : libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceNmdm
    {
        /// <summary>Sets the master side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0A);</summary>
        /// <remarks>
        /// this attribute is required for an nmdm source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#master Domain#master}
        /// </remarks>
        [JsiiProperty(name: "master", typeJson: "{\"primitive\":\"string\"}")]
        public string Master
        {
            get;
            set;
        }

        /// <summary>Sets the slave side device path of the nmdm pair used for the EGD entropy connection (for example, /dev/nmdm0B);</summary>
        /// <remarks>
        /// this attribute is required for an nmdm source.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#nmdm-device">https://libvirt.org/formatdomain.html#nmdm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#slave Domain#slave}
        /// </remarks>
        [JsiiProperty(name: "slave", typeJson: "{\"primitive\":\"string\"}")]
        public string Slave
        {
            get;
            set;
        }
    }
}
