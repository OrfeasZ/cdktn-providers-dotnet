using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbNetworkPeeringConnection
{
    [JsiiInterface(nativeType: typeof(IOdbNetworkPeeringConnectionConfig), fullyQualifiedName: "aws.odbNetworkPeeringConnection.OdbNetworkPeeringConnectionConfig")]
    public interface IOdbNetworkPeeringConnectionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Display name of the odb network peering connection. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#display_name OdbNetworkPeeringConnection#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Required field. The unique identifier of the ODB peering connection. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#peer_network_id OdbNetworkPeeringConnection#peer_network_id}
        /// </remarks>
        [JsiiProperty(name: "peerNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string PeerNetworkId
        {
            get;
        }

        /// <summary>ARN of the odb network peering connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#odb_network_arn OdbNetworkPeeringConnection#odb_network_arn}
        /// </remarks>
        [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OdbNetworkArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Required field.</summary>
        /// <remarks>
        /// The unique identifier of the ODB network that initiates the peering connection. A sample ID is odbpcx-abcdefgh12345678. Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#odb_network_id OdbNetworkPeeringConnection#odb_network_id}
        /// </remarks>
        [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OdbNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of peered network cidrs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#peer_network_cidrs OdbNetworkPeeringConnection#peer_network_cidrs}
        /// </remarks>
        [JsiiProperty(name: "peerNetworkCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PeerNetworkCidrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#region OdbNetworkPeeringConnection#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#tags OdbNetworkPeeringConnection#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#timeouts OdbNetworkPeeringConnection#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetworkPeeringConnection.OdbNetworkPeeringConnectionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OdbNetworkPeeringConnection.IOdbNetworkPeeringConnectionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbNetworkPeeringConnectionConfig), fullyQualifiedName: "aws.odbNetworkPeeringConnection.OdbNetworkPeeringConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OdbNetworkPeeringConnection.IOdbNetworkPeeringConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Display name of the odb network peering connection. Changing this will force terraform to create new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#display_name OdbNetworkPeeringConnection#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Required field. The unique identifier of the ODB peering connection. Changing this will force terraform to create new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#peer_network_id OdbNetworkPeeringConnection#peer_network_id}
            /// </remarks>
            [JsiiProperty(name: "peerNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string PeerNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the odb network peering connection.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#odb_network_arn OdbNetworkPeeringConnection#odb_network_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OdbNetworkArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Required field.</summary>
            /// <remarks>
            /// The unique identifier of the ODB network that initiates the peering connection. A sample ID is odbpcx-abcdefgh12345678. Changing this will force terraform to create new resource.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#odb_network_id OdbNetworkPeeringConnection#odb_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OdbNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of peered network cidrs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#peer_network_cidrs OdbNetworkPeeringConnection#peer_network_cidrs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peerNetworkCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PeerNetworkCidrs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#region OdbNetworkPeeringConnection#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#tags OdbNetworkPeeringConnection#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network_peering_connection#timeouts OdbNetworkPeeringConnection#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetworkPeeringConnection.OdbNetworkPeeringConnectionTimeouts\"}", isOptional: true)]
            public aws.OdbNetworkPeeringConnection.IOdbNetworkPeeringConnectionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OdbNetworkPeeringConnection.IOdbNetworkPeeringConnectionTimeouts?>();
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
