using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiByValue(fqn: "oci.databaseDbSystem.DatabaseDbSystemDbSystemOptions")]
    public class DatabaseDbSystemDbSystemOptions : oci.DatabaseDbSystem.IDatabaseDbSystemDbSystemOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#storage_management DatabaseDbSystem#storage_management}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageManagement
        {
            get;
            set;
        }
    }
}
