using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceVds")]
    public class DomainDevicesInterfacesSourceVds : libvirt.Domain.IDomainDevicesInterfacesSourceVds
    {
        /// <summary>Sets the VMware Distributed Switch identifier to which the interface connects;</summary>
        /// <remarks>
        /// this is required and must be a user-provided VDS ID.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#switch_id Domain#switch_id}
        /// </remarks>
        [JsiiProperty(name: "switchId", typeJson: "{\"primitive\":\"string\"}")]
        public string SwitchId
        {
            get;
            set;
        }

        /// <summary>Sets the VDS connection identifier that associates the interface with a particular distributed switch connection; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#connection_id Domain#connection_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionId
        {
            get;
            set;
        }

        /// <summary>Sets the VDS port group identifier that determines which distributed port group the interface attaches to; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port_group_id Domain#port_group_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortGroupId
        {
            get;
            set;
        }

        /// <summary>Sets a specific VDS port identifier within the distributed switch to attach this interface to; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port_id Domain#port_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PortId
        {
            get;
            set;
        }
    }
}
