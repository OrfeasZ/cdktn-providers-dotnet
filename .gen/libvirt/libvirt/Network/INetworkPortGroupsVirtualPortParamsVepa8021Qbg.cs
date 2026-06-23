using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroupsVirtualPortParamsVepa8021Qbg), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsVepa8021Qbg")]
    public interface INetworkPortGroupsVirtualPortParamsVepa8021Qbg
    {
        /// <summary>Sets the 802.1Qbg VEPA instance identifier (instanceid) for this port profile; value is user-provided and usually a unique identifier (often UUID-like) assigned by the EVB manager.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#instance_id Network#instance_id}
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

        /// <summary>Sets the 802.1Qbg VEPA manager identifier (managerid) that identifies the external EVB manager controlling this profile; value is user-provided numeric or string ID.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#manager_id Network#manager_id}
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

        /// <summary>Sets the 802.1Qbg VEPA type identifier (typeid) indicating what kind of profile is referenced; value is user-provided and must match the EVB manager’s expectations.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#type_id Network#type_id}
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

        /// <summary>Sets the 802.1Qbg VEPA type identifier version (typeidversion) for this profile; value is user-provided and typically a small integer version understood by the EVB manager.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#type_id_version Network#type_id_version}
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

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroupsVirtualPortParamsVepa8021Qbg), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsVepa8021Qbg")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroupsVirtualPortParamsVepa8021Qbg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the 802.1Qbg VEPA instance identifier (instanceid) for this port profile; value is user-provided and usually a unique identifier (often UUID-like) assigned by the EVB manager.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#instance_id Network#instance_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the 802.1Qbg VEPA manager identifier (managerid) that identifies the external EVB manager controlling this profile; value is user-provided numeric or string ID.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#manager_id Network#manager_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ManagerId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the 802.1Qbg VEPA type identifier (typeid) indicating what kind of profile is referenced; value is user-provided and must match the EVB manager’s expectations.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#type_id Network#type_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TypeId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the 802.1Qbg VEPA type identifier version (typeidversion) for this profile; value is user-provided and typically a small integer version understood by the EVB manager.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface">https://libvirt.org/formatdomain.html#direct-attachment-to-physical-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#type_id_version Network#type_id_version}
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
