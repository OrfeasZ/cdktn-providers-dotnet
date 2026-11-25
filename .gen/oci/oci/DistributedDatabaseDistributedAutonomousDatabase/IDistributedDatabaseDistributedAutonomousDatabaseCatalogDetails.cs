using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails
    {
        /// <summary>original_replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#original_replica DistributedDatabaseDistributedAutonomousDatabase#original_replica}
        /// </remarks>
        [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica\"}")]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica OriginalReplica
        {
            get;
        }

        /// <summary>data_guard_replicas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_guard_replicas DistributedDatabaseDistributedAutonomousDatabase#data_guard_replicas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsDataGuardReplicas" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataGuardReplicas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>original_replica block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#original_replica DistributedDatabaseDistributedAutonomousDatabase#original_replica}
            /// </remarks>
            [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica\"}")]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica OriginalReplica
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOriginalReplica>()!;
            }

            /// <summary>data_guard_replicas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_guard_replicas DistributedDatabaseDistributedAutonomousDatabase#data_guard_replicas}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsDataGuardReplicas" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataGuardReplicas
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
