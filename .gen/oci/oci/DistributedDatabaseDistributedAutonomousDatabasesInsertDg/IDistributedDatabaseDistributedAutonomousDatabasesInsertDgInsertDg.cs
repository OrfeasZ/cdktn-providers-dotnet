using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg
    {
        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#database DistributedDatabaseDistributedAutonomousDatabasesInsertDg#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}")]
        oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#replica_name DistributedDatabaseDistributedAutonomousDatabasesInsertDg#replica_name}.</summary>
        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#selection DistributedDatabaseDistributedAutonomousDatabasesInsertDg#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#database DistributedDatabaseDistributedAutonomousDatabasesInsertDg#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}")]
            public oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase Database
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#replica_name DistributedDatabaseDistributedAutonomousDatabasesInsertDg#replica_name}.</summary>
            [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#selection DistributedDatabaseDistributedAutonomousDatabasesInsertDg#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
