using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts")]
    public class DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts : oci.DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement.IDatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#create DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#delete DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_externalcontainerdatabase_external_container_dbm_features_management#update DatabaseManagementExternalcontainerdatabaseExternalContainerDbmFeaturesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
