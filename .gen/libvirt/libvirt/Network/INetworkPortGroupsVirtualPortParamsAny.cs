using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkPortGroupsVirtualPortParamsAny), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsAny")]
    public interface INetworkPortGroupsVirtualPortParamsAny
    {
        /// <summary>Sets the instance identifier for the generic port profile, typically a UUID string unique per attached interface instance.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#instance_id Network#instance_id}
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

        /// <summary>Sets the interface identifier for the generic port profile, usually a stable ID used by the external switch to identify the virtual NIC.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
        /// </remarks>
        [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the manager identifier for the generic port profile, typically a numeric or string ID identifying the external network management system.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#manager_id Network#manager_id}
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

        /// <summary>Sets the profile identifier for the generic port profile, referencing a logical port profile defined in the external network manager.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#profile_id Network#profile_id}
        /// </remarks>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the type identifier for the generic port profile, defining the semantic type of the profile as expected by the external switch;</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#type_id Network#type_id}
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

        /// <summary>Sets the version of the type identifier for the generic port profile, allowing the external manager to distinguish revisions;</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#type_id_version Network#type_id_version}
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

        [JsiiTypeProxy(nativeType: typeof(INetworkPortGroupsVirtualPortParamsAny), fullyQualifiedName: "libvirt.network.NetworkPortGroupsVirtualPortParamsAny")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkPortGroupsVirtualPortParamsAny
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the instance identifier for the generic port profile, typically a UUID string unique per attached interface instance.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#instance_id Network#instance_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the interface identifier for the generic port profile, usually a stable ID used by the external switch to identify the virtual NIC.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#interface_id Network#interface_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the manager identifier for the generic port profile, typically a numeric or string ID identifying the external network management system.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#manager_id Network#manager_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ManagerId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the profile identifier for the generic port profile, referencing a logical port profile defined in the external network manager.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#profile_id Network#profile_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the type identifier for the generic port profile, defining the semantic type of the profile as expected by the external switch;</summary>
            /// <remarks>
            /// value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#type_id Network#type_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "typeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TypeId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the version of the type identifier for the generic port profile, allowing the external manager to distinguish revisions;</summary>
            /// <remarks>
            /// value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatnetwork.html#connectivity">https://libvirt.org/formatnetwork.html#connectivity</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/network#type_id_version Network#type_id_version}
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
