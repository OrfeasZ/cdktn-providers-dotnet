using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerTransitGatewayConnectPeerAssociation
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerTransitGatewayConnectPeerAssociationConfig), fullyQualifiedName: "aws.networkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationConfig")]
    public interface INetworkmanagerTransitGatewayConnectPeerAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#device_id NetworkmanagerTransitGatewayConnectPeerAssociation#device_id}.</summary>
        [JsiiProperty(name: "deviceId", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#global_network_id NetworkmanagerTransitGatewayConnectPeerAssociation#global_network_id}.</summary>
        [JsiiProperty(name: "globalNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string GlobalNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#transit_gateway_connect_peer_arn NetworkmanagerTransitGatewayConnectPeerAssociation#transit_gateway_connect_peer_arn}.</summary>
        [JsiiProperty(name: "transitGatewayConnectPeerArn", typeJson: "{\"primitive\":\"string\"}")]
        string TransitGatewayConnectPeerArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#id NetworkmanagerTransitGatewayConnectPeerAssociation#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#link_id NetworkmanagerTransitGatewayConnectPeerAssociation#link_id}.</summary>
        [JsiiProperty(name: "linkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LinkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#timeouts NetworkmanagerTransitGatewayConnectPeerAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.networkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkmanagerTransitGatewayConnectPeerAssociation.INetworkmanagerTransitGatewayConnectPeerAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerTransitGatewayConnectPeerAssociationConfig), fullyQualifiedName: "aws.networkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerTransitGatewayConnectPeerAssociation.INetworkmanagerTransitGatewayConnectPeerAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#device_id NetworkmanagerTransitGatewayConnectPeerAssociation#device_id}.</summary>
            [JsiiProperty(name: "deviceId", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#global_network_id NetworkmanagerTransitGatewayConnectPeerAssociation#global_network_id}.</summary>
            [JsiiProperty(name: "globalNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string GlobalNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#transit_gateway_connect_peer_arn NetworkmanagerTransitGatewayConnectPeerAssociation#transit_gateway_connect_peer_arn}.</summary>
            [JsiiProperty(name: "transitGatewayConnectPeerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitGatewayConnectPeerArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#id NetworkmanagerTransitGatewayConnectPeerAssociation#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#link_id NetworkmanagerTransitGatewayConnectPeerAssociation#link_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LinkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_transit_gateway_connect_peer_association#timeouts NetworkmanagerTransitGatewayConnectPeerAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.networkmanagerTransitGatewayConnectPeerAssociation.NetworkmanagerTransitGatewayConnectPeerAssociationTimeouts\"}", isOptional: true)]
            public aws.NetworkmanagerTransitGatewayConnectPeerAssociation.INetworkmanagerTransitGatewayConnectPeerAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.NetworkmanagerTransitGatewayConnectPeerAssociation.INetworkmanagerTransitGatewayConnectPeerAssociationTimeouts?>();
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
