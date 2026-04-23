using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerTransitGatewayRouteTableAttachment
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerTransitGatewayRouteTableAttachmentConfig), fullyQualifiedName: "aws.networkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentConfig")]
    public interface INetworkmanagerTransitGatewayRouteTableAttachmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#peering_id NetworkmanagerTransitGatewayRouteTableAttachment#peering_id}.</summary>
        [JsiiProperty(name: "peeringId", typeJson: "{\"primitive\":\"string\"}")]
        string PeeringId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#transit_gateway_route_table_arn NetworkmanagerTransitGatewayRouteTableAttachment#transit_gateway_route_table_arn}.</summary>
        [JsiiProperty(name: "transitGatewayRouteTableArn", typeJson: "{\"primitive\":\"string\"}")]
        string TransitGatewayRouteTableArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#id NetworkmanagerTransitGatewayRouteTableAttachment#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#routing_policy_label NetworkmanagerTransitGatewayRouteTableAttachment#routing_policy_label}.</summary>
        [JsiiProperty(name: "routingPolicyLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingPolicyLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags NetworkmanagerTransitGatewayRouteTableAttachment#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags_all NetworkmanagerTransitGatewayRouteTableAttachment#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#timeouts NetworkmanagerTransitGatewayRouteTableAttachment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.networkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkmanagerTransitGatewayRouteTableAttachment.INetworkmanagerTransitGatewayRouteTableAttachmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerTransitGatewayRouteTableAttachmentConfig), fullyQualifiedName: "aws.networkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerTransitGatewayRouteTableAttachment.INetworkmanagerTransitGatewayRouteTableAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#peering_id NetworkmanagerTransitGatewayRouteTableAttachment#peering_id}.</summary>
            [JsiiProperty(name: "peeringId", typeJson: "{\"primitive\":\"string\"}")]
            public string PeeringId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#transit_gateway_route_table_arn NetworkmanagerTransitGatewayRouteTableAttachment#transit_gateway_route_table_arn}.</summary>
            [JsiiProperty(name: "transitGatewayRouteTableArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitGatewayRouteTableArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#id NetworkmanagerTransitGatewayRouteTableAttachment#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#routing_policy_label NetworkmanagerTransitGatewayRouteTableAttachment#routing_policy_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingPolicyLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingPolicyLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags NetworkmanagerTransitGatewayRouteTableAttachment#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#tags_all NetworkmanagerTransitGatewayRouteTableAttachment#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_transit_gateway_route_table_attachment#timeouts NetworkmanagerTransitGatewayRouteTableAttachment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.networkmanagerTransitGatewayRouteTableAttachment.NetworkmanagerTransitGatewayRouteTableAttachmentTimeouts\"}", isOptional: true)]
            public aws.NetworkmanagerTransitGatewayRouteTableAttachment.INetworkmanagerTransitGatewayRouteTableAttachmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.NetworkmanagerTransitGatewayRouteTableAttachment.INetworkmanagerTransitGatewayRouteTableAttachmentTimeouts?>();
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
