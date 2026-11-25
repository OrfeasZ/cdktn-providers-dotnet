using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>original_replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#original_replica DistributedDatabaseDistributedAutonomousDatabase#original_replica}
        /// </remarks>
        [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica\"}")]
        oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica OriginalReplica
        {
            get;
        }

        /// <summary>data_guard_replicas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_guard_replicas DistributedDatabaseDistributedAutonomousDatabase#data_guard_replicas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesDataGuardReplicas" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataGuardReplicas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#name DistributedDatabaseDistributedAutonomousDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>original_replica block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#original_replica DistributedDatabaseDistributedAutonomousDatabase#original_replica}
            /// </remarks>
            [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica\"}")]
            public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica OriginalReplica
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesOriginalReplica>()!;
            }

            /// <summary>data_guard_replicas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_guard_replicas DistributedDatabaseDistributedAutonomousDatabase#data_guard_replicas}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesDataGuardReplicas" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataGuardReplicas
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
