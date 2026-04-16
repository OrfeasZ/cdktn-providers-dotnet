using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnConnection
{
    [JsiiInterface(nativeType: typeof(IS2SVpnConnectionConfig), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionConfig")]
    public interface IS2SVpnConnectionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>bgp_config_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#bgp_config_ipv4 S2SVpnConnection#bgp_config_ipv4}
        /// </remarks>
        [JsiiProperty(name: "bgpConfigIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BgpConfigIpv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>bgp_config_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#bgp_config_ipv6 S2SVpnConnection#bgp_config_ipv6}
        /// </remarks>
        [JsiiProperty(name: "bgpConfigIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BgpConfigIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the customer gateway to attach to the connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#customer_gateway_id S2SVpnConnection#customer_gateway_id}
        /// </remarks>
        [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether route propagation is enabled or not.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#enable_route_propagation S2SVpnConnection#enable_route_propagation}
        /// </remarks>
        [JsiiProperty(name: "enableRoutePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableRoutePropagation
        {
            get
            {
                return null;
            }
        }

        /// <summary>esp_ciphers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#esp_ciphers S2SVpnConnection#esp_ciphers}
        /// </remarks>
        [JsiiProperty(name: "espCiphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionEspCiphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EspCiphers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#id S2SVpnConnection#id}.</summary>
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

        /// <summary>ikev2_ciphers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#ikev2_ciphers S2SVpnConnection#ikev2_ciphers}
        /// </remarks>
        [JsiiProperty(name: "ikev2Ciphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionIkev2Ciphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ikev2Ciphers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines who initiates the IPsec tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#initiation_policy S2SVpnConnection#initiation_policy}
        /// </remarks>
        [JsiiProperty(name: "initiationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitiationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines IP version of the IPSec Tunnel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#is_ipv6 S2SVpnConnection#is_ipv6}
        /// </remarks>
        [JsiiProperty(name: "isIpv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#name S2SVpnConnection#name}
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

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#project_id S2SVpnConnection#project_id}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#region S2SVpnConnection#region}
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

        /// <summary>The list of tags to apply to the connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#tags S2SVpnConnection#tags}
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

        /// <summary>The ID of the VPN gateway to attach to the connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#vpn_gateway_id S2SVpnConnection#vpn_gateway_id}
        /// </remarks>
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpnGatewayId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS2SVpnConnectionConfig), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.S2SVpnConnection.IS2SVpnConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bgp_config_ipv4 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#bgp_config_ipv4 S2SVpnConnection#bgp_config_ipv4}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bgpConfigIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BgpConfigIpv4
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>bgp_config_ipv6 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#bgp_config_ipv6 S2SVpnConnection#bgp_config_ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bgpConfigIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionBgpConfigIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BgpConfigIpv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the customer gateway to attach to the connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#customer_gateway_id S2SVpnConnection#customer_gateway_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether route propagation is enabled or not.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#enable_route_propagation S2SVpnConnection#enable_route_propagation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableRoutePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableRoutePropagation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>esp_ciphers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#esp_ciphers S2SVpnConnection#esp_ciphers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "espCiphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionEspCiphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EspCiphers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#id S2SVpnConnection#id}.</summary>
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

            /// <summary>ikev2_ciphers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#ikev2_ciphers S2SVpnConnection#ikev2_ciphers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ikev2Ciphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.s2SVpnConnection.S2SVpnConnectionIkev2Ciphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ikev2Ciphers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines who initiates the IPsec tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#initiation_policy S2SVpnConnection#initiation_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initiationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitiationPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines IP version of the IPSec Tunnel.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#is_ipv6 S2SVpnConnection#is_ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isIpv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIpv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The name of the connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#name S2SVpnConnection#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#project_id S2SVpnConnection#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#region S2SVpnConnection#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of tags to apply to the connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#tags S2SVpnConnection#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The ID of the VPN gateway to attach to the connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#vpn_gateway_id S2SVpnConnection#vpn_gateway_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpnGatewayId
            {
                get => GetInstanceProperty<string?>();
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
