using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesInsertDg
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabasesInsertDgInsertDg), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDg")]
    public interface IDistributedDatabaseDistributedDatabasesInsertDgInsertDg
    {
        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#database DistributedDatabaseDistributedDatabasesInsertDg#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase\"}")]
        oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase Database
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#replica_name DistributedDatabaseDistributedDatabasesInsertDg#replica_name}.</summary>
        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#selection DistributedDatabaseDistributedDatabasesInsertDg#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabasesInsertDgInsertDg), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDg")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#database DistributedDatabaseDistributedDatabasesInsertDg#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase\"}")]
            public oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase Database
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabase>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#replica_name DistributedDatabaseDistributedDatabasesInsertDg#replica_name}.</summary>
            [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#selection DistributedDatabaseDistributedDatabasesInsertDg#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
