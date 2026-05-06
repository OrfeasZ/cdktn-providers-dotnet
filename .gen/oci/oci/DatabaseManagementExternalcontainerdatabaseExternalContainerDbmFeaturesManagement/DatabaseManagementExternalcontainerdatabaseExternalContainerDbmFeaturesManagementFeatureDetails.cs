using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails")]
    public class DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails : oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#feature DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#feature}.</summary>
        [JsiiProperty(name: "feature", typeJson: "{\"primitive\":\"string\"}")]
        public string Feature
        {
            get;
            set;
        }

        private object? _canEnableAllCurrentPdbs;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#can_enable_all_current_pdbs DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#can_enable_all_current_pdbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "canEnableAllCurrentPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CanEnableAllCurrentPdbs
        {
            get => _canEnableAllCurrentPdbs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _canEnableAllCurrentPdbs = value;
            }
        }

        /// <summary>connector_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#connector_details DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#connector_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectorDetails", typeJson: "{\"fqn\":\"oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsConnectorDetails\"}", isOptional: true)]
        public oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementFeatureDetailsConnectorDetails? ConnectorDetails
        {
            get;
            set;
        }

        private object? _isAutoEnablePluggableDatabase;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#is_auto_enable_pluggable_database DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#is_auto_enable_pluggable_database}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoEnablePluggableDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoEnablePluggableDatabase
        {
            get => _isAutoEnablePluggableDatabase;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoEnablePluggableDatabase = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#license_model DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#license_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }
    }
}
