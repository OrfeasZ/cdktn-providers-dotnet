using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseManagementExternalDbSystem.DatabaseManagementExternalDbSystemDatabaseManagementConfig")]
    public class DatabaseManagementExternalDbSystemDatabaseManagementConfig : oci.DatabaseManagementExternalDbSystem.IDatabaseManagementExternalDbSystemDatabaseManagementConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#license_model DatabaseManagementExternalDbSystem#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public string LicenseModel
        {
            get;
            set;
        }
    }
}
