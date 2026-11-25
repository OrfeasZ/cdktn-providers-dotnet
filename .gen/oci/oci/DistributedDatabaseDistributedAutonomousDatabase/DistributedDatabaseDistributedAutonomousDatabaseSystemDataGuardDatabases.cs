using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabases")]
    public class DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabases : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabases
    {
        /// <summary>original_replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#original_replica DistributedDatabaseDistributedAutonomousDatabase#original_replica}
        /// </remarks>
        [JsiiProperty(name: "originalReplica", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesOriginalReplica\"}")]
        public oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesOriginalReplica OriginalReplica
        {
            get;
            set;
        }

        private object? _dataGuardReplicas;

        /// <summary>data_guard_replicas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_guard_replicas DistributedDatabaseDistributedAutonomousDatabase#data_guard_replicas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesDataGuardReplicas" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataGuardReplicas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesDataGuardReplicas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataGuardReplicas
        {
            get => _dataGuardReplicas;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesDataGuardReplicas[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesDataGuardReplicas).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataGuardReplicas = value;
            }
        }
    }
}
