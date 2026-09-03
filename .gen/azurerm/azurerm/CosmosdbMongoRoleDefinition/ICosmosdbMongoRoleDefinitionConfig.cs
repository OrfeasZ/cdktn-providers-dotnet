using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbMongoRoleDefinition
{
    [JsiiInterface(nativeType: typeof(ICosmosdbMongoRoleDefinitionConfig), fullyQualifiedName: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionConfig")]
    public interface ICosmosdbMongoRoleDefinitionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#cosmos_mongo_database_id CosmosdbMongoRoleDefinition#cosmos_mongo_database_id}.</summary>
        [JsiiProperty(name: "cosmosMongoDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string CosmosMongoDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#role_name CosmosdbMongoRoleDefinition#role_name}.</summary>
        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        string RoleName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#id CosmosdbMongoRoleDefinition#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#inherited_role_names CosmosdbMongoRoleDefinition#inherited_role_names}.</summary>
        [JsiiProperty(name: "inheritedRoleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InheritedRoleNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>privilege block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#privilege CosmosdbMongoRoleDefinition#privilege}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilege" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privilege", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Privilege
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#timeouts CosmosdbMongoRoleDefinition#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbMongoRoleDefinitionConfig), fullyQualifiedName: "azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#cosmos_mongo_database_id CosmosdbMongoRoleDefinition#cosmos_mongo_database_id}.</summary>
            [JsiiProperty(name: "cosmosMongoDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string CosmosMongoDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#role_name CosmosdbMongoRoleDefinition#role_name}.</summary>
            [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#id CosmosdbMongoRoleDefinition#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#inherited_role_names CosmosdbMongoRoleDefinition#inherited_role_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inheritedRoleNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InheritedRoleNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>privilege block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#privilege CosmosdbMongoRoleDefinition#privilege}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionPrivilege" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privilege", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Privilege
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_mongo_role_definition#timeouts CosmosdbMongoRoleDefinition#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionTimeouts\"}", isOptional: true)]
            public azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.CosmosdbMongoRoleDefinition.ICosmosdbMongoRoleDefinitionTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
