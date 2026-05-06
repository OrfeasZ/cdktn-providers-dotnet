using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts")]
    public class DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts : oci.DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement.IDatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#create DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#delete DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalnoncontainerdatabase_external_non_container_dbm_features_management#update DatabaseManagementExternalnoncontainerdatabaseExternalNonContainerDbmFeaturesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
