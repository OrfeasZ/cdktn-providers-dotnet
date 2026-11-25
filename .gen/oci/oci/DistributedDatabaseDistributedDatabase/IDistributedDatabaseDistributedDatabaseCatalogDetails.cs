using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCatalogDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetails")]
    public interface IDistributedDatabaseDistributedDatabaseCatalogDetails
    {
        /// <summary>original_replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#original_replica DistributedDatabaseDistributedDatabase#original_replica}
        /// </remarks>
        [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica\"}")]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica OriginalReplica
        {
            get;
        }

        /// <summary>data_guard_replicas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#data_guard_replicas DistributedDatabaseDistributedDatabase#data_guard_replicas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicas" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataGuardReplicas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCatalogDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>original_replica block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#original_replica DistributedDatabaseDistributedDatabase#original_replica}
            /// </remarks>
            [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica\"}")]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica OriginalReplica
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica>()!;
            }

            /// <summary>data_guard_replicas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#data_guard_replicas DistributedDatabaseDistributedDatabase#data_guard_replicas}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicas" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataGuardReplicas
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
