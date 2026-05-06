using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAzureConnector
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbAzureConnectorConfig), fullyQualifiedName: "oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorConfig")]
    public interface IDbmulticloudOracleDbAzureConnectorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#access_token DbmulticloudOracleDbAzureConnector#access_token}.</summary>
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        string AccessToken
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_identity_mechanism DbmulticloudOracleDbAzureConnector#azure_identity_mechanism}.</summary>
        [JsiiProperty(name: "azureIdentityMechanism", typeJson: "{\"primitive\":\"string\"}")]
        string AzureIdentityMechanism
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_resource_group DbmulticloudOracleDbAzureConnector#azure_resource_group}.</summary>
        [JsiiProperty(name: "azureResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        string AzureResourceGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_subscription_id DbmulticloudOracleDbAzureConnector#azure_subscription_id}.</summary>
        [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string AzureSubscriptionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_tenant_id DbmulticloudOracleDbAzureConnector#azure_tenant_id}.</summary>
        [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}")]
        string AzureTenantId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#compartment_id DbmulticloudOracleDbAzureConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#db_cluster_resource_id DbmulticloudOracleDbAzureConnector#db_cluster_resource_id}.</summary>
        [JsiiProperty(name: "dbClusterResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string DbClusterResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#display_name DbmulticloudOracleDbAzureConnector#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>arc_agent_nodes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#arc_agent_nodes DbmulticloudOracleDbAzureConnector#arc_agent_nodes}
        /// </remarks>
        [JsiiProperty(name: "arcAgentNodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorArcAgentNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArcAgentNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#id DbmulticloudOracleDbAzureConnector#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#last_modification DbmulticloudOracleDbAzureConnector#last_modification}.</summary>
        [JsiiProperty(name: "lastModification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastModification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#lifecycle_state_details DbmulticloudOracleDbAzureConnector#lifecycle_state_details}.</summary>
        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LifecycleStateDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#timeouts DbmulticloudOracleDbAzureConnector#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbAzureConnectorConfig), fullyQualifiedName: "oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#access_token DbmulticloudOracleDbAzureConnector#access_token}.</summary>
            [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessToken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_identity_mechanism DbmulticloudOracleDbAzureConnector#azure_identity_mechanism}.</summary>
            [JsiiProperty(name: "azureIdentityMechanism", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureIdentityMechanism
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_resource_group DbmulticloudOracleDbAzureConnector#azure_resource_group}.</summary>
            [JsiiProperty(name: "azureResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureResourceGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_subscription_id DbmulticloudOracleDbAzureConnector#azure_subscription_id}.</summary>
            [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureSubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#azure_tenant_id DbmulticloudOracleDbAzureConnector#azure_tenant_id}.</summary>
            [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureTenantId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#compartment_id DbmulticloudOracleDbAzureConnector#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#db_cluster_resource_id DbmulticloudOracleDbAzureConnector#db_cluster_resource_id}.</summary>
            [JsiiProperty(name: "dbClusterResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string DbClusterResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#display_name DbmulticloudOracleDbAzureConnector#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>arc_agent_nodes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#arc_agent_nodes DbmulticloudOracleDbAzureConnector#arc_agent_nodes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "arcAgentNodes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorArcAgentNodes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArcAgentNodes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#id DbmulticloudOracleDbAzureConnector#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#last_modification DbmulticloudOracleDbAzureConnector#last_modification}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastModification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastModification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#lifecycle_state_details DbmulticloudOracleDbAzureConnector#lifecycle_state_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LifecycleStateDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_azure_connector#timeouts DbmulticloudOracleDbAzureConnector#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dbmulticloudOracleDbAzureConnector.DbmulticloudOracleDbAzureConnectorTimeouts\"}", isOptional: true)]
            public oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DbmulticloudOracleDbAzureConnector.IDbmulticloudOracleDbAzureConnectorTimeouts?>();
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
