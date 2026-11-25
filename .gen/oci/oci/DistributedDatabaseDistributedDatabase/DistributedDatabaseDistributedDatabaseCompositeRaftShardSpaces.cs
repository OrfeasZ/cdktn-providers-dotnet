using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces")]
    public class DistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpaces
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#chunk_count DistributedDatabaseDistributedDatabase#chunk_count}.</summary>
        [JsiiProperty(name: "chunkCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ChunkCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#name DistributedDatabaseDistributedDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _raftClusters;

        /// <summary>raft_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#raft_clusters DistributedDatabaseDistributedDatabase#raft_clusters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "raftClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters\"},\"kind\":\"array\"}}]}}")]
        public object RaftClusters
        {
            get => _raftClusters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _raftClusters = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#replication_unit_count DistributedDatabaseDistributedDatabase#replication_unit_count}.</summary>
        [JsiiProperty(name: "replicationUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicationUnitCount
        {
            get;
            set;
        }
    }
}
