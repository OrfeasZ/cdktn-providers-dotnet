using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#chunk_count DistributedDatabaseDistributedAutonomousDatabase#chunk_count}.</summary>
        [JsiiProperty(name: "chunkCount", typeJson: "{\"primitive\":\"number\"}")]
        double ChunkCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>raft_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#raft_clusters DistributedDatabaseDistributedAutonomousDatabase#raft_clusters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesRaftClusters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "raftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesRaftClusters\"},\"kind\":\"array\"}}]}}")]
        object RaftClusters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#replication_unit_count DistributedDatabaseDistributedAutonomousDatabase#replication_unit_count}.</summary>
        [JsiiProperty(name: "replicationUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicationUnitCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#chunk_count DistributedDatabaseDistributedAutonomousDatabase#chunk_count}.</summary>
            [JsiiProperty(name: "chunkCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ChunkCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>raft_clusters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#raft_clusters DistributedDatabaseDistributedAutonomousDatabase#raft_clusters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesRaftClusters" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "raftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesRaftClusters\"},\"kind\":\"array\"}}]}}")]
            public object RaftClusters
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#replication_unit_count DistributedDatabaseDistributedAutonomousDatabase#replication_unit_count}.</summary>
            [JsiiProperty(name: "replicationUnitCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicationUnitCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
