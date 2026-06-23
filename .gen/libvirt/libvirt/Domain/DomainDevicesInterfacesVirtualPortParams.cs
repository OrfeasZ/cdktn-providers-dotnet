using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVirtualPortParams")]
    public class DomainDevicesInterfacesVirtualPortParams : libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams
    {
        /// <summary>Enables a generic "any" virtual port profile parameter block, allowing arbitrary identification fields understood by the network backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#any Domain#any}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "any", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAny\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsAny? Any
        {
            get;
            set;
        }

        /// <summary>Enables Midonet-specific virtual port parameters for this interface;</summary>
        /// <remarks>
        /// only one virtual_port parameters block (Midonet, Open vSwitch, VEPA8021QBG, VNTag8011QBH, or Any) should be set at a time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mido_net Domain#mido_net}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "midoNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsMidoNet\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsMidoNet? MidoNet
        {
            get;
            set;
        }

        /// <summary>Enables Open vSwitch-specific virtual port parameters for this interface;</summary>
        /// <remarks>
        /// only one virtual_port parameters block (Midonet, Open vSwitch, VEPA8021QBG, VNTag8011QBH, or Any) should be set at a time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#open_v_switch Domain#open_v_switch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openVSwitch", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsOpenVSwitch\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsOpenVSwitch? OpenVSwitch
        {
            get;
            set;
        }

        /// <summary>Enables 802.1Qbg VEPA virtual port profile parameters for this interface; only one virtual_port parameters block (VEPA8021QBG, VNTag8011QBH, Midonet, Open vSwitch, or Any) should be set at a time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vepa8021qbg Domain#vepa8021qbg}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vepa8021Qbg", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021Qbg\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg? Vepa8021Qbg
        {
            get;
            set;
        }

        /// <summary>Enables 802.1Qbh VN-Tag virtual port profile parameters for this interface; only one virtual_port parameters block (VNTag8011QBH, VEPA8021QBG, Midonet, Open vSwitch, or Any) should be set at a time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vn_tag8011qbh Domain#vn_tag8011qbh}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vnTag8011Qbh", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh? VnTag8011Qbh
        {
            get;
            set;
        }
    }
}
