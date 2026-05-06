using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbGcpIdentityConnector
{
    [JsiiInterface(nativeType: typeof(IDbmulticloudOracleDbGcpIdentityConnectorConfig), fullyQualifiedName: "oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorConfig")]
    public interface IDbmulticloudOracleDbGcpIdentityConnectorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#compartment_id DbmulticloudOracleDbGcpIdentityConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#display_name DbmulticloudOracleDbGcpIdentityConnector#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_location DbmulticloudOracleDbGcpIdentityConnector#gcp_location}.</summary>
        [JsiiProperty(name: "gcpLocation", typeJson: "{\"primitive\":\"string\"}")]
        string GcpLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_resource_service_agent_id DbmulticloudOracleDbGcpIdentityConnector#gcp_resource_service_agent_id}.</summary>
        [JsiiProperty(name: "gcpResourceServiceAgentId", typeJson: "{\"primitive\":\"string\"}")]
        string GcpResourceServiceAgentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_workload_identity_pool_id DbmulticloudOracleDbGcpIdentityConnector#gcp_workload_identity_pool_id}.</summary>
        [JsiiProperty(name: "gcpWorkloadIdentityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string GcpWorkloadIdentityPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_workload_identity_provider_id DbmulticloudOracleDbGcpIdentityConnector#gcp_workload_identity_provider_id}.</summary>
        [JsiiProperty(name: "gcpWorkloadIdentityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        string GcpWorkloadIdentityProviderId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#issuer_url DbmulticloudOracleDbGcpIdentityConnector#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        string IssuerUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#project_id DbmulticloudOracleDbGcpIdentityConnector#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#resource_id DbmulticloudOracleDbGcpIdentityConnector#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#defined_tags DbmulticloudOracleDbGcpIdentityConnector#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#freeform_tags DbmulticloudOracleDbGcpIdentityConnector#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#id DbmulticloudOracleDbGcpIdentityConnector#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#timeouts DbmulticloudOracleDbGcpIdentityConnector#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbmulticloudOracleDbGcpIdentityConnectorConfig), fullyQualifiedName: "oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#compartment_id DbmulticloudOracleDbGcpIdentityConnector#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#display_name DbmulticloudOracleDbGcpIdentityConnector#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_location DbmulticloudOracleDbGcpIdentityConnector#gcp_location}.</summary>
            [JsiiProperty(name: "gcpLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string GcpLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_resource_service_agent_id DbmulticloudOracleDbGcpIdentityConnector#gcp_resource_service_agent_id}.</summary>
            [JsiiProperty(name: "gcpResourceServiceAgentId", typeJson: "{\"primitive\":\"string\"}")]
            public string GcpResourceServiceAgentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_workload_identity_pool_id DbmulticloudOracleDbGcpIdentityConnector#gcp_workload_identity_pool_id}.</summary>
            [JsiiProperty(name: "gcpWorkloadIdentityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string GcpWorkloadIdentityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#gcp_workload_identity_provider_id DbmulticloudOracleDbGcpIdentityConnector#gcp_workload_identity_provider_id}.</summary>
            [JsiiProperty(name: "gcpWorkloadIdentityProviderId", typeJson: "{\"primitive\":\"string\"}")]
            public string GcpWorkloadIdentityProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#issuer_url DbmulticloudOracleDbGcpIdentityConnector#issuer_url}.</summary>
            [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string IssuerUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#project_id DbmulticloudOracleDbGcpIdentityConnector#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#resource_id DbmulticloudOracleDbGcpIdentityConnector#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#defined_tags DbmulticloudOracleDbGcpIdentityConnector#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#freeform_tags DbmulticloudOracleDbGcpIdentityConnector#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#id DbmulticloudOracleDbGcpIdentityConnector#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dbmulticloud_oracle_db_gcp_identity_connector#timeouts DbmulticloudOracleDbGcpIdentityConnector#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dbmulticloudOracleDbGcpIdentityConnector.DbmulticloudOracleDbGcpIdentityConnectorTimeouts\"}", isOptional: true)]
            public oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DbmulticloudOracleDbGcpIdentityConnector.IDbmulticloudOracleDbGcpIdentityConnectorTimeouts?>();
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
