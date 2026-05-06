using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiExadataInsight
{
    [JsiiInterface(nativeType: typeof(IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails), fullyQualifiedName: "oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails")]
    public interface IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#compartment_id OpsiExadataInsight#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_credential_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#connection_credential_details OpsiExadataInsight#connection_credential_details}
        /// </remarks>
        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionCredentialDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionCredentialDetails? ConnectionCredentialDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#connection_details OpsiExadataInsight#connection_details}
        /// </remarks>
        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionDetails? ConnectionDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>credential_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#credential_details OpsiExadataInsight#credential_details}
        /// </remarks>
        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsCredentialDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsCredentialDetails? CredentialDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#database_id OpsiExadataInsight#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#database_resource_type OpsiExadataInsight#database_resource_type}.</summary>
        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#defined_tags OpsiExadataInsight#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#deployment_type OpsiExadataInsight#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#entity_source OpsiExadataInsight#entity_source}.</summary>
        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntitySource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#freeform_tags OpsiExadataInsight#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#is_advanced_features_enabled OpsiExadataInsight#is_advanced_features_enabled}.</summary>
        [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAdvancedFeaturesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#management_agent_id OpsiExadataInsight#management_agent_id}.</summary>
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagementAgentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#opsi_private_endpoint_id OpsiExadataInsight#opsi_private_endpoint_id}.</summary>
        [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpsiPrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#system_tags OpsiExadataInsight#system_tags}.</summary>
        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SystemTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails), fullyQualifiedName: "oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#compartment_id OpsiExadataInsight#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_credential_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#connection_credential_details OpsiExadataInsight#connection_credential_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionCredentialDetails\"}", isOptional: true)]
            public oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionCredentialDetails? ConnectionCredentialDetails
            {
                get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionCredentialDetails?>();
            }

            /// <summary>connection_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#connection_details OpsiExadataInsight#connection_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionDetails\"}", isOptional: true)]
            public oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionDetails? ConnectionDetails
            {
                get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsConnectionDetails?>();
            }

            /// <summary>credential_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#credential_details OpsiExadataInsight#credential_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.opsiExadataInsight.OpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsCredentialDetails\"}", isOptional: true)]
            public oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsCredentialDetails? CredentialDetails
            {
                get => GetInstanceProperty<oci.OpsiExadataInsight.IOpsiExadataInsightMemberVmClusterDetailsMemberAutonomousDetailsCredentialDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#database_id OpsiExadataInsight#database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#database_resource_type OpsiExadataInsight#database_resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#defined_tags OpsiExadataInsight#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#deployment_type OpsiExadataInsight#deployment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#entity_source OpsiExadataInsight#entity_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntitySource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#freeform_tags OpsiExadataInsight#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#is_advanced_features_enabled OpsiExadataInsight#is_advanced_features_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAdvancedFeaturesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#management_agent_id OpsiExadataInsight#management_agent_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagementAgentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#opsi_private_endpoint_id OpsiExadataInsight#opsi_private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpsiPrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_exadata_insight#system_tags OpsiExadataInsight#system_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SystemTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
