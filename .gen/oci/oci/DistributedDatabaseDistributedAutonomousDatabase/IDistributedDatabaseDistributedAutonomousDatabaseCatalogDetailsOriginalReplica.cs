using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica
    {
        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#database DistributedDatabaseDistributedAutonomousDatabase#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplicaDatabase\"}")]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplicaDatabase Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#database DistributedDatabaseDistributedAutonomousDatabase#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplicaDatabase\"}")]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplicaDatabase Database
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplicaDatabase>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
