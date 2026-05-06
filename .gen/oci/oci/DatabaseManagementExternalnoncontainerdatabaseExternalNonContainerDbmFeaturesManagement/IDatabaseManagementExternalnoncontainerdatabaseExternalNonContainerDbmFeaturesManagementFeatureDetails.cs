using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails")]
    public interface IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#feature DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        string Feature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#can_enable_all_current_pdbs DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#can_enable_all_current_pdbs}.</summary>
        [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CanEnableAllCurrentPdbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#connector_details DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#connector_details}
        /// </remarks>
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#is_auto_enable_pluggable_database DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#is_auto_enable_pluggable_database}.</summary>
        [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoEnablePluggableDatabase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#license_model DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseModel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails), fullyQualifiedName: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#feature DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#feature}.</summary>
            [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
            public string Feature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#can_enable_all_current_pdbs DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#can_enable_all_current_pdbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanEnableAllCurrentPdbs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>connector_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#connector_details DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#connector_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
            public oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementFeatureDetailsConnectorDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#is_auto_enable_pluggable_database DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#is_auto_enable_pluggable_database}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoEnablePluggableDatabase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#license_model DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#license_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseModel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
