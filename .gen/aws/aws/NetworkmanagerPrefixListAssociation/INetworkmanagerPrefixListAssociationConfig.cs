using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerPrefixListAssociation
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerPrefixListAssociationConfig), fullyQualifiedName: "aws.networkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociationConfig")]
    public interface INetworkmanagerPrefixListAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#core_network_id NetworkmanagerPrefixListAssociation#core_network_id}.</summary>
        [JsiiProperty(name: "coreNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string CoreNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#prefix_list_alias NetworkmanagerPrefixListAssociation#prefix_list_alias}.</summary>
        [JsiiProperty(name: "prefixListAlias", typeJson: "{\"primitive\":\"string\"}")]
        string PrefixListAlias
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#prefix_list_arn NetworkmanagerPrefixListAssociation#prefix_list_arn}.</summary>
        [JsiiProperty(name: "prefixListArn", typeJson: "{\"primitive\":\"string\"}")]
        string PrefixListArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerPrefixListAssociationConfig), fullyQualifiedName: "aws.networkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerPrefixListAssociation.INetworkmanagerPrefixListAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#core_network_id NetworkmanagerPrefixListAssociation#core_network_id}.</summary>
            [JsiiProperty(name: "coreNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string CoreNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#prefix_list_alias NetworkmanagerPrefixListAssociation#prefix_list_alias}.</summary>
            [JsiiProperty(name: "prefixListAlias", typeJson: "{\"primitive\":\"string\"}")]
            public string PrefixListAlias
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkmanager_prefix_list_association#prefix_list_arn NetworkmanagerPrefixListAssociation#prefix_list_arn}.</summary>
            [JsiiProperty(name: "prefixListArn", typeJson: "{\"primitive\":\"string\"}")]
            public string PrefixListArn
            {
                get => GetInstanceProperty<string>()!;
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
