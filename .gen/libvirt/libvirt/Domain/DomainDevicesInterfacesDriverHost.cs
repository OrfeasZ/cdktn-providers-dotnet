using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesDriverHost")]
    public class DomainDevicesInterfacesDriverHost : libvirt.Domain.IDomainDevicesInterfacesDriverHost
    {
        /// <summary>Configures whether checksum offload is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#csum Domain#csum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csum", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Csum
        {
            get;
            set;
        }

        /// <summary>Configures whether Explicit Congestion Notification (ECN) offload is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ecn Domain#ecn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ecn
        {
            get;
            set;
        }

        /// <summary>Configures whether generic segmentation offload (GSO) is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gso Domain#gso}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gso", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gso
        {
            get;
            set;
        }

        /// <summary>Configures whether mergeable receive buffers (mrg_rxbuf) are enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mrg_rx_buf Domain#mrg_rx_buf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mrgRxBuf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MrgRxBuf
        {
            get;
            set;
        }

        /// <summary>Configures whether TCP segmentation offload (TSO) for IPv4 is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tso4 Domain#tso4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tso4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tso4
        {
            get;
            set;
        }

        /// <summary>Configures whether TCP segmentation offload (TSO) for IPv6 is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tso6 Domain#tso6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tso6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tso6
        {
            get;
            set;
        }

        /// <summary>Configures whether UDP fragmentation offload (UFO) is enabled on the host side of a virtio network interface driver;</summary>
        /// <remarks>
        /// value is user-provided, typically “on/off” or “yes/no”.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options">https://libvirt.org/formatdomain.html#setting-nic-driver-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ufo Domain#ufo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ufo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ufo
        {
            get;
            set;
        }
    }
}
