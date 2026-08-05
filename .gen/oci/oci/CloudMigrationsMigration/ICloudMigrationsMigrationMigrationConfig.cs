using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsMigration
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsMigrationMigrationConfig), fullyQualifiedName: "oci.cloudMigrationsMigration.CloudMigrationsMigrationMigrationConfig")]
    public interface ICloudMigrationsMigrationMigrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration#subnet_id CloudMigrationsMigration#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsMigrationMigrationConfig), fullyQualifiedName: "oci.cloudMigrationsMigration.CloudMigrationsMigrationMigrationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsMigration.ICloudMigrationsMigrationMigrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/cloud_migrations_migration#subnet_id CloudMigrationsMigration#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
