using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsAny), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAny")]
    public interface IDomainDevicesInterfacesVirtualPortParamsAny
    {
        /// <summary>Sets an opaque instance identifier for the virtual port profile, used by some network platforms to uniquely track the interface;</summary>
        /// <remarks>
        /// value is user-provided (often a UUID-like string).
        ///
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

        /// <summary>Sets an opaque interface identifier for the virtual port profile, typically used by SDN or virtual switch controllers;</summary>
        /// <remarks>
        /// value is user-provided (often a UUID or similar).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface_id Domain#interface_id}
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

        /// <summary>Sets an opaque manager identifier for the virtual port profile, identifying the controlling network manager or switch domain;</summary>
        /// <remarks>
        /// value is user-provided integer or string as expected by the backend.
        ///
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

        /// <summary>Sets the opaque profile identifier passed to a generic 802.1Qbh/any virtual port profile; the value is user-provided and interpreted by the underlying switch or SDN controller (for example, "profile-1").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#profile_id Domain#profile_id}
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

        /// <summary>Sets the 802.1Qbh profile type identifier for a generic virtual port profile; the value is user-provided (typically a numeric or UUID-like identifier defined by the switch implementation).</summary>
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

        /// <summary>Sets the version of the 802.1Qbh profile type for a generic virtual port profile; the value is user-provided and must match what the upstream switch expects (for example, "1").</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsAny), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsAny")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsAny
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets an opaque instance identifier for the virtual port profile, used by some network platforms to uniquely track the interface;</summary>
            /// <remarks>
            /// value is user-provided (often a UUID-like string).
            ///
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

            /// <summary>Sets an opaque interface identifier for the virtual port profile, typically used by SDN or virtual switch controllers;</summary>
            /// <remarks>
            /// value is user-provided (often a UUID or similar).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#interface_id Domain#interface_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an opaque manager identifier for the virtual port profile, identifying the controlling network manager or switch domain;</summary>
            /// <remarks>
            /// value is user-provided integer or string as expected by the backend.
            ///
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

            /// <summary>Sets the opaque profile identifier passed to a generic 802.1Qbh/any virtual port profile; the value is user-provided and interpreted by the underlying switch or SDN controller (for example, "profile-1").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#profile_id Domain#profile_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the 802.1Qbh profile type identifier for a generic virtual port profile; the value is user-provided (typically a numeric or UUID-like identifier defined by the switch implementation).</summary>
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

            /// <summary>Sets the version of the 802.1Qbh profile type for a generic virtual port profile; the value is user-provided and must match what the upstream switch expects (for example, "1").</summary>
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
