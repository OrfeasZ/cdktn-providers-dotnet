using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiDatabaseInsight
{
    [JsiiInterface(nativeType: typeof(IOpsiDatabaseInsightConfig), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConfig")]
    public interface IOpsiDatabaseInsightConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#compartment_id OpsiDatabaseInsight#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#entity_source OpsiDatabaseInsight#entity_source}.</summary>
        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        string EntitySource
        {
            get;
        }

        /// <summary>connection_credential_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connection_credential_details OpsiDatabaseInsight#connection_credential_details}
        /// </remarks>
        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionCredentialDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionCredentialDetails? ConnectionCredentialDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connection_details OpsiDatabaseInsight#connection_details}
        /// </remarks>
        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionDetails? ConnectionDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connector_id OpsiDatabaseInsight#connector_id}.</summary>
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>credential_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_details OpsiDatabaseInsight#credential_details}
        /// </remarks>
        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightCredentialDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiDatabaseInsight.IOpsiDatabaseInsightCredentialDetails? CredentialDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_connection_status_details OpsiDatabaseInsight#database_connection_status_details}.</summary>
        [JsiiProperty(name: "databaseConnectionStatusDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseConnectionStatusDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_connector_id OpsiDatabaseInsight#database_connector_id}.</summary>
        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_id OpsiDatabaseInsight#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_resource_type OpsiDatabaseInsight#database_resource_type}.</summary>
        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#dbm_private_endpoint_id OpsiDatabaseInsight#dbm_private_endpoint_id}.</summary>
        [JsiiProperty(name: "dbmPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbmPrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#defined_tags OpsiDatabaseInsight#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#deployment_type OpsiDatabaseInsight#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_bridge_id OpsiDatabaseInsight#enterprise_manager_bridge_id}.</summary>
        [JsiiProperty(name: "enterpriseManagerBridgeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnterpriseManagerBridgeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_entity_identifier OpsiDatabaseInsight#enterprise_manager_entity_identifier}.</summary>
        [JsiiProperty(name: "enterpriseManagerEntityIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnterpriseManagerEntityIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_identifier OpsiDatabaseInsight#enterprise_manager_identifier}.</summary>
        [JsiiProperty(name: "enterpriseManagerIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnterpriseManagerIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#exadata_insight_id OpsiDatabaseInsight#exadata_insight_id}.</summary>
        [JsiiProperty(name: "exadataInsightId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExadataInsightId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#freeform_tags OpsiDatabaseInsight#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#id OpsiDatabaseInsight#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#is_advanced_features_enabled OpsiDatabaseInsight#is_advanced_features_enabled}.</summary>
        [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAdvancedFeaturesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#management_agent_id OpsiDatabaseInsight#management_agent_id}.</summary>
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagementAgentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#opsi_private_endpoint_id OpsiDatabaseInsight#opsi_private_endpoint_id}.</summary>
        [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpsiPrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#service_name OpsiDatabaseInsight#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#status OpsiDatabaseInsight#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#system_tags OpsiDatabaseInsight#system_tags}.</summary>
        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SystemTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#timeouts OpsiDatabaseInsight#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiDatabaseInsight.IOpsiDatabaseInsightTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiDatabaseInsightConfig), fullyQualifiedName: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#compartment_id OpsiDatabaseInsight#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#entity_source OpsiDatabaseInsight#entity_source}.</summary>
            [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
            public string EntitySource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>connection_credential_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connection_credential_details OpsiDatabaseInsight#connection_credential_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionCredentialDetails\"}", isOptional: true)]
            public oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionCredentialDetails? ConnectionCredentialDetails
            {
                get => GetInstanceProperty<oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionCredentialDetails?>();
            }

            /// <summary>connection_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connection_details OpsiDatabaseInsight#connection_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionDetails\"}", isOptional: true)]
            public oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionDetails? ConnectionDetails
            {
                get => GetInstanceProperty<oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#connector_id OpsiDatabaseInsight#connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>credential_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#credential_details OpsiDatabaseInsight#credential_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightCredentialDetails\"}", isOptional: true)]
            public oci.OpsiDatabaseInsight.IOpsiDatabaseInsightCredentialDetails? CredentialDetails
            {
                get => GetInstanceProperty<oci.OpsiDatabaseInsight.IOpsiDatabaseInsightCredentialDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_connection_status_details OpsiDatabaseInsight#database_connection_status_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseConnectionStatusDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseConnectionStatusDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_connector_id OpsiDatabaseInsight#database_connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_id OpsiDatabaseInsight#database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#database_resource_type OpsiDatabaseInsight#database_resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#dbm_private_endpoint_id OpsiDatabaseInsight#dbm_private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbmPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbmPrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#defined_tags OpsiDatabaseInsight#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#deployment_type OpsiDatabaseInsight#deployment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_bridge_id OpsiDatabaseInsight#enterprise_manager_bridge_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enterpriseManagerBridgeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnterpriseManagerBridgeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_entity_identifier OpsiDatabaseInsight#enterprise_manager_entity_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enterpriseManagerEntityIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnterpriseManagerEntityIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#enterprise_manager_identifier OpsiDatabaseInsight#enterprise_manager_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enterpriseManagerIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnterpriseManagerIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#exadata_insight_id OpsiDatabaseInsight#exadata_insight_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exadataInsightId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExadataInsightId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#freeform_tags OpsiDatabaseInsight#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#id OpsiDatabaseInsight#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#is_advanced_features_enabled OpsiDatabaseInsight#is_advanced_features_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAdvancedFeaturesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#management_agent_id OpsiDatabaseInsight#management_agent_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagementAgentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#opsi_private_endpoint_id OpsiDatabaseInsight#opsi_private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpsiPrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#service_name OpsiDatabaseInsight#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#status OpsiDatabaseInsight#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#system_tags OpsiDatabaseInsight#system_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SystemTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#timeouts OpsiDatabaseInsight#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opsiDatabaseInsight.OpsiDatabaseInsightTimeouts\"}", isOptional: true)]
            public oci.OpsiDatabaseInsight.IOpsiDatabaseInsightTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OpsiDatabaseInsight.IOpsiDatabaseInsightTimeouts?>();
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
