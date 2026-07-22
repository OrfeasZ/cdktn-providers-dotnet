using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationAsset
{
    [JsiiByValue(fqn: "oci.cloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetail")]
    public class CloudMigrationsMigrationAssetReplicationLocationDetail : oci.CloudMigrationsMigrationAsset.ICloudMigrationsMigrationAssetReplicationLocationDetail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_migrations_migration_asset#metadata CloudMigrationsMigrationAsset#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/cloud_migrations_migration_asset#replication_location_type CloudMigrationsMigrationAsset#replication_location_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationLocationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationLocationType
        {
            get;
            set;
        }
    }
}
