using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021Qbg")]
    public interface IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg
    {
        /// <summary>Sets the 802.1Qbg instance identifier for this VEPA virtual port, typically a UUID or other unique ID required by the edge switch.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#instance_id Domain#instance_id}
        /// </remarks>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the 802.1Qbg manager identifier for this VEPA virtual port, usually a numeric ID designating the managing entity on the switch.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#manager_id Domain#manager_id}
        /// </remarks>
        [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ManagerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the 802.1Qbg type identifier used by the VEPA manager to classify the virtual port profile; the value is user-provided and must match the switch configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type_id Domain#type_id}
        /// </remarks>
        [JsiiProperty(name: "typeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TypeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the version of the 802.1Qbg profile type for this VEPA virtual port; the value is user-provided (for example, "1").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type_id_version Domain#type_id_version}
        /// </remarks>
        [JsiiProperty(name: "typeIdVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TypeIdVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVepa8021Qbg")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVepa8021Qbg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the 802.1Qbg instance identifier for this VEPA virtual port, typically a UUID or other unique ID required by the edge switch.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#instance_id Domain#instance_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the 802.1Qbg manager identifier for this VEPA virtual port, usually a numeric ID designating the managing entity on the switch.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#manager_id Domain#manager_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ManagerId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the 802.1Qbg type identifier used by the VEPA manager to classify the virtual port profile; the value is user-provided and must match the switch configuration.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type_id Domain#type_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TypeId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the version of the 802.1Qbg profile type for this VEPA virtual port; the value is user-provided (for example, "1").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type_id_version Domain#type_id_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeIdVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TypeIdVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
