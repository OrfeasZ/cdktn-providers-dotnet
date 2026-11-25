using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters")]
    public interface IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters
    {
        /// <summary>databases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#databases DistributedDatabaseDistributedDatabase#databases}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClustersDatabases" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClustersDatabases\"},\"kind\":\"array\"}}]}}")]
        object Databases
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#name DistributedDatabaseDistributedDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#replication_factor DistributedDatabaseDistributedDatabase#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicationFactor
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ru_mode DistributedDatabaseDistributedDatabase#ru_mode}.</summary>
        [JsiiProperty(name: "ruMode", typeJson: "{\"primitive\":\"string\"}")]
        string RuMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#witness_count DistributedDatabaseDistributedDatabase#witness_count}.</summary>
        [JsiiProperty(name: "witnessCount", typeJson: "{\"primitive\":\"number\"}")]
        double WitnessCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClusters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>databases block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#databases DistributedDatabaseDistributedDatabase#databases}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClustersDatabases" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesRaftClustersDatabases\"},\"kind\":\"array\"}}]}}")]
            public object Databases
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#name DistributedDatabaseDistributedDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#replication_factor DistributedDatabaseDistributedDatabase#replication_factor}.</summary>
            [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicationFactor
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#ru_mode DistributedDatabaseDistributedDatabase#ru_mode}.</summary>
            [JsiiProperty(name: "ruMode", typeJson: "{\"primitive\":\"string\"}")]
            public string RuMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#witness_count DistributedDatabaseDistributedDatabase#witness_count}.</summary>
            [JsiiProperty(name: "witnessCount", typeJson: "{\"primitive\":\"number\"}")]
            public double WitnessCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
