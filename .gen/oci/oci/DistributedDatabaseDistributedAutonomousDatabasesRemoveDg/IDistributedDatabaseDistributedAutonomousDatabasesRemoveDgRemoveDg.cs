using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#replica_name DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#replica_name}.</summary>
        [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#selection DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#replica_name DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#replica_name}.</summary>
            [JsiiProperty(name: "replicaName", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#selection DistributedDatabaseDistributedAutonomousDatabasesRemoveDg#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
