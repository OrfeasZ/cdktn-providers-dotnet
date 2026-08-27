using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigration
{
    [JsiiByValue(fqn: "oci.cloudMigrationsMigration.CloudMigrationsMigrationMigrationConfig")]
    public class CloudMigrationsMigrationMigrationConfig : oci.CloudMigrationsMigration.ICloudMigrationsMigrationMigrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/cloud_migrations_migration#subnet_id CloudMigrationsMigration#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
