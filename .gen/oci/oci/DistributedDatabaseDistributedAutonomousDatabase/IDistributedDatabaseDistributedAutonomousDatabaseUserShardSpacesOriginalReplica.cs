using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica
    {
        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#database DistributedDatabaseDistributedAutonomousDatabase#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplicaDatabase\"}")]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplicaDatabase Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#database DistributedDatabaseDistributedAutonomousDatabase#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplicaDatabase\"}")]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplicaDatabase Database
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplicaDatabase>()!;
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
