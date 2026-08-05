using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigrationAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsMigrationAssetReplicationLocationDetail), fullyQualifiedName: "oci.cloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetail")]
    public interface ICloudMigrationsMigrationAssetReplicationLocationDetail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration_asset#metadata CloudMigrationsMigrationAsset#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration_asset#replication_location_type CloudMigrationsMigrationAsset#replication_location_type}.</summary>
        [JsiiProperty(name: "replicationLocationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationLocationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsMigrationAssetReplicationLocationDetail), fullyQualifiedName: "oci.cloudMigrationsMigrationAsset.CloudMigrationsMigrationAssetReplicationLocationDetail")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsMigrationAsset.ICloudMigrationsMigrationAssetReplicationLocationDetail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration_asset#metadata CloudMigrationsMigrationAsset#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration_asset#replication_location_type CloudMigrationsMigrationAsset#replication_location_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationLocationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationLocationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
