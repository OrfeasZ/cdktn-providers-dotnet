using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InterlinkLink
{
    [JsiiInterface(nativeType: typeof(IInterlinkLinkConfig), fullyQualifiedName: "scaleway.interlinkLink.InterlinkLinkConfig")]
    public interface IInterlinkLinkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Desired bandwidth for the link. Must be compatible with available link bandwidths and remaining bandwidth capacity of the connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#bandwidth_mbps InterlinkLink#bandwidth_mbps}
        /// </remarks>
        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        double BandwidthMbps
        {
            get;
        }

        /// <summary>PoP (location) where the link will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#pop_id InterlinkLink#pop_id}
        /// </remarks>
        [JsiiProperty(name: "popId", typeJson: "{\"primitive\":\"string\"}")]
        string PopId
        {
            get;
        }

        /// <summary>If set, creates a self-hosted link using this dedicated physical connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#connection_id InterlinkLink#connection_id}
        /// </remarks>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#id InterlinkLink#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#name InterlinkLink#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, creates a hosted link on a partner's connection.</summary>
        /// <remarks>
        /// Specify the ID of the chosen partner, who already has a shared connection with available bandwidth
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#partner_id InterlinkLink#partner_id}
        /// </remarks>
        [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>For self-hosted links, the peer AS Number to establish BGP session.</summary>
        /// <remarks>
        /// If not given, a default one will be assigned
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#peer_asn InterlinkLink#peer_asn}
        /// </remarks>
        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeerAsn
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#project_id InterlinkLink#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#region InterlinkLink#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, attaches this routing policy containing IPv4 prefixes to the link. A BGP IPv4 session will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#routing_policy_v4_id InterlinkLink#routing_policy_v4_id}
        /// </remarks>
        [JsiiProperty(name: "routingPolicyV4Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingPolicyV4Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, attaches this routing policy containing IPv6 prefixes to the link. A BGP IPv6 session will be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#routing_policy_v6_id InterlinkLink#routing_policy_v6_id}
        /// </remarks>
        [JsiiProperty(name: "routingPolicyV6Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingPolicyV6Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags associated with the link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#tags InterlinkLink#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#timeouts InterlinkLink#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.InterlinkLink.IInterlinkLinkTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>For self-hosted links only, the VLAN ID.</summary>
        /// <remarks>
        /// If the VLAN is not available (already taken or out of range), an error is returned
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#vlan InterlinkLink#vlan}
        /// </remarks>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vlan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInterlinkLinkConfig), fullyQualifiedName: "scaleway.interlinkLink.InterlinkLinkConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.InterlinkLink.IInterlinkLinkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Desired bandwidth for the link. Must be compatible with available link bandwidths and remaining bandwidth capacity of the connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#bandwidth_mbps InterlinkLink#bandwidth_mbps}
            /// </remarks>
            [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
            public double BandwidthMbps
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>PoP (location) where the link will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#pop_id InterlinkLink#pop_id}
            /// </remarks>
            [JsiiProperty(name: "popId", typeJson: "{\"primitive\":\"string\"}")]
            public string PopId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If set, creates a self-hosted link using this dedicated physical connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#connection_id InterlinkLink#connection_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#id InterlinkLink#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the link.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#name InterlinkLink#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, creates a hosted link on a partner's connection.</summary>
            /// <remarks>
            /// Specify the ID of the chosen partner, who already has a shared connection with available bandwidth
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#partner_id InterlinkLink#partner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For self-hosted links, the peer AS Number to establish BGP session.</summary>
            /// <remarks>
            /// If not given, a default one will be assigned
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#peer_asn InterlinkLink#peer_asn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PeerAsn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#project_id InterlinkLink#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#region InterlinkLink#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, attaches this routing policy containing IPv4 prefixes to the link. A BGP IPv4 session will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#routing_policy_v4_id InterlinkLink#routing_policy_v4_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingPolicyV4Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingPolicyV4Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, attaches this routing policy containing IPv6 prefixes to the link. A BGP IPv6 session will be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#routing_policy_v6_id InterlinkLink#routing_policy_v6_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingPolicyV6Id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingPolicyV6Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of tags associated with the link.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#tags InterlinkLink#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#timeouts InterlinkLink#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.interlinkLink.InterlinkLinkTimeouts\"}", isOptional: true)]
            public scaleway.InterlinkLink.IInterlinkLinkTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.InterlinkLink.IInterlinkLinkTimeouts?>();
            }

            /// <summary>For self-hosted links only, the VLAN ID.</summary>
            /// <remarks>
            /// If the VLAN is not available (already taken or out of range), an error is returned
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/interlink_link#vlan InterlinkLink#vlan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vlan
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
