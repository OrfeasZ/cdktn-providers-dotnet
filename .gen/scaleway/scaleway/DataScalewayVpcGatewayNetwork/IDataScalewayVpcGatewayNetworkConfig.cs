using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayVpcGatewayNetwork
{
    [JsiiInterface(nativeType: typeof(IDataScalewayVpcGatewayNetworkConfig), fullyQualifiedName: "scaleway.dataScalewayVpcGatewayNetwork.DataScalewayVpcGatewayNetworkConfig")]
    public interface IDataScalewayVpcGatewayNetworkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the public gateway DHCP config.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#dhcp_id DataScalewayVpcGatewayNetwork#dhcp_id}
        /// </remarks>
        [JsiiProperty(name: "dhcpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DhcpId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable masquerade on this network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#enable_masquerade DataScalewayVpcGatewayNetwork#enable_masquerade}
        /// </remarks>
        [JsiiProperty(name: "enableMasquerade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMasquerade
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the public gateway where connect to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#gateway_id DataScalewayVpcGatewayNetwork#gateway_id}
        /// </remarks>
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the gateway network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#gateway_network_id DataScalewayVpcGatewayNetwork#gateway_network_id}
        /// </remarks>
        [JsiiProperty(name: "gatewayNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#id DataScalewayVpcGatewayNetwork#id}.</summary>
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

        /// <summary>The ID of the private network where connect to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#private_network_id DataScalewayVpcGatewayNetwork#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateNetworkId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayVpcGatewayNetworkConfig), fullyQualifiedName: "scaleway.dataScalewayVpcGatewayNetwork.DataScalewayVpcGatewayNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayVpcGatewayNetwork.IDataScalewayVpcGatewayNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the public gateway DHCP config.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#dhcp_id DataScalewayVpcGatewayNetwork#dhcp_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DhcpId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable masquerade on this network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#enable_masquerade DataScalewayVpcGatewayNetwork#enable_masquerade}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableMasquerade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMasquerade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the public gateway where connect to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#gateway_id DataScalewayVpcGatewayNetwork#gateway_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the gateway network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#gateway_network_id DataScalewayVpcGatewayNetwork#gateway_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#id DataScalewayVpcGatewayNetwork#id}.</summary>
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

            /// <summary>The ID of the private network where connect to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/vpc_gateway_network#private_network_id DataScalewayVpcGatewayNetwork#private_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateNetworkId
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
