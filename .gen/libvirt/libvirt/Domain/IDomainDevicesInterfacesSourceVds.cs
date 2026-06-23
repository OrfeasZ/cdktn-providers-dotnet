using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceVds), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVds")]
    public interface IDomainDevicesInterfacesSourceVds
    {
        /// <summary>Sets the VMware Distributed Switch identifier to which the interface connects;</summary>
        /// <remarks>
        /// this is required and must be a user-provided VDS ID.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#switch_id Domain#switch_id}
        /// </remarks>
        [JsiiProperty(name: "switchId", typeJson: "{\"primitive\":\"string\"}")]
        string SwitchId
        {
            get;
        }

        /// <summary>Sets the VDS connection identifier that associates the interface with a particular distributed switch connection; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connection_id Domain#connection_id}
        /// </remarks>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the VDS port group identifier that determines which distributed port group the interface attaches to; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_group_id Domain#port_group_id}
        /// </remarks>
        [JsiiProperty(name: "portGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets a specific VDS port identifier within the distributed switch to attach this interface to; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_id Domain#port_id}
        /// </remarks>
        [JsiiProperty(name: "portId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PortId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceVds), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVds")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceVds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the VMware Distributed Switch identifier to which the interface connects;</summary>
            /// <remarks>
            /// this is required and must be a user-provided VDS ID.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#switch_id Domain#switch_id}
            /// </remarks>
            [JsiiProperty(name: "switchId", typeJson: "{\"primitive\":\"string\"}")]
            public string SwitchId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the VDS connection identifier that associates the interface with a particular distributed switch connection; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#connection_id Domain#connection_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the VDS port group identifier that determines which distributed port group the interface attaches to; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_group_id Domain#port_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets a specific VDS port identifier within the distributed switch to attach this interface to; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#vmware-distributed-switch">https://libvirt.org/formatdomain.html#vmware-distributed-switch</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port_id Domain#port_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PortId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
